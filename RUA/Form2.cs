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
using Newtonsoft.Json;

namespace RUA
{
    public partial class Form2 : Form
    {

        public Form2(string user)
        {
            InitializeComponent();
            string username = user;
            labanmetag.Text = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            string urlprofile = "https://www.reddit.com/user/{0}/about.json";
            string fed = string.Format(urlprofile, labanmetag.Text);
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData(fed);

            string webData = System.Text.Encoding.UTF8.GetString(raw);
            
            dynamic stuff = JsonConvert.DeserializeObject(webData);
            labanmetag.Text = stuff.data.name;
           
            if (stuff.data.is_employee == "True") { lblAdmin.Visible = true; }
            if (stuff.data.is_mod == "True") { lblMod.Visible = true; }
            if (stuff.data.is_gold == "True") { lblPremium.Visible = true; }
            if (stuff.data.subreddit.over_18 == "True") { lblNsfw.Visible = true; }
            lblKarmaTotal.Text = (stuff.data.total_karma).ToString();
            lblKarmaLink.Text = (stuff.data.link_karma).ToString();
            lblKarmaComment.Text = (stuff.data.comment_karma).ToString();
            lblKarmaAward.Text = (stuff.data.awardee_karma+ stuff.data.awarder_karma).ToString();
            lblDescription.Text = (stuff.data.subreddit.public_description).ToString();
            lblDescription.Text = lblDescription.Text.Replace("\n", "");


            double timestamp = stuff.data.created;
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timestamp);
            string printDate = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
            lblCreatedOn.Text = printDate;
        }


    }
}
