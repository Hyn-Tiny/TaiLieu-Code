using GiaoDienQLBH.Forms;
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

namespace GiaoDienQLBH
{
    public partial class TrangChu : Form
    {
       

        private Form currentForm;
        public TrangChu()
        {
            InitializeComponent();
        }
        
        private void TrangChu_Load(object sender, EventArgs e)
        {
            libl_TC_TenDangNhap.Text = FormManager.Instance.TenDangNhap;
        }


        //ham kiem tra de mơ form các form con
        private void OpenForm(Form children)
        {
            if (currentForm != null) currentForm.Close();

            currentForm = children;

            children.TopLevel = false;
            children.FormBorderStyle = FormBorderStyle.None;

            children.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(children);
            pnlBody.Tag = children;
            children.BringToFront();
            children.Show();

        }

        private void pib_TC_TrangChu_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
        }

        private void btn_TC_TrangChu_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
        }
        private void btn_TC_SanPham_Click(object sender, EventArgs e)
        {
            OpenForm(new SanPham());
        }

        private void btn_TC_NhanVien_Click(object sender, EventArgs e)
        {
            OpenForm(new NhanVien());
        }

        private void btn_TC_HoTro_Click(object sender, EventArgs e)
        {
            OpenForm(new HoTro());
        }

        private void btn_TC_ThongKe_Click(object sender, EventArgs e)
        {
            OpenForm(new ThongKe());
        }

        // ham sang form dang nhap
        void ChangeForm()
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();

            this.Hide();
        }

        private void lilb_TC_Thoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThoatChuongTrinh();
        }


        //ham thoát chương trình
        private void ThoatChuongTrinh()
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình này không?", "Hộp Thoại Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) Close();
        }

        //ham dang xuat bảng anh
        private void pib_TC_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này không?", "Hộp Thoại Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)ChangeForm();
        }

        //ham dang xuat bang tên người su dung
        private void libl_TC_TenDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này không?", "Hộp Thoại Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) ChangeForm();
        }

    }
}
