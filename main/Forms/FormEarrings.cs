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
    public partial class FormEarrings : Form
    {
        public static string ID;
        public FormEarrings()
        {
            InitializeComponent();
        }

        private void btnEarrings1_Click(object sender, EventArgs e)
        {
            ID = "H01";
            new FormProInfor().Show();
        }

        private void btnEarrings2_Click(object sender, EventArgs e)
        {
            ID = "H02";
            new FormProInfor().Show();
        }

        private void btnEarrings3_Click(object sender, EventArgs e)
        {
            ID = "H03";
            new FormProInfor().Show();
        }

        private void btnEarrings4_Click(object sender, EventArgs e)
        {
            ID = "H04";
            new FormProInfor().Show();
        }

        private void btnEarrings5_Click(object sender, EventArgs e)
        {
            ID = "H05";
            new FormProInfor().Show();
        }

        private void btnEarrings6_Click(object sender, EventArgs e)
        {
            ID = "H06";
            new FormProInfor().Show();
        }
    }
}
