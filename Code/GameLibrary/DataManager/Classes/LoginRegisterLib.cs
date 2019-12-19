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
        /// The color that a field needs to take during some processes.
        /// </summary>
        private Color fieldColor;

        #endregion attributes

        #region accessors

        /// <summary>
        /// The status of the view. True for register and false for login.
        /// </summary>
        public bool Status { get; set; }

        #endregion accessors

        #region public methods

        /// <summary>
        /// Check if a mail is valid
        /// </summary>
        /// <param name="email">the mail that must be checked</param>
        /// <returns>true if the mail is valid, false if it isnt</returns>
        /// <remarks>This regex has been found on StackOverflow. It has been posted by "PaRiMaL RaJ" and "mafafu".</remarks>
        public bool ValidMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// This method tests if the email textbox is well formatted.
        /// </summary>
        /// <param name="email">the email in the email textbox</param>
        /// <returns>the color that the email field has to take</returns>
        public Color CheckMail(string email)
        {
            fieldColor = !ValidMail(email) || email == "" ?
                Color.Crimson : Color.White;
            return fieldColor;
        }

        /// <summary>
        /// This the different condition that password textboxes should pass.
        /// </summary>
        /// <param name="password">the password in the password textbox</param>
        /// <param name="rePassword">the password confirmed in the confirm your password textbox</param>
        /// <param name="status">the status of the view. True for Register</param>
        /// <returns>the color that password fields have to take</returns>
        public Color CheckPassword(string password, string rePassword, bool status)
        {
            fieldColor = password == "" ?
                Color.Crimson : Color.White;
            if (status)
            {
                fieldColor = password != rePassword || password == "" || rePassword == "" ?
                    Color.Crimson : Color.White;
            }
            return fieldColor;
        }

        #endregion public methods
    }
}
