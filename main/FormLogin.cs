using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class FormLogin : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSach.Instance.ListTaiKhoan;
        List<TaiKhoan> admin = DanhSach.Instance.ListAdmin;
        public static string TK;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginCheck(txtUsername.Text, txtPassword.Text))
            {                
                new Formmenu().Show();                
                this.Hide();
            }
            else if (adminCheck(txtUsername.Text,txtPassword.Text) && chkAdmin.CheckState == CheckState.Checked)
            {
                new FormMenuAdmin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect, please try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            
        }

        bool loginCheck(string username, string password) 
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (txtUsername.Text == listTaiKhoan[i].UserName && txtPassword.Text == listTaiKhoan[i].Password)
                {
                    TK = listTaiKhoan [i].UserName;
                    return true;
                }
            }
            return false;
        }

        bool adminCheck(string username, string password)
        {
            for (int i = 0; i < admin.Count; i++)
            {
                if (txtUsername.Text == admin[i].UserName && txtPassword.Text == admin[i].Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
