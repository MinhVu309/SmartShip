using System.Drawing;
using System.Windows.Forms;

namespace DA.GUI
{
    partial class frmQLDH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDH));
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNguoiG = new System.Windows.Forms.ComboBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtDCG = new System.Windows.Forms.TextBox();
            this.txtNguoiD = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocHoaDon = new System.Drawing.Printing.PrintDocument();
            this.previewDlgHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToResizeColumns = false;
            this.dgvDonHang.AllowUserToResizeRows = false;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.dgvDonHang.Location = new System.Drawing.Point(6, 70);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(628, 250);
            this.dgvDonHang.TabIndex = 10;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDH_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(801, 293);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 44);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTim.Location = new System.Drawing.Point(132, 44);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 29);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm Đơn";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtTim.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTim.Location = new System.Drawing.Point(18, 44);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(108, 28);
            this.txtTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(331, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Đơn Hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inHóaĐơnToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.cmbNguoiG);
            this.groupBox1.Controls.Add(this.cmbTrangThai);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dgvDonHang);
            this.groupBox1.Controls.Add(this.txtDCG);
            this.groupBox1.Controls.Add(this.txtNguoiD);
            this.groupBox1.Controls.Add(this.txtMaDH);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 387);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Đơn hàng";
            // 
            // cmbNguoiG
            // 
            this.cmbNguoiG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cmbNguoiG.FormattingEnabled = true;
            this.cmbNguoiG.Location = new System.Drawing.Point(738, 159);
            this.cmbNguoiG.Name = "cmbNguoiG";
            this.cmbNguoiG.Size = new System.Drawing.Size(191, 26);
            this.cmbNguoiG.TabIndex = 3;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cmbTrangThai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(738, 236);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(191, 26);
            this.cmbTrangThai.TabIndex = 5;
            // 
            // txtDCG
            // 
            this.txtDCG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDCG.Location = new System.Drawing.Point(738, 200);
            this.txtDCG.Name = "txtDCG";
            this.txtDCG.Size = new System.Drawing.Size(191, 24);
            this.txtDCG.TabIndex = 4;
            // 
            // txtNguoiD
            // 
            this.txtNguoiD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtNguoiD.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNguoiD.Location = new System.Drawing.Point(738, 116);
            this.txtNguoiD.Name = "txtNguoiD";
            this.txtNguoiD.Size = new System.Drawing.Size(191, 24);
            this.txtNguoiD.TabIndex = 2;
            // 
            // txtMaDH
            // 
            this.txtMaDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMaDH.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMaDH.Location = new System.Drawing.Point(738, 70);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(191, 24);
            this.txtMaDH.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCapNhat.Location = new System.Drawing.Point(677, 293);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 44);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(640, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ Giao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(655, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người Đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(649, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người Giao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(651, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(674, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ĐH";
            // 
            // printDocHoaDon
            // 
            this.printDocHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocHoaDon_PrintPage);
            // 
            // previewDlgHoaDon
            // 
            this.previewDlgHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewDlgHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewDlgHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.previewDlgHoaDon.Document = this.printDocHoaDon;
            this.previewDlgHoaDon.Enabled = true;
            this.previewDlgHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("previewDlgHoaDon.Icon")));
            this.previewDlgHoaDon.Name = "printPreviewDialog1";
            this.previewDlgHoaDon.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(834, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 29);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // mau
            // Màu chủ đạo
            this.BackColor = Color.FromArgb(40, 60, 60);
            this.ForeColor = Color.Yellow;

            this.groupBox1.BackColor = Color.FromArgb(40, 60, 60);
            this.groupBox1.ForeColor = Color.Yellow;

            // MenuStrip
            this.menuStrip1.BackColor = Color.FromArgb(40, 60, 60);
            this.menuStrip1.ForeColor = Color.Yellow;

            // DataGridView
            this.dgvDonHang.BackgroundColor = Color.FromArgb(40, 60, 60);
            this.dgvDonHang.GridColor = Color.FromArgb(200, 170, 110);
            this.dgvDonHang.DefaultCellStyle.BackColor = Color.FromArgb(60, 80, 80);
            this.dgvDonHang.DefaultCellStyle.ForeColor = Color.White;
            this.dgvDonHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 70, 70);
            this.dgvDonHang.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            this.dgvDonHang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 150, 90);
            this.dgvDonHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 150, 90);
            this.dgvDonHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgvDonHang.EnableHeadersVisualStyles = false;

            // Button
            this.btnXoa.BackColor = Color.FromArgb(180, 150, 90);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // TextBox
            this.txtMaDH.BackColor = Color.FromArgb(60, 80, 80);
            this.txtMaDH.ForeColor = Color.White;
            this.txtMaDH.BorderStyle = BorderStyle.FixedSingle;

            this.txtDCG.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtDCG.ForeColor = System.Drawing.Color.White;
            this.txtDCG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.cmbNguoiG.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.cmbNguoiG.ForeColor = System.Drawing.Color.White;
            this.cmbNguoiG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.White;
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //
            // frmQLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(965, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLDH";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cmbNguoiG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocHoaDon;
        private System.Windows.Forms.PrintPreviewDialog previewDlgHoaDon;
        private System.Windows.Forms.TextBox txtNguoiD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDCG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
    }
}

