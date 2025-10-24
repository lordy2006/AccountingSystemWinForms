namespace AccountingSystemWinForms
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginControl = new LoginControl();
            signUpControl = new SignUpControl();
            btnClose = new PictureBox();
            label1 = new Label();
            lblSignUpWelcome = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // loginControl
            // 
            loginControl.BackColor = Color.Transparent;
            loginControl.Location = new Point(748, 39);
            loginControl.Name = "loginControl";
            loginControl.Size = new Size(552, 668);
            loginControl.TabIndex = 3;
            loginControl.Load += loginControl1_Load;
            // 
            // signUpControl
            // 
            signUpControl.BackColor = Color.Transparent;
            signUpControl.Location = new Point(51, 39);
            signUpControl.Name = "signUpControl";
            signUpControl.Size = new Size(565, 668);
            signUpControl.TabIndex = 5;
            signUpControl.Load += signUpControl_Load;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.exit_google;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(1306, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 43;
            btnClose.TabStop = false;
            btnClose.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 80);
            label1.Name = "label1";
            label1.Size = new Size(200, 94);
            label1.TabIndex = 44;
            label1.Text = "Accounting\r\nSystem";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSignUpWelcome
            // 
            lblSignUpWelcome.AutoSize = true;
            lblSignUpWelcome.BackColor = Color.Transparent;
            lblSignUpWelcome.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUpWelcome.ForeColor = Color.White;
            lblSignUpWelcome.Location = new Point(89, 637);
            lblSignUpWelcome.Name = "lblSignUpWelcome";
            lblSignUpWelcome.Size = new Size(497, 86);
            lblSignUpWelcome.TabIndex = 46;
            lblSignUpWelcome.Text = "Welcome Back!";
            lblSignUpWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(807, 637);
            label2.Name = "label2";
            label2.Size = new Size(497, 86);
            label2.TabIndex = 48;
            label2.Text = "Welcome Back!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(797, 80);
            label3.Name = "label3";
            label3.Size = new Size(200, 94);
            label3.TabIndex = 47;
            label3.Text = "Accounting\r\nSystem";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            BackgroundImage = Properties.Resources.log_in_screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 746);
            Controls.Add(loginControl);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(signUpControl);
            Controls.Add(btnClose);
            Controls.Add(lblSignUpWelcome);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Silver;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public LoginControl loginControl;
        public SignUpControl signUpControl;
        private PictureBox btnClose;
        private Label label1;
        private Label lblSignUpWelcome;
        private Label label2;
        private Label label3;
    }
}
