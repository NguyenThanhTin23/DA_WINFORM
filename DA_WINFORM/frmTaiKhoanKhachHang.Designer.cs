namespace DA_WINFORM
{
    partial class frmTaiKhoanKhachHang
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTinTaiKhoan = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResetPass = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.lblResetPass);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lblThongTinTaiKhoan);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(219, 164);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(426, 593);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblThongTinTaiKhoan
            // 
            this.lblThongTinTaiKhoan.AutoSize = true;
            this.lblThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblThongTinTaiKhoan.Location = new System.Drawing.Point(70, 263);
            this.lblThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinTaiKhoan.Name = "lblThongTinTaiKhoan";
            this.lblThongTinTaiKhoan.Size = new System.Drawing.Size(199, 28);
            this.lblThongTinTaiKhoan.TabIndex = 3;
            this.lblThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.lblThongTinTaiKhoan.Click += new System.EventHandler(this.lblThongTinTaiKhoan_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel3.Location = new System.Drawing.Point(75, 366);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(268, 2);
            this.guna2Panel3.TabIndex = 63;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.Location = new System.Drawing.Point(75, 306);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(268, 2);
            this.guna2Panel2.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 61;
            this.label2.Text = "TÀI KHOẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Location = new System.Drawing.Point(651, 167);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(1248, 590);
            this.panelTaiKhoan.TabIndex = 1;
            this.panelTaiKhoan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTaiKhoan_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 64;
            this.label1.Text = "Lịch sử đặt tour";
            // 
            // lblResetPass
            // 
            this.lblResetPass.AutoSize = true;
            this.lblResetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPass.ForeColor = System.Drawing.Color.White;
            this.lblResetPass.Location = new System.Drawing.Point(70, 387);
            this.lblResetPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetPass.Name = "lblResetPass";
            this.lblResetPass.Size = new System.Drawing.Size(140, 28);
            this.lblResetPass.TabIndex = 65;
            this.lblResetPass.Text = "Đổi mật khẩu";
            this.lblResetPass.Click += new System.EventHandler(this.lblResetPass_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.guna2Panel4.Location = new System.Drawing.Point(219, 164);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1698, 599);
            this.guna2Panel4.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.guna2Panel4;
            // 
            // frmTaiKhoanKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1844, 966);
            this.Controls.Add(this.panelTaiKhoan);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoanKhachHang";
            this.Text = "frmTaiKhoanKhachHang";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblThongTinTaiKhoan;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Label lblResetPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}