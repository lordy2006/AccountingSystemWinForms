namespace AccountingSystemWinForms
{
    partial class LoginForm
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            loginControl1 = new LoginControl();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(loginControl1);
            kryptonPanel1.Location = new Point(661, 12);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(420, 447);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 3;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // loginControl1
            // 
            loginControl1.BackColor = Color.White;
            loginControl1.Location = new Point(23, 18);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(368, 463);
            loginControl1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 4);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 2;
            label1.Text = "Adto Pag design sa login control";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1120, 446);
            Controls.Add(kryptonPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StateCommon.Border.Rounding = 20F;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private LoginControl loginControl1;
        private Label label1;
    }
}
