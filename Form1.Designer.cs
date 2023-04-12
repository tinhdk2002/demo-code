namespace TinhHocPhi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXemHP = new System.Windows.Forms.Button();
            this.cbHPSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvHP = new System.Windows.Forms.DataGridView();
            this.ThongTinHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHọcPhầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônĐăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.btnXemHP);
            this.splitContainer1.Panel1.Controls.Add(this.cbHPSV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvHP);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // btnXemHP
            // 
            this.btnXemHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXemHP.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.btnXemHP, "btnXemHP");
            this.btnXemHP.Name = "btnXemHP";
            this.btnXemHP.UseVisualStyleBackColor = false;
            this.btnXemHP.Click += new System.EventHandler(this.btnXemHP_Click);
            // 
            // cbHPSV
            // 
            this.cbHPSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHPSV.FormattingEnabled = true;
            resources.ApplyResources(this.cbHPSV, "cbHPSV");
            this.cbHPSV.Name = "cbHPSV";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // dtgvHP
            // 
            this.dtgvHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThongTinHoaDon,
            this.SoTien,
            this.TinhTrang});
            resources.ApplyResources(this.dtgvHP, "dtgvHP");
            this.dtgvHP.Name = "dtgvHP";
            this.dtgvHP.RowTemplate.Height = 29;
            // 
            // ThongTinHoaDon
            // 
            this.ThongTinHoaDon.DataPropertyName = "HocKy";
            resources.ApplyResources(this.ThongTinHoaDon, "ThongTinHoaDon");
            this.ThongTinHoaDon.Name = "ThongTinHoaDon";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            resources.ApplyResources(this.SoTien, "SoTien");
            this.SoTien.Name = "SoTien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            resources.ApplyResources(this.TinhTrang, "TinhTrang");
            this.TinhTrang.Name = "TinhTrang";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcPhầnToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýMônĐăngKýToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // quảnLýHọcPhầnToolStripMenuItem
            // 
            this.quảnLýHọcPhầnToolStripMenuItem.Name = "quảnLýHọcPhầnToolStripMenuItem";
            resources.ApplyResources(this.quảnLýHọcPhầnToolStripMenuItem, "quảnLýHọcPhầnToolStripMenuItem");
            this.quảnLýHọcPhầnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHọcPhầnToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            resources.ApplyResources(this.quảnLýSinhViênToolStripMenuItem, "quảnLýSinhViênToolStripMenuItem");
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // quảnLýMônĐăngKýToolStripMenuItem
            // 
            this.quảnLýMônĐăngKýToolStripMenuItem.Name = "quảnLýMônĐăngKýToolStripMenuItem";
            resources.ApplyResources(this.quảnLýMônĐăngKýToolStripMenuItem, "quảnLýMônĐăngKýToolStripMenuItem");
            this.quảnLýMônĐăngKýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônĐăngKýToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TinhHocPhi.Properties.Resources._050994962c61328795f2568b4c51c0ab;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýHọcPhầnToolStripMenuItem;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýMônĐăngKýToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ComboBox cbHPSV;
        private Label label2;
        private Label label1;
        private DataGridView dtgvHP;
        private Button btnXemHP;
        private DataGridViewTextBoxColumn ThongTinHoaDon;
        private DataGridViewTextBoxColumn SoTien;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}