using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class Client1 : Form
    {
        tcpclient tcp = new tcpclient();
        public Client1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client2 client2 = new Client2();
            client2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            // ok?
            //var responce = tcp.StartClient(txtIpaddress.Text, int.Parse(txtPort.Text), txtSendData.Text);
            var responce = tcp.StartClient("10.128.61.30", 1024, textBox1.Text);
            MessageBox.Show(responce);
            textBox2.Text = responce;
            button1.Enabled = true;
        }
    }
}
