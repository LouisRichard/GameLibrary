using System;
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

        #endregion formLoad

        #region dynamicForm events

        /// <summary>
        /// This method is used to toggle the view of the form.
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            lib.Status ^= true;
            lblError.Text = "";

            lblTitle.Text = lib.Status ? "Register" : "Login";
            btnChange.Text = lib.Status ? "Go login" : "Go register";
            btnSignIn.Text = lib.Status ? "Sign Up" : "Sign In";
            this.Text = lib.Status ? "Register" : "Login";
            this.btnSignIn.Click += lib.Status ? new System.EventHandler(this.Register) : new System.EventHandler(this.Login);

            lblRePassword.Visible = lib.Status;
            txtRePassword.Visible = lib.Status;

        }

        #endregion dynamic form

        #region signIn signUp methods

        /// <summary>
        /// This method sign the user. Depending on the status, it will add or authentifiate the user on the database.
        /// </summary>
        private void Register(object sender, EventArgs e)
        {
            lblError.Text = "";
            user = new User(txtEmail.Text, txtPassword.Text, txtRePassword.Text);

            txtEmail.BackColor = lib.CheckMail(txtEmail.Text);
            txtPassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);
            txtRePassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);

            try
            {
                loginRegisterSuccess = UserManager.RegisterRequest(user.Username, user.Password, user.RePassword);
            }
            catch (DbException except) { lblError.Text = $"{except.Message}"; }
            catch (LoginRegisterException except) { lblError.Text = $"{except.Message}"; }

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

        /// <summary>
        /// This method sign the user. Depending on the status, it will add or authentifiate the user on the database.
        /// </summary>
        private void Login(object sender, EventArgs e)
        {
            lblError.Text = "";
            user = new User(txtEmail.Text, txtPassword.Text, txtRePassword.Text);

            txtEmail.BackColor = lib.CheckMail(txtEmail.Text);
            txtPassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);

            try
            {
                loginRegisterSuccess = UserManager.LoginRequest(user.Username, user.Password);
            }
            catch (DbException except) { lblError.Text = $"{except.Message}"; }
            catch (LoginRegisterException except) { lblError.Text = $"{except.Message}"; }

            if (loginRegisterSuccess)
            {
                this.Hide();
                formLibrary.User = user;
                formLibrary.ShowDialog();
                this.Close();
            }
        }

        #endregion signIn signUp methods

        #region F****NG CODE
        #region dont evaluate this, its not a functionning part of the project...
        #region seriously
        /// These lines separate the
        ///     Serious Business Code,
        ///     the SBC 
        ///         from the
        ///             Funny but Organized and Obliously Out Of Nonsense Gratifying CODE,
        ///             the F****NG CODE.
        ///             
        /// If you continue as a reader,
        /// have fun :D
        ///     but if you continue as our Product Owner,
        ///     please respect our imagination and don't be harsh on coding this kind of stuff :)
        #region whats here?
        /// <summary>
        /// DONT LOOK UP HERE ! GO AWAY...
        /// .....
        /// Welp now it's found.
        /// </summary>
        private void LoginRegister_DoubleClick(object sender, EventArgs e)
        {
            if (lblLlabel1.Location.Y > 60) { lblLlabel1.Top -= 20; }
        }
        #endregion whats here?
        #endregion
        #endregion
        #endregion
    }
}