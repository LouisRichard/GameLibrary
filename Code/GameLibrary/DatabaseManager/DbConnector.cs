using System.IO;
using System.Data.SQLite;
using System;

namespace GameLibrary
{
    public class DbConnector
    {
        /// <summary>
        /// Connect to the SQLite database
        /// </summary>
        /// <param name="close">If true : Close database connection. If false : Open database connection</param>
        /// <returns>SQLiteCommand cmd if database is getting opened.</returns>
        /// <returns>Null if database is getting closed</returns>
        internal static SQLiteCommand ConnectToDatabase(bool close)
        {
            bool createTable = false;
            if (!File.Exists("GLdb.db3"))
            {
                CreateDatabase();
                createTable = true;
            }

            System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=GLdb.db3");
            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn);

            if (!close)
            {
                conn.Open(); //Open connection to the SQLite database
                if (createTable)
                {
                    CreateTable(cmd);
                }
                return cmd;
            }
            else
            {
                cmd = null;
                conn.Close();
                return cmd;
            }
        }

        /// <summary>
        /// Create the DB File
        /// </summary>
        private static void CreateDatabase()
        {
            System.Data.SQLite.SQLiteConnection.CreateFile(
                    Path.Combine(
                        Directory.GetCurrentDirectory(), "GLdb.db3")); //Create the database
        }
        /// <summary>
        /// Create the tables needed fot the database to works properly
        /// </summary>
        /// <param name="cmd">SQLiteCommand cmd</param>
        private static void CreateTable(SQLiteCommand cmd)
        {
            //TODO CREATE TABLES NEEDED FOR THE DB
            throw new NotImplementedException();
        }
    }
}
