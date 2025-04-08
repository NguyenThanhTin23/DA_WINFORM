using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_WINFORM
{
    public partial class frmTaiKhoanKhachHang : Form
    {
        private string currentUser;
        public frmTaiKhoanKhachHang(string user)
        {
            InitializeComponent();
            currentUser = user;
           
        }
        public frmTaiKhoanKhachHang()
        {
            InitializeComponent();
        }
        private Form activeForm = null; // Lưu trữ form con đang mở

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();  // Đóng form cũ nếu có

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelTaiKhoan.Controls.Add(childForm);
            panelTaiKhoan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lblThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frmTaoTK = new frmTaoTaiKhoan(currentUser);
            openChildForm(frmTaoTK);
        }

        private void panelTaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblResetPass_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(currentUser);
           frmChangePassword.Show();
        }
    }
}
