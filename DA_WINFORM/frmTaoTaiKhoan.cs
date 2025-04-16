using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_WINFORM
{
    public partial class frmTaoTaiKhoan : Form
    {
        private string currentUser;
        private TaiKhoanKhachHang_BLL tkkhBLL;
        private KhachHang_BLL khachHangBLL = new KhachHang_BLL();
        string maKH;
        public frmTaoTaiKhoan(string user)
        {
            InitializeComponent();
            currentUser = user;
            tkkhBLL = new TaiKhoanKhachHang_BLL();
        }
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            tkkhBLL = new TaiKhoanKhachHang_BLL();
        }
        private void LoadKhachHang(string maKH)
        {
            DataTable dt = khachHangBLL.GetKhachHangByMaKH(maKH);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtHoTen.Text = row["TENKH"].ToString();
                txtEmail.Text = row["EMAIL"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtDiaChi.Text = row["DIACHI"].ToString();
            }
            else
            {
                txtHoTen.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            maKH = tkkhBLL.GetMaKHByUsername(currentUser);

            if (maKH == null)
            {
                btnTaoKH.Enabled = true;
                btnTaoKH.Text = "Tạo khách hàng";
                btnTaoKH.Click -= btnSuaKH_Click;
                btnTaoKH.Click += btnTaoKH_Click;
            }
            else
            {
                btnTaoKH.Enabled = true;
                btnTaoKH.Text = "Sửa thông tin";
                btnTaoKH.Click -= btnTaoKH_Click;
                btnTaoKH.Click += btnSuaKH_Click;

                // Load thông tin khách hàng
                LoadKhachHang(maKH);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            tbl_KhachHang khachHang = new tbl_KhachHang
            {
                MaKH = maKH,
                TenKH = txtHoTen.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrWhiteSpace(khachHang.TenKH) ||
                string.IsNullOrWhiteSpace(khachHang.SDT) ||
                string.IsNullOrWhiteSpace(khachHang.Email) ||
                string.IsNullOrWhiteSpace(khachHang.DiaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!Regex.IsMatch(khachHang.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra email đã tồn tại chưa (trừ trường hợp của chính khách hàng hiện tại)
            KhachHang_DAL khachHangDAL = new KhachHang_DAL();
            if (khachHangDAL.CheckEmailExists(khachHang.Email, khachHang.MaKH))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số điện thoại có đúng 10 số
            if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin khách hàng
            bool result = khachHangDAL.UpdateKhachHang(khachHang);

            if (result)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
     string.IsNullOrWhiteSpace(txtEmail.Text) ||
     string.IsNullOrWhiteSpace(txtSDT.Text) ||
     string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra email đã tồn tại trong hệ thống
            if (khachHangBLL.CheckEmailExists(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số điện thoại có đúng 10 số
            if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1️⃣ Tạo mới khách hàng
            tbl_KhachHang khachHang = new tbl_KhachHang
            {
                MaKH = khachHangBLL.GenerateNewMaKH(),
                TenKH = txtHoTen.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            if (khachHangBLL.InsertKhachHang(khachHang))
            {
                // 2️⃣ Chèn UserName và MaKH vào bảng TAIKHOANKHACHHANG
                tbl_TaiKhoanKhachHang taiKhoanKH = new tbl_TaiKhoanKhachHang
                {
                    UserName = currentUser,
                    MaKH = khachHang.MaKH
                };

                if (tkkhBLL.InsertTaiKhoan(taiKhoanKH))
                {
                    MessageBox.Show("Tạo tài khoản khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaoKH.Visible = false;
                    LoadKhachHang(khachHang.MaKH);
                }
                else
                {
                    MessageBox.Show("Lỗi khi chèn UserName vào bảng TAIKHOANKHACHHANG!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
