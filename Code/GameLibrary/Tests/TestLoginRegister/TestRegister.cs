using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
using DataManager;

namespace TestLoginRegister
{
    [TestClass]
    public class TestRegister
    {
        [TestMethod]
        public void TestRegisterUserThatDoesntExist()
        {
            string testUserEmail = "testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool success = false;

            success = UserManager.RegisterRequest(testUserEmail, testUserPassword, testUserPasswordConfirm);
            
            Assert.AreEqual(success, true);
        }
    }
}
