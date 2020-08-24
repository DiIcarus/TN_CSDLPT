using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public class CauHoi
    {
        public string cau_hoi;
        public string cau_so;
        public string noi_dung;
        public string a;
        public string b;
        public string c;
        public string d;
        public string da_chon = "";
        public string dap_an = "";
        public string ma_bd;
        public CauHoi(string cau_hoi, string cau_so, string noi_dung,string a,string b,string c, string d, string dap_an,string da_chon, string ma_bd)
        {
            this.cau_hoi = cau_hoi;
            this.cau_so = cau_so;
            this.noi_dung = noi_dung;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.da_chon = da_chon;
            this.dap_an = dap_an;
            this.ma_bd = ma_bd;
        }
    }
}
