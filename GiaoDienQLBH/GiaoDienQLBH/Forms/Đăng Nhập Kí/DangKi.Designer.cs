namespace GiaoDienQLBH.Forms.Đăng_Nhập_Kí
{
    partial class DangKi
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
            this.label3 = new System.Windows.Forms.Label();
            this.lilbDangNhap = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lilb_DK_Thoat = new System.Windows.Forms.LinkLabel();
            this.txt_DL_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_DK_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DK_NLMatKhau = new System.Windows.Forms.TextBox();
            this.cbb_DK_ChucVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_DK_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trang Đăng Kí";
            // 
            // lilbDangNhap
            // 
            this.lilbDangNhap.AutoSize = true;
            this.lilbDangNhap.Location = new System.Drawing.Point(240, 260);
            this.lilbDangNhap.Name = "lilbDangNhap";
            this.lilbDangNhap.Size = new System.Drawing.Size(62, 13);
            this.lilbDangNhap.TabIndex = 14;
            this.lilbDangNhap.TabStop = true;
            this.lilbDangNhap.Text = "Đăng Nhập";
            this.lilbDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbDangNhap_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // lilb_DK_Thoat
            // 
            this.lilb_DK_Thoat.AutoSize = true;
            this.lilb_DK_Thoat.Location = new System.Drawing.Point(104, 260);
            this.lilb_DK_Thoat.Name = "lilb_DK_Thoat";
            this.lilb_DK_Thoat.Size = new System.Drawing.Size(35, 13);
            this.lilb_DK_Thoat.TabIndex = 11;
            this.lilb_DK_Thoat.TabStop = true;
            this.lilb_DK_Thoat.Text = "Thoát";
            this.lilb_DK_Thoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilb_DK_Thoat_LinkClicked);
            // 
            // txt_DL_MatKhau
            // 
            this.txt_DL_MatKhau.Location = new System.Drawing.Point(128, 105);
            this.txt_DL_MatKhau.Name = "txt_DL_MatKhau";
            this.txt_DL_MatKhau.Size = new System.Drawing.Size(176, 20);
            this.txt_DL_MatKhau.TabIndex = 10;
            this.txt_DL_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_DK_TenDangNhap
            // 
            this.txt_DK_TenDangNhap.Location = new System.Drawing.Point(128, 69);
            this.txt_DK_TenDangNhap.Name = "txt_DK_TenDangNhap";
            this.txt_DK_TenDangNhap.Size = new System.Drawing.Size(176, 20);
            this.txt_DK_TenDangNhap.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhập lại Mật Khẩu:";
            // 
            // txt_DK_NLMatKhau
            // 
            this.txt_DK_NLMatKhau.Location = new System.Drawing.Point(126, 145);
            this.txt_DK_NLMatKhau.Name = "txt_DK_NLMatKhau";
            this.txt_DK_NLMatKhau.Size = new System.Drawing.Size(176, 20);
            this.txt_DK_NLMatKhau.TabIndex = 16;
            this.txt_DK_NLMatKhau.UseSystemPasswordChar = true;
            // 
            // cbb_DK_ChucVu
            // 
            this.cbb_DK_ChucVu.FormattingEnabled = true;
            this.cbb_DK_ChucVu.IntegralHeight = false;
            this.cbb_DK_ChucVu.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cbb_DK_ChucVu.Location = new System.Drawing.Point(126, 181);
            this.cbb_DK_ChucVu.Name = "cbb_DK_ChucVu";
            this.cbb_DK_ChucVu.Size = new System.Drawing.Size(176, 21);
            this.cbb_DK_ChucVu.TabIndex = 18;
            this.cbb_DK_ChucVu.Text = "Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chức Vụ:";
            // 
            // chb_DK_HienMatKhau
            // 
            this.chb_DK_HienMatKhau.AutoSize = true;
            this.chb_DK_HienMatKhau.Location = new System.Drawing.Point(205, 225);
            this.chb_DK_HienMatKhau.Name = "chb_DK_HienMatKhau";
            this.chb_DK_HienMatKhau.Size = new System.Drawing.Size(97, 17);
            this.chb_DK_HienMatKhau.TabIndex = 20;
            this.chb_DK_HienMatKhau.Text = "Hiện Mật Khẩu";
            this.chb_DK_HienMatKhau.UseVisualStyleBackColor = true;
            this.chb_DK_HienMatKhau.CheckedChanged += new System.EventHandler(this.chb_DK_HienMatKhau_CheckedChanged);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Image = global::GiaoDienQLBH.Properties.Resources.icons8_register_24;
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(143, 292);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(106, 39);
            this.btnDangKi.TabIndex = 8;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 343);
            this.Controls.Add(this.chb_DK_HienMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_DK_ChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DK_NLMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lilbDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lilb_DK_Thoat);
            this.Controls.Add(this.txt_DL_MatKhau);
            this.Controls.Add(this.txt_DK_TenDangNhap);
            this.Controls.Add(this.btnDangKi);
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lilbDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lilb_DK_Thoat;
        private System.Windows.Forms.TextBox txt_DL_MatKhau;
        private System.Windows.Forms.TextBox txt_DK_TenDangNhap;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DK_NLMatKhau;
        private System.Windows.Forms.ComboBox cbb_DK_ChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_DK_HienMatKhau;
    }
}