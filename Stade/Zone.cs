using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stade
{
    public partial class Zone : Form
    {
        public List<PointF> points = new List<PointF>();
        List<ClassChaise> chaises = new List<ClassChaise>();
        List<Rectangle> rects = new List<Rectangle>();
        List<Rectangle> annules = new List<Rectangle>();
        String idZone = "";
        public Zone()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.points = new List<PointF>();
            this.ResetText();
        }

        private void Zone_Load(object sender, EventArgs e)
        {
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

        private void enregistrer_Click(object sender, EventArgs e)
        {
            ServicePaint servPaint = new ServicePaint();
            servPaint.isPolygon(this.points);
            String nom = nomZone.Text;
            String lieu = evenements.SelectedValue.ToString();
            String coordinates = servPaint.generatePointDB(this.points);
            ServiceZone servZone = new ServiceZone();
            decimal pu = decimal.Parse(price.Text.ToString());
            decimal remplissage = decimal.Parse(taux.Text.ToString());
            decimal estimation = decimal.Parse(gain.Text.ToString());
            this.idZone = servZone.addZone(nom, lieu, coordinates, pu, estimation, remplissage);
            MessageBox.Show("Zone enregistré");
        }

        private void paintzone_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int cooX = e.X;
                int cooY = e.Y;
                PointF point = new PointF(cooX, cooY);
                points.Add(point);
                ServicePaint servPaint = new ServicePaint();
                servPaint.drawPoint(paintzone, cooX, cooY);
            }
        }

        private void evenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = ((KeyValuePair<string, string>)evenements.SelectedItem).Key;
            ServiceEvenement servEvent = new ServiceEvenement();
            
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                paintzone.Refresh();
                ClassEvenement evenement = servEvent.getEventById(id, connection);
                ServicePaint servPaint = new ServicePaint();
                servPaint.drawPolygon(paintzone, evenement.getPoints(), Pens.Black);
                ServiceZone zoneServ = new ServiceZone();
                Font myFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                List<ClassZone> zones = zoneServ.getZonesByEvent(id, connection);
                int i = 0, j=0, size = zones.Count;
                for(i=0; i<size; i++)
                {
                    servPaint.drawPolygon(paintzone, zones.ElementAt(i).getPoints(), Pens.Green);
                    List<ClassChaise> chairs = zoneServ.getChaises(zones.ElementAt(i).id, connection);
                    for(j=0; j<chairs.Count; j++)
                    {
                        Rectangle rect = chairs.ElementAt(j).generateRectangle();
                        servPaint.drawRectangle(paintzone, rect, Pens.Black);
                        if (chairs.ElementAt(j).position == -1)
                        {
                            servPaint.drawString(paintzone, rect, Brushes.Red, "X", myFont);
                        }
                        else
                        {
                            servPaint.drawString(paintzone, rect, Brushes.Blue, "" + decimal.Floor(chairs.ElementAt(j).position), myFont);
                        }
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                //throw ex;
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            ServicePaint servPaint = new ServicePaint();
            servPaint.drawPolygon(paintzone, this.points, Pens.DimGray);
        }

        private void simulation_Click(object sender, EventArgs e)
        {
            ServicePaint servPaint = new ServicePaint();
            float width = float.Parse(largeur.Text.ToString());
            float height = float.Parse(longueur.Text.ToString());
            float space = float.Parse(espace.Text.ToString());
            int debut = int.Parse(debutnum.Text.ToString());
            ServiceGenerique servGen = new ServiceGenerique();
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            rects = servPaint.drawPlaces(paintzone, width, height, space, this.points);
            String idevent = ((KeyValuePair<string, string>)evenements.SelectedItem).Key;
            int i = 0, size = rects.Count;
            String id = "";
            try
            {
                for(i=0; i<size; i++)
                {
                    servPaint.drawRectangle(paintzone, rects.ElementAt(i), Pens.MediumTurquoise);
                    ClassChaise chaise = new ClassChaise(id, this.idZone, 0, decimal.Parse(space.ToString()), decimal.Parse(height.ToString()), decimal.Parse(width.ToString()), rects.ElementAt(i).X, rects.ElementAt(i).Y, idevent);
                    this.chaises.Add(chaise);
                }   
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            servPaint.numeroterPlaces(paintzone, rects, annules, this.chaises, debut, 0, 0, 0);
        }

        private void buttonchaises_Click(object sender, EventArgs e)
        {
            ServiceZone servZone = new ServiceZone();
            servZone.addChaises(this.chaises);
            MessageBox.Show("Chaises enregistrées");
        }

        private void init_Click(object sender, EventArgs e)
        {
            paintzone.Refresh();
            this.rects = new List<Rectangle>();
            this.afficher_Click(sender, e);
        }

        private void paintzone_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int cooX = e.X;
                int cooY = e.Y;
                Point point = new Point(cooX, cooY);
                ServicePaint servPaint = new ServicePaint();
                int i = 0, size = rects.Count;
                Graphics graphics = this.paintzone.CreateGraphics();
                for (i=0; i<size; i++)
                {
                    if(servPaint.isInside(rects.ElementAt(i), point))
                    {
                        paintzone.Refresh();
                        annules.Add(rects.ElementAt(i));
                        graphics.FillRectangle(Brushes.Black, rects.ElementAt(i));
                        this.evenements_SelectedIndexChanged(sender, e);
                        this.afficher_Click(sender, e);
                        this.simulation_Click(sender, e);
                    }
                }
            }
        }
    }
}
