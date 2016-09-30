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
    public class TacGia_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From TacGia";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(TacGia_DTO TG)
        {
            try
            {
                string sTruyVan = string.Format("Insert into TacGia(TenTG,DiaChi,TieuSu,NgaySinh) values(N'{0}',N'{1}',N'{2}','{3}')", TG.TenTG, TG.DiaChi, TG.TieuSu, TG.NgaySinh);
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

        public static bool Sua(TacGia_DTO TG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update TacGia set TenTG = N'{0}' ,DiaChi = N'{1}',TieuSu='{2}',NgaySinh = '{3}' where MaTG ='{4}'", TG.TenTG, TG.DiaChi, TG.TieuSu, TG.NgaySinh, TG.MaTG);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(TacGia_DTO TG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From TacGia where MaTG = '{0}'", TG.MaTG);
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
