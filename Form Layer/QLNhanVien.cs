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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }
        DataTable dtNV = null;
        DataSet dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtGT.ResetText();
            this.txtLuong.ResetText();
            this.txtSDT.ResetText();

            this.txtMaNV.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlNV.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnlNV.Enabled = true;
            //dgvNV_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlNV.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNV.Enabled = false;
            this.txtTenNV.Focus();
            // Phuong vua them dong nay
            // hom nay la ngay may
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvNV.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNV =
                dgvNV.Rows[r].Cells[0].Value.ToString();
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
                    dbNV.XoaNV(this.txtMaNV.Text, ref err);
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
                    BLNhanVien blNV = new BLNhanVien();
                    string macv = dt.Tables[0].Rows[cboCongViec.SelectedIndex]["MaCV"].ToString();
                    blNV.ThemNV(this.txtMaNV.Text, this.txtTenNV.Text, macv, this.txtGT.Text, this.txtSDT.Text, this.txtDiaChi.Text, Convert.ToInt32(txtLuong.Text), ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                string macv = dt.Tables[0].Rows[cboCongViec.SelectedIndex]["MaCV"].ToString();
                
                if (!blNV.CapNhatNV(this.txtMaNV.Text, this.txtTenNV.Text, macv, this.txtGT.Text, this.txtSDT.Text, this.txtDiaChi.Text, Convert.ToInt32(txtLuong.Text), ref err))// Load lại dữ liệu trên DataGridView
                {
                    MessageBox.Show("Có lỗi phát sinh,Cập nhật thất bại!");
                    return;
                }
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == -1)
                return;
            if (cboTimKiem.SelectedIndex == 0)
                SHAREVAR.search_MaNV = true;
            if (cboTimKiem.SelectedIndex == 1)
                SHAREVAR.search_TenNV = true;
            if (cboTimKiem.SelectedIndex == 2)
                SHAREVAR.search_congviec = true;
            LoadDataTimKiem();
        }
        void LoadDataTimKiem()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = dbNV.Timkiem(txtTimKiem.Text);
                dtNV = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvNV.DataSource = dtNV;
                // Thay đổi độ rộng cột
                dgvNV.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();
                this.txtLuong.ResetText();
                this.txtSDT.ResetText();
                this.txtGT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlNV.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                SHAREVAR.search_MaNV = false;
                SHAREVAR.search_TenNV = false;
                SHAREVAR.search_congviec = false;
                ////
                dgvNV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlNV.Enabled = false;
            dgvNV_CellClick(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
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
            SHAREVAR.search_mausac = false;
            SHAREVAR.search_TenNV = false;
            SHAREVAR.search_congviec = false;
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            if (SHAREVAR.ChonNV == false)
            {
                btnChonNV.Visible = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnChonNV.Visible = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            dt = new DataSet();
            dt = dbNV.LayCongViec();
            List<string> t = new List<string>();
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                t.Add(dt.Tables[0].Rows[i]["TenCV"].ToString());
            }
            cboCongViec.Items.AddRange(t.ToArray()); // thêm vào lựa chọn công việc
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = dbNV.LayNV();
                dtNV = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvNV.DataSource = dtNV;
                // Thay đổi độ rộng cột
                dgvNV.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlNV.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                if (SHAREVAR.ChonNV == true)
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
                this.btnThoat.Enabled = true;
                ////
                dgvNV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvNV.CurrentCell == null)
                    return;
                else
                    r = dgvNV.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                //if (dgvNV.Rows[r].Cells[0].Value.ToString() == null)
                //    return;


                this.txtMaNV.Text =
                dgvNV.Rows[r].Cells[0].Value.ToString();
                this.txtTenNV.Text =
                dgvNV.Rows[r].Cells[1].Value.ToString();

                if (dgvNV.Rows[r].Cells[2].Value.ToString() == "")
                    this.cboCongViec.SelectedIndex = -1;
                else
                    this.cboCongViec.SelectedItem = dgvNV.Rows[r].Cells[2].Value.ToString(); // chọn hiển thị tên công việc
  
                this.txtGT.Text =
                dgvNV.Rows[r].Cells[3].Value.ToString();
                this.txtSDT.Text =
                dgvNV.Rows[r].Cells[4].Value.ToString();
                this.txtDiaChi.Text =
                dgvNV.Rows[r].Cells[5].Value.ToString();
                this.txtLuong.Text =
                dgvNV.Rows[r].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //blNV.ThemNV(this.txtMaNV.Text, this.txtTenNV.Text, macv, this.txtGT.Text, this.txtSDT.Text, this.txtDiaChi.Text, Convert.ToInt32(txtLuong.Text), ref err);
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            SHAREVAR.MaNV_DK = txtMaNV.Text;
            SHAREVAR.TenNV_DK = txtTenNV.Text;
            SHAREVAR.ChonNV = false;
            this.Close();
        }

        private void QLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            SHAREVAR.ChonNV = false;
        }
    }
}
