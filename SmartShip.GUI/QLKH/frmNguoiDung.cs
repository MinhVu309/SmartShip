using SmartShip.BUS;
using SmartShip.DAL;
using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using BUS.Service;


namespace SmartShip.GUI
{
    public partial class frmNguoiDung : Form
    {
        NguoiDungService bus = new NguoiDungService();
        string action = ""; 
        public frmNguoiDung()
        {
            InitializeComponent();
            

            
            this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(40, 60, 60);
            this.dgvNguoiDung.GridColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.dgvNguoiDung.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 60, 60);
            this.dgvNguoiDung.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoiDung.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 180, 80);
            this.dgvNguoiDung.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoiDung.EnableHeadersVisualStyles = false;

            

            

        }
        

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            var khachHangList = bus.GetAll().Where(nd => nd.VaiTro == "KhachHang").ToList();

            dgvNguoiDung.DataSource = khachHangList;

            
            string[] cotCanAn = { "DiaChis", "DonHangs", "Taikhoan", "Taixes", "ResetCode", "VaiTro" };
            foreach (string tenCot in cotCanAn)
            {
                if (dgvNguoiDung.Columns.Contains(tenCot))
                    dgvNguoiDung.Columns[tenCot].Visible = false;
            }

           
            if (dgvNguoiDung.Columns.Contains("MaNguoiDung"))
                dgvNguoiDung.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";

            if (dgvNguoiDung.Columns.Contains("MaTaiKhoan"))
                dgvNguoiDung.Columns["MaTaiKhoan"].HeaderText = "Mã tài khoản";

            if (dgvNguoiDung.Columns.Contains("HoTen"))
                dgvNguoiDung.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvNguoiDung.Columns.Contains("SDT"))
                dgvNguoiDung.Columns["SDT"].HeaderText = "Số điện thoại";

            if (dgvNguoiDung.Columns.Contains("DiaChiMacDinh"))
                dgvNguoiDung.Columns["DiaChiMacDinh"].HeaderText = "Địa chỉ mặc định";

            if (dgvNguoiDung.Columns.Contains("Email"))
                dgvNguoiDung.Columns["Email"].HeaderText = "Email";

            if (dgvNguoiDung.Columns.Contains("HoatDong"))
                dgvNguoiDung.Columns["HoatDong"].HeaderText = "Hoạt động";

            if (dgvNguoiDung.Columns.Contains("NgayTao"))
                dgvNguoiDung.Columns["NgayTao"].HeaderText = "Ngày tạo";

            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.CurrentRow == null) return;

            var nd = new NguoiDung
            {
                MaNguoiDung = dgvNguoiDung.CurrentRow.Cells["MaNguoiDung"].Value.ToString(),
                HoTen = dgvNguoiDung.CurrentRow.Cells["HoTen"].Value.ToString(),
                SDT = dgvNguoiDung.CurrentRow.Cells["SDT"].Value.ToString(),
                DiaChiMacDinh = dgvNguoiDung.CurrentRow.Cells["DiaChiMacDinh"].Value.ToString(),
                HoatDong = (bool)dgvNguoiDung.CurrentRow.Cells["HoatDong"].Value
            };

            frmNguoiDungEdit frm = new frmNguoiDungEdit("edit", nd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bus.CapNhat(frm.nguoiDung);
                LoadGrid();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {

                txtSearch.Text = string.Empty;


                LoadGrid();


                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi làm mới dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
               
                var ds = bus.GetAll();

                var ketQua = ds.Where(nd =>
                    (nd.HoTen != null && nd.HoTen.ToLower().Contains(keyword)) ||
                    (nd.SDT != null && nd.SDT.ToLower().Contains(keyword)) ||
                    (nd.MaNguoiDung != null && nd.MaNguoiDung.ToLower().Contains(keyword))
                ).ToList();

              
                dgvNguoiDung.DataSource = ketQua;

              
                if (ketQua.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
