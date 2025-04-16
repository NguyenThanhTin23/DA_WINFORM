using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA_WINFORM
{
    class TaiKhoanKhachHang_DAL
    {
        DataConnection dataCon;
        SqlCommand cmd;

        public TaiKhoanKhachHang_DAL()
        {
            dataCon = new DataConnection();
        }

        // Kiểm tra tài khoản đã tồn tại hay chưa
        public string GetMaKHByUsername(string username)
        {
            string sql = "SELECT MAKH FROM TAIKHOANKHACHHANG WHERE UserName = @UserName";
            using (SqlConnection con = dataCon.getConnect())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserName", username);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                return result != null ? result.ToString() : null;
            }
        }


        // Lấy thông tin tài khoản theo UserName
        public DataTable GetTaiKhoanByUsername(string username)
        {
            string sql = "SELECT * FROM TAIKHOANKHACHHANG WHERE UserName = @UserName";
            using (SqlConnection con = dataCon.getConnect())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserName", username);
                using (SqlDataAdapter sqlDA = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    con.Open();
                    sqlDA.Fill(dataTable);
                    con.Close();
                    return dataTable;
                }
            }
        }

        public bool InsertTaiKhoan(tbl_TaiKhoanKhachHang taiKhoan)
        {
            string sql = "INSERT INTO TAIKHOANKHACHHANG (UserName, MAKH) VALUES (@UserName, @MAKH)";
            using (SqlConnection con = dataCon.getConnect())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserName", taiKhoan.UserName);
                cmd.Parameters.AddWithValue("@MAKH", taiKhoan.MaKH);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

    }
}
