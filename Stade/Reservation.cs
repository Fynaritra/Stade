using Stade.services;
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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }

        private void reserver_Click(object sender, EventArgs e)
        {
            ServiceReservation service = new ServiceReservation();
            String idevent = ((KeyValuePair<string, string>)evenements.SelectedItem).Key;
            String listPlaces = sieges.Text.ToString();
            String idZone = zone.SelectedValue.ToString();
            String nom = proprio.Text;
            DateTime dateReservation = this.dateReservation.SelectionStart;
            try
            {
                service.takePlaces(listPlaces, idZone, idevent, nom, dateReservation);
                MessageBox.Show("Places réservées");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void changeZones(List<ClassZone> zones, SqlConnection connection)
        {
            int i = 0, j = 0, x=0, y=0, width=60, height=15, size = zones.Count;
            ServicePaint servPaint = new ServicePaint();
            ServiceZone servZone = new ServiceZone();
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            Font myFont = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);

            for (i = 0; i < size; i++)
            {
                float nbChaises = servZone.getNbChaises(connection, zones.ElementAt(i).id);
                float nbReservation = servZone.getNbReservations(connection, zones.ElementAt(i).id);
                float pourcentage = (nbReservation / nbChaises)*100;
                x = (int)zones.ElementAt(i).getPoints().ElementAt(i).X-15;
                y = (int)zones.ElementAt(i).getPoints().ElementAt(i).Y;
                Rectangle rect = new Rectangle(x, y, width*5, height*3);
                servPaint.drawString(reservationpaint, rect, Brushes.ForestGreen, zones.ElementAt(i).nom + " " + pourcentage + "% sur " + zones.ElementAt(i).remplissage + "%", myFont);
                //servPaint.drawString(reservationpaint, rect, Brushes.ForestGreen, zones.ElementAt(i).nom, myFont);
                comboSource.Add(zones.ElementAt(i).id, zones.ElementAt(i).nom + " - " + zones.ElementAt(i).prixunitaire);
                servPaint.drawPolygon(reservationpaint, zones.ElementAt(i).getPoints(), Pens.Black);
                List<ClassChaise> chaises = servZone.getChaises(zones.ElementAt(i).id, connection);
                for(j=0; j<chaises.Count; j++)
                {
                    Rectangle chaise = chaises.ElementAt(j).generateRectangle();
                    servPaint.drawRectangle(reservationpaint, chaise, Pens.Blue);
                    if (chaises.ElementAt(j).position != -1)
                    {
                        servPaint.drawString(reservationpaint, chaise, Brushes.Black, decimal.Floor(chaises.ElementAt(j).position).ToString(), myFont);
                    }else
                    {
                        servPaint.drawString(reservationpaint, chaise, Brushes.Red, "X", myFont);
                    }
                }

            }
            zone.DataSource = new BindingSource(comboSource, null);
            zone.DisplayMember = "Value";
            zone.ValueMember = "Key";
        }

        private void Reservation_Load(object sender, EventArgs e)
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

        private void evenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            ServiceZone servZone = new ServiceZone();
            String eventSelected = ((KeyValuePair<string, string>)evenements.SelectedItem).Key;
            try
            {
                List<ClassZone> zones = servZone.getZonesByEvent(eventSelected, connection);
                this.changeZones(zones, connection);
            }
            catch(Exception)
            {
                //throw ex;
            }finally
            {
                connection.Close();
            }
        }

        private void dateReservation_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(""+dateReservation.SelectionRange);
        }
    }
}
