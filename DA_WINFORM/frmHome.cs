using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DA_WINFORM
{
    public partial class frmHome : Form
    {
        HoaDon_BLL bllhoadon;
        Tour_BLL bllTour;
        public frmHome()
        {
            InitializeComponent();
            bllhoadon = new HoaDon_BLL();
            bllTour = new Tour_BLL();
        }
       
        private void getDoanhThuNam()
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();
            chartRevenue.Titles.Clear(); // Xóa tiêu đề cũ nếu có

            // Thêm tiêu đề
            Title title = new Title("       Thống kê doanh thu theo tháng", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.MidnightBlue);
            chartRevenue.Titles.Add(title);

            // Thêm ChartArea mới
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";

            chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chartArea.AxisX.TitleForeColor = Color.MidnightBlue;
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chartArea.AxisY.TitleForeColor = Color.MidnightBlue;

            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 12;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Interval = 1;

            chartRevenue.ChartAreas.Add(chartArea);

            // Lấy dữ liệu từ database
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            DataTable dt = bllhoadon.ThongKe_DoanhThu_Nam(HoaDon);

            // Tạo Series cột
            Series columnSeries = new Series("Doanh thu");
            columnSeries.ChartType = SeriesChartType.Column;
            columnSeries.IsValueShownAsLabel = true; // Hiển thị giá trị trên cột
            columnSeries["PixelPointWidth"] = "30"; // Giảm độ rộng cột
            columnSeries.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Font chữ trên cột
            columnSeries.LabelForeColor = Color.Black; // Màu chữ hiển thị

            // Thêm từng điểm dữ liệu với màu khác nhau
            Random rand = new Random();
            foreach (DataRow row in dt.Rows)
            {
                int month = Convert.ToInt32(row["Tháng"]);
                double value = Convert.ToDouble(row["Thành tiền"]);

                DataPoint dp = new DataPoint(month, value);
                dp.Color = Color.FromArgb(rand.Next(50, 255), rand.Next(50, 255), rand.Next(50, 255)); // Màu ngẫu nhiên
               
                dp.Label = string.Format("{0:N0}", value); // Định dạng số hiển thị trên cột
                dp.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Font chữ lớn hơn và đậm
                dp.LabelForeColor = Color.DarkBlue;
                columnSeries.Points.Add(dp);
            }


            // Tạo Series đường
            Series lineSeries = new Series("Doanh thu2");
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Color = Color.MidnightBlue;
            lineSeries.BorderWidth = 3;
            lineSeries.XValueMember = "Tháng";
            lineSeries.YValueMembers = "Thành tiền";
            lineSeries.IsValueShownAsLabel = false;

            // Gán dữ liệu cho biểu đồ
            chartRevenue.DataSource = dt;
            chartRevenue.Series.Add(columnSeries);
            chartRevenue.Series.Add(lineSeries);

            // Xóa chú thích
            chartRevenue.Legends.Clear();
        }


        private void GetTourBanChay()
        {
            DataTable dttb = bllTour.GetTourBanChay();
            lblMaTour.Text = dttb.Rows[0]["MATOUR"].ToString();
            lblTenTour.Text = dttb.Rows[0]["TENTOUR"].ToString();
            lblMoTa.Text = dttb.Rows[0]["MOTA"].ToString();
            lblGiaTour.Text = "Giá chỉ: " + string.Format("{0:#,##0}", decimal.Parse(dttb.Rows[0]["GIATOUR"].ToString())) + "đ";
            MemoryStream ms3 = new MemoryStream((byte[])(dttb.Rows[0]["ANH1"]));
            picHinh1.Image = Image.FromStream(ms3);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            

            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            // Thêm ChartArea mới
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";

            // Định dạng tiêu đề trục
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chartArea.AxisX.TitleForeColor = Color.MidnightBlue;
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chartArea.AxisY.TitleForeColor = Color.MidnightBlue;

            // Bỏ lưới kẻ trục
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            // Trục X từ 1 -> 12
            chartArea.AxisX.Minimum = 1;
            chartArea.AxisX.Maximum = 12;
            chartArea.AxisX.Interval = 1;

            chartRevenue.ChartAreas.Add(chartArea);

            
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = 2025;
            chartRevenue.DataSource = bllhoadon.ThongKe_DoanhThu_Nam(HoaDon);

            // Series cột
            Series columnSeries = new Series("Doanh thu");
            columnSeries.ChartType = SeriesChartType.Column;
            columnSeries.Color = Color.DarkOrange;
            columnSeries.IsValueShownAsLabel = true;
            columnSeries.XValueMember = "Tháng";
            columnSeries.YValueMembers = "Thành tiền";

            // Series đường
            Series lineSeries = new Series("Doanh thu2");
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Color = Color.MidnightBlue;
            lineSeries.BorderWidth = 3;
            lineSeries.XValueMember = "Tháng";
            lineSeries.YValueMembers = "Thành tiền";
            lineSeries.IsValueShownAsLabel = false;

            chartRevenue.Series.Add(columnSeries);
            chartRevenue.Series.Add(lineSeries);

            // Xóa chú thích
            chartRevenue.Legends.Clear();

            GetTourBanChay();

            cmbYear.Items.Add("-- Chọn năm --");
            cmbYear.SelectedIndex = 0;
            for (int a = 2015; a < 2026; a++)
            {
                cmbYear.Items.Add(a);
            }
            cmbYear.Text = "2025";
        }

        

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbYear.SelectedIndex != 0))
            {
                getDoanhThuNam();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
