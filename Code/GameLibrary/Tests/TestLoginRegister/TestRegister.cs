using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;
using DatabaseManager;

namespace TestLoginRegister
{ 
    [TestClass]
    #region Test register
    public class TestRegister
    {
        [TestMethod]
        public void TestRegisterUserThatDoesntExist()
        {
            //If this test fails, try deleting your GLdb.db3 file in Code\GameLibrary\Tests\TestLoginRegister\bin\Debug
            string testUserEmail = @"testregister1@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool success = false;

            success = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);

            Assert.AreEqual(success, true);
        }

        [TestMethod]
        [ExpectedException(typeof(UserAldreadyExistsException))]
        public void TestRegisterUserThatAlreadyExist()
        {
            string testUserEmail = @"testregister2@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool register = false;
            bool registerSame = false;

            register = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
            registerSame = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordDontMatchException))]
        public void TestRegisterButPasswordsArentTheSame()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "NotTheSamePassword";
            bool success = false;

            success = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void TestRegiserWithoutEmail()
        {
            string testUserEmail = "";
            string password = "root";

            bool success = UserManager.RegisterRequest(testUserEmail, password, password);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutPasswords()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "";

            bool success = UserManager.RegisterRequest(testUserEmail, password, password);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutConfirmPassword()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "Password";
            string confirm = "";

            bool success = UserManager.RegisterRequest(testUserEmail, password, confirm);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutPasswordWithConfirm()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "";
            string confirm = "confirmPassword";

            bool success = UserManager.RegisterRequest(testUserEmail, password, confirm);
        }
    #endregion
    }
}
