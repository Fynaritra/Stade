using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ClassLieu
    {
        public String id { get; set; }
        public String nom { get; set; }
        public String lieu { get; set; }

        public ClassLieu() { }
        public ClassLieu(String nom, String lieu)
        {
            this.nom = nom;
            this.lieu = lieu;
        }

    }
}
