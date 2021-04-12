using QLCuaHangBanXe.BS_Layer;
using QLCuaHangBanXe.Form_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXe
{
    public partial class Form1 : Form
    {
        bool beNV;

        DataTable dtNV = null;

        BLNhanVien dbANV = new BLNhanVien();

        public Form1()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                //Lấy account nhân viên
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet dsANV = dbANV.LayTaiKkhoanNV();
                dtNV = dsANV.Tables[0];

                if (beNV)
                {
                    // Xóa trống các đối tượng trong Panel
                    this.txtTaiKhoan.ResetText();
                    this.txtMatKhau.ResetText();
                    // Không cho thao tác trên các nút đăng ký
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        //private void btnSignin_Click(object sender, EventArgs e)
        //{
        //    frm_Signin = new Form_Signin();
        //    frm_Signin.getForm(this);
        //    frm_Signin.Show();
        //    this.Hide();
        //}

        //private void btnNV_Click(object sender, EventArgs e)
        //{
        //    btnSignin.Enabled = false;
        //    beNV = true;
        //    beKH = false;
        //    btnNV.BackColor = Color.Red;
        //    btnKH.BackColor = DefaultBackColor;
        //    txtTaiKhoan.ResetText();
        //    txtMatKhau.ResetText();
        //    txtTaiKhoan.Focus();
        //}


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                if (txtTaiKhoan.Text.Trim() == dtNV.Rows[i][0].ToString().Trim() && txtMatKhau.Text.Trim() == dtNV.Rows[i][1].ToString().Trim())
                {
                    MessageBox.Show("Đăng nhập thành công roi TIen oi !!");
                    chứcNăngToolStripMenuItem.Enabled = true;
                    muaXeToolStripMenuItem.Enabled = true;
                    SHAREVAR.MaNV_TK = dtNV.Rows[i][2].ToString();
                    SHAREVAR.TenNV_TK = dtNV.Rows[i][3].ToString();
                    lbMaNV.Text = SHAREVAR.MaNV_TK;
                    lbTenNV.Text = SHAREVAR.TenNV_TK;
                    this.pnlDangNhap.Hide();
                    DataSet KTChucVu = dbANV.KTChucVu(SHAREVAR.MaNV_TK);
              
                    if (KTChucVu.Tables[0].Rows[0]["MaCV"].ToString().Trim() != "CV01") // nếu không phải người quản lý
                    {
                        menuStrip1.Enabled = true;
                        quảnLýNhânViênToolStripMenuItem.Enabled = false;
                        quảnLýXeToolStripMenuItem.Enabled = false;
                    }   
                    else
                        menuStrip1.Enabled = true;
                    pnlDNThanhCong.Visible = true;
                    pnlDNThanhCong.Left = 157;
                    pnlDNThanhCong.Top = 126;
                    return;
                }
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");
            //frm_Management = new Form_Management();
            ////frm_Management.getForm(this, dtNV.Rows[i][2].ToString());
            //frm_Management.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMaNV.Visible = true;
            LoadData();
            menuStrip1.Enabled = false;
            //btnKH.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DKTK f = new DKTK();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MuaXe f = new MuaXe();
            f.Show();
        }

        private void chiTiếtHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHoaDon f = new QLHoaDon();
            f.Show();
        }

        private void quảnLýThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            f.Show();
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLXe f = new QLXe();
            f.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachHang f = new QLKhachHang();
            f.Show();
        }

        private void muaXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuaXe f = new MuaXe();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu f = new ThongKeDoanhThu();
            f.Show();
        }

        private void đăngKýTàiKhoảnNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DKTK f = new DKTK();
            f.Show();
        }
    }
}
