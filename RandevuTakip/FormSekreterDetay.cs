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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        public void temizle()
        {
            Textid.Text = "";
            MaskTarih.Text = "";
            MaskSaat.Text = "";
            ComboBrans.Text = "";
            ComboDoktor.Text = "";
            Textid.Focus();
        }

        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSet6.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter2.Fill(this.hastaneSistemiDataSet6.Tbl_Branslar);
            // TODO: Bu kod satırı 'hastaneSistemiDataSet5.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter1.Fill(this.hastaneSistemiDataSet5.Tbl_Branslar);
            // TODO: Bu kod satırı 'hastaneSistemiDataSet4.Tbl_Doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DoktorTableAdapter2.Fill(this.hastaneSistemiDataSet4.Tbl_Doktor);
            // TODO: Bu kod satırı 'hastaneSistemiDataSet3.Tbl_Doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DoktorTableAdapter1.Fill(this.hastaneSistemiDataSet3.Tbl_Doktor);
            
            // TC çekme
            label3.Text = tc;

            //AD ÇEKME
            SqlCommand adcek = new SqlCommand("Select AdSoyad From Tbl_Sekreter Where TC=@a1", baglanti.baglanti());
            adcek.Parameters.AddWithValue("@a1", label3.Text);
            SqlDataReader dr = adcek.ExecuteReader();

            while (dr.Read())
            {
                label4.Text = dr[0].ToString();
            }
            baglanti.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into Tbl_Randevu (Randevu_tarih,Randevu_saat,Randevu_brans,Randevu_doktor)values (@e1,@e2,@e3,@e4)", baglanti.baglanti());
            ekle.Parameters.AddWithValue("@e1",MaskTarih.Text);
            ekle.Parameters.AddWithValue("@e2",MaskSaat.Text);
            ekle.Parameters.AddWithValue("@e3",ComboBrans.Text);
            ekle.Parameters.AddWithValue("@e4",ComboDoktor.Text);
            ekle.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Randevu Eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoktor.Items.Clear();
            SqlCommand bransdoktor = new SqlCommand("Select Adsoyad From Tbl_Doktor Where Brans=@b1",baglanti.baglanti());
            bransdoktor.Parameters.AddWithValue("@b1", ComboBrans.Text);
            SqlDataReader dr = bransdoktor.ExecuteReader();
            while (dr.Read())
            {
                ComboDoktor.Items.Add(dr[0]);
            }
            baglanti.baglanti().Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruolustur = new SqlCommand("Insert into Tbl_Duyuru(Duyuru)values(@d1)", baglanti.baglanti());
            duyuruolustur.Parameters.AddWithValue("@d1", richTextBox1.Text);
            duyuruolustur.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturulmuştur.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FormSekreterDoktorPaneli frm = new FormSekreterDoktorPaneli();
            frm.Show();

        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_DoktorTableAdapter1.Fill(this.hastaneSistemiDataSet3.Tbl_Doktor);
            this.tbl_BranslarTableAdapter2.Fill(this.hastaneSistemiDataSet6.Tbl_Branslar);
        }

        private void BtnBrans_Click(object sender, EventArgs e)
        {
            FormSekreterBransPaneli frm2 = new FormSekreterBransPaneli();
            frm2.Show();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            FormSekreterRandevuListe frm3 = new FormSekreterRandevuListe();
            frm3.Show();
        }
    }
}
