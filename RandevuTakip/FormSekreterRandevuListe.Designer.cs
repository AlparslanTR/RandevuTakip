
namespace RandevuTakip
{
    partial class FormSekreterRandevuListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterRandevuListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevutarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevusaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevubransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevudoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevudurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet8 = new RandevuTakip.HastaneSistemiDataSet8();
            this.tbl_RandevuTableAdapter = new RandevuTakip.HastaneSistemiDataSet8TableAdapters.Tbl_RandevuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.randevutarihDataGridViewTextBoxColumn,
            this.randevusaatDataGridViewTextBoxColumn,
            this.randevubransDataGridViewTextBoxColumn,
            this.randevudoktorDataGridViewTextBoxColumn,
            this.randevudurumDataGridViewCheckBoxColumn,
            this.tCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRandevuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1091, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // randevutarihDataGridViewTextBoxColumn
            // 
            this.randevutarihDataGridViewTextBoxColumn.DataPropertyName = "Randevu_tarih";
            this.randevutarihDataGridViewTextBoxColumn.HeaderText = "Randevu_tarih";
            this.randevutarihDataGridViewTextBoxColumn.Name = "randevutarihDataGridViewTextBoxColumn";
            // 
            // randevusaatDataGridViewTextBoxColumn
            // 
            this.randevusaatDataGridViewTextBoxColumn.DataPropertyName = "Randevu_saat";
            this.randevusaatDataGridViewTextBoxColumn.HeaderText = "Randevu_saat";
            this.randevusaatDataGridViewTextBoxColumn.Name = "randevusaatDataGridViewTextBoxColumn";
            // 
            // randevubransDataGridViewTextBoxColumn
            // 
            this.randevubransDataGridViewTextBoxColumn.DataPropertyName = "Randevu_brans";
            this.randevubransDataGridViewTextBoxColumn.HeaderText = "Randevu_brans";
            this.randevubransDataGridViewTextBoxColumn.Name = "randevubransDataGridViewTextBoxColumn";
            // 
            // randevudoktorDataGridViewTextBoxColumn
            // 
            this.randevudoktorDataGridViewTextBoxColumn.DataPropertyName = "Randevu_doktor";
            this.randevudoktorDataGridViewTextBoxColumn.HeaderText = "Randevu_doktor";
            this.randevudoktorDataGridViewTextBoxColumn.Name = "randevudoktorDataGridViewTextBoxColumn";
            // 
            // randevudurumDataGridViewCheckBoxColumn
            // 
            this.randevudurumDataGridViewCheckBoxColumn.DataPropertyName = "Randevu_durum";
            this.randevudurumDataGridViewCheckBoxColumn.HeaderText = "Randevu_durum";
            this.randevudurumDataGridViewCheckBoxColumn.Name = "randevudurumDataGridViewCheckBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // tblRandevuBindingSource
            // 
            this.tblRandevuBindingSource.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource.DataSource = this.hastaneSistemiDataSet8;
            // 
            // hastaneSistemiDataSet8
            // 
            this.hastaneSistemiDataSet8.DataSetName = "HastaneSistemiDataSet8";
            this.hastaneSistemiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RandevuTableAdapter
            // 
            this.tbl_RandevuTableAdapter.ClearBeforeFill = true;
            // 
            // FormSekreterRandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1091, 463);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormSekreterRandevuListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Randevu Listesi";
            this.Load += new System.EventHandler(this.FormSekreterRandevuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneSistemiDataSet8 hastaneSistemiDataSet8;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource;
        private HastaneSistemiDataSet8TableAdapters.Tbl_RandevuTableAdapter tbl_RandevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevutarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevusaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevubransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevudoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevudurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
    }
}