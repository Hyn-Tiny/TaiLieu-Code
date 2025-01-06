using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienQLBH.Forms
{
    public partial class SanPham : Form
    {
        private SqlConnection sqlCon = null;

        SqlDataAdapter adapter = null;
        DataSet ds = null;


        private string query;
        int vt = -1;
        private static string tblSrcSanPham = "tbl_SanPham";

        public SanPham()
        {
            InitializeComponent();
        }

        //ham kiem tra va mo ket noi
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(DuLieu.strConn);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }


        // ham kiem tra quyên
        void KiemtraQuyen()
        {
            if (string.Compare(FormManager.Instance.Quyen, "Quản Lý", true) == 0)// neu dung là  quản  lý thì sẽ cho thuc hiện các chức năng thêm xóa sử
            {
                BatNutThem_Sua(false);
            }

            else
            {
                BatTatCaNut(false);
            }
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();

            KiemtraQuyen();
        }

        //ham hien thi danh danh san pham
        private void HienThiDanhSachSanPham()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham";

            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];

        }

       public void BatNutThem_Sua(bool daBat)
        {
            btnSuaSP.Enabled = daBat;
            btnXoaSP.Enabled = daBat;
        }
        void BatTatCaNut(bool daBat)
        {
            BatNutThem_Sua(daBat);
            btnThemSP.Enabled = daBat;
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables[tblSrcSanPham].Rows[vt];

            if (string.Compare(FormManager.Instance.Quyen, "Quản Lý", true) == 0)
            {
                BatNutThem_Sua(true);
            }

        }

        private void btnTKSP_Click(object sender, EventArgs e)
        {
            string maTK = txtTKMaSP.Text.Trim();
            string tenTK = txtTKTenSP.Text.Trim();

            if (maTK != " " && tenTK == "")
            { TimKiemBangMa(maTK); }

            else if (maTK == "" && tenTK != "")
            { TimKiemBangTen(tenTK); }

            else if (maTK != "" && tenTK != "")
            { TimKiemBangMa(maTK); }

            else
            {
                MessageBox.Show("bạn chưa nhập gì ,bạn hãy nhập ở đây");
                txtTKMaSP.Focus();
            }

        }



        //ham thuc hien tim kiem bang ma
        private void TimKiemBangMa(string maSp)
        {
            MoKetNoi();

            query = "select * from tbl_SanPham where MaSP ='" + maSp + "'";
            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "tblTimKiemMa");
            dgvDanhSachSanPham.DataSource = ds.Tables["tblTimKiemMa"];

        }

        //ham thuc hien tim kiem bang ten
        private void TimKiemBangTen(string tenSp)
        {
            MoKetNoi();
            query = "select * from tbl_SanPham where TenSP like'%" + tenSp + "%'";
            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "tblTimKiemTen");
            dgvDanhSachSanPham.DataSource = ds.Tables["tblTimKiemTen"];
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
            FormManager.Instance.ChucNang = 0;

            ChucNangSanPham them = new ChucNangSanPham(this);
            them.ShowDialog();

        }

        // Phương thức để thêm dữ liệu vào DataGridView
        public void ThemVaoBang(string maSP, string tenSP, string soLuong, string gia, string kichCo, string ngayNhap, string hang, string tinhTrang)
        {
            try
            {
                DataRow row = ds.Tables[tblSrcSanPham].NewRow();
                // MessageBox.Show($"hien thi ra {}");
                row[DuLieu.maSP] = maSP;
                row[DuLieu.tenSP] = tenSP;
                row[DuLieu.soLuong] = soLuong;
                row[DuLieu.gia] = gia;
                row[DuLieu.kichCo] = kichCo;
                row[DuLieu.ngayNhap] = ngayNhap;
                row[DuLieu.hang] = hang;
                row[DuLieu.tinhTrang] = tinhTrang;
                ds.Tables[tblSrcSanPham].Rows.Add(row);

                int kq = adapter.Update(ds.Tables[tblSrcSanPham]);
                if (kq > 0)
                {
                    MessageBox.Show("bạn thêm thành công");
                    HienThiDanhSachSanPham();

                }
                else
                {
                    MessageBox.Show("bạn thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hiển thị ra lỗi " + ex.Message);
            }

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            FormManager.Instance.ChucNang = 1;
            if (vt == -1) return;

            DataRow row = ds.Tables[tblSrcSanPham].Rows[vt];
            string maSP = row[DuLieu.maSP].ToString().Trim();
            string tenSP = row[DuLieu.tenSP].ToString().Trim();
            string gia = row[DuLieu.gia].ToString().Trim();
            string soLuong = row[DuLieu.soLuong].ToString().Trim();
            string kichCo = row[DuLieu.kichCo].ToString().Trim();
            string ngayNhap = row[DuLieu.ngayNhap].ToString().Trim();
            string hang = row[DuLieu.hang].ToString().Trim();
            string tinhTrang = row[DuLieu.tinhTrang].ToString().Trim();


            ChucNangSanPham sua = new ChucNangSanPham(this, maSP, tenSP, gia, soLuong, kichCo, ngayNhap, hang, tinhTrang);
            sua.ShowDialog();
        }


        //ham sua 1 san phâm trong bang
        public void SuaMotSanPham(string maSP, string tenSP, string soLuong, string gia, string kichCo, string ngayNhap, string hang, string tinhTrang)
        {

            if (vt == -1) return;
            try
            {
                DataRow row = ds.Tables[tblSrcSanPham].Rows[vt];
                row.BeginEdit();
                row[DuLieu.maSP] = maSP;
                row[DuLieu.tenSP] = tenSP;
                row[DuLieu.soLuong] = soLuong;
                row[DuLieu.gia] = gia;
                row[DuLieu.kichCo] = kichCo;
                row[DuLieu.ngayNhap] = ngayNhap;
                row[DuLieu.hang] = hang;
                row[DuLieu.tinhTrang] = tinhTrang;
                row.EndEdit();

                int kq = adapter.Update(ds.Tables[tblSrcSanPham]);

                if (kq > 0)
                {
                    MessageBox.Show("sửa thành công");
                    HienThiDanhSachSanPham();

                    BatNutThem_Sua(false);
                }
                else
                {
                    MessageBox.Show("sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hiển thị ra lỗi " + ex.Message);
            }

        }



        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            DataRow row = ds.Tables[tblSrcSanPham].Rows[vt];
            DialogResult result = MessageBox.Show($"bạn muốn xóa san phẩm này có mã {row[DuLieu.maSP]}  và tên {row[DuLieu.tenSP]} này không", "hộp thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) XoaMotSanPham();
        }


        //hàm thực hiện xóa 1 cột được chọn
        void XoaMotSanPham()
        {
            if (vt == -1) return;
            try
            {
                DataRow row = ds.Tables[tblSrcSanPham].Rows[vt];
                row.Delete();
                int kq = adapter.Update(ds.Tables[tblSrcSanPham]);
                if (kq > 0)
                {
                    MessageBox.Show("Bạn xóa sản Phẩm này thành công!");
                    HienThiDanhSachSanPham();
                    BatNutThem_Sua(false);
                }
                else
                {
                    MessageBox.Show("bạn xóa sản Phẩm này không thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hiển thị ra lỗi " + ex.Message);
            }
        }




        private void btnSapXep_Click(object sender, EventArgs e)
        {
            switch (cbbSapXep.Text)
            {
                case "tên sản phẩm (A-Z)":
                    SapXepA_Z();
                    break;
                case "tên sản phẩm (Z-A)":
                    SapXepZ_A();
                    break;
                case "Số Lượng Tăng Dần":
                    SapXepSoLuongTang();
                    break;
                case "Số Lượng Giảm Dần":
                    SapXepSoLuongGiam();
                    break;
                case "ngày nhập gần nhất":
                    SapXepNgayNhapTang();
                    break;
                case "ngày nhập xa nhất":
                    SapXepNgayNhapGiam();
                    break;
                default:
                    MessageBox.Show("Chọn một phương thức sắp xếp hợp lệ.");
                    break;
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();// làm mới dữ liệu ở trong bảng
        }


        //ham sap xep tu a - z
        void SapXepA_Z()
        {
            MoKetNoi();

            query = "select *from tbl_SanPham order by TenSP asc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }

        //ham sap xep tu Z den a
        void SapXepZ_A()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham order by TenSP desc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }

        // sap xep so luong tang dan

        void SapXepSoLuongTang()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham order by CONVERT(int, SoLuong) asc";

            adapter = new SqlDataAdapter(query, sqlCon);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }

        // sap xep so luong giam dan
        void SapXepSoLuongGiam()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham order by CONVERT(int, SoLuong) desc";

            adapter = new SqlDataAdapter(query, sqlCon);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }


        void SapXepNgayNhapTang()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham order by NgayNhap asc";

            adapter = new SqlDataAdapter(query, sqlCon);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }

        // sap xep so luong giam dan
        void SapXepNgayNhapGiam()
        {
            MoKetNoi();

            query = "select * from tbl_SanPham order by NgayNhap desc";

            adapter = new SqlDataAdapter(query, sqlCon);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcSanPham);
            dgvDanhSachSanPham.DataSource = ds.Tables[tblSrcSanPham];
        }

        private void SanPham_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                MessageBox.Show("Hello, world!");
            }
        }
    }
}
