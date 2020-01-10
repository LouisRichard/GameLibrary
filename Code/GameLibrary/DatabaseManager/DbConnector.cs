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
                "1292 Advanced Programmable Video System",
                "Panasonic 3DO Interactive Multiplayer FZ-1",
                "3DO/Matsushita M2",
                "Active Enterprises Action Gamemaster",
                "Atari 2600 Video Computer System",
                "Atari 2600 CE",
                "Atari 2600 VCSp",
                "Atari Lynx",
                "Bally Professional Arcade/Astrocade",
                "Bankzilla",
                "Barcode Battler",
                "Bit Corporation Gamate",
                "Bit Corporation Gamate Color",
                "Coleco Adam",
                "ColecoVision",
                "DataMax UV-1",
                "Fujitsu FM Towns Marty/FM Towns Marty 2",
                "GamePark 32",
                "Hasbro Pox",
                "Indrema Entertainment System",
                "Infinium Labs Phantom",
                "Interton VC-4000",
                "iQue Player",
                "Konix Multisystem",
                "Magnavox Odyssey",
                "Mega Duck/Cougar Boy",
                "Mega Duck Super Junior Computer",
                "Microsoft Xbox",
                "Microsoft Xbox 360",
                "Nintendo Entertainment System/Famicom",
                "Nintendo 64",
                "Nintendo 64 Dynamic Drive",
                "Nintendo DS",
                "Nintendo Famicom Disk System",
                "Nintendo Game & Watch",
                "Nintendo GameBoy/GameBoy Pocket",
                "Nintendo GameBoy Advance/GameBoy Advance SP",
                "Nintendo GameBoy Color",
                "Nintendo GameBoy Evolution",
                "Nintendo GameCube",
                "Nintendo Pokémon Mini",
                "Nintendo Virtual Boy",
                "Nintendo Wii",
                "Nokia N-Gage/N-Gage QD",
                "NPES",
                "Portendo",
                "PSp",
                "Puma 2600",
                "Sega 32X",
                "Sega Dreamcast",
                "Sega Dreamcast Visual Memory Unit",
                "Sega Game Gear",
                "Sega Master System/SG-1000 Mark III",
                "Sega Mega CD/Sega CD",
                "Sega Mega Drive/Genesis",
                "Sega Mega Jet",
                "Sega Neptune",
                "Sega Nomad",
                "Sega Pico",
                "Sega Saturn",
                "Sega SC-3000",
                "Sega SG-1000",
                "Sega Triforce",
                "Nintendo Super NES/Super Famicom",
                "SNES CD-ROM",
                "SNESp",
                "Sony PlayStation/PSOne",
                "Sony PlayStation 2",
                "Sony PlayStation 3",
                "Sony PlayStation PocketStation",
                "Sony PlayStation Portable",
                "Super Cassette Vision",
                "Supervision",
                "Tapwave Zodiac",
                "Tiger Telematics Gizmondo",
                "Time Top GameKing",
                "V-Tech V.Smile",
                "Video Driver",
                "ZGrass Computer Expansion Module"
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
