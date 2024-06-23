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
    public partial class FormBracelet : Form
    {
        public static string ID;
        public FormBracelet()
        {
            InitializeComponent();
        }

        private void btnBracelet1_Click(object sender, EventArgs e)
        {
            ID = "V01";
            new FormProInfor().Show();
        }

        private void btnBracelet2_Click(object sender, EventArgs e)
        {
            ID = "V02";
            new FormProInfor().Show();
        }

        private void btnBracelet3_Click(object sender, EventArgs e)
        {
            ID = "V03";
            new FormProInfor().Show();
        }

        private void btnBracelet4_Click(object sender, EventArgs e)
        {
            ID = "V04";
            new FormProInfor().Show();
        }

        private void btnBracelet5_Click(object sender, EventArgs e)
        {
            ID = "V05";
            new FormProInfor().Show();
        }

        private void btnBracelet6_Click(object sender, EventArgs e)
        {
            ID = "V06";
            new FormProInfor().Show();
        }
    }
}
