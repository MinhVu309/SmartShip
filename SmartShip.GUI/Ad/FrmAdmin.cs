using DA.GUI;
using SmartShip.GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShip.GUI.Ad
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiXe());
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLDH());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongke());
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaoDH());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn đăng xuất?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    frmLogin f = new frmLogin(); // quay về form đăng nhập
                    f.Show();
                }
            }
        }

        // Khi form load
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SmartShip - Bảng điều khiển Admin";
        }
        

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNguoiDung());
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTop());
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDH.frmQLSP());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
