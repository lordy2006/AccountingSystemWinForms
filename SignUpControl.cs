using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystemWinForms
{
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }
        //enable window buffering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            WelcomeForm.welcomeForm.loginControl.Show();
            WelcomeForm.welcomeForm.signUpControl.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
