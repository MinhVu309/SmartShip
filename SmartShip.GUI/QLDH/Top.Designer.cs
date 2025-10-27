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