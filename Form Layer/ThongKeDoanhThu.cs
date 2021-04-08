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
    public partial class ThongKeDoanhThu : Form
    {
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        DataTable dtHD = null;
        BLHoaDon dbHD = new BLHoaDon();
        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboThongKe.SelectedIndex == -1)
                return;
            else
            if (cboThongKe.SelectedIndex == 0)
            {
                SHAREVAR.TK_TheoThang = true;
                dgvThongKe.Columns[0].HeaderText = "Thống kê theo tháng";
            }
            else
            if (cboThongKe.SelectedIndex == 1)
            {
                SHAREVAR.TK_TheoQuy = true;
                dgvThongKe.Columns[0].HeaderText = "Thống kê theo quý";
            }
            else
            if (cboThongKe.SelectedIndex == 2)
            {
                SHAREVAR.TK_TheoNam = true;
                dgvThongKe.Columns[0].HeaderText = "Thống kê theo năm";
            }
            LoadDataTimKiem();
        }
        void LoadDataTimKiem()
        {
            try
            {
                dtHD = new DataTable();
                dtHD.Clear();
                DataSet ds = dbHD.TKDoanhThu((int)numNam.Value);
                dtHD = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvThongKe.DataSource = dtHD;
                // Thay đổi độ rộng cột
                dgvThongKe.AutoResizeColumns();
                
                SHAREVAR.TK_TheoNam = false;
                SHAREVAR.TK_TheoQuy = false;
                SHAREVAR.TK_TheoThang = false;
                ////
                //dgvHD_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void cboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboThongKe.SelectedIndex == 2)
            {
                numNam.Enabled = false;
            }
            else
                numNam.Enabled = true;
        }
    }
}
