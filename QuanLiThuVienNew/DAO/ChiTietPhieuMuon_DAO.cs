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
    public class ChiTietPhieuMuon_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From ChiTietPhieuMuon";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(ChiTietPhieuMuon_DTO CTPM)
        {
            try
            {
                string sTruyVan = string.Format("Insert into ChiTietPhieuMuon(MaPM,MaSach,TinhTrang,SoLuong,NgayHenTra,NgayTra) values('{0}','{1}',N'{2}','{3}','{4}','{5}')", CTPM.MaPM, CTPM.MaSach, CTPM.TinhTrang, CTPM.SoLuong, CTPM.NgayHenTra,CTPM.NgayTra);
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

        public static bool Sua(ChiTietPhieuMuon_DTO CTPM)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update ChiTietPhieuMuon set TinhTrang= N'{0}' ,SoLuong= '{1}',NgayHenTra='{2}',NgayTra='{3}' where MaPM ='{4}'and MaSach='{5}'", CTPM.TinhTrang, CTPM.SoLuong, CTPM.NgayHenTra,CTPM.NgayTra, CTPM.MaPM, CTPM.MaSach);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(ChiTietPhieuMuon_DTO CTPM)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From ChiTietPhieuMuon where MaPM = '{0}'and MaSach='{1}'", CTPM.MaPM, CTPM.MaSach);
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
