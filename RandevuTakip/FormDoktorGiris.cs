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
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("Select * From Tbl_Doktor Where TC=@g1 and Sifre=@g2",baglanti.baglanti());
            giris.Parameters.AddWithValue("@g1", MaskTC.Text);
            giris.Parameters.AddWithValue("@g2", TxtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                FormDoktorBilgi fr = new FormDoktorBilgi();
                fr.TC = MaskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifreniz Yanlış Tekrar Deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.baglanti().Close();
        }
    }
}
