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

            txbPassword.UseSystemPasswordChar = true;

        }

        public void PreFillFields(SignUpData data)
        {
            // If you keep prefill at all, use the actual controls:
            txbUsername.Text = data.Username;
            txbPassword.Text = data.Password;   // consider removing for security
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
            var identifier = txbUsername.Text.Trim();   // username OR email
            var password = txbPassword.Text;

            if (string.IsNullOrWhiteSpace(identifier) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username/email and password.", "Missing info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var repo = new UserRepository();

                // check username OR email + password
                if (!repo.ValidateCredentials(identifier, password))
                {
                    MessageBox.Show("Invalid username/email or password.", "Login failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPassword.Clear();
                    txbPassword.Focus();
                    return;
                }

                // get the name to display on Main
                var fullName = repo.GetFullNameByIdentifier(identifier) ?? identifier;

                var main = new Main();
                // use whatever you already have to set the label in Main:
                // e.g., main.setUsername(fullName); or main.SetCurrentUser(fullName);
                main.setUsername(fullName);

                main.Show();
                WelcomeForm.welcomeForm.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed.\n\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            WelcomeForm.welcomeForm.signUpControl.Show();
            WelcomeForm.welcomeForm.loginControl.Hide();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
