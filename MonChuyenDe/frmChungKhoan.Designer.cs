namespace MonChuyenDe
{
    partial class frmChungKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChungKhoan));
            this.btnDatlenh1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.rdbBan = new System.Windows.Forms.RadioButton();
            this.rdbMua = new System.Windows.Forms.RadioButton();
            this.lblGiaoDich = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDatlenh2 = new System.Windows.Forms.Button();
            this.numGia2 = new System.Windows.Forms.NumericUpDown();
            this.numSoluong2 = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaiLenh2 = new System.Windows.Forms.ComboBox();
            this.txtMaCK2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numGia1 = new System.Windows.Forms.NumericUpDown();
            this.numSoluong1 = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaiLenh1 = new System.Windows.Forms.ComboBox();
            this.txtMaCK1 = new System.Windows.Forms.TextBox();
            this.lblLoaiLenh1 = new System.Windows.Forms.Label();
            this.lblSoluong1 = new System.Windows.Forms.Label();
            this.lblGia1 = new System.Windows.Forms.Label();
            this.lblCK1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnDatlenh1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatlenh1
            // 
            this.btnDatlenh1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.btnDatlenh1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btnDatlenh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatlenh1.Location = new System.Drawing.Point(0, 0);
            this.btnDatlenh1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.btnDatlenh1.Name = "btnDatlenh1";
            this.btnDatlenh1.ReadOnly = true;
            this.btnDatlenh1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnDatlenh1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.btnDatlenh1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.btnDatlenh1.Size = new System.Drawing.Size(1143, 379);
            this.btnDatlenh1.TabIndex = 0;
            this.btnDatlenh1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.btnDatlenh1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.btnDatlenh1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.btnDatlenh1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.btnDatlenh1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDatlenh1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 379);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblNgay);
            this.panel3.Controls.Add(this.rdbBan);
            this.panel3.Controls.Add(this.rdbMua);
            this.panel3.Controls.Add(this.lblGiaoDich);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1143, 32);
            this.panel3.TabIndex = 10;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.Blue;
            this.lblNgay.Location = new System.Drawing.Point(920, 2);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(0, 23);
            this.lblNgay.TabIndex = 3;
            // 
            // rdbBan
            // 
            this.rdbBan.AutoSize = true;
            this.rdbBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBan.ForeColor = System.Drawing.Color.Blue;
            this.rdbBan.Location = new System.Drawing.Point(378, 4);
            this.rdbBan.Name = "rdbBan";
            this.rdbBan.Size = new System.Drawing.Size(108, 21);
            this.rdbBan.TabIndex = 2;
            this.rdbBan.TabStop = true;
            this.rdbBan.Text = "Đặt lệnh bán";
            this.rdbBan.UseVisualStyleBackColor = true;
            this.rdbBan.CheckedChanged += new System.EventHandler(this.rdbBan_CheckedChanged);
            // 
            // rdbMua
            // 
            this.rdbMua.AutoSize = true;
            this.rdbMua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMua.ForeColor = System.Drawing.Color.Blue;
            this.rdbMua.Location = new System.Drawing.Point(216, 5);
            this.rdbMua.Name = "rdbMua";
            this.rdbMua.Size = new System.Drawing.Size(112, 21);
            this.rdbMua.TabIndex = 1;
            this.rdbMua.TabStop = true;
            this.rdbMua.Text = "Đặt lệnh mua";
            this.rdbMua.UseVisualStyleBackColor = true;
            this.rdbMua.CheckedChanged += new System.EventHandler(this.rdbMua_CheckedChanged);
            // 
            // lblGiaoDich
            // 
            this.lblGiaoDich.AutoSize = true;
            this.lblGiaoDich.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaoDich.ForeColor = System.Drawing.Color.Blue;
            this.lblGiaoDich.Location = new System.Drawing.Point(26, 2);
            this.lblGiaoDich.Name = "lblGiaoDich";
            this.lblGiaoDich.Size = new System.Drawing.Size(95, 24);
            this.lblGiaoDich.TabIndex = 0;
            this.lblGiaoDich.Text = "Giao dịch";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 168);
            this.panel2.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.btnDatlenh2);
            this.groupBox2.Controls.Add(this.numGia2);
            this.groupBox2.Controls.Add(this.numSoluong2);
            this.groupBox2.Controls.Add(this.cmbLoaiLenh2);
            this.groupBox2.Controls.Add(this.txtMaCK2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(596, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăt lệnh bán";
            // 
            // btnDatlenh2
            // 
            this.btnDatlenh2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatlenh2.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDatlenh2.Location = new System.Drawing.Point(242, 124);
            this.btnDatlenh2.Name = "btnDatlenh2";
            this.btnDatlenh2.Size = new System.Drawing.Size(63, 23);
            this.btnDatlenh2.TabIndex = 11;
            this.btnDatlenh2.Text = "Đặt lệnh";
            this.btnDatlenh2.UseVisualStyleBackColor = true;
            this.btnDatlenh2.Click += new System.EventHandler(this.btnDatlenh2_Click);
            // 
            // numGia2
            // 
            this.numGia2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGia2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGia2.Location = new System.Drawing.Point(242, 98);
            this.numGia2.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numGia2.Name = "numGia2";
            this.numGia2.Size = new System.Drawing.Size(115, 21);
            this.numGia2.TabIndex = 10;
            // 
            // numSoluong2
            // 
            this.numSoluong2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoluong2.Location = new System.Drawing.Point(242, 74);
            this.numSoluong2.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numSoluong2.Name = "numSoluong2";
            this.numSoluong2.Size = new System.Drawing.Size(71, 21);
            this.numSoluong2.TabIndex = 9;
            // 
            // cmbLoaiLenh2
            // 
            this.cmbLoaiLenh2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiLenh2.FormattingEnabled = true;
            this.cmbLoaiLenh2.Location = new System.Drawing.Point(242, 47);
            this.cmbLoaiLenh2.Name = "cmbLoaiLenh2";
            this.cmbLoaiLenh2.Size = new System.Drawing.Size(180, 21);
            this.cmbLoaiLenh2.TabIndex = 1;
            // 
            // txtMaCK2
            // 
            this.txtMaCK2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaCK2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCK2.Location = new System.Drawing.Point(242, 20);
            this.txtMaCK2.MaxLength = 5;
            this.txtMaCK2.Name = "txtMaCK2";
            this.txtMaCK2.Size = new System.Drawing.Size(180, 20);
            this.txtMaCK2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại lệnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã chứng khoán";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numGia1);
            this.groupBox1.Controls.Add(this.numSoluong1);
            this.groupBox1.Controls.Add(this.cmbLoaiLenh1);
            this.groupBox1.Controls.Add(this.txtMaCK1);
            this.groupBox1.Controls.Add(this.lblLoaiLenh1);
            this.groupBox1.Controls.Add(this.lblSoluong1);
            this.groupBox1.Controls.Add(this.lblGia1);
            this.groupBox1.Controls.Add(this.lblCK1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(46, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt lệnh mua";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(250, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đặt lệnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numGia1
            // 
            this.numGia1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGia1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGia1.Location = new System.Drawing.Point(250, 99);
            this.numGia1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numGia1.Name = "numGia1";
            this.numGia1.Size = new System.Drawing.Size(115, 21);
            this.numGia1.TabIndex = 5;
            // 
            // numSoluong1
            // 
            this.numSoluong1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoluong1.Location = new System.Drawing.Point(250, 70);
            this.numSoluong1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numSoluong1.Name = "numSoluong1";
            this.numSoluong1.Size = new System.Drawing.Size(71, 21);
            this.numSoluong1.TabIndex = 4;
            // 
            // cmbLoaiLenh1
            // 
            this.cmbLoaiLenh1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiLenh1.FormattingEnabled = true;
            this.cmbLoaiLenh1.Location = new System.Drawing.Point(250, 43);
            this.cmbLoaiLenh1.Name = "cmbLoaiLenh1";
            this.cmbLoaiLenh1.Size = new System.Drawing.Size(180, 21);
            this.cmbLoaiLenh1.TabIndex = 1;
            // 
            // txtMaCK1
            // 
            this.txtMaCK1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaCK1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCK1.Location = new System.Drawing.Point(250, 18);
            this.txtMaCK1.MaxLength = 5;
            this.txtMaCK1.Name = "txtMaCK1";
            this.txtMaCK1.Size = new System.Drawing.Size(180, 20);
            this.txtMaCK1.TabIndex = 0;
            // 
            // lblLoaiLenh1
            // 
            this.lblLoaiLenh1.AutoSize = true;
            this.lblLoaiLenh1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiLenh1.Location = new System.Drawing.Point(70, 49);
            this.lblLoaiLenh1.Name = "lblLoaiLenh1";
            this.lblLoaiLenh1.Size = new System.Drawing.Size(58, 15);
            this.lblLoaiLenh1.TabIndex = 3;
            this.lblLoaiLenh1.Text = "Loại lệnh";
            // 
            // lblSoluong1
            // 
            this.lblSoluong1.AutoSize = true;
            this.lblSoluong1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong1.Location = new System.Drawing.Point(70, 76);
            this.lblSoluong1.Name = "lblSoluong1";
            this.lblSoluong1.Size = new System.Drawing.Size(57, 15);
            this.lblSoluong1.TabIndex = 2;
            this.lblSoluong1.Text = "Số lượng";
            // 
            // lblGia1
            // 
            this.lblGia1.AutoSize = true;
            this.lblGia1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia1.Location = new System.Drawing.Point(70, 99);
            this.lblGia1.Name = "lblGia1";
            this.lblGia1.Size = new System.Drawing.Size(26, 15);
            this.lblGia1.TabIndex = 1;
            this.lblGia1.Text = "Giá";
            // 
            // lblCK1
            // 
            this.lblCK1.AutoSize = true;
            this.lblCK1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCK1.Location = new System.Drawing.Point(70, 23);
            this.lblCK1.Name = "lblCK1";
            this.lblCK1.Size = new System.Drawing.Size(99, 15);
            this.lblCK1.TabIndex = 0;
            this.lblCK1.Text = "Mã chứng khoán";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChungKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChungKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÀN CHỨNG KHOÁN MINI";
            this.Load += new System.EventHandler(this.frmBGTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDatlenh1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView btnDatlenh1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGiaoDich;
        private System.Windows.Forms.RadioButton rdbBan;
        private System.Windows.Forms.RadioButton rdbMua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoaiLenh1;
        private System.Windows.Forms.Label lblSoluong1;
        private System.Windows.Forms.Label lblGia1;
        private System.Windows.Forms.Label lblCK1;
        private System.Windows.Forms.TextBox txtMaCK1;
        private System.Windows.Forms.TextBox txtMaCK2;
        private System.Windows.Forms.ComboBox cmbLoaiLenh1;
        private System.Windows.Forms.ComboBox cmbLoaiLenh2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numGia1;
        private System.Windows.Forms.NumericUpDown numSoluong1;
        private System.Windows.Forms.NumericUpDown numGia2;
        private System.Windows.Forms.NumericUpDown numSoluong2;
        private System.Windows.Forms.Button btnDatlenh2;
        private System.Windows.Forms.Button button1;
    }
}