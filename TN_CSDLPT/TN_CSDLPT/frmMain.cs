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

namespace TN_CSDLPT
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private Form form;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnNhapDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(frmNhapDe));
            if(form == null)
            {
                frmNhapDe f = new frmNhapDe();
                //f.Text = "Nhap de";
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
            
        }
        private void btnChuanBiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(frmChuanBiThi));
            if (form == null)
            {
                frmChuanBiThi f = new frmChuanBiThi();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Program.frmDangNhap = new frmDangNhap();
            Program.frmDangNhap.Activate();
            Program.frmDangNhap.ShowDialog();
            this.Close();
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(frmThi));
            if (form == null)
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }
    }
}