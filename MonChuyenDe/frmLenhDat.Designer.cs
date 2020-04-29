namespace MonChuyenDe
{
    partial class frmLenhDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLenhDat));
            this.cHUNGKHOANDataSet = new MonChuyenDe.CHUNGKHOANDataSet();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lENHDATTableAdapter = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
            this.tableAdapterManager = new MonChuyenDe.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.lENHDATBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lENHDATBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lENHDATDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcLENHDAT = new System.Windows.Forms.GroupBox();
            this.txtGiaDat = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtLoaiGD = new System.Windows.Forms.TextBox();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.btnLenhDat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingNavigator)).BeginInit();
            this.lENHDATBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATDataGridView)).BeginInit();
            this.gcLENHDAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            this.lENHDATBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // lENHDATTableAdapter
            // 
            this.lENHDATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANG_GIA_TRUC_TUYENTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = this.lENHDATTableAdapter;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MonChuyenDe.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lENHDATBindingNavigator
            // 
            this.lENHDATBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lENHDATBindingNavigator.BindingSource = this.lENHDATBindingSource;
            this.lENHDATBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lENHDATBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lENHDATBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lENHDATBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lENHDATBindingNavigatorSaveItem});
            this.lENHDATBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lENHDATBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lENHDATBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lENHDATBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lENHDATBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lENHDATBindingNavigator.Name = "lENHDATBindingNavigator";
            this.lENHDATBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lENHDATBindingNavigator.Size = new System.Drawing.Size(976, 27);
            this.lENHDATBindingNavigator.TabIndex = 0;
            this.lENHDATBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lENHDATBindingNavigatorSaveItem
            // 
            this.lENHDATBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lENHDATBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lENHDATBindingNavigatorSaveItem.Image")));
            this.lENHDATBindingNavigatorSaveItem.Name = "lENHDATBindingNavigatorSaveItem";
            this.lENHDATBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.lENHDATBindingNavigatorSaveItem.Text = "Save Data";
            this.lENHDATBindingNavigatorSaveItem.Click += new System.EventHandler(this.lENHDATBindingNavigatorSaveItem_Click);
            // 
            // lENHDATDataGridView
            // 
            this.lENHDATDataGridView.AutoGenerateColumns = false;
            this.lENHDATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lENHDATDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.lENHDATDataGridView.DataSource = this.lENHDATBindingSource;
            this.lENHDATDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lENHDATDataGridView.Location = new System.Drawing.Point(0, 27);
            this.lENHDATDataGridView.Name = "lENHDATDataGridView";
            this.lENHDATDataGridView.RowTemplate.Height = 24;
            this.lENHDATDataGridView.Size = new System.Drawing.Size(976, 220);
            this.lENHDATDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MACP";
            this.dataGridViewTextBoxColumn2.HeaderText = "MACP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYDAT";
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAYDAT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LOAIGD";
            this.dataGridViewTextBoxColumn4.HeaderText = "LOAIGD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LOAILENH";
            this.dataGridViewTextBoxColumn5.HeaderText = "LOAILENH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GIADAT";
            this.dataGridViewTextBoxColumn7.HeaderText = "GIADAT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TRANGTHAILENH";
            this.dataGridViewTextBoxColumn8.HeaderText = "TRANGTHAILENH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // gcLENHDAT
            // 
            this.gcLENHDAT.Controls.Add(this.txtGiaDat);
            this.gcLENHDAT.Controls.Add(this.txtSoLuong);
            this.gcLENHDAT.Controls.Add(this.txtLoaiGD);
            this.gcLENHDAT.Controls.Add(this.txtMaCP);
            this.gcLENHDAT.Controls.Add(this.btnLenhDat);
            this.gcLENHDAT.Controls.Add(this.label4);
            this.gcLENHDAT.Controls.Add(this.label3);
            this.gcLENHDAT.Controls.Add(this.label2);
            this.gcLENHDAT.Controls.Add(this.label1);
            this.gcLENHDAT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcLENHDAT.Location = new System.Drawing.Point(0, 257);
            this.gcLENHDAT.Name = "gcLENHDAT";
            this.gcLENHDAT.Size = new System.Drawing.Size(976, 246);
            this.gcLENHDAT.TabIndex = 2;
            this.gcLENHDAT.TabStop = false;
            this.gcLENHDAT.Text = "LENH DAT";
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.Location = new System.Drawing.Point(614, 111);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Size = new System.Drawing.Size(307, 22);
            this.txtGiaDat.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(92, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(307, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtLoaiGD
            // 
            this.txtLoaiGD.Location = new System.Drawing.Point(614, 35);
            this.txtLoaiGD.Name = "txtLoaiGD";
            this.txtLoaiGD.Size = new System.Drawing.Size(307, 22);
            this.txtLoaiGD.TabIndex = 6;
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(92, 35);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(307, 22);
            this.txtMaCP.TabIndex = 5;
            // 
            // btnLenhDat
            // 
            this.btnLenhDat.Location = new System.Drawing.Point(496, 168);
            this.btnLenhDat.Name = "btnLenhDat";
            this.btnLenhDat.Size = new System.Drawing.Size(107, 23);
            this.btnLenhDat.TabIndex = 4;
            this.btnLenhDat.Text = "Lenh Dat";
            this.btnLenhDat.UseVisualStyleBackColor = true;
            this.btnLenhDat.Click += new System.EventHandler(this.btnLenhDat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "sl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "loaiGD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "maCP";
            // 
            // frmLenhDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 503);
            this.Controls.Add(this.gcLENHDAT);
            this.Controls.Add(this.lENHDATDataGridView);
            this.Controls.Add(this.lENHDATBindingNavigator);
            this.Name = "frmLenhDat";
            this.Text = "frmLenhDat";
            this.Load += new System.EventHandler(this.frmLenhDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingNavigator)).EndInit();
            this.lENHDATBindingNavigator.ResumeLayout(false);
            this.lENHDATBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATDataGridView)).EndInit();
            this.gcLENHDAT.ResumeLayout(false);
            this.gcLENHDAT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lENHDATBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lENHDATBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lENHDATDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox gcLENHDAT;
        private System.Windows.Forms.TextBox txtGiaDat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtLoaiGD;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.Button btnLenhDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}