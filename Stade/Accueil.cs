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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stade_Click(object sender, EventArgs e)
        {
            Stade stade = new Stade();
            stade.Show();
        }

        private void evenement_Click(object sender, EventArgs e)
        {
            Evenement evenement = new Evenement();
            evenement.Show();
        }

        private void zone_Click(object sender, EventArgs e)
        {
            Zone zone = new Zone();
            zone.Show();
        }


        private void recherche_Click(object sender, EventArgs e)
        {
            Courbe courbe = new Courbe();
            courbe.Show();
        }

        private void reserver_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
        }
    }
}
