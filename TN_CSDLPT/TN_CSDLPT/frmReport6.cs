using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT
{
    public partial class frmReport6 : DevExpress.XtraEditors.XtraForm
    {
        public frmReport6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xrpDanhSachDangKyThi rpt = new xrpDanhSachDangKyThi();
            //rpt.xrlHoTen.Text = "aaaaaa";
            //rpt.xrlLop.Text = "bbbbb";
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}