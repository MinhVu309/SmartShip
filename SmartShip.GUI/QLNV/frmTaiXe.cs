using SmartShip.BUS;
using SmartShip.DAL;
using SmartShip.DAL.Model;
using System;
using System.Windows.Forms;
namespace SmartShip.GUI
{
    public partial class frmTaiXe : Form
    {
        DriverService bus = new DriverService(new DriverRepository());
        string action = "";
        public frmTaiXe()
        {
            InitializeComponent();
        }

        private void frmTaiXe_Load(object sender, EventArgs e)
        {
            LoadGrid();
            pnlEdit.Visible = false;
        }
        private void LoadGrid()
        {
            dgvTaiXe.DataSource = bus.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "add";
            pnlEdit.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null) return;

            action = "edit";
            pnlEdit.Visible = true;

            txtMaTX.Text = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();
            txtNguoiDung.Text = dgvTaiXe.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
            txtLoaiXe.Text = dgvTaiXe.CurrentRow.Cells["LoaiXe"].Value.ToString();
            txtBienSo.Text = dgvTaiXe.CurrentRow.Cells["BienSo"].Value.ToString();
            txtDiem.Text = dgvTaiXe.CurrentRow.Cells["Diem"].Value.ToString();
            txtTongDon.Text = dgvTaiXe.CurrentRow.Cells["TongDon"].Value.ToString();
            chkSanSang.Checked = (bool)dgvTaiXe.CurrentRow.Cells["SanSang"].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null) return;

            string id = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();
            bus.Delete(id);
            LoadGrid();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTaiXe.CurrentRow == null) return;

            string id = dgvTaiXe.CurrentRow.Cells["MaTaiXe"].Value.ToString();
            bus.ToggleStatus(id);
            LoadGrid();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvTaiXe.DataSource = bus.Search(txtSearch.Text.Trim());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Taixe tx = new Taixe()
            {
                MaTaiXe = txtMaTX.Text,
                MaNguoiDung = txtNguoiDung.Text,
                LoaiXe = txtLoaiXe.Text,
                BienSo = txtBienSo.Text,
                Diem = decimal.Parse(txtDiem.Text),
                TongDon = int.Parse(txtTongDon.Text),
                SanSang = chkSanSang.Checked
            };

            if (action == "add")
                bus.Add(tx);
            else if (action == "edit")
                bus.Update(tx);

            LoadGrid();
            pnlEdit.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }
    }
}
