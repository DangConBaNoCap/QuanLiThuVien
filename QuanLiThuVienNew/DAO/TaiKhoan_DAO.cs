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
    public class TaiKhoan_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From TaiKhoan";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(TaiKhoan_DTO TK)
        {
            try
            {
                string sTruyVan = string.Format("Insert into TaiKhoan(TaiKhoan,MatKhau,MaNV) values(N'{0}',N'{1}','{2}')", TK.TaiKhoan, TK.MatKhau, TK.MaNV);
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

        public static bool Sua(TaiKhoan_DTO TK)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update TaiKhoan set MatKhau='{0}',MaNV='{1}' where TaiKhoan ='{3}'", TK.MatKhau, TK.MaNV, TK.TaiKhoan);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(TaiKhoan_DTO TK)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From TaiKhoan where TaiKhoan = '{0}'", TK.TaiKhoan);
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
