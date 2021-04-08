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
    public partial class QLXe : Form
    {
        public QLXe()
        {
            InitializeComponent();
        }
        DataTable dtXe = null;
        DataSet dt;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLXe dbXe = new BLXe();
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaXe.ResetText();
            this.txtTenXe.ResetText();
            this.cboDongXe.ResetText();
            this.txtNamRaMat.ResetText();
            this.cboMauSac.ResetText();
            this.txtSoLuong.ResetText();
            this.txtGiaXe.ResetText();

            this.txtMaXe.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlXe.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaXe.Focus();
        }

        private void QLXe_Load(object sender, EventArgs e)
        {
            dt = new DataSet();
            dt = dbXe.LayDongXe();
            List<string> t = new List<string>();
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                t.Add(dt.Tables[0].Rows[i]["TenDongXe"].ToString());
            }
            cboDongXe.Items.AddRange(t.ToArray()); // thêm vào dòng lựa chọn dòng xe
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
                // Thay đổi độ rộng cột
                dgvXe.AutoResizeColumns();

                
               
                // Xóa trống các đối tượng trong Panel
                this.txtMaXe.ResetText();
                this.txtTenXe.ResetText();
                //this.cboDongXe.ResetText();
                this.txtNamRaMat.ResetText();
                this.cboMauSac.ResetText();
                this.txtSoLuong.ResetText();
                this.txtGiaXe.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlXe.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                ////
                dgvXe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnlXe.Enabled = true;
            //dgvNV_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlXe.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaXe.Enabled = false;
            this.txtTenXe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvXe.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNV =
                dgvXe.Rows[r].Cells[0].Value.ToString();
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
                    dbXe.XoaXe(this.txtMaXe.Text, ref err);
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
                    BLXe blXe = new BLXe();
                    string madongxe = dt.Tables[0].Rows[cboDongXe.SelectedIndex]["MaDongXe"].ToString();
                    
                    blXe.ThemXe(this.txtMaXe.Text, this.txtTenXe.Text, madongxe, this.txtNamRaMat.Text, this.cboMauSac.Items[cboMauSac.SelectedIndex].ToString(), this.txtSoLuong.Text, Convert.ToInt32(txtGiaXe.Text), ref err);
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
                BLXe blXe = new BLXe();
                string madongxe = dt.Tables[0].Rows[cboDongXe.SelectedIndex]["MaDongXe"].ToString();

                if (!blXe.CapNhatXe(this.txtMaXe.Text, this.txtTenXe.Text, madongxe, this.txtNamRaMat.Text, this.cboMauSac.Items[cboMauSac.SelectedIndex].ToString(), this.txtSoLuong.Text, Convert.ToInt32(txtGiaXe.Text), ref err))// Load lại dữ liệu trên DataGridView
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaXe.ResetText();
            this.txtTenXe.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlXe.Enabled = false;
            dgvXe_CellClick(null, null);
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
                // Xóa trống các đối tượng trong Panel
                this.txtMaXe.ResetText();
                this.txtTenXe.ResetText();
                this.txtGiaXe.ResetText();
                this.cboMauSac.ResetText();
                this.txtSoLuong.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlXe.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
            //SHAREVAR.search_mausac = false;
            //SHAREVAR.search_TenNV = false;
            //SHAREVAR.search_congviec = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvXe.CurrentCell == null)
                    return;
                else
                    r = dgvXe.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                //if (dgvXe.Rows[r].Cells[0].Value.ToString() == null)
                //    return;


                this.txtMaXe.Text =
                dgvXe.Rows[r].Cells[0].Value.ToString();
                this.txtTenXe.Text =
                dgvXe.Rows[r].Cells[1].Value.ToString();

                if (dgvXe.Rows[r].Cells[2].Value.ToString() == "")
                    this.cboDongXe.SelectedIndex = -1;
                else
                    this.cboDongXe.SelectedItem = dgvXe.Rows[r].Cells[2].Value.ToString(); // chọn hiển thị tên công việc

                this.txtNamRaMat.Text =
                dgvXe.Rows[r].Cells[3].Value.ToString();
                this.cboMauSac.Text =
                dgvXe.Rows[r].Cells[4].Value.ToString();
                this.txtSoLuong.Text =
                dgvXe.Rows[r].Cells[5].Value.ToString();
                this.txtGiaXe.Text =
                dgvXe.Rows[r].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void pnlXe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
