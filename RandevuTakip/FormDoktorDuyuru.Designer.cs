
namespace RandevuTakip
{
    partial class FormDoktorDuyuru
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duyuruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneSistemiDataSet9 = new RandevuTakip.HastaneSistemiDataSet9();
            this.tbl_DuyuruTableAdapter = new RandevuTakip.HastaneSistemiDataSet9TableAdapters.Tbl_DuyuruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyuruidDataGridViewTextBoxColumn,
            this.duyuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDuyuruBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // duyuruidDataGridViewTextBoxColumn
            // 
            this.duyuruidDataGridViewTextBoxColumn.DataPropertyName = "Duyuruid";
            this.duyuruidDataGridViewTextBoxColumn.HeaderText = "Duyuruid";
            this.duyuruidDataGridViewTextBoxColumn.Name = "duyuruidDataGridViewTextBoxColumn";
            this.duyuruidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duyuruDataGridViewTextBoxColumn
            // 
            this.duyuruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.duyuruDataGridViewTextBoxColumn.DataPropertyName = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.HeaderText = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.Name = "duyuruDataGridViewTextBoxColumn";
            this.duyuruDataGridViewTextBoxColumn.Width = 21;
            // 
            // tblDuyuruBindingSource
            // 
            this.tblDuyuruBindingSource.DataMember = "Tbl_Duyuru";
            this.tblDuyuruBindingSource.DataSource = this.hastaneSistemiDataSet9;
            // 
            // hastaneSistemiDataSet9
            // 
            this.hastaneSistemiDataSet9.DataSetName = "HastaneSistemiDataSet9";
            this.hastaneSistemiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DuyuruTableAdapter
            // 
            this.tbl_DuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoktorDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 375);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormDoktorDuyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoktorDuyuru";
            this.Load += new System.EventHandler(this.FormDoktorDuyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneSistemiDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneSistemiDataSet9 hastaneSistemiDataSet9;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource;
        private HastaneSistemiDataSet9TableAdapters.Tbl_DuyuruTableAdapter tbl_DuyuruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
    }
}