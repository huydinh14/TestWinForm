
namespace VIEW
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblSignUpUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbSignUpPass = new System.Windows.Forms.Label();
            this.txtSignUpPass = new System.Windows.Forms.TextBox();
            this.lblSignUpReEnterPass = new System.Windows.Forms.Label();
            this.txtSignUpReEnterPassword = new System.Windows.Forms.TextBox();
            this.lblSignUpEmail = new System.Windows.Forms.Label();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.lblSignUpReEnterEmail = new System.Windows.Forms.Label();
            this.txtSignUpReEnterEmail = new System.Windows.Forms.TextBox();
            this.btnFrmSignUp = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCreateAccount.Location = new System.Drawing.Point(47, 28);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(292, 36);
            this.lblCreateAccount.TabIndex = 1;
            this.lblCreateAccount.Text = "Create Your Account";
            // 
            // lblSignUpUsername
            // 
            this.lblSignUpUsername.AutoSize = true;
            this.lblSignUpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignUpUsername.Location = new System.Drawing.Point(25, 87);
            this.lblSignUpUsername.Name = "lblSignUpUsername";
            this.lblSignUpUsername.Size = new System.Drawing.Size(77, 18);
            this.lblSignUpUsername.TabIndex = 4;
            this.lblSignUpUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsername.Location = new System.Drawing.Point(28, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(334, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // lbSignUpPass
            // 
            this.lbSignUpPass.AutoSize = true;
            this.lbSignUpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbSignUpPass.Location = new System.Drawing.Point(27, 142);
            this.lbSignUpPass.Name = "lbSignUpPass";
            this.lbSignUpPass.Size = new System.Drawing.Size(75, 18);
            this.lbSignUpPass.TabIndex = 6;
            this.lbSignUpPass.Text = "Password";
            // 
            // txtSignUpPass
            // 
            this.txtSignUpPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSignUpPass.Location = new System.Drawing.Point(28, 163);
            this.txtSignUpPass.Name = "txtSignUpPass";
            this.txtSignUpPass.PasswordChar = '•';
            this.txtSignUpPass.Size = new System.Drawing.Size(334, 22);
            this.txtSignUpPass.TabIndex = 5;
            // 
            // lblSignUpReEnterPass
            // 
            this.lblSignUpReEnterPass.AutoSize = true;
            this.lblSignUpReEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpReEnterPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignUpReEnterPass.Location = new System.Drawing.Point(27, 202);
            this.lblSignUpReEnterPass.Name = "lblSignUpReEnterPass";
            this.lblSignUpReEnterPass.Size = new System.Drawing.Size(136, 18);
            this.lblSignUpReEnterPass.TabIndex = 8;
            this.lblSignUpReEnterPass.Text = "Re-enter Password";
            // 
            // txtSignUpReEnterPassword
            // 
            this.txtSignUpReEnterPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSignUpReEnterPassword.Location = new System.Drawing.Point(28, 223);
            this.txtSignUpReEnterPassword.Name = "txtSignUpReEnterPassword";
            this.txtSignUpReEnterPassword.PasswordChar = '•';
            this.txtSignUpReEnterPassword.Size = new System.Drawing.Size(334, 22);
            this.txtSignUpReEnterPassword.TabIndex = 7;
            // 
            // lblSignUpEmail
            // 
            this.lblSignUpEmail.AutoSize = true;
            this.lblSignUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignUpEmail.Location = new System.Drawing.Point(27, 258);
            this.lblSignUpEmail.Name = "lblSignUpEmail";
            this.lblSignUpEmail.Size = new System.Drawing.Size(45, 18);
            this.lblSignUpEmail.TabIndex = 10;
            this.lblSignUpEmail.Text = "Email";
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSignUpEmail.Location = new System.Drawing.Point(28, 279);
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(334, 22);
            this.txtSignUpEmail.TabIndex = 9;
            // 
            // lblSignUpReEnterEmail
            // 
            this.lblSignUpReEnterEmail.AutoSize = true;
            this.lblSignUpReEnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpReEnterEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSignUpReEnterEmail.Location = new System.Drawing.Point(27, 322);
            this.lblSignUpReEnterEmail.Name = "lblSignUpReEnterEmail";
            this.lblSignUpReEnterEmail.Size = new System.Drawing.Size(108, 18);
            this.lblSignUpReEnterEmail.TabIndex = 12;
            this.lblSignUpReEnterEmail.Text = "Re-Enter Email";
            // 
            // txtSignUpReEnterEmail
            // 
            this.txtSignUpReEnterEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSignUpReEnterEmail.Location = new System.Drawing.Point(28, 343);
            this.txtSignUpReEnterEmail.Name = "txtSignUpReEnterEmail";
            this.txtSignUpReEnterEmail.Size = new System.Drawing.Size(334, 22);
            this.txtSignUpReEnterEmail.TabIndex = 11;
            // 
            // btnFrmSignUp
            // 
            this.btnFrmSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnFrmSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmSignUp.ForeColor = System.Drawing.Color.White;
            this.btnFrmSignUp.Location = new System.Drawing.Point(64, 397);
            this.btnFrmSignUp.Name = "btnFrmSignUp";
            this.btnFrmSignUp.Size = new System.Drawing.Size(261, 56);
            this.btnFrmSignUp.TabIndex = 13;
            this.btnFrmSignUp.Text = "Sign Up";
            this.btnFrmSignUp.UseVisualStyleBackColor = false;
            this.btnFrmSignUp.Click += new System.EventHandler(this.btnFrmSignUp_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(233, 139);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(129, 21);
            this.chkShowPassword.TabIndex = 14;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(373, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(14, 13);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "bvbvb";
            this.notifyIcon2.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VIEW.Properties.Resources.help_24px;
            this.pictureBox1.Location = new System.Drawing.Point(108, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(393, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnFrmSignUp);
            this.Controls.Add(this.lblSignUpReEnterEmail);
            this.Controls.Add(this.txtSignUpReEnterEmail);
            this.Controls.Add(this.lblSignUpEmail);
            this.Controls.Add(this.txtSignUpEmail);
            this.Controls.Add(this.lblSignUpReEnterPass);
            this.Controls.Add(this.txtSignUpReEnterPassword);
            this.Controls.Add(this.lbSignUpPass);
            this.Controls.Add(this.txtSignUpPass);
            this.Controls.Add(this.lblSignUpUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblCreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblSignUpUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbSignUpPass;
        private System.Windows.Forms.TextBox txtSignUpPass;
        private System.Windows.Forms.Label lblSignUpReEnterPass;
        private System.Windows.Forms.TextBox txtSignUpReEnterPassword;
        private System.Windows.Forms.Label lblSignUpEmail;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.Label lblSignUpReEnterEmail;
        private System.Windows.Forms.TextBox txtSignUpReEnterEmail;
        private System.Windows.Forms.Button btnFrmSignUp;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}