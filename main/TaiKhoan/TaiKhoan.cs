using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class TaiKhoan
    {
        private string userName;

        public string UserName
        { 
            get => userName;
            set => userName = value;
        }

        private string password;

        public string Password
        {
            get => password;
            set => password = value;
        }

        private int cash;

        public int Cash
        {
            get => cash;
            set => cash = value;
        }

        public TaiKhoan(string userName, string password, int cash)
        {
            this.UserName = userName;
            this.Password = password;
            this.Cash = cash;
        }
    }
}
