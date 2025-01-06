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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            HienThiSoQuanLy();
            HienThiSoNhanVien();
        }

        //ham hiển thi các dữ liệu thông kê lên các bảng sơ đồ dữ liệu
        void TaiDuLieu()
        {
            DataTable dt = new DataTable();
            string query = "select * from tbl_ThongKe";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DuLieu.strConn);

            adapter.Fill(dt);
            chart_TK_SanPham.DataSource = dt;
            chart_TK_DoanhThu.DataSource = dt;  
            // du lei bảng áo
            chart_TK_SanPham.Series["Áo"].XValueMember = "Thang";
            chart_TK_SanPham.Series["Áo"].YValueMembers = "Ao";
            chart_TK_SanPham.Series["Quần"].YValueMembers = "Quan";
            chart_TK_SanPham.Series["Cả Bộ"].YValueMembers = "CaBo";

            chart_TK_DoanhThu.Series["Thu Nhập"].YValueMembers = "DoanhThu";
            chart_TK_DoanhThu.Series["Tốc Độ"].YValueMembers = "TocDo";

        }

        //ham  hien thi so luong quan lý trong shop
        void HienThiSoQuanLy()
        {
            string query = "select count(*) from tbl_NhanVien where ChucVu = N'Quản Lý'";
            int quanly = 0;
            SqlConnection conn = new SqlConnection(DuLieu.strConn);
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            quanly = (int)command.ExecuteScalar();
            lbl_TK_QuanLy.Text = quanly.ToString();
            
            conn.Close();
        }


        // ham hien thi so luong nhan vien trong shop
        void HienThiSoNhanVien()
        {
            string query = "select count (*)from tbl_NhanVien where ChucVu = 'Nhân Viên'";
            int nhanVien = 0;
            SqlConnection conn = new SqlConnection(DuLieu.strConn);
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            nhanVien = (int)command.ExecuteScalar();
            lbl_TK_NhanVien.Text = nhanVien.ToString();

            conn.Close();
        }
    }

}
