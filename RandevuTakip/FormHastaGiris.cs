using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandevuTakip
{
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglantı = new randevu_sql_baglantısı();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayıt fr = new FormHastaKayıt();
            fr.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("Select * From Tbl_Hasta Where TC=@g1 and Sifre=@g2",baglantı.baglanti());
            giris.Parameters.AddWithValue("@g1", MaskedTC.Text);
            giris.Parameters.AddWithValue("@g2", TxtSifre.Text);

            SqlDataReader gr = giris.ExecuteReader();
            if (gr.Read())
            {
                FormHastaRandevu fr = new FormHastaRandevu();
                fr.TC = MaskedTC.Text;
 
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifrenizi Yanlış Girdiniz Lütfen Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglantı.baglanti().Close();
        }
    }
}
