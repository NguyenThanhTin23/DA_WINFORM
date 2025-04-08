using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace DA_WINFORM
{
    public partial class frmTaiKhoan : Form
    {
        User_BLL bllUser;
        public frmTaiKhoan()
        {
            InitializeComponent();
            bllUser = new User_BLL();
            cbRole.Items.AddRange(new string[] { "Quản Trị Viên", "Nhân Viên", "Khách Hàng" });
        }

        void OpenBox()
        {
            txtTaiKhoan.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            
        }

        void CloseBox()
        {
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
        }

        void ResetBox()
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
     
        }

        public void ShowAllAccount()
        {
            DataTable dataTable = bllUser.getAllAccount();
            DataGridViewTaiKhoan.DataSource = dataTable;
        }

        private bool CheckDataUser()
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text) || txtMatKhau.Text.Length < 6 ||
                !txtMatKhau.Text.Any(char.IsUpper) || !txtMatKhau.Text.Any(char.IsLower) || !txtMatKhau.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, chữ thường và số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetBox();
                CloseBox();
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTroVe.Enabled = false;
            }
        }

        private void DataGridViewTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBox();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtTaiKhoan.Text = DataGridViewTaiKhoan.Rows[index].Cells[0].Value.ToString();
                txtMatKhau.Text = DataGridViewTaiKhoan.Rows[index].Cells[1].Value.ToString();
                cbRole.SelectedValue = DataGridViewTaiKhoan.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            ShowAllAccount();
            CloseBox();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTroVe.Enabled = false;
        }

        private void DataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBox();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtTaiKhoan.Text = DataGridViewTaiKhoan.Rows[index].Cells[0].Value.ToString();
                txtMatKhau.Text = DataGridViewTaiKhoan.Rows[index].Cells[1].Value.ToString();

                string role = DataGridViewTaiKhoan.Rows[index].Cells[2].Value.ToString().Trim(); // Lấy dữ liệu từ DataGridView
                if (role == "Admin")
                {
                    cbRole.SelectedItem = "Quản Trị Viên".Trim();
                    txtTaiKhoan.ReadOnly = true;
                    txtMatKhau.ReadOnly = true;
                    cbRole.Enabled = false;
                }
                else if (role == "Employee")
                {
                    cbRole.SelectedItem = "Nhân Viên".Trim();
                    txtTaiKhoan.ReadOnly = true;
                    txtMatKhau.ReadOnly = true;
                    cbRole.Enabled = true;
                }
                else if (role == "Guest")
                {
                    cbRole.SelectedItem = "Khách Hàng".Trim();
                    txtTaiKhoan.ReadOnly = true;
                    txtMatKhau.ReadOnly = true;
                    cbRole.Enabled = true;
                }
                else
                    cbRole.SelectedIndex = -1;
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimKiem.Focus();
                return;
            }

            DataTable searchResult = bllUser.SearchUser(keyword);

            if (searchResult.Rows.Count > 0)
            {
                DataGridViewTaiKhoan.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllAccount(); // Hiển thị lại toàn bộ danh sách nếu không tìm thấy
            }
        }

        private void txtTimKiem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }
        bool checkThemSua = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetBox();  // Xóa nội dung các ô nhập
            OpenBox();   // Cho phép nhập liệu

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkThemSua = true;
            btnThem.Enabled = false;
            btnTroVe.Enabled = true;
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckDataUser()) // Kiểm tra đầu vào
            {
                if (cbRole.SelectedItem != null && cbRole.SelectedItem.ToString() == "Quản Trị Viên" && !checkThemSua)
                {
                    MessageBox.Show("Không thể thay đổi thông tin tài khoản Quản Trị Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbl_User user = new tbl_User();
                user.UserName = txtTaiKhoan.Text.Trim();
                user.Password = txtMatKhau.Text.Trim();
                user.Quyen = cbRole.SelectedItem?.ToString().Trim(); // Lấy quyền

                if (checkThemSua == true) // Thêm mới
                {
                    if (bllUser.RegisterUser(user))
                    {
                        ShowAllAccount();
                        CloseBox();
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.Focus();
                    }
                }
                else // Sửa thông tin
                {
                    if (bllUser.UpdatePassword(user.UserName, user.Password))
                    {
                        ShowAllAccount();
                        MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseBox();
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTaiKhoan.Focus();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem != null && cbRole.SelectedItem.ToString() == "Quản Trị Viên")
            {
                MessageBox.Show("Không thể sửa tài khoản Quản Trị Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenBox();
            checkThemSua = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cbRole.SelectedItem != null && cbRole.SelectedItem.ToString() == "Quản Trị Viên")
            {
                MessageBox.Show("Không thể xóa tài khoản Quản Trị Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_User user = new tbl_User();
                user.UserName = txtTaiKhoan.Text.Trim();

                if (bllUser.DeleteUser(user))
                {
                    ShowAllAccount();
                    ResetBox();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
     
        private void btnXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (DataGridViewTaiKhoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo SaveFileDialog để chọn nơi lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "DanhSachTaiKhoan.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                    // Xuất tiêu đề cột
                    for (int i = 0; i < DataGridViewTaiKhoan.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = DataGridViewTaiKhoan.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Font.Bold = true;
                    }

                    // Xuất dữ liệu
                    for (int i = 0; i < DataGridViewTaiKhoan.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridViewTaiKhoan.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = DataGridViewTaiKhoan.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Tự động chỉnh độ rộng cột
                    worksheet.Columns.AutoFit();

                    // Lưu file
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

