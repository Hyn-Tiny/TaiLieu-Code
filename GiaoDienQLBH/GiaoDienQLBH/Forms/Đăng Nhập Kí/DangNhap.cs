using GiaoDienQLBH.Forms.Đăng_Nhập_Kí;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienQLBH.Forms
{
    public partial class DangNhap : Form
    {

        private SqlDataAdapter adapter = null;


        private string query;

        public DangNhap()
        {
            InitializeComponent();
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }

       
        // ham kiem tra dang nhap
        void KiemTraDangNhap()
        {
            string tenDangNhap = txt_DN_TenDangNhap.Text.Trim();
            string matKhau = txt_DN_MatKhau.Text.Trim();

            query = "select * from tblTaiKhoan where TenDangNhap ='" + tenDangNhap + "' and MatKhau='" + matKhau + "'";

            adapter = new SqlDataAdapter(query, DuLieu.strConn);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tenDangNhap = txt_DN_TenDangNhap.Text.Trim();
                matKhau = txt_DN_MatKhau.Text.Trim();
                string quyen = dt.Rows[0]["ChucVu"].ToString();

                FormManager.Instance.TenDangNhap = tenDangNhap;
                FormManager.Instance.Quyen = quyen;


                //MessageBox.Show("hien thi ra: "+ quyen);
                ChangeForm();
            }

            else
            {
                MessageBox.Show("bạn đã nhập sai,bạn hãy nhập lại ", "Hộp Thoại Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DN_TenDangNhap.Focus();
            }

        }

        //hàm đổi form
        void ChangeForm()
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();

            this.Hide();
        }


        // thoát chuong trình
        private void lilbThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        //chuyen sang form dang ki
        private void lilbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dangKi = new DangKi();
            dangKi.Show();

            this.Hide();
        }

        
        private void chb_DN_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            HienMatKhau();
        }

        //ham hien mat khau
        void HienMatKhau() 
        {
            txt_DN_MatKhau.UseSystemPasswordChar = chb_DN_HienMatKhau.Checked ? false : true;
        }
    }
}
