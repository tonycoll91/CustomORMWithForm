using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFormAC
{
    class Marina
    {
        public string id;
        public string name;
        public string address;
        public string city;
        public string state;
        public string zip;

        public int Update()
        {
            SqlConnection dbSqlConnection = new SqlConnection(Properties.Resources.DBConnectionString);
            dbSqlConnection.Open();

            string sqlQueryString = "UPDATE marina SET marina_num = '" + newId + "', name = '" + this.name + "',address = '" + this.address + "',city = '" + this.city + "', state = '" + this.state + "', zip = '" + this.zip + "' WHERE marina_num = '" + oldId + "';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            int numRowsAffected = sqlCommand.ExecuteNonQuery();
            
            dbSqlConnection.Close();

            return numRowsAffected;
        }

        public int Delete()
        {
            SqlConnection dbSqlConnection = new SqlConnection(Properties.Resources.DBConnectionString);
            dbSqlConnection.Open();

            string sqlQueryString = "DELETE FROM marina WHERE marina_num = '" + this.id + "';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            int numRowsAffected = sqlCommand.ExecuteNonQuery();

            dbSqlConnection.Close();

            return numRowsAffected;
        }

        public static Marina GetMarinaById(string id)
        {
            SqlConnection dbSqlConnection = new SqlConnection(Properties.Resources.DBConnectionString);
            dbSqlConnection.Open();

            dbSqlConnection.Close();
        }

        public static List<Marina> GetAllMarinas()
        {
            //stub
        }
    }
}
