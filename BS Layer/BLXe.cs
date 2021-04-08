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
    class BLXe
    {
        public DBXe db = null;
        public BLXe()
        {
            db = new DBXe();
        }
        public DataSet LayXe()
        {
            return db.ExecuteQueryDataSet("select MaXe,TenXe,TenDongXe,NamRaMat,MauSac,SoLuong,GiaXe from Xe x, DongXe d where x.MaDongXe = d.MaDongXe ", CommandType.Text);
        }
        
        public DataSet LayDongXe()
        {
            return db.ExecuteQueryDataSet("select * from DongXe ", CommandType.Text);
        }
        public bool ThemXe(string MaXe, string TenXe, string DongXe, string NamRaMat, string MauSac, string SoLuong, int GiaXe, ref string err)
        {
            string sqlString = "Insert Into Xe (MaXe,TenXe,MaDongXe,NamRaMat,MauSac,SoLuong,GiaXe) Values( @MaXe,@TenXe,@DongXe,@NamRaMat,@MauSac,@SoLuong,@GiaXe )";
            SqlParameter[] para = {
            new SqlParameter("@MaXe", MaXe),
            new SqlParameter("@TenXe", TenXe),
            new SqlParameter("@DongXe", DongXe),
            new SqlParameter("@NamRaMat", NamRaMat),
            new SqlParameter("@MauSac", MauSac),
            new SqlParameter("@SoLuong", SoLuong),
            new SqlParameter("@GiaXe", GiaXe)};
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public bool XoaXe(string MaXe, ref string err)
        {
            string sqlString = "Delete From Xe Where MaXe = @MaXe ";
            SqlParameter[] para = { new SqlParameter("@MaXe", MaXe) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public bool CapNhatXe(string MaXe, string TenXe, string DongXe, string NamRaMat, string MauSac, string SoLuong, int GiaXe, ref string err)
        {
            //string sqlString = "Update NhanVien Set TenXe =N'" +
            //TenXe + "' ,MaCV = '" + DongXe +"' ,NamRaMat = N'" + NamRaMat + "',MauSac = '" + MauSac + "' ,SoLuong = N'" + SoLuong + "',GiaXe = " + GiaXe + " Where MaXe ='" + MaXe + "'";
            string sqlString = "Update Xe Set TenXe = @TenXe,MaDongXe = @DongXe,NamRaMat = @NamRaMat,MauSac =@MauSac,SoLuong = @SoLuong,GiaXe = @GiaXe Where MaXe = @MaXe ";
            SqlParameter[] para = {
            new SqlParameter("@MaXe", MaXe),
            new SqlParameter("@TenXe", TenXe),
            new SqlParameter("@DongXe", DongXe),
            new SqlParameter("@NamRaMat", NamRaMat),
            new SqlParameter("@MauSac", MauSac),
            new SqlParameter("@SoLuong", SoLuong),
            new SqlParameter("@GiaXe", GiaXe) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }

        public DataSet Timkiem(string TK)
        {
            if (SHAREVAR.search_maxe == true)
            {
                return db.ExecuteQueryDataSet("select MaXe,TenXe,TenDongXe,NamRaMat,MauSac,SoLuong,GiaXe from Xe x, DongXe d where x.MaDongXe = d.MaDongXe and MaXe like '" + TK + "%'", CommandType.Text);
            }
            else if (SHAREVAR.search_tenxe == true)
            {
                return db.ExecuteQueryDataSet("select MaXe, TenXe, TenDongXe, NamRaMat, MauSac, SoLuong, GiaXe from Xe x, DongXe d where x.MaDongXe = d.MaDongXe and TenXe like '" + TK + "%'", CommandType.Text);
            }
            else
            {
                return db.ExecuteQueryDataSet("select MaXe, TenXe, TenDongXe, NamRaMat, MauSac, SoLuong, GiaXe from Xe x, DongXe d where x.MaDongXe = d.MaDongXe and MauSac like '" + TK + "%'", CommandType.Text);
            }
        }
    }
}
