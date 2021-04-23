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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtSignUpPass.PasswordChar = chkShowPassword.Checked ? '\0' : '•';
            txtSignUpReEnterPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '•';
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrmSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
