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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("Select * From Tbl_Sekreter Where TC=@g1 And Sifre=@g2", baglanti.baglanti());
            giris.Parameters.AddWithValue("@g1", MaskTC.Text);
            giris.Parameters.AddWithValue("@g2", TxtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                FormSekreterDetay fr = new FormSekreterDetay();
                fr.tc = MaskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifrenizi Yanlış Girdiniz Lütfen Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
