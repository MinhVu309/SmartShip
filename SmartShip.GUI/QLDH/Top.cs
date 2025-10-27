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
using DAL.DT;

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
        }
        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
