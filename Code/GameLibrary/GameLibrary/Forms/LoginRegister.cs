using System;
using System.Drawing;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    /// <summary>
    /// This is the form from where you'll login/register.
    /// </summary>
    public partial class LoginRegister : Form
    {
        #region attributes

        /// <summary>
        /// MyLibrary form.
        /// </summary>
        private MyLibrary formLibrary = new MyLibrary();
        /// <summary>
        /// RegisterValid form.
        /// </summary>
        private RegisterValid formRegisterValid = new RegisterValid();
        /// <summary>
        /// The login-register library of methods.
        /// </summary>
        private LoginRegisterLib lib = new LoginRegisterLib();
        /// <summary>
        /// The user that wants to connect.
        /// </summary>
        private User user = new User();
        /// <summary>
        /// The status of the login request or the register request. True if they went well.
        /// </summary>
        private bool loginRegisterSuccess;

        #endregion attributes

        #region formLoad

        public LoginRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method loads the user preferences during the load of the window.
        /// </summary>
        private void LoginRegister_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(lib.LoginLocation().X, lib.LoginLocation().Y);
        }

        #endregion formLoad

        #region dynamicForm events

        /// <summary>
        /// This method is used to dynamically toggle the view of the form.
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            lib.Status ^= true;
            lblError.Text = "";

            lblTitle.Text = lib.Status ? "Register" : "Login";
            btnChange.Text = lib.Status ? "Go login" : "Go register";
            btnSignIn.Text = lib.Status ? "Sign Up" : "Sign In";
            this.Text = lib.Status ? "Register" : "Login";

            lblRePassword.Visible = lib.Status;
            txtRePassword.Visible = lib.Status;

        }

        /// <summary>
        /// This method test if the mail textbox is well formatted.
        /// </summary>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = !(lib.ValidMail(txtEmail.Text)) || txtEmail.Text == "" ?
                Color.Crimson : Color.White;
        }

        /// <summary>
        /// This method calls the txtEmail_TextChanged event.
        /// </summary>
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail_TextChanged(sender, e);
        }

        /// <summary>
        /// This method test if the password textbox is well formatted.
        /// </summary>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = txtPassword.Text == "" ?
                Color.Crimson : Color.White;

            if (lib.Status)
            {
                txtPassword.BackColor = txtPassword.Text != txtRePassword.Text || txtPassword.Text == "" ?
                    Color.Crimson : Color.White;
                txtRePassword.BackColor = txtPassword.Text != txtRePassword.Text || txtRePassword.Text == "" ?
                    Color.Crimson : Color.White;
            }

        }

        /// <summary>
        /// This method calls the txtPassword_TextChanged event.
        /// </summary>
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword_TextChanged(sender, e);
        }

        /// <summary>
        /// This method test if the confirm password textbox is well formatted.
        /// </summary>
        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = txtPassword.Text != txtRePassword.Text || txtPassword.Text == "" ?
                    Color.Crimson : Color.White;
            txtRePassword.BackColor = txtPassword.Text != txtRePassword.Text || txtRePassword.Text == "" ?
                Color.Crimson : Color.White;
        }

        /// <summary>
        /// This method calls the txtRePassword_TextChanged event.
        /// </summary>
        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            txtRePassword_TextChanged(sender, e);
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
                catch (LoginRegisterException except)
                {
                    if (except is NotValidEmailException || except is EmptyFieldException ||
                        except is UserAldreadyExistsException || except is PasswordDontMatchException)
                    { lblError.Text = $"{except.Message}"; }
                }
                catch (FailedDatabaseConnectionException except) { lblError.Text = $"{except.Message}"; }

                if (loginRegisterSuccess)
                {
                    this.Hide();
                    formRegisterValid.User = user;
                    formRegisterValid.ShowDialog(this);
                    
                    formLibrary.User = user;
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
                catch (LoginRegisterException except)
                {
                    if (except is NotValidEmailException || except is EmptyFieldException ||
                        except is UserDoesntExistException || except is WrongPasswordException)
                    { lblError.Text = $"{except.Message}"; }
                }
                catch (FailedDatabaseConnectionException except) { lblError.Text = $"{except.Message}"; }

                if (loginRegisterSuccess)
                {
                    this.Hide();
                    formLibrary.User = user;
                    formLibrary.ShowDialog();
                    this.Close();
                }

            }
        }

        #endregion signIn signUp methods

        /// <summary>
        /// This method save the position of the window.
        /// </summary>
        private void LoginRegister_Move(object sender, EventArgs e)
        {

        }

        #region dont evaluate this, its not a functionning part of the project...
        #region seriously
        /// <summary>
        /// DONT LOOK UP HERE ! GO AWAY...
        /// .....
        /// Welp now it's found.
        /// </summary>
        private void LoginRegister_DoubleClick(object sender, EventArgs e)
        {
            if (lblLlabel1.Location.Y > 60) { lblLlabel1.Top -= 20; }
        }
        #endregion
        #endregion
    }
}