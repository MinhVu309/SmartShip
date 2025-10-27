using BUS.Service;
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
    public partial class Thongke : Form
    {
        public Thongke()
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

            var donHangSv = new DonHangService();
            var ctDhSv = new ChiTietDonHangService();

            // Lọc đơn hàng trong khoảng thời gian
            var donHangs = donHangSv.GetAll()
                .Where(dh => dh.NgayTao >= tuNgay && dh.NgayTao <= denNgay)
                .ToList();

            // Tổng đơn hàng
            int tongDon = donHangs.Count;
            txtTongD.Text = tongDon.ToString();

            // Tổng doanh thu = tổng (SoLuong * DonGia) từ ChiTietDonHang
            decimal tongDoanhThu = 0;
            var doanhThuTheoNgay = new Dictionary<DateTime, decimal>();

            foreach (var dh in donHangs)
            {
                var chiTietList = ctDhSv.GetByDon(dh.MaDon);
                decimal tongTienDH = chiTietList.Sum(ct => ct.SoLuong * ct.DonGia); // ← Sửa ở đây
                tongDoanhThu += tongTienDH;

                DateTime ngay = (dh.NgayTao ?? DateTime.Now).Date;
                if (!doanhThuTheoNgay.ContainsKey(ngay))
                    doanhThuTheoNgay[ngay] = 0;
                doanhThuTheoNgay[ngay] += tongTienDH;
            }

            txtTongTN.Text = tongDoanhThu.ToString("N0") + " VNĐ";

            // === Biểu đồ Trạng Thái ===
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

            // === Biểu đồ Doanh Thu Theo Ngày ===
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
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form1 frm = new Form1();
           frm.Hide();
           frm.ShowDialog();
        }
        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Top frmTop = new Top();
            frmTop.Hide();
            frmTop.ShowDialog();
        }

    }
}
