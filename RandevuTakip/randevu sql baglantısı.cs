using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace RandevuTakip
{
    class randevu_sql_baglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-38ER4CK\\SQLEXPRESS;Initial Catalog=HastaneSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
