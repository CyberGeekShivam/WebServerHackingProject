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
    public partial class Website_Sniffing : Form
    {
        public Website_Sniffing()
        {
            InitializeComponent();
        }
        Hacking_Library.hacking hackingLibrary = new Hacking_Library.hacking();
        private void button1_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri("http://www.krishnacollege.ac.in");

            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(myUri);
            myrequest.ProtocolVersion = HttpVersion.Version10;

            HttpWebResponse myResponse = (HttpWebResponse)myrequest.GetResponse();

            richTextBox1.Text = myResponse.Headers.ToString();
            textBox1.Text = "The Destination Remote Server Is :" + myResponse.Server;
            textBox2.Text = "The Destination Remote Server Character Set Is:" + myResponse.CharacterSet;

            string contentType = myResponse.ContentType;
            string MainPageType = contentType.Substring(hackingLibrary.bytes(), contentType.IndexOf(hackingLibrary.HttpResponse()));

            if (String.Compare(MainPageType, hackingLibrary.HttpResponseText()) == 0)
            {
                textBox3.Text = "Content type is a Text Format";
            }
            else
            {
                textBox3.Text = "Content type is not a Text Format it can be in any other format";

            }
            if (myResponse.StatusCode.ToString() == "OK")
            {
                int val = 200;
                textBox4.Text = "This Status code of the Web Response is :" + val.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_For_Vulnerability_Open_Ports_In_Server portScanner = new Check_For_Vulnerability_Open_Ports_In_Server();
            portScanner.Show();
            this.Hide();
        }
    }
}
