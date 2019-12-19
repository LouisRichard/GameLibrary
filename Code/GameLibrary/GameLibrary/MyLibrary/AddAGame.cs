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
    public partial class AddAGame : Form
    {

        #region formLoad

        public AddAGame()
        {
            InitializeComponent();
        }

        #endregion formLoad

        #region confirm-cancel

        /// <summary>
        /// This method sends the game to DataManager
        /// </summary>
        public void Confirm(object sender, EventArgs e)
        {


            Cancel(sender, e);
        }

        /// <summary>
        /// This method closes the form without sending any data.
        /// </summary>
        public void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion confirm-cancel
    }
}
