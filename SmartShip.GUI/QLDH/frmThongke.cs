using BUS.Service;
using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DA.GUI
{
    public partial class frmThongke : Form
    {
        private readonly DonHangService donHangSv = new DonHangService();
        private readonly ChiTietDonHangService ctDhSv = new ChiTietDonHangService();
        public frmThongke()
        {
            InitializeComponent();

        }
        private void Thongke_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            // Tự động thống kê khi load form
            btnTKe_Click(sender, e);
        }
        private void btnTKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1); // Đến cuối ngày
            // Lọc đơn hàng trong khoảng thời gian
            var donHangs = donHangSv.GetAll()
                .Where(dh => dh.NgayTao >= tuNgay && dh.NgayTao <= denNgay)
                .ToList();

            // Tổng đơn hàng
            int tongDon = donHangs.Count;
            txtTongD.Text = tongDon.ToString();

            // Tổng doanh thu = tổng (SoLuong * DonGia) 
            decimal tongDoanhThu = 0;
            var doanhThuTheoNgay = new Dictionary<DateTime, decimal>();

            foreach (var dh in donHangs)
            {
                var chiTietList = ctDhSv.GetByDon(dh.MaDon);
                decimal tongTienDH = chiTietList.Sum(ct => ct.SoLuong * ct.DonGia);
                tongDoanhThu += tongTienDH;

                DateTime ngay = (dh.NgayTao ?? DateTime.Now).Date;
                if (!doanhThuTheoNgay.ContainsKey(ngay))
                    doanhThuTheoNgay[ngay] = 0;
                doanhThuTheoNgay[ngay] += tongTienDH;
            }

            txtTongTN.Text = tongDoanhThu.ToString("N0") + " VNĐ";

            // Biểu đồ Trạng Thái 
            chartTrangThai.Series.Clear();
            var trangThaiCount = donHangs.GroupBy(dh => dh.TrangThai)
                                         .ToDictionary(g => g.Key, g => g.Count());

            var seriesTrangThai = new Series("Trạng Thái")
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var item in trangThaiCount)
            {
                seriesTrangThai.Points.AddXY(item.Key, item.Value);
            }

            chartTrangThai.Series.Add(seriesTrangThai);
            chartTrangThai.Titles.Clear();
            chartTrangThai.Titles.Add("Trạng Thái Đơn Hàng");

            // Biểu đồ Doanh Thu Theo Ngày
            chartDoanhThu.Series.Clear();
            var seriesDoanhThu = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column
            };

            // Sắp xếp theo ngày
            foreach (var ngay in doanhThuTheoNgay.OrderBy(x => x.Key))
            {
                seriesDoanhThu.Points.AddXY(ngay.Key.ToString("dd/MM"), ngay.Value);
            }

            chartDoanhThu.Series.Add(seriesDoanhThu);
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Doanh Thu Theo Ngày");
        }
        private void XuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo Excel
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                var workbook = excel.Workbooks.Add();

                //  Trạng Thái Đơn Hàng 
                var ws1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                ws1.Name = "Trạng Thái";

                // Tiêu đề
                ws1.Cells[1, 1] = "STT";
                ws1.Cells[1, 2] = "Trạng Thái";
                ws1.Cells[1, 3] = "Số Lượng";

                // Dữ liệu
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                var donHangs = donHangSv.GetAll()
                    .Where(dh => dh.NgayTao >= tuNgay && dh.NgayTao <= denNgay)
                    .ToList();

                var trangThaiCount = donHangs.GroupBy(dh => dh.TrangThai).ToList();
                for (int i = 0; i < trangThaiCount.Count; i++)
                {
                    ws1.Cells[i + 2, 1] = i + 1;
                    ws1.Cells[i + 2, 2] = trangThaiCount[i].Key;
                    ws1.Cells[i + 2, 3] = trangThaiCount[i].Count();
                }

                //  Doanh Thu Theo Ngày 
                var ws2 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add();
                ws2.Name = "Doanh Thu Theo Ngày";

                ws2.Cells[1, 1] = "Ngày";
                ws2.Cells[1, 2] = "Doanh Thu";

                var doanhThuTheoNgay = new Dictionary<DateTime, decimal>();
                foreach (var dh in donHangs)
                {
                    var chiTietList = new ChiTietDonHangService().GetByDon(dh.MaDon);
                    decimal tongTienDH = chiTietList.Sum(ct => ct.SoLuong * ct.DonGia);
                    DateTime ngay = (dh.NgayTao ?? DateTime.Now).Date;

                    if (!doanhThuTheoNgay.ContainsKey(ngay))
                        doanhThuTheoNgay[ngay] = 0;
                    doanhThuTheoNgay[ngay] += tongTienDH;
                }

                int row = 2;
                foreach (var item in doanhThuTheoNgay.OrderBy(x => x.Key))
                {
                    ws2.Cells[row, 1] = item.Key.ToString("dd/MM/yyyy");
                    ws2.Cells[row, 2] = item.Value;
                    row++;
                }

                //  Tổng Kết 
                var ws3 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add();
                ws3.Name = "Tổng Kết";

                ws3.Cells[1, 1] = "Tổng Số Đơn";
                ws3.Cells[1, 2] = "Tổng Doanh Thu";
                ws3.Cells[2, 1] = donHangs.Count;
                ws3.Cells[2, 2] = doanhThuTheoNgay.Values.Sum();

                // Định dạng
                ws1.Columns.AutoFit();
                ws2.Columns.AutoFit();
                ws3.Columns.AutoFit();

                // Lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    FileName = $"ThongKe_{dtpTuNgay.Value:yyyyMMdd}_{dtpDenNgay.Value:yyyyMMdd}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excel.Quit();

                    // Giải phóng COM
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ws1);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ws2);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ws3);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                    MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

    }
}
