namespace AccountingSystemWinForms
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            pnlUser = new Krypton.Toolkit.KryptonPanel();
            txbUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pnlUser).BeginInit();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(72, 112);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(41, 20);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Login";
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(txbUser);
            pnlUser.Location = new Point(72, 138);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(174, 41);
            pnlUser.StateCommon.Color1 = Color.FromArgb(231, 231, 231);
            pnlUser.TabIndex = 6;
            // 
            // txbUser
            // 
            txbUser.BackColor = Color.FromArgb(231, 231, 231);
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Location = new Point(8, 13);
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "asdasd";
            txbUser.Size = new Size(150, 16);
            txbUser.TabIndex = 5;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlUser);
            Controls.Add(kryptonLabel1);
            Name = "LoginControl";
            Size = new Size(368, 463);
            ((System.ComponentModel.ISupportInitialize)pnlUser).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel pnlUser;
        private TextBox txbUser;
    }
}
