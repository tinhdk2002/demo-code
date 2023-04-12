namespace TinhHocPhi
{
    partial class QuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVien));
            this.btnUpdateSV = new System.Windows.Forms.Button();
            this.btnDelSV = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateSV
            // 
            this.btnUpdateSV.Location = new System.Drawing.Point(173, 257);
            this.btnUpdateSV.Name = "btnUpdateSV";
            this.btnUpdateSV.Size = new System.Drawing.Size(71, 29);
            this.btnUpdateSV.TabIndex = 10;
            this.btnUpdateSV.Text = "Sửa";
            this.btnUpdateSV.UseVisualStyleBackColor = true;
            this.btnUpdateSV.Click += new System.EventHandler(this.btnUpdateSV_Click);
            // 
            // btnDelSV
            // 
            this.btnDelSV.Location = new System.Drawing.Point(96, 257);
            this.btnDelSV.Name = "btnDelSV";
            this.btnDelSV.Size = new System.Drawing.Size(71, 29);
            this.btnDelSV.TabIndex = 9;
            this.btnDelSV.Text = "Xóa";
            this.btnDelSV.UseVisualStyleBackColor = true;
            this.btnDelSV.Click += new System.EventHandler(this.btnDelSV_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Location = new System.Drawing.Point(19, 257);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(71, 29);
            this.btnAddSV.TabIndex = 8;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSV.Location = new System.Drawing.Point(98, 82);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(125, 20);
            this.txtTenSV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên:";
            // 
            // txtDiaChiSinhVien
            // 
            this.txtDiaChiSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiSinhVien.Location = new System.Drawing.Point(98, 131);
            this.txtDiaChiSinhVien.Name = "txtDiaChiSinhVien";
            this.txtDiaChiSinhVien.Size = new System.Drawing.Size(125, 20);
            this.txtDiaChiSinhVien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ:";
            // 
            // dtgvSV
            // 
            this.dtgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.DiaChi,
            this.NgaySinh});
            this.dtgvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSV.Location = new System.Drawing.Point(0, 0);
            this.dtgvSV.Name = "dtgvSV";
            this.dtgvSV.RowHeadersWidth = 51;
            this.dtgvSV.RowTemplate.Height = 29;
            this.dtgvSV.Size = new System.Drawing.Size(530, 450);
            this.dtgvSV.TabIndex = 3;
            this.dtgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSV_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MaSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSV.Location = new System.Drawing.Point(96, 31);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 20);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dTPNgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateSV);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelSV);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSV);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenSV);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChiSinhVien);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaSV);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvSV);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 4;
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgaySinh.Location = new System.Drawing.Point(98, 181);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(125, 27);
            this.dTPNgaySinh.TabIndex = 11;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUpdateSV;
        private Button btnDelSV;
        private Button btnAddSV;
        private Label label4;
        private TextBox txtTenSV;
        private Label label3;
        private TextBox txtDiaChiSinhVien;
        private Label label2;
        private DataGridView dtgvSV;
        private TextBox txtMaSV;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NgaySinh;
        private DateTimePicker dTPNgaySinh;
    }
}