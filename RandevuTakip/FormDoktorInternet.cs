using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandevuTakip
{
    public partial class FormDoktorInternet : Form
    {
        public FormDoktorInternet()
        {
            InitializeComponent();
        }

        private void FormDoktorInternet_Load(object sender, EventArgs e)
        {

        }

        private void googlecomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void pOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=o5WVg8lC7ig");
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }

        private void rAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=-fWAlXBXG1k");
        }

        private void sLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=oEfPse8H2p4");
        }

        private void yABANCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=IF70iqaTiRY");
        }

        private void doktorsitesicomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.doktorsitesi.com/icerikler/soru");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/?lang=tr");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/?hl=tr");
        }
    }
}
