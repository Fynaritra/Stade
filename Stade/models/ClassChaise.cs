using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ClassChaise
    {
        String id { get; set; }
        String zone { get; set; }
        public decimal position { get; set; }
        public decimal espacement { get; set; }
        public decimal longueur { get; set; }
        public decimal largeur { get; set; }
        public decimal coordonneeX { get; set; }
        public decimal coordonneeY { get; set; }
        public String idevent { get; set; }
        
        public void setId(String id)
        {
            this.id = id;
        }

        public Rectangle generateRectangle()
        {
            return new Rectangle((int)this.coordonneeX, (int)this.coordonneeY, (int)this.largeur, (int)this.longueur);
        }

        public ClassChaise() { }

        public ClassChaise(String id, String zone, decimal position, decimal espacement, decimal longueur, decimal largeur, decimal cooX, decimal cooY, String idevent)
        {
            this.id = id;
            this.zone = zone;
            this.position = position;
            this.espacement = espacement;
            this.longueur = longueur;
            this.largeur = largeur;
            this.coordonneeX = cooX;
            this.coordonneeY = cooY;
            this.idevent = idevent;
        }
    }
}
