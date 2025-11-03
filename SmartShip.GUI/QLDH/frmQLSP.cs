using BUS.Service;
using SmartShip.BUS.Service;
using SmartShip.DAL.Model;
using SmartShip.GUI.QLDH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace SmartShip.GUI.QLDH
{
    public partial class frmQLSP : Form
    {
        private SanPhamService spService = new SanPhamService();
        public frmQLSP()
        {
            InitializeComponent();
        
        }
       
        private void QLSP_Load(object sender, EventArgs e)
        {
    
            LoadSanPham();
           
        }
        private void LoadSanPham()
        {
            dgvSanPham.AutoGenerateColumns = true;
            dgvSanPham.DataSource = spService.GetAll();

            // Đổi tên cột — đặt sau DataSource
            if (dgvSanPham.Columns["MaSanPham"] != null)
                dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã SP";

            if (dgvSanPham.Columns["TenSanPham"] != null)
                dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên SP";

            if (dgvSanPham.Columns["MoTa"] != null)
                dgvSanPham.Columns["MoTa"].HeaderText = "Mô Tả";

            if (dgvSanPham.Columns["DonGia"] != null)
                dgvSanPham.Columns["DonGia"].HeaderText = "Đơn Giá";

            if (dgvSanPham.Columns["TonKho"] != null)
                dgvSanPham.Columns["TonKho"].HeaderText = "Tồn Kho";
            if (dgvSanPham.Columns["NgayNhapHang"] != null)
                dgvSanPham.Columns["NgayNhapHang"].Visible = false;

            // Ẩn navigation property
            foreach (DataGridViewColumn col in dgvSanPham.Columns)
            {
                if (col.ValueType != null &&
                    col.ValueType.Namespace == "System.Collections.Generic")
                {
                    col.Visible = false;
                }
            }
        }

      

    
        //      CLEAR INPUT TEXTBOX
        private void ClearForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtMoTa.Clear();
            txtDonGia.Clear();
            txtTonKho.Clear();
        }
       

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString();
                txtMoTa.Text = dgvSanPham.Rows[e.RowIndex].Cells["MoTa"].Value?.ToString();
                txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtTonKho.Text = dgvSanPham.Rows[e.RowIndex].Cells["TonKho"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SanPham
                {
                    MaSanPham = txtMaSP.Text,
                    TenSanPham = txtTenSP.Text,
                    MoTa = txtMoTa.Text,
                    DonGia = decimal.Parse(txtDonGia.Text),
                    TonKho = string.IsNullOrEmpty(txtTonKho.Text) ? 0 : int.Parse(txtTonKho.Text)
                };

                spService.Them(sp);
                LoadSanPham();
                ClearForm();

                MessageBox.Show("Đã thêm sản phẩm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SanPham
                {
                    MaSanPham = txtMaSP.Text,
                    TenSanPham = txtTenSP.Text,
                    MoTa = txtMoTa.Text,
                    DonGia = decimal.Parse(txtDonGia.Text),
                    TonKho = string.IsNullOrEmpty(txtTonKho.Text) ? 0 : int.Parse(txtTonKho.Text)
                };

                spService.CapNhat(sp);
                LoadSanPham();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?",
                 "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    spService.Xoa(txtMaSP.Text);
                    LoadSanPham();
                    ClearForm();

                    MessageBox.Show("Đã xóa sản phẩm!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = spService.TimKiem(keyword);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            ClearForm();
        }
    }
}
