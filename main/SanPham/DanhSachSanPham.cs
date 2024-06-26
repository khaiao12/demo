using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class DanhSachSanPham
    {
        private static DanhSachSanPham instance;

        List<SanPham> listProduct;

        
        public static DanhSachSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachSanPham();
                return instance;
            }
            set => instance = value;
        }

        public List<SanPham> ListProduct
        {
            get => listProduct;
            set => listProduct = value;
        }

        DanhSachSanPham()
        {
            ListProduct = new List<SanPham>();
            ListProduct.Add(new SanPham("Nhẫn 1", 2999, "R01", "Kim cương chính 1 carat", "Kim cương phụ 0.5 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Nhẫn 2", 3999, "R02", "Kim cương chính 1.5 carat", "Kim cương phụ 0.8 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Nhẫn 3", 4999, "R03", "Kim cương chính 2 carat", "Kim cương phụ 1 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Nhẫn 4", 5999, "R04", "Kim cương chính 2.5 carat", "Kim cương phụ 1.2 carat", "Vỏ vàng và bạc mix"));
            ListProduct.Add(new SanPham("Nhẫn 5", 6999, "R05", "Kim cương chính 3 carat", "Kim cương phụ 1.5 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Nhẫn 6", 7999, "R06", "Kim cương chính 4 carat", "Kim cương phụ 2 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Vòng tay 1", 3999, "V01", "Kim cương chính 1.2 carat", "Kim cương phụ 0.6 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Vòng tay 2", 4999, "V02", "Kim cương chính 1.8 carat", "Kim cương phụ 0.9 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Vòng tay 3", 5999, "V03", "Kim cương chính 2.2 carat", "Kim cương phụ 1.1 carat", "Vỏ vàng và bạc mix"));
            ListProduct.Add(new SanPham("Vòng tay 4", 6999, "V04", "Kim cương chính 2.8 carat", "Kim cương phụ 1.4 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Vòng tay 5", 7999, "V05", "Kim cương chính 3.5 carat", "Kim cương phụ 1.7 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Vòng tay 6", 8999, "V06", "Kim cương chính 4 carat", "Kim cương phụ 2 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Dây chuyền 1", 2999, "D01", "Kim cương chính 1.2 carat", "Kim cương phụ 0.6 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Dây chuyền 2", 3999, "D02", "Kim cương chính 1.8 carat", "Kim cương phụ 0.9 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Dây chuyền 3", 4999, "D03", "Kim cương chính 2.2 carat", "Kim cương phụ 1.1 carat", "Vỏ vàng và bạc mix"));
            ListProduct.Add(new SanPham("Dây chuyền 4", 5999, "D04", "Kim cương chính 2.8 carat", "Kim cương phụ 1.4 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Dây chuyền 5", 6999, "D05", "Kim cương chính 3.5 carat", "Kim cương phụ 1.7 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Dây chuyền 6", 7999, "D06", "Kim cương chính 4 carat", "Kim cương phụ 2 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Hoa tai 1", 2999, "H01", "Kim cương chính 1.2 carat", "Kim cương phụ 0.6 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Hoa tai 2", 3999, "H02", "Kim cương chính 1.8 carat", "Kim cương phụ 0.9 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Hoa tai 3", 3999, "H03", "Kim cương chính 2.2 carat", "Kim cương phụ 1.1 carat", "Vỏ vàng và bạc mix"));
            ListProduct.Add(new SanPham("Hoa tai 4", 4999, "H04", "Kim cương chính 2.8 carat", "Kim cương phụ 1.4 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Hoa tai 5", 5999, "H05", "Kim cương chính 3.5 carat", "Kim cương phụ 1.7 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Hoa tai 6", 5999, "H06", "Kim cương chính 4 carat", "Kim cương phụ 2 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Đồng hồ 1", 9999, "W01", "Kim cương chính 1 carat", "Kim cương phụ 0.5 carat", "Vỏ vàng trắng 18K"));
            ListProduct.Add(new SanPham("Đồng hồ 2", 10999, "W02", "Kim cương chính 1.5 carat", "Kim cương phụ 0.8 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Đồng hồ 3", 8999, "W03", "Kim cương chính 2 carat", "Kim cương phụ 1 carat", "Vỏ bạc sterling và rhodium"));
            ListProduct.Add(new SanPham("Đồng hồ 4", 9999, "W04", "Kim cương chính 2.5 carat", "Kim cương phụ 1.2 carat", "Vỏ vàng và bạc mix"));
            ListProduct.Add(new SanPham("Đồng hồ 5", 12999, "W05", "Kim cương chính 3 carat", "Kim cương phụ 1.5 carat", "Vỏ vàng hồng 18K"));
            ListProduct.Add(new SanPham("Đồng hồ 6", 7999, "W06", "Kim cương chính 4 carat", "Kim cương phụ 2 carat", "Vỏ vàng trắng 18K"));
        }
    }
}
