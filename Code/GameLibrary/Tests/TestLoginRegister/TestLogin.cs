using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void TestEmailNotValid()
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            string notValidEmail = "Not So Valid Email, Is It?";
            bool valid = lib.ValidMail(notValidEmail);

            Assert.AreEqual(valid, false);
        }

        [TestMethod]
        public void TestEmailValid()
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            string validEmail = "veryvalid@email.com";
            bool valid = lib.ValidMail(validEmail);

            Assert.AreEqual(valid, true);
        }
    }
}
