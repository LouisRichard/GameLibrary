using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    [TestClass]
    public class TestPasswordEncryption
    {
        [TestMethod]
        public void TestCryptPassword()
        {
            CryptoPassword crypto = new CryptoPassword();

            string clearPassword = "BasicPa$$w0rd";
            string encryptedPassword = crypto.Hash(clearPassword);

            Assert.AreNotEqual(clearPassword, encryptedPassword);
        }

        [TestMethod]
        public void TestPasswordVerifyWithGoodPassword()
        {
            CryptoPassword crypto = new CryptoPassword();

            string clearPassword = "basicPa$$w0rd";
            string encryptedPassword = crypto.Hash(clearPassword);

            bool verify = crypto.Verify(clearPassword, encryptedPassword);

            Assert.AreEqual(true, verify);
        }

        [TestMethod]
        public void TestPasswordVerifyWithWrongPassword()
        {
            CryptoPassword crypto = new CryptoPassword();

            string actualPassword = "basicPa$$w0rd";
            string wrongPassword = "wrongPa$$w0rd";
            string encryptedPassword = crypto.Hash(actualPassword);

            bool verify = crypto.Verify(wrongPassword, encryptedPassword);

            Assert.AreEqual(false, verify);
        }

        [TestMethod]
        public void TestRandomSaltInEncryption()
        {
            CryptoPassword crypto = new CryptoPassword();

            string password = "Pa$$w0rd";
            string firstEncrypt = crypto.Hash(password);
            string secondEncrypt = crypto.Hash(password);

            Assert.AreNotEqual(firstEncrypt, secondEncrypt);
        }
    }
}
