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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBGTT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcLENHDAT = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLenhDat = new System.Windows.Forms.Button();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.txtLoaiGD = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaDat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gcLENHDAT.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1143, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
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
            this.gcLENHDAT.Location = new System.Drawing.Point(0, 333);
            this.gcLENHDAT.Name = "gcLENHDAT";
            this.gcLENHDAT.Size = new System.Drawing.Size(1143, 246);
            this.gcLENHDAT.TabIndex = 1;
            this.gcLENHDAT.TabStop = false;
            this.gcLENHDAT.Text = "LENH DAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(92, 35);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(307, 25);
            this.txtMaCP.TabIndex = 5;
            // 
            // txtLoaiGD
            // 
            this.txtLoaiGD.Location = new System.Drawing.Point(614, 35);
            this.txtLoaiGD.Name = "txtLoaiGD";
            this.txtLoaiGD.Size = new System.Drawing.Size(307, 25);
            this.txtLoaiGD.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(92, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(307, 25);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.Location = new System.Drawing.Point(614, 111);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Size = new System.Drawing.Size(307, 25);
            this.txtGiaDat.TabIndex = 8;
            // 
            // frmBGTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 579);
            this.Controls.Add(this.gcLENHDAT);
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
            this.gcLENHDAT.ResumeLayout(false);
            this.gcLENHDAT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gcLENHDAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaDat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtLoaiGD;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.Button btnLenhDat;
    }
}