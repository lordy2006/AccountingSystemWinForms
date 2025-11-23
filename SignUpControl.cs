using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.Sqlite;
using System.Net.Mail;

namespace AccountingSystemWinForms
{
    public partial class SignUpControl : UserControl
    {

        public SignUpControl()
        {
            InitializeComponent();

            txbPassword.UseSystemPasswordChar = true;        // preferred
            txbConfirmPassword.UseSystemPasswordChar = true;
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
            WelcomeForm.welcomeForm.SlideToLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var name = txbFullName.Text.Trim();
            var username = txbUsername.Text.Trim();        // <-- NEW
            var email = txbEmailAddress.Text.Trim();
            var password = txbPassword.Text;
            var confirm = txbConfirmPassword.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please complete all fields.", "Missing info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Username rules: 3-20 chars, letters, numbers, dot, underscore, hyphen
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9._-]{3,20}$"))
            {
                MessageBox.Show("Username must be 3–20 chars (letters, numbers, ., _, -).", "Invalid username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try { var _ = new MailAddress(email); }
            catch
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters.", "Weak password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new UserRepository();

            try
            {
                if (repo.UsernameExists(username))
                {
                    MessageBox.Show("That username is taken. Try another.", "Duplicate username",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (repo.EmailExists(email))
                {
                    MessageBox.Show("That email is already registered.", "Duplicate email",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                repo.CreateUser(name, username, email, password);

                MessageBox.Show("Account created! You can now log in.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                // Navigate back to login (with animation)
                WelcomeForm.welcomeForm.SlideToLogin();   

            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19) // constraint violation
            {
                MessageBox.Show("That username or email is already registered.", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create account.\n\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txbEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonGroup5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
