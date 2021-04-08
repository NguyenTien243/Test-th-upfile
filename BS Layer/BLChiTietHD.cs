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
    class BLChiTietHD
    {
        public DBXe db = null;
        public BLChiTietHD()
        {
            db = new DBXe();
        }
        public DataSet LayThongTinXeMua(string MaHD)
        {
            return db.ExecuteQueryDataSet("SELECT HD_Xe.MaXe AS MaXe,TenXe,TenDongXe,NamRaMat,MauSac,dbo.HD_Xe.Gia AS GiaXe,dbo.HD_Xe.SLXe AS SLXe FROM Xe,dbo.DongXe,dbo.HD_Xe WHERE MaHD = '"+MaHD+"' AND HD_Xe.MaXe = dbo.Xe.MaXe AND Xe.MaDongXe = DongXe.MaDongXe", CommandType.Text);
        }
        
    }
}
