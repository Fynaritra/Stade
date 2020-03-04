using Stade.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.services
{
    class ServiceReservation : ServiceGenerique
    {
        private String[] separate(String toSeparate, char separator) {
            return toSeparate.Split(separator);
        }
        private List<String> continuouslySeparate(String toSeparate, char continuous)
        {
            List<String> separated = new List<string>();
            String[] numbers = toSeparate.Split(continuous);
            int firstPart = int.Parse(numbers[0]), lastPart = int.Parse(numbers[1]);
            while(firstPart<lastPart)
            {
                separated.Add("" + firstPart);
                firstPart++;
            }
            return separated;
        }
        public List<String> analyzeString(String toAnalyze)
        {
            List<String> result = new List<string>();
            char separator = ',', continuous = '-';
            String[] separations = this.separate(toAnalyze, separator);
            int i = 0, size = separations.Length;
            for(i=0; i<size; i++)
            {
                if (separations[i].Contains(continuous))
                {
                    List<String> separation = this.continuouslySeparate(separations[i], continuous);
                    result.AddRange(separation);
                }
                else
                {
                    result.Add(separations[i]);
                }
            }
            return result;
        }

        private bool isAvailable(String idzone, decimal position, SqlConnection connection)
        {
            List<Object> temp = this.Select(connection, new ClassReservation(), "etatreservation", "*", "where idzone like '"+idzone+"' and position ="+position);
            if (temp.Count > 0)
            {
               return false;
            }
            return true;
        }
        public void verifPlaces(String listPlaces, String idzone, SqlConnection connection)
        {
            String error = "";
            List<String> analyzed = analyzeString(listPlaces);
            int i = 0, size = analyzed.Count;
            for (i =0; i<size; i++)
            {
                if(!isAvailable(idzone, decimal.Parse(analyzed.ElementAt(i)), connection))
                {
                    error += analyzed.ElementAt(i) + "/";
                }
            }
            if (error.CompareTo("") != 0)
            {
                throw new Exception("Place(s) non disponible(s) : " + error);
            }
        }
        public void addReservation(ClassReservation reservation, SqlConnection connection)
        {
            int idReservation = this.getSeqValue(connection, "reservationsequence");
            String id = "R" + idReservation;
            reservation.id = id;
            this.Insert(connection, reservation, "reservation");
        }
        private void verifDateReservation(String id, DateTime dateReservation, SqlConnection connection)
        {
            ServiceEvenement service = new ServiceEvenement();
            ClassEvenement evenement = service.getEventById(id, connection);
            if (dateReservation.CompareTo(evenement.date) > 0)
            {
                throw new Exception("Date de réservation doit etre avant " + evenement.date.ToString("DD/MM/YYYY"));
            }
        }
        public void takePlaces(String listPlaces, String idZone, String idevent, String nom, DateTime dateReservation)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            ServiceZone servZone = new ServiceZone();
            try
            {
                verifDateReservation(idevent, dateReservation, connection);
                verifPlaces(listPlaces, idZone, connection);
                decimal pu = servZone.getPuByZone(idZone, connection);
                List<String> positions = this.analyzeString(listPlaces);
                int i = 0, size = positions.Count;
                for(i=0; i<size; i++)
                {
                    ClassReservation reservation = new ClassReservation(idevent, decimal.Parse(positions[i]), nom, pu, dateReservation, idZone);
                    this.addReservation(reservation, connection);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
