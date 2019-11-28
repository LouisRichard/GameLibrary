using System.IO;
using System.Data.SQLite;

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
        private static SQLiteCommand ConnectToDatabase(bool close)
        {
            if (!File.Exists("GLdb.db3"))
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(
                    Path.Combine(
                        Directory.GetCurrentDirectory(), "GLdb.db3")); //Create the database
            }

            System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=GLdb.db3");
            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn);

            if (!close)
            {
                conn.Open(); //Open connection to the SQLite database
                return cmd;
            }
            else
            {
                cmd = null;
                conn.Close();
                return cmd;
            }
        }
    }
}
