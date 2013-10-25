using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFormAC
{
    class MarinaDBConnector
    {
        private SqlConnection dbSqlConnection;
        //private bool dbConnectionIsPersistent = true;

        /// <summary>
        /// Open db connection set it to dbSqlConnection
        /// </summary>
        /// <param name="dbConnectionString"></param>
        public MarinaDBConnector(string dbConnectionString)
        {
            dbSqlConnection = new SqlConnection(dbConnectionString);
            dbSqlConnection.Open();
        }

        /// <summary>
        /// Closes dbSqlConnection
        /// </summary>
        ~MarinaDBConnector()
        {
            dbSqlConnection.Close();
        }

        /// <summary>
        /// Selects an individual MarinaDBRow from Marina Table
        /// </summary>
        /// <param name="id">Id of the requested row</param>
        /// <returns>MarinaDBRow object</returns>
        public MarinaDBRow Select(string id)
        {
            string sqlQueryString = "SELECT marina_num, name, address, city, state, zip FROM marina WHERE marina_num = " + id + ";";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            MarinaDBRow row = new MarinaDBRow();

            //Read record in result set
            reader.Read();
           
            row.id = reader[0].ToString().Trim();
            row.name = reader[1].ToString().Trim();
            row.address = reader[2].ToString().Trim();
            row.city = reader[3].ToString().Trim();
            row.state = reader[4].ToString().Trim();
            row.zip = reader[5].ToString().Trim();
            
            reader.Close();
            return row;
        }

        /// <summary>
        /// Inserts a MarinaDBRow into the Marina Table
        /// </summary>
        /// <param name="row">MarinaDBRow to be inserted</param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Insert(MarinaDBRow row)
        {
            return Insert(row.id, row.name, row.address, row.city, row.state, row.zip);
        }

        /// <summary>
        /// Inserts data into the Marina Table
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Insert(string id, string name, string address, string city, string state, string zip)
        {
            string sqlQueryString = "INSERT INTO marina VALUES ('" + id + "','" + name + "','" + address + "','" + city + "','" + state + "','" + zip + "');";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            return sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates a record in the Marina Table
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Update(string id, string name, string address, string city, string state, string zip)
        {
            string sqlQueryString = "UPDATE marina SET name = '" + name + "',address = '" + address + "',city = '" + city + "', state = '" + state + "', zip = '" + zip + "' WHERE marina_num = '" + id + "';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);   
            return sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates a record in the Maina Table
        /// </summary>
        /// <param name="oldId">id value to change</param>
        /// <param name="newId">updated id value</param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Update(string oldId, string newId, string name, string address, string city, string state, string zip)
        {
            string sqlQueryString = "UPDATE marina SET marina_num = '" + newId + "', name = '" + name + "',address = '" + address + "',city = '" + city + "', state = '" + state + "', zip = '" + zip + "' WHERE marina_num = '" + oldId + "';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            return sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates a record in the Maina Table
        /// </summary>
        /// <param name="id">id value to change</param>
        /// <param name="row"></param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Update(string id, MarinaDBRow row)
        {
            string sqlQueryString = "UPDATE marina SET name = '" + row.name + "',address = '" + row.address + "',city = '" + row.city + "', state = '" + row.state + "', zip = '" + row.zip + "' WHERE marina_num = '" + id + "';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);
            return sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Deletes a row in the Marina Table
        /// </summary>
        /// <param name="id">Id of requested record to be deleted</param>
        /// <returns>Number of rows affected in the Marina Table</returns>
        public int Delete(string id)
        {
            string sqlQueryString = "DELETE FROM marina WHERE marina_num = '" + id +"';";
            SqlCommand sqlCommand = new SqlCommand(sqlQueryString, dbSqlConnection);          
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
