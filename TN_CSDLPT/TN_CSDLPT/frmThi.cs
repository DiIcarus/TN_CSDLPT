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
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        private bool isSinhVien = true;
        public static CauHoi[] listCauHoi;
        private float diem = -1;
        public static bool checkThi = false;
        private int soCauThi = 20;
        public static ListViewItem baiThi;
        public int currentIndex = 0;
        public int pickedIndex = 0;
        public string currentPicked = "";
        public frmThi()
        {
            InitializeComponent();
        }
        private void loadThongTinSInhVien()
        {
            if (!Program.mSV.Equals(""))
            {
                String ktsocau = "SELECT LOP.MALOP, TENLOP FROM dbo.LOP JOIN dbo.SINHVIEN " +
                    "ON SINHVIEN.MALOP = LOP.MALOP WHERE MASV = '" + Program.mSV + "'";
                Program.myReader = Program.ExecSqlDataReader(ktsocau);
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    MALOP.Text = Program.myReader.GetString(0).Trim();
                    TENLOP.Text = Program.myReader.GetString(1).Trim();
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
        }
        public void loadCauHoi()
        {

            String sql = "";
            if (isSinhVien == true)
            {
                //sql = "exec SP_BAITHI '"
                //    + edtMaLop.Text + "','"
                //    + Program.mSV + "','"
                //    + cbbTenMon.SelectedValue.ToString() + "', "
                //    + cbbLanThi.SelectedValue.ToString().Trim();
                sql = "exec SP_Thi 20,N'AVCB',N'CNTT',N'A'";
            }
            else
            {
                //sql = "exec SP_ThiThu '"
                //     + cbbTenLop.SelectedValue.ToString() + "','"
                //    + cbbTenMon.SelectedValue.ToString() + "', "
                //    + cbbLanThi.SelectedValue.ToString().Trim();
                sql = "exec SP_Thi 20,N'AVCB',N'CNTT',N'A'";
            }
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy được đề thi, thiếu đề", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // bắt đầu thi khi đã có dữ liệu
            timer.Start();
            bdBaiThi.DataSource = dt;
            listCauHoi = new CauHoi[soCauThi];
            checkThi = true;

            if (isSinhVien != true)
            {
            }
            else
            {
                txtNoiDung.Text = ((DataRowView)bdBaiThi[1])["NOIDUNG"].ToString();
                txtA.Text = ((DataRowView)bdBaiThi[1])["A"].ToString();
                txtB.Text = ((DataRowView)bdBaiThi[1])["B"].ToString();
                txtC.Text = ((DataRowView)bdBaiThi[1])["C"].ToString();
                txtD.Text = ((DataRowView)bdBaiThi[1])["D"].ToString();
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    //listCauHoi[i] = new CauHoi(
                    //    ((DataRowView)bdBaiThi[i])["CAUHOI"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["CAUSO"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["NOIDUNG"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["A"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["B"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["C"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["D"].ToString(),
                    //    ((DataRowView)bdBaiThi[i])["DAPAN"].ToString(),
                    //    //this.currentPicked.Trim()
                    //    "",
                    //    ((DataRowView)bdBaiThi[i])["MABD"].ToString()
                    //    );
                    //txtNoiDung.Text = ((DataRowView)bdBaiThi[i])["NOIDUNG"].ToString();
                    //txtA.Text = ((DataRowView)bdBaiThi[i])["A"].ToString();
                    //txtB.Text = ((DataRowView)bdBaiThi[i])["B"].ToString();
                    //txtC.Text = ((DataRowView)bdBaiThi[i])["C"].ToString();
                    //txtD.Text = ((DataRowView)bdBaiThi[i])["D"].ToString();
                    //MessageBox.Show(((DataRowView)bdBaiThi[i])["NOIDUNG"].ToString());

                    //String[] arr = new string[2];
                    //arr[0] = (i + 1).ToString();
                    //arr[1] = listCauHoi[i].da_chon;

                    //baiThi = new ListViewItem(arr);
                    //Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].dap_an);
                    ////this.summarylistview.Items.Add(baiThi);
                }
            }
        }
        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            this.adapterBaiThi.Fill(this.dS.BAITHI);
            this.adapterBoDe.Fill(this.dS.BODE);
            loadThongTinSInhVien();
            loadCauHoi();
        }
    }
}