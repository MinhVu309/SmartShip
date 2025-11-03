using BUS.Service;
using SmartShip.GUI.Login;  
using SmartShip.BUS.Service;
using SmartShip.GUI.Ad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShip.GUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly TaiKhoanService _taiKhoanService;
        public frmLogin()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
            this.Resize += frmLogin_Resize;
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            // Căn giữa panel đăng nhập
            if (panelLogin != null)
            {
                panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
                panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
            }
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister registerForm = new FrmRegister();
            registerForm.Show();

            // Ẩn form đăng nhập hiện tại (nếu muốn)
            this.Hide();
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
                if (user.TrangThai == false)
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
                if (user != null)
                {
                    string role = user.VaiTro?.ToLower();

                    if (role == "admin")
                    {
                        FrmAdmin frm = new FrmAdmin();
                        frm.Show();
                        this.Hide();
                    }
                    else if (role == "taixe" || role == "shipper" || role == "tài xế")
                    {
                        TaiXeService taiXeService = new TaiXeService();
                        var taiXe = taiXeService.GetByTaiKhoan(user.MaTaiKhoan);

                        if (taiXe != null)
                        {
                            FrmTaiXeND frmTaiXeND = new FrmTaiXeND(taiXe.MaTaiXe);
                            frmTaiXeND.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin tài xế tương ứng!");
                        }
                    }
                }
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

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword forgotForm = new FrmForgotPassword();  // tạo form quên mật khẩu
            forgotForm.Show();                                 // mở form mới
            this.Hide();
        }
    }
}
