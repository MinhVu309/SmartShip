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
using SmartShip.DAL.Model;
using SmartShip.BUS.Service;

namespace SmartShip.GUI.Login
{
    public partial class FrmResetPassword : Form
    {
        private TaiKhoanService tkService = new TaiKhoanService();
        public FrmResetPassword()
        {
            InitializeComponent();
            txtEmail.Text = FrmForgotPassword.tempEmail;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string code = txtResetCode.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();

            // ⚠️ Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(code) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 8)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 8 ký tự!", "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔍 Kiểm tra mã khôi phục
            var user = tkService.KiemTraResetCode(email, code);
            if (user == null)
            {
                MessageBox.Show("❌ Mã khôi phục không hợp lệ hoặc email sai!", "Lỗi mã khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Đặt lại mật khẩu
            bool success = tkService.DatLaiMatKhau(email, newPass);
            if (success)
            {
                MessageBox.Show("✅ Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form1().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Lỗi khi cập nhật mật khẩu!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
