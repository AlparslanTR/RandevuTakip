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
    public partial class FormDoktorBilgiDüzenle : Form
    {
        public FormDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        public string TC;
        private void FormDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSet11.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter.Fill(this.hastaneSistemiDataSet11.Tbl_Branslar);
            MaskedTC.Text = TC;

            SqlCommand bglgetir = new SqlCommand("Select * From Tbl_Doktor Where TC=@b1", baglanti.baglanti());
            bglgetir.Parameters.AddWithValue("@b1", MaskedTC.Text);

            SqlDataReader dr = bglgetir.ExecuteReader();
            while (dr.Read())
            {
                TxtAdSoyad.Text = dr[1].ToString();
                TxtSifre.Text = dr[4].ToString();
                baglanti.baglanti().Close();
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Doktor set Adsoyad=@g1,Brans=@g2,sifre=@g3 Where TC=@g4", baglanti.baglanti());
            guncelle.Parameters.AddWithValue("@g1", TxtAdSoyad.Text);
            guncelle.Parameters.AddWithValue("@g2", ComboBrans.Text);
            guncelle.Parameters.AddWithValue("@g3",TxtSifre.Text);
            guncelle.Parameters.AddWithValue("@g4", MaskedTC.Text);
            guncelle.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
