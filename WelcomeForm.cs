using Krypton;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class WelcomeForm : Form
    {
        //para ma access globally
        public static WelcomeForm welcomeForm;
        public WelcomeForm()
        {

            InitializeComponent();
            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )

            UiDesign.ApplyShadow(this);

            signUpControl.Hide();
            welcomeForm = this;

            signUpControl.AccountCreated += SignUpControl_AccountCreated;
        }


        public SignUpData LastSignedUpUser { get; set; }

        //enable window buffering  (para ma smooth ang pag render)
        private void SignUpControl_AccountCreated(SignUpData data)
        {
            LastSignedUpUser = data;
           
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signUpControl_Load(object sender, EventArgs e)
        {

        }
    }
}
