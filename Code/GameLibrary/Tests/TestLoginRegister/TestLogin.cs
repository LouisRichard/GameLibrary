using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    /// <summary>
    /// This class fully tests the login functionnality.
    /// </summary>
    [TestClass]
    public class TestLogin
    {
        #region Test login

        /// <summary>
        /// This test is for a not valid email.
        /// </summary>
        [TestMethod]
        public void TestEmailNotValid()
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            string notValidEmail = "Not So Valid Email, Is It?";
            bool valid = lib.ValidMail(notValidEmail);

            Assert.AreEqual(valid, false);
        }

        /// <summary>
        /// This test is for a valid email.
        /// </summary>
        [TestMethod]
        public void TestEmailValid()
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            string validEmail = "veryvalid@email.com";
            bool valid = lib.ValidMail(validEmail);

            Assert.AreEqual(valid, true);
        }

        /// <summary>
        /// This test is for a working login process.
        /// </summary>
        [TestMethod]
        public void LoginWithCorrectParameters()
        {
            //If this test fails, try deleting your GLdb.db3 file in Code\GameLibrary\Tests\TestLoginRegister\bin\Debug
            string email = "testlogin1@domain.ch";
            string password = "Pa$$w0rd";
            //insert the user in the database
            _ = UserManager.RegisterRequest(email, password, password);

            //Tries to log in
            bool success = UserManager.LoginRequest(email, password);

            Assert.AreEqual(true, success);
        }

        /// <summary>
        /// This test is for login but with a non-existing user. It expects an UserDoesntExistException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserDoesntExistException))]
        public void TestLoginUserThatdoesntExist()
        {
            string email = "thisuserdoesnotexist@sad.co.uk";
            string password = "whatever";

            bool success = UserManager.LoginRequest(email, password);
        }

        /// <summary>
        /// This test is for login but with the wrong password. It expects a WrongPasswordException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(WrongPasswordException))]
        public void TestLoginUserWithWrongPassword()
        {
            //If this test fails, try deleting your GLdb.db3 file in Code\GameLibrary\Tests\TestLoginRegister\bin\Debug
            string email = "testlogin3@domain.ch";
            string password = "theRightPassword";
            string wrongPassword = "ExcuseMeWhaaaaat?";

            _ = UserManager.RegisterRequest(email, password, password);

            bool success = UserManager.LoginRequest(email, wrongPassword);
        }

        /// <summary>
        /// This test is for login without filling the password field. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void TestLoginWithoutPassword()
        {
            string email = "testLogin4@domain.ch";
            string emptyPassword = "";


            bool success = UserManager.LoginRequest(email, emptyPassword);
        }

        /// <summary>
        /// This test is for login without filling the email field. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void TestLoginWithoutEmail()
        {
            string email = "";
            string password = "whatever";

            bool success = UserManager.LoginRequest(email, password);
        }
        #endregion
    }
}
