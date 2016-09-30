using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuDe_DTO
    {
        private int _MaCD;

        public int MaCD
        {
            get { return _MaCD; }
            set { _MaCD = value; }
        }
        private string _TenCD;

        public string TenCD
        {
            get { return _TenCD; }
            set { _TenCD = value; }
        }

    }
}
