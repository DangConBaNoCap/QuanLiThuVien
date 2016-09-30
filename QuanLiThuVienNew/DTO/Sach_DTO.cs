using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        private int _MaSach;

        public int MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }




        private string _TenSach;

        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }



        private decimal _GiaBan;

        public decimal GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }


        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }


        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }


        private DateTime _NgayNhap;

        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }


        private int _MaNXB;

        public int MaNXB
        {
            get { return _MaNXB; }
            set { _MaNXB = value; }
        }


        private int _MaCD;

        public int MaCD
        {
            get { return _MaCD; }
            set { _MaCD = value; }
        }
    }
}
