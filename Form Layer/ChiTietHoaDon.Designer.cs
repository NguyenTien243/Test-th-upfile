namespace QLCuaHangBanXe.Form_Layer
{
    partial class ChiTietHoaDon
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
            this.baoHanhTableAdapter1 = new QLCuaHangBanXe.QLCHXTableAdapters.BaoHanhTableAdapter();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamRaMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTongHoaDon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNgayXuatDon = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baoHanhTableAdapter1
            // 
            this.baoHanhTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToOrderColumns = true;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TenXe,
            this.TenDongXe,
            this.NamRaMat,
            this.MauSac,
            this.GiaXe,
            this.SLXe});
            this.dgvCTHD.Location = new System.Drawing.Point(12, 416);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(1200, 312);
            this.dgvCTHD.TabIndex = 64;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            // 
            // TenDongXe
            // 
            this.TenDongXe.DataPropertyName = "TenDongXe";
            this.TenDongXe.HeaderText = "Dòng Xe";
            this.TenDongXe.MinimumWidth = 6;
            this.TenDongXe.Name = "TenDongXe";
            // 
            // NamRaMat
            // 
            this.NamRaMat.DataPropertyName = "NamRaMat";
            this.NamRaMat.HeaderText = "Năm Ra Mắt";
            this.NamRaMat.MinimumWidth = 6;
            this.NamRaMat.Name = "NamRaMat";
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            // 
            // GiaXe
            // 
            this.GiaXe.DataPropertyName = "GiaXe";
            this.GiaXe.HeaderText = "Giá Khi Mua";
            this.GiaXe.MinimumWidth = 6;
            this.GiaXe.Name = "GiaXe";
            // 
            // SLXe
            // 
            this.SLXe.DataPropertyName = "SLXe";
            this.SLXe.HeaderText = "Số Lượng Chiếc";
            this.SLXe.MinimumWidth = 6;
            this.SLXe.Name = "SLXe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbTongHoaDon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbNgayXuatDon);
            this.panel1.Controls.Add(this.lbMaHD);
            this.panel1.Controls.Add(this.lbCMND);
            this.panel1.Controls.Add(this.lbGioiTinh);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Controls.Add(this.lbTenKH);
            this.panel1.Controls.Add(this.lbMaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 316);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTongHoaDon
            // 
            this.lbTongHoaDon.AutoSize = true;
            this.lbTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTongHoaDon.Location = new System.Drawing.Point(930, 127);
            this.lbTongHoaDon.Name = "lbTongHoaDon";
            this.lbTongHoaDon.Size = new System.Drawing.Size(89, 25);
            this.lbTongHoaDon.TabIndex = 87;
            this.lbTongHoaDon.Text = "Tổng giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(760, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 86;
            this.label10.Text = "Tổng Hóa Đơn :";
            // 
            // lbNgayXuatDon
            // 
            this.lbNgayXuatDon.AutoSize = true;
            this.lbNgayXuatDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNgayXuatDon.Location = new System.Drawing.Point(930, 80);
            this.lbNgayXuatDon.Name = "lbNgayXuatDon";
            this.lbNgayXuatDon.Size = new System.Drawing.Size(150, 25);
            this.lbNgayXuatDon.TabIndex = 85;
            this.lbNgayXuatDon.Text = "Ngày Xuất Đơn ";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMaHD.Location = new System.Drawing.Point(930, 29);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(127, 25);
            this.lbMaHD.TabIndex = 84;
            this.lbMaHD.Text = "Mã Hóa Đơn ";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCMND.Location = new System.Drawing.Point(163, 222);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(77, 25);
            this.lbCMND.TabIndex = 83;
            this.lbCMND.Text = "CMND ";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGioiTinh.Location = new System.Drawing.Point(163, 127);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(0, 25);
            this.lbGioiTinh.TabIndex = 82;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSDT.Location = new System.Drawing.Point(163, 173);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(0, 25);
            this.lbSDT.TabIndex = 81;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDiaChi.Location = new System.Drawing.Point(163, 270);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(81, 25);
            this.lbDiaChi.TabIndex = 80;
            this.lbDiaChi.Text = "Địa Chỉ ";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenKH.Location = new System.Drawing.Point(160, 77);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(0, 25);
            this.lbTenKH.TabIndex = 79;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMaKH.Location = new System.Drawing.Point(160, 29);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(0, 25);
            this.lbMaKH.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(760, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ngày Xuất Đơn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(760, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 76;
            this.label8.Text = "Mã Hóa Đơn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(54, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "CMND :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(54, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Giới Tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(54, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "SĐT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(54, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Địa Chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(51, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tên KH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(51, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Mã KH :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 38);
            this.label9.TabIndex = 89;
            this.label9.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 919);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCTHD);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLCHXTableAdapters.BaoHanhTableAdapter baoHanhTableAdapter1;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamRaMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTongHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNgayXuatDon;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}