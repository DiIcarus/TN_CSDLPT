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
        private string control;
        public frmChuanBiThi()
        {
            InitializeComponent();
            this.Text = "Chuẩn bị thi";
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.adapterGiaoVienDangKy.Fill(this.dS.GIAOVIEN_DANGKY);
            List<string> trinhdo = new List<string>();
            List<string> lanthi = new List<string>();
            lanthi.Add("1");
            lanthi.Add("2");
            trinhdo.Add("A");
            trinhdo.Add("B");
            trinhdo.Add("C");
            this.cbxLanThi.DataSource = lanthi;
            this.cbxLanThi.SelectedIndex = 0;
            this.cbxTrinhDo.DataSource = trinhdo;
            this.cbxTrinhDo.SelectedIndex = 0;
        }
        void setDecisionButton(bool state)
        {
            this.btnGhi.Enabled = btnHuy.Enabled = state;
        }
        void setCRUDButton(bool state)
        {
            btnThem.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnSua.Enabled = state;
        }
        void setEditTable(bool state)
        {
            gridView.OptionsBehavior.Editable = state;
            gridView.OptionsBehavior.ReadOnly = !state;
        }
        void setStateCRUDOnClick()
        {
            setDecisionButton(true);
            setCRUDButton(false);
        }
        void setStateDecissionOnClick()
        {
            setDecisionButton(false);
            setCRUDButton(true);
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
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            
            
        }

     
        void XoaBoDe()
        {
            this.bsGiaoVienDangKy.RemoveAt(this.gridView.GetSelectedRows()[0]);
            this.adapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.adapterGiaoVienDangKy.Update(this.dS.GIAOVIEN_DANGKY);
            //this.undoTarget.Push()
        }
        void NhapFormChuanBiThi(string MAGV, string MAMH, string MALOP, string TRINHDO, DateTime NGAYTHI, short LAN, short SOCAUTHI, short THOIGIAN)
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
            setStateCRUDOnClick();
            this.control = "them";
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
            setStateDecissionOnClick();
            switch (this.control)
            {
                case "them":
                    //NhapFormChuanBiThi(
                    //    Program.username.Trim(),
                    //    cbxMonHoc.SelectedValue.ToString().Trim(),
                    //    "TH04",
                    //    cbxTrinhDo.Text.Trim(),
                    //    Convert.ToDateTime(spNgayThi.Text.Trim()),
                    //    Convert.ToInt16(cbxLanThi.Text.Trim()),
                    //     Convert.ToInt16(txtSoCauThi.Text.Trim()),
                    //    Convert.ToInt16(dateThoiGianThi.Text.Trim())
                    //    );
                    MessageBox.Show("Sua");
                    break;
                case "sua":
                    //HieuChinhBoDe();
                    setEditTable(false);
                    MessageBox.Show("Edit");
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setStateDecissionOnClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xoa");
            //XoaBoDe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setStateCRUDOnClick();
            setEditTable(true);
            this.control = "sua";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            setStateCRUDOnClick();
            this.control = "them";
        }

        private void btnGhi_Click_1(object sender, EventArgs e)
        {
            setStateDecissionOnClick();
            switch (this.control)
            {
                case "them":
                    //NhapFormChuanBiThi(
                    //    Program.username.Trim(),
                    //    cbxMonHoc.SelectedValue.ToString().Trim(),
                    //    "TH04",
                    //    cbxTrinhDo.Text.Trim(),
                    //    Convert.ToDateTime(spNgayThi.Text.Trim()),
                    //    Convert.ToInt16(cbxLanThi.Text.Trim()),
                    //    Convert.ToInt16(txtSoCauThi.Text.Trim()),
                    //    Convert.ToInt16(dateThoiGianThi.Text.Trim())
                    //    );
                    NhapFormChuanBiThi(
                        Program.username.Trim(),
                        cbxMonHoc.SelectedValue.ToString().Trim(),
                        "TH04",
                        cbxTrinhDo.Text.Trim(),
                        Convert.ToDateTime(spNgayThi.Text.Trim()),
                        Convert.ToInt16(cbxLanThi.Text.Trim()),
                        Convert.ToInt16(txtSoCauThi.Text.Trim()),
                        Convert.ToInt16(dateThoiGianThi.Text.Trim())
                        );
                    MessageBox.Show("Sua");
                    break;
                case "sua":
                    HieuChinhBoDe();
                    setEditTable(false);
                    MessageBox.Show("Edit");
                    break;
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            setStateDecissionOnClick();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhucHoi_Click_1(object sender, EventArgs e)
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

        private void btnThem_Click_2(object sender, EventArgs e)
        {
            setStateCRUDOnClick();
            this.control = "them";
        }
    }
}