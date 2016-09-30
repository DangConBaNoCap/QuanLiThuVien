using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuMuon_DTO
    {

        private int _MaPM;

        public int MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }


        private int _MaSach;

        public int MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }


        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private DateTime _NgayHenTra;

        public DateTime NgayHenTra
        {
            get { return _NgayHenTra; }
            set { _NgayHenTra = value; }
        }
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
    }
}
