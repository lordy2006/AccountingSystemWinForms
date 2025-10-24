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
        public event Action<SignUpData> AccountCreated;
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
            string fullName = txbFullName.Text.Trim();
            string email = txbEmailAddress.Text.Trim();
            string password = txbPassword.Text;
            string confirmPassword = txbConfirmPassword.Text;

            // Simple validation (expand as needed)
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                txbPassword.Clear();
                txbConfirmPassword.Clear();
                return;
            }

            // Create the data object
            SignUpData data = new SignUpData(fullName, email, password);

            // Raise the event
            AccountCreated?.Invoke(data);
            MessageBox.Show("Account created successfully! Please log in.");
            txbFullName.Clear();
            txbEmailAddress.Clear();    
            txbPassword.Clear();
            txbConfirmPassword.Clear();


        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
