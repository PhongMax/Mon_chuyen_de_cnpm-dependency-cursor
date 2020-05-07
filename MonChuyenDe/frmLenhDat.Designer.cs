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
            this.cHUNGKHOANDataSet = new MonChuyenDe.CHUNGKHOANDataSet();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            this.gcLENHDAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gcLENHDAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLENHDAT.Location = new System.Drawing.Point(0, 0);
            this.gcLENHDAT.Name = "gcLENHDAT";
            this.gcLENHDAT.Size = new System.Drawing.Size(1000, 366);
            this.gcLENHDAT.TabIndex = 2;
            this.gcLENHDAT.TabStop = false;
            this.gcLENHDAT.Text = "LENH DAT";
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.Location = new System.Drawing.Point(638, 111);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Size = new System.Drawing.Size(307, 22);
            this.txtGiaDat.TabIndex = 8;
            this.txtGiaDat.Validated += new System.EventHandler(this.txtGiaDat_Validated);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(110, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(307, 22);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.Validated += new System.EventHandler(this.txtSoLuong_Validated);
            // 
            // txtLoaiGD
            // 
            this.txtLoaiGD.Location = new System.Drawing.Point(684, 35);
            this.txtLoaiGD.Name = "txtLoaiGD";
            this.txtLoaiGD.Size = new System.Drawing.Size(261, 22);
            this.txtLoaiGD.TabIndex = 6;
            this.txtLoaiGD.Validated += new System.EventHandler(this.txtLoaiGD_Validated);
            // 
            // txtMaCP
            // 
            this.txtMaCP.Location = new System.Drawing.Point(110, 35);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(307, 22);
            this.txtMaCP.TabIndex = 5;
            this.txtMaCP.Validated += new System.EventHandler(this.txtMaCP_Validated);
            // 
            // btnLenhDat
            // 
            this.btnLenhDat.Location = new System.Drawing.Point(432, 199);
            this.btnLenhDat.Name = "btnLenhDat";
            this.btnLenhDat.Size = new System.Drawing.Size(107, 23);
            this.btnLenhDat.TabIndex = 4;
            this.btnLenhDat.Text = "Lệnh Đặt";
            this.btnLenhDat.UseVisualStyleBackColor = true;
            this.btnLenhDat.Click += new System.EventHandler(this.btnLenhDat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Giao Dịch (M/B) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Cổ Phiếu:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmLenhDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 391);
            this.Controls.Add(this.gcLENHDAT);
            this.Name = "frmLenhDat";
            this.Text = "frmLenhDat";
            this.Load += new System.EventHandler(this.frmLenhDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            this.gcLENHDAT.ResumeLayout(false);
            this.gcLENHDAT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}