using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_restauration
{
    public partial class NewOrder : UserControl
    {
        

        public NewOrder()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
            panel2.BackColor = Color.FromArgb(162, 172, 243);
            bunifuImageButton1.Image = null;

            bunifuImageButton1.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/coconut_cocktail_52px.png";

            if(panel4.BackColor == Color.FromArgb(162, 172, 243) || panel3.BackColor == Color.FromArgb(162, 172, 243))
            {
                if(panel4.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton2.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/need_for_speed.png";
                    panel4.BackColor = Color.White;
                    label4.ForeColor = Color.FromArgb(162, 172, 243);
                }
                else if(panel3.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton3.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/delivery_96px.png";
                    panel3.BackColor = Color.White;
                    label5.ForeColor = Color.FromArgb(162, 172, 243);
                }

            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuImageButton3.Image = null;
            panel3.BackColor = Color.FromArgb(162, 172, 243);
            label5.ForeColor = Color.White;
            bunifuImageButton3.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/delivery_filled_100px.png";

            if (panel4.BackColor == Color.FromArgb(162, 172, 243) || panel2.BackColor == Color.FromArgb(162, 172, 243))
            {
                if (panel4.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton2.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/need_for_speed.png";
                    panel4.BackColor = Color.White;
                    label4.ForeColor = Color.FromArgb(162, 172, 243);
                }
                else if (panel2.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton1.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/coconut_cocktail_96px.png";
                    panel2.BackColor = Color.White;
                    label3.ForeColor = Color.FromArgb(162, 172, 243);
                }

            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuImageButton2.Image = null;
            panel4.BackColor = Color.FromArgb(162, 172, 243);
            label4.ForeColor = Color.White;
            bunifuImageButton2.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/need_for_speed_96px.png";

            if (panel3.BackColor == Color.FromArgb(162, 172, 243) || panel2.BackColor == Color.FromArgb(162, 172, 243))
            {
                if (panel3.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton3.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/delivery_96px.png";
                    panel3.BackColor = Color.White;
                    label5.ForeColor = Color.FromArgb(162, 172, 243);
                }
                else if (panel2.BackColor == Color.FromArgb(162, 172, 243))
                {
                    bunifuImageButton1.ImageLocation = "D:/Bureau/Logiciel de restauration/Resources/coconut_cocktail_96px.png";
                    panel2.BackColor = Color.White;
                    label3.ForeColor = Color.FromArgb(162, 172, 243);
                }

            }
        }


        public void Delete1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
