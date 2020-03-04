using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.models
{
    class ClassMedia
    {
        int id { get; set; }
        String idevent { get; set; }
        public String media { get; set; }
        decimal cout { get; set; }
        public float pourcentage { get; set; }
        public DateTime datemedia { get; set; }
        public String nom { get; set; }
        public ClassMedia(){ }
        public ClassMedia(String media, float pourcentage, String nom)
        {
            this.media = media;
            this.pourcentage = pourcentage;
            this.nom = nom;
        }

    }
}
