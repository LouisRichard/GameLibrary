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
        public LoginRegisterLib lib = new LoginRegisterLib();

        public LoginRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to dynamically change the view of the form
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            view.Status ^= true;

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

            try
            {

            }
            catch
            {
                
            }

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

        /// <summary>
        /// this method test if the mail textbox is well formatted
        /// </summary>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!(lib.ValidMail(txtEmail.Text)))
            {
                txtEmail.BackColor = Color.Crimson;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        /// <summary>
        /// this method test if the password textbox is well formatted
        /// </summary>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (view.Status)
            {
                if (!(txtPassword.Text == txtRePassword.Text))
                {
                    txtPassword.BackColor = Color.Crimson;
                    txtRePassword.BackColor = Color.Crimson;
                }
                else
                {
                    txtPassword.BackColor = Color.White;
                    txtRePassword.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// this method test if the confirm password textbox is well formatted
        /// </summary>
        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == txtRePassword.Text))
            {
                txtPassword.BackColor = Color.Crimson;
                txtRePassword.BackColor = Color.Crimson;
            }
            else
            {
                txtPassword.BackColor = Color.White;
                txtRePassword.BackColor = Color.White;
            }
        }
    }
}
