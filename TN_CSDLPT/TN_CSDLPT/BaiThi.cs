using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT
{
    public class BaiThi
    {
        public int cau_hoi;
        public int cau_so;
        public string noi_dung;
        public string a, b, c, d, dap_an, da_chon;
        public int ma_bd;
        public BaiThi(int cau_hoi,int cau_so, string noi_dung,string a, string b, string c,string d,string dap_an, string da_chon,int ma_bd)
        {
            this.cau_hoi = cau_hoi;
            this.cau_so = cau_so;
            this.noi_dung = noi_dung;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.dap_an = dap_an;
            this.da_chon = da_chon;
            this.ma_bd = ma_bd;
        }
    }
}
