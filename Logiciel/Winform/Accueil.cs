using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_restauration
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            bunifuImageButton7.Visible = false;
            bunifuImageButton8.Visible = false;

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewOrder1_Load(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            newOrder1.Width = 0;
            bunifuGradientPanel1.Width = 1023;
            bunifuTextBox1.Width = 665;
            panel8.Location = new Point(708, 9);
            bunifuGradientPanel1.Location = new Point(84, 0);
            bunifuImageButton7.Visible = true;
            bunifuImageButton7.Location = new Point(987, 14);
            bunifuImageButton8.Visible = true;
            bunifuImageButton8.Location = new Point(954, 14);

            flowLayoutPanel1.Width = 717 + 300;
            flowLayoutPanel1.Location = new Point(90, 164);

            bunifuImageButton2.Image = null;
            bunifuImageButton2.Image = Properties.Resources.person_at_home_96px;
            panel3.BackColor = Color.White;
            label2.ForeColor = Color.FromArgb(101, 120, 249);
            bunifuSeparator2.Width = 654 + 380;
            bunifuSeparator2.Location = new Point(387 - 300, 156);
            if (panel2.BackColor == Color.White)
            {
                panel2.BackColor = Color.FromArgb(101, 120, 249);
                bunifuImageButton4.Image = Properties.Resources.food_480px;
                label4.ForeColor = Color.White;

            }
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            newOrder1.Width = 300;
            bunifuGradientPanel1.Width = 720;
            bunifuTextBox1.Width = 465;
            panel8.Location = new Point(508, 9);
            bunifuGradientPanel1.Location = new Point(387, 0);
            bunifuImageButton7.Visible = false;
            bunifuImageButton8.Visible = false;

            flowLayoutPanel1.Width = 717;
            flowLayoutPanel1.Location = new Point(387, 164);

            bunifuSeparator2.Width = 719;
            bunifuSeparator2.Location = new Point(387, 156);

            bunifuImageButton4.Image = null;
            bunifuImageButton4.Image = Properties.Resources.menu_480px;
            panel2.BackColor = Color.White;
            label4.ForeColor = Color.FromArgb(101, 120, 249);

            if (panel3.BackColor == Color.White)
            {
                panel3.BackColor = Color.FromArgb(101, 120, 249);
                bunifuImageButton2.Image = Properties.Resources.person_at_home_96px;
                label2.ForeColor = Color.White;

            }
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            Recapitulatif_commande recapitulatif_Commande = new Recapitulatif_commande();
            recapitulatif_Commande.Show();
        }
    }
}
