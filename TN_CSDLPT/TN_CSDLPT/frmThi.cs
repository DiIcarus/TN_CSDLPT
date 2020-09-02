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
        public static BaiThi[] listCauHoi;
        public string[] listResult = new String[20];
        private float diem = -1;
        public static bool checkThi = false;
        private int soCauThi = 20;
        public static ListViewItem baiThi;
        public int currentIndex = 0;// câu hiện tại
        public int pickedIndex = 0;// số câu đã chọn
        public string currentPicked = "";
        public int duration = 120;
        public string MAMON = "";
        public int MABD;

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

            timer.Start();
            bdBaiThi.DataSource = dt;
            listCauHoi = new BaiThi[soCauThi];
            checkThi = true;

            if (isSinhVien != true)
            {
            }
            else
            {
                displayCauHoi(currentIndex);
            }
        }
        void displayCauHoi(int currentIndex)
        {
            txtNoiDung.Text = ((DataRowView)bdBaiThi[currentIndex])["NOIDUNG"].ToString();
            txtA.Text = ((DataRowView)bdBaiThi[currentIndex])["A"].ToString();
            txtB.Text = ((DataRowView)bdBaiThi[currentIndex])["B"].ToString();
            txtC.Text = ((DataRowView)bdBaiThi[currentIndex])["C"].ToString();
            txtD.Text = ((DataRowView)bdBaiThi[currentIndex])["D"].ToString();
        }
        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        void randomMaBD()
        {
            Random rnd = new Random();
            bool check = false;
            while (!check)
            {
                check = true;
                int maBD = rnd.Next(soCauThi, soCauThi + 10);
                for (int i = 0; i < soCauThi && check; i++)
                {
                    //if (bdBangDiem == null){
                    //    break;
                    //}
                    //else if (maBD == Convert.ToInt32(((DataRowView)bdBangDiem[i])["MABD"].ToString().Trim()))
                    //{
                    //    check = false;
                    //    break;
                    //}
                }
                this.MABD = maBD;
            }
            
        }
        void insertNewBangDiem()
        {
            randomMaBD();
            this.adapterBangDiem.Connection.ConnectionString = Program.connstr;
            this.adapterBangDiem.Insert(
                MASO.Text.Trim(),
                MAMON,
                Convert.ToInt16(txtLanThi.Text.Trim()),
                DateTime.Parse(txtNgayThi.Text.Trim()),
                0,
                MABD
                );
            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
            this.adapterBangDiem.Fill(this.dS.BANGDIEM);
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            this.adapterBangDiem.Fill(this.dS.BANGDIEM);
            this.adapterBaiThi.Fill(this.dS.BAITHI);
            this.adapterBoDe.Fill(this.dS.BODE);
            loadThongTinSInhVien();
            insertNewBangDiem();
            loadCauHoi();
            setCoondowTime();
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if (currentIndex == 0)
            {
                currentIndex = listCauHoi.Length-1;
            }
            else
            {
                currentIndex--;
            }
            lbCount.Text = (currentIndex + 1).ToString().Trim() + "/" + listCauHoi.Length.ToString().Trim();
            displayCauHoi(currentIndex);
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            if (currentIndex == listCauHoi.Length - 1)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }
            lbCount.Text = (currentIndex + 1).ToString().Trim() + "/" + listCauHoi.Length.ToString().Trim();
            displayCauHoi(currentIndex);
        }
        void setCoondowTime()
        {
            int min = Convert.ToInt32(duration / 60);
            int sec = duration % 60;
            txtTimer.Text = min.ToString() + ":" + sec.ToString();
            duration--;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (duration > 0)
            {
                setCoondowTime();
            }
            else
            {
                setCoondowTime();
                timer.Stop();
                SubmitExercise();
                checkThi = false;
                MessageBox.Show("Đã hết giờ làm bài");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            Program.frmSinhVienMain = new frmSinhVienMain();
            Program.frmSinhVienMain.Activate();
            Program.frmSinhVienMain.MASO.Text = "Mã số: " + Program.mSV;
            Program.frmSinhVienMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmSinhVienMain.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.frmSinhVienMain.ShowDialog();
            this.Close();
        }

        private void rdA_CheckedChanged(object sender, EventArgs e)
        {
            listResult[currentIndex] = "A";
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
            listResult[currentIndex] = "B";
        }

        private void rdC_CheckedChanged(object sender, EventArgs e)
        {
            listResult[currentIndex] = "C";
        }

        private void rdD_CheckedChanged(object sender, EventArgs e)
        {
            listResult[currentIndex] = "D";
        }

        int summary()
        {
            return 0;
        }
        int genCode()
        {
            DateTime foo = DateTime.UtcNow;
            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
            int f =Convert.ToInt32 (unixTime / 100000);
            int l =Convert.ToInt32( unixTime % 100000);
            return f+l;
        }
        void SubmitExercise()
        {
            int rightAnswer = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                string dap_an = ((DataRowView)bdBoDe[i])["DAP_AN"].ToString();
                if(String.Compare( this.listResult[i],dap_an) == 0)
                {
                    rightAnswer++;
                }
                this.adapterBaiThi.Connection.ConnectionString = Program.connstr;
                this.adapterBaiThi.Insert(
                    Convert.ToInt32(((DataRowView)bdBoDe[i])["CAUHOI"]),
                    i,
                    ((DataRowView)bdBoDe[i])["NOIDUNG"].ToString().Trim(),
                    ((DataRowView)bdBoDe[i])["A"].ToString(),
                    ((DataRowView)bdBoDe[i])["B"].ToString(),
                    ((DataRowView)bdBoDe[i])["C"].ToString(),
                    ((DataRowView)bdBoDe[i])["D"].ToString(),
                    ((DataRowView)bdBoDe[i])["DAP_AN"].ToString(),
                    listResult[i].Trim(),
                    MABD
                    );
                MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                this.adapterBaiThi.Fill(this.dS.BAITHI);
                //Save Bai Thi
                //listCauHoi[i] = new BaiThi(
                //    Convert.ToInt32(((DataRowView)bdBaiThi[i])["CAUHOI"]),
                //    Convert.ToInt32(((DataRowView)bdBaiThi[i])["CAUSO"]),
                //    ((DataRowView)bdBaiThi[i])["NOIDUNG"].ToString(),
                //    ((DataRowView)bdBaiThi[i])["A"].ToString(),
                //    ((DataRowView)bdBaiThi[i])["B"].ToString(),
                //    ((DataRowView)bdBaiThi[i])["C"].ToString(),
                //    ((DataRowView)bdBaiThi[i])["D"].ToString(),
                //    ((DataRowView)bdBaiThi[i])["DAP_AN"].ToString(),
                //    listResult[i].Trim(),
                //    Convert.ToInt32(((DataRowView)bdBaiThi[i])["MABD"])
                //    );
                //MessageBox.Show(((DataRowView)bdBaiThi[i])["NOIDUNG"].ToString());
                //String[] arr = new string[2];
                //arr[0] = (i + 1).ToString();
                //arr[1] = listCauHoi[i].da_chon;

                //baiThi = new ListViewItem(arr);
                //Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].dap_an);
                ////this.summarylistview.Items.Add(baiThi);
            }
            float total = 10*rightAnswer / soCauThi;
            MessageBox.Show(total.ToString());
        }
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            SubmitExercise();
            checkThi = false;
            timer.Stop();
            //this.Hide();
            //Program.frmSinhVienMain = new frmSinhVienMain();//Mo form ket qua
            //Program.frmSinhVienMain.Activate();
            //Program.frmSinhVienMain.MASO.Text = "Mã số: " + Program.mSV;
            //Program.frmSinhVienMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
            //Program.frmSinhVienMain.NHOM.Text = "Nhóm: " + Program.mGroup;
            //Program.frmSinhVienMain.ShowDialog();
            //this.Close();
        }
    }
}