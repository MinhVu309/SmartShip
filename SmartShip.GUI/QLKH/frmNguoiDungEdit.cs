using System;
using System.Windows.Forms;
using SmartShip.DAL.Model;

namespace SmartShip.GUI
{
    public partial class frmNguoiDungEdit : Form
    {
        public NguoiDung nguoiDung { get; private set; }
        private readonly string action; 

        public frmNguoiDungEdit(string action, NguoiDung nd = null)
        {
            InitializeComponent();
            this.action = action;

            if (action == "edit" && nd != null)
            {
                nguoiDung = new NguoiDung
                {
                    MaNguoiDung = nd.MaNguoiDung,
                    HoTen = nd.HoTen,
                    SDT = nd.SDT,
                    DiaChiMacDinh = nd.DiaChiMacDinh,
                    HoatDong = nd.HoatDong
                };
            }
            else
            {
                nguoiDung = new NguoiDung();
            }
        }

        private void frmNguoiDungEdit_Load(object sender, EventArgs e)
        {
            if (action == "edit" && nguoiDung != null)
            {
                txtHoTen.Text = nguoiDung.HoTen;
                txtSDT.Text = nguoiDung.SDT;
                txtDiaChi.Text = nguoiDung.DiaChiMacDinh;
                chkHoatDong.Checked = nguoiDung.HoatDong ?? false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                nguoiDung.HoTen = txtHoTen.Text.Trim();
                nguoiDung.SDT = txtSDT.Text.Trim();
                nguoiDung.DiaChiMacDinh = txtDiaChi.Text.Trim();
                nguoiDung.HoatDong = chkHoatDong.Checked;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}