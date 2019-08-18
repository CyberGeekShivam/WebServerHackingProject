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
    public partial class FindProtocol_In_Sever : Form
    {
        public FindProtocol_In_Sever()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri("http://www.krishnacollege.ac.in");

            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(myUri);
            myrequest.ProtocolVersion = HttpVersion.Version10;

            HttpWebResponse myResponse = (HttpWebResponse)myrequest.GetResponse();

            if(myResponse.ProtocolVersion!=HttpVersion.Version10)
            {

                textBox1.Text = myResponse.ProtocolVersion.Minor.ToString();
                textBox2.Text = myResponse.ProtocolVersion.Major.ToString();
                textBox3.Text = "http" + myResponse.ProtocolVersion.ToString();
                
            }
            if(myResponse.StatusCode == HttpStatusCode.OK)
            {
                textBox4.Text = "Response sent using" + textBox3.Text + "Successfully received response with the version of" + textBox3.Text;
            }
            myResponse.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Website_Sniffing website_Sniffing = new Website_Sniffing();
            website_Sniffing.Show();
            this.Hide();
        }
    }
}
