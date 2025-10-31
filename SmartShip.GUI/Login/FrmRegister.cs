using SmartShip.DAL.Model;
using SmartShip.BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartShip.GUI.Login;

namespace SmartShip.GUI.Login
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
            new frmLogin().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            
         
        }

    }
}