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
    public partial class frmSinhVienMain : DevExpress.XtraEditors.XtraForm
    {
        private Form form;
        public frmSinhVienMain()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSinhVienMain_Load(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            //List<string> lanthi = new List<string>();
            //lanthi.Add("1");
            //lanthi.Add("2");
            //cbxLanThi.DataSource = lanthi;
            //cbxLanThi.SelectedIndex = 0;
            cbxMonHoc.SelectedIndex = 0;
            //cbxNgayThi.SelectedIndex = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmDangNhap = new frmDangNhap();
            Program.frmDangNhap.Activate();
            Program.frmDangNhap.ShowDialog();
            this.Close();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmThi = new frmThi();
            Program.frmThi.Activate();
            Program.frmThi.MASO.Text = Program.mSV;
            Program.frmThi.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmThi.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.frmThi.MONHOC.Text = cbxMonHoc.SelectedValue.ToString().Trim();
            Program.frmThi.txtLanThi.Text = cbxLanThi.Text;
            Program.frmThi.txtMonHoc.Text = cbxMonHoc.Text;
            Program.frmThi.txtNgayThi.Text = cbxNgayThi.Text;
            Program.frmThi.MAMON = cbxMonHoc.SelectedValue.ToString().Trim();
            Program.frmThi.ShowDialog();
            this.Close();
        }
    }
}