namespace TN_CSDLPT
{
    partial class frmThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.bdBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.adapterBoDe = new TN_CSDLPT.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.txtNgayThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSoCau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.txtD = new System.Windows.Forms.TextBox();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MASO = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.MALOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.TENLOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.MONHOC = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCount = new System.Windows.Forms.Label();
            this.bdBaiThi = new System.Windows.Forms.BindingSource(this.components);
            this.adapterBaiThi = new TN_CSDLPT.DSTableAdapters.BAITHITableAdapter();
            this.bdBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.adapterBangDiem = new TN_CSDLPT.DSTableAdapters.BANGDIEMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBoDe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdBoDe
            // 
            this.bdBoDe.DataMember = "BODE";
            this.bdBoDe.DataSource = this.dS;
            // 
            // adapterBoDe
            // 
            this.adapterBoDe.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.adapterBoDe;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtLanThi);
            this.panel1.Controls.Add(this.txtNgayThi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMonHoc);
            this.panel1.Controls.Add(this.btnNopBai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(46, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Enabled = false;
            this.txtLanThi.Location = new System.Drawing.Point(403, 45);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(100, 21);
            this.txtLanThi.TabIndex = 6;
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.Enabled = false;
            this.txtNgayThi.Location = new System.Drawing.Point(244, 45);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Size = new System.Drawing.Size(100, 21);
            this.txtNgayThi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lần thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn học:";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Enabled = false;
            this.txtMonHoc.Location = new System.Drawing.Point(81, 45);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(100, 21);
            this.txtMonHoc.TabIndex = 1;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(528, 44);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(75, 21);
            this.btnNopBai.TabIndex = 0;
            this.btnNopBai.Text = "Nop Bai";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSoCau);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNoiDung);
            this.panel2.Controls.Add(this.rdD);
            this.panel2.Controls.Add(this.txtD);
            this.panel2.Controls.Add(this.rdC);
            this.panel2.Controls.Add(this.rdB);
            this.panel2.Controls.Add(this.txtC);
            this.panel2.Controls.Add(this.txtB);
            this.panel2.Controls.Add(this.rdA);
            this.panel2.Controls.Add(this.txtA);
            this.panel2.Location = new System.Drawing.Point(32, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 262);
            this.panel2.TabIndex = 1;
            // 
            // lbSoCau
            // 
            this.lbSoCau.AutoSize = true;
            this.lbSoCau.Location = new System.Drawing.Point(49, 12);
            this.lbSoCau.Name = "lbSoCau";
            this.lbSoCau.Size = new System.Drawing.Size(13, 13);
            this.lbSoCau.TabIndex = 6;
            this.lbSoCau.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cau so:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Enabled = false;
            this.txtNoiDung.Location = new System.Drawing.Point(49, 36);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(487, 79);
            this.txtNoiDung.TabIndex = 4;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(277, 197);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(36, 17);
            this.rdD.TabIndex = 3;
            this.rdD.TabStop = true;
            this.rdD.Text = "D.";
            this.rdD.UseVisualStyleBackColor = true;
            this.rdD.CheckedChanged += new System.EventHandler(this.rdD_CheckedChanged);
            // 
            // txtD
            // 
            this.txtD.Enabled = false;
            this.txtD.Location = new System.Drawing.Point(318, 197);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(218, 54);
            this.txtD.TabIndex = 3;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(7, 197);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(36, 17);
            this.rdC.TabIndex = 2;
            this.rdC.TabStop = true;
            this.rdC.Text = "C.";
            this.rdC.UseVisualStyleBackColor = true;
            this.rdC.CheckedChanged += new System.EventHandler(this.rdC_CheckedChanged);
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(277, 137);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(35, 17);
            this.rdB.TabIndex = 1;
            this.rdB.TabStop = true;
            this.rdB.Text = "B.";
            this.rdB.UseVisualStyleBackColor = true;
            this.rdB.CheckedChanged += new System.EventHandler(this.rdB_CheckedChanged);
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(49, 197);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(218, 54);
            this.txtC.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(318, 137);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(218, 54);
            this.txtB.TabIndex = 1;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(7, 137);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(36, 17);
            this.rdA.TabIndex = 0;
            this.rdA.TabStop = true;
            this.rdA.Text = "A.";
            this.rdA.UseVisualStyleBackColor = true;
            this.rdA.CheckedChanged += new System.EventHandler(this.rdA_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(49, 137);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(218, 54);
            this.txtA.TabIndex = 0;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Location = new System.Drawing.Point(32, 107);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnCauTruoc.TabIndex = 2;
            this.btnCauTruoc.Text = "Cau truoc";
            this.btnCauTruoc.UseVisualStyleBackColor = true;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.Location = new System.Drawing.Point(509, 107);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(75, 23);
            this.btnCauSau.TabIndex = 3;
            this.btnCauSau.Text = "Cau sau";
            this.btnCauSau.UseVisualStyleBackColor = true;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Enabled = false;
            this.txtTimer.Location = new System.Drawing.Point(264, 92);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(100, 21);
            this.txtTimer.TabIndex = 4;
            this.txtTimer.Text = "10:10:10";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.MASO,
            this.HOTEN,
            this.NHOM,
            this.MALOP,
            this.TENLOP,
            this.MONHOC});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MASO
            // 
            this.MASO.Name = "MASO";
            this.MASO.Size = new System.Drawing.Size(41, 17);
            this.MASO.Text = "MASO";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // MALOP
            // 
            this.MALOP.Name = "MALOP";
            this.MALOP.Size = new System.Drawing.Size(48, 17);
            this.MALOP.Text = "MALOP";
            // 
            // TENLOP
            // 
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Size = new System.Drawing.Size(50, 17);
            this.TENLOP.Text = "TENLOP";
            // 
            // MONHOC
            // 
            this.MONHOC.Name = "MONHOC";
            this.MONHOC.Size = new System.Drawing.Size(62, 17);
            this.MONHOC.Text = "MONHOC";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(297, 116);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(35, 13);
            this.lbCount.TabIndex = 6;
            this.lbCount.Text = "12/30";
            // 
            // bdBaiThi
            // 
            this.bdBaiThi.DataMember = "BAITHI";
            this.bdBaiThi.DataSource = this.dS;
            // 
            // adapterBaiThi
            // 
            this.adapterBaiThi.ClearBeforeFill = true;
            // 
            // bdBangDiem
            // 
            this.bdBangDiem.DataMember = "BANGDIEM";
            this.bdBangDiem.DataSource = this.dS;
            // 
            // adapterBangDiem
            // 
            this.adapterBangDiem.ClearBeforeFill = true;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 452);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBoDe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private DS dS;
        private System.Windows.Forms.BindingSource bdBoDe;
        private DSTableAdapters.BODETableAdapter adapterBoDe;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSoCau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel MASO;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private System.Windows.Forms.Button btnNopBai;
        public System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNgayThi;
        public System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.ToolStripStatusLabel MALOP;
        private System.Windows.Forms.ToolStripStatusLabel TENLOP;
        public System.Windows.Forms.ToolStripStatusLabel MONHOC;
        private System.Windows.Forms.BindingSource bdBaiThi;
        private DSTableAdapters.BAITHITableAdapter adapterBaiThi;
        private System.Windows.Forms.BindingSource bdBangDiem;
        private DSTableAdapters.BANGDIEMTableAdapter adapterBangDiem;
    }
}