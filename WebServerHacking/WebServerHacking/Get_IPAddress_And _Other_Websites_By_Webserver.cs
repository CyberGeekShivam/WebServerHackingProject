using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebServerHacking
{
    public partial class Get_IPAddress_And__Other_Websites_By_Webserver : Form
    {
        public Get_IPAddress_And__Other_Websites_By_Webserver()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Hacking_Library.hacking hackingLibrary = new Hacking_Library.hacking();
        private void button1_Click(object sender, EventArgs e)
        {
            var address = Dns.GetHostAddresses(textBox1.Text)[hackingLibrary.HostArguments()];
            textBox2.Text = address.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {  try
            {
                string ipAdd = textBox2.Text;
                textBox3.Text = hackingLibrary.GetIPAddress(ipAdd);
            }
            catch(Exception ex)
            {

            }

            }

        private void Get_IPAddress_And__Other_Websites_By_Webserver_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindProtocol_In_Sever findprotocol = new FindProtocol_In_Sever();
            findprotocol.Show();
            this.Hide();
        }
    }
}
