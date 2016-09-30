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
   public class NhanVien_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From NhanVien";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(NhanVien_DTO NV)
        {
            try
            {
                string sTruyVan = string.Format("Insert into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai) values(N'{0}','{1}','{2}',N'{3}','{4}')", NV.HoTen, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.DienThoai);
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

        public static bool Sua(NhanVien_DTO NV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update NhanVien set HoTen= N'{0}',NgaySinh='{1}',GioiTinh='{2}',DiaChi=N'{3}',DienThoai='{4}' where MaNV='{5}'", NV.HoTen, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.DienThoai, NV.MaNV);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(NhanVien_DTO NV)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From NhanVien where MaNV = '{0}'", NV.MaNV);
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
