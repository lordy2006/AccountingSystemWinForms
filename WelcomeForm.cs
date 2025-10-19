using Krypton;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class WelcomeForm : KryptonForm
    {
        public static WelcomeForm welcomeForm;
        public WelcomeForm()
        {

            InitializeComponent();
            signUpControl.Hide();
            welcomeForm = this;
        }   
       
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            closeButton.Click += CloseButton_Click;
        
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
