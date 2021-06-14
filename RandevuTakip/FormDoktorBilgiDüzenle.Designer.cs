
namespace RandevuTakip
{
    partial class FormDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorBilgiDüzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.ComboBrans = new System.Windows.Forms.ComboBox();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet11 = new RandevuTakip.HastaneSistemiDataSet11();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.tbl_BranslarTableAdapter = new RandevuTakip.HastaneSistemiDataSet11TableAdapters.Tbl_BranslarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Enabled = false;
            this.MaskedTC.Location = new System.Drawing.Point(109, 20);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(180, 29);
            this.MaskedTC.TabIndex = 1;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(109, 63);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(180, 29);
            this.TxtAdSoyad.TabIndex = 2;
            // 
            // ComboBrans
            // 
            this.ComboBrans.DataSource = this.tblBranslarBindingSource;
            this.ComboBrans.DisplayMember = "BransAd";
            this.ComboBrans.FormattingEnabled = true;
            this.ComboBrans.Location = new System.Drawing.Point(109, 108);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(180, 32);
            this.ComboBrans.TabIndex = 3;
            this.ComboBrans.ValueMember = "BransAd";
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource.DataSource = this.hastaneSistemiDataSet11;
            // 
            // hastaneSistemiDataSet11
            // 
            this.hastaneSistemiDataSet11.DataSetName = "HastaneSistemiDataSet11";
            this.hastaneSistemiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(109, 154);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(180, 29);
            this.TxtSifre.TabIndex = 4;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(183, 189);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(106, 38);
            this.BtnGüncelle.TabIndex = 27;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // tbl_BranslarTableAdapter
            // 
            this.tbl_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.BtnGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(301, 235);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.ComboBrans);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDoktorBilgiDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FormDoktorBilgiDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.ComboBox ComboBrans;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGüncelle;
        private HastaneSistemiDataSet11 hastaneSistemiDataSet11;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private HastaneSistemiDataSet11TableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter;
    }
}