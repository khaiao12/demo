using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Forms
{
    public partial class FormRing : Form
    {
        public static string ID;
        public FormRing()
        {
            InitializeComponent();
        }

        private void btnRing1_Click(object sender, EventArgs e)
        {
            ID = "R01";
            new FormProInfor().Show();
        }

        private void btnRing2_Click(object sender, EventArgs e)
        {
            ID = "R02";
            new FormProInfor().Show();
        }

        private void btnRing3_Click(object sender, EventArgs e)
        {
            ID = "R03";
            new FormProInfor().Show();
        }

        private void btnRing4_Click(object sender, EventArgs e)
        {
            ID = "R04";
            new FormProInfor().Show();
        }

        private void btnRing5_Click(object sender, EventArgs e)
        {
            ID = "R05";
            new FormProInfor().Show();
        }

        private void btnRing6_Click(object sender, EventArgs e)
        {
            ID = "R06";
            new FormProInfor().Show();
        }
    }
}
