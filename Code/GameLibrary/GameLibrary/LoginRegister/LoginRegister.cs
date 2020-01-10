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
        /// The login/register library of methods.
        /// </summary>
        private LoginRegisterLib lib = new LoginRegisterLib();
        /// <summary>
        /// The status of the login request or the register request. True if the request went well.
        /// </summary>
        private bool loginRegisterSuccess;
        /// <summary>
        /// The timer for passwords wildcards.
        /// </summary>
        private Timer timer = new Timer();
        /// <summary>
        /// The temporay variable for the password.
        /// </summary>
        private string password = "";

        #endregion attributes

        #region formLoad

        public LoginRegister()
        {
            InitializeComponent();
            this.Location = Properties.Settings.Default.Location;

            timer.Tick += new EventHandler(MaskPassword);
            timer.Interval = 1000;
        }

        #endregion formLoad

        #region dynamicForm events

        /// <summary>
        /// This method is used to toggle the view of the form.
        /// </summary>
        public void ToggleView(object sender, EventArgs e)
        {
            lib.Status ^= true;
            lblError.Text = "";

            lblTitle.Text = lib.Status ? "Register" : "Login";
            cmdToggle.Text = lib.Status ? "Go login" : "Go register";
            cmdSignIn.Text = lib.Status ? "Sign Up" : "Sign In";
            this.Text = lib.Status ? "Register" : "Login";
            this.cmdSignIn.Click += lib.Status ? new System.EventHandler(this.Register) : new System.EventHandler(this.Login);

            lblRePassword.Visible = lib.Status;
            txtRePassword.Visible = lib.Status;

        }

        private void LoginRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location= this.Location;
            Properties.Settings.Default.Save();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordChanged(txtPassword.Text);

            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            txtRePassword.Text = PasswordChanged(txtRePassword.Text);

            txtRePassword.Focus();
            txtRePassword.SelectionStart = txtRePassword.Text.Length;
        }

        /// <summary>
        /// Crypts every character but the last of the password and starts a timer.
        /// </summary>
        /// <param name="pass">The password field value</param>
        /// <returns>The string to display in the current password field</returns>
        private string PasswordChanged(string pass)
        {
            string tempPass = "";

            //store text
            if (password == "") //first char
            {
                password = pass;
            }
            else if (password.Length < pass.Length) //writting
            {
                password += pass.Substring(pass.Length - 1);
            }
            else if (password.Length > pass.Length) //erasing
            {
                password = password.Substring(0, password.Length - 1);
                if (password.Length != pass.Length) //if more than one character is deleted
                {
                    //we dont know whats written in the field
                }
            }

            //cryptate
            for (int i = 0; i < pass.Length - 1; i++)
            {
                tempPass += "•";
            }

            if (pass.Length != 0)
            {
                tempPass += pass.Substring(pass.Length - 1, 1);
            }

            //timer start
            timer.Start();

            return tempPass;
        }

        /// <summary>
        /// Crypts the final character of the password.
        /// </summary>
        private void MaskPassword(object sender, EventArgs e)
        {
            //cryptate password
            if (txtPassword.Text.Length == 1)
            {
                txtPassword.Text = "•";
            } else if (txtPassword.Text.Length != 0)
            {
                txtPassword.Text = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1) + "•";
            }

            //cryptate repassword
            if (txtRePassword.Text.Length == 1)
            {
                txtRePassword.Text = "•";
            } else if (txtRePassword.Text.Length != 0)
            {
                txtRePassword.Text = txtRePassword.Text.Substring(0, txtRePassword.Text.Length - 1) + "•";
            }

            timer.Stop();
        }

        #endregion dynamic form

        #region signIn signUp methods

        /// <summary>
        /// This method tries to register the user. If everything goes well, it will add the user on the database.
        /// </summary>
        public void Register(object sender, EventArgs e)
        {
            lblError.Text = "";
            User user = new User(txtEmail.Text, txtPassword.Text, txtRePassword.Text);

            txtEmail.BackColor = lib.CheckMail(txtEmail.Text);
            txtPassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);
            txtRePassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);

            try { loginRegisterSuccess = UserManager.RegisterRequest(user); }
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
        /// This method tries to login the user. If everything goes well, it will authentifiate the user on the database.
        /// </summary>
        public void Login(object sender, EventArgs e)
        {
            lblError.Text = "";
            User user = new User(txtEmail.Text, txtPassword.Text, txtRePassword.Text);

            txtEmail.BackColor = lib.CheckMail(txtEmail.Text);
            txtPassword.BackColor = lib.CheckPassword(txtPassword.Text, txtRePassword.Text, lib.Status);

            try
            {
                loginRegisterSuccess = UserManager.LoginRequest(user);
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
        public void DoubleClic(object sender, EventArgs e)
        {
            if (lblLlabel1.Location.Y > 60) { lblLlabel1.Top -= 20; }
        }
        #endregion whats here?

        #endregion

        #endregion

        #endregion

    }
}