using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandevuTakip
{
    public partial class FormDoktorDuyuru : Form
    {
        public FormDoktorDuyuru()
        {
            InitializeComponent();
        }

        private void FormDoktorDuyuru_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneSistemiDataSet9.Tbl_Duyuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DuyuruTableAdapter.Fill(this.hastaneSistemiDataSet9.Tbl_Duyuru);

        }
    }
}
