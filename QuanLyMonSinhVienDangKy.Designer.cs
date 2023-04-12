namespace TinhHocPhi
{
    partial class QuanLyMonSinhVienDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMonSinhVienDangKy));
            this.splitFull = new System.Windows.Forms.SplitContainer();
            this.cbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitDown = new System.Windows.Forms.SplitContainer();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.btnDangKyMon = new System.Windows.Forms.Button();
            this.btnXemMonDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flpDangKy = new System.Windows.Forms.FlowLayoutPanel();
            this.panelXemMonHoc = new System.Windows.Forms.Panel();
            this.dtgvXemMonDangKy = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChiHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitFull)).BeginInit();
            this.splitFull.Panel1.SuspendLayout();
            this.splitFull.Panel2.SuspendLayout();
            this.splitFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDown)).BeginInit();
            this.splitDown.Panel1.SuspendLayout();
            this.splitDown.Panel2.SuspendLayout();
            this.splitDown.SuspendLayout();
            this.panelXemMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemMonDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // splitFull
            // 
            this.splitFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFull.Location = new System.Drawing.Point(0, 0);
            this.splitFull.Name = "splitFull";
            this.splitFull.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitFull.Panel1
            // 
            this.splitFull.Panel1.Controls.Add(this.cbMaSinhVien);
            this.splitFull.Panel1.Controls.Add(this.label1);
            // 
            // splitFull.Panel2
            // 
            this.splitFull.Panel2.Controls.Add(this.splitDown);
            this.splitFull.Size = new System.Drawing.Size(989, 586);
            this.splitFull.SplitterDistance = 95;
            this.splitFull.TabIndex = 3;
            // 
            // cbMaSinhVien
            // 
            this.cbMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSinhVien.FormattingEnabled = true;
            this.cbMaSinhVien.Location = new System.Drawing.Point(135, 30);
            this.cbMaSinhVien.Name = "cbMaSinhVien";
            this.cbMaSinhVien.Size = new System.Drawing.Size(151, 28);
            this.cbMaSinhVien.Sorted = true;
            this.cbMaSinhVien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // splitDown
            // 
            this.splitDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDown.Location = new System.Drawing.Point(0, 0);
            this.splitDown.Name = "splitDown";
            // 
            // splitDown.Panel1
            // 
            this.splitDown.Panel1.Controls.Add(this.cbHocKy);
            this.splitDown.Panel1.Controls.Add(this.btnDangKyMon);
            this.splitDown.Panel1.Controls.Add(this.btnXemMonDangKy);
            this.splitDown.Panel1.Controls.Add(this.label3);
            // 
            // splitDown.Panel2
            // 
            this.splitDown.Panel2.Controls.Add(this.flpDangKy);
            this.splitDown.Panel2.Controls.Add(this.panelXemMonHoc);
            this.splitDown.Size = new System.Drawing.Size(989, 487);
            this.splitDown.SplitterDistance = 328;
            this.splitDown.TabIndex = 0;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(94, 23);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(160, 28);
            this.cbHocKy.TabIndex = 5;
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.Location = new System.Drawing.Point(56, 206);
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.Size = new System.Drawing.Size(143, 44);
            this.btnDangKyMon.TabIndex = 1;
            this.btnDangKyMon.Text = "Đăng ký môn";
            this.btnDangKyMon.UseVisualStyleBackColor = true;
            this.btnDangKyMon.Click += new System.EventHandler(this.btnDangKyMon_Click);
            // 
            // btnXemMonDangKy
            // 
            this.btnXemMonDangKy.Location = new System.Drawing.Point(56, 119);
            this.btnXemMonDangKy.Name = "btnXemMonDangKy";
            this.btnXemMonDangKy.Size = new System.Drawing.Size(143, 44);
            this.btnXemMonDangKy.TabIndex = 0;
            this.btnXemMonDangKy.Text = "Xem môn đăng ký";
            this.btnXemMonDangKy.UseVisualStyleBackColor = true;
            this.btnXemMonDangKy.Click += new System.EventHandler(this.btnXemMonDangKy_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Học Kỳ:";
            // 
            // flpDangKy
            // 
            this.flpDangKy.AutoScroll = true;
            this.flpDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDangKy.Location = new System.Drawing.Point(0, 0);
            this.flpDangKy.Name = "flpDangKy";
            this.flpDangKy.Size = new System.Drawing.Size(657, 487);
            this.flpDangKy.TabIndex = 1;
            // 
            // panelXemMonHoc
            // 
            this.panelXemMonHoc.Controls.Add(this.dtgvXemMonDangKy);
            this.panelXemMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXemMonHoc.Location = new System.Drawing.Point(0, 0);
            this.panelXemMonHoc.Name = "panelXemMonHoc";
            this.panelXemMonHoc.Size = new System.Drawing.Size(657, 487);
            this.panelXemMonHoc.TabIndex = 0;
            // 
            // dtgvXemMonDangKy
            // 
            this.dtgvXemMonDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvXemMonDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXemMonDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.TinChiHP,
            this.HeSoHP});
            this.dtgvXemMonDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvXemMonDangKy.Location = new System.Drawing.Point(0, 0);
            this.dtgvXemMonDangKy.Name = "dtgvXemMonDangKy";
            this.dtgvXemMonDangKy.RowHeadersWidth = 51;
            this.dtgvXemMonDangKy.RowTemplate.Height = 29;
            this.dtgvXemMonDangKy.Size = new System.Drawing.Size(657, 487);
            this.dtgvXemMonDangKy.TabIndex = 1;
            this.dtgvXemMonDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvXemMonDangKy_CellContentClick);
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MaHP";
            this.MaHP.HeaderText = "Mã HP";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            this.TenHP.HeaderText = "Tên học phần";
            this.TenHP.MinimumWidth = 6;
            this.TenHP.Name = "TenHP";
            // 
            // TinChiHP
            // 
            this.TinChiHP.DataPropertyName = "TinChiHP";
            this.TinChiHP.HeaderText = "Tín chỉ";
            this.TinChiHP.MinimumWidth = 6;
            this.TinChiHP.Name = "TinChiHP";
            // 
            // HeSoHP
            // 
            this.HeSoHP.DataPropertyName = "HeSoHP";
            this.HeSoHP.HeaderText = "Hệ số";
            this.HeSoHP.MinimumWidth = 6;
            this.HeSoHP.Name = "HeSoHP";
            // 
            // QuanLyMonSinhVienDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 586);
            this.Controls.Add(this.splitFull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyMonSinhVienDangKy";
            this.Text = "QuanLyMonSinhVienDangKy";
            this.splitFull.Panel1.ResumeLayout(false);
            this.splitFull.Panel1.PerformLayout();
            this.splitFull.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFull)).EndInit();
            this.splitFull.ResumeLayout(false);
            this.splitDown.Panel1.ResumeLayout(false);
            this.splitDown.Panel1.PerformLayout();
            this.splitDown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDown)).EndInit();
            this.splitDown.ResumeLayout(false);
            this.panelXemMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemMonDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitFull;
        private ComboBox cbMaSinhVien;
        private Label label1;
        private SplitContainer splitDown;
        private Button btnDangKyMon;
        private Button btnXemMonDangKy;
        private Panel panelXemMonHoc;
        private Label label3;
        private ComboBox cbHocKy;
        private DataGridView dtgvXemMonDangKy;
        private DataGridViewTextBoxColumn MaHP;
        private DataGridViewTextBoxColumn TenHP;
        private DataGridViewTextBoxColumn TinChiHP;
        private DataGridViewTextBoxColumn HeSoHP;
        private FlowLayoutPanel flpDangKy;
    }
}