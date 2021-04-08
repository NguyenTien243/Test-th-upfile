namespace QLCuaHangBanXe.Form_Layer
{
    partial class QLXe
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
            this.txtGiaXe = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlXe = new System.Windows.Forms.Panel();
            this.cboMauSac = new System.Windows.Forms.ComboBox();
            this.cboDongXe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNamRaMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamRaMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaXe
            // 
            this.txtGiaXe.Location = new System.Drawing.Point(150, 270);
            this.txtGiaXe.Name = "txtGiaXe";
            this.txtGiaXe.Size = new System.Drawing.Size(275, 22);
            this.txtGiaXe.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(150, 229);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(275, 22);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(150, 65);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(275, 22);
            this.txtTenXe.TabIndex = 6;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(150, 24);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(275, 22);
            this.txtMaXe.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(22, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Màu Sắc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(22, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá Xe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(22, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Xe :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlXe
            // 
            this.pnlXe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlXe.Controls.Add(this.cboMauSac);
            this.pnlXe.Controls.Add(this.cboDongXe);
            this.pnlXe.Controls.Add(this.label8);
            this.pnlXe.Controls.Add(this.txtNamRaMat);
            this.pnlXe.Controls.Add(this.label2);
            this.pnlXe.Controls.Add(this.txtGiaXe);
            this.pnlXe.Controls.Add(this.txtSoLuong);
            this.pnlXe.Controls.Add(this.txtTenXe);
            this.pnlXe.Controls.Add(this.txtMaXe);
            this.pnlXe.Controls.Add(this.label7);
            this.pnlXe.Controls.Add(this.label6);
            this.pnlXe.Controls.Add(this.label5);
            this.pnlXe.Controls.Add(this.label4);
            this.pnlXe.Controls.Add(this.label3);
            this.pnlXe.Location = new System.Drawing.Point(161, 115);
            this.pnlXe.Name = "pnlXe";
            this.pnlXe.Size = new System.Drawing.Size(447, 309);
            this.pnlXe.TabIndex = 33;
            this.pnlXe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlXe_Paint);
            // 
            // cboMauSac
            // 
            this.cboMauSac.FormattingEnabled = true;
            this.cboMauSac.Items.AddRange(new object[] {
            "Blue",
            "Gray",
            "Green",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Striped",
            "White",
            "Yellow",
            "",
            "",
            ""});
            this.cboMauSac.Location = new System.Drawing.Point(149, 191);
            this.cboMauSac.Name = "cboMauSac";
            this.cboMauSac.Size = new System.Drawing.Size(275, 24);
            this.cboMauSac.TabIndex = 15;
            // 
            // cboDongXe
            // 
            this.cboDongXe.FormattingEnabled = true;
            this.cboDongXe.Location = new System.Drawing.Point(150, 107);
            this.cboDongXe.Name = "cboDongXe";
            this.cboDongXe.Size = new System.Drawing.Size(275, 24);
            this.cboDongXe.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(22, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dòng Xe :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNamRaMat
            // 
            this.txtNamRaMat.Location = new System.Drawing.Point(150, 150);
            this.txtNamRaMat.Name = "txtNamRaMat";
            this.txtNamRaMat.Size = new System.Drawing.Size(274, 22);
            this.txtNamRaMat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Năm Ra Mắt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Xe :";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLuu.Location = new System.Drawing.Point(161, 445);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(318, 37);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuy.Location = new System.Drawing.Point(505, 445);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 37);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(755, 175);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 33);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Theo mã xe",
            "Theo tên xe",
            "Theo màu sắc",
            ""});
            this.cboTimKiem.Location = new System.Drawing.Point(755, 119);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(263, 33);
            this.cboTimKiem.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(636, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(1047, 114);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 37);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.Location = new System.Drawing.Point(1047, 445);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 37);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReload.Location = new System.Drawing.Point(1047, 375);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(134, 37);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(37, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 37);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(37, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 37);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(37, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 37);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TenXe,
            this.TenDongXe,
            this.NamRaMat,
            this.MauSac,
            this.SoLuong,
            this.GiaXe});
            this.dgvXe.Location = new System.Drawing.Point(37, 512);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(1144, 312);
            this.dgvXe.TabIndex = 18;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
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
            this.NamRaMat.HeaderText = "Năm ra mắt";
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
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaXe
            // 
            this.GiaXe.DataPropertyName = "GiaXe";
            this.GiaXe.HeaderText = "Giá Xe";
            this.GiaXe.MinimumWidth = 6;
            this.GiaXe.Name = "GiaXe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 38);
            this.label9.TabIndex = 51;
            this.label9.Text = "QUẢN LÝ XE";
            // 
            // QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 919);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlXe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvXe);
            this.Name = "QLXe";
            this.Text = "QLXe";
            this.Load += new System.EventHandler(this.QLXe_Load);
            this.pnlXe.ResumeLayout(false);
            this.pnlXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaXe;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamRaMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamRaMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMauSac;
    }
}