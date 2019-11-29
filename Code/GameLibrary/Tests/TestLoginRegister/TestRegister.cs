
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{ 
    [TestClass]
    public class TestRegister
    {
        [TestCleanup]
        public void RemoveDatabase()
        {
            File.Delete(Path.Combine(
                        Directory.GetCurrentDirectory(), "GLdb.db3"));
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
        public void TestRegisterUserThatAlreadyExist()
        {

        }

        [TestMethod]
        public void TestRegisterTwiceSameUser()
        {

        }
    }
}
