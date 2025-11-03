namespace SmartShip.GUI.Ad
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnQLDH = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(68)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 60);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🚚 SmartShip Admin";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1140, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnTop);
            this.pnlSidebar.Controls.Add(this.btnTaoDonHang);
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnSP);
            this.pnlSidebar.Controls.Add(this.btnQLDH);
            this.pnlSidebar.Controls.Add(this.btnQLKH);
            this.pnlSidebar.Controls.Add(this.btnQLNV);
            this.pnlSidebar.Controls.Add(this.lblMenu);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 640);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(12, 588);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 40);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTop
            // 
            this.btnTop.FlatAppearance.BorderSize = 0;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTop.ForeColor = System.Drawing.Color.White;
            this.btnTop.Location = new System.Drawing.Point(12, 435);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(180, 72);
            this.btnTop.TabIndex = 7;
            this.btnTop.Text = "Top Nhân Viên và Khách Hàng";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.FlatAppearance.BorderSize = 0;
            this.btnTaoDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDonHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonHang.Location = new System.Drawing.Point(12, 377);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(180, 40);
            this.btnTaoDonHang.TabIndex = 6;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.UseVisualStyleBackColor = true;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(12, 306);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(180, 40);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSP
            // 
            this.btnSP.FlatAppearance.BorderSize = 0;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSP.ForeColor = System.Drawing.Color.White;
            this.btnSP.Location = new System.Drawing.Point(26, 246);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(180, 40);
            this.btnSP.TabIndex = 4;
            this.btnSP.Text = "Quản lý sản phẩm";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.FlatAppearance.BorderSize = 0;
            this.btnQLDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLDH.ForeColor = System.Drawing.Color.White;
            this.btnQLDH.Location = new System.Drawing.Point(20, 186);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Size = new System.Drawing.Size(180, 40);
            this.btnQLDH.TabIndex = 3;
            this.btnQLDH.Text = "Quản lý đơn hàng";
            this.btnQLDH.UseVisualStyleBackColor = true;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.Location = new System.Drawing.Point(20, 126);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(180, 40);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.Location = new System.Drawing.Point(20, 70);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(180, 40);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(20, 20);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(72, 28);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(980, 640);
            this.pnlContent.TabIndex = 2;
            // 
            // FrmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartShip Admin";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLDH;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnSP;
    }
}