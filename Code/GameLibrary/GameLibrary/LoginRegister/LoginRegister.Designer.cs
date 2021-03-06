﻿namespace GameLibrary
{
    partial class LoginRegister
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

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdToggle = new System.Windows.Forms.Button();
            this.cmdSignIn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.Location = new System.Drawing.Point(50, 225);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(272, 29);
            this.lblRePassword.TabIndex = 17;
            this.lblRePassword.Text = "Confirm your password :";
            this.lblRePassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(50, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(245, 29);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Enter your password :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(199, 29);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Enter your email :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblTitle.Location = new System.Drawing.Point(50, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 44);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Login";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(350, 220);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(300, 35);
            this.txtRePassword.TabIndex = 13;
            this.txtRePassword.Visible = false;
            this.txtRePassword.TextChanged += new System.EventHandler(this.txtRePassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(350, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 35);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(350, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 35);
            this.txtEmail.TabIndex = 11;
            // 
            // cmdToggle
            // 
            this.cmdToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdToggle.Location = new System.Drawing.Point(625, 25);
            this.cmdToggle.Name = "cmdToggle";
            this.cmdToggle.Size = new System.Drawing.Size(150, 50);
            this.cmdToggle.TabIndex = 10;
            this.cmdToggle.Text = "Go Register";
            this.cmdToggle.UseVisualStyleBackColor = true;
            this.cmdToggle.Click += new System.EventHandler(this.ToggleView);
            // 
            // cmdSignIn
            // 
            this.cmdSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSignIn.Location = new System.Drawing.Point(50, 280);
            this.cmdSignIn.Name = "cmdSignIn";
            this.cmdSignIn.Size = new System.Drawing.Size(125, 50);
            this.cmdSignIn.TabIndex = 9;
            this.cmdSignIn.Text = "Sign in";
            this.cmdSignIn.UseVisualStyleBackColor = true;
            this.cmdSignIn.Click += new System.EventHandler(this.Login);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(345, 291);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 29);
            this.lblError.TabIndex = 18;
            this.lblError.Text = ".";
            // 
            // lblLlabel1
            // 
            this.lblLlabel1.AutoSize = true;
            this.lblLlabel1.Location = new System.Drawing.Point(715, 650);
            this.lblLlabel1.Name = "lblLlabel1";
            this.lblLlabel1.Size = new System.Drawing.Size(61, 13);
            this.lblLlabel1.TabIndex = 19;
            this.lblLlabel1.Text = "Hello there.";
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblLlabel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmdToggle);
            this.Controls.Add(this.cmdSignIn);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::GameLibrary.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::GameLibrary.Properties.Settings.Default.Location;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "LoginRegister";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginRegister_FormClosing);
            this.DoubleClick += new System.EventHandler(this.DoubleClic);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdToggle;
        private System.Windows.Forms.Button cmdSignIn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLlabel1;
    }
}

