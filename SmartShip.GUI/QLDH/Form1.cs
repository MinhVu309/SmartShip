using BUS.Service;
using DAL.DT;
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
    public partial class Form1 : Form
    {
        private readonly DonHangService donHangSv = new DonHangService();
        private readonly NguoiDungService NguoiDungSv = new NguoiDungService();
        private readonly DiaChiService diaChiSv = new DiaChiService();
        private readonly PhanCongService phanCongSv = new PhanCongService();
        private readonly TaiXeService TaixeSv = new TaiXeService();
        private readonly ThanhToanService thanhToanSv = new ThanhToanService();
        private readonly ChiTietDonHangService chiTietDonHangSv = new ChiTietDonHangService();
        private readonly SanPhamService sanPhamSv = new SanPhamService();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            
            // Load danh sách đơn hàng với thông tin đầy đủ
            LoadData();
            LoadTaiXe(); 
            LoadTrangThai();

        }
        private void LoadData()
        {
            dgvDonHang.DataSource = donHangSv.GetAll()
                .Select(dh =>
                {
                    var nguoiDat = NguoiDungSv.GetById(dh.MaKhach)?.HoTen ?? "Không xác định";

                    string nguoiGiao = "Chưa phân công";
                    if (!string.IsNullOrEmpty(dh.MaTaiXe))
                    {
                        var taiXe = TaixeSv.GetById(dh.MaTaiXe);
                        if (taiXe != null)
                        {
                            nguoiGiao = NguoiDungSv.GetById(taiXe.MaNguoiDung)?.HoTen ?? "Không xác định";
                        }
                    }

                    var diaChiGiao = diaChiSv.GetById(dh.MaDiaChiGiao)?.DiaChiChiTiet ?? "Không có địa chỉ";

                    return new
                    {
                        MaDon = dh.MaDon,
                        NguoiDat = nguoiDat,
                        NguoiGiao = nguoiGiao,
                        TenHang = string.Join(", ",chiTietDonHangSv.GetByDon(dh.MaDon)
                                .Select(ct =>
                                {
                                    // Lấy tên sản phẩm từ SanPhamService
                                    var sp = sanPhamSv.GetById(ct.MaSanPham);
                                    return sp?.TenSanPham ?? ct.TenHang ?? "Không xác định";
                                })
                        ) ?? "Không có sản phẩm",
                        SoLuong = chiTietDonHangSv.GetByDon(dh.MaDon).Sum(ct => ct.SoLuong), // Tổng SL
                        COD = dh.COD,
                        DiaChiGiao = diaChiGiao,
                        TrangThai = dh.TrangThai,
                        NgayTao = dh.NgayTao
                    };
                })
                .ToList();
            // Thiết lập tiêu đề cột
            dgvDonHang.Columns["MaDon"].HeaderText = "Mã Đơn";
            dgvDonHang.Columns["NguoiDat"].HeaderText = "Người Đặt";
            dgvDonHang.Columns["NguoiGiao"].HeaderText = "Người Giao";
            dgvDonHang.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvDonHang.Columns["COD"].HeaderText = "COD";
            dgvDonHang.Columns["DiaChiGiao"].HeaderText = "Địa Chỉ Giao";
            dgvDonHang.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDonHang.Columns["NgayTao"].HeaderText = "Ngày Tạo";

            // Thiết lập độ rộng cột (tùy chọn)
            dgvDonHang.Columns["MaDon"].Width = 80;
            dgvDonHang.Columns["NguoiDat"].Width = 120;
            dgvDonHang.Columns["NguoiGiao"].Width = 120;
            dgvDonHang.Columns["SoLuong"].Width = 80;
            dgvDonHang.Columns["COD"].Width = 100;
            dgvDonHang.Columns["DiaChiGiao"].Width = 200;
            dgvDonHang.Columns["TrangThai"].Width = 100;
            dgvDonHang.Columns["NgayTao"].Width = 120;
        }
        private void LoadTrangThai()
        {
            // Danh sách trạng thái cố định theo hệ thống của bạn
            var trangThais = new List<string>
            {
                "Chờ",
                "Đang giao",
                "Hoàn thành",
                "Đã hủy"
            };

            cmbTrangThai.DataSource = trangThais;
        }

        private void LoadTaiXe()
        {
            var taiXes = TaixeSv.GetAll().ToList();
            // Lấy thông tin người dùng của từng tài xế để hiển thị tên
            var ndService = new NguoiDungService();
            var taiXeWithNames = taiXes.Select(tx =>
            {
                var nd = NguoiDungSv.GetById(tx.MaNguoiDung);
                return new
                {
                    MaTaiXe = tx.MaTaiXe,
                    HoTen = nd?.HoTen ?? "Chưa cập nhật",
                    BienSo = tx.BienSo
                };
            }).ToList();

            cmbNguoiG.DisplayMember = "HoTen";
            cmbNguoiG.ValueMember = "MaTaiXe";
            cmbNguoiG.DataSource = taiXeWithNames;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã đơn hàng đang được chọn
            if (dgvDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDon = dgvDonHang.SelectedRows[0].Cells["MaDon"].Value?.ToString();

            if (string.IsNullOrEmpty(maDon))
            {
                MessageBox.Show("Không xác định được mã đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận xóa
            if (MessageBox.Show($"Bạn có chắc muốn xóa đơn hàng '{maDon}'?", "Xác nhận xóa",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var donHangSv = new DonHangService();
                var donHang = donHangSv.GetById(maDon);

                if (donHang == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ⚠️ Kiểm tra: không cho xóa nếu đã thanh toán hoặc đã giao
                if (donHang.TrangThai != "Chờ")
                {
                    MessageBox.Show("Chỉ được xóa đơn hàng có trạng thái 'Chờ'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tiến hành xóa
                donHangSv.Xoa(maDon);

                MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload lại danh sách
                Form_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maDon = txtMaDH.Text.Trim();
            if (string.IsNullOrEmpty(maDon))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var donHang = donHangSv.GetById(maDon);
            if (donHang == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Cập nhật trạng thái
            donHang.TrangThai = cmbTrangThai.Text;
            // Cập nhật tài xế (nếu có chọn)
            if (cmbNguoiG.SelectedValue != null)
            {
                donHang.MaTaiXe = cmbNguoiG.SelectedValue.ToString();
            }
            else
            {
                donHang.MaTaiXe = null; // Chưa phân công
            }
            // Lưu cập nhật
            donHangSv.CapNhat(donHang);
            MessageBox.Show("Cập nhật đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Tải lại dữ liệu
            LoadData();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {

            string maTim = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(maTim))
            {
                // Load toàn bộ đơn hàng nếu ô tìm kiếm trống
                Form_Load(null, null);
                return;
            }

            // Tìm đơn hàng theo mã
            var donHang = donHangSv.GetById(maTim);

            if (donHang == null)
            {
                // Không tìm thấy → hiển thị trống
                dgvDonHang.DataSource = new List<object>();
                MessageBox.Show("Không tìm thấy đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Nếu tìm thấy → gọi lại Form_Load nhưng chỉ với đơn này
            // Tạm thời ghi đè DataSource (giống logic Form_Load)

            var nguoiDat = NguoiDungSv.GetById(donHang.MaKhach)?.HoTen ?? "Không xác định";
            string nguoiGiao = "Chưa phân công";
            if (!string.IsNullOrEmpty(donHang.MaTaiXe))
            {
                var tx = TaixeSv.GetById(donHang.MaTaiXe);
                if (tx != null)
                {
                    nguoiGiao = NguoiDungSv.GetById(tx.MaNguoiDung)?.HoTen ?? "Không xác định";
                }
            }
            var diaChi = diaChiSv.GetById(donHang.MaDiaChiGiao)?.DiaChiChiTiet ?? "Không có địa chỉ";

            dgvDonHang.DataSource = new[]
            {
        new
        {
            MaDon = donHang.MaDon,
            NguoiDat = nguoiDat,
            NguoiGiao = nguoiGiao,
            DiaChiGiao = diaChi,
            TrangThai = donHang.TrangThai,
            NgayTao = donHang.NgayTao
        }
    }.ToList();

            // Thiết lập cột (nếu chưa có)
            if (dgvDonHang.Columns.Count > 0)
            {
                dgvDonHang.Columns["MaDon"].HeaderText = "Mã Đơn";
                dgvDonHang.Columns["NguoiDat"].HeaderText = "Người Đặt";
                dgvDonHang.Columns["NguoiGiao"].HeaderText = "Người Giao";
                dgvDonHang.Columns["DiaChiGiao"].HeaderText = "Địa Chỉ Giao";
                dgvDonHang.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvDonHang.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            }
        }
       
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tạoĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoDH taoDH = new TaoDH();
            taoDH.ShowDialog();
        }
        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke tk = new Thongke();
            tk.ShowDialog();
        }
        private void dgvDSDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dgvDonHang.Rows[e.RowIndex];

            // Lấy dữ liệu từ các cột (phải khớp với tên cột trong DataSource)
            string maDon = row.Cells["MaDon"].Value?.ToString();
            string nguoiDat = row.Cells["NguoiDat"].Value?.ToString();
            string nguoiGiaoText = row.Cells["NguoiGiao"].Value?.ToString(); // chỉ để hiển thị fallback
            string diaChiGiao = row.Cells["DiaChiGiao"].Value?.ToString();
            string trangThai = row.Cells["TrangThai"].Value?.ToString();
            var ngayTaoObj = row.Cells["NgayTao"].Value;

            // Hiển thị lên control
            txtMaDH.Text = maDon;
            txtNguoiD.Text = nguoiDat;
            txtDCG.Text = diaChiGiao;

            // Xử lý trạng thái
            cmbTrangThai.Text = trangThai;
            string maTaiXe = null;
            if (!string.IsNullOrEmpty(maDon))
            {
                var dhService = new DonHangService();
                var donHang = dhService.GetById(maDon);
                maTaiXe = donHang?.MaTaiXe;
            }

            if (string.IsNullOrEmpty(maTaiXe))
            {
                // Chưa phân công: chỉ hiển thị text, không chọn item
                cmbNguoiG.Text = "Chưa phân công";
                // Đảm bảo không có item nào được chọn
                cmbNguoiG.SelectedIndex = -1;
            }
            else
            {
                // Cố gắng chọn tài xế trong ComboBox
                cmbNguoiG.SelectedValue = maTaiXe;

                // Nếu không tìm thấy (do dữ liệu lỗi), hiển thị cảnh báo
                if (cmbNguoiG.SelectedValue?.ToString() != maTaiXe)
                {
                    cmbNguoiG.Text = "Tài xế không tồn tại";
                    cmbNguoiG.SelectedIndex = -1;
                }
            }



        }
    }
}
