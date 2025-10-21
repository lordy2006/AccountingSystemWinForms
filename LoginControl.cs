using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();

        }
        //enable window buffering  (para ma smooth ang pag render)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();

            WelcomeForm.welcomeForm.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            WelcomeForm.welcomeForm.signUpControl.Show();
            WelcomeForm.welcomeForm.loginControl.Hide();
        }
    }
}
