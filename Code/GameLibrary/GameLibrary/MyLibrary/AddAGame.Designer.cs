namespace GameLibrary
{
    partial class AddAGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAGame));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboPlatform = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitle.Location = new System.Drawing.Point(25, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title :";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPlatform.Location = new System.Drawing.Point(25, 63);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(86, 22);
            this.lblPlatform.TabIndex = 1;
            this.lblPlatform.Text = "Platform :";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTitle.Location = new System.Drawing.Point(150, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(600, 27);
            this.txtTitle.TabIndex = 2;
            // 
            // cboPlatform
            // 
            this.cboPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboPlatform.FormattingEnabled = true;
            this.cboPlatform.Items.AddRange(new object[] {
                "3DO Interactive Multiplayer",
                "Atari 2600 Video Computer System",
                "Atari 2600 CE",
                "Atari Lynx",
                "Casio Loopy",
                "ColecoVision",
                "Microsoft Xbox",
                "Microsoft Xbox 360",
                "Neo-Geo CD",
                "Nintendo Entertainment System",
                "Nintendo 64",
                "Nintendo DS",
                "Nintendo Famicom Disk System",
                "Nintendo Game & Watch",
                "Nintendo GameBoy",
                "Nintendo GameBoy Advance",
                "Nintendo GameBoy Color",
                "Nintendo GameCube",
                "Nintendo Pokémon Mini",
                "Nintendo Switch",
                "Nintendo Virtual Boy",
                "Nintendo Wii",
                "Nintendo Wii U",
                "Nokia N-Gage",
                "Sega 32X",
                "Sega Dreamcast",
                "Sega Game Gear",
                "Sega Master System",
                "Sega CD",
                "Sega Mega Drive",
                "Sega Saturn",
                "Sega Triforce",
                "Super NES",
                "Sony PlayStation",
                "Sony PlayStation 2",
                "Sony PlayStation 3",
                "Sony PlayStation 4",
                "Sony PlayStation Portable",
                "Vectrex"
            });
            this.cboPlatform.Location = new System.Drawing.Point(150, 64);
            this.cboPlatform.Name = "cboPlatform";
            this.cboPlatform.Size = new System.Drawing.Size(600, 21);
            this.cboPlatform.Sorted = true;
            this.cboPlatform.TabIndex = 3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmdCancel.Location = new System.Drawing.Point(650, 525);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 30);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmdConfirm.Location = new System.Drawing.Point(545, 525);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(100, 30);
            this.cmdConfirm.TabIndex = 5;
            this.cmdConfirm.Text = "Confirm";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(24, 523);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 29);
            this.lblError.TabIndex = 19;
            this.lblError.Text = ".";
            // 
            // AddAGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cboPlatform);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAGame";
            this.Load += new System.EventHandler(this.AddAGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboPlatform;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Label lblError;
    }
}