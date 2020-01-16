using System;
using System.Text;
using System.Collections.Generic;
using DataManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLoginRegister
{
    /// <summary>
    /// This class tests the functionnalities related to games.
    /// </summary>
    [TestClass]
    public class TestGame
    {
        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [ExpectedException (typeof(GameException))]
        public void AddAGameWithoutTitle()
        {
            string title = "";
            string platform = "Sony PlayStation 3";

            User user = new User("TestUser1@email.com", "", "");
            Game game = new Game(title, platform);

            GameManager.AddGameToLibrary(game, user);
        }

        [TestMethod]
        [ExpectedException (typeof(GameException))]
        public void AddAGameWithoutPlatform()
        {
            string title = "Portal 2";
            string platform = "";

            User user = new User("TestUser1@email.com", "", "");
            Game game = new Game(title, platform);

            GameManager.AddGameToLibrary(game, user);
        }

        [TestMethod]
        [ExpectedException (typeof(PlatformDoesntExistsException))]
        public void AddAGameWithoutAValidPlatform()
        {
            string title = "Portal 2";
            string platform = "Look at me! I am the brand new platform everyone likes! I am soooo kewl! Better than a race car!";

            User user = new User("TestUser1@email.com", "psw1", "psw1");
            //The user needs to be registed because the program tries to get the user ID from the database
            UserManager.RegisterRequest(user); //In the case you get "UserAlreadyExistsException", delete the database and try again twice

            Game game = new Game(title, platform);

            GameManager.AddGameToLibrary(game, user);
        }

        [TestMethod]
        public void AddAGameWithCorrectValues()
        {
            string title = "Half Life 3";
            string platform = "Sony PlayStation 3";
            string userEmail = "gaben@valvesoftware.com";
            string userPsw = "MoolyFTW";

            Game game = new Game(title, platform);
            User user = new User(userEmail, userPsw, userPsw);

            UserManager.RegisterRequest(user);
            GameManager.AddGameToLibrary(game, user);
        }

        [TestMethod]
        public void DeleteAGameFromTheLibrary()
        {
            //Prep
            string title = "Left4Dead 3";
            string platform = "Panasonic 3DO Interactive Multiplayer FZ-1";
            string userEmail = "glad0s@lj-corp.ch";
            string userPsw = "Bond";

            Game game = new Game(title, platform);
            User user = new User(userEmail, userPsw, userPsw);

            UserManager.RegisterRequest(user);
            GameManager.AddGameToLibrary(game, user);

            //Now for the test
            GameManager.DeleteFromLibrary(title, platform, userEmail);
        }
    }
}
