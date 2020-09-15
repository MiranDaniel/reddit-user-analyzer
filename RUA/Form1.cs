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
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace RUA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (labname.Text != "Account found.")
            {
                Cursor = Cursors.WaitCursor;
                //labname.Text = tboname.Text.Replace("/u/","u/").Replace("u/","");
                string urlprofile = "https://www.reddit.com/user/{0}.json";
                string fed = string.Format(urlprofile, tboname.Text.Replace("/u/", "u/").Replace("u/", ""));

                WebRequest request = WebRequest.Create(fed);
                try
                {
                    WebResponse response = request.GetResponse();
                    labname.Text = (((HttpWebResponse)response).StatusDescription);
                    labname.Text = "Account found.";
                }
                catch
                {
                    labname.Text = "Account not found.";
                }
                Cursor = Cursors.Arrow;
            }
            else
            {
                string user = tboname.Text.Replace("/u/", "u/").Replace("u/", "").ToString();
                this.Hide();
                var form2 = new Form2(user);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
    }
}