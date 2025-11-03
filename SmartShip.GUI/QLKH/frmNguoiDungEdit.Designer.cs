namespace SmartShip.GUI
{
    partial class frmNguoiDungEdit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(30, 75);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 16);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(30, 120);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 72);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 22);
            this.txtSDT.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(140, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 22);
            this.txtDiaChi.TabIndex = 3;
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.AutoSize = true;
            this.chkHoatDong.Location = new System.Drawing.Point(140, 160);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(92, 20);
            this.chkHoatDong.TabIndex = 4;
            this.chkHoatDong.Text = "Hoạt động";
            this.chkHoatDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(140, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(300, 200);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // mau
            // 
            // ====================
            // 🎨 Theme chỉnh màu frmNguoiDungEdit
            // ====================
            System.Drawing.Color mossGreen = System.Drawing.Color.FromArgb(40, 60, 60);      // Xanh rêu sẫm
            System.Drawing.Color goldButton = System.Drawing.Color.FromArgb(180, 150, 90);   // Vàng đồng
            System.Drawing.Color goldAccent = System.Drawing.Color.FromArgb(200, 170, 110);  // Vàng sáng hơn
            System.Drawing.Color textColor = System.Drawing.Color.White;

            // Nền form
            this.BackColor = mossGreen;
            this.ForeColor = textColor;

            // Label
            this.lblHoTen.ForeColor = goldAccent;
            this.lblSDT.ForeColor = goldAccent;
            this.lblDiaChi.ForeColor = goldAccent;

            // TextBox
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtHoTen.ForeColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(60, 80, 80);
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // CheckBox
            this.chkHoatDong.ForeColor = textColor;
            this.chkHoatDong.BackColor = mossGreen;

            // Nút Lưu
            this.btnLuu.BackColor = goldButton;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.FlatAppearance.MouseOverBackColor = goldAccent;
            this.btnLuu.FlatAppearance.MouseDownBackColor = goldAccent;

            // Nút Hủy
            this.btnHuy.BackColor = goldButton;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 2;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.FlatAppearance.MouseOverBackColor = goldAccent;
            this.btnHuy.FlatAppearance.MouseDownBackColor = goldAccent;

            // frmNguoiDungEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 260);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.chkHoatDong);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNguoiDungEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDungEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}