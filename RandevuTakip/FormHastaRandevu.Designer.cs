
namespace RandevuTakip
{
    partial class FormHastaRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaRandevu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkBilgi = new System.Windows.Forms.LinkLabel();
            this.BtnRandevual = new System.Windows.Forms.Button();
            this.ComboDoktor = new System.Windows.Forms.ComboBox();
            this.ComboBrans = new System.Windows.Forms.ComboBox();
            this.tblBranslarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet1 = new RandevuTakip.HastaneSistemiDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagecmişrandevu = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataktifrandevu = new System.Windows.Forms.DataGridView();
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevutarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevusaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevubransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevudoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevudurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet10 = new RandevuTakip.HastaneSistemiDataSet10();
            this.hastaneSistemiDataSet = new RandevuTakip.HastaneSistemiDataSet1();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BranslarTableAdapter = new RandevuTakip.HastaneSistemiDataSet1TableAdapters.Tbl_BranslarTableAdapter();
            this.tbl_BranslarTableAdapter1 = new RandevuTakip.HastaneSistemiDataSet1TableAdapters.Tbl_BranslarTableAdapter();
            this.tbl_RandevuTableAdapter = new RandevuTakip.HastaneSistemiDataSet10TableAdapters.Tbl_RandevuTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagecmişrandevu)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataktifrandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgisi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(152, 59);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(106, 24);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "AD SOYAD";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(58, 35);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 24);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.Txtid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LinkBilgi);
            this.groupBox2.Controls.Add(this.BtnRandevual);
            this.groupBox2.Controls.Add(this.ComboDoktor);
            this.groupBox2.Controls.Add(this.ComboBrans);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(2, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(121, 145);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(118, 33);
            this.BtnTemizle.TabIndex = 17;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(140, 37);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(184, 29);
            this.Txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Randevu İd:";
            // 
            // LinkBilgi
            // 
            this.LinkBilgi.AutoSize = true;
            this.LinkBilgi.Location = new System.Drawing.Point(6, 157);
            this.LinkBilgi.Name = "LinkBilgi";
            this.LinkBilgi.Size = new System.Drawing.Size(120, 24);
            this.LinkBilgi.TabIndex = 14;
            this.LinkBilgi.TabStop = true;
            this.LinkBilgi.Text = "Bilgi Düzenle";
            this.LinkBilgi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBilgi_LinkClicked);
            // 
            // BtnRandevual
            // 
            this.BtnRandevual.Location = new System.Drawing.Point(245, 145);
            this.BtnRandevual.Name = "BtnRandevual";
            this.BtnRandevual.Size = new System.Drawing.Size(118, 33);
            this.BtnRandevual.TabIndex = 2;
            this.BtnRandevual.Text = "Randevu Al";
            this.BtnRandevual.UseVisualStyleBackColor = true;
            this.BtnRandevual.Click += new System.EventHandler(this.BtnRandevual_Click);
            // 
            // ComboDoktor
            // 
            this.ComboDoktor.FormattingEnabled = true;
            this.ComboDoktor.Location = new System.Drawing.Point(140, 110);
            this.ComboDoktor.Name = "ComboDoktor";
            this.ComboDoktor.Size = new System.Drawing.Size(187, 32);
            this.ComboDoktor.TabIndex = 3;
            this.ComboDoktor.SelectedIndexChanged += new System.EventHandler(this.ComboDoktor_SelectedIndexChanged);
            // 
            // ComboBrans
            // 
            this.ComboBrans.DataSource = this.tblBranslarBindingSource1;
            this.ComboBrans.DisplayMember = "BransAd";
            this.ComboBrans.FormattingEnabled = true;
            this.ComboBrans.Location = new System.Drawing.Point(140, 72);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(187, 32);
            this.ComboBrans.TabIndex = 2;
            this.ComboBrans.ValueMember = "BransAd";
            this.ComboBrans.SelectedIndexChanged += new System.EventHandler(this.ComboBrans_SelectedIndexChanged);
            // 
            // tblBranslarBindingSource1
            // 
            this.tblBranslarBindingSource1.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource1.DataSource = this.hastaneSistemiDataSet1;
            // 
            // hastaneSistemiDataSet1
            // 
            this.hastaneSistemiDataSet1.DataSetName = "HastaneSistemiDataSet1";
            this.hastaneSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "BRANŞ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagecmişrandevu);
            this.groupBox3.Location = new System.Drawing.Point(371, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Randevular";
            // 
            // datagecmişrandevu
            // 
            this.datagecmişrandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datagecmişrandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagecmişrandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagecmişrandevu.Location = new System.Drawing.Point(3, 25);
            this.datagecmişrandevu.Name = "datagecmişrandevu";
            this.datagecmişrandevu.Size = new System.Drawing.Size(593, 274);
            this.datagecmişrandevu.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataktifrandevu);
            this.groupBox4.Location = new System.Drawing.Point(2, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(968, 215);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataktifrandevu
            // 
            this.dataktifrandevu.AutoGenerateColumns = false;
            this.dataktifrandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataktifrandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataktifrandevu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.randevutarihDataGridViewTextBoxColumn,
            this.randevusaatDataGridViewTextBoxColumn,
            this.randevubransDataGridViewTextBoxColumn,
            this.randevudoktorDataGridViewTextBoxColumn,
            this.randevudurumDataGridViewCheckBoxColumn,
            this.tCDataGridViewTextBoxColumn});
            this.dataktifrandevu.DataSource = this.tblRandevuBindingSource;
            this.dataktifrandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataktifrandevu.Location = new System.Drawing.Point(3, 25);
            this.dataktifrandevu.Name = "dataktifrandevu";
            this.dataktifrandevu.ReadOnly = true;
            this.dataktifrandevu.Size = new System.Drawing.Size(962, 187);
            this.dataktifrandevu.TabIndex = 1;
            this.dataktifrandevu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataktifrandevu_CellContentClick);
            this.dataktifrandevu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataktifrandevu_CellDoubleClick);
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuidDataGridViewTextBoxColumn.Width = 126;
            // 
            // randevutarihDataGridViewTextBoxColumn
            // 
            this.randevutarihDataGridViewTextBoxColumn.DataPropertyName = "Randevu_tarih";
            this.randevutarihDataGridViewTextBoxColumn.HeaderText = "Randevu_tarih";
            this.randevutarihDataGridViewTextBoxColumn.Name = "randevutarihDataGridViewTextBoxColumn";
            this.randevutarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevutarihDataGridViewTextBoxColumn.Width = 156;
            // 
            // randevusaatDataGridViewTextBoxColumn
            // 
            this.randevusaatDataGridViewTextBoxColumn.DataPropertyName = "Randevu_saat";
            this.randevusaatDataGridViewTextBoxColumn.HeaderText = "Randevu_saat";
            this.randevusaatDataGridViewTextBoxColumn.Name = "randevusaatDataGridViewTextBoxColumn";
            this.randevusaatDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevusaatDataGridViewTextBoxColumn.Width = 154;
            // 
            // randevubransDataGridViewTextBoxColumn
            // 
            this.randevubransDataGridViewTextBoxColumn.DataPropertyName = "Randevu_brans";
            this.randevubransDataGridViewTextBoxColumn.HeaderText = "Randevu_brans";
            this.randevubransDataGridViewTextBoxColumn.Name = "randevubransDataGridViewTextBoxColumn";
            this.randevubransDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevubransDataGridViewTextBoxColumn.Width = 168;
            // 
            // randevudoktorDataGridViewTextBoxColumn
            // 
            this.randevudoktorDataGridViewTextBoxColumn.DataPropertyName = "Randevu_doktor";
            this.randevudoktorDataGridViewTextBoxColumn.HeaderText = "Randevu_doktor";
            this.randevudoktorDataGridViewTextBoxColumn.Name = "randevudoktorDataGridViewTextBoxColumn";
            this.randevudoktorDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevudoktorDataGridViewTextBoxColumn.Width = 173;
            // 
            // randevudurumDataGridViewCheckBoxColumn
            // 
            this.randevudurumDataGridViewCheckBoxColumn.DataPropertyName = "Randevu_durum";
            this.randevudurumDataGridViewCheckBoxColumn.HeaderText = "Randevu_durum";
            this.randevudurumDataGridViewCheckBoxColumn.Name = "randevudurumDataGridViewCheckBoxColumn";
            this.randevudurumDataGridViewCheckBoxColumn.ReadOnly = true;
            this.randevudurumDataGridViewCheckBoxColumn.Width = 157;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCDataGridViewTextBoxColumn.Width = 60;
            // 
            // tblRandevuBindingSource
            // 
            this.tblRandevuBindingSource.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource.DataSource = this.hastaneSistemiDataSet10;
            // 
            // hastaneSistemiDataSet10
            // 
            this.hastaneSistemiDataSet10.DataSetName = "HastaneSistemiDataSet10";
            this.hastaneSistemiDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneSistemiDataSet
            // 
            this.hastaneSistemiDataSet.DataSetName = "HastaneSistemiDataSet";
            this.hastaneSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource.DataSource = this.hastaneSistemiDataSet;
            // 
            // tbl_BranslarTableAdapter
            // 
            this.tbl_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_BranslarTableAdapter1
            // 
            this.tbl_BranslarTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_RandevuTableAdapter
            // 
            this.tbl_RandevuTableAdapter.ClearBeforeFill = true;
            // 
            // FormHastaRandevu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(972, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormHastaRandevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Randevu Alma";
            this.Load += new System.EventHandler(this.FormHastaRandevu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagecmişrandevu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataktifrandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRandevual;
        private System.Windows.Forms.ComboBox ComboDoktor;
        private System.Windows.Forms.ComboBox ComboBrans;
        private System.Windows.Forms.LinkLabel LinkBilgi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView datagecmişrandevu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataktifrandevu;
        private HastaneSistemiDataSet1 hastaneSistemiDataSet;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private HastaneSistemiDataSet1TableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter;
        private HastaneSistemiDataSet1 hastaneSistemiDataSet1;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource1;
        private HastaneSistemiDataSet1TableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter1;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label3;
        private HastaneSistemiDataSet10 hastaneSistemiDataSet10;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource;
        private HastaneSistemiDataSet10TableAdapters.Tbl_RandevuTableAdapter tbl_RandevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevutarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevusaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevubransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevudoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevudurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnTemizle;
    }
}