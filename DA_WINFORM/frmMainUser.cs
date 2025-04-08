using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_WINFORM
{
    public partial class frmMainUser : Form
    {
        private string currentUser = "";
        public frmMainUser(string user)
        {
            InitializeComponent();
            currentUser = user;
            UpdateLoginButton();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void UpdateLoginButton()
        {
            if (string.IsNullOrEmpty(currentUser))
            {
                btnLogin.Text = "Đăng nhập";
            }
            else
            {
                btnLogin.Text = "Đăng xuất";
            }
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1440, 680);

            btnTrangChu.FillColor = Color.White;
            btnTrangChu.FillColor2 = Color.White;
            btnTrangChu.ForeColor = Color.Black;

            btnTour.FillColor = Color.FromArgb(11, 7, 66);
            btnTour.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTour.ForeColor = Color.White;

            btnTaiKhoan.FillColor = Color.FromArgb(11, 7, 66);
            btnTaiKhoan.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTaiKhoan.ForeColor = Color.White;

            btnLienHe.FillColor = Color.FromArgb(11, 7, 66);
            btnLienHe.FillColor2 = Color.FromArgb(18, 12, 110);
            btnLienHe.ForeColor = Color.White;
            openChildForm(new frmHome());
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Bạn cần đăng nhập để sử dụng dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                // Mở form đăng nhập
                frmLogin loginForm = new frmLogin();
                if (loginForm.ShowDialog() == DialogResult.OK) // Nếu đăng nhập thành công
                {
                    
                    currentUser = loginForm.currentUser; // Lấy tên user sau khi đăng nhập
                    UpdateLoginButton(); // Cập nhật giao diện nút đăng nhập
                }
                else
                {
                    return; // Nếu không đăng nhập, thoát luôn
                }
            }

            // Nếu đã đăng nhập, mở form Tour
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1440, 680);
            frmDatTour datTour= new frmDatTour(currentUser);
            openChildForm(datTour);

            btnTour.FillColor = Color.White;
            btnTour.FillColor2 = Color.White;
            btnTour.ForeColor = Color.Black;

            btnTrangChu.FillColor = Color.FromArgb(11, 7, 66);
            btnTrangChu.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTrangChu.ForeColor = Color.White;

            btnLienHe.FillColor = Color.FromArgb(11, 7, 66);
            btnLienHe.FillColor2 = Color.FromArgb(18, 12, 110);
            btnLienHe.ForeColor = Color.White;

            btnTaiKhoan.FillColor = Color.FromArgb(11, 7, 66);
            btnTaiKhoan.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTaiKhoan.ForeColor = Color.White;
        }

     

        private void frmMainn_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1440, 680);

            btnTrangChu.FillColor = Color.White;
            btnTrangChu.FillColor2 = Color.White;
            btnTrangChu.ForeColor = Color.Black;

            btnTour.FillColor = Color.FromArgb(11, 7, 66);
            btnTour.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTour.ForeColor = Color.White;

            btnTaiKhoan.FillColor = Color.FromArgb(11, 7, 66);
            btnTaiKhoan.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTaiKhoan.ForeColor = Color.White;

            btnLienHe.FillColor = Color.FromArgb(11, 7, 66);
            btnLienHe.FillColor2 = Color.FromArgb(18, 12, 110);
            btnLienHe.ForeColor = Color.White;
            openChildForm(new frmHome());
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin LoginFrm = new frmLogin();
            LoginFrm.Show();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1440, 680);

            btnTrangChu.FillColor = Color.White;
            btnTrangChu.FillColor2 = Color.White;
            btnTrangChu.ForeColor = Color.Black;

            btnTour.FillColor = Color.FromArgb(11, 7, 66);
            btnTour.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTour.ForeColor = Color.White;

            btnTaiKhoan.FillColor = Color.FromArgb(11, 7, 66);
            btnTaiKhoan.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTaiKhoan.ForeColor = Color.White;

            btnLienHe.FillColor = Color.FromArgb(11, 7, 66);
            btnLienHe.FillColor2 = Color.FromArgb(18, 12, 110);
            btnLienHe.ForeColor = Color.White;
            openChildForm(new frmHome());
        }

       

        private void ControlMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1440, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            btnLienHe.FillColor = Color.White;
            btnLienHe.FillColor2 = Color.White;
            btnLienHe.ForeColor = Color.Black;

            btnTour.FillColor = Color.FromArgb(11, 7, 66);
            btnTour.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTour.ForeColor = Color.White;

            btnTaiKhoan.FillColor = Color.FromArgb(11, 7, 66);
            btnTaiKhoan.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTaiKhoan.ForeColor = Color.White;

            btnTrangChu.FillColor = Color.FromArgb(11, 7, 66);
            btnTrangChu.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTrangChu.ForeColor = Color.White;
            openChildForm(new frmLienHe());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentUser))
            {
                // Nếu chưa đăng nhập → mở form đăng nhập
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                // Nếu đã đăng nhập → đăng xuất
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Đăng xuất → trở về màn hình đăng nhập
                    frmLogin loginForm = new frmLogin();
                    loginForm.Show();
                    this.Close();
                }
            }
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Size = new Size(118, 933);
            panelChildForm.Size = new Size(1440, 680);
            panelChildForm.BackColor = Color.White;
            btnTaiKhoan.FillColor = Color.White;
            btnTaiKhoan.FillColor2 = Color.White;
            btnTaiKhoan.ForeColor = Color.Black;

            btnTour.FillColor = Color.FromArgb(11, 7, 66);
            btnTour.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTour.ForeColor = Color.White;

            btnTrangChu.FillColor = Color.FromArgb(11, 7, 66);
            btnTrangChu.FillColor2 = Color.FromArgb(18, 12, 110);
            btnTrangChu.ForeColor = Color.White;

            btnLienHe.FillColor = Color.FromArgb(11, 7, 66);
            btnLienHe.FillColor2 = Color.FromArgb(18, 12, 110);
            btnLienHe.ForeColor = Color.White;
            frmTaiKhoanKhachHang frmTaiKhoan = new frmTaiKhoanKhachHang(currentUser);
            openChildForm(frmTaiKhoan);
        }


        //private void btnKhachHang_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new frmKhachHang());
        //    //frmKhachHang KhachHang = new frmKhachHang();
        //    //KhachHang.ShowDialog();
        //}

        //private void btnThongTin_Click(object sender, EventArgs e)
        //{
        //    //if(pnlSubMenuThongTin.Visible == true)
        //    //    pnlSubMenuThongTin.Visible = false;
        //    //else
        //    //    pnlSubMenuThongTin.Visible = true;
        //}

        //private void btnQLTT_Click(object sender, EventArgs e)
        //{


        //}
    }
}
