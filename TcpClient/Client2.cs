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
    public partial class Client2 : Form
    {
        public Client2()
        {
            InitializeComponent();
            textBox1.Text = "192.168.11.2";
            textBox2.Text = "1024";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
