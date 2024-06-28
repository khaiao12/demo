using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class DanhSach
    {
        private static DanhSach instance; 

        List<TaiKhoan> listTaiKhoan;
        List<TaiKhoan> listAdmin;

        public static DanhSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSach();
                return instance;
            }
            set => instance = value;
        }
        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }
        public List<TaiKhoan> ListAdmin
        {
            get => listAdmin;
            set => listAdmin = value;
        }

        DanhSach()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("Demo", "4321", 59123131));
            listTaiKhoan.Add(new TaiKhoan("Demo1", "1212", 12698232));
            listTaiKhoan.Add(new TaiKhoan("Demo2", "1111", 3212313));
            listTaiKhoan.Add(new TaiKhoan("Demo3", "1234", 2131));
            listAdmin = new List<TaiKhoan>();
            listAdmin.Add(new TaiKhoan("Admin", "2222", 1));
        }
    }
}
