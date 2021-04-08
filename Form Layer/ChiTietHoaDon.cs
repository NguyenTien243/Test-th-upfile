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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        BLKhachHang dbKH = null;
        BLHoaDon dbHD = null;
        DataSet ds = null;
        BLChiTietHD dbCTHD = null;
        DataTable dtXe = null;
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            int a = 5;
        }
        private void LoadThongTin()
        {
            // lấy thông tin khách hàng
            dbKH = new BLKhachHang();
            ds = dbKH.LayKhachHang(SHAREVAR.CTHD_MaKH);
            lbMaKH.Text = ds.Tables[0].Rows[0]["MaKH"].ToString();
            lbTenKH.Text = ds.Tables[0].Rows[0]["TenKH"].ToString();
            lbGioiTinh.Text = ds.Tables[0].Rows[0]["GioiTinh"].ToString();
            lbSDT.Text = ds.Tables[0].Rows[0]["SDT"].ToString();
            lbCMND.Text = ds.Tables[0].Rows[0]["CMND"].ToString();
            lbDiaChi.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();

            // lấy thông tin hóa đơn
            dbHD = new BLHoaDon();
            ds = dbHD.LayHoaDon(SHAREVAR.CTHD_MaHD);
            lbMaHD.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
            lbNgayXuatDon.Text = ds.Tables[0].Rows[0]["NgayXuatDon"].ToString();
            //lbNgayXuatDon.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayXuatDon"].ToString()).("dd/MM/yyyy");
            lbTongHoaDon.Text = FomatTien(ds.Tables[0].Rows[0]["TongHoaDon"].ToString());

            // lấy thông tin xe trong hóa đơn
            dbCTHD = new BLChiTietHD();
            ds = dbCTHD.LayThongTinXeMua(SHAREVAR.CTHD_MaHD);
            dtXe = ds.Tables[0];
            // Đưa dữ liệu lên DataGridView
            dgvCTHD.DataSource = dtXe;
            // Thay đổi độ rộng cột
            dgvCTHD.AutoResizeColumns();
        }
        private string FomatTien(string s)
        {
           
            int l = s.Length;           // độ dài của chuỗi
            for (int i = 0; i < l / 3; i++)
            {
                s = s.Insert(l - 3 * (i + 1), ".");    // chèn dấu . từ phải sang trái
            }
            if (s.StartsWith(".")) s = s.Substring(1); // nếu dấu . xuất hiện đầu, bỏ nó đi
            s = s + " VND";
            return s;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
