using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.models
{
    class ClassReservation
    {
        public String id { get; set; }
        public String nom { get; set; }
        public decimal lieu { get; set; }
        String idevent { get; set; }
        decimal prixunitaire { get; set; }
        public DateTime datereservation { get; set; }
        String idzone { get; set; }

        public ClassReservation(String idEvent, decimal position, String nom, decimal pu, DateTime date, String idzone)
        {
            this.lieu = position;
            this.idevent = idEvent;
            this.nom = nom;
            this.prixunitaire = pu;
            this.datereservation = date;
            this.idzone = idzone;
        }
        public ClassReservation()
        {
            
        }


    }
}
