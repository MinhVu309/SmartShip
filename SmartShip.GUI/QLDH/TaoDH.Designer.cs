namespace DA.GUI
{
    partial class TaoDH
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTDH = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.txtTongT = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbKH = new System.Windows.Forms.ComboBox();
            this.cmbDC = new System.Windows.Forms.ComboBox();
            this.grbTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Đơn Hàng";
            // 
            // grbTTDH
            // 
            this.grbTTDH.Controls.Add(this.dgvDS);
            this.grbTTDH.Controls.Add(this.nudSL);
            this.grbTTDH.Controls.Add(this.txtTongT);
            this.grbTTDH.Controls.Add(this.txtTenSP);
            this.grbTTDH.Controls.Add(this.txtGhiChu);
            this.grbTTDH.Controls.Add(this.cmbDC);
            this.grbTTDH.Controls.Add(this.cmbKH);
            this.grbTTDH.Controls.Add(this.cmbNV);
            this.grbTTDH.Controls.Add(this.label5);
            this.grbTTDH.Controls.Add(this.label6);
            this.grbTTDH.Controls.Add(this.label3);
            this.grbTTDH.Controls.Add(this.label8);
            this.grbTTDH.Controls.Add(this.label7);
            this.grbTTDH.Controls.Add(this.label4);
            this.grbTTDH.Controls.Add(this.label2);
            this.grbTTDH.Location = new System.Drawing.Point(12, 54);
            this.grbTTDH.Name = "grbTTDH";
            this.grbTTDH.Size = new System.Drawing.Size(786, 340);
            this.grbTTDH.TabIndex = 1;
            this.grbTTDH.TabStop = false;
            this.grbTTDH.Text = "Thông Tin Đơn Hàng";
            // 
            // dgvDS
            // 
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(9, 148);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(756, 146);
            this.dgvDS.TabIndex = 4;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(493, 115);
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(43, 22);
            this.nudSL.TabIndex = 3;
            this.nudSL.ValueChanged += new System.EventHandler(this.nudSL_ValueChanged);
            // 
            // txtTongT
            // 
            this.txtTongT.Location = new System.Drawing.Point(302, 300);
            this.txtTongT.Multiline = true;
            this.txtTongT.Name = "txtTongT";
            this.txtTongT.Size = new System.Drawing.Size(248, 24);
            this.txtTongT.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(173, 111);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(211, 22);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(481, 70);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(211, 22);
            this.txtGhiChu.TabIndex = 2;
            // 
            // cmbNV
            // 
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Location = new System.Drawing.Point(173, 71);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(211, 24);
            this.cmbNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên giao hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên  Khách Hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(187, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(329, 400);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 36);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(470, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbKH
            // 
            this.cmbKH.FormattingEnabled = true;
            this.cmbKH.Location = new System.Drawing.Point(173, 36);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(211, 24);
            this.cmbKH.TabIndex = 1;
            this.cmbKH.SelectedIndexChanged += new System.EventHandler(this.cmbKH_SelectedIndexChanged);
            // 
            // cmbDC
            // 
            this.cmbDC.FormattingEnabled = true;
            this.cmbDC.Location = new System.Drawing.Point(481, 35);
            this.cmbDC.Name = "cmbDC";
            this.cmbDC.Size = new System.Drawing.Size(211, 24);
            this.cmbDC.TabIndex = 1;
            // Mau
            // ==================== PHỐI MÀU GIAO DIỆN ====================

            // Màu định nghĩa
            System.Drawing.Color xanhReu = System.Drawing.Color.FromArgb(40, 60, 60);
            System.Drawing.Color vangDong = System.Drawing.Color.FromArgb(180, 150, 90);

            // Form nền
            this.BackColor = xanhReu;

            // Label tiêu đề
            this.label1.ForeColor = vangDong;

            // GroupBox
            this.grbTTDH.BackColor = xanhReu;
            this.grbTTDH.ForeColor = System.Drawing.Color.White;

            // Label trong GroupBox
            this.label2.ForeColor = vangDong;
            this.label3.ForeColor = vangDong;
            this.label4.ForeColor = vangDong;
            this.label5.ForeColor = vangDong;
            this.label6.ForeColor = vangDong;
            this.label7.ForeColor = vangDong;
            this.label8.ForeColor = vangDong;

            // ComboBox
            this.cmbNV.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.cmbNV.ForeColor = System.Drawing.Color.White;

            this.cmbKH.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.cmbKH.ForeColor = System.Drawing.Color.White;

            this.cmbDC.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.cmbDC.ForeColor = System.Drawing.Color.White;

            // TextBox
            this.txtTenSP.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtTenSP.ForeColor = System.Drawing.Color.White;

            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtGhiChu.ForeColor = System.Drawing.Color.White;

            this.txtTongT.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtTongT.ForeColor = System.Drawing.Color.White;

            // NumericUpDown
            this.nudSL.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.nudSL.ForeColor = System.Drawing.Color.White;

            // DataGridView phối màu
            this.dgvDS.BackgroundColor = System.Drawing.Color.FromArgb(50, 70, 70);
            this.dgvDS.GridColor = vangDong;
            this.dgvDS.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.dgvDS.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDS.DefaultCellStyle.SelectionBackColor = vangDong;
            this.dgvDS.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(40, 60, 60);

            // Nút bấm (Button)
            System.Drawing.Color btnBack = vangDong;
            System.Drawing.Color btnText = System.Drawing.Color.FromArgb(40, 60, 60);

            this.btnLuu.BackColor = btnBack;
            this.btnLuu.ForeColor = btnText;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 100, 60);

            this.btnHuy.BackColor = btnBack;
            this.btnHuy.ForeColor = btnText;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 100, 60);

            this.btnThoat.BackColor = btnBack;
            this.btnThoat.ForeColor = btnText;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 100, 60);

            // ==================== HẾT PHỐI MÀU ====================

            // 
            // TaoDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbTTDH);
            this.Controls.Add(this.label1);
            this.Name = "TaoDH";
            this.Text = "Tạo Đơn Hàng Mới";
            this.Load += new System.EventHandler(this.TaoDH_Load);
            this.grbTTDH.ResumeLayout(false);
            this.grbTTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKH;
        private System.Windows.Forms.ComboBox cmbDC;
    }
}