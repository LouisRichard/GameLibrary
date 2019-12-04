using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class User
    {
        #region attributes

        private string username;
        private string password;
        private string rePassword;

        #endregion attributes

        #region accessors

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public string RePassword
        {
            get
            {
                return rePassword;
            }
            set
            {
                this.rePassword = value;
            }
        }

        #endregion accessors
    }
}
