using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThamGia_DTO
    {
        private int _MaSach;

        public int MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }


        private int _MaTG;

        public int MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }


        private String _VaiTro;

        public String VaiTro
        {
            get { return _VaiTro; }
            set { _VaiTro = value; }
        }


        private string _ViTri;

        public string ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }
    }
}
