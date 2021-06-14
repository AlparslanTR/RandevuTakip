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
    public partial class FormSekreterDoktorPaneli : Form
    {
        public FormSekreterDoktorPaneli()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        public void temizle()
        {
            TxtAdSoyad.Text = "";
            ComboBrans.Text = "";
            MaskTC.Text = "";
            TxtSifre.Text = "";
        }
        private void FormSekreterDoktorPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSetBransAdları.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter.Fill(this.hastaneSistemiDataSetBransAdları.Tbl_Branslar);
            // TODO: Bu kod satırı 'hastaneSistemiDataSetdoktorbilgisi.Tbl_Doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DoktorTableAdapter.Fill(this.hastaneSistemiDataSetdoktorbilgisi.Tbl_Doktor);

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorekle = new SqlCommand("Insert into Tbl_Doktor(AdSoyad,Brans,TC,Sifre)values(@d1,@d2,@d3,@d4)", baglanti.baglanti());
            doktorekle.Parameters.AddWithValue("@d1", TxtAdSoyad.Text);
            doktorekle.Parameters.AddWithValue("@d2", ComboBrans.Text);
            doktorekle.Parameters.AddWithValue("@d3", MaskTC.Text);
            doktorekle.Parameters.AddWithValue("@d4", TxtSifre.Text);
            doktorekle.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ComboBrans.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MaskTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand doktorsil = new SqlCommand("Delete from Tbl_Doktor where TC=@s1", baglanti.baglanti());
            doktorsil.Parameters.AddWithValue("@s1", MaskTC.Text);
            doktorsil.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Silinmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorguncelle = new SqlCommand("Update Tbl_Doktor set AdSoyad=@g1,Brans=@g2,Sifre=@g4 Where TC=@g3", baglanti.baglanti());
            doktorguncelle.Parameters.AddWithValue("@g1", TxtAdSoyad.Text);
            doktorguncelle.Parameters.AddWithValue("@g2", ComboBrans.Text);
            doktorguncelle.Parameters.AddWithValue("@g3", MaskTC.Text);
            doktorguncelle.Parameters.AddWithValue("@g4", TxtSifre.Text);
            doktorguncelle.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Doktor Güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_DoktorTableAdapter.Fill(this.hastaneSistemiDataSetdoktorbilgisi.Tbl_Doktor);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            TxtAdSoyad.Focus();
        }
    }
}
