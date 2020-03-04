using Stade.models;
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
    public partial class Courbe : Form
    {
        List<PointF> points = new List<PointF>();
        PaintEventArgs paintEvent;
        public Courbe()
        {
            InitializeComponent();
        }

        private void drawRepere()
        {
            Graphics g = this.paintGraphe.CreateGraphics();
            int longueur = this.paintGraphe.Height - 25;
            int largeur = this.paintGraphe.Width - 20;
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, longueur));
            g.DrawLine(Pens.Black, new Point(0, longueur), new Point(largeur, longueur));
        }
        private void paintGraphe_Paint(object sender, PaintEventArgs e)
        {
            this.paintEvent = e;
            Pen penCurrent = new Pen(Color.Blue);
            Graphics g = e.Graphics;
            PointF[] pf = this.points.ToArray<PointF>();
            if (pf.Length > 0)
            {
                g.DrawCurve(penCurrent, pf, 0);
            }
        }

        private void voir_Click(object sender, EventArgs e)
        {
            Pen penCurrent = new Pen(Color.Blue);
            float baseY = this.paintGraphe.Height - 40;
            String idevent = evenements.SelectedValue.ToString();
            ServiceEvenement service = new ServiceEvenement();
            List<ClassAnalyse> analyses = service.getDailyReservations(idevent);
            List<ClassMedia> classement = service.getClassement(analyses);
            int i = 0, size = analyses.Count, j=0, sizeClass = classement.Count;
            float position = 10;
            tableau.Rows.Clear();
            tableau.ColumnCount = 2;
            tableau.Columns[0].Name = "Media";
            tableau.Columns[1].Name = "Pourcentage";

            for (j=0; j<sizeClass; j++)
            {
                String[] row = { classement[j].nom, ""+classement[j].pourcentage };
                tableau.Rows.Add(row);
            }

            this.drawRepere();
            decimal nombre = 0;
            for(i=0; i<size; i++)
            {
                if (i > 0)
                {
                    analyses.ElementAt(i).nombre = analyses.ElementAt(i).nombre + analyses.ElementAt(i - 1).nombre;
                    nombre = analyses.ElementAt(i).nombre;
                    MessageBox.Show(""+analyses.ElementAt(i).nombre);
                }
                PointF point = analyses.ElementAt(i).generatePoint(position, baseY- float.Parse(nombre.ToString()));
                points.Add(point);
                position += 35;
            }
            position = 0;
            Graphics g = this.paintGraphe.CreateGraphics();
            Font myFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            PointF[] pf = this.points.ToArray<PointF>();
            if (pf.Length > 0)
            {
                g.DrawCurve(penCurrent, pf, 0);
                for(i=0; i<pf.Length; i++)
                {
                    g.DrawString(analyses.ElementAt(i).getPourcentage().ToString(), myFont, Brushes.Blue, pf[i]);
                }
                for(i=0; i<size; i++)
                {
                    List<ClassMedia> mediasAnalyse = analyses.ElementAt(i).media;
                    for(j=0; j<mediasAnalyse.Count; j++)
                    {
                        g.DrawString(mediasAnalyse.ElementAt(j).media, myFont, Brushes.Black, new PointF(position, this.paintGraphe.Height - 20));
                        position += 50;
                    }
                }
            }
        }

        private void Courbe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evenementdbDataSet.Media' table. You can move, or remove it, as needed.
            this.mediaTableAdapter.Fill(this.evenementdbDataSet.Media);
            ServiceEvenement servEvent = new ServiceEvenement();
            List<ClassEvenement> events = servEvent.getEvents();
            int i = 0, size = events.Count;
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            for (i = 0; i < size; i++)
            {
                comboSource.Add(events.ElementAt(i).id, events.ElementAt(i).nom + " - " + String.Format("{0:dd/MM/yyyy}", events.ElementAt(i).date));
            }
            evenements.DataSource = new BindingSource(comboSource, null);
            evenements.DisplayMember = "Value";
            evenements.ValueMember = "Key";
        }
    }
}
