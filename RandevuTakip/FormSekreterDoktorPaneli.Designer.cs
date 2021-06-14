
namespace RandevuTakip
{
    partial class FormSekreterDoktorPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MaskTC = new System.Windows.Forms.MaskedTextBox();
            this.ComboBrans = new System.Windows.Forms.ComboBox();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSetBransAdları = new RandevuTakip.HastaneSistemiDataSetBransAdları();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSetdoktorbilgisi = new RandevuTakip.HastaneSistemiDataSetdoktorbilgisi();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.tbl_DoktorTableAdapter = new RandevuTakip.HastaneSistemiDataSetdoktorbilgisiTableAdapters.Tbl_DoktorTableAdapter();
            this.hastaneSistemiDataSet1 = new RandevuTakip.HastaneSistemiDataSet1();
            this.hastaneSistemiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BranslarTableAdapter = new RandevuTakip.HastaneSistemiDataSetBransAdlarıTableAdapters.Tbl_BranslarTableAdapter();
            this.BtnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdları)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetdoktorbilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(95, 17);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(158, 29);
            this.TxtAdSoyad.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(95, 152);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(158, 29);
            this.TxtSifre.TabIndex = 4;
            // 
            // MaskTC
            // 
            this.MaskTC.Location = new System.Drawing.Point(95, 106);
            this.MaskTC.Mask = "00000000000";
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(158, 29);
            this.MaskTC.TabIndex = 3;
            this.MaskTC.ValidatingType = typeof(int);
            // 
            // ComboBrans
            // 
            this.ComboBrans.DataSource = this.tblBranslarBindingSource;
            this.ComboBrans.DisplayMember = "BransAd";
            this.ComboBrans.FormattingEnabled = true;
            this.ComboBrans.Location = new System.Drawing.Point(95, 64);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(158, 32);
            this.ComboBrans.TabIndex = 2;
            this.ComboBrans.ValueMember = "BransAd";
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource.DataSource = this.hastaneSistemiDataSetBransAdları;
            // 
            // hastaneSistemiDataSetBransAdları
            // 
            this.hastaneSistemiDataSetBransAdları.DataSetName = "HastaneSistemiDataSetBransAdları";
            this.hastaneSistemiDataSetBransAdları.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktoridDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 327);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            this.doktoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "Adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "Adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // bransDataGridViewTextBoxColumn
            // 
            this.bransDataGridViewTextBoxColumn.DataPropertyName = "Brans";
            this.bransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.bransDataGridViewTextBoxColumn.Name = "bransDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // tblDoktorBindingSource
            // 
            this.tblDoktorBindingSource.DataMember = "Tbl_Doktor";
            this.tblDoktorBindingSource.DataSource = this.hastaneSistemiDataSetdoktorbilgisi;
            // 
            // hastaneSistemiDataSetdoktorbilgisi
            // 
            this.hastaneSistemiDataSetdoktorbilgisi.DataSetName = "HastaneSistemiDataSetdoktorbilgisi";
            this.hastaneSistemiDataSetdoktorbilgisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(4, 219);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 38);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(87, 219);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(65, 38);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(158, 219);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(95, 38);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(12, 276);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(110, 36);
            this.BtnTemizle.TabIndex = 12;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // tbl_DoktorTableAdapter
            // 
            this.tbl_DoktorTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneSistemiDataSet1
            // 
            this.hastaneSistemiDataSet1.DataSetName = "HastaneSistemiDataSet1";
            this.hastaneSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneSistemiDataSet1BindingSource
            // 
            this.hastaneSistemiDataSet1BindingSource.DataSource = this.hastaneSistemiDataSet1;
            this.hastaneSistemiDataSet1BindingSource.Position = 0;
            // 
            // tbl_BranslarTableAdapter
            // 
            this.tbl_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // BtnYenile
            // 
            this.BtnYenile.Location = new System.Drawing.Point(143, 276);
            this.BtnYenile.Name = "BtnYenile";
            this.BtnYenile.Size = new System.Drawing.Size(110, 36);
            this.BtnYenile.TabIndex = 13;
            this.BtnYenile.Text = "Yenile";
            this.BtnYenile.UseVisualStyleBackColor = true;
            this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            // 
            // FormSekreterDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1064, 340);
            this.Controls.Add(this.BtnYenile);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBrans);
            this.Controls.Add(this.MaskTC);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormSekreterDoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Doktor Ekleme";
            this.Load += new System.EventHandler(this.FormSekreterDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdları)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetdoktorbilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MaskTC;
        private System.Windows.Forms.ComboBox ComboBrans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnTemizle;
        private HastaneSistemiDataSetdoktorbilgisi hastaneSistemiDataSetdoktorbilgisi;
        private System.Windows.Forms.BindingSource tblDoktorBindingSource;
        private HastaneSistemiDataSetdoktorbilgisiTableAdapters.Tbl_DoktorTableAdapter tbl_DoktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private HastaneSistemiDataSet1 hastaneSistemiDataSet1;
        private System.Windows.Forms.BindingSource hastaneSistemiDataSet1BindingSource;
        private HastaneSistemiDataSetBransAdları hastaneSistemiDataSetBransAdları;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private HastaneSistemiDataSetBransAdlarıTableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter;
        private System.Windows.Forms.Button BtnYenile;
    }
}