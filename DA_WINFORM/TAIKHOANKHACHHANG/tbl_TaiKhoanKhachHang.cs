namespace DA_WINFORM
{
    public class tbl_TaiKhoanKhachHang
    {
        public string UserName { get; set; }
        public string MaKH { get; set; }

        public tbl_TaiKhoanKhachHang() { }

        public tbl_TaiKhoanKhachHang(string userName, string maKH)
        {
            UserName = userName;
            MaKH = maKH;
        }
    }
}
