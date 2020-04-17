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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBGTT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cHUNGKHOANDataSet = new MonChuyenDe.CHUNGKHOANDataSet();
            this.bANG_GIA_TRUC_TUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANG_GIA_TRUC_TUYENTableAdapter = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.BANG_GIA_TRUC_TUYENTableAdapter();
            this.tableAdapterManager = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANG_GIA_TRUC_TUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BlueViolet;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 511);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
    }
}