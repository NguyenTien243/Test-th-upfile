ahihi
using QLCuaHangBanXe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanXe.BS_Layer
{
    public class BLKhachHang
    {
        public DBXe db = null;
        public BLKhachHang()
        {
            db = new DBXe();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang  ", CommandType.Text);
        }
        public DataSet LayKhachHang(string MaKH)
        {
            return db.ExecuteQueryDataSet("select * from KhachHang where MaKH = '"+ MaKH + "'", CommandType.Text);
        }
        public bool ThemKH(string MaKH, string TenKH, string GioiTinh, string SDT, string CMND, string DiaChi, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values( @MaKH,@TenKH,@CMND,@GioiTinh,@DiaChi,@SDT )";
            SqlParameter[] para = {
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@TenKH", TenKH),
            new SqlParameter("@CMND", GioiTinh),
            new SqlParameter("@GioiTinh", SDT),
            new SqlParameter("@DiaChi", CMND),
            new SqlParameter("@SDT", DiaChi) };
            return db.MyExecuteNonQuery(sqlString,para, CommandType.Text, ref err);
        }
        public bool XoaKH(string MaKH, ref string err)
        {
            string sqlString = "Delete From KhachHang Where MaKH = @MaKH";
            SqlParameter[] para = {
            new SqlParameter("@MaKH", MaKH) };
            return db.MyExecuteNonQuery(sqlString,para, CommandType.Text, ref err);
        }
        public bool CapNhatKH(string MaKH, string TenKH,  string GioiTinh, string SDT, string CMND, string DiaChi, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH = @TenKH ,CMND = @CMND ,GioiTinh = @GioiTinh ,DiaChi = @DiaChi ,SDT = @SDT Where MaKH = @MaKH";
            SqlParameter[] para = {
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@TenKH", TenKH),
            new SqlParameter("@CMND", GioiTinh),
            new SqlParameter("@GioiTinh", SDT),
            new SqlParameter("@DiaChi", CMND),
            new SqlParameter("@SDT", DiaChi) };
            return db.MyExecuteNonQuery(sqlString,para, CommandType.Text, ref err);
        }

        public DataSet Timkiem(string TK)
        {

            if (SHAREVAR.search_MaKH == true)
            {
                return db.ExecuteQueryDataSet("Select * from KhachHang where MaKH like '" + TK + "%'", CommandType.Text);
            }
            else if (SHAREVAR.search_TenKH == true)
            {
                return db.ExecuteQueryDataSet("Select * from KhachHang where TenKH like '" + TK + "%'", CommandType.Text);
            }
            else
            {
                return db.ExecuteQueryDataSet("Select * from KhachHang where SDT like '" + TK + "%'", CommandType.Text);
            }
        }
    }
}
