using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    /// <summary>
    /// This class tests the password encryption functionnality.
    /// </summary>
    [TestClass]
    public class TestPasswordEncryption
    {

        /// <summary>
        /// This test is for making sure the encryption process works.
        /// </summary>
        [TestMethod]
        public void TestCryptPassword()
        {
            CryptoPassword crypto = new CryptoPassword();

            string clearPassword = "BasicPa$$w0rd";
            string encryptedPassword = crypto.Hash(clearPassword);

            Assert.AreNotEqual(clearPassword, encryptedPassword);
        }

        /// <summary>
        /// This test is for verifying that we can recognize an encrypted password.
        /// </summary>
        [TestMethod]
        public void TestPasswordVerifyWithGoodPassword()
        {
            CryptoPassword crypto = new CryptoPassword();

            string clearPassword = "basicPa$$w0rd";
            string encryptedPassword = crypto.Hash(clearPassword);

            bool verify = crypto.Verify(clearPassword, encryptedPassword);

            Assert.AreEqual(true, verify);
        }

        /// <summary>
        /// This test is for verifying that we can differentiate an encrypted password and a password that isn't the one encrypted.
        /// </summary>
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

        /// <summary>
        /// This test is for verifying that the random salt is not the same twice in a row.
        /// </summary>
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
