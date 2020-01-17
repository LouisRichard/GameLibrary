using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseManager
{
    /// <summary>
    /// This class assures the connection with the database.
    /// </summary>
    public class DbConnector
    {
        #region methods

        /// <summary>
        /// Connect to the SQLite database.
        /// </summary>
        /// <param name="close">If true : Close database connection. If false : Open database connection.</param>
        /// <returns>SQLiteCommand cmd if database is getting opened.</returns>
        /// <returns>Null if database is getting closed.</returns>
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
                conn.Open();
                if (createTable)
                {
                    CreateTable(cmd);
                    InsertPlatform(cmd);
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
        /// Create the DB File.
        /// </summary>
        internal static void CreateDatabase()
        {
            System.Data.SQLite.SQLiteConnection.CreateFile(
                    Path.Combine(
                        Directory.GetCurrentDirectory(), "GLdb.db3")); //Create the database
        }

        internal static void InsertPlatform(SQLiteCommand cmd)
        {
            string query = @"INSERT INTO [Platforms](Name) VALUES ";

            List<string> platforms = new List<string>(new string[]
            {
                "3DO Interactive Multiplayer",
                "Atari 2600 Video Computer System",
                "Atari 2600 CE",
                "Atari Lynx",
                "Casio Loopy",
                "ColecoVision",
                "Microsoft Xbox",
                "Microsoft Xbox 360",
                "Neo-Geo CD",
                "Nintendo Entertainment System",
                "Nintendo 64",
                "Nintendo DS",
                "Nintendo Famicom Disk System",
                "Nintendo Game & Watch",
                "Nintendo GameBoy",
                "Nintendo GameBoy Advance",
                "Nintendo GameBoy Color",
                "Nintendo GameCube",
                "Nintendo Pokémon Mini",
                "Nintendo Switch",
                "Nintendo Virtual Boy",
                "Nintendo Wii",
                "Nintendo Wii U",
                "Nokia N-Gage",
                "Sega 32X",
                "Sega Dreamcast",
                "Sega Game Gear",
                "Sega Master System",
                "Sega CD",
                "Sega Mega Drive",
                "Sega Saturn",
                "Sega Triforce",
                "Super NES",
                "Sony PlayStation",
                "Sony PlayStation 2",
                "Sony PlayStation 3",
                "Sony PlayStation 4",
                "Sony PlayStation Portable",
                "Vectrex"
            });

            int nbPlatform = platforms.Count();
            int index = 0;
            foreach (string platform in platforms)
            {
                index++;
                if (index == nbPlatform)
                {
                    query = query + "('" + platform + "');";
                }
                else
                {
                    query = query + "('" + platform + "'), ";
                }
            }
            query = query + "')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Create the tables needed fot the database to works properly.
        /// </summary>
        /// <param name="cmd">SQLiteCommand cmd</param>
        internal static void CreateTable(SQLiteCommand cmd)
        {
            List<string> createTableQuery = new List<string>
            {
                @"CREATE TABLE IF NOT EXISTS
                                [Users]([idUser] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                [Email] VARCHAR(255) NOT NULL UNIQUE,
                                [Password] VARCHAR(255) NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS 
                                [Games]([idGame] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                [Title] VARCHAR(255) NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS
                                [Library](
                                [idUser] INTEGER NOT NULL,
                                [idGame] INTEGER NOT NULL,
                                [idPlatform] INTEGER NOT NULL,
                                [DateAdded] DATE NOT NULL,
                                FOREIGN KEY(idUser) REFERENCES Users(idUser),
                                FOREIGN KEY(idGame) REFERENCES Games(idGame)
                                FOREIGN KEY(idPlatform) REFERENCES Platforms(idPlatform));",

                @"CREATE TABLE IF NOT EXISTS
                                [Platforms]([idPlatform] INTEGER NOT NULL PRIMARY KEY,
                                [Name] VARCHAR(255) NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS 
                                [GamesPlatforms](
                                [idGame] INTEGER NOT NULL,
                                [idPlatform] INTEGER NOT NULL,
                                FOREIGN KEY(idGame) REFERENCES Games(idGame)
                                FOREIGN KEY(idPlatform) REFERENCES Platforms(idPlatform));"
            };

            foreach(string query in createTableQuery)
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }

        #endregion methods
    }
}
