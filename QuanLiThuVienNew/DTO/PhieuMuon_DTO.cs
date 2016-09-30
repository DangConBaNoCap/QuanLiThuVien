using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuon_DTO
    {
        private int _MAPM;

        public int MAPM
        {
            get { return _MAPM; }
            set { _MAPM = value; }
        }


        private int _MaDG;

        public int MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }


        private DateTime _NgayMuon;

        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }


        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        
    }
}
