using QLCuaHangBanXe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXe.Form_Layer
{
    public partial class MuaXe : Form
    {

        public MuaXe()
        {
            InitializeComponent();
        }
        int TongGia = 0;
        DataTable dtXe = null;
        DataSet dt;
        DataSet slhd;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        string err;
        string maxe;
        BLXe dbXe;
        BLHoaDon dbHoaDon;
        private void btnChonXe_Click(object sender, EventArgs e)
        {
            int r = dgvXe.CurrentCell.RowIndex;
            int slxe = (int)dgvXe.Rows[r].Cells[5].Value;
            if (slxe == 0)
            {
                MessageBox.Show("Xe đã hết !!!");
                return;
            }
            else
                if (slxe < nSoluong.Value)
            {
                MessageBox.Show("Số lượng xe không đủ, vui lòng chọn lại !");
                return;
            }
            int i = 0;
            while (i < dtXe.Rows.Count && dtXe.Rows[i][1].ToString() != txtTenXe.Text) i++;

            foreach (ListViewItem item2 in livHoaDon.Items)
            {
                if (item2.Text == maxe)
                {
                    int sltanggiam =  int.Parse(nSoluong.Value.ToString()) - int.Parse(item2.SubItems[2].Text);
                    item2.SubItems[2].Text = nSoluong.Value.ToString();

                    TongGia = TongGia + int.Parse(item2.SubItems[3].Text) * sltanggiam;
                    lbTongGia.Text = FomatTien(TongGia.ToString());
                    livHoaDon.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                    livHoaDon.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);// ColumnContent
                    livHoaDon.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                    livHoaDon.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
                    return;
                }
            }
            //thêm item
            ListViewItem item = new ListViewItem();
            item.Text = maxe;
            item.SubItems.Add(txtTenXe.Text);
            item.SubItems.Add(nSoluong.Value.ToString());
            item.SubItems.Add(dtXe.Rows[i][6].ToString());
            livHoaDon.Items.Add(item);
            livHoaDon.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            livHoaDon.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);// ColumnContent
            livHoaDon.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            livHoaDon.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            //tính tổng tiền
            TongGia = TongGia + int.Parse(dtXe.Rows[i][6].ToString()) * int.Parse(nSoluong.Value.ToString());
             
            lbTongGia.Text = FomatTien(TongGia.ToString());
        }

        private void MuaXe_Load(object sender, EventArgs e)
        {
            dbXe = new BLXe();
            dbHoaDon = new BLHoaDon();
            lbMaNV.Text = SHAREVAR.MaNV_TK;
            lbTenNV.Text = SHAREVAR.TenNV_TK;
            dt = new DataSet();
            dt = dbXe.LayDongXe();
            List<string> t = new List<string>();
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                t.Add(dt.Tables[0].Rows[i]["TenDongXe"].ToString());
            }
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtXe = new DataTable();
                dtXe.Clear();
                DataSet ds = dbXe.LayXe();
                dtXe = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvXe.DataSource = dtXe;

                //Tạo list view hóa đơn
                livHoaDon.View = View.Details;
                livHoaDon.Columns.Add("Mã Xe", 70);
                livHoaDon.Columns.Add("Tên Xe", 70);
                livHoaDon.Columns.Add("SL", 30);
                livHoaDon.Columns.Add("Giá", 45);
                livHoaDon.GridLines = true;
                livHoaDon.FullRowSelect = true;
                livHoaDon.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                livHoaDon.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);// ColumnContent
                livHoaDon.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                livHoaDon.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
                lbTongGia.Text = "0";
                // Thay đổi độ rộng cột
                dgvXe.AutoResizeColumns();
                dgvXe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            SHAREVAR.ChonKH = true;
            QLKhachHang f = new QLKhachHang();
            f.Show();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (SHAREVAR.TenKH_TK == null || SHAREVAR.MaKH_TK == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước !");
                return;
            }
            slhd = new DataSet();
            slhd = dbHoaDon.LayDSMaHD();
            string mahd = "HD";
            int sl = slhd.Tables[0].Rows.Count + 1;
            if (sl < 10)
                mahd = "HD0" + sl.ToString();
            else
                mahd = "HD" + sl.ToString();
            dbHoaDon = new BLHoaDon();
            bool kq = dbHoaDon.ThemHD(mahd, DateTime.Now.Date, TongGia, SHAREVAR.MaKH_TK, SHAREVAR.MaNV_TK, ref err);
            for (int i = 0; i < livHoaDon.Items.Count; i++)
            {
                dbHoaDon = new BLHoaDon();
                dbHoaDon.ThemHD_Xe(mahd, livHoaDon.Items[i].SubItems[0].Text, int.Parse(livHoaDon.Items[i].SubItems[3].Text), int.Parse(livHoaDon.Items[i].SubItems[2].Text), ref err);
            }

            SHAREVAR.TenKH_TK = null;
            SHAREVAR.MaKH_TK = null;
            lbMaKH.Text = "Chưa chọn !";
            lbTenKH.Text = "Chưa chọn !";

            MessageBox.Show("Đã thanh toán! Cảm ơn quý khách <3");
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = dgvXe.CurrentCell.RowIndex;
                txtTenXe.Text = dgvXe.Rows[r].Cells[1].Value.ToString();
                maxe = dgvXe.Rows[r].Cells[0].Value.ToString();
                nSoluong.Value = 1;
                // Chuyển thông tin lên panel
                //if (dgvXe.Rows[r].Cells[0].Value.ToString() == null)
                //    return;
            }
            catch
            {

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
                SHAREVAR.search_maxe = true;
            if (cboTimKiem.SelectedIndex == 1)
                SHAREVAR.search_tenxe = true;
            if (cboTimKiem.SelectedIndex == 2)
                SHAREVAR.search_mausac = true;
            LoadDataTimKiem();
        }
        void LoadDataTimKiem()
        {
            try
            {
                dtXe = new DataTable();
                dtXe.Clear();
                DataSet ds = dbXe.Timkiem(txtTimKiem.Text);
                dtXe = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvXe.DataSource = dtXe;
                // Thay đổi độ rộng cột
                dgvXe.AutoResizeColumns();
                SHAREVAR.search_maxe = false;
                SHAREVAR.search_tenxe = false;
                SHAREVAR.search_mausac = false;
                ////
                dgvXe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            
            if (livHoaDon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn hãy chọn xe cần xóa");
                return;
            }
           
                //tính sl món ăn cùng loại bị xóa
                int sl = int.Parse(livHoaDon.Items[livHoaDon.SelectedIndices[0]].SubItems[2].Text);
                //lấy giá của món ăn
                int gia = int.Parse(livHoaDon.Items[livHoaDon.SelectedIndices[0]].SubItems[3].Text);
            //tính tổng tiền
                TongGia = TongGia - sl * gia;
                lbTongGia.Text = FomatTien(TongGia.ToString());
                //xóa món ăn
                livHoaDon.Items.RemoveAt(livHoaDon.SelectedIndices[0]);
                if (livHoaDon.Items.Count != 0) livHoaDon.Items[0].Selected = true;
           
        }

        private void MuaXe_MouseMove(object sender, MouseEventArgs e)
        {
            lbMaKH.Text = SHAREVAR.MaKH_TK;
            lbTenKH.Text = SHAREVAR.TenKH_TK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbHoaDon.ThemHD_Xe("HD5", "X01", 15000, 2, ref err))
                MessageBox.Show("ok");
            else MessageBox.Show("not");

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


    }
}
