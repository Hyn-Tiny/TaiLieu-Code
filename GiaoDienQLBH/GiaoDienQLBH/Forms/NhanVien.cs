using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GiaoDienQLBH.Forms
{
    public partial class NhanVien : Form
    {

        private SqlConnection sqlCon = null;

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private string query;
        int vt = -1;
        private static string tblSrcNhanVien = "tbl_NhanVien";

        //luong
        int ngay = 30;
        int luongNV = 700000;
        int luongQL = 1000000;
        int luongSep = 2000000;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();

            KiemtraQuyen();
        }


        //ham kiem tra va mo ket noi
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(DuLieu.strConn);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void HienThiDanhSachNhanVien()
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien";

            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcNhanVien);

            dgv_DanhSachNhanVien.DataSource = ds.Tables[tblSrcNhanVien];

        }

        private void dgv_DanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            
            DataRow row = ds.Tables[tblSrcNhanVien].Rows[vt];

            txt_MaLuongNV.Text = row[0].ToString().Trim();

            int luong = Convert.ToInt32(row[7].ToString().Trim());
            float soNgayLam = 0;

            switch (row[6].ToString().Trim())
            {
                case "Nhân Viên":
                    soNgayLam = luong / TinhLuongMotNgay(luongNV);
                    break;

                case "Quản Lý":
                    soNgayLam = luong / TinhLuongMotNgay(luongQL);
                    break;
                case "Sếp":
                    soNgayLam = luong / TinhLuongMotNgay(luongSep);
                    break;
            }

            txt_ChatLuong.Text = soNgayLam < ngay ?"Không Đủ ngày":"Đử ngày";

            txt_LuongNV.Text = soNgayLam.ToString();


            if (string.Compare(FormManager.Instance.Quyen, "Quản Lý", true) == 0)
            {
                BatNutThem_Sua(true);
            }
        }


        float TinhLuongMotNgay(int luong)
        {
            return luong/ngay;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            FormManager.Instance.ChucNang = 3;

            if (vt == -1) return;

            DataRow row = ds.Tables[tblSrcNhanVien].Rows[vt];


            string maNV = row[DuLieu.maNV].ToString().Trim();
            string tenNV = row[DuLieu.tenNV].ToString().Trim();
            string ngaySinh = row[DuLieu.ngaySinh].ToString().Trim();
            string SDT = row[DuLieu.SDT].ToString().Trim();
            string Email = row[DuLieu.Email].ToString().Trim();
            string queQuan = row[DuLieu.queQuan].ToString().Trim();
            string chucVu = row[DuLieu.chucVu].ToString().Trim();
            string luong = row[DuLieu.luong].ToString().Trim();


            ChucNangNhanVien sua = new ChucNangNhanVien(this, maNV, tenNV, ngaySinh, SDT, Email, queQuan, chucVu, luong);
            sua.ShowDialog();
        }

        //ham sua mot nhân vien
        public void SuaMotNhanVien(string maNV, string tenNV, string ngaySinh, string SDT, string Email, string queQuan, string chucVu, string luong)
        {

            if (vt == -1) return;
            try
            {
                DataRow row = ds.Tables[tblSrcNhanVien].Rows[vt];
                row.BeginEdit();
                row[DuLieu.maNV] = maNV;
                row[DuLieu.tenNV] = tenNV;
                row[DuLieu.ngaySinh] = ngaySinh;
                row[DuLieu.SDT] = SDT;
                row[DuLieu.Email] = Email;
                row[DuLieu.queQuan] = queQuan;
                row[DuLieu.chucVu] = chucVu;
                row[DuLieu.luong] = luong;
                row.EndEdit();

                int kq = adapter.Update(ds.Tables[tblSrcNhanVien]);

                if (kq > 0)
                {
                    MessageBox.Show("sửa nhân viên thành công");
                    HienThiDanhSachNhanVien();
                    BatNutThem_Sua(false);
                }
                else
                {
                    MessageBox.Show("sửa nhân viên không thành công");
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
            DataRow row = ds.Tables[tblSrcNhanVien].Rows[vt];
            DialogResult result = MessageBox.Show($"bạn muốn xoa san phẩm này có mã {row[DuLieu.maNV]}  và tên {row[DuLieu.tenNV]} này không", "hộp thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) XoaMotNhanVien();
        }


        //hàm thực hiện xóa 1 cột được chọn
        void XoaMotNhanVien()
        {

            if (vt == -1) return;
            try
            {
                DataRow row = ds.Tables[tblSrcNhanVien].Rows[vt];
                row.Delete();
                int kq = adapter.Update(ds.Tables[tblSrcNhanVien]);
                if (kq > 0)
                {
                    MessageBox.Show("Bạn xóa nhân viên này thành công!");
                    HienThiDanhSachNhanVien();
                    BatNutThem_Sua(false);
                }
                else
                {
                    MessageBox.Show("bạn xóa nhân viên này không thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hiển thị ra lỗi " + ex.Message);
            }
        }

        //ham kiem tra quyen
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

        // bật cac nút  
        public void BatNutThem_Sua(bool daBat)
        {
            btnSuaNV.Enabled = daBat;
            btnXoaNV.Enabled = daBat;
        }
        void BatTatCaNut(bool daBat)
        {
            BatNutThem_Sua(daBat);
            btnThemNV.Enabled = daBat;
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            string maTK = txtTKMaNV.Text.Trim();
            string tenTK = txtTKTenNV.Text.Trim();

            if (maTK != " " && tenTK == "")
            { TimKiemBangMa(maTK); }

            else if (maTK == "" && tenTK != "")
            { TimKiemBangTen(tenTK); }

            else if (maTK != "" && tenTK != "")
            { TimKiemBangMa(maTK); }

            else
            {
                MessageBox.Show("bạn chưa nhập gì ,bạn hãy nhập ở đây");
                txtTKMaNV.Focus();
            }
        }

        //ham thuc hien tim kiem bang ma
        private void TimKiemBangMa(string maNV)
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien where MaNV ='" + maNV + "'";
            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "tblTimKiemMa");
            dgv_DanhSachNhanVien.DataSource = ds.Tables["tblTimKiemMa"];

        }

        //ham thuc hien tim kiem bang ten
        private void TimKiemBangTen(string tenNV)
        {
            MoKetNoi();
            query = "select * from tbl_NhanVien where TenNV like'%" + tenNV + "%'";
            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "tblTimKiemTen");
            dgv_DanhSachNhanVien.DataSource = ds.Tables["tblTimKiemTen"];
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            FormManager.Instance.ChucNang = 4;

            ChucNangNhanVien them = new ChucNangNhanVien(this);
            them.ShowDialog();
        }


        //them mot nhan vien
        public void ThemMotNV(string maNV, string tenNV, string ngaySinh, string SDT, string Email, string queQuan, string chucVu, string luong)
        {
            try
            {
                DataRow row = ds.Tables[tblSrcNhanVien].NewRow();
                // MessageBox.Show($"hien thi ra {}");
                row[DuLieu.maNV] = maNV;
                row[DuLieu.tenNV] = tenNV;
                row[DuLieu.ngaySinh] = ngaySinh;
                row[DuLieu.SDT] = SDT;
                row[DuLieu.Email] = Email;
                row[DuLieu.queQuan] = queQuan;
                row[DuLieu.chucVu] = chucVu;
                row[DuLieu.luong] = luong;
                ds.Tables[tblSrcNhanVien].Rows.Add(row);

                int kq = adapter.Update(ds.Tables[tblSrcNhanVien]);
                if (kq > 0)
                {
                    MessageBox.Show("bạn thêm thành công");
                    HienThiDanhSachNhanVien();

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

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();// câp lại danh sach
        }


        //thcu cac loại săp xếp theo yeu cầu
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
                case "Lươnng Tăng Dần":
                    SapXepLuongTang();
                    break;
                case "Lương Giảm Dần":
                    SapXepLuongGiam();
                    break;
                default:
                    MessageBox.Show("Chọn một phương thức sắp xếp hợp lệ.");
                    break;
            }
        }

        private void SapXepLuongTang()
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien order by Luong desc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcNhanVien);
            dgv_DanhSachNhanVien.DataSource = ds.Tables[tblSrcNhanVien];
        }

        private void SapXepLuongGiam()
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien order by Luong asc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcNhanVien);
            dgv_DanhSachNhanVien.DataSource = ds.Tables[tblSrcNhanVien];
        }

        private void SapXepZ_A()
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien order by TenNV desc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcNhanVien);
            dgv_DanhSachNhanVien.DataSource = ds.Tables[tblSrcNhanVien];
        }

        private void SapXepA_Z()
        {
            MoKetNoi();

            query = "select * from tbl_NhanVien order by TenNV asc";

            adapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, tblSrcNhanVien);
            dgv_DanhSachNhanVien.DataSource = ds.Tables[tblSrcNhanVien];
        }
    }
}
