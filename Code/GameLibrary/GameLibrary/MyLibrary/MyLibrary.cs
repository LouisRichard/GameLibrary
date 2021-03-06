﻿using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    /// <summary>
    /// This form is main form of the program past the login-register process.
    /// </summary>
    public partial class MyLibrary : Form
    {
        #region attributes

        /// <summary>
        /// The user inherited from the login-register.
        /// </summary>
        private User user;
        /// <summary>
        /// AddAGame form.
        /// </summary>
        private AddAGame addAGame;
        /// <summary>
        /// The game selected by the user.
        /// </summary>
        private Game game;

        #endregion attributes

        #region accessors

        /// <summary>
        /// Contains the user information.
        /// </summary>
        public User User
        {
            set { user = value; }
        }

        #endregion accessors

        #region formLoad

        public MyLibrary()
        {
            InitializeComponent();
        }

        private void MyLibrary_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{user.Username}";
            DataTable dt = new DataTable();
            dt = GameManager.GetGameLibrary(user.Username);;

            dgvLibrary.DataSource = dt;
            dgvLibrary.AutoResizeColumn(1);
        }

        /// <summary>
        /// This method quits the program
        /// </summary>
        private void Quit(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion formLoad

        #region add, edit, delete

        /// <summary>
        /// This method launches the add a game form on top of the library.
        /// </summary>
        public void AddAGame(object sender, EventArgs e)
        {
            addAGame = new AddAGame("Add");
            addAGame.User = user;
            addAGame.ShowDialog(this);

            MyLibrary_Load(sender, e);
        }

        /// <summary>
        /// This method launches the edit a game form on top of the library.
        /// </summary>
        private void EditAGame(object sender, EventArgs e)
        {
            if(dgvLibrary.SelectedCells.Count > 0)
            {
                string title;
                string platform;

                string selectedCellValue = dgvLibrary.SelectedCells[0].Value.ToString();
                int rowIndex = dgvLibrary.CurrentCell.RowIndex;
                int columnIndex = dgvLibrary.CurrentCell.ColumnIndex;
                columnIndex = columnIndex == 0 ? columnIndex++ : columnIndex--;
                string otherCellValue = dgvLibrary.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                title = columnIndex == 0 ? otherCellValue : selectedCellValue;
                platform = columnIndex == 0 ? selectedCellValue : otherCellValue;

                game = new Game(title, platform);

                addAGame = new AddAGame("Edit");

                addAGame.Game = game;
                addAGame.User = user;
                
                addAGame.ShowDialog(this);
                MyLibrary_Load(sender, e);    
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Delete(object sender, EventArgs e)
        {
            if (dgvLibrary.SelectedCells.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure to delete this game ?", "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string cellValue = dgvLibrary.SelectedCells[0].Value.ToString();
                    int rowIndex = dgvLibrary.CurrentCell.RowIndex;
                    int columnIndex = dgvLibrary.CurrentCell.ColumnIndex;
                    if (columnIndex == 0)
                        columnIndex++;
                    else
                        columnIndex -= 1;
                    string otherCellValue = dgvLibrary.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                
                    if (columnIndex == 0)
                        GameManager.DeleteFromLibrary(otherCellValue, cellValue, user.Username);
                    else
                        GameManager.DeleteFromLibrary(cellValue, otherCellValue, user.Username);

                    MyLibrary_Load(sender, e);
                }
            }
        }

        #endregion actions
    }
}