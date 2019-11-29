
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    [TestClass]
    public class TestRegister
    {
        [TestMethod]
        public void TestRegisterUserThatDoesntExist()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            bool success = false;

            //delete the database for further tests
            File.Delete(Path.Combine(
                        Directory.GetCurrentDirectory(), "GLdb.db3"));

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
