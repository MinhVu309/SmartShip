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

namespace SmartShip.GUI.QLKH
{
    public partial class frmNguoiDungEdit : Form
    {
        public NguoiDung nguoiDung { get; set; }
        private string mode;
        public frmNguoiDungEdit(string mode, NguoiDung data = null)
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == "edit" && data != null)
            {
                txtMaND.Text = data.MaNguoiDung;
                txtHoTen.Text = data.HoTen;
                txtSdt.Text = data.SDT;
                txtDiaChi.Text = data.DiaChiMacDinh;
                chkHoatDong.Checked = data.HoatDong ?? false;
                txtMaND.ReadOnly = true;
            }
            // ✅ Màu toàn form
            this.BackColor = System.Drawing.Color.FromArgb(40, 60, 60);

            // ✅ Panel nền cùng theme
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(40, 60, 60);

            // ✅ Style Label
            this.label1.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);

            // ✅ TextBox màu tối + chữ trắng
            this.txtMaND.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtMaND.ForeColor = System.Drawing.Color.White;
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtHoTen.ForeColor = System.Drawing.Color.White;
            this.txtSdt.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtSdt.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;

            // ✅ CheckBox màu vàng đồng
            this.chkHoatDong.ForeColor = System.Drawing.Color.FromArgb(180, 150, 90);

            // ✅ Button vàng đồng + chữ đen
            System.Drawing.Color vangDong = System.Drawing.Color.FromArgb(180, 150, 90);
            this.btnLuu.BackColor = vangDong;
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.BackColor = vangDong;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;

            // ✅ Bo viền TextBox để đồng bộ
            this.txtMaND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaND.Text))
            {
                MessageBox.Show("Mã người dùng không được để trống!");
                return;
            }

            nguoiDung = new NguoiDung()
            {
                MaNguoiDung = txtMaND.Text,
                HoTen = txtHoTen.Text,
                SDT = txtSdt.Text,
                DiaChiMacDinh = txtDiaChi.Text,
                HoatDong = chkHoatDong.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
