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
            checkBox1 = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // loginControl
            // 
            loginControl.BackColor = Color.FromArgb(7, 67, 130);
            loginControl.Location = new Point(747, 42);
            loginControl.Name = "loginControl";
            loginControl.Size = new Size(552, 668);
            loginControl.TabIndex = 3;
            loginControl.Load += loginControl1_Load;
            // 
            // signUpControl
            // 
            signUpControl.BackColor = Color.FromArgb(7, 67, 130);
            signUpControl.Location = new Point(47, 42);
            signUpControl.Name = "signUpControl";
            signUpControl.Size = new Size(554, 668);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.DimGray;
            checkBox1.Location = new Point(871, 409);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 21);
            checkBox1.TabIndex = 45;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(1093, 409);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 46;
            label1.Text = "Forgot password?";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            BackgroundImage = Properties.Resources.log_in_screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 746);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(btnClose);
            Controls.Add(signUpControl);
            Controls.Add(loginControl);
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
        private CheckBox checkBox1;
        private Label label1;
    }
}
