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

        //Active Record Design Pattern

        public int Update()
        {
            SqlConnection dbSqlConnection = new SqlConnection(Properties.Resources.DBConnectionString);
            dbSqlConnection.Open();

                string sqlQueryString = "UPDATE marina SET name = '" + this.name + "',address = '" + this.address + "',city = '" + this.city + "', state = '" + this.state + "', zip = '" + this.zip + "' WHERE marina_num = '" + this.id + "';";
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

            string sqlQueryString = "SELECT marina_num, name, address, city, state, zip FROM marina WHERE marina_num = " + id + ";";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Marina m1 = new Marina(); 

            //Read record in result set
            reader.Read();

            m1.id = reader[0].ToString().Trim();
            m1.name = reader[1].ToString().Trim();
            m1.address = reader[2].ToString().Trim();
            m1.city = reader[3].ToString().Trim();
            m1.state = reader[4].ToString().Trim();
            m1.zip = reader[5].ToString().Trim();

            reader.Close();

            dbSqlConnection.Close();

            return m1;
        }

        public static List<Marina> GetAllMarinas()
        {
            SqlConnection dbSqlConnection = new SqlConnection(Properties.Resources.DBConnectionString);
            dbSqlConnection.Open();

            string sqlQueryString = "SELECT marina_num, name, address, city, state, zip FROM marina;";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Marina> marinas = new List<Marina>();

            //Read record in result set
            while(reader.Read())
            {
                Marina m1 = new Marina();
                
                m1.id = reader[0].ToString().Trim();
                m1.name = reader[1].ToString().Trim();
                m1.address = reader[2].ToString().Trim();
                m1.city = reader[3].ToString().Trim();
                m1.state = reader[4].ToString().Trim();
                m1.zip = reader[5].ToString().Trim();

                marinas.Add(m1);
            }
            reader.Close();

            dbSqlConnection.Close();

            return marinas;
        }
    }
}
