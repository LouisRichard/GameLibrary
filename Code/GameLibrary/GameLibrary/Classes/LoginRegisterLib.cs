using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// This class will have different methods used in the login/register process
    /// </summary>
    public class LoginRegisterLib
    {
        #region attributes

        private bool status;
        private Point loginLocation = new Point();
        private Point registerValidLocation = new Point();

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

        #region constructors

        

        #endregion constructors

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

        /// <summary>
        /// This method returns register valid window location
        /// </summary>
        /// <returns>Point structure: the position of the register valid window</returns>
        public Point RegisterValidLocation()
        {
            registerValidLocation.X = this.LoginLocation().X;
            registerValidLocation.Y = this.LoginLocation().Y+50;

            return registerValidLocation;
        }

        #endregion public methods

    }
}
