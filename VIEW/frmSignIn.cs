using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEW
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            Util.Animate(this, Util.Effect.Center, 150, 180);
        }

        Point LastPoint;
        private void frmSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void frmSignIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Center, 150, 30);
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtSignInUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignInToFrmSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp newForm = new frmSignUp();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}

