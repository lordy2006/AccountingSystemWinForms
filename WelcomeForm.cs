using Krypton;
using Krypton.Toolkit;
using Transitions;

namespace AccountingSystemWinForms
{
    public partial class WelcomeForm : Form
    {
        //para ma access globally
        public static WelcomeForm welcomeForm;

        private int cardLeftX;
        private int cardRightX;
        private int panelTop;
        public WelcomeForm()
        {

            InitializeComponent();
            this.Size = new Size(1352, 746);

            UiDesign.ApplyShadow(this);
            welcomeForm = this;

            // vertical position where the cards sit
            panelTop = 60;

            int margin = 60;

            // where a card sits when it's on the LEFT or RIGHT
            cardLeftX = margin;
            cardRightX = this.ClientSize.Width - loginControl.Width - margin;

            // --- START STATE: LOGIN visible on RIGHT, SIGNUP hidden ---
            loginControl.Location = new Point(cardRightX, panelTop);
            loginControl.Visible = true;

            // sign-up starts off-screen to the RIGHT
            signUpControl.Location = new Point(this.ClientSize.Width, panelTop);
            signUpControl.Visible = false;

            // text: login state
            label1.Visible = true;
            lblSignUpWelcome.Visible = true;
            label2.Visible = false;
            label3.Visible = false;


        }
        public void SlideToSignUp()
        {
            signUpControl.Visible = true;

            var t = new Transition(new TransitionType_EaseInEaseOut(450));

            // login: from right -> off-screen left
            t.add(loginControl, "Left", -loginControl.Width);

            // sign-up: from off-screen right -> left position
            t.add(signUpControl, "Left", cardLeftX);

            t.run();

            // after animation, hide login to avoid overlap
            loginControl.Visible = false;

            // text for SIGN-UP state
            label1.Visible = false;
            lblSignUpWelcome.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
                
        }

        public void SlideToLogin()
        {
            loginControl.Visible = true;

            var t = new Transition(new TransitionType_EaseInEaseOut(450));

            // sign-up: from left -> off-screen right
            t.add(signUpControl, "Left", this.ClientSize.Width);

            // login: from off-screen left -> right position
            t.add(loginControl, "Left", cardRightX);

            t.run();

            // after animation, hide sign-up to avoid overlap
            signUpControl.Visible = false;

            // text for LOGIN state
            label1.Visible = true;
            lblSignUpWelcome.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
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

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
