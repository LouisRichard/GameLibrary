using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace GameLibrary
{
    /// <summary>
    /// This class will have different methods used in the login/register process
    /// </summary>
    public class LoginRegisterLib
    {
        /// <summary>
        /// Check if a mail is valid
        /// </summary>
        /// <param name="email">the mail that must be checked</param>
        /// <returns>boolean value: true if the mail is valid, false if it isnt</returns>
        public bool ValidMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public struct Point GetLoginLocation()
        {
            return
        }
    }
}
