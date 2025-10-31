using SmartShip.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartShip.GUI.QLNV
{
    public partial class frmTaiXeEdit : Form
    {
        public Taixe TaiXe { get; set; }
        private string mode;

        public frmTaiXeEdit(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            SetupUI();
        }

        public frmTaiXeEdit(string mode, Taixe data)
        {
            InitializeComponent();
            this.mode = mode;
            SetupUI();

            if (mode == "edit" && data != null)
            {
                txtMaTX.Text = data.MaTaiXe;
                txtNguoiDung.Text = data.MaNguoiDung;
                txtLoaiXe.Text = data.LoaiXe;
                txtBienSo.Text = data.BienSo;
                txtDiem.Text = data.Diem.ToString();
                txtTongDon.Text = data.TongDon.ToString();
                chkSanSang.Checked = data.SanSang ?? false;

                txtMaTX.ReadOnly = true;
            }
        }

        private void SetupUI()
        {
            // Màu nền form
            this.BackColor = Color.FromArgb(40, 60, 60);

            // Panel chỉnh sửa
            pnlEdit.BackColor = Color.FromArgb(50, 70, 70);
            pnlEdit.BorderStyle = BorderStyle.FixedSingle;

            // Label
            foreach (Control c in pnlEdit.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = Color.White;
                    c.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }

            // TextBox style
            TextBox[] txts = { txtMaTX, txtNguoiDung, txtLoaiXe, txtBienSo, txtDiem, txtTongDon };
            foreach (TextBox t in txts)
            {
                t.BackColor = Color.FromArgb(60, 80, 80);
                t.ForeColor = Color.White;
                t.BorderStyle = BorderStyle.FixedSingle;
            }

            // Checkbox style
            chkSanSang.ForeColor = Color.White;

            // Button style
            Button[] buttons = { btnLuu, btnHuy };
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.FromArgb(180, 150, 90);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaTX.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tài xế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiXe = new Taixe()
            {
                MaTaiXe = txtMaTX.Text,
                MaNguoiDung = txtNguoiDung.Text,
                LoaiXe = txtLoaiXe.Text,
                BienSo = txtBienSo.Text,
                Diem = decimal.TryParse(txtDiem.Text, out decimal diem) ? diem : 0,
                TongDon = int.TryParse(txtTongDon.Text, out int tongDon) ? tongDon : 0,
                SanSang = chkSanSang.Checked
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
