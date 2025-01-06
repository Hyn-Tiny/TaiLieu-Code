using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDienQLBH.Forms
{
    public class FormManager
    {
        private static FormManager instance;
        public static FormManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormManager();
                return instance;
            }
        }

        private int chucNang;
        public int ChucNang { get { return chucNang; } set { chucNang = value; } }

        private string tenDangNhap;

        public string TenDangNhap { get { return tenDangNhap; } set { tenDangNhap = value; } }

        private string quyen;
        public string Quyen { get => quyen; set => quyen= value; }  
    }
}
