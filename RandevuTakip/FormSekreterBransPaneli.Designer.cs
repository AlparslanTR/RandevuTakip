
namespace RandevuTakip
{
    partial class FormSekreterBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterBransPaneli));
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bransidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet7 = new RandevuTakip.HastaneSistemiDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaneSistemiDataSetBransAdları = new RandevuTakip.HastaneSistemiDataSetBransAdları();
            this.hastaneSistemiDataSetBransAdlarıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BranslarTableAdapter = new RandevuTakip.HastaneSistemiDataSet7TableAdapters.Tbl_BranslarTableAdapter();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnYenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdları)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdlarıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(61, 203);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(131, 36);
            this.BtnTemizle.TabIndex = 25;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(61, 159);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(131, 38);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(61, 115);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(131, 38);
            this.BtnEkle.TabIndex = 22;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransidDataGridViewTextBoxColumn,
            this.bransAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBranslarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(255, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 279);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bransidDataGridViewTextBoxColumn
            // 
            this.bransidDataGridViewTextBoxColumn.DataPropertyName = "Bransid";
            this.bransidDataGridViewTextBoxColumn.HeaderText = "Bransid";
            this.bransidDataGridViewTextBoxColumn.Name = "bransidDataGridViewTextBoxColumn";
            this.bransidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bransAdDataGridViewTextBoxColumn
            // 
            this.bransAdDataGridViewTextBoxColumn.DataPropertyName = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.HeaderText = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.Name = "bransAdDataGridViewTextBoxColumn";
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataMember = "Tbl_Branslar";
            this.tblBranslarBindingSource.DataSource = this.hastaneSistemiDataSet7;
            // 
            // hastaneSistemiDataSet7
            // 
            this.hastaneSistemiDataSet7.DataSetName = "HastaneSistemiDataSet7";
            this.hastaneSistemiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Branş Ad:";
            // 
            // hastaneSistemiDataSetBransAdları
            // 
            this.hastaneSistemiDataSetBransAdları.DataSetName = "HastaneSistemiDataSetBransAdları";
            this.hastaneSistemiDataSetBransAdları.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneSistemiDataSetBransAdlarıBindingSource
            // 
            this.hastaneSistemiDataSetBransAdlarıBindingSource.DataSource = this.hastaneSistemiDataSetBransAdları;
            this.hastaneSistemiDataSetBransAdlarıBindingSource.Position = 0;
            // 
            // tbl_BranslarTableAdapter
            // 
            this.tbl_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(91, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(158, 29);
            this.TxtAd.TabIndex = 1;
            // 
            // BtnYenile
            // 
            this.BtnYenile.Location = new System.Drawing.Point(61, 245);
            this.BtnYenile.Name = "BtnYenile";
            this.BtnYenile.Size = new System.Drawing.Size(131, 36);
            this.BtnYenile.TabIndex = 28;
            this.BtnYenile.Text = "Yenile";
            this.BtnYenile.UseVisualStyleBackColor = true;
            this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Branş İd:";
            this.label1.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(91, 71);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(158, 29);
            this.txtid.TabIndex = 2;
            this.txtid.Visible = false;
            // 
            // FormSekreterBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(658, 283);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYenile);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormSekreterBransPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Branş Ekle";
            this.Load += new System.EventHandler(this.FormSekreterBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdları)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSetBransAdlarıBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private HastaneSistemiDataSetBransAdları hastaneSistemiDataSetBransAdları;
        private System.Windows.Forms.BindingSource hastaneSistemiDataSetBransAdlarıBindingSource;
        private HastaneSistemiDataSet7 hastaneSistemiDataSet7;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private HastaneSistemiDataSet7TableAdapters.Tbl_BranslarTableAdapter tbl_BranslarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnYenile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}