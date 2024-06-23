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
    public partial class FormWatch : Form
    {
        public static string ID;
        public FormWatch()
        {
            InitializeComponent();
        }

        private void btnWatch1_Click(object sender, EventArgs e)
        {
            ID = "W01";
            new FormProInfor().Show();
        }

        private void btnWatch2_Click(object sender, EventArgs e)
        {
            ID = "W02";
            new FormProInfor().Show();
        }

        private void btnWatch3_Click(object sender, EventArgs e)
        {
            ID = "W03";
            new FormProInfor().Show();
        }

        private void btnWatch4_Click(object sender, EventArgs e)
        {
            ID = "W04";
            new FormProInfor().Show();
        }

        private void btnWatch5_Click(object sender, EventArgs e)
        {
            ID = "W05";
            new FormProInfor().Show();
        }

        private void btnWatch6_Click(object sender, EventArgs e)
        {
            ID = "W06";
            new FormProInfor().Show();
        }
    }
}
