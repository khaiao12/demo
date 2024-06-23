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
    public partial class FormProduct : Form
    {

        private Form activeForm;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form Childform, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            this.panelProduct.Controls.Add(Childform);
            this.panelProduct.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRing(), sender);
        }

        private void btnEarrings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEarrings(), sender);
        }

        private void btnBracelet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBracelet(), sender);
        }

        private void btnNecklace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNecklace(), sender);
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWatch(), sender);
        }
    }
}
