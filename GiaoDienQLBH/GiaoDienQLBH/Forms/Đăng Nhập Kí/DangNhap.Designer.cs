namespace GiaoDienQLBH.Forms
{
    partial class DangNhap
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
            this.txt_DN_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_DN_MatKhau = new System.Windows.Forms.TextBox();
            this.lilbThoat = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lilbDangKy = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_DN_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_DN_TenDangNhap
            // 
            this.txt_DN_TenDangNhap.Location = new System.Drawing.Point(146, 88);
            this.txt_DN_TenDangNhap.Name = "txt_DN_TenDangNhap";
            this.txt_DN_TenDangNhap.Size = new System.Drawing.Size(176, 20);
            this.txt_DN_TenDangNhap.TabIndex = 1;
            // 
            // txt_DN_MatKhau
            // 
            this.txt_DN_MatKhau.Location = new System.Drawing.Point(146, 137);
            this.txt_DN_MatKhau.Name = "txt_DN_MatKhau";
            this.txt_DN_MatKhau.Size = new System.Drawing.Size(176, 20);
            this.txt_DN_MatKhau.TabIndex = 2;
            this.txt_DN_MatKhau.UseSystemPasswordChar = true;
            // 
            // lilbThoat
            // 
            this.lilbThoat.AutoSize = true;
            this.lilbThoat.Location = new System.Drawing.Point(132, 206);
            this.lilbThoat.Name = "lilbThoat";
            this.lilbThoat.Size = new System.Drawing.Size(35, 13);
            this.lilbThoat.TabIndex = 3;
            this.lilbThoat.TabStop = true;
            this.lilbThoat.Text = "Thoát";
            this.lilbThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbThoat_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu:";
            // 
            // lilbDangKy
            // 
            this.lilbDangKy.AutoSize = true;
            this.lilbDangKy.Location = new System.Drawing.Point(255, 206);
            this.lilbDangKy.Name = "lilbDangKy";
            this.lilbDangKy.Size = new System.Drawing.Size(48, 13);
            this.lilbDangKy.TabIndex = 6;
            this.lilbDangKy.TabStop = true;
            this.lilbDangKy.Text = "Đăng Ký";
            this.lilbDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbDangKy_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trang Đăng Nhập";
            // 
            // chb_DN_HienMatKhau
            // 
            this.chb_DN_HienMatKhau.AutoSize = true;
            this.chb_DN_HienMatKhau.Location = new System.Drawing.Point(231, 174);
            this.chb_DN_HienMatKhau.Name = "chb_DN_HienMatKhau";
            this.chb_DN_HienMatKhau.Size = new System.Drawing.Size(97, 17);
            this.chb_DN_HienMatKhau.TabIndex = 8;
            this.chb_DN_HienMatKhau.Text = "Hiện Mật Khẩu";
            this.chb_DN_HienMatKhau.UseVisualStyleBackColor = true;
            this.chb_DN_HienMatKhau.CheckedChanged += new System.EventHandler(this.chb_DN_HienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = global::GiaoDienQLBH.Properties.Resources.icons8_enter_24;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(160, 238);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(133, 36);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.chb_DN_HienMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lilbDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lilbThoat);
            this.Controls.Add(this.txt_DN_MatKhau);
            this.Controls.Add(this.txt_DN_TenDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txt_DN_TenDangNhap;
        private System.Windows.Forms.TextBox txt_DN_MatKhau;
        private System.Windows.Forms.LinkLabel lilbThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lilbDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_DN_HienMatKhau;
    }
}