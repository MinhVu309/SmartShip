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

namespace SmartShip.GUI.Login
{
    public partial class FrmTaiXeND : Form
    {
        private readonly TaiXeService taiXeService = new TaiXeService();
        private readonly DonHangService donHangService = new DonHangService();
        private readonly string maTaiXe;

        public FrmTaiXeND(string maTaiXe)
        {
            InitializeComponent();
            this.maTaiXe = maTaiXe;
        }

        private void FrmTaiXeND_Load(object sender, EventArgs e)
        {
            LoadDonHang();
            LoadThongTinTaiXe();

            dgvDonHang.CurrentCellDirtyStateChanged += dgvDonHang_CurrentCellDirtyStateChanged;
            dgvDonHang.CellValueChanged += dgvDonHang_CellValueChanged;

            dgvDonHang.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void LoadThongTinTaiXe()
        {
            var tx = taiXeService.GetThongTinTaiXe(maTaiXe);
            if (tx != null)
            {
                lblHoTen.Text = tx.HoTen;
                lblSDT.Text = tx.SDT;
                lblBienSo.Text = tx.BienSo;
            }
        }

        private void LoadDonHang()
        {
            var list = donHangService.GetByTaiXe(maTaiXe)
                .Select(d => new DonHangView
                {
                    MaDon = d.MaDon,
                    KhachHang = d.NguoiDung?.HoTen ?? "",
                    DiaChi = d.DiaChi?.DiaChiChiTiet ?? "",
                    TrangThai = d.TrangThai,
                    // FIX lỗi DateTime? -> DateTime
                    NgayTao = d.NgayTao ?? DateTime.MinValue,
                    DaGiao = d.TrangThai == "Hoàn thành"
                })
                .ToList();

            var binding = new BindingList<DonHangView>(list);
            dgvDonHang.DataSource = binding;

            // Cho phép tự tạo cột
            dgvDonHang.AutoGenerateColumns = true;
            dgvDonHang.ReadOnly = false;

            // Nếu cột "ChonGiao" đã tồn tại, xóa để thêm mới
            if (dgvDonHang.Columns.Contains("ChonGiao"))
                dgvDonHang.Columns.Remove("ChonGiao");

            // ✅ Thêm cột checkbox
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
            {
                Name = "ChonGiao",
                HeaderText = "Chọn giao",
                Width = 80,
                ReadOnly = false
            };
            dgvDonHang.Columns.Insert(0, chkCol); // Thêm ở đầu bảng

            // Các cột khác chỉ đọc
            foreach (DataGridViewColumn col in dgvDonHang.Columns)
            {
                if (col.Name != "ChonGiao")
                    col.ReadOnly = true;
            }

            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dgvDonHang.Rows)
            {
                if (row.IsNewRow) continue; // tránh lỗi dòng trống

                // FIX: tránh null
                bool isChecked = row.Cells["ChonGiao"].Value != null &&
                                 Convert.ToBoolean(row.Cells["ChonGiao"].Value);

                if (isChecked)
                {
                    string maDon = row.Cells["MaDon"].Value.ToString();
                    donHangService.CapNhatTrangThai(maDon, "Hoàn thành");
                    count++;
                }
            }

            if (count > 0)
            {
                MessageBox.Show($"✅ Đã cập nhật {count} đơn hàng sang trạng thái 'Hoàn thành'.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("⚠️ Vui lòng chọn ít nhất một đơn hàng để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDonHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDonHang.IsCurrentCellDirty)
            {
                dgvDonHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDonHang.Columns[e.ColumnIndex].Name == "ChonGiao")
            {
                var maDon = dgvDonHang.Rows[e.RowIndex].Cells["MaDon"].Value?.ToString();
                var val = dgvDonHang.Rows[e.RowIndex].Cells["ChonGiao"].Value;
                bool isChecked = val != null && (bool)val;
                Console.WriteLine($"[DEBUG] {maDon} => {isChecked}");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn đăng xuất?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    frmLogin f = new frmLogin(); // quay về form đăng nhập
                    f.Show();
                }
            }
        }
    }

   
   
}
