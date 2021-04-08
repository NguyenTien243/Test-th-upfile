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
    class BLHoaDon
    {
        public DBXe db = null;
        public BLHoaDon()
        {
            db = new DBXe();
        }
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet("select MaHD,NgayXuatDon,MaNV,MaKH,TongHoaDon from HoaDon  ", CommandType.Text);
        }
        public DataSet LayHoaDon(string MaHD)
        {
            return db.ExecuteQueryDataSet("select MaHD,NgayXuatDon,MaNV,MaKH,TongHoaDon from HoaDon where MaHD = '"+ MaHD+"' ", CommandType.Text);
        }
        public DataSet TKDoanhThu(int year)
        {
            if(SHAREVAR.TK_TheoThang == true)
            return db.ExecuteQueryDataSet("select MONTH(NgayXuatDon) as ThongKe ,SUM(TongHoaDon) as DoanhThu from HoaDon WHERE YEAR(NgayXuatDon) = " + year + " Group by MONTH(NgayXuatDon) ORDER By MONTH(NgayXuatDon) ", CommandType.Text);
            else
                if (SHAREVAR.TK_TheoQuy == true)
                return db.ExecuteQueryDataSet("SELECT DATEPART( QUARTER,(NgayXuatDon)) as ThongKe ,SUM(TongHoaDon) AS DoanhThu FROM dbo.HoaDon WHERE YEAR(NgayXuatDon) = "+ year+ " GROUP BY DATEPART( QUARTER,(NgayXuatDon)) ORDER BY DATEPART( QUARTER,(NgayXuatDon))  ", CommandType.Text);
            else
                if (SHAREVAR.TK_TheoNam == true)
                return db.ExecuteQueryDataSet("select YEAR(NgayXuatDon) as ThongKe ,SUM(TongHoaDon) as DoanhThu from HoaDon Group by YEAR(NgayXuatDon) ORDER By YEAR(NgayXuatDon) ", CommandType.Text);
            return new DataSet();
        }
        public bool ThemHD_Xe(string MaHD, string MaXe, int Gia, int slXe, ref string err)
        {
            string sqlString = "Insert Into HD_Xe (MaHD,MaXe,Gia,SLXe) Values ( @MaHD , @MaXe , @Gia , @slXe ) ; Update Xe set SoLuong = SoLuong - @slXe where MaXe = @MaXe ";
            //string sqlString = "Insert Into HD_Xe Values( 'HD6',@MaXe,@Gia,@slXe )";
            SqlParameter[] para = {
            new SqlParameter("@MaHD", MaHD),
            new SqlParameter("@MaXe", MaXe),
            new SqlParameter("@Gia", Gia),
            new SqlParameter("@slXe", slXe) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
            //string sqlString = "Insert into HD_Xe (MaHD,MaXe) Values('HD4','X01')";
            //return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            //string sqlString = "Insert into HD_Xe Values('" + MaHD+"','"+MaXe+"',"+Gia+","+slXe +")" ;
            //return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            //string sqlString = "Insert Into KHACHHANG Values(" + "N'" +
            //MaHD + "',N'" +
            //MaXe + "',N'" +
            //Gia + "',N'" +
            //slXe + "')";
            //return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayDSMaHD()
        {
            return db.ExecuteQueryDataSet("select MaHD from HoaDon  ", CommandType.Text);
        }
        public bool ThemHD(string MaHD, DateTime NgayXD, int TongHD, string MaKH, string MaNV, ref string err)
        {

            string sqlString = "Insert Into HoaDon Values( @MaHD,@NgayXD,@TongHD,@MaKH,@MaNV )";
            SqlParameter[] para = {
            new SqlParameter("@MaHD", MaHD),
            new SqlParameter("@NgayXD", NgayXD),
            new SqlParameter("@TongHD", TongHD),
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@MaNV", MaNV) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public bool XoaHD(string MaHD, ref string err)
        {
            string sqlString = "Delete From HoaDon Where MaHD = @MaHD";
            SqlParameter[] para = {
            new SqlParameter("@MaHD", MaHD) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public bool CapNhatHD(string MaHD, DateTime NgayXD, int TongHD, string MaKH, string MaNV, ref string err)
        {
            string sqlString = "Update HoaDon Set NgayXuatDon = @NgayXD ,TongHoaDon = @TongHD ,MaKH = @MaKH ,MaNV = @MaNV  Where MaKH = @MaKH";
            SqlParameter[] para = {
            new SqlParameter("@MaHD", MaHD),
            new SqlParameter("@NgayXD", NgayXD),
            new SqlParameter("@TongHD", TongHD),
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@MaNV", MaNV) };
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }

        public DataSet Timkiem(string TK)
        {

            if (SHAREVAR.search_MaHD == true)
            {
                return db.ExecuteQueryDataSet("Select * from HoaDon where MaHD like '" + TK + "%'", CommandType.Text);
            }
            else if (SHAREVAR.search_MaNVHD == true)
            {
                return db.ExecuteQueryDataSet("Select * from HoaDon where MaNV like '" + TK + "%'", CommandType.Text);
            }
            else
            {
                return db.ExecuteQueryDataSet("Select * from HoaDon where MaKH like '" + TK + "%'", CommandType.Text);
            }
        }
    }
}
