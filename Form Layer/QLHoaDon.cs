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
    public partial class QLHoaDon : Form
    {
        public QLHoaDon()
        {
            InitializeComponent();
        }
        DataTable dtHD = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLHoaDon dbHD = new BLHoaDon();
        private void QLHoaDon_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = dbHD.LayHoaDon();
                dtHD = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvHD.DataSource = dtHD;
                dgvHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                // Thay đổi độ rộng cột
                dgvHD.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaHD.ResetText();
                this.txtNgayXD.ResetText();
                this.txtMaNV.ResetText();
                this.txtMaKH.ResetText();
                this.txtTongHD.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlHD.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                //this.btnThem.Enabled = true;
                //this.btnSua.Enabled = true;
                //this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                ////
                dgvHD_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvHD.CurrentCell == null)
                    return;
                else
                    r = dgvHD.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaHD.Text =
                dgvHD.Rows[r].Cells[0].Value.ToString();
                this.txtNgayXD.Text =
                ((DateTime)dgvHD.Rows[r].Cells[1].Value).ToString("dd/MM/yyyy");
                this.txtMaNV.Text =
                dgvHD.Rows[r].Cells[2].Value.ToString();
                this.txtMaKH.Text =
                dgvHD.Rows[r].Cells[3].Value.ToString();
                this.txtTongHD.Text =
                dgvHD.Rows[r].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadDataTimKiem()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = dbHD.Timkiem(txtTimKiem.Text);
                dtHD = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvHD.DataSource = dtHD;
                // Thay đổi độ rộng cột
                dgvHD.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaHD.ResetText();
                this.txtNgayXD.ResetText();
                this.txtMaNV.ResetText();
                this.txtMaKH.ResetText();
                this.txtTongHD.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlHD.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                //this.btnThem.Enabled = true;
                //this.btnSua.Enabled = true;
                //this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                SHAREVAR.search_MaHD = false;
                SHAREVAR.search_MaNVHD = false;
                SHAREVAR.search_MaKHHD = false;
                ////
                dgvHD_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCTietHD_Click(object sender, EventArgs e)
        {
            SHAREVAR.CTHD_MaHD = txtMaHD.Text;
            
            SHAREVAR.CTHD_MaKH = txtMaKH.Text;
            ChiTietHoaDon f = new ChiTietHoaDon();
            f.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
                SHAREVAR.search_MaHD = true;
            if (cboTimKiem.SelectedIndex == 1)
                SHAREVAR.search_MaNV = true;
            if (cboTimKiem.SelectedIndex == 2)
                SHAREVAR.search_MaKHHD = true;
            LoadDataTimKiem();
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
