using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;



namespace ICOM
{
    public partial class Present : Form
    {
        MqttClient client;
        string clientld;


        public Present()
        {
            InitializeComponent();
        }

        private void Present_Load(object sender, EventArgs e)
        {
            string BrokerAddress = "broker.mqtt-dashboard.com";
            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;


            clientld = Guid.NewGuid().ToString();
            client.Connect(clientld);

            client.Subscribe(new string[] {"outNock" }, new byte[] { 0 });
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

            label1.Text = ReceivedMessage;


        }

        private void Present_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Disconnect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 mainForm1 = new Form2();
            mainForm1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 Present = new Form3();
            Present.Show();

        }
    }
}
