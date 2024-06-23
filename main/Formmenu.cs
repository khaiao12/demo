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
    public partial class Formmenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Formmenu()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.Colorlist.Count);
            while (tempIndex == index) { 
                index = random.Next(Themecolor.Colorlist.Count);
            }
            tempIndex = index;
            string color = Themecolor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }

        }

        private void OpenChildForm(Form Childform, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(Childform);
            this.panelDesktop.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
            lblTitle.Text = Childform.Text;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomer(), sender);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVoucher(), sender);
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDiamond(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetting(), sender);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.DodgerBlue;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            reset();
        }
    }
}
