using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary
{
    public partial class LoginRegister : Form
    {
        /// <summary>
        /// register permits to change dynamically the view
        /// </summary>
        private bool register = false;


        public LoginRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to dynamically change the view of the form
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (register)
            {
                register = false;
            }
            else
            {
                register = true;
            }

            if (register)
            {
                //register
                lblTitle.Text = "Register";
                btnChange.Text = "Go login";
                btnSignIn.Text = "Sign up";

                lblRePassword.Visible = true;
                txtRePassword.Visible = true;
            }
            else
            {
                //login
                lblTitle.Text = "Login";
                btnChange.Text = "Go register";
                btnSignIn.Text = "Sign in";

                lblRePassword.Visible = false;
                txtRePassword.Visible = false;
            }
        }
    }
}
