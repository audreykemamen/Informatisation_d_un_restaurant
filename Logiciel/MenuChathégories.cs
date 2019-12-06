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
    public partial class MenuChathégories : UserControl
    {

        public MenuChathégories()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            ListeCommande listeCommande = new ListeCommande();
            NewOrder.flowLayoutPanel1.Controls.Add(listeCommande);
        }
    }
}
