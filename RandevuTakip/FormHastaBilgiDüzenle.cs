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
    public partial class FormHastaBilgiDüzenle : Form
    {
        public FormHastaBilgiDüzenle()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglantı = new randevu_sql_baglantısı();
        public string tc;
        private void FormHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MaskedTC.Text = tc;

            SqlCommand cek = new SqlCommand("Select * From Tbl_Hasta Where TC=@c1", baglantı.baglanti());
            cek.Parameters.AddWithValue("@c1", MaskedTC.Text);
            SqlDataReader dr = cek.ExecuteReader();
            while (dr.Read())
            {
                TxtAdSoyad.Text = dr[1].ToString();
                MaskedTEL.Text = dr[3].ToString();
                ComboCinsiyet.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            baglantı.baglanti().Close();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("Update Tbl_Hasta set Ad_Soyad=@g1,Tel=@g2,Cinsiyet=@g3,Sifre=@g4 Where TC=@g5", baglantı.baglanti());
            güncelle.Parameters.AddWithValue("@g1", TxtAdSoyad.Text);
            güncelle.Parameters.AddWithValue("@g2", MaskedTEL.Text);
            güncelle.Parameters.AddWithValue("@g3", ComboCinsiyet.Text);
            güncelle.Parameters.AddWithValue("@g4", TxtSifre.Text);
            güncelle.Parameters.AddWithValue("@g5", MaskedTC.Text);
            güncelle.ExecuteNonQuery();

            baglantı.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
