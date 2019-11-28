using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// This class represents the view of the user (Login ⊕ Register)
    /// </summary>
    public class StatusLoginRegister
    {
        private bool status;

        /// <summary>
        /// status accessors
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

        /// <summary>
        /// status constructor with a parameter
        /// </summary>
        public StatusLoginRegister(bool status)
        {
            this.status = status;
        }
    }
}
