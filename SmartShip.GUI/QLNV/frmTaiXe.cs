using BUS.Service;
using SmartShip.DAL.Model;
using SmartShip.GUI.QLNV;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartShip.GUI
{
    public partial class frmTaiXe : Form
    {
        TaiXeService bus = new TaiXeService();

        public frmTaiXe()
        {
            InitializeComponent();
        }

        private void frmTaiXe_Load(object sender, EventArgs e)
        {
            LoadGrid();

            
           
            dgvTaiXe.BackgroundColor = Color.FromArgb(40, 60, 60);
            dgvTaiXe.GridColor = Color.FromArgb(180, 150, 90);

            dgvTaiXe.EnableHeadersVisualStyles = false;
            dgvTaiXe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 150, 90);
            dgvTaiXe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTaiXe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTaiXe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTaiXe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 80, 80);
            dgvTaiXe.DefaultCellStyle.BackColor = Color.FromArgb(50, 70, 70);
            dgvTaiXe.DefaultCellStyle.ForeColor = Color.White;

        }

        private void LoadGrid()
        {
            var dsTaiXe = bus.GetAll().ToList();
            var nguoiDungSv = new NguoiDungService();

            var data = dsTaiXe.Select(tx =>
            {
                var nd = nguoiDungSv.GetById(tx.MaNguoiDung);
                return new
                {
                    MaTaiXe = tx.MaTaiXe,
                    TenTaiXe = nd?.HoTen ?? "Chưa cập nhật",
                    LoaiXe = tx.LoaiXe,
                    BienSo = tx.BienSo,
                   
                    TongDon = tx.TongDon,
                    SanSang = tx.SanSang
                };
            }).ToList();

            dgvTaiXe.DataSource = data;

            dgvTaiXe.Columns["MaTaiXe"].HeaderText = "Mã tài xế";
            dgvTaiXe.Columns["TenTaiXe"].HeaderText = "Tên tài xế";
            dgvTaiXe.Columns["LoaiXe"].HeaderText = "Loại xe";
            dgvTaiXe.Columns["BienSo"].HeaderText = "Biển số";
           
            dgvTaiXe.Columns["TongDon"].HeaderText = "Tổng đơn";
            dgvTaiXe.Columns["SanSang"].HeaderText = "Sẵn sàng nhận đơn";

            dgvTaiXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiXe.MultiSelect = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null) return;

            string maTaiXe = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();

          
            var tx = bus.GetById(maTaiXe);

            frmTaiXeEdit f = new frmTaiXeEdit("edit", tx);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bus.CapNhat(f.TaiXe);
                LoadGrid();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài xế!", "Thông báo");
                return;
            }

            string maTX = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();
            var tx = bus.GetById(maTX);

            if (tx == null)
            {
                MessageBox.Show("Không tìm thấy tài xế!", "Lỗi");
                return;
            }

            tx.SanSang = !tx.SanSang;
            bus.CapNhat(tx);

            MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo");
            LoadGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài xế cần xóa!", "Thông báo");
                return;
            }

            string maTaiXe = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài xế này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bus.Xoa(maTaiXe);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var dsTaiXe = bus.GetAll().ToList();
            var nguoiDungSv = new NguoiDungService();

            var data = dsTaiXe.Select(tx =>
            {
                var nd = nguoiDungSv.GetById(tx.MaNguoiDung);
                return new
                {
                    MaTaiXe = tx.MaTaiXe,
                    TenTaiXe = nd?.HoTen ?? "Chưa cập nhật",
                    LoaiXe = tx.LoaiXe,
                    BienSo = tx.BienSo,
                    DiemDanhGia = tx.Diem,
                    TongDon = tx.TongDon,
                    SanSang = tx.SanSang
                };
            })
            .Where(x =>
                x.TenTaiXe.ToLower().Contains(keyword) ||
                x.BienSo.ToLower().Contains(keyword) ||
                x.MaTaiXe.ToLower().Contains(keyword))
            .ToList();

            dgvTaiXe.DataSource = data;
        }
    }
}
