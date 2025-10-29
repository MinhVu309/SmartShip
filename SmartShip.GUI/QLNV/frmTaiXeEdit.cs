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

namespace SmartShip.GUI.QLNV
{
    public partial class frmTaiXeEdit : Form
    {
        public Taixe TaiXe { get; set; }
        private string mode;
        public frmTaiXeEdit()
        {
            InitializeComponent();
            this.mode = mode;

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
            // ========== UI THEO BẢNG MÀU YÊU CẦU ==========

            // Màu nền form
            this.BackColor = Color.FromArgb(40, 60, 60);

            // Panel chỉnh sửa
            pnlEdit.BackColor = Color.FromArgb(50, 70, 70);
            pnlEdit.BorderStyle = BorderStyle.FixedSingle;

            // Label màu trắng
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

            // Button style vàng đồng
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
            TaiXe = new Taixe()
            {
                MaTaiXe = txtMaTX.Text,
                MaNguoiDung = txtNguoiDung.Text,
                LoaiXe = txtLoaiXe.Text,
                BienSo = txtBienSo.Text,
                Diem = decimal.Parse(txtDiem.Text),
                TongDon = int.Parse(txtTongDon.Text),
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
