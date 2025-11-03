using System.Drawing;
using System.Windows.Forms;

namespace SmartShip.GUI.QLDH
{
    partial class frmQLSP
    {
        /// <summary>
        ///Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTonKho;

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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbTTSP = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grbTTSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvSanPham.ColumnHeadersHeight = 34;
            this.dgvSanPham.Location = new System.Drawing.Point(350, 104);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(550, 364);
            this.dgvSanPham.TabIndex = 4;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(13, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(119, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(225, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCapNhat.Location = new System.Drawing.Point(119, 259);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 30);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(619, 64);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMaSP.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMaSP.Location = new System.Drawing.Point(77, 26);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(249, 22);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtTenSP.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTenSP.Location = new System.Drawing.Point(77, 61);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(249, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMoTa.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMoTa.Location = new System.Drawing.Point(77, 89);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(249, 22);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDonGia.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDonGia.Location = new System.Drawing.Point(77, 117);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(249, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtTonKho
            // 
            this.txtTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtTonKho.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTonKho.Location = new System.Drawing.Point(77, 145);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(249, 22);
            this.txtTonKho.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtTimKiem.Location = new System.Drawing.Point(350, 64);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 34);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblMaSP
            // 
            this.lblMaSP.ForeColor = System.Drawing.Color.White;
            this.lblMaSP.Location = new System.Drawing.Point(15, 29);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(53, 23);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.ForeColor = System.Drawing.Color.White;
            this.lblTenSP.Location = new System.Drawing.Point(10, 61);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(58, 23);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.ForeColor = System.Drawing.Color.White;
            this.lblMoTa.Location = new System.Drawing.Point(19, 87);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(49, 23);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.Location = new System.Drawing.Point(10, 116);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(58, 23);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblTonKho
            // 
            this.lblTonKho.ForeColor = System.Drawing.Color.White;
            this.lblTonKho.Location = new System.Drawing.Point(10, 144);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(61, 23);
            this.lblTonKho.TabIndex = 5;
            this.lblTonKho.Text = "Tồn kho:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.lblTitle.Location = new System.Drawing.Point(299, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Sản Phẩm";
            // 
            // grbTTSP
            // 
            this.grbTTSP.Controls.Add(this.lblMaSP);
            this.grbTTSP.Controls.Add(this.txtMaSP);
            this.grbTTSP.Controls.Add(this.lblTonKho);
            this.grbTTSP.Controls.Add(this.lblDonGia);
            this.grbTTSP.Controls.Add(this.lblMoTa);
            this.grbTTSP.Controls.Add(this.btnCapNhat);
            this.grbTTSP.Controls.Add(this.btnXoa);
            this.grbTTSP.Controls.Add(this.btnSua);
            this.grbTTSP.Controls.Add(this.btnThem);
            this.grbTTSP.Controls.Add(this.lblTenSP);
            this.grbTTSP.Controls.Add(this.txtTonKho);
            this.grbTTSP.Controls.Add(this.txtDonGia);
            this.grbTTSP.Controls.Add(this.txtMoTa);
            this.grbTTSP.Controls.Add(this.txtTenSP);
            this.grbTTSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbTTSP.Location = new System.Drawing.Point(12, 104);
            this.grbTTSP.Name = "grbTTSP";
            this.grbTTSP.Size = new System.Drawing.Size(332, 364);
            this.grbTTSP.TabIndex = 18;
            this.grbTTSP.TabStop = false;
            this.grbTTSP.Text = "Thông tín sản phẩm";
            // mau
            // 🎨 Bảng màu chủ đạo dùng toàn hệ thống
            Color mossGreen = Color.FromArgb(40, 60, 60);      // Xanh rêu sẫm (nền chính)
            Color darkGreen = Color.FromArgb(50, 70, 70);      // Xanh rêu trung bình
            Color inputBg = Color.FromArgb(60, 80, 80);      // Nền ô nhập
            Color goldButton = Color.FromArgb(180, 150, 90);    // Vàng đồng (nút chính)
            Color goldAccent = Color.FromArgb(200, 170, 110);   // Vàng nhạt (hover, header)
            Color textColor = Color.White;                     // Màu chữ trắng
            Color blackText = Color.Black;                     // Màu chữ đen (dùng trên nền vàng)
                                                               // ====================
                                                               //  🎨 DataGridView Style
                                                               // ====================
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 70, 70);
            this.dgvSanPham.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 150, 90);
            this.dgvSanPham.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.RowTemplate.Height = 30;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            // ====================
            //  🎨 Button Style (Thêm, Sửa, Xóa, Cập nhật)
            // ====================
            System.Drawing.Color btnBack = System.Drawing.Color.FromArgb(180, 150, 90);
            System.Drawing.Color btnFore = System.Drawing.Color.White;
            System.Drawing.Color btnHover = System.Drawing.Color.FromArgb(200, 170, 110);

            // Nút Thêm
            this.btnThem.BackColor = btnBack;
            this.btnThem.ForeColor = btnFore;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseOverBackColor = btnHover;
            this.btnThem.FlatAppearance.MouseDownBackColor = btnHover;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Nút Sửa
            this.btnSua.BackColor = btnBack;
            this.btnSua.ForeColor = btnFore;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseOverBackColor = btnHover;
            this.btnSua.FlatAppearance.MouseDownBackColor = btnHover;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Nút Xóa
            this.btnXoa.BackColor = btnBack;
            this.btnXoa.ForeColor = btnFore;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseOverBackColor = btnHover;
            this.btnXoa.FlatAppearance.MouseDownBackColor = btnHover;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Nút Cập Nhật
            this.btnCapNhat.BackColor = btnBack;
            this.btnCapNhat.ForeColor = btnFore;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.FlatAppearance.BorderSize = 2;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = btnHover;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = btnHover;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // 
            // QLSP
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(920, 480);
            this.Controls.Add(this.grbTTSP);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "QLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grbTTSP.ResumeLayout(false);
            this.grbTTSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbTTSP;
    }
}