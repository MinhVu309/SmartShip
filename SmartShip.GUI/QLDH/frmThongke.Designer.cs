namespace DA.GUI
{
    partial class frmThongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongke));
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.btnTKe = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartTrangThai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongD = new System.Windows.Forms.TextBox();
            this.grbTK.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThai)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTK
            // 
            this.grbTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.grbTK.Controls.Add(this.btnTKe);
            this.grbTK.Controls.Add(this.dtpDenNgay);
            this.grbTK.Controls.Add(this.dtpTuNgay);
            this.grbTK.Controls.Add(this.label2);
            this.grbTK.Controls.Add(this.label1);
            this.grbTK.ForeColor = System.Drawing.Color.White;
            this.grbTK.Location = new System.Drawing.Point(13, 31);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(775, 81);
            this.grbTK.TabIndex = 1;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Thông Kê Đơn Hàng";
            // 
            // btnTKe
            // 
            this.btnTKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnTKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnTKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTKe.Location = new System.Drawing.Point(580, 28);
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(91, 26);
            this.btnTKe.TabIndex = 3;
            this.btnTKe.Text = "Thông kê";
            this.btnTKe.UseVisualStyleBackColor = false;
            this.btnTKe.Click += new System.EventHandler(this.btnTKe_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDenNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(374, 29);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CalendarForeColor = System.Drawing.Color.White;
            this.dtpTuNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(146, 29);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(352, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XuatToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // XuatToolStripMenuItem
            // 
            this.XuatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.XuatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.XuatToolStripMenuItem.Name = "XuatToolStripMenuItem";
            this.XuatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.XuatToolStripMenuItem.Text = "Xuất Excel";
            this.XuatToolStripMenuItem.Click += new System.EventHandler(this.XuatToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.chartTrangThai);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái";
            // 
            // chartTrangThai
            // 
            this.chartTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            chartArea1.Name = "ChartArea1";
            this.chartTrangThai.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrangThai.Legends.Add(legend1);
            this.chartTrangThai.Location = new System.Drawing.Point(9, 21);
            this.chartTrangThai.Name = "chartTrangThai";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTrangThai.Series.Add(series1);
            this.chartTrangThai.Size = new System.Drawing.Size(354, 292);
            this.chartTrangThai.TabIndex = 0;
            this.chartTrangThai.Text = "Trạng Thái";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.groupBox2.Controls.Add(this.chartDoanhThu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(397, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 319);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh Thu";
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(6, 21);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(379, 292);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "Doanh Thu";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(400, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Thu Nhập";
            // 
            // txtTongTN
            // 
            this.txtTongTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtTongTN.ForeColor = System.Drawing.Color.White;
            this.txtTongTN.Location = new System.Drawing.Point(516, 448);
            this.txtTongTN.Multiline = true;
            this.txtTongTN.Name = "txtTongTN";
            this.txtTongTN.Size = new System.Drawing.Size(127, 27);
            this.txtTongTN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(19, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Đơn Hàng";
            // 
            // txtTongD
            // 
            this.txtTongD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtTongD.ForeColor = System.Drawing.Color.White;
            this.txtTongD.Location = new System.Drawing.Point(138, 450);
            this.txtTongD.Multiline = true;
            this.txtTongD.Name = "txtTongD";
            this.txtTongD.Size = new System.Drawing.Size(138, 27);
            this.txtTongD.TabIndex = 1;
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(809, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTongD);
            this.Controls.Add(this.txtTongTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbTK);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThongke";
            this.Text = "Thông kê đơn hàng";
            this.Load += new System.EventHandler(this.Thongke_Load);
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Button btnTKe;
        private System.Windows.Forms.ToolStripMenuItem XuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtTongTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongD;
    }
}