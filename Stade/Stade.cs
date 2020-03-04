using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stade
{
    public partial class Stade : Form
    {
        public Stade()
        {
            InitializeComponent();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            ServiceLieu servLieu = new ServiceLieu();
            string nom = nomstade.Text;
            string lieu = lieustade.Text;
            servLieu.addLieu(nom, lieu);
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }
    }
}
