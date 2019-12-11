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
    public partial class Delete : UserControl
    {

        public Delete()
        {
            InitializeComponent();
        }

     


        public void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            NewOrder.flowLayoutPanel1.Controls.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
