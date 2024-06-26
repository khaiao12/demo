using main.Forms;
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
    public partial class FormDiamond : Form
    {
        public FormDiamond()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormBangGiaKCNT().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormBangGiaKCTN().Show();
        }
    }
}
