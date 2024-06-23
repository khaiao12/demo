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
    public partial class FormNecklace : Form
    {
        public static string ID;
        public FormNecklace()
        {
            InitializeComponent();
        }

        private void btnNecklace1_Click(object sender, EventArgs e)
        {
            ID = "D01";
            new FormProInfor().Show();
        }

        private void btnNecklace2_Click(object sender, EventArgs e)
        {
            ID = "D02";
            new FormProInfor().Show();
        }

        private void btnNecklace3_Click(object sender, EventArgs e)
        {
            ID = "D03";
            new FormProInfor().Show();
        }

        private void btnNecklace4_Click(object sender, EventArgs e)
        {
            ID = "D04";
            new FormProInfor().Show();
        }

        private void btnNecklace5_Click(object sender, EventArgs e)
        {
            ID = "D05";
            new FormProInfor().Show();
        }

        private void btnNecklace6_Click(object sender, EventArgs e)
        {
            ID = "D06";
            new FormProInfor().Show();
        }
    }
}
