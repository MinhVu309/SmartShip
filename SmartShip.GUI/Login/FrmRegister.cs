using DangNhap.BUS;
using DangNhap.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap3Lop
{
    public partial class FrmRegister : Form
    {
        private TaiKhoanService _taiKhoanService = new TaiKhoanService();
        public FrmRegister()
        {
            InitializeComponent();
            cbRole.Items.AddRange(new string[] { "KhachHang", "Shipper", "Admin" });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();

            // 🧾 Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔍 Kiểm tra trùng tên đăng nhập
            var existed = _taiKhoanService.GetAll().Any(u => u.TenDangNhap == username);
            if (existed)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧠 Tạo tài khoản mới
            var newUser = new Taikhoan
            {
                TenDangNhap = username,
                MatKhau = password,
                VaiTro = role,
                TrangThai = true,
                NgayTao = DateTime.Now,
                Email = email
            };

            // 💾 Lưu vào CSDL qua BUS
            _taiKhoanService.Them(newUser);

            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 👉 Quay lại form đăng nhập
            new Form1().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 60, 60);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.WhiteSmoke;
                    lbl.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
                }
                else if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.FromArgb(55, 75, 75);
                    ctrl.ForeColor = Color.WhiteSmoke;
                    ctrl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(180, 150, 90);
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;

                    btn.MouseEnter += (s, ev) => btn.BackColor = Color.FromArgb(200, 170, 110);
                    btn.MouseLeave += (s, ev) => btn.BackColor = Color.FromArgb(180, 150, 90);
                }
            }

        }

    }
}
