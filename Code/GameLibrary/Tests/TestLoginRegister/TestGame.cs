﻿using System;
using System.Text;
using System.Collections.Generic;
using DataManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLoginRegister
{
    /// <summary>
    /// Description résumée pour TestGame
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
        public void AddAGameWithoutTitle()
        {
            string title = "";
            string platform = "Nintendont 69";

            //TODO
        }
    }
}