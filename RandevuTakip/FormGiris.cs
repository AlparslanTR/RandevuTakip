using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandevuTakip
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            FormHastaGiris fr = new FormHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr = new FormSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
