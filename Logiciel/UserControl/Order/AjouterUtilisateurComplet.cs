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
    public partial class AjouterUtilisateurComplet : UserControl
    {
        public AjouterUtilisateurComplet()
        {
            InitializeComponent();
            
        }
        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            Recapitulatif_commande.recapitulatif_commande11.BringToFront();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
