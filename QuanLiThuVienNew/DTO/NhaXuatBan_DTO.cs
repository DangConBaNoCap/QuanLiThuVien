using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhaXuatBan_DTO
    {
        private int _MaNXB;

        public int MaNXB
        {
            get { return _MaNXB; }
            set { _MaNXB = value; }
        }


        private string _TenNXB;

        public string TenNXB
        {
            get { return _TenNXB; }
            set { _TenNXB = value; }
        }


        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }


        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

    }
}
