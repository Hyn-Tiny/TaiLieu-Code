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
    public partial class ChucNangSanPham : Form
    {

        private SanPham sanPham;


        public ChucNangSanPham()
        {
            InitializeComponent();
        }
        public ChucNangSanPham(SanPham sanPham)
        {
            InitializeComponent();
            this.sanPham = sanPham;

        }

        public ChucNangSanPham(SanPham sanPham, string maSP, string tenSP, string gia, string soLuong, string kichCo, string ngayNhap, string hang, string tinhTrang)
        {

            InitializeComponent();

            this.sanPham = sanPham;

            txt_CNSP_MaSP.Text = maSP;
            txt_CNSP_TenSP.Text = tenSP;
            txt_CNSP_SoLuong.Text = soLuong;
            txt_CNSP_GiaTien.Text = gia;
            cbb_CNSP_KichThuoc.Text = kichCo;
            dtp_CNSP_NgayNhap.Text = ngayNhap;
            txt_CNSP_Hang.Text = hang;
            cbb_CNSP_TinhTrang.Text = tinhTrang;
        }

        private void btn_CNSP_Luu_Click(object sender, EventArgs e)
        {
            string maSP = txt_CNSP_MaSP.Text;
            string tenSP = txt_CNSP_TenSP.Text;
            string soLuong = txt_CNSP_SoLuong.Text;
            string gia = txt_CNSP_GiaTien.Text;
            string kichCo = cbb_CNSP_KichThuoc.Text;
            string ngayNhap = dtp_CNSP_NgayNhap.Text;
            string hang = txt_CNSP_Hang.Text;
            string tinhTrang = cbb_CNSP_TinhTrang.Text;



            if (FormManager.Instance.ChucNang == 0)
            {

                if (maSP == "" || tenSP == "" || soLuong == "" || gia == "" || hang == "")
                {
                    MessageBox.Show("bạn chua nhập gì,bạn hãy nhập đi");
                    return;
                }

                this.sanPham.ThemVaoBang(maSP, tenSP, soLuong, gia, kichCo, ngayNhap, hang, tinhTrang);
            }

            else if (FormManager.Instance.ChucNang == 1)
            {
                this.sanPham.SuaMotSanPham(maSP, tenSP, soLuong, gia, kichCo, ngayNhap, hang, tinhTrang);

            }

            this.Close();
        }

        private void btn_CNSP_Huy_Click(object sender, EventArgs e)
        {
            this.Close();

            this.sanPham.BatNutThem_Sua(false);

        }




    }

}
