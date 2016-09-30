using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
   public class ChuDe_DAO
    {

        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ChuDe";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(ChuDe_DTO CD)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ChuDe(TenCD) values(N'{0}')", CD.TenCD);
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

        public static bool Sua(ChuDe_DTO CD)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ChuDe set TenCD = N'{0}' where MaSach='{1}'", CD.TenCD, CD.MaCD);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ChuDe_DTO CD)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From ChuDe where MaCD = '{0}'", CD.MaCD);
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
