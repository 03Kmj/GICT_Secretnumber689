#include <Servo.h>    //서버모터관련 함수 사용을 위한 라이브러리 삽입 

#define POT A0    //가변저항 
#define ECHO 12    //초음파 센서의 ECHO핀 
#define TRIGGER 13    //초음파 센서의 TRIGGER핀 
#define RED_LED 4   //ICOM의 꺼지 상태를 나타냄 
#define GREEN_LED 5   //ICOM의 켜진 상태를 나타냄 
#define SERVO 7       //서보모터 

int val = 0;   //가변저항값 (폐의류의 무게로 간주함)
long duration, distance;    //초음파가 송신되고 이후 수신되어지기 까지의 시간, 계산한 거리값
int after = 0;    //사용자와 헌옷 수거함 사이의 거리가 10cm이하가 되고 경과한 시간 
int start = 0;
int check = 0;    //만약 after값이 3초과이면 check가 1이 되고 ICOM이 켜짐
                  //(즉, 3초 이상 거리값이 10cm이하이면 ICOM앞에 사용자가 도착했다고 판단) 
int flag = 0;     //사용자의 정보와 ICOM의 정보가 일치됨이 확인 되면 flag가 1이 되고 헌옷 수거함의 입구를 열어줌 

Servo S;  //서보모터를 S라는 이름으로 선언 

void setup(){
  Serial.begin(9600);     //시리얼 모니터 연결 
  
  pinMode(ECHO, INPUT);    //초음파 센서의 pinmode 
  pinMode(TRIGGER, OUTPUT);    

  pinMode(RED_LED, OUTPUT);       //LED의 pinmode
  pinMode(GREEN_LED, OUTPUT);

  S.attach(SERVO);     //서보모터 핀 설정 
  S.write(0);    //서보모터의 기본값을 0도로 설정 
}

void loop(){
  digitalWrite(RED_LED, HIGH);   //현재 ICOM은 꺼진 상태 
  digitalWrite(GREEN_LED, LOW);
  
  digitalWrite(TRIGGER,LOW);
  delayMicroseconds(2);
  digitalWrite(TRIGGER, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGGER,LOW);

  duration = pulseIn(ECHO, HIGH);
  distance = duration*34000/1000000/2;
  
  while(1){
    if(distance >= 0 && distance <= 10){
      delay(1000);
      after += 1;     // 경과 된 시간 측정 
    }
    else{
      after = 0;
      break;
    }

    if(after > 3){
      after = 0;
      check = 1;
      break;
    }
  }

  if(check == 1){
    digitalWrite(RED_LED, LOW);
    digitalWrite(GREEN_LED, HIGH);    //ICOM이 켜짐
    val = analogRead(POT);    //무게 값을 측정 
    Serial.print("\nWeight: ");
    Serial.print(val/100);      //실제 폐의류의 무게와 비슷한 무게 값이 나오도록 조정
    Serial.println(" kg");

    flag = 1;  //통신한 결과 사용자가 입력한 정보와 ICOM이 수집한 결과가 같았다고 가정 
    if(flag == 1){
      S.write(90);   //ICOM이 헌옷수거함의 입구를 10초 동안 열어줌 
      delay(10000);
      S.write(0);    //다시 헌옷 수거함 닫기 
    }
  }
  flag = 0;
  check = 0;
  after = 0;
}
