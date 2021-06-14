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
    public partial class FormHastaKayıt : Form
    {
        public FormHastaKayıt()
        {
            InitializeComponent();
        }
        randevu_sql_baglantısı baglantı = new randevu_sql_baglantısı();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("Insert into Tbl_Hasta(Ad_Soyad,TC,Tel,Cinsiyet,Sifre)values (@k1,@k2,@k3,@k4,@k5)", baglantı.baglanti());
            kaydet.Parameters.AddWithValue("@k1", TxtAdSoyad.Text);
            kaydet.Parameters.AddWithValue("@k2", MaskedTC.Text);
            kaydet.Parameters.AddWithValue("@k3", MaskedTEL.Text);
            kaydet.Parameters.AddWithValue("@k4", ComboCinsiyet.Text);
            kaydet.Parameters.AddWithValue("@k5", TxtSifre.Text);
            kaydet.ExecuteNonQuery();
            baglantı.baglanti().Close();
            MessageBox.Show("Başarılı Bir Şekilde Kaydınız Alınmıştır,Lütfen Giriş Sisteminde TC ve Şifrenizi Kullanarak Giriş Yapınız.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);




        }

        private void FormHastaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
