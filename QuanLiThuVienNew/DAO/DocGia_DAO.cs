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
   public class DocGia_DAO
    {
       public static SqlConnection con;
        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * From DocGia";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static bool Them(DocGia_DTO DG)
        {
            try
            {
                string sTruyVan = string.Format("Insert into DocGia(HoTen,NgaySinh,GioiTinh,DienThoai,DiaChi,Email) values(N'{0}','{1}','{2}','{3}',N'{4}','{5}')", DG.HoTen, DG.NgaySinh, DG.GioiTinh, DG.DienThoai, DG.DiaChi, DG.Email);
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

        public static bool Sua(DocGia_DTO DG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update DocGia set HoTen = N'{0}' ,NgaySinh = '{1}',GioiTinh='{2}',DienThoai = '{3}',DiaChi=N'{4}',Email='{5}' where MaDocGia ='{6}'", DG.HoTen, DG.NgaySinh, DG.GioiTinh, DG.DienThoai, DG.DiaChi, DG.Email, DG.MaDocGia);
                DataProvider.ThucThiTruyVanNonQuery(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(DocGia_DTO DG)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete From DocGia where MaDocGia = '{0}'", DG.MaDocGia);
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
