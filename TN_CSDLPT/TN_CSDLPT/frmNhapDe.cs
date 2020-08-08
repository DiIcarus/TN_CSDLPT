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
    public partial class frmNhapDe : DevExpress.XtraEditors.XtraForm
    {
        private class UndoTarget
        {
            private int CAUHOI;
            private string MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAPAN, MAGV;
            private string HANHDONG;
            UndoTarget(int CAUHOI, string MAMH, string TRINHDO, string NOIDUNG, string A, string B, string C, string D, string DAPAN, string MAGV, string HANHDONG)
            {
                this.CAUHOI = CAUHOI;
                this.MAMH = MAMH;
                this.TRINHDO = TRINHDO;
                this.NOIDUNG = NOIDUNG;
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.DAPAN = DAPAN;
                this.MAGV = MAGV;
                this.HANHDONG = HANHDONG;
            }
            string getHanhDong()
            {
                return this.HANHDONG;
            }
            string[] getInfo()
            {
                string[] arr = { this.MAMH, this.TRINHDO, this.NOIDUNG,this.A,this.B,this.C,this.D,this.DAPAN,this.MAGV};
                return arr;
            }
            int getMaCauHoi()
            {
                return this.CAUHOI;
            }
        }

        private Stack<UndoTarget> undoTarget = new Stack<UndoTarget>();
        public frmNhapDe()
        {
            InitializeComponent();
            this.Text = "Nhập đề";
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            this.adapterBoDe.Connection.ConnectionString = Program.connstr;
            this.adapterBoDe.Fill(this.dS.BODE);

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
            this.bsBoDe.RemoveAt(this.gridView.GetSelectedRows()[0]);
            this.adapterBoDe.Connection.ConnectionString = Program.connstr;
            this.adapterBoDe.Update(this.dS.BODE);
            //this.undoTarget.Push()
        }
        void NhapBoDe(int CAUHOI, string MAMH, string TRINHDO, string NOIDUNG, string A,string B,string C,string D,string DAPAN,string MAGV)
        {
            this.bsBoDe.EndEdit();
            this.bsBoDe.ResetCurrentItem();
            this.adapterBoDe.Connection.ConnectionString = Program.connstr;
            this.adapterBoDe.Insert(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAPAN, MAGV);
            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
            this.adapterBoDe.Fill(this.dS.BODE);
            this.gridControlAll.DataSource = this.dS.BODE;
            this.gridControlAll.RefreshDataSource();
            this.gridView.RefreshData();
            //this.undoTarget.Push()

        }
        void HieuChinhBoDe()
        {
            this.bsBoDe.EndEdit();
            this.bsBoDe.ResetCurrentItem();
            this.adapterBoDe.Connection.ConnectionString = Program.connstr;
            this.adapterBoDe.Update(this.dS.BODE);
            this.adapterBoDe.Fill(this.dS.BODE);
            this.gridControlAll.DataSource = this.dS.BODE;
            this.gridControlAll.RefreshDataSource();
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