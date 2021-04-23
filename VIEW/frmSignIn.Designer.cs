
namespace VIEW
{
    partial class frmSignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSignInUsername = new System.Windows.Forms.TextBox();
            this.lblSignInUsername = new System.Windows.Forms.Label();
            this.lblSignInPass = new System.Windows.Forms.Label();
            this.txtSignInPass = new System.Windows.Forms.TextBox();
            this.chkRemberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSignInToFrmSignUp = new System.Windows.Forms.Button();
            this.picUserLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLogin.Location = new System.Drawing.Point(62, 273);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(313, 36);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login to Your Account";
            // 
            // txtSignInUsername
            // 
            this.txtSignInUsername.Location = new System.Drawing.Point(23, 367);
            this.txtSignInUsername.Name = "txtSignInUsername";
            this.txtSignInUsername.Size = new System.Drawing.Size(377, 22);
            this.txtSignInUsername.TabIndex = 1;
            this.txtSignInUsername.TextChanged += new System.EventHandler(this.txtSignInUsername_TextChanged);
            // 
            // lblSignInUsername
            // 
            this.lblSignInUsername.AutoSize = true;
            this.lblSignInUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignInUsername.Location = new System.Drawing.Point(20, 336);
            this.lblSignInUsername.Name = "lblSignInUsername";
            this.lblSignInUsername.Size = new System.Drawing.Size(77, 18);
            this.lblSignInUsername.TabIndex = 2;
            this.lblSignInUsername.Text = "Username";
            // 
            // lblSignInPass
            // 
            this.lblSignInPass.AutoSize = true;
            this.lblSignInPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignInPass.Location = new System.Drawing.Point(20, 404);
            this.lblSignInPass.Name = "lblSignInPass";
            this.lblSignInPass.Size = new System.Drawing.Size(75, 18);
            this.lblSignInPass.TabIndex = 4;
            this.lblSignInPass.Text = "Password";
            // 
            // txtSignInPass
            // 
            this.txtSignInPass.Location = new System.Drawing.Point(23, 434);
            this.txtSignInPass.Name = "txtSignInPass";
            this.txtSignInPass.PasswordChar = '•';
            this.txtSignInPass.Size = new System.Drawing.Size(377, 22);
            this.txtSignInPass.TabIndex = 3;
            this.txtSignInPass.UseSystemPasswordChar = true;
            // 
            // chkRemberMe
            // 
            this.chkRemberMe.AutoSize = true;
            this.chkRemberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemberMe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkRemberMe.Location = new System.Drawing.Point(23, 467);
            this.chkRemberMe.Name = "chkRemberMe";
            this.chkRemberMe.Size = new System.Drawing.Size(141, 24);
            this.chkRemberMe.TabIndex = 5;
            this.chkRemberMe.Text = "Remember me";
            this.chkRemberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(85, 528);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.White;
            this.btnForgotPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnForgotPass.Location = new System.Drawing.Point(229, 467);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(171, 32);
            this.btnForgotPass.TabIndex = 7;
            this.btnForgotPass.Text = "Forgot Password?";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(411, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(14, 13);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnSignInToFrmSignUp
            // 
            this.btnSignInToFrmSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnSignInToFrmSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInToFrmSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignInToFrmSignUp.Location = new System.Drawing.Point(85, 577);
            this.btnSignInToFrmSignUp.Name = "btnSignInToFrmSignUp";
            this.btnSignInToFrmSignUp.Size = new System.Drawing.Size(254, 37);
            this.btnSignInToFrmSignUp.TabIndex = 10;
            this.btnSignInToFrmSignUp.Text = "Sign Up";
            this.btnSignInToFrmSignUp.UseVisualStyleBackColor = false;
            this.btnSignInToFrmSignUp.Click += new System.EventHandler(this.btnSignInToFrmSignUp_Click);
            // 
            // picUserLogin
            // 
            this.picUserLogin.Image = global::VIEW.Properties.Resources.userlogin;
            this.picUserLogin.Location = new System.Drawing.Point(113, 53);
            this.picUserLogin.Name = "picUserLogin";
            this.picUserLogin.Size = new System.Drawing.Size(226, 188);
            this.picUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserLogin.TabIndex = 8;
            this.picUserLogin.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 626);
            this.Controls.Add(this.btnSignInToFrmSignUp);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.picUserLogin);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRemberMe);
            this.Controls.Add(this.lblSignInPass);
            this.Controls.Add(this.txtSignInPass);
            this.Controls.Add(this.lblSignInUsername);
            this.Controls.Add(this.txtSignInUsername);
            this.Controls.Add(this.lblLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSignIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSignIn_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSignInUsername;
        private System.Windows.Forms.Label lblSignInUsername;
        private System.Windows.Forms.Label lblSignInPass;
        private System.Windows.Forms.TextBox txtSignInPass;
        private System.Windows.Forms.CheckBox chkRemberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.PictureBox picUserLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSignInToFrmSignUp;
    }
}

