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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormAccept().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormBaoHanh().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormChungNhan().Show();
        }
    }
}
