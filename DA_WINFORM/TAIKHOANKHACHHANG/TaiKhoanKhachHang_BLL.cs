using System;
using System.Data;
using System.Data.SqlClient;
namespace DA_WINFORM
{
    class TaiKhoanKhachHang_BLL
    {
        private TaiKhoanKhachHang_DAL dal;

        public TaiKhoanKhachHang_BLL()
        {
            dal = new TaiKhoanKhachHang_DAL();
        }

        // Kiểm tra UserName có tồn tại không
        public string GetMaKHByUsername(string username)
        {
            return dal.GetMaKHByUsername(username);
        }

        // Lấy thông tin tài khoản khách hàng theo UserName
        public DataTable LayTaiKhoanTheoUserName(string userName)
        {
            return dal.GetTaiKhoanByUsername(userName);
        }

        // Thêm tài khoản khách hàng mới
        public bool InsertTaiKhoan(tbl_TaiKhoanKhachHang taiKhoan)
        {
            return dal.InsertTaiKhoan(taiKhoan);
        }
    }
}
