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
            "1292 Advanced Programmable Video System",
            "3DO/Matsushita M2",
            "Active Enterprises Action Gamemaster",
            "Atari 2600 CE",
            "Atari 2600 VCSp",
            "Atari 2600 Video Computer System",
            "Atari Lynx",
            "Bally Professional Arcade/Astrocade",
            "Bankzilla",
            "Barcode Battler",
            "Bit Corporation Gamate",
            "Bit Corporation Gamate Color",
            "Coleco Adam",
            "ColecoVision",
            "DataMax UV-1",
            "Fujitsu FM Towns Marty/FM Towns Marty 2",
            "GamePark 32",
            "Hasbro Pox",
            "Indrema Entertainment System",
            "Infinium Labs Phantom",
            "Interton VC-4000",
            "iQue Player",
            "Konix Multisystem",
            "Magnavox Odyssey",
            "Mega Duck Super Junior Computer",
            "Mega Duck/Cougar Boy",
            "Microsoft Xbox",
            "Microsoft Xbox 360",
            "Nintendo 64",
            "Nintendo 64 Dynamic Drive",
            "Nintendo DS",
            "Nintendo Entertainment System/Famicom",
            "Nintendo Famicom Disk System",
            "Nintendo Game & Watch",
            "Nintendo GameBoy Advance/GameBoy Advance SP",
            "Nintendo GameBoy Color",
            "Nintendo GameBoy Evolution",
            "Nintendo GameBoy/GameBoy Pocket",
            "Nintendo GameCube",
            "Nintendo Pokémon Mini",
            "Nintendo Super NES/Super Famicom",
            "Nintendo Virtual Boy",
            "Nintendo Wii",
            "Nokia N-Gage/N-Gage QD",
            "NPES",
            "Panasonic 3DO Interactive Multiplayer FZ-",
            "Portendo",
            "PSp",
            "Puma 2600",
            "Sega 32X",
            "Sega Dreamcast",
            "Sega Dreamcast Visual Memory Unit",
            "Sega Game Gear",
            "Sega Master System/SG-1000 Mark III",
            "Sega Mega CD/Sega CD",
            "Sega Mega Drive/Genesis",
            "Sega Mega Jet",
            "Sega Neptune",
            "Sega Nomad",
            "Sega Pico",
            "Sega Saturn",
            "Sega SC-3000",
            "Sega SG-1000",
            "Sega Triforce",
            "SNES CD-ROM",
            "SNESp",
            "Sony PlayStation 2",
            "Sony PlayStation 3",
            "Sony PlayStation PocketStation",
            "Sony PlayStation Portable",
            "Sony PlayStation/PSOne",
            "Super Cassette Vision",
            "Supervision",
            "Tapwave Zodiac",
            "Tiger Telematics Gizmondo",
            "Time Top GameKing",
            "V-Tech V.Smile",
            "Video Driver",
            "ZGrass Computer Expansion Module"});
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