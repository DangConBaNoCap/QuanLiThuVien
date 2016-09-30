using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia_DTO
    {

        private int _MaTG;

        public int MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }


        private string _TenTG;

        public string TenTG
        {
            get { return _TenTG; }
            set { _TenTG = value; }
        }


        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }


        private string _TieuSu;

        public string TieuSu
        {
            get { return _TieuSu; }
            set { _TieuSu = value; }
        }


        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
    }
}
