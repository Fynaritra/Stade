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
    public partial class Evenement : Form
    {
        public List<PointF> points = new List<PointF>();
        public Evenement()
        {
            InitializeComponent();
        }

        private void lieux_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idEvent = lieux.SelectedItem.ToString();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.points = new List<PointF>();
            this.ResetText();
        }

        private void enregistrement_Click(object sender, EventArgs e)
        {
            ServicePaint paintServ = new ServicePaint();
            paintServ.isPolygon(this.points);
            String nomEvent = nom.Text;
            String lieu = lieux.SelectedValue.ToString();
            DateTime date = calendrier.SelectionStart;
            String coordonnees = paintServ.generatePointDB(this.points);
            ServiceEvenement servEvent = new ServiceEvenement();
            servEvent.addEvenement(date, nomEvent, lieu, coordonnees);
            //this.annuler_Click(sender, e);
            Zone zone = new Zone();
            zone.Show();
        }

        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = calendrier.SelectionStart;
            MessageBox.Show(date.ToString());
        }

        private void paintstade_MouseDown(object sender, MouseEventArgs e)
        {
            int cooX = e.X;
            int cooY = e.Y;
            PointF point = new PointF(cooX, cooY);
            points.Add(point);
            ServicePaint servPaint = new ServicePaint();
            servPaint.drawPoint(paintstade, cooX, cooY);
        }

        private void affichage_Click(object sender, EventArgs e)
        {
            ServicePaint servPaint = new ServicePaint();
            Pen pen = new Pen(Brushes.LightGray);
            servPaint.drawPolygon(paintstade, points, pen);
        }

        private void Evenement_Load(object sender, EventArgs e)
        {
            ServiceLieu serv = new ServiceLieu();
            List<ClassLieu> listeLieux = serv.getLieux();
            int i = 0, size = listeLieux.Count;
            Dictionary<String,String> comboSource = new Dictionary<String, String>();
            for(i=0; i<size; i++)
            {
                comboSource.Add(listeLieux.ElementAt(i).id, listeLieux.ElementAt(i).nom + " " + listeLieux.ElementAt(i).lieu);
            }
            lieux.DataSource = new BindingSource(comboSource, null);
            lieux.DisplayMember = "Value";
            lieux.ValueMember = "Key";
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
