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
    public partial class FormHastaRandevu : Form
    {
        public FormHastaRandevu()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            Txtid.Text = "";
            ComboBrans.Text = "";
            ComboDoktor.Text = "";
        }
        public string TC;
        randevu_sql_baglantısı baglantı = new randevu_sql_baglantısı();
        private void FormHastaRandevu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSet10.Tbl_Randevu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_RandevuTableAdapter.Fill(this.hastaneSistemiDataSet10.Tbl_Randevu);
            // TODO: Bu kod satırı 'hastaneSistemiDataSet1.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter1.Fill(this.hastaneSistemiDataSet1.Tbl_Branslar);
           
            lblTC.Text = TC;
            // AD SOYAD ÇEKME
            SqlCommand ad = new SqlCommand("Select ad_soyad From Tbl_Hasta Where TC=@a1", baglantı.baglanti());
            ad.Parameters.AddWithValue("@a1", lblTC.Text);
            SqlDataReader dr = ad.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            baglantı.baglanti().Close();

            // Geçmiş Randevuları Çekme

             DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu Where TC=" + TC, baglantı.baglanti());
            da.Fill(dt);
            datagecmişrandevu.DataSource = dt; 

            // Extra Branşları Çekme , Dilerseniz Kod olarak çekebilirsiniz veya comboboxun veri taşımacılığını kullanabilirsiniz.
         /*   SqlCommand branscek = new SqlCommand("Select BransAd From Tbl_Branslar",baglantı.baglanti());
            SqlDataReader dr2 = branscek.ExecuteReader();
            while (dr2.Read())
            {
                ComboBrans.Items.Add(dr2[0]);
            }
            baglantı.baglanti().Close(); */
        }

        private void ComboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoktor.Items.Clear();
            SqlCommand doktorcek = new SqlCommand("Select AdSoyad From Tbl_Doktor Where Brans=@d1", baglantı.baglanti());
            doktorcek.Parameters.AddWithValue("@d1", ComboBrans.Text);
            SqlDataReader dr3 = doktorcek.ExecuteReader();
            while (dr3.Read())
            {
                ComboDoktor.Items.Add(dr3[0]);
            }

            baglantı.baglanti().Close();
        }

        private void ComboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu Where randevu_brans='" + ComboBrans.Text+"'", baglantı.baglanti());
            da.Fill(dt);
            dataktifrandevu.DataSource = dt;
        }

        private void dataktifrandevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataktifrandevu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LinkBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgiDüzenle fr = new FormHastaBilgiDüzenle();
            fr.tc = lblTC.Text;
            fr.Show();
        }

        private void dataktifrandevu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataktifrandevu.SelectedCells[0].RowIndex;
            Txtid.Text = dataktifrandevu.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevual_Click(object sender, EventArgs e)
        {
            SqlCommand randevuguncelle = new SqlCommand("Update Tbl_Randevu set Randevu_Durum=1, TC=@r1 where Randevuid=@r2",baglantı.baglanti());
            randevuguncelle.Parameters.AddWithValue("@r1", lblTC.Text);
            randevuguncelle.Parameters.AddWithValue("@r2", Txtid.Text);
            randevuguncelle.ExecuteNonQuery();
            baglantı.baglanti().Close();
            MessageBox.Show("Randevunuz Eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
