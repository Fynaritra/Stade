using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ServiceZone : ServiceGenerique
    {
        //Avoir nb chaises par zone
        public float getNbChaises(SqlConnection connection, String idZone)
        {
            float result = 0;
            List<object> chaises = this.Select(connection, new ClassChaise(), "chaises", "*", "where zone like '" + idZone + "'");
            result = chaises.Count;
            return result;
        }

        //Avoir nb réservations par zone
         public float getNbReservations(SqlConnection connection, String idZone)
        {
            float result = 0;
            List<object> chaises = this.Select(connection, new ClassChaise(), "reservation", "*", "where idzone like '" + idZone + "'");
            result = chaises.Count;
            return result;
        }

        //Avoir chaises
        public List<ClassChaise> getChaises(String idZone, SqlConnection connection)
        {
            List<ClassChaise> chaises = new List<ClassChaise>();
            List<object> temp = this.Select(connection, new ClassChaise(), "chaises", "*", "where zone like '" + idZone + "'");
            int i = 0, size = temp.Count;
            for(i=0; i<size; i++)
            {
                chaises.Add((ClassChaise)temp.ElementAt(i));
            }
            return chaises;
        }


        //Ajouter chaises
        public void addChaises(List<ClassChaise> chaises)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                String tableChaise = "Chaises";
                int i = 0, size = chaises.Count;
                for(i=0; i<size; i++)
                {
                    if (chaises.ElementAt(i).position != 0)
                    {
                        String id = "C" + this.getSeqValue(connection, "chaisesequence");
                        chaises.ElementAt(i).setId(id);
                        this.Insert(connection, chaises.ElementAt(i), tableChaise);
                    }
                    
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public String addZone(String nom, String lieu, String coordinates, decimal pu, decimal estimation, decimal remplissage)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            String id = "";
            try
            {
                id = "Z" + this.getSeqValue(connection, "zonesequence");
                ClassZone classZone = new ClassZone(lieu, nom, id, coordinates, pu, estimation, remplissage);
                this.Insert(connection, classZone, "zone");
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public decimal getPuByZone(string idZone, SqlConnection connection)
        {
            decimal price = 0;
            List<object> temp = Select(connection, new ClassZone(), "zone", "*", "where id like '" + idZone + "'");
            if (temp.Count > 0)
            {
                price = ((ClassZone)temp.ElementAt(0)).prixunitaire;
            }
            return price;
        }

        public List<ClassZone> getZonesByEvent(String idEvent, SqlConnection connection)
        {
            List<ClassZone> zones = new List<ClassZone>();
            try
            {
                List<object> temp = this.Select(connection, new ClassZone(), "zone", "*", " where lieu like '" + idEvent + "'");
                int i = 0, size = temp.Count;
                for(i=0; i<size; i++)
                {
                    zones.Add((ClassZone)temp.ElementAt(i));
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return zones;
        }
    }
}
