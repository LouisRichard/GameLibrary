using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    /// <summary>
    /// This class represents the view of the user (Login ⊕ Register)
    /// </summary>
    public class StatusLoginRegister
    {
        private bool status;

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
    }
}
