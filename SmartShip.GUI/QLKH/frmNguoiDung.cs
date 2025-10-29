using SmartShip.BUS;
using SmartShip.DAL;
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


namespace SmartShip.GUI
{
    public partial class frmNguoiDung : Form
    {
        NguoiDungService bus = new NguoiDungService(new NguoiDungRepository());
        string action = ""; // "add" hoặc "edit"
        public frmNguoiDung()
        {
            InitializeComponent();
            // ✅ Set màu nền Form
            this.BackColor = System.Drawing.Color.FromArgb(40, 60, 60);

            // ✅ Format DataGridView
            this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(40, 60, 60);
            this.dgvNguoiDung.GridColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.dgvNguoiDung.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 60, 60);
            this.dgvNguoiDung.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoiDung.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 180, 80);
            this.dgvNguoiDung.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // ✅ Header DataGridView
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoiDung.EnableHeadersVisualStyles = false;

            // ✅ Button Style màu vàng đồng
            System.Drawing.Color vangDong = System.Drawing.Color.FromArgb(180, 150, 90);

            this.btnThem.BackColor = vangDong;
            this.btnSua.BackColor = vangDong;
            this.btnLamMoi.BackColor = vangDong;
            this.btnTimKiem.BackColor = vangDong;

            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;

            // ✅ TextBox Search
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dgvNguoiDung.DataSource = bus.GetAll();
            // Ẩn các cột không cần thiết
            dgvNguoiDung.Columns["ResetCode"].Visible = false;
            dgvNguoiDung.Columns["DiaChi"].Visible = false;
            dgvNguoiDung.Columns["DonHang"].Visible = false;
            dgvNguoiDung.Columns["Taikhoan"].Visible = false;
            dgvNguoiDung.Columns["Taixe"].Visible = false;

            // Format lại tên cột chính
            dgvNguoiDung.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";
            dgvNguoiDung.Columns["HoTen"].HeaderText = "Họ tên";
            dgvNguoiDung.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNguoiDung.Columns["DiaChiMacDinh"].HeaderText = "Địa chỉ";
            dgvNguoiDung.Columns["HoatDong"].HeaderText = "Hoạt động";

            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNguoiDungEdit frm = new frmNguoiDungEdit("add");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bus.Add(frm.nguoiDung);
                LoadGrid();
            }
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
                bus.Update(frm.nguoiDung);
                LoadGrid();
            }
        }

       

       
    }
}
