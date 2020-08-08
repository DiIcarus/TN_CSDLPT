namespace TN_CSDLPT
{
    partial class frmDangNhap
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
            this.rdSinhVien = new System.Windows.Forms.RadioButton();
            this.rdGiaoVien = new System.Windows.Forms.RadioButton();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbSeccond = new System.Windows.Forms.Label();
            this.txtFirst = new DevExpress.XtraEditors.TextEdit();
            this.txtSeccond = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxCoSo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeccond.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rdSinhVien
            // 
            this.rdSinhVien.AutoSize = true;
            this.rdSinhVien.Location = new System.Drawing.Point(130, 26);
            this.rdSinhVien.Name = "rdSinhVien";
            this.rdSinhVien.Size = new System.Drawing.Size(68, 17);
            this.rdSinhVien.TabIndex = 0;
            this.rdSinhVien.TabStop = true;
            this.rdSinhVien.Text = "Sinh viên";
            this.rdSinhVien.UseVisualStyleBackColor = true;
            this.rdSinhVien.CheckedChanged += new System.EventHandler(this.rdSinhVien_CheckedChanged);
            // 
            // rdGiaoVien
            // 
            this.rdGiaoVien.AutoSize = true;
            this.rdGiaoVien.Location = new System.Drawing.Point(19, 26);
            this.rdGiaoVien.Name = "rdGiaoVien";
            this.rdGiaoVien.Size = new System.Drawing.Size(69, 17);
            this.rdGiaoVien.TabIndex = 1;
            this.rdGiaoVien.TabStop = true;
            this.rdGiaoVien.Text = "Giáo viên";
            this.rdGiaoVien.UseVisualStyleBackColor = true;
            this.rdGiaoVien.CheckedChanged += new System.EventHandler(this.rdGiaoVien_CheckedChanged);
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(35, 78);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(36, 13);
            this.lbFirst.TabIndex = 2;
            this.lbFirst.Text = "lbFirst";
            // 
            // lbSeccond
            // 
            this.lbSeccond.AutoSize = true;
            this.lbSeccond.Location = new System.Drawing.Point(16, 107);
            this.lbSeccond.Name = "lbSeccond";
            this.lbSeccond.Size = new System.Drawing.Size(55, 13);
            this.lbSeccond.TabIndex = 3;
            this.lbSeccond.Text = "lbSeccond";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(81, 78);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(136, 20);
            this.txtFirst.TabIndex = 4;
            // 
            // txtSeccond
            // 
            this.txtSeccond.Location = new System.Drawing.Point(81, 104);
            this.txtSeccond.Name = "txtSeccond";
            this.txtSeccond.Size = new System.Drawing.Size(136, 20);
            this.txtSeccond.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(261, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Đăng Nhập";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxCoSo
            // 
            this.cbxCoSo.FormattingEnabled = true;
            this.cbxCoSo.Location = new System.Drawing.Point(238, 25);
            this.cbxCoSo.Name = "cbxCoSo";
            this.cbxCoSo.Size = new System.Drawing.Size(121, 21);
            this.cbxCoSo.TabIndex = 7;
            this.cbxCoSo.SelectedIndexChanged += new System.EventHandler(this.cbxCoSo_SelectedIndexChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 151);
            this.Controls.Add(this.cbxCoSo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSeccond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lbSeccond);
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.rdGiaoVien);
            this.Controls.Add(this.rdSinhVien);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeccond.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdSinhVien;
        private System.Windows.Forms.RadioButton rdGiaoVien;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbSeccond;
        private DevExpress.XtraEditors.TextEdit txtFirst;
        private DevExpress.XtraEditors.TextEdit txtSeccond;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbxCoSo;
    }
}