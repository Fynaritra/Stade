using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.models
{
    class ClassAnalyse
    {
        DateTime date { get; set; }
        public decimal nombre { get; set; }
        public decimal total { get; set; }
        public List<ClassMedia> media { get; set; }
        public ClassAnalyse() { }
        public ClassAnalyse(DateTime date, decimal nombre, decimal total, List<ClassMedia> media)
        {
            this.date = date;
            this.nombre = nombre;
            this.total = total;
            this.media = media;
        }
        public float getPourcentage()
        {
            return float.Parse(((this.nombre / this.total)*100).ToString());
        }
        public float getValeur()
        {
            return float.Parse(this.nombre.ToString());
            //return 100 - getPourcentage();
        }
        public PointF generatePoint(float position, float posY)
        {
            PointF point = new PointF(position, posY);
            return point;
        }
    }
}
