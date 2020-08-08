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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        void defaultUISetting()
        {
            rdGiaoVien.Checked = false;
            rdSinhVien.Checked = true;
            txtFirst.Focus();
            lbSeccond.Visible = false;
            txtSeccond.Visible = false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.defaultUISetting();
            try
            {
                // Integrated Security=True--> Kết nối về site chủ không cần password và tài khoản
                // dùng để lấy danh sách cơ sở từ site chủ
                string chuoiketnoi = "Data Source=HSONNL;Initial Catalog=TN_CSDLPT;Integrated Security=True";
                Program.conn.ConnectionString = chuoiketnoi;
                Program.conn.Open();

                // Gọi view V_DS_COSO và trả về datable 
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
                Program.bds_dspm.DataSource = dt;

                // Lấy kết quả đổ vào combobox
                cbxCoSo.DataSource = dt;
                cbxCoSo.DisplayMember = "TENCN";
                cbxCoSo.ValueMember = "TENSERVER";
                cbxCoSo.SelectedIndex = 1;
                cbxCoSo.SelectedIndex = 0;

            }
            catch (Exception a)
            {
                MessageBox.Show("Không thể kết nối tới database! " + a.Message, "", MessageBoxButtons.OK);
            }
        }

        private void rdSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            lbSeccond.Visible = false;
            txtSeccond.Visible = false;
            txtSeccond.Visible = false;
            lbFirst.Text = "MSSV";
        }

        private void rdGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            lbSeccond.Visible = true;
            lbSeccond.Visible = true;
            txtSeccond.Visible = true;
            lbFirst.Text = "ID";
            lbSeccond.Text = "Password";
        }

        private void cbxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCoSo.SelectedValue != null)
                {
                    Program.servername = cbxCoSo.SelectedValue.ToString();
                }
            }
            catch (Exception) { };
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text.Trim() == "" || txtSeccond.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được trống", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Program.mlogin = txtFirst.Text;
                Program.password = txtSeccond.Text;
            }
            if (txtSeccond.Text.Trim() == "" && rdSinhVien.Checked)
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Program.mSV = txtFirst.Text;
            }
            // Đăng nhập thất bại
            if (Program.KetNoi() == 0) return;


            Program.mCoSo = cbxCoSo.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            if (rdSinhVien.Checked)
            {
                String sql = "EXEC SP_KTSV_DANGNHAP '" + txtFirst.Text + "'";
                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    MessageBox.Show("blas");
                    return;
                }
            }

            string strLenh;
            if (rdGiaoVien.Checked)
            {
                strLenh = "EXEC SP_LAY_TT_DANGNHAP  '" + Program.mlogin + "'";
            }
            else
            {
                strLenh = "EXEC SP_LAY_TT_DANGNHAP_SV  '" + Program.mlogin + "' , " + "'" + Program.mSV + "'";
            }

            //Thực hiện sp
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            // Check giáo viên nhưng lại lấy tài khoản sinh viên đăng nhập
            if (rdGiaoVien.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("Sinhvien"))
                {
                    MessageBox.Show("Bạn đang đăng nhập tài khoản có quyền Sinhvien. \nVui lòng kiểm tra lại.", "", MessageBoxButtons.OK);
                    return;
                }
            }
            // Check sinh viên nhưng lại lấy Giangvien đăng nhập
            else
            {
                if (Program.myReader.GetString(2).Trim().Equals("Giangvien"))
                {
                    MessageBox.Show("Bạn đang đăng nhập tài khoản có quyền của Giangvien." +
                        "\n Vui lòng kiểm tra lại thông tin đăng nhập.", "", MessageBoxButtons.OK);
                    return;
                }
            }

            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Login thanh cong", "", MessageBoxButtons.OK);

                //Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                if (rdSinhVien.Checked)
                {
                    this.Hide();
                    Program.frmSinhVienMain = new frmSinhVienMain();
                    Program.frmSinhVienMain.Activate();
                    Program.frmSinhVienMain.MASO.Text = "Mã số: " + Program.mSV;
                    Program.frmSinhVienMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
                    Program.frmSinhVienMain.NHOM.Text = "Nhóm: " + Program.mGroup;
                    Program.frmSinhVienMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    Program.frmMain = new frmMain();
                    Program.frmMain.Activate();
                    Program.frmMain.MASO.Text = "Mã số: " + Program.username;
                    Program.frmMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
                    Program.frmMain.NHOM.Text = "Nhóm: " + Program.mGroup;
                    Program.frmMain.ShowDialog();
                    this.Close();
                }
                this.Hide();

            }
        }
    }
}