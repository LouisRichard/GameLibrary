namespace GameLibrary
{
    partial class MyLibrary
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLibrary));
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmdAddAGame = new System.Windows.Forms.Button();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblUsername.Location = new System.Drawing.Point(500, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(261, 29);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "example@domain.com\r\n";
            // 
            // cmdAddAGame
            // 
            this.cmdAddAGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmdAddAGame.Location = new System.Drawing.Point(50, 700);
            this.cmdAddAGame.Name = "cmdAddAGame";
            this.cmdAddAGame.Size = new System.Drawing.Size(150, 50);
            this.cmdAddAGame.TabIndex = 1;
            this.cmdAddAGame.Text = "Add a game";
            this.cmdAddAGame.UseVisualStyleBackColor = true;
            this.cmdAddAGame.Click += new System.EventHandler(this.AddAGame);
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.Location = new System.Drawing.Point(50, 75);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.Size = new System.Drawing.Size(700, 600);
            this.dgvLibrary.TabIndex = 3;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmdEdit.Location = new System.Drawing.Point(215, 700);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(150, 50);
            this.cmdEdit.TabIndex = 4;
            this.cmdEdit.Text = "Edit a game";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmdDelete.Location = new System.Drawing.Point(380, 700);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(100, 50);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // MyLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.dgvLibrary);
            this.Controls.Add(this.cmdAddAGame);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyLibrary";
            this.Text = "My library";
            this.Load += new System.EventHandler(this.MyLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button cmdAddAGame;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDelete;
    }
}