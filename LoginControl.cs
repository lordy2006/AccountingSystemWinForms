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

        public void PreFillFields(SignUpData data)
        {
            kryptonTextBox2.Text = data.Email;
            kryptonTextBox3.Text = data.Password;
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
            string inputEmail = kryptonTextBox2.Text.Trim();      // Replace with your actual email textbox name
            string inputPassword = kryptonTextBox3.Text;          // Replace with your actual password textbox name

            // Get last sign-up info from WelcomeForm
            var registered = WelcomeForm.welcomeForm.LastSignedUpUser;

            // Check if user has registered
            if (registered == null)
            {
                MessageBox.Show("No account registered yet. Please sign up first.");
                kryptonTextBox2.Clear();
                kryptonTextBox3.Clear();
                return;
            }

            // Validate credentials
            if (inputEmail == registered.Email && inputPassword == registered.Password)
            {
                // Credentials correct, proceed
                Main mainForm = new Main();
                mainForm.Show();
                WelcomeForm.welcomeForm.Hide();
            }
            else
            {
                // Credentials do not match
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            WelcomeForm.welcomeForm.signUpControl.Show();
            WelcomeForm.welcomeForm.loginControl.Hide();
        }
    }
}
