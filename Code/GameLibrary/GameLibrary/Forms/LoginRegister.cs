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
        public StatusLoginRegister view = new StatusLoginRegister(false);

        public LoginRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to dynamically change the view of the form
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (view.Status)
            {
                //goes to login view
                view.Status = false;
            }
            else
            {
                //goes to register view
                view.Status = true;
            }

            if (view.Status)
            {
                //register view
                lblTitle.Text = "Register";
                btnChange.Text = "Go login";
                btnSignIn.Text = "Sign up";

                lblRePassword.Visible = true;
                txtRePassword.Visible = true;
            }
            else
            {
                //login view
                lblTitle.Text = "Login";
                btnChange.Text = "Go register";
                btnSignIn.Text = "Sign in";

                lblRePassword.Visible = false;
                txtRePassword.Visible = false;
            }
        }

        /// <summary>
        /// This method sign the user. Depending on the register attribute, it will add or authentifiate the user on the database.
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //!!//make every textboxes normal

            //!!//check that every field is filled

            if (view.Status)
            {
                //!!//sends register view

                //!!//if the user has been correctly added to DB, shows RegisterValid form

            }
            else
            {
                //!!//sends login view

            }
        }
    }
}
