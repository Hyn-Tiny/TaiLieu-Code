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

namespace GiaoDienQLBH.Forms.Đăng_Nhập_Kí
{
    public partial class DangKi : Form
    {
        private SqlDataAdapter adapter = null;
        private string query;
        public DangKi()
        {
            InitializeComponent();
        }

        private void lilb_DK_Thoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lilbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();

            this.Hide();

        }
       
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DangKiTaiKhoan();
        }

        //ham dang ki tai khoan
        void DangKiTaiKhoan()
        {
            string tenDangNhap = txt_DK_TenDangNhap.Text.Trim();
            string matKhau = txt_DL_MatKhau.Text.Trim();

            string nlMatKhau = txt_DK_NLMatKhau.Text.Trim();

            string chucVu = cbb_DK_ChucVu.Text.Trim();



            if (matKhau != nlMatKhau)
            {
                MessageBox.Show("Mật Khẩu không khớp", "hộp thoại", MessageBoxButtons.OK);
                return;
            }


            query = "select count(*) from tblTaiKhoan where TenDangNhap ='" + tenDangNhap + "' and MatKhau='" + matKhau + "'";

            adapter = new SqlDataAdapter(query, DuLieu.strConn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show($"tai khoan ton tai {chucVu}  {dt.Rows[0][0]}");
                return;
            }
            else
            {
                int i = 11;
                bool maTKTonTai = false;
                string maTK = "";
                while (!maTKTonTai)
                {
                    maTK = "TK" + i;
                    query = "select count(*) FROM tblTaiKhoan where MaTK = @MaTK";
                    adapter = new SqlDataAdapter(query, DuLieu.strConn);

                    adapter.SelectCommand.Parameters.AddWithValue("@MaTK", maTK);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    
                    //tim cac matk trong bảng nếu tồn tại tăng thêm 1,nếu chưa có thì thêm matk
                    if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        maTKTonTai = true;
                    }
                    else
                    {
                        i++;
                    }


                }
                query = "insert into tblTaiKhoan (MaTK,TenDangNhap,MatKhau,ChucVu) values ('TK" + i + "','" + tenDangNhap + "','" + matKhau + "',N'" + chucVu + "');";

                adapter = new SqlDataAdapter(query, DuLieu.strConn);
                dt = new DataTable();
                adapter.Fill(dt);

                MessageBox.Show($"Bạn tai khoan thanh cong", "Hộp Thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chb_DK_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            HienMatKhau();
        }


        //ham hien mat khau
        void HienMatKhau()
        {
            txt_DK_NLMatKhau.UseSystemPasswordChar = chb_DK_HienMatKhau.Checked ? false : true;
            txt_DL_MatKhau.UseSystemPasswordChar=chb_DK_HienMatKhau.Checked?false : true;
        }
    }
}
