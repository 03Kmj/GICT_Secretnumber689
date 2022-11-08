using System.Data;
using System.Data.SqlClient;

namespace ICOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\강민정\Documents\loginData.mdf; Integrated Security = True; Connect Timeout = 30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='"+ID_txt.Text+"' and PASSWORD='"+PW_txt.Text+"'",con);

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                //로그인을 성공했을 경우
                this.Hide();

                MessageBox.Show("오늘도 지구를 지키는 "+ID_txt.Text+"님 환영합니다!");


                Form2 mainForm1 = new Form2();
                mainForm1.Show();
            }
            else
            {
                //로그인 실패 시
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            }

            

            
        }

        private void PW_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}