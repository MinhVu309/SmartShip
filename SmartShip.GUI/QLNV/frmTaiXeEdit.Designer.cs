namespace SmartShip.GUI.QLNV
{
    partial class frmTaiXeEdit
    {
        private System.ComponentModel.IContainer components = null;

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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.chkSanSang = new System.Windows.Forms.CheckBox();
            this.txtTongDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.chkSanSang);
            this.pnlEdit.Controls.Add(this.txtTongDon);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txtBienSo);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.txtLoaiXe);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.btnHuy);
            this.pnlEdit.Controls.Add(this.btnLuu);
            this.pnlEdit.Location = new System.Drawing.Point(12, 12);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(360, 270);
            this.pnlEdit.TabIndex = 0;
            // 
            // chkSanSang
            // 
            this.chkSanSang.AutoSize = true;
            this.chkSanSang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkSanSang.Location = new System.Drawing.Point(125, 165);
            this.chkSanSang.Name = "chkSanSang";
            this.chkSanSang.Size = new System.Drawing.Size(101, 27);
            this.chkSanSang.TabIndex = 3;
            this.chkSanSang.Text = "Sẵn sàng";
            this.chkSanSang.UseVisualStyleBackColor = true;
            // 
            // txtTongDon
            // 
            this.txtTongDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongDon.Location = new System.Drawing.Point(125, 120);
            this.txtTongDon.Name = "txtTongDon";
            this.txtTongDon.Size = new System.Drawing.Size(210, 30);
            this.txtTongDon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng đơn:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBienSo.Location = new System.Drawing.Point(125, 75);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(210, 30);
            this.txtBienSo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Biển số:";
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoaiXe.Location = new System.Drawing.Point(125, 30);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.Size = new System.Drawing.Size(210, 30);
            this.txtLoaiXe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại xe:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(202, 215);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(65, 215);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 35);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmTaiXeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.pnlEdit);
            this.Name = "frmTaiXeEdit";
            this.Text = "Thông tin tài xế";
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSanSang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}
