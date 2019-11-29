using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;

namespace DatabaseManager
{
    public class ExecuteQuery
    {
        /// <summary>
        /// Execute a Select query
        /// </summary>
        /// <param name="query">Select query to execute</param>
        /// <returns>Query result as an String List</returns>
        public static List<string> Select(string query)
        {
            SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection
            List<string> result = new List<string>();
            DataTable dt = new DataTable();
            command.CommandText = query;
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    result.Add(Convert.ToString(reader));
                }
            }
                _ = DbConnector.ConnectToDatabase(true); //close db connection  Using Ignore(_) as we don't care what it returns.
            return result;
        }

        /// <summary>
        /// Execute a Insert query
        /// </summary>
        /// <param name="query">Insert query to execute</param>
        public static void Insert(string query)
        {
            SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection
            command.CommandText = query;
            command.ExecuteNonQuery(); //Execute the query

            _ = DbConnector.ConnectToDatabase(true); //close db connection   Using Ignore(_) as we don't care what it returns.
        }

        /// <summary>
        /// Execute a statement delete in the database
        /// </summary>
        /// <param name="query"></param>
        public static void Delete(string query)
        {
                SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection
                command.CommandText = query;
                command.ExecuteNonQuery(); //Execute the query

                _ = DbConnector.ConnectToDatabase(true); //close db connection   Using Ignore(_) as we don't care what it returns.
        }
    }
}
