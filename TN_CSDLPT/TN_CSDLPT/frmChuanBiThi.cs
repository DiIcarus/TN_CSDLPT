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
    public partial class frmChuanBiThi : DevExpress.XtraEditors.XtraForm
    {
        public frmChuanBiThi()
        {
            InitializeComponent();
            this.Text = "Chuẩn bị thi";
        }
        private class UndoTarget
        {
            public string MAGV, MAMH, MALOP, TRINHDO;
            public DateTime NGAYTHI;
            public short LAN, SOCAUTHI, THOIGIAN;
            private string HANHDONG;
            UndoTarget(string MAGV, string MAMH, string MALOP, string TRINHDO, DateTime NGAYTHI, short LAN, short SOCAUTHI, short THOIGIAN, string HANHDONG)
            {
                this.MAGV = MAGV;
                this.MAMH = MAMH;
                this.MALOP = TRINHDO;
                this.TRINHDO = TRINHDO;
                this.NGAYTHI = NGAYTHI;
                this.LAN = LAN;
                this.SOCAUTHI = SOCAUTHI;
                this.THOIGIAN = THOIGIAN;
                this.HANHDONG = HANHDONG;
            }
            string getHanhDong()
            {
                return this.HANHDONG;
            }
        }

        private Stack<UndoTarget> undoTarget = new Stack<UndoTarget>();

        private void frmChuanBiThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.adapterGiaoVienDangKy.Fill(this.dS.GIAOVIEN_DANGKY);

        }
        void setStateAddOnClick()
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void XoaBoDe()
        {
            this.bsGiaoVienDangKy.RemoveAt(this.gridView.GetSelectedRows()[0]);
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.adapterGiaoVienDangKy.Update(this.dS.GIAOVIEN_DANGKY);
            //this.undoTarget.Push()
        }
        void NhapBoDe(string MAGV, string MAMH, string MALOP, string TRINHDO, DateTime NGAYTHI, short LAN, short SOCAUTHI, short THOIGIAN)
        {
            this.bsGiaoVienDangKy.EndEdit();
            this.bsGiaoVienDangKy.ResetCurrentItem();
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.adapterGiaoVienDangKy.Insert(MAGV, MAMH, MALOP, TRINHDO, NGAYTHI, LAN, SOCAUTHI, THOIGIAN);
            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
            this.adapterGiaoVienDangKy.Fill(this.dS.GIAOVIEN_DANGKY);
            this.gridControl.DataSource = this.dS.GIAOVIEN_DANGKY;
            this.gridControl.RefreshDataSource();
            this.gridView.RefreshData();
            //this.undoTarget.Push()

        }
        void HieuChinhBoDe()
        {
            this.bsGiaoVienDangKy.EndEdit();
            this.bsGiaoVienDangKy.ResetCurrentItem();
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.adapterGiaoVienDangKy.Update(this.dS.GIAOVIEN_DANGKY);
            this.adapterGiaoVienDangKy.Fill(this.dS.GIAOVIEN_DANGKY);
            this.gridControl.DataSource = this.dS.GIAOVIEN_DANGKY;
            this.gridControl.RefreshDataSource();
            this.gridView.RefreshData();
            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
            //this.undoTarget.Push()

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Set display to add or update
            //switchGrid(true);
            //Program.Control = "insert";
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (this.undoTarget.Count <= 0)
                return;//stack rong

            UndoTarget oldRow = this.undoTarget.Pop();

            if (this.undoTarget.Count <= 0)
            {
                //phan tu cuoi
            }
            else
            {
                oldRow = this.undoTarget.Peek();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //NhapPhieuNhap();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Set display to cancel
        }
    }
}