namespace TinhHocPhi
{
    partial class ThietLapMucDonViHocPHi
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
            this.btnThietLapPhi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThietLapPhi
            // 
            this.btnThietLapPhi.Location = new System.Drawing.Point(278, 208);
            this.btnThietLapPhi.Name = "btnThietLapPhi";
            this.btnThietLapPhi.Size = new System.Drawing.Size(94, 29);
            this.btnThietLapPhi.TabIndex = 0;
            this.btnThietLapPhi.Text = "Thiết lập ";
            this.btnThietLapPhi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thiết lập mức đơn vị phí:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thiết lập mức đơn vị phí cũ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 5;
            // 
            // ThietLapMucDonViHocPHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 379);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThietLapPhi);
            this.Name = "ThietLapMucDonViHocPHi";
            this.Text = "ThietLapMucDonViHocPHi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThietLapPhi;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
    }
}