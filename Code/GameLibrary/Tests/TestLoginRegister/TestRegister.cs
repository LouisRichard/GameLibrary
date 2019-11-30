using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;
using DatabaseManager;

namespace TestLoginRegister
{ 
    [TestClass]
    public class TestRegister
    {
        [TestInitialize]
        public void RemoveDatabase()
        {
            string query = @"DELETE FROM [Users] WHERE 'email' = 'testuser@domain.ch'";
            ExecuteQuery.Delete(query);
        }

        [TestMethod]
        public void TestRegisterUserThatDoesntExist()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool success = false;

            success = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);

            Assert.AreEqual(success, true);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Data.SQLite.SQLiteException))]
        public void TestRegisterUserThatAlreadyExist()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool register = false;
            bool registerSame = false;

            register = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
            registerSame = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterButPasswordsArentTheSame()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "NotTheSamePassword";
            bool success = false;

            success = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
        }
    }
}
