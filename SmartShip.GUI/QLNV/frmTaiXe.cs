using SmartShip.BUS;
using SmartShip.DAL;
using SmartShip.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace SmartShip.GUI
{
    public partial class frmTaiXe : Form
    {
        TaiXeService bus = new TaiXeService(new TaiXeRepository());
        string action = "";
        public frmTaiXe()
        {
            InitializeComponent();
        }

        private void frmTaiXe_Load(object sender, EventArgs e)
        {
            LoadGrid();
            // ========== UI THEO BẢNG MÀU YÊU CẦU ==========

            // Màu nền form
            this.BackColor = Color.FromArgb(40, 60, 60);

            // Màu nền cho DataGridView
            dgvTaiXe.BackgroundColor = Color.FromArgb(40, 60, 60);
            dgvTaiXe.GridColor = Color.FromArgb(180, 150, 90);

            // Header DataGridView
            dgvTaiXe.EnableHeadersVisualStyles = false;
            dgvTaiXe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 150, 90);
            dgvTaiXe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTaiXe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTaiXe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Dòng xen kẽ
            dgvTaiXe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 80, 80);
            dgvTaiXe.DefaultCellStyle.BackColor = Color.FromArgb(50, 70, 70);
            dgvTaiXe.DefaultCellStyle.ForeColor = Color.White;

            // Bo góc nút (nếu .NET hỗ trợ)
            btnThem.FlatStyle = FlatStyle.Flat;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnTimKiem.FlatStyle = FlatStyle.Flat;

            // Đặt màu cho các nút
            Button[] buttons = { btnThem, btnSua, btnXoa, btnCapNhat, btnTimKiem };
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.FromArgb(180, 150, 90);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }

            // TextBox tìm kiếm tông xám nhẹ
            txtSearch.BackColor = Color.FromArgb(60, 80, 80);
            txtSearch.ForeColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
        }
        private void LoadGrid()
        {
            dgvTaiXe.DataSource = bus.GetAll();
            dgvTaiXe.Columns["DonHang"].Visible = false;
            dgvTaiXe.Columns["NguoiDung"].Visible = false;
            dgvTaiXe.Columns["PhanCong"].Visible = false;

            dgvTaiXe.Columns["MaTaiXe"].HeaderText = "Mã tài xế";
            dgvTaiXe.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";
            dgvTaiXe.Columns["LoaiXe"].HeaderText = "Loại xe";
            dgvTaiXe.Columns["BienSo"].HeaderText = "Biển số";
            dgvTaiXe.Columns["Diem"].HeaderText = "Điểm đánh giá";
            dgvTaiXe.Columns["TongDon"].HeaderText = "Tổng đơn";
            dgvTaiXe.Columns["SanSang"].HeaderText = "Sẵn sàng nhận đơn";

            dgvTaiXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiXe.MultiSelect = false;

            dgvTaiXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaiXeEdit f = new frmTaiXeEdit("add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                bus.Add(f.TaiXe);
                LoadGrid();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null) return;

            Taixe data = new Taixe()
            {
                MaTaiXe = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString(),
                MaNguoiDung = dgvTaiXe.CurrentRow.Cells["MaNguoiDung"].Value.ToString(),
                LoaiXe = dgvTaiXe.CurrentRow.Cells["LoaiXe"].Value.ToString(),
                BienSo = dgvTaiXe.CurrentRow.Cells["BienSo"].Value.ToString(),
                Diem = Convert.ToDecimal(dgvTaiXe.CurrentRow.Cells["Diem"].Value),
                TongDon = Convert.ToInt32(dgvTaiXe.CurrentRow.Cells["TongDon"].Value),
                SanSang = dgvTaiXe.CurrentRow.Cells["SanSang"].Value as bool? ?? false
            };

            frmTaiXeEdit f = new frmTaiXeEdit("edit", data);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bus.Update(f.TaiXe);
                LoadGrid();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài xế!", "Thông báo");
                return;
            }

            string maTX = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();

            // Gọi service đổi trạng thái
            bus.ToggleStatus(maTX);

            MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo");

            LoadGrid(); // Refresh lại DataGridView
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }
    }
}
