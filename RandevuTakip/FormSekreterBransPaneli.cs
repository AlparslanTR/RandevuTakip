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
    public partial class FormSekreterBransPaneli : Form
    {
        public FormSekreterBransPaneli()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        public void temizle()
        {
            TxtAd.Text = "";
        }
        private void FormSekreterBransPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSet7.Tbl_Branslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_BranslarTableAdapter.Fill(this.hastaneSistemiDataSet7.Tbl_Branslar);

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand bransekle = new SqlCommand("Insert into Tbl_Branslar (BransAd)values(@b1)", baglanti.baglanti());
            bransekle.Parameters.AddWithValue("@b1", TxtAd.Text);
            bransekle.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Branş Eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_BranslarTableAdapter.Fill(this.hastaneSistemiDataSet7.Tbl_Branslar);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand bransil = new SqlCommand("Delete from Tbl_Branslar where Bransid=@s1", baglanti.baglanti());
            bransil.Parameters.AddWithValue("@s1", txtid.Text);
            bransil.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Branş Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
