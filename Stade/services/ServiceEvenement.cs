using Stade.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ServiceEvenement: ServiceGenerique
    {
        //Medias using during an event
        private  void distinctMedia(List<ClassMedia> medias)
        {
            int i = 0, j=0;
            for(i=0; i< medias.Count - 1; i++)
            {
                for(j=i+1; j< medias.Count; j++)
                {
                    if (medias.ElementAt(i).media.CompareTo(medias.ElementAt(j).media) == 0)
                    {
                        medias.RemoveAt(j);
                    }
                }
            }
        }
        private List<ClassMedia> getSameMedia(List<ClassMedia> listMedias, String idMedia)
        {
            List<ClassMedia> medias = new List<ClassMedia>();
            int i = 0, size = listMedias.Count;
            for(i=0; i<size; i++)
            {
                if (listMedias.ElementAt(i).media.CompareTo(idMedia) == 0)
                {
                    medias.Add(listMedias.ElementAt(i));
                }
            }
            return medias;
        }
        private float getMoyenne(List<ClassMedia> listMedias)
        {
            float result = 0, somme = 0;
            int i = 0;
            for(i=0; i<listMedias.Count; i++)
            {
                somme += listMedias.ElementAt(i).pourcentage;
            }
            if (listMedias.Count > 0)
            {
                result = somme / listMedias.Count;
            }
            return result;
        }
        public List<ClassMedia> getClassement(List<ClassAnalyse> analyses)
        {
            List<ClassMedia> medias = new List<ClassMedia>();
            List<ClassMedia> listMediasToDistinct = new List<ClassMedia>();
            List<ClassMedia> listMedias = new List<ClassMedia>();
            int i = 0, size = analyses.Count, j=0;
            for(i=0; i<size; i++)
            {
                List<ClassMedia> media = analyses.ElementAt(i).media;
                for(j=0; j<media.Count; j++)
                {
                    listMedias.Add(media.ElementAt(j));
                    listMediasToDistinct.Add(media.ElementAt(j));
                }
            }
            distinctMedia(listMediasToDistinct);
            for(i=0; i< listMediasToDistinct.Count; i++)
            {
                List<ClassMedia> sameMedias = getSameMedia(listMedias, listMediasToDistinct.ElementAt(i).media);
                float moyenne = getMoyenne(sameMedias);
                ClassMedia temp = new ClassMedia(listMediasToDistinct.ElementAt(i).media, moyenne, listMediasToDistinct.ElementAt(i).nom);
                medias.Add(temp);
            }
            return medias;
        }
        private List<ClassMedia> getMediasByEvent(SqlConnection connection, String idevent)
        {
            List<ClassMedia> medias = new List<ClassMedia>();
            List<object> temp = this.Select(connection, new ClassMedia(), "DetailMedia", "*", " where idevent like '" + idevent + "' order by id");
            int i = 0, size = temp.Count;
            for(i=0; i<size; i++)
            {
                medias.Add((ClassMedia)temp.ElementAt(i));
            }
            return medias;
        }
        public List<ClassMedia> getMediasByDate(List<ClassMedia> medias, DateTime date)
        {
            List<ClassMedia> sameDates = new List<ClassMedia>();
            /*IEnumerable<ClassMedia> result = medias.AsQueryable().Where(media => media.datemedia.CompareTo(date) == 0);
            sameDates.AddRange(sameDates);*/
            int i = 0, size = medias.Count;
            for(i=0; i<size; i++)
            {
                if (medias.ElementAt(i).datemedia.CompareTo(date) == 0)
                {
                    sameDates.Add(medias.ElementAt(i));
                }
            }
            return sameDates;
        }

        //Reservations of an event, for the curve
        private List<DateTime> distinctDates(List<ClassReservation> reservations)
        {
            List<DateTime> dates = new List<DateTime>();
            /*IEnumerable<ClassReservation> noDuplicatesDate = reservations.AsQueryable().Distinct(new ReservationComparer());
            foreach(var reservation in noDuplicatesDate)
            {
                dates.Add(reservation.datereservation);
            }*/
            DateTime init = new DateTime(1, 1, 1);
            int i = 0, j = 0;
            for(i=0; i<reservations.Count-1; i++)
            {
                for(j=i+1; j<reservations.Count; j++)
                {
                    if (reservations.ElementAt(i).datereservation.CompareTo(reservations.ElementAt(j).datereservation) == 0)
                    {
                        reservations.ElementAt(j).datereservation = init;
                    }
                }
            }
            for(i=0; i<reservations.Count; i++)
            {
                if (reservations.ElementAt(i).datereservation.CompareTo(init) != 0)
                {
                    dates.Add(reservations.ElementAt(i).datereservation);
                }
            }
            return dates;
        }
        private List<ClassReservation> reservationsByDate(List<ClassReservation> reservations, DateTime date)
        {
            List<ClassReservation> result = new List<ClassReservation>();
            /*IEnumerable<ClassReservation> sameDates = reservations.AsQueryable().Where(reservation => reservation.datereservation.CompareTo(date) == 0);
            result.AddRange(sameDates);*/
            int i = 0, size = reservations.Count;
            for (i = 0; i < size; i++)
            {
                if (reservations.ElementAt(i).datereservation.CompareTo(date) == 0)
                {
                    result.Add(reservations.ElementAt(i));
                }
            }
            return result;
        }
        public List<ClassReservation> getReservations(String id, SqlConnection connection)
        {
            List<ClassReservation> reservations = new List<ClassReservation>();
            List<object> temp = this.Select(connection, new ClassReservation(), "reservation", "*", " where idevent like '"+id+"' order by datereservation");
            int i = 0, size = temp.Count;
            for(i=0; i< size;i++ )
            {
                reservations.Add((ClassReservation)temp.ElementAt(i));
            }
            return reservations;
        }
        public decimal getNombreChaises(String id, SqlConnection connection)
        {
            List<object> temp = this.Select(connection, new ClassAnalyse(), "Chaises", "*", " where idevent like '"+id+"'");
            decimal result = temp.Count;
            return result;
        }

        //Courbe d'analyse des réservations selon médias utilisés durant un événement
        public List<ClassAnalyse> getDailyReservations(String idevent)
        {
            List<ClassAnalyse> dailyReservations = new List<ClassAnalyse>();
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                List<ClassReservation> eventReservations = getReservations(idevent, connection);
                List<ClassMedia> mediasEvent = getMediasByEvent(connection, idevent);
                List<ClassReservation> reservations = getReservations(idevent, connection);
                List<DateTime> dates = distinctDates(eventReservations);

                decimal total = getNombreChaises(idevent, connection);
                int i = 0, dateSize = dates.Count, j=0;
                for (i = 0; i < dateSize; i++)
                {
                    List<ClassReservation> sameDates = reservationsByDate(reservations, dates.ElementAt(i));
                    List<ClassMedia> media = getMediasByDate(mediasEvent, dates.ElementAt(i).AddDays(-1));
                    ClassAnalyse analyse = new ClassAnalyse(dates.ElementAt(i), sameDates.Count, total, media);
                    if (media.Count > 0)
                    {
                        float pourcentage = (sameDates.Count / float.Parse(total.ToString())) / media.Count;
                        for(j=0; j<media.Count; j++)
                        {
                            media.ElementAt(j).pourcentage = pourcentage;
                        }
                    }
                    dailyReservations.Add(analyse);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dailyReservations;
        }

        //Evenement selon Id
        public ClassEvenement getEventById(String id, SqlConnection connection)
        {
            ClassEvenement evenement = new ClassEvenement();
            try
            {
                List<object> temp = this.Select(connection, new ClassEvenement(), "evenement", "*", " where id like '"+id+"'");
                if (temp.Count > 0)
                {
                    evenement = (ClassEvenement)temp.ElementAt(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return evenement;
        }
        
        //Liste de tous les evenements
        public List<ClassEvenement> getEvents()
        {
            List<ClassEvenement> events = new List<ClassEvenement>();
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                events = getEvents(connection);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return events;
        }
        public List<ClassEvenement> getEvents(SqlConnection connection)
        {
            List<ClassEvenement> events = new List<ClassEvenement>();
            List<object> temp = this.Select(connection, new ClassEvenement(), "evenement", "*", "");
            int i = 0, size = temp.Count;
            for(i=0; i<size; i++)
            {
                events.Add((ClassEvenement)temp.ElementAt(i));
            }
            return events;
        }

        //Ajouter un nouvel evenement
        public void addEvenement(DateTime date, String nomEvent, String lieu, String coordinates)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                int idEvent = this.getSeqValue(connection, "eventsequence");
                String id = "E" + idEvent;
                ClassEvenement evenement = new ClassEvenement(nomEvent, lieu, id, date, coordinates);
                this.Insert(connection, evenement, "evenement");
            }catch(Exception ex)
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
