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
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\������\Documents\loginData.mdf; Integrated Security = True; Connect Timeout = 30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='"+ID_txt.Text+"' and PASSWORD='"+PW_txt.Text+"'",con);

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                //�α����� �������� ���
                this.Hide();

                MessageBox.Show("���õ� ������ ��Ű�� "+ID_txt.Text+"�� ȯ���մϴ�!");


                Form2 mainForm1 = new Form2();
                mainForm1.Show();
            }
            else
            {
                //�α��� ���� ��
                MessageBox.Show("���̵�� ��й�ȣ�� Ȯ�����ּ���.");
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