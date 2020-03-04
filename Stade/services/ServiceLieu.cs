using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ServiceLieu : ServiceGenerique
    {
        public void addLieu(String nom, String lieu)
        {
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection sqlCon = servCon.getCon();
            
            try
            {
                int idLieu = this.getSeqValue(sqlCon, "lieusequence");
                ClassLieu nouveauLieu = new ClassLieu(nom, lieu);
                nouveauLieu.id = "L"+idLieu;
                this.Insert(sqlCon, nouveauLieu, "Lieu");
            }catch(Exception ex)
            {
                throw ex;
            }finally
            {
                //transaction.Rollback();
                //transaction.Dispose();
                sqlCon.Close();
            }
            
        }

        public List<ClassLieu> getLieux()
        {
            List<ClassLieu> lieux = new List<ClassLieu>();
            ServiceConnection servCon = new ServiceConnection();
            servCon.OpenConection();
            SqlConnection connection = servCon.getCon();
            try
            {
                lieux = getLieux(connection);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return lieux;
        }
        public List<ClassLieu> getLieux(SqlConnection connection)
        {
            List<ClassLieu> lieux = new List<ClassLieu>();
            List<object> temp = this.Select(connection, new ClassLieu(), "Lieu", "*", "");
            int i = 0, size = temp.Count;
            for(i=0; i<size; i++)
            {
                lieux.Add((ClassLieu)temp.ElementAt(i));
            }
            return lieux;
        }
    }
}
