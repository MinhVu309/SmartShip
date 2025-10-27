using DangNhap.BUS;
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
    public partial class FrmForgotPassword : Form
    {
        private readonly TaiKhoanService _taiKhoanService = new TaiKhoanService();
        public static string tempEmail;
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // ✅ Lấy tài khoản theo email (dùng service BUS)
            var user = _taiKhoanService.GetAll().FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                MessageBox.Show("❌ Email không tồn tại trong hệ thống!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔢 Tạo mã khôi phục ngẫu nhiên (6 chữ số)
            string code = new Random().Next(100000, 999999).ToString();

            // 🧠 Lưu mã reset vào DB thông qua BUS
            user.ResetCode = code;
            _taiKhoanService.CapNhat(user);

            // 📧 Giả lập gửi mã qua email
            MessageBox.Show($"📧 Mã khôi phục của bạn là: {code}", "Khôi phục mật khẩu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("✅ Mã đã được gửi! Nhấn 'Tiếp tục' để đổi mật khẩu.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tempEmail = email;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tempEmail))
            {
                MessageBox.Show("Vui lòng nhập email và nhấn 'Gửi mã' trước!",
                                "Chưa gửi mã",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FrmResetPassword frm = new FrmResetPassword();
            frm.Show();
            this.Close();
        }
    }
}
