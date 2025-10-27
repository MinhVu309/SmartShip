using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangNhap.DAL.Models;
using DangNhap.BUS;

namespace DangNhap3Lop
{
    public partial class Form1 : Form
    {
        private readonly TaiKhoanService _taiKhoanService;
        public Form1()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 60, 60);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SmartShip - Đăng nhập";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // 🧭 Label tiêu đề
            label1.Text = "SmartShip";
            label1.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.AutoSize = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Location = new Point((this.Width - label1.Width) / 2, 40);

            // 🧾 Label Tài khoản & Mật khẩu
            label2.ForeColor = Color.Gainsboro;
            label3.ForeColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            label3.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            // 🔐 TextBox
            txtUsername.Font = new Font("Segoe UI", 11);
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.UseSystemPasswordChar = true;

            // ✨ Button Đăng ký & Đăng nhập
            StyleButton(btnRegister);
            StyleButton(btnLogin);


            // 💫 LinkLabel
            linkForgotPassword.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            linkForgotPassword.LinkColor = Color.FromArgb(255, 215, 0);
            linkForgotPassword.ActiveLinkColor = Color.Gold;
            linkForgotPassword.VisitedLinkColor = Color.Yellow;

            // 🪶 Hiệu ứng hover cho button
            btnLogin.MouseEnter += (s, ev) => btnLogin.BackColor = Color.FromArgb(200, 170, 110);
            btnLogin.MouseLeave += (s, ev) => btnLogin.BackColor = Color.FromArgb(180, 150, 90);
            btnRegister.MouseEnter += (s, ev) => btnRegister.BackColor = Color.FromArgb(200, 170, 110);
            btnRegister.MouseLeave += (s, ev) => btnRegister.BackColor = Color.FromArgb(180, 150, 90);
            //
            CenterControls();
        }
        private void StyleButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(180, 150, 90);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Width = 110;
            btn.Height = 40;
            btn.Cursor = Cursors.Hand;
        }
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // label1: tiêu đề
            label1.Left = centerX - (label1.Width / 2);
            label1.Top = 40;

            // label2, label3, txtUsername, txtPassword
            int leftCol = centerX - 120;  // chỉnh theo cảm quan
            int topStart = 120;

            label2.Left = leftCol;
            label2.Top = topStart;

            txtUsername.Left = leftCol + label2.Width + 10;
            txtUsername.Top = topStart - 3;

            label3.Left = leftCol;
            label3.Top = label2.Top + 45;

            txtPassword.Left = leftCol + label3.Width + 10;
            txtPassword.Top = label3.Top - 3;

            // linkForgotPassword
            linkForgotPassword.Left = centerX - (linkForgotPassword.Width / 2);
            linkForgotPassword.Top = txtPassword.Top + 40;

            // Button
            int totalButtonWidth = btnRegister.Width + btnLogin.Width + 20; // khoảng cách giữa 2 nút
            int startX = centerX - (totalButtonWidth / 2);
            btnRegister.Left = startX;
            btnLogin.Left = startX + btnRegister.Width + 20;

            btnRegister.Top = linkForgotPassword.Top + 50;
            btnLogin.Top = btnRegister.Top;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra nhập thiếu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm đăng nhập từ tầng BUS
            var user = _taiKhoanService.DangNhap(username, password);

            if (user != null)
            {
                // Kiểm tra trạng thái tài khoản
                if  (user.TrangThai == false)
                    {
                    MessageBox.Show("Tài khoản của bạn đang bị khóa!",
                                    "Tài khoản bị khóa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Đăng nhập thành công
                MessageBox.Show($"Đăng nhập thành công!\nVai trò: {user.VaiTro}",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // 👉 Mở form chính hoặc ẩn form đăng nhập
                this.Hide();
                // new MainForm().Show(); // nếu có form chính
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister registerForm = new FrmRegister();
            registerForm.Show();

            // Ẩn form đăng nhập hiện tại (nếu muốn)
            this.Hide();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword forgotForm = new FrmForgotPassword();  // tạo form quên mật khẩu
            forgotForm.Show();                                 // mở form mới
            this.Hide();
        }
    }
}
