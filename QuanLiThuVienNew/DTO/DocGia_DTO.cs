using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia_DTO
    {
        private int _MaDocGia;

        public int MaDocGia
        {
            get { return _MaDocGia; }
            set { _MaDocGia = value; }
        }




        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }




        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }



        private int _GioiTinh;

        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }




        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }



        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }



        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        
    }
}
