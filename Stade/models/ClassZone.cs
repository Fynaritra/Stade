using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ClassZone : ClassEvenement
    {
        public decimal prixunitaire { get; set; }
        public decimal remplissage { get; set; }
        public decimal estimation { get; set; }
        public ClassZone()
        {

        }
       
        public ClassZone(String lieu, String nom, String id, String coordinates, decimal pu, decimal simulation, decimal remplissage)
        {
            this.id = id;
            this.lieu = lieu;
            this.nom = nom;
            this.coordinates = coordinates;
            this.prixunitaire = pu;
            this.estimation = simulation;
            //this.remplissage = remplissage;
        }
    }
}
