using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    public partial class LoginRegister : Form
    {
        #region attributes

        private MyLibrary formLibrary = new MyLibrary();
        private RegisterValid formRegisterValid = new RegisterValid();
        private LoginRegisterLib lib = new LoginRegisterLib();
        private User user = new User();
        private bool loginRegisterSuccess;

        #endregion attributes

        #region formLoad

        public LoginRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method loads the user preferences during the load of the window
        /// </summary>
        private void LoginRegister_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(lib.LoginLocation().X, lib.LoginLocation().Y);
        }
        private void LoginRegister_FormClosing(object sender, FormClosedEventArgs e)
        {

        }

        #endregion formLoad

        #region dynamicForm events

        /// <summary>
        /// This method is used to dynamically toggle the view of the form
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            lib.Status ^= true;
            lblError.Text = "";

            if (lib.Status)
            {
                //register view
                lblTitle.Text = "Register";
                btnChange.Text = "Go login";
                btnSignIn.Text = "Sign up";
                this.Text = "Register";

                lblRePassword.Visible = true;
                txtRePassword.Visible = true;
            }
            else
            {
                //login view
                lblTitle.Text = "Login";
                btnChange.Text = "Go register";
                btnSignIn.Text = "Sign in";
                this.Text = "Login";

                lblRePassword.Visible = false;
                txtRePassword.Visible = false;
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
            else if (txtEmail.Text == "")
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
            if (lib.Status)
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
            else if (txtPassword.Text == "")
            {
                txtPassword.BackColor = Color.Crimson;
            }
            else
            {
                txtPassword.BackColor = Color.White;
            }
        }

        /// <summary>
        /// this method test if the confirm password textbox is well formatted
        /// </summary>
        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == txtRePassword.Text && lib.Status))
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

        #endregion dynamic form

        #region signIn signUp methods

        /// <summary>
        /// This method sign the user. Depending on the status, it will add or authentifiate the user on the database.
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            user.Username = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.RePassword = txtRePassword.Text;

            if (lib.Status)
            {
                try
                {
                    loginRegisterSuccess = UserManager.RegisterRequest(user.Username, user.Password, user.RePassword);
                }
                catch
                {
                    //!!//add exception text
                    //lblError.Text = $"{}";
                }

                if (loginRegisterSuccess)
                {
                    this.Hide();
                    formRegisterValid.User = user;
                    formRegisterValid.Lib = lib;
                    formRegisterValid.ShowDialog(this);
                    formLibrary.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                try
                {
                    loginRegisterSuccess = UserManager.LoginRequest(user.Username, user.Password);
                }
                catch (FailedDatabaseConnectionException exception)
                {
                    lblError.Text = $"{exception}";
                }

                if (loginRegisterSuccess)
                {
                    this.Hide();
                    formLibrary.ShowDialog();
                    this.Close();
                }

            }
        }

        #endregion signIn signUp methods

        /// <summary>
        /// This method save the position of the window
        /// </summary>
        private void LoginRegister_Move(object sender, EventArgs e)
        {

        }

    }
}
