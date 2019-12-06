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
    public partial class Recapitulatif_commande1 : UserControl
    {
        public Recapitulatif_commande1()
        {
            InitializeComponent();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            Recapitulatif_commande.ajouterUtilisateurComplet1.BringToFront();
        }
    }
}
