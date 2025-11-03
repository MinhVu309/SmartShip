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
            TaiXe = data;

            if (mode == "edit" && data != null)
            {
                txtLoaiXe.Text = data.LoaiXe;
                txtBienSo.Text = data.BienSo;
                txtTongDon.Text = data.TongDon?.ToString();
                chkSanSang.Checked = data.SanSang ?? false;
            }
        }

        private void SetupUI()
        {
            this.BackColor = Color.FromArgb(40, 60, 60);
            pnlEdit.BackColor = Color.FromArgb(50, 70, 70);
            pnlEdit.BorderStyle = BorderStyle.FixedSingle;

            foreach (Control c in pnlEdit.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = Color.White;
                    c.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }

            TextBox[] txts = { txtLoaiXe, txtBienSo, txtTongDon };
            foreach (TextBox t in txts)
            {
                t.BackColor = Color.FromArgb(60, 80, 80);
                t.ForeColor = Color.White;
                t.BorderStyle = BorderStyle.FixedSingle;
            }

            chkSanSang.ForeColor = Color.White;

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
            if (TaiXe == null)
            {
                MessageBox.Show("Dữ liệu tài xế không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tongDonStr = txtTongDon.Text.Replace(",", "").Replace(".", "").Trim();

            // CẬP NHẬT TRỰC TIẾP VÀO ĐỐI TƯỢNG CŨ
            TaiXe.LoaiXe = txtLoaiXe.Text.Trim();
            TaiXe.BienSo = txtBienSo.Text.Trim();
            TaiXe.TongDon = int.TryParse(tongDonStr, out int tongDon) ? tongDon : 0;
            TaiXe.SanSang = chkSanSang.Checked;

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
