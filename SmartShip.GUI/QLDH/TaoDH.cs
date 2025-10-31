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

namespace DA.GUI
{
    public partial class TaoDH : Form
    {
        private string maSanPhamChon = "";
        private decimal donGiaSanPham = 0;
        private readonly SanPhamService sanPhamSv = new SanPhamService();
        private readonly NguoiDungService nguoiDungSv = new NguoiDungService();
        private readonly TaiXeService TaixeSv = new TaiXeService();
        private readonly ChiTietDonHangService chiTietDonHangSv = new ChiTietDonHangService();
        private readonly DiaChiService diaChiSv = new DiaChiService();
        public TaoDH()
        {
            InitializeComponent();
        }
        private void TaoDH_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadTaiXe();
            LoadKhachHang();
        }

        private void LoadSanPham()
        {
            var sanPhams = sanPhamSv.GetAll();
            dgvDS.DataSource = sanPhams.Select(sp => new
            {
                MaSanPham = sp.MaSanPham,
                TenSanPham = sp.TenSanPham,
                DonGia = sp.DonGia,
                TonKho = sp.TonKho
            }).ToList();

            // Thiết lập tiêu đề cột
            dgvDS.Columns["MaSanPham"].HeaderText = "Mã SP";
            dgvDS.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvDS.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvDS.Columns["TonKho"].HeaderText = "Số Tồn";

            // Độ rộng cột (tùy ý)
            dgvDS.Columns["MaSanPham"].Width = 80;
            dgvDS.Columns["TenSanPham"].Width = 200;
            dgvDS.Columns["DonGia"].Width = 100;
            dgvDS.Columns["TonKho"].Width = 80;
        }
        private void LoadTaiXe()
        {
            
            var taiXes = TaixeSv.GetAll().ToList();
            // Lấy thông tin người dùng của từng tài xế để hiển thị tên
            var taiXeWithNames = taiXes.Select(tx =>
            {
                var nd = nguoiDungSv.GetById(tx.MaNguoiDung);
                return new
                {
                    MaTaiXe = tx.MaTaiXe,
                    HoTen = nd?.HoTen ?? "Chưa cập nhật",
                    BienSo = tx.BienSo
                };
            }).ToList();

            cmbNV.DisplayMember = "HoTen";
            cmbNV.ValueMember = "MaTaiXe";
            cmbNV.DataSource = taiXeWithNames;
        }
        private void LoadKhachHang()
        {
            
            var khachHangs = nguoiDungSv.GetAll()
                .Where(nd => nd.Taikhoan?.VaiTro == "KhachHang")
                .ToList();

            cmbKH.DisplayMember = "HoTen";
            cmbKH.ValueMember = "MaNguoiDung";
            cmbKH.DataSource = khachHangs;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbKH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbDC.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn địa chỉ giao hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maSanPhamChon))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuong = (int)nudSL.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //  Tạo mã đơn hàng mới
                var donHangSv = new DonHangService();
                var soThuTu = donHangSv.GetAll().Count + 1;
                string maDon = $"DH{soThuTu:D3}";

                // Tạo Đơn hàng DonHang
                var donHang = new DonHang
                {
                    MaDon = maDon,
                    MaKhach = cmbKH.SelectedValue.ToString(),
                    MaDiaChiGiao = cmbDC.SelectedValue.ToString(),
                    MaTaiXe = cmbNV.SelectedValue?.ToString(),
                    Loai = "Nhanh",
                    MoTa = "Đơn hàng thu " + soThuTu,
                    COD = donGiaSanPham * soLuong,
                    TrangThai = "Chờ",
                    NgayTao = DateTime.Now
                };

                // DÙNG HÀM THEM 
                donHangSv.Them(donHang);

                // Lưu vào chi tiết đơn hàng
                int soCT = chiTietDonHangSv.GetAll().Count + 1;
                string maChiTiet = "CT" + soCT.ToString("D3");
                var chiTiet = new ChiTietDonHang
                {
                    MaChiTiet = "CT" + maDon + "001",
                    MaDon = maDon,
                    MaSanPham = maSanPhamChon,
                    TenHang = txtTenSP.Text,
                    SoLuong = soLuong,
                    DonGia = donGiaSanPham
                };
                chiTietDonHangSv.Them(chiTiet);

                MessageBox.Show($"Đơn hàng {maDon} đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                btnHuy_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmbKH.Text = "";
            cmbDC.Text = "";
            txtGhiChu.Text = "";
            txtTenSP.Text = "";
            txtTongT.Text = "0";

            // Reset NumericUpDown
            nudSL.Value = 0;

            // Reset ComboBox (nếu có)
            if (cmbNV.Items.Count > 0)
                cmbNV.SelectedIndex = -1;
            else
                cmbNV.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLDH frm = new frmQLDH();
            this.Hide();
            frm.ShowDialog();
        }
        private void TinhTongTien()
        {
            int soLuong = (int)nudSL.Value; 
            if (soLuong > 0)
            {
                decimal thanhTien = donGiaSanPham * soLuong;
                txtTongT.Text = thanhTien.ToString("N0");
            }
            else
            {
                txtTongT.Text = "0";
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex < 0) return;

                var row = dgvDS.Rows[e.RowIndex];
                maSanPhamChon = row.Cells["MaSanPham"].Value?.ToString();
                string tenSanPham = row.Cells["TenSanPham"].Value?.ToString();
                donGiaSanPham = Convert.ToDecimal(row.Cells["DonGia"].Value ?? 0);

                if (!string.IsNullOrEmpty(tenSanPham))
                {
                    txtTenSP.Text = tenSanPham;
                }

            }
        }

        private void nudSL_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKH.SelectedValue == null) return;

            string maNguoiDung = cmbKH.SelectedValue.ToString();
            var diaChis = diaChiSv.GetByNguoiDung(maNguoiDung);

            if (diaChis.Count == 0)
            {
                MessageBox.Show("Khách hàng chưa có địa chỉ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDC.DataSource = null;
                return;
            }

            cmbDC.DisplayMember = "DiaChiChiTiet";
            cmbDC.ValueMember = "MaDiaChi";
            cmbDC.DataSource = diaChis;

            // Tự động chọn địa chỉ mặc định nếu có
            var diaChiMacDinh = diaChis.FirstOrDefault(d => d.MacDinh == true);
            if (diaChiMacDinh != null)
                cmbDC.SelectedValue = diaChiMacDinh.MaDiaChi;
        }
    }
}