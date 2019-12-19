using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManager;

namespace TestLoginRegister
{
    #region Test register

    /// <summary>
    /// This class fully tests the register functionnality.
    /// </summary>
    [TestClass]
    public class TestRegister
    {
        /// <summary>
        /// This test is for register a new user.
        /// </summary>
        [TestMethod]
        public void TestRegisterUserThatDoesntExist()
        {
            //If this test fails, try deleting your GLdb.db3 file in Code\GameLibrary\Tests\TestLoginRegister\bin\Debug
            string testUserEmail = @"testregister1@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            User user = new User(testUserEmail, testUserPassword, testUserPasswordConfirm);
            bool success = false;

            success = UserManager.RegisterRequest(user);

            Assert.AreEqual(success, true);
        }

        /// <summary>
        /// This test is for register an already existing user. It expects an UserAldreadyExistsException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserAldreadyExistsException))]
        public void TestRegisterUserThatAlreadyExist()
        {
            string testUserEmail = @"testregister2@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "password";
            User user = new User(testUserEmail, testUserPassword, testUserPasswordConfirm);
            bool register = false;
            bool registerSame = false;

            register = UserManager.RegisterRequest(user);
            registerSame = UserManager.RegisterRequest(user);
        }

        /// <summary>
        /// This test is for register with non-matching passwords. It expects a PasswordDontMatchException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PasswordDontMatchException))]
        public void TestRegisterButPasswordsArentTheSame()
        {
            string testUserEmail = @"testuser@domain.ch";
            string testUserPassword = "password";
            string testUserPasswordConfirm = "NotTheSamePassword";
            User user = new User(testUserEmail, testUserPassword, testUserPasswordConfirm);
            bool success = false;

            success = UserManager.RegisterRequest(user);
        }

        /// <summary>
        /// This test is for register without an email. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void TestRegiserWithoutEmail()
        {
            string testUserEmail = "";
            string password = "root";
            User user = new User(testUserEmail, password, password);

            bool success = UserManager.RegisterRequest(user);
        }

        /// <summary>
        /// This test is for register without passwords. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutPasswords()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "";
            User user = new User(testUserEmail, password, password);

            bool success = UserManager.RegisterRequest(user);
        }

        /// <summary>
        /// This test is for register without confirming the password. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutConfirmPassword()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "Password";
            string confirm = "";
            User user = new User(testUserEmail, password, confirm);
            bool success = UserManager.RegisterRequest(user);
        }

        /// <summary>
        /// This test is for register without a password. It expects an EmptyFieldException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyFieldException))]
        public void RegisterUserWithoutPasswordWithConfirm()
        {
            string testUserEmail = "testUser@domain.ch";
            string password = "";
            string confirm = "confirmPassword";
            User user = new User(testUserEmail, password, confirm);
            bool success = UserManager.RegisterRequest(user);
        }
    }

    #endregion Test register
}
