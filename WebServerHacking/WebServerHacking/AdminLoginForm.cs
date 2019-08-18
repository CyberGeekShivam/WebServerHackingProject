using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServerHacking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login Successful");
                Get_IPAddress_And__Other_Websites_By_Webserver getipaddress = new Get_IPAddress_And__Other_Websites_By_Webserver();
                getipaddress.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful Please Check the Login Credentials");
            }
        }
    }
}
