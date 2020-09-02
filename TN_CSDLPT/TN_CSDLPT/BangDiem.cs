using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT
{
    public class BangDiem
    {
        string ma_sv, ma_mh;
        int lan;
        DateTime ngay_thi;
        float diem;
        int ma_bd;
        BangDiem( string ma_sv,string ma_mh, int lan, DateTime ngay_thi,float diem, int ma_bd)
        {
            this.ma_sv = ma_sv;
            this.ma_mh = ma_mh;
            this.lan = lan;
            this.ngay_thi = ngay_thi;
            this.diem = diem;
            this.ma_bd = ma_bd;
        }
    }
}
