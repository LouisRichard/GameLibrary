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
        private Point windowLocation = new Point();

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

        s

        #endregion constructors

        #region public methods

        /// <summary>
        /// Check if a mail is valid
        /// </summary>
        /// <param name="email">string value: the mail that must be checked</param>
        /// <returns>boolean value: true if the mail is valid, false if it isnt</returns>
        public bool ValidMail(string email)
        {
            //This regex has been made by "PaRiMaL RaJ" and "mafafu"
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// This method gets the user preferences for the login window location
        /// </summary>
        /// <returns>Point structure: the position of the window</returns>
        public Point GetLoginLocation()
        {
            windowLocation.X = 800;
            windowLocation.Y = 400;

            return windowLocation;
        }

        #endregion public methods

    }
}
