using Krypton;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class LoginForm : KryptonForm
    {
        public static LoginForm loginForm;
        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main fillup = new Main();
            fillup.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
