using System.Drawing;
using System.Text.RegularExpressions;

namespace DataManager
{
    /// <summary>
    /// This class has different methods used in the login/register process.
    /// </summary>
    public class LoginRegisterLib
    {
        #region attributes

        /// <summary>
        /// The status of the view. True for register and false for login.
        /// </summary>
        private bool status;
        /// <summary>
        /// The location of the login window.
        /// </summary>
        private Point loginLocation = new Point();

        #endregion attributes

        #region accessors

        /// <summary>
        /// Status of the LoginRegister form
        /// </summary>
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                this.status = value;
            }
        }

        #endregion accessors

        #region public methods

        /// <summary>
        /// Check if a mail is valid
        /// </summary>
        /// <param name="email">string value: the mail that must be checked</param>
        /// <returns>boolean value: true if the mail is valid, false if it isnt</returns>
        public bool ValidMail(string email)
        {
            //This regex has been made by "PaRiMaL RaJ" and "mafafu" on StackOverflow
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// This method returns login-register window location from the last user preferences
        /// </summary>
        /// <returns>Point structure: the position of the login-regiser window</returns>
        public Point LoginLocation()
        {
            //loginLocation.X = json.JSONXLocation;
            //loginLocation.Y = json.JSONYLocation;
            loginLocation.X = 100;
            loginLocation.Y = 50;

            return loginLocation;
        }

        #endregion public methods

    }
}
