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
    public partial class RegisterValid : Form
    {
        private LoginRegisterLib lib = new LoginRegisterLib();

        public RegisterValid()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterValid_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(lib.RegisterValidLocation().X, lib.RegisterValidLocation().Y);

            //!!//modify the label to put the username
            //lblConfirm = $"{}, you're now registered.";
        }
    }
}
