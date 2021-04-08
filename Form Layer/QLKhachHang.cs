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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }
        DataTable dtKH = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            if (SHAREVAR.ChonKH == false)
            {
                btnChonKH.Visible = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnChonKH.Visible = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();
                DataSet ds = dbKH.LayKhachHang();
                dtKH = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvKH.DataSource = dtKH;
                // Thay đổi độ rộng cột
                dgvKH.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaKH.ResetText();
                this.txtTenKH.ResetText();
                this.txtCMND.ResetText();
                this.txtGioiTinh.ResetText();
                this.txtDchi.ResetText();
                this.txtSDT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlKH.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                
                if (SHAREVAR.ChonKH == true)
                {
                    this.btnSua.Enabled = false;
                    this.btnXoa.Enabled = false;
                    this.btnThem.Enabled = false;
                }
                else
                {
                    this.btnSua.Enabled = true;
                    this.btnXoa.Enabled = true;
                    this.btnThem.Enabled = true;
                }
                ////
                this.btnThoat.Enabled = false;
                dgvKH_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvKH.CurrentCell == null)
                    return;
                else
                    r = dgvKH.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaKH.Text =
                dgvKH.Rows[r].Cells[0].Value.ToString();
                this.txtTenKH.Text =
                dgvKH.Rows[r].Cells[1].Value.ToString();
                this.txtGioiTinh.Text =
                dgvKH.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text =
                dgvKH.Rows[r].Cells[3].Value.ToString();
                this.txtCMND.Text =
                dgvKH.Rows[r].Cells[4].Value.ToString();
                this.txtDchi.Text =
                dgvKH.Rows[r].Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDchi.ResetText();
            this.txtSDT.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtCMND.ResetText();

            this.txtMaKH.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlKH.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            this.dgvKH.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnlKH.Enabled = true;
            //dgvKH_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlKH.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvKH.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strKH =
                dgvKH.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu t
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaKH(this.txtMaKH.Text, ref err);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLKhachHang blKH = new BLKhachHang();


                    if (!blKH.ThemKH(this.txtMaKH.Text, this.txtTenKH.Text, this.txtGioiTinh.Text, this.txtSDT.Text, this.txtCMND.Text, this.txtDchi.Text, ref err))
                    {
                        MessageBox.Show("Có lỗi, thêm thất bại!");
                        return;
                    }
                    //blXe.ThemXe("ba","con","co",1,1, ref err);
                    // Load lại dữ liệu trên DataGridView

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLKhachHang blKH = new BLKhachHang();
                blKH.CapNhatKH(this.txtMaKH.Text, this.txtTenKH.Text, this.txtGioiTinh.Text, this.txtSDT.Text, this.txtCMND.Text, this.txtDchi.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                this.dgvKH.Enabled = true;
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.dgvKH.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlKH.Enabled = false;
            dgvKH_CellClick(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
            SHAREVAR.search_MaKH = false;
            SHAREVAR.search_TenKH = false;
            SHAREVAR.search_SDT = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
                SHAREVAR.search_MaKH = true;
            if (cboTimKiem.SelectedIndex == 1)
                SHAREVAR.search_TenKH = true;
            if (cboTimKiem.SelectedIndex == 2)
                SHAREVAR.search_SDT = true;
            LoadDataTimKiem();
        }
        void LoadDataTimKiem()
        {
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();
                DataSet ds = dbKH.Timkiem(txtTimKiem.Text);
                dtKH = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvKH.DataSource = dtKH;
                // Thay đổi độ rộng cột
                dgvKH.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaKH.ResetText();
                this.txtTenKH.ResetText();
                this.txtDchi.ResetText();
                this.txtSDT.ResetText();
                this.txtGioiTinh.ResetText();
                this.txtCMND.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlKH.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                SHAREVAR.search_MaKH = false;
                SHAREVAR.search_TenKH = false;
                SHAREVAR.search_SDT = false;
                ////
                dgvKH_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            SHAREVAR.MaKH_TK = txtMaKH.Text;
            SHAREVAR.TenKH_TK = txtTenKH.Text;
            SHAREVAR.ChonKH = false;
            this.Close();
        }

        private void QLKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            SHAREVAR.ChonKH = false;
        }
    }
}
