using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Facebook_Desktop
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem18_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.twitter.com");
        }

        private void radMenuItem20_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://m.facebook.com");
        }

        private void radMenuItem21_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://touch.facebook.com");
        }

        private void radMenuItem22_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.googleplus.com");
        }

        private void radMenuItem23_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.flickr.com");
        }

        private void radMenuItem24_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://m.youtube.com");
        }

        private void radMenuItem25_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.vimeo.com");
        }

        private void radMenuItem15_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("https://mail.live.com/m/");
        }

        private void radMenuItem26_Click(object sender, EventArgs e)
        {
           browser.Url = new Uri("https://m.google.com/");
        }

        private void radMenuItem17_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.github.com/horaciogarza");
        }

        private void radMenuItem27_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://m.twitter.com/horaciogza");
        }
    }
}
