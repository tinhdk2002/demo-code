namespace TinhHocPhi
{
    partial class QuanLyHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHocPhan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDelCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtHeSoHP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinChiHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvHocPhan = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChiHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateCourse);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelCourse);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddCourse);
            this.splitContainer1.Panel1.Controls.Add(this.txtHeSoHP);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenHP);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTinChiHP);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaHP);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvHocPhan);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(173, 257);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(71, 29);
            this.btnUpdateCourse.TabIndex = 10;
            this.btnUpdateCourse.Text = "Sửa";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDelCourse
            // 
            this.btnDelCourse.Location = new System.Drawing.Point(96, 257);
            this.btnDelCourse.Name = "btnDelCourse";
            this.btnDelCourse.Size = new System.Drawing.Size(71, 29);
            this.btnDelCourse.TabIndex = 9;
            this.btnDelCourse.Text = "Xóa";
            this.btnDelCourse.UseVisualStyleBackColor = true;
            this.btnDelCourse.Click += new System.EventHandler(this.btnDelCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(19, 257);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(71, 29);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Thêm";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txtHeSoHP
            // 
            this.txtHeSoHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeSoHP.Location = new System.Drawing.Point(92, 186);
            this.txtHeSoHP.Name = "txtHeSoHP";
            this.txtHeSoHP.Size = new System.Drawing.Size(125, 20);
            this.txtHeSoHP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hệ số:";
            // 
            // txtTenHP
            // 
            this.txtTenHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenHP.Location = new System.Drawing.Point(94, 82);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(125, 20);
            this.txtTenHP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên môn:";
            // 
            // txtTinChiHP
            // 
            this.txtTinChiHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTinChiHP.Location = new System.Drawing.Point(94, 131);
            this.txtTinChiHP.Name = "txtTinChiHP";
            this.txtTinChiHP.Size = new System.Drawing.Size(125, 20);
            this.txtTinChiHP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tín chỉ:";
            // 
            // txtMaHP
            // 
            this.txtMaHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHP.Location = new System.Drawing.Point(92, 31);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(125, 20);
            this.txtMaHP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // dtgvHocPhan
            // 
            this.dtgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.TinChiHP,
            this.HeSoHP});
            this.dtgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHocPhan.Location = new System.Drawing.Point(0, 0);
            this.dtgvHocPhan.Name = "dtgvHocPhan";
            this.dtgvHocPhan.RowHeadersWidth = 51;
            this.dtgvHocPhan.RowTemplate.Height = 29;
            this.dtgvHocPhan.Size = new System.Drawing.Size(530, 450);
            this.dtgvHocPhan.TabIndex = 3;
            this.dtgvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHocPhan_CellClick);
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MaHP";
            this.MaHP.HeaderText = "Mã môn";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            this.TenHP.HeaderText = "Tên môn";
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
            // QuanLyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyHocPhan";
            this.Text = "QuanLyHocPhan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label l1;
        private DataGridView dtgvHocPhan;
        private Label label1;
        private Button btnUpdateCourse;
        private Button btnDelCourse;
        private Button btnAddCourse;
        private TextBox txtHeSoHP;
        private Label label4;
        private TextBox txtTenHP;
        private Label label3;
        private TextBox txtTinChiHP;
        private Label label2;
        private TextBox txtMaHP;
        private DataGridViewTextBoxColumn MaHP;
        private DataGridViewTextBoxColumn TenHP;
        private DataGridViewTextBoxColumn TinChiHP;
        private DataGridViewTextBoxColumn HeSoHP;
    }
}