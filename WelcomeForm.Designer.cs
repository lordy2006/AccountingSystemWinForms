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
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // loginControl
            // 
            loginControl.BackColor = Color.FromArgb(7, 67, 130);
            loginControl.Location = new Point(758, 49);
            loginControl.Name = "loginControl";
            loginControl.Size = new Size(560, 680);
            loginControl.TabIndex = 3;
            loginControl.Load += loginControl1_Load;
            // 
            // signUpControl
            // 
            signUpControl.BackColor = Color.FromArgb(7, 67, 130);
            signUpControl.Location = new Point(17, 49);
            signUpControl.Name = "signUpControl";
            signUpControl.Size = new Size(570, 688);
            signUpControl.TabIndex = 5;
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
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 746);
            Controls.Add(btnClose);
            Controls.Add(signUpControl);
            Controls.Add(loginControl);
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
        }

        #endregion
        public LoginControl loginControl;
        public SignUpControl signUpControl;
        private PictureBox btnClose;
    }
}
