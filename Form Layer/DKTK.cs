using QLCuaHangBanXe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXe.Form_Layer
{
    public partial class DKTK : Form
    {
        public DKTK()
        {
            InitializeComponent();
        }
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (SHAREVAR.MaNV_DK == null || SHAREVAR.TenNV_DK == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước !");
                return;
            }
            if(txtMK.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp, vui lòng nhập lại !");
                return;
            }
            BLNhanVien blNV = new BLNhanVien();

            bool dktk = blNV.DangKyNV(this.lbMaNV.Text, this.txtTK.Text, this.txtMK.Text, ref err);
            //blXe.ThemXe("ba","con","co",1,1, ref err);
            if (dktk)
            {
                MessageBox.Show("Đăng ký thành công !");
                SHAREVAR.MaNV_DK = null;
                SHAREVAR.TenNV_DK = null;
                txtTK.ResetText();
                txtMK.ResetText();
                txtNhapLaiMK.ResetText();
            }    
            else
                MessageBox.Show("Đăng ký thất bại, có thể nhân viên này đã có tài khoản rồi !!!");

        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            SHAREVAR.ChonNV = true;
            QLNhanVien f = new QLNhanVien();
            f.Show();
        }

        private void DKTK_MouseMove(object sender, MouseEventArgs e)
        {
            lbMaNV.Text = SHAREVAR.MaNV_DK;
            lbTenNV.Text = SHAREVAR.TenNV_DK;
        }

        private void DKTK_Load(object sender, EventArgs e)
        {

        }
    }
}
