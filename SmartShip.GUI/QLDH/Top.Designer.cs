namespace DA.GUI
{
    partial class Top
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
            this.dgvTNV = new System.Windows.Forms.DataGridView();
            this.dgvTKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTNV
            // 
            this.dgvTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTNV.Location = new System.Drawing.Point(12, 106);
            this.dgvTNV.Name = "dgvTNV";
            this.dgvTNV.RowHeadersWidth = 51;
            this.dgvTNV.RowTemplate.Height = 24;
            this.dgvTNV.Size = new System.Drawing.Size(381, 206);
            this.dgvTNV.TabIndex = 0;
            // 
            // dgvTKH
            // 
            this.dgvTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKH.Location = new System.Drawing.Point(399, 106);
            this.dgvTKH.Name = "dgvTKH";
            this.dgvTKH.RowHeadersWidth = 51;
            this.dgvTKH.RowTemplate.Height = 24;
            this.dgvTKH.Size = new System.Drawing.Size(389, 206);
            this.dgvTKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Nhân Viên Và Khách Hàng Tiêu Biểu";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(278, 330);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(115, 45);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(399, 330);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(115, 45);
            this.Thoát.TabIndex = 2;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // mau
            // ==================== PHỐI MÀU GIAO DIỆN ====================

            // Định nghĩa màu
            System.Drawing.Color xanhReu = System.Drawing.Color.FromArgb(40, 60, 60);
            System.Drawing.Color vangDong = System.Drawing.Color.FromArgb(180, 150, 90);
            System.Drawing.Color nenPhu = System.Drawing.Color.FromArgb(60, 80, 80);

            // Màu nền form
            this.BackColor = xanhReu;

            // Label tiêu đề
            this.label1.ForeColor = vangDong;

            // DataGridView Top Nhân Viên
            this.dgvTNV.BackgroundColor = nenPhu;
            this.dgvTNV.GridColor = vangDong;
            this.dgvTNV.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 70, 70);
            this.dgvTNV.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTNV.DefaultCellStyle.SelectionBackColor = vangDong;
            this.dgvTNV.DefaultCellStyle.SelectionForeColor = xanhReu;
            this.dgvTNV.ColumnHeadersDefaultCellStyle.BackColor = vangDong;
            this.dgvTNV.ColumnHeadersDefaultCellStyle.ForeColor = xanhReu;
            this.dgvTNV.EnableHeadersVisualStyles = false;

            // DataGridView Top Khách Hàng
            this.dgvTKH.BackgroundColor = nenPhu;
            this.dgvTKH.GridColor = vangDong;
            this.dgvTKH.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 70, 70);
            this.dgvTKH.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTKH.DefaultCellStyle.SelectionBackColor = vangDong;
            this.dgvTKH.DefaultCellStyle.SelectionForeColor = xanhReu;
            this.dgvTKH.ColumnHeadersDefaultCellStyle.BackColor = vangDong;
            this.dgvTKH.ColumnHeadersDefaultCellStyle.ForeColor = xanhReu;
            this.dgvTKH.EnableHeadersVisualStyles = false;

            // Nút "Xuất Excel"
            this.btnXuat.BackColor = vangDong;
            this.btnXuat.ForeColor = xanhReu;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 100, 60);

            // Nút "Thoát"
            this.Thoát.BackColor = vangDong;
            this.Thoát.ForeColor = xanhReu;
            this.Thoát.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thoát.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 100, 60);

            // ==================== HẾT PHỐI MÀU ====================

            //
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTKH);
            this.Controls.Add(this.dgvTNV);
            this.Name = "Top";
            this.Text = "Top Nhân Viên Và Khách Hàng";
            this.Load += new System.EventHandler(this.Top_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTNV;
        private System.Windows.Forms.DataGridView dgvTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button Thoát;
    }
}