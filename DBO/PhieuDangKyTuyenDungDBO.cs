using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PTTK.DBO
{
    internal class PhieuDangKyTuyenDungDBO
    {
        DataProvider DataProvider { get; set; }
        public PhieuDangKyTuyenDungDBO()
        {
            DataProvider = new DataProvider();
        }
    }
}
