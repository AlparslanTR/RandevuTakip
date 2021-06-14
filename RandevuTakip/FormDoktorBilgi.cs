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
    public partial class FormDoktorBilgi : Form
    {
        public FormDoktorBilgi()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglanti = new randevu_sql_baglantısı();
        
        public string TC;
        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FormDoktorDuyuru fr = new FormDoktorDuyuru();
            fr.Show();
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDüzenle fr = new FormDoktorBilgiDüzenle();
            fr.TC = label2.Text;
            fr.Show();

        }

        private void FormDoktorBilgi_Load(object sender, EventArgs e)
        {
            label2.Text = TC;

            //Doktor Ad Soyad Getirme
            SqlCommand adgetir = new SqlCommand("Select Adsoyad From Tbl_Doktor Where TC=@a1", baglanti.baglanti());
            adgetir.Parameters.AddWithValue("@a1", label2.Text);
            SqlDataReader dr = adgetir.ExecuteReader();
            while (dr.Read())
            {
                label5.Text = (string)dr[0];
            }
            baglanti.baglanti().Close();
            //Brans adı getirme
            SqlCommand bransgetir = new SqlCommand("Select Brans From Tbl_Doktor Where TC=@b1", baglanti.baglanti());
            bransgetir.Parameters.AddWithValue("@b1", label2.Text);
            SqlDataReader dr2 = bransgetir.ExecuteReader();
            while (dr2.Read())
            {
                label6.Text = (string)dr2[0];
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu Where Randevu_doktor='" + label5.Text+"'", baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btninternet_Click(object sender, EventArgs e)
        {
            FormDoktorInternet fr = new FormDoktorInternet();
            fr.Show();
        }
    }
}
