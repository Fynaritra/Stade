using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade
{
    class ServiceConnection
    {
        string ConnectionString;
        SqlConnection con;
        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public SqlConnection getCon()
        {
            return con;
        }
        public void CloseConnection()
        {
            con.Close();
        }
        public void ExecuteQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public ServiceConnection(string connection)
        {
            ConnectionString = connection;
        }
        public ServiceConnection()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\etudes\Dev\C#\Stade\Stade\evenementdb.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
