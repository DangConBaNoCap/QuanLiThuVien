using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class NhaXuatBan_DAO
    {

        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From NhaXuatBan";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(NhaXuatBan_DTO NXB)
        {
            try
            {
                string sTruyVan = string.Format("Insert into NhaXuatBan(TenNXB,DiaChi,DienThoai) values(N'{0}','{1}','{2}')", NXB.TenNXB, NXB.DiaChi, NXB.DienThoai);
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

        public static bool Sua(NhaXuatBan_DTO NXB)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update NhaXuatBan set TenNXB = N'{0}' ,DiaChi = N'{1}',DienThoai='{2}' where MaNXB ='{3}'", NXB.TenNXB, NXB.DiaChi, NXB.DienThoai, NXB.MaNXB);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(NhaXuatBan_DTO NXB)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From NhaXuatBan where MaNXB = '{0}'", NXB.MaNXB);
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
