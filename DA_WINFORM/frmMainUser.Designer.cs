
namespace DA_WINFORM
{
    partial class frmMainUser
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
            this.ControlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLienHe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTour = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlMin
            // 
            this.ControlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMin.BackColor = System.Drawing.Color.Silver;
            this.ControlMin.BorderColor = System.Drawing.Color.SeaGreen;
            this.ControlMin.BorderRadius = 5;
            this.ControlMin.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ControlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMin.FillColor = System.Drawing.Color.Silver;
            this.ControlMin.HoverState.Parent = this.ControlMin;
            this.ControlMin.IconColor = System.Drawing.Color.Black;
            this.ControlMin.Location = new System.Drawing.Point(1744, 15);
            this.ControlMin.Margin = new System.Windows.Forms.Padding(4);
            this.ControlMin.Name = "ControlMin";
            this.ControlMin.ShadowDecoration.Parent = this.ControlMin;
            this.ControlMin.Size = new System.Drawing.Size(40, 37);
            this.ControlMin.TabIndex = 9;
            this.ControlMin.Click += new System.EventHandler(this.ControlMin_Click);
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.BorderRadius = 5;
            this.ControlClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ControlClose.FillColor = System.Drawing.Color.Silver;
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.Black;
            this.ControlClose.Location = new System.Drawing.Point(1815, 15);
            this.ControlClose.Margin = new System.Windows.Forms.Padding(4);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(40, 37);
            this.ControlClose.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(897, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(217, 65);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblXinChao.Location = new System.Drawing.Point(1427, 22);
            this.lblXinChao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(99, 28);
            this.lblXinChao.TabIndex = 5;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelChildForm.Location = new System.Drawing.Point(74, 207);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.ShadowDecoration.Parent = this.panelChildForm;
            this.panelChildForm.Size = new System.Drawing.Size(1589, 966);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Controls.Add(this.guna2Panel7);
            this.guna2Panel2.Controls.Add(this.btnLogin);
            this.guna2Panel2.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel2.Controls.Add(this.ControlMin);
            this.guna2Panel2.Controls.Add(this.ControlClose);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Controls.Add(this.lblXinChao);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1871, 174);
            this.guna2Panel2.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(1652, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(156, 45);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.guna2Panel8);
            this.guna2Panel7.Controls.Add(this.guna2Panel9);
            this.guna2Panel7.Controls.Add(this.guna2Panel10);
            this.guna2Panel7.Controls.Add(this.guna2Panel11);
            this.guna2Panel7.Location = new System.Drawing.Point(483, 110);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(1043, 64);
            this.guna2Panel7.TabIndex = 4;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Controls.Add(this.btnLienHe);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel8.Location = new System.Drawing.Point(786, 0);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(262, 64);
            this.guna2Panel8.TabIndex = 4;
            // 
            // btnLienHe
            // 
            this.btnLienHe.BorderRadius = 10;
            this.btnLienHe.CheckedState.Parent = this.btnLienHe;
            this.btnLienHe.CustomImages.Parent = this.btnLienHe;
            this.btnLienHe.DisabledState.Parent = this.btnLienHe;
            this.btnLienHe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLienHe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(66)))));
            this.btnLienHe.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(110)))));
            this.btnLienHe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe.ForeColor = System.Drawing.Color.White;
            this.btnLienHe.HoverState.Parent = this.btnLienHe;
            this.btnLienHe.Location = new System.Drawing.Point(0, 0);
            this.btnLienHe.Margin = new System.Windows.Forms.Padding(4);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.ShadowDecoration.Parent = this.btnLienHe;
            this.btnLienHe.Size = new System.Drawing.Size(227, 64);
            this.btnLienHe.TabIndex = 5;
            this.btnLienHe.Text = "Liên hệ";
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.Controls.Add(this.btnTaiKhoan);
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel9.Location = new System.Drawing.Point(524, 0);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.ShadowDecoration.Parent = this.guna2Panel9;
            this.guna2Panel9.Size = new System.Drawing.Size(262, 64);
            this.guna2Panel9.TabIndex = 3;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderRadius = 10;
            this.btnTaiKhoan.CheckedState.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.CustomImages.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.DisabledState.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(66)))));
            this.btnTaiKhoan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(110)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.HoverState.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ShadowDecoration.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.Size = new System.Drawing.Size(227, 64);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.Controls.Add(this.btnTour);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel10.Location = new System.Drawing.Point(262, 0);
            this.guna2Panel10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.ShadowDecoration.Parent = this.guna2Panel10;
            this.guna2Panel10.Size = new System.Drawing.Size(262, 64);
            this.guna2Panel10.TabIndex = 2;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.Controls.Add(this.btnTrangChu);
            this.guna2Panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel11.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.ShadowDecoration.Parent = this.guna2Panel11;
            this.guna2Panel11.Size = new System.Drawing.Size(262, 64);
            this.guna2Panel11.TabIndex = 1;
            // 
            // btnTour
            // 
            this.btnTour.BorderRadius = 10;
            this.btnTour.CheckedState.Parent = this.btnTour;
            this.btnTour.CustomImages.Parent = this.btnTour;
            this.btnTour.DisabledState.Parent = this.btnTour;
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(66)))));
            this.btnTour.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(110)))));
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.HoverState.Parent = this.btnTour;
            this.btnTour.Image = global::DA_WINFORM.Properties.Resources.icons8_tour_bus_50;
            this.btnTour.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTour.Location = new System.Drawing.Point(0, 0);
            this.btnTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnTour.Name = "btnTour";
            this.btnTour.ShadowDecoration.Parent = this.btnTour;
            this.btnTour.Size = new System.Drawing.Size(227, 64);
            this.btnTour.TabIndex = 2;
            this.btnTour.TabStop = false;
            this.btnTour.Text = "Tour";
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BorderRadius = 10;
            this.btnTrangChu.CheckedState.Parent = this.btnTrangChu;
            this.btnTrangChu.CustomImages.Parent = this.btnTrangChu;
            this.btnTrangChu.DisabledState.Parent = this.btnTrangChu;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(66)))));
            this.btnTrangChu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(110)))));
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.Parent = this.btnTrangChu;
            this.btnTrangChu.Image = global::DA_WINFORM.Properties.Resources.icons8_home_50;
            this.btnTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.ShadowDecoration.Parent = this.btnTrangChu;
            this.btnTrangChu.Size = new System.Drawing.Size(227, 64);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "  Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Silver;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Silver;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::DA_WINFORM.Properties.Resources.icons8_exit_60;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1846, 13);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(40, 37);
            this.guna2GradientButton1.TabIndex = 10;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_WINFORM.Properties.Resources._8_Logo_Travel_Agent_Vietravel_01;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1871, 976);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainn_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMin;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public System.Windows.Forms.Label lblXinChao;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        public Guna.UI2.WinForms.Guna2GradientButton btnLienHe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2GradientButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2GradientButton btnTour;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2GradientButton btnTrangChu;
    }
}