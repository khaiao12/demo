using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class SanPham
    {
        private string productName;

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        private int productPrice;

        public int ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        private string productID;

        public string ProductID
        {
            get => productID;
            set => productID = value;
        }

        private string kimcuongchinh;

        public string Kimcuongchinh
        {
            get => kimcuongchinh;
            set => kimcuongchinh = value;
        }

        private string kimcuongphu;

        public string Kimcuongphu
        {
            get => kimcuongphu;
            set => kimcuongphu = value;
        }

        private string vokimcuong;

        public string Vokimcuong
        {
            get => vokimcuong;
            set => vokimcuong = value;
        }

        public SanPham (string productName, int productPrice, string productID,string kimcuongchinh, string kimcuongphu, string vokimcuong)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductID = productID;
            this.Kimcuongchinh = kimcuongchinh;
            this.Kimcuongphu = kimcuongphu;
            this.Vokimcuong = vokimcuong;
        }
    }
}
