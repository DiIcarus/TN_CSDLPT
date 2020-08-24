namespace TN_CSDLPT
{
    partial class frmSinhVienMain
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
            System.Windows.Forms.Label mAMHLabel;
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MASO = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dS = new TN_CSDLPT.DS();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.cbxNgayThi = new System.Windows.Forms.ComboBox();
            this.cbxLanThi = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(103, 66);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(0, 13);
            mAMHLabel.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASO,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lần thi:";
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(192, 154);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(75, 23);
            this.btnThi.TabIndex = 11;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(89, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "MAMH", true));
            this.cbxMonHoc.DataSource = this.mONHOCBindingSource;
            this.cbxMonHoc.DisplayMember = "TENMH";
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(89, 52);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(178, 21);
            this.cbxMonHoc.TabIndex = 14;
            this.cbxMonHoc.ValueMember = "MAMH";
            // 
            // cbxNgayThi
            // 
            this.cbxNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "NGAYTHI", true));
            this.cbxNgayThi.FormattingEnabled = true;
            this.cbxNgayThi.Location = new System.Drawing.Point(89, 87);
            this.cbxNgayThi.Name = "cbxNgayThi";
            this.cbxNgayThi.Size = new System.Drawing.Size(178, 21);
            this.cbxNgayThi.TabIndex = 15;
            // 
            // cbxLanThi
            // 
            this.cbxLanThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "LAN", true));
            this.cbxLanThi.FormattingEnabled = true;
            this.cbxLanThi.Location = new System.Drawing.Point(89, 119);
            this.cbxLanThi.Name = "cbxLanThi";
            this.cbxLanThi.Size = new System.Drawing.Size(178, 21);
            this.cbxLanThi.TabIndex = 16;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVienMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 242);
            this.Controls.Add(this.cbxLanThi);
            this.Controls.Add(this.cbxNgayThi);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmSinhVienMain";
            this.Text = "frmSinhVienMain";
            this.Load += new System.EventHandler(this.frmSinhVienMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MASO;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnThoat;
        private DS dS;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.ComboBox cbxNgayThi;
        private System.Windows.Forms.ComboBox cbxLanThi;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}