using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
   public class Sach_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From Sach";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(Sach_DTO S)
        {
            try
            {
                string sTruyVan = string.Format("Insert into Sach(TenSach,GiaBan,MoTa,SoLuong,NgayNhap,MaNXB,MaCD) values(N'{0}','{1}',N'{2}','{3}','{4}','{5}','{6}')", S.TenSach, S.GiaBan, S.MoTa, S.SoLuong, S.NgayNhap, S.MaNXB, S.MaCD);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Sua(Sach_DTO S)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update Sach set TenSach = N'{0}' ,GiaBan = '{1}',MoTa=N'{2}',SoLuong = '{3}',NgayNhap='{4}',MaNXB='{5}',MaCD='{6}' where MaSach='{7}'",S.TenSach,S.GiaBan,S.MoTa,S.SoLuong,S.NgayNhap,S.MaNXB,S.MaCD,S.MaSach );
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(Sach_DTO S)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From Sach where MaSach = '{0}'", S.MaSach);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
