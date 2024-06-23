using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class FormCustomer : Form
    {
        List<TaiKhoan> listTK = DanhSach.Instance.ListTaiKhoan;
        
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listTK.Count; i++)
            {
                if(FormLogin.TK == listTK[i].UserName)
                {
                    lblMoney.Text = "" + listTK[i].Cash;
                    lblACC.Text = "@" + listTK[i].UserName;
                }
            }
        }
    }
}
