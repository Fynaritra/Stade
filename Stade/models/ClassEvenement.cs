using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ClassEvenement
    {
        public String id { get; set; }
        public String lieu { get; set; }
        public String nom { get; set; }
        public DateTime date { get; set; }
        public String coordinates { get; set; }

        public ClassEvenement()
        {

        }
        public ClassEvenement(String nom, String lieu, String id, DateTime date, String coordinates)
        {
            this.nom = nom;
            this.lieu = lieu;
            this.id = id;
            this.date = date;
            this.coordinates = coordinates;
        }
        public List<PointF> getPoints()
        {
            ServicePaint servPaint = new ServicePaint();
            return servPaint.generatePoints(this.coordinates);
        }
    }
}
