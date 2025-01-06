using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienQLBH.Forms
{
    public partial class ChucNangNhanVien : Form
    {
        private NhanVien nhanVien;

        public ChucNangNhanVien()
        {
            InitializeComponent();
        }

        
        public ChucNangNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;

        }

        public ChucNangNhanVien(NhanVien nhanVien, string maNV, string tenNV, string ngaySinh, string SDT, string email, string queQuan, string chucVu, string luong)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;

            txtMaNV.Text = maNV;
            txtTenNV.Text = tenNV;
            dtp_NgaySinh.Text = ngaySinh;
            txt_SDT.Text = SDT;
            txt_Email.Text = email;
            txt_QueQuan.Text = queQuan;
            cbb_ChucVu.Text = chucVu;
            txt_Luong.Text = luong;
        }

        private void btn_HuyNV_Click(object sender, EventArgs e)
        {
            this.Close();
            nhanVien.BatNutThem_Sua(false);

        }

        private void btn_LuuNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string ngaySinh = dtp_NgaySinh.Text.Trim();
            string SDT = txt_SDT.Text.Trim();
            string Email = txt_Email.Text.Trim();
            string queQuan = txt_QueQuan.Text.Trim();
            string chucVu = cbb_ChucVu.Text.Trim();
            string luong = txt_Luong.Text.Trim();

            

            if (FormManager.Instance.ChucNang == 4)
            {

                if (maNV == "" || tenNV == "" || SDT == "" || Email == "" || queQuan == "" || luong == "")
                {
                    MessageBox.Show("bạn chua nhập gì,bạn hãy nhập đi");
                    return;
                }

                this.nhanVien.ThemMotNV(maNV, tenNV, ngaySinh, SDT, Email, queQuan, chucVu, luong);
            }
            else if (FormManager.Instance.ChucNang == 3)
            {
                this.nhanVien.SuaMotNhanVien(maNV, tenNV, ngaySinh, SDT, Email, queQuan, chucVu, luong);
            }

            this.Close();
        }



        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "abcd@gmail.com")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Text = "abcd@gmail.com";
                txt_Email.ForeColor = Color.Gray;
            }

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            txt_Email.ForeColor = Color.Black;
        }
    }
}
