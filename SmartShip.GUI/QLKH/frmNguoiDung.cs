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
        UserService bus = new UserService(new UserRepository());
        string action = ""; // "add" hoặc "edit"
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadGrid();
            pnlEdit.Visible = false;
        }
        private void LoadGrid()
        {
            dgvNguoiDung.DataSource = bus.GetAll();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadGrid();
            txtSearch.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource = bus.Search(txtSearch.Text.Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "add";
            pnlEdit.Visible = true;
            txtMaND.Clear();
            txtHoTen.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
            chkHoatDong.Checked = true;
            txtMaND.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.CurrentRow == null) return;

            action = "edit";
            pnlEdit.Visible = true;
            txtMaND.Text = dgvNguoiDung.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
            txtHoTen.Text = dgvNguoiDung.CurrentRow.Cells["HoTen"].Value.ToString();
            txtSdt.Text = dgvNguoiDung.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgvNguoiDung.CurrentRow.Cells["DiaChiMacDinh"].Value.ToString();
            chkHoatDong.Checked = (bool)dgvNguoiDung.CurrentRow.Cells["HoatDong"].Value;
            txtMaND.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung()
            {
                MaNguoiDung = txtMaND.Text,
                HoTen = txtHoTen.Text,
                SDT = txtSdt.Text,
                DiaChiMacDinh = txtDiaChi.Text,
                HoatDong = chkHoatDong.Checked
            };

            if (action == "add")
                bus.Add(nd);
            else if (action == "edit")
                bus.Update(nd);

            LoadGrid();
            pnlEdit.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }
    }
}
