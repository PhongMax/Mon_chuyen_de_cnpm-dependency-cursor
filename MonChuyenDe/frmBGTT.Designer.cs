namespace MonChuyenDe
{
    partial class frmBGTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBGTT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cHUNGKHOANDataSet = new MonChuyenDe.CHUNGKHOANDataSet();
            this.bANG_GIA_TRUC_TUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANG_GIA_TRUC_TUYENTableAdapter = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.BANG_GIA_TRUC_TUYENTableAdapter();
            this.tableAdapterManager = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.mACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMGIA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMKL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMGIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMKL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBGIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBKL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBGIA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBKL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANG_GIA_TRUC_TUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACPDataGridViewTextBoxColumn,
            this.dMGIA2DataGridViewTextBoxColumn,
            this.dMKL2DataGridViewTextBoxColumn,
            this.dMGIA1DataGridViewTextBoxColumn,
            this.dMKL1DataGridViewTextBoxColumn,
            this.kLGIADataGridViewTextBoxColumn,
            this.kLKLDataGridViewTextBoxColumn,
            this.dBGIA1DataGridViewTextBoxColumn,
            this.dBKL1DataGridViewTextBoxColumn,
            this.dBGIA2DataGridViewTextBoxColumn,
            this.dBKL2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bANG_GIA_TRUC_TUYENBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 511);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANG_GIA_TRUC_TUYENBindingSource
            // 
            this.bANG_GIA_TRUC_TUYENBindingSource.DataMember = "BANG_GIA_TRUC_TUYEN";
            this.bANG_GIA_TRUC_TUYENBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // bANG_GIA_TRUC_TUYENTableAdapter
            // 
            this.bANG_GIA_TRUC_TUYENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANG_GIA_TRUC_TUYENTableAdapter = this.bANG_GIA_TRUC_TUYENTableAdapter;
            this.tableAdapterManager.LENHDATTableAdapter = null;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MonChuyenDe.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mACPDataGridViewTextBoxColumn
            // 
            this.mACPDataGridViewTextBoxColumn.DataPropertyName = "MACP";
            this.mACPDataGridViewTextBoxColumn.HeaderText = "MACP";
            this.mACPDataGridViewTextBoxColumn.Name = "mACPDataGridViewTextBoxColumn";
            // 
            // dMGIA2DataGridViewTextBoxColumn
            // 
            this.dMGIA2DataGridViewTextBoxColumn.DataPropertyName = "DM_GIA2";
            this.dMGIA2DataGridViewTextBoxColumn.HeaderText = "DM_GIA2";
            this.dMGIA2DataGridViewTextBoxColumn.Name = "dMGIA2DataGridViewTextBoxColumn";
            // 
            // dMKL2DataGridViewTextBoxColumn
            // 
            this.dMKL2DataGridViewTextBoxColumn.DataPropertyName = "DM_KL2";
            this.dMKL2DataGridViewTextBoxColumn.HeaderText = "DM_KL2";
            this.dMKL2DataGridViewTextBoxColumn.Name = "dMKL2DataGridViewTextBoxColumn";
            // 
            // dMGIA1DataGridViewTextBoxColumn
            // 
            this.dMGIA1DataGridViewTextBoxColumn.DataPropertyName = "DM_GIA1";
            this.dMGIA1DataGridViewTextBoxColumn.HeaderText = "DM_GIA1";
            this.dMGIA1DataGridViewTextBoxColumn.Name = "dMGIA1DataGridViewTextBoxColumn";
            // 
            // dMKL1DataGridViewTextBoxColumn
            // 
            this.dMKL1DataGridViewTextBoxColumn.DataPropertyName = "DM_KL1";
            this.dMKL1DataGridViewTextBoxColumn.HeaderText = "DM_KL1";
            this.dMKL1DataGridViewTextBoxColumn.Name = "dMKL1DataGridViewTextBoxColumn";
            // 
            // kLGIADataGridViewTextBoxColumn
            // 
            this.kLGIADataGridViewTextBoxColumn.DataPropertyName = "KL_GIA";
            this.kLGIADataGridViewTextBoxColumn.HeaderText = "KL_GIA";
            this.kLGIADataGridViewTextBoxColumn.Name = "kLGIADataGridViewTextBoxColumn";
            // 
            // kLKLDataGridViewTextBoxColumn
            // 
            this.kLKLDataGridViewTextBoxColumn.DataPropertyName = "KL_KL";
            this.kLKLDataGridViewTextBoxColumn.HeaderText = "KL_KL";
            this.kLKLDataGridViewTextBoxColumn.Name = "kLKLDataGridViewTextBoxColumn";
            // 
            // dBGIA1DataGridViewTextBoxColumn
            // 
            this.dBGIA1DataGridViewTextBoxColumn.DataPropertyName = "DB_GIA1";
            this.dBGIA1DataGridViewTextBoxColumn.HeaderText = "DB_GIA1";
            this.dBGIA1DataGridViewTextBoxColumn.Name = "dBGIA1DataGridViewTextBoxColumn";
            // 
            // dBKL1DataGridViewTextBoxColumn
            // 
            this.dBKL1DataGridViewTextBoxColumn.DataPropertyName = "DB_KL1";
            this.dBKL1DataGridViewTextBoxColumn.HeaderText = "DB_KL1";
            this.dBKL1DataGridViewTextBoxColumn.Name = "dBKL1DataGridViewTextBoxColumn";
            // 
            // dBGIA2DataGridViewTextBoxColumn
            // 
            this.dBGIA2DataGridViewTextBoxColumn.DataPropertyName = "DB_GIA2";
            this.dBGIA2DataGridViewTextBoxColumn.HeaderText = "DB_GIA2";
            this.dBGIA2DataGridViewTextBoxColumn.Name = "dBGIA2DataGridViewTextBoxColumn";
            // 
            // dBKL2DataGridViewTextBoxColumn
            // 
            this.dBKL2DataGridViewTextBoxColumn.DataPropertyName = "DB_KL2";
            this.dBKL2DataGridViewTextBoxColumn.HeaderText = "DB_KL2";
            this.dBKL2DataGridViewTextBoxColumn.Name = "dBKL2DataGridViewTextBoxColumn";
            // 
            // frmBGTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 511);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBGTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG GIÁ TRỰC TUYẾN";
            this.Load += new System.EventHandler(this.frmBGTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANG_GIA_TRUC_TUYENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource bANG_GIA_TRUC_TUYENBindingSource;
        private CHUNGKHOANDataSetTableAdapters.BANG_GIA_TRUC_TUYENTableAdapter bANG_GIA_TRUC_TUYENTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMGIA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMKL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMGIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMKL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBGIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBKL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBGIA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBKL2DataGridViewTextBoxColumn;
    }
}