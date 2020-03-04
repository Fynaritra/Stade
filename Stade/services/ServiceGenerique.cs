using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ServiceGenerique
    {
        //Get current value of a sequence
        public int getSeqValue(SqlConnection connection, string sequence_name)
        {
            SqlDataReader dr = null;
            string query = "SELECT NEXT VALUE FOR " + sequence_name;
            SqlCommand cmd = new SqlCommand(query, connection);
            
            dr = cmd.ExecuteReader();
            int value = 0;
            while (dr.Read())
            {
                value = (int)dr.GetValue(0);
            }
            cmd.Dispose();
            dr.Close();
            return value;
        }

        //Set upper case the first letter of the word
        public string firstMaj(string str)
        {
            str = str.Trim();
            string valiny = "";
            //str = str.ToLower();
            char[] cara = str.ToCharArray();
            char[] vao = new char[cara.Length - 1];
            string debut = "" + (cara[0]);
            debut = debut.ToUpper();
            for (int i = 0; i < vao.Length; i++)
            {
                vao[i] = cara[i + 1];
            }
            string fin = new string(vao);
            valiny = string.Concat(debut, fin);
            return valiny;
        }

        //Select in table with object toSelect, the return object type, the clause after where and SqlConnection 
        public List<object> Select(SqlConnection connection, object toReturn, string table, string toSelect, string complement)
        {
            List<object> result = new List<object>();
            List<string> objectFields = new List<string>();
            List<string> tableFields = new List<string>();
            bool check = true;
            ServiceConnection dbcon = new ServiceConnection();
            if (connection == null)
            {
                check = false;
                dbcon.OpenConection();
                connection = dbcon.getCon();
            }
            try
            {
                //Type of return object
                Type objectType = toReturn.GetType();

                //Properties of the return object: public, nonPubilc, herited, and ignored case
                PropertyInfo[] objectProperties = objectType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase);
                int i = 0;
                for (i = 0; i < objectProperties.Length; i++)
                {
                    objectFields.Add(firstMaj(objectProperties[i].Name));
                }

                //Fields in table on database
                string queryColumn = "SELECT name FROM sys.columns WHERE object_id like OBJECT_ID('[dbo].[" + table + "]')";
                SqlCommand cmd = new SqlCommand(queryColumn, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tableFields.Add(firstMaj(dataReader.GetString(0)));
                }
                dataReader.Close();

                //Query of selection
                string query = "SELECT " + toSelect +" FROM [dbo].[" + table + "]";
                if (complement != "" && complement!=null)
                {
                    query += " " + complement;
                }
                cmd = new SqlCommand(query, connection);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    object temp = Activator.CreateInstance(objectType);
                    for (i = 0; i < objectFields.Count; i++)
                    {
                        //Select only common fields between table and class
                        if (tableFields.Contains(objectFields[i]))
                        {
                            objectProperties[i].SetValue(temp, data.GetValue(data.GetOrdinal(objectFields[i])));
                        }
                    }
                    result.Add(temp);
                }
                cmd.Dispose();
                data.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (!check)
                {
                    dbcon.CloseConnection();
                }
            }
            return result;
        }

        //Insert in a table
        public void Insert(SqlConnection connection, object toInsert, string table)
        {
            //Transaction
            //SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            try
            {
                List<string> objectFields = new List<string>();
                List<string> tableFields = new List<string>();
                Type objectType = toInsert.GetType();

                //Properties of the object to insert: Public, nonPublic, herited, ingored case
                PropertyInfo[] objectProperties = objectType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase);
                int i = 0;
                for (i = 0; i < objectProperties.Length; i++)
                {
                    objectFields.Add(firstMaj(objectProperties[i].Name));
                }

                //Fields in table on database
                string queryColumn = "SELECT name FROM sys.columns WHERE object_id like OBJECT_ID('[dbo].[" + table + "]')";
                cmd = new SqlCommand(queryColumn, connection);
                
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tableFields.Add(firstMaj(dataReader.GetString(0)));
                }
                dataReader.Close();

                string colonnes = "";
                string valeurs = "";
                List<string> listColonnes = new List<string>();
                List<object> listValeurs = new List<object>();
                List<PropertyInfo> listMethodes = new List<PropertyInfo>();
                for (i = 0; i < objectFields.Count; i++)
                {
                    //Insert only all common fields between class and table
                    if (tableFields.Contains(objectFields[i]))
                    {
                        PropertyInfo tempProperty = objectType.GetProperty(objectFields[i], BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        listColonnes.Add(objectFields[i]);
                        listValeurs.Add(tempProperty.GetValue(toInsert));
                    }
                }
                for(i=0; i<listColonnes.Count-1; i++)
                {
                    colonnes += listColonnes.ElementAt(i) + ",";
                }
                colonnes += listColonnes.ElementAt(i);
                String valeur = "";
                for (i=0; i<listValeurs.Count-1; i++)
                {
                    valeur = listValeurs.ElementAt(i) + ", ";
                    if (listValeurs.ElementAt(i).GetType().Name.CompareTo("Decimal") == 0)
                    {
                        String nombre = listValeurs.ElementAt(i).ToString().Trim().Split(',')[0];
                        valeur = nombre + ", ";
                    }
                    if (listValeurs.ElementAt(i).GetType().Name.CompareTo("String") == 0)
                    {
                        valeur = "'" + listValeurs.ElementAt(i) + "', ";
                    }
                    if (listValeurs.ElementAt(i).GetType().Name.Contains("Date"))
                    {
                        DateTime daty = (DateTime)listValeurs.ElementAt(i);
                        valeur = " convert(datetime ,'" + daty.ToString("MM/dd/yyyy HH:mm:ss") + "'), ";
                    }
                    valeurs += valeur;
                }
                valeur = listValeurs.ElementAt(i) + "";
                if (listValeurs.ElementAt(i).GetType().Name.CompareTo("String") == 0)
                {
                    valeur = "'" + listValeurs.ElementAt(i) + "'";
                }
                if (listValeurs.ElementAt(i).GetType().Name.Contains("Date")){
                    DateTime daty = (DateTime)listValeurs.ElementAt(i);
                    valeur = " convert(datetime,'" + daty.ToString("MM/dd/yyyy HH:mm:ss") + "') ";
                }

                valeurs += valeur;
                /*Get a query like this : insert into table (col1, col2, col3) values (val1, val2, val3)*/
                string insertQuery = "insert into " + table + " (" + colonnes + ") values (" + valeurs + ") ";
                cmd = new SqlCommand(insertQuery, connection);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                //transaction.Rollback();
            }
            
        }


    }
}
