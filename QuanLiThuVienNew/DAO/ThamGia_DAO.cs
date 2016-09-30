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
    public class ThamGia_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ThamGia";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(ThamGia_DTO TG)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ThamGia(MaSach,MaTG,VaiTro,ViTri) values('{0}','{1}',N'{2}',N'{3}')", TG.MaSach, TG.MaTG, TG.VaiTro, TG.ViTri);
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

        public static bool Sua(ThamGia_DTO TG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ThamGia set VaiTro=N'{0}',ViTri= N'{1}' where MaSach ='{2}'and MaTG='{3}'", TG.VaiTro, TG.ViTri, TG.MaSach, TG.MaTG);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ThamGia_DTO TG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From ThamGia where MaTG = '{0}' and MaSach='{1}'", TG.MaTG, TG.MaSach);
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
