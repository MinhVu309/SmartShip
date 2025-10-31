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
using SmartShip.DAL.Model;

namespace DA.GUI
{
    public partial class Top : Form
    {
        private readonly TaiXeService TaixeSV = new TaiXeService();
        private readonly NguoiDungService NguoiDungSv = new NguoiDungService();
        private readonly ChiTietDonHangService ChiTietDonHangSv = new ChiTietDonHangService();
        private readonly DonHangService donHangSv = new DonHangService();

        public Top()
        {
            InitializeComponent();
        }
        private void Top_Load(object sender, EventArgs e)
        {
            LoadTopNhanVien();
            LoadTopKhachHang();
        }

        private void LoadTopNhanVien()
        {
            // Lấy top 5 tài xế theo TongDon
            var topTaiXe = TaixeSV.GetAll()
                .OrderByDescending(tx => tx.TongDon)
                .Take(5)
                .ToList();

            // Gán tên tài xế
            var data = topTaiXe.Select((tx, index) =>
            {
                var nd = NguoiDungSv.GetById(tx.MaNguoiDung);
                return new
                {
                    STT = index + 1,
                    TenTaiXe = nd?.HoTen ?? "Không xác định",
                    SoDon = tx.TongDon
                };
            }).ToList();

            dgvTNV.DataSource = data;

            // Thiết lập cột
            dgvTNV.Columns["STT"].HeaderText = "STT";
            dgvTNV.Columns["TenTaiXe"].HeaderText = "Tên Tài Xế";
            dgvTNV.Columns["SoDon"].HeaderText = "Số Đơn";
        }
        private void LoadTopKhachHang()
        {
            var topKhachHang = donHangSv.GetAll()
                .GroupBy(dh => dh.MaKhach)
                .Select(g => new TopKhachHang
                {
                    TenKhach = NguoiDungSv.GetById(g.Key)?.HoTen ?? "Không xác định",
                    TongTien = g.Sum(dh => ChiTietDonHangSv.GetByDon(dh.MaDon).Sum(ct => ct.SoLuong * ct.DonGia))
                })
                .OrderByDescending(x => x.TongTien)
                .Take(5)
                .ToList();

            // Gán STT
            for (int i = 0; i < topKhachHang.Count; i++)
            {
                topKhachHang[i].STT = i + 1;
            }

            dgvTKH.DataSource = topKhachHang;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                var workbook = excel.Workbooks.Add();

                // Sheet 1: Top Tài Xế
                var ws1 = workbook.Worksheets[1];
                ws1.Name = "Top Tài Xế";
                XuatEx(dgvTNV, ws1);

                // Sheet 2: Top Khách Hàng
                var ws2 = workbook.Worksheets.Add();
                ws2.Name = "Top Khách Hàng";
                XuatEx(dgvTKH, ws2);

                // Lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    FileName = $"TopNhanVien_KhachHang_{DateTime.Now:yyyyMMddHHmmss}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excel.Quit();

                    // Giải phóng COM
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ws1);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ws2);
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
        private void XuatEx(DataGridView dgv, Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            // Tiêu đề
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // Dữ liệu
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].IsNewRow) continue;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Columns[j].Visible)
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // AutoFit
            worksheet.Columns.AutoFit();
        }
        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
