using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Forms
{
    public partial class FormProInfor : Form
    {
        List<SanPham> listSanPham = DanhSachSanPham.Instance.ListProduct;
        List<TaiKhoan> listTaiKhoan = DanhSach.Instance.ListTaiKhoan;
        private string ID;
        private int Price;
        public FormProInfor()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listSanPham.Count; i++)
            {
                if (FormRing.ID == listSanPham[i].ProductID)
                {
                    lblPrice.Text = "" + listSanPham[i].ProductPrice;
                    lblMaindia.Text = listSanPham[i].Kimcuongchinh;
                    lblSidedia.Text = listSanPham[i].Kimcuongphu;
                    lblDiaCover.Text = listSanPham[i].Vokimcuong;
                    ID = FormRing.ID;
                    FormRing.ID = null;
                }
                else if (FormBracelet.ID == listSanPham[i].ProductID)
                {
                    lblPrice.Text = "" + listSanPham[i].ProductPrice;
                    lblMaindia.Text = listSanPham[i].Kimcuongchinh;
                    lblSidedia.Text = listSanPham[i].Kimcuongphu;
                    lblDiaCover.Text = listSanPham[i].Vokimcuong;
                    ID = FormBracelet.ID;
                    FormBracelet.ID = null;
                }
                else if (FormNecklace.ID == listSanPham[i].ProductID)
                {
                    lblPrice.Text = "" + listSanPham[i].ProductPrice;
                    lblMaindia.Text = listSanPham[i].Kimcuongchinh;
                    lblSidedia.Text = listSanPham[i].Kimcuongphu;
                    lblDiaCover.Text = listSanPham[i].Vokimcuong;
                    ID = FormBracelet.ID;
                    FormNecklace.ID = null;
                }
                else if (FormEarrings.ID == listSanPham[i].ProductID)
                {
                    lblPrice.Text = "" + listSanPham[i].ProductPrice;
                    lblMaindia.Text = listSanPham[i].Kimcuongchinh;
                    lblSidedia.Text = listSanPham[i].Kimcuongphu;
                    lblDiaCover.Text = listSanPham[i].Vokimcuong;
                    ID = FormEarrings.ID;
                    FormEarrings.ID = null;
                }
                else if (FormWatch.ID == listSanPham[i].ProductID)
                {
                    lblPrice.Text = "" + listSanPham[i].ProductPrice;
                    lblMaindia.Text = listSanPham[i].Kimcuongchinh;
                    lblSidedia.Text = listSanPham[i].Kimcuongphu;
                    lblDiaCover.Text = listSanPham[i].Vokimcuong;
                    ID = FormWatch.ID;
                    FormWatch.ID = null;
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listSanPham.Count; i++)
            {
                if (ID == listSanPham[i].ProductID)
                    Price = listSanPham[i].ProductPrice;
            }
            for (int i = 0;i < listTaiKhoan.Count; i++)
            {
                if(FormLogin.TK == listTaiKhoan[i].UserName)
                {
                    if (listTaiKhoan[i].Cash < Price)
                    {
                        MessageBox.Show("Tài khoản không đủ để thanh toán đơn hàng. Xin quý khách vui lòng kiểm tra lại");
                    }
                    else
                    {
                        listTaiKhoan[i].Cash -= Price;
                        MessageBox.Show("Mua hàng thành công!!!!!!");
                    }
                }
            }            
            this.Close();
        }
    }
}
