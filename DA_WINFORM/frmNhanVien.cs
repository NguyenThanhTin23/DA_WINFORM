using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace DA_WINFORM
{
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL bllNV;
        public frmNhanVien()
        {
            InitializeComponent();
            bllNV = new NhanVien_BLL();
        }

        public void ShowAllNhanVien()
        {
            DataTable dataTable = bllNV.GetAllNhanVien();
            DataGridViewNhanVien.DataSource = dataTable;
        }

        public bool CheckDataNV()
        {
            if (string.IsNullOrEmpty(txtMANV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTENNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }

            if((dtpNGVL.Value.Year - dtpNGSINH.Value.Year) < 18)
            {
                MessageBox.Show("Chưa đủ 18 tuổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtCMND_CCCD.Text))
            {
                MessageBox.Show("Bạn chưa nhập CMND_CCCD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND_CCCD.Focus();
                return false;
            }
            return true;
        }

        void OpenBox()
        {
            txtTENNV.ReadOnly = false;
            dtpNGSINH.Enabled = true;
            txtSDT.ReadOnly = false;
            txtCMND_CCCD.ReadOnly = false;
            dtpNGVL.Enabled = true;
        }

        void CloseBox()
        {
            txtTENNV.ReadOnly = true;
            dtpNGSINH.Enabled = false;
            txtSDT.ReadOnly = true;
            txtCMND_CCCD.ReadOnly = true;
            dtpNGVL.Enabled = false;
        }

        void ResetBox()
        {
            txtMANV.Clear();
            txtTENNV.Clear();
            dtpNGSINH.Value = DateTime.Now;
            txtSDT.Clear();
            txtCMND_CCCD.Clear();
            dtpNGVL.Value = DateTime.Now;
        }

        bool checkThemSua = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetBox();
            string MaNV;
            if (bllNV.GetSLNV() < 10)
                MaNV = "NV0" + bllNV.GetSLNV().ToString();
            else
                MaNV = "NV" + bllNV.GetSLNV().ToString();
            txtMANV.Text = MaNV;
            OpenBox();          
            checkThemSua = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkThemSua == true)
            {

                if (CheckDataNV())
                {
                    tbl_NhanVien nv = new tbl_NhanVien();
                    nv.MANV = txtMANV.Text;
                    nv.TENNV = txtTENNV.Text;
                    nv.NGSINH = dtpNGSINH.Value;
                    nv.SDT = txtSDT.Text;
                    nv.CMND_CCCD = txtCMND_CCCD.Text;
                    nv.NGVL = dtpNGVL.Value;
                    if (bllNV.InsertNhanVien(nv))
                    {
                        ShowAllNhanVien();
                        CloseBox();
                        MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtTENNV.Focus();
                    }
                }
            }

            if (checkThemSua == false)
            {
                if (CheckDataNV())
                {
                    tbl_NhanVien nv = new tbl_NhanVien();
                    nv.MANV = txtMANV.Text;
                    nv.TENNV = txtTENNV.Text;
                    nv.NGSINH = dtpNGSINH.Value;
                    nv.SDT = txtSDT.Text;
                    nv.CMND_CCCD = txtCMND_CCCD.Text;
                    nv.NGVL = dtpNGVL.Value;
                    if (bllNV.UpdateNhanVien(nv))
                    {
                        ShowAllNhanVien();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseBox();
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtTENNV.Focus();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OpenBox();
            txtMANV.ReadOnly = true;
            checkThemSua = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_NhanVien nv = new tbl_NhanVien();
                    nv.MANV = txtMANV.Text;
                    if (bllNV.DeleteNhanVien(nv))
                    {
                        ShowAllNhanVien();
                        ResetBox();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllNhanVien();
                    }

                    else
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
            CloseBox();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTroVe.Enabled = false;
        }

        private void DataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBox();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtMANV.Text = DataGridViewNhanVien.Rows[index].Cells[0].Value.ToString();
                txtTENNV.Text = DataGridViewNhanVien.Rows[index].Cells[1].Value.ToString();
                dtpNGSINH.Value = Convert.ToDateTime(DataGridViewNhanVien.Rows[index].Cells[2].Value.ToString());
                txtSDT.Text = DataGridViewNhanVien.Rows[index].Cells[3].Value.ToString();
                txtCMND_CCCD.Text = DataGridViewNhanVien.Rows[index].Cells[4].Value.ToString();
                dtpNGVL.Value = Convert.ToDateTime(DataGridViewNhanVien.Rows[index].Cells[5].Value.ToString());
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCMND_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không nhập gì, hiển thị toàn bộ danh sách nhân viên
                ShowAllNhanVien();
                return;
            }

            DataTable dt = bllNV.SearchNhanVien(keyword);

            if (dt.Rows.Count > 0)
            {
                DataGridViewNhanVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatDuLieu_Click(object sender, EventArgs e)
        {

            if (DataGridViewNhanVien.Rows.Count > 0)
            {
                // Tạo ứng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // Tạo Sheet đầu tiên
                Excel._Worksheet worksheet = excelApp.ActiveSheet;
                worksheet.Name = "DanhSachNhanVien";

                // Xuất tiêu đề cột
                for (int i = 0; i < DataGridViewNhanVien.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DataGridViewNhanVien.Columns[i].HeaderText;
                }

                // Xuất dữ liệu từ DataGridView
                for (int i = 0; i < DataGridViewNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGridViewNhanVien.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DataGridViewNhanVien.Rows[i].Cells[j].Value?.ToString();
                    }
                }

             
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.Title = "Chọn nơi lưu file";
                saveFileDialog.FileName = "DanhSachNhanVien.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog.FileName);
                    excelApp.Quit();
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    excelApp.Quit();
                    MessageBox.Show("Hủy lưu file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbThongTinNV_Enter(object sender, EventArgs e)
        {

        }

        private void txtCMND_CCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTENNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNGVL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpNGSINH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHoten_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
