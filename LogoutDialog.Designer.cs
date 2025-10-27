namespace AccountingSystemWinForms
{
    partial class LogoutDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnConfirmLogout = new Krypton.Toolkit.KryptonButton();
            btnCancelLogout = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(7, 67, 130);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(74, 187);
            label6.Name = "label6";
            label6.Size = new Size(459, 108);
            label6.TabIndex = 17;
            label6.Text = "Oh no! You’re leaving...\r\nAre you sure?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Log_Out_Icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(218, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 180);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnConfirmLogout
            // 
            btnConfirmLogout.Cursor = Cursors.Hand;
            btnConfirmLogout.Location = new Point(306, 331);
            btnConfirmLogout.Name = "btnConfirmLogout";
            btnConfirmLogout.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnConfirmLogout.Size = new Size(159, 51);
            btnConfirmLogout.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmLogout.StateCommon.Border.Rounding = 50F;
            btnConfirmLogout.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmLogout.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmLogout.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirmLogout.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmLogout.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmLogout.TabIndex = 20;
            btnConfirmLogout.Values.DropDownArrowColor = Color.Empty;
            btnConfirmLogout.Values.Text = "CONFIRM";
            btnConfirmLogout.Click += btnConfirmLogout_Click;
            // 
            // btnCancelLogout
            // 
            btnCancelLogout.Cursor = Cursors.Hand;
            btnCancelLogout.Location = new Point(141, 331);
            btnCancelLogout.Name = "btnCancelLogout";
            btnCancelLogout.OverrideDefault.Back.Color1 = Color.White;
            btnCancelLogout.OverrideDefault.Back.Color2 = Color.White;
            btnCancelLogout.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelLogout.Size = new Size(159, 51);
            btnCancelLogout.StateCommon.Back.Color1 = Color.White;
            btnCancelLogout.StateCommon.Back.Color2 = Color.White;
            btnCancelLogout.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelLogout.StateCommon.Border.Rounding = 50F;
            btnCancelLogout.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelLogout.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelLogout.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancelLogout.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCancelLogout.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCancelLogout.StateNormal.Back.Color1 = Color.White;
            btnCancelLogout.StateNormal.Back.Color2 = Color.White;
            btnCancelLogout.StateNormal.Border.Color1 = Color.Black;
            btnCancelLogout.StateNormal.Border.Color2 = Color.Black;
            btnCancelLogout.StateNormal.Border.Width = 1;
            btnCancelLogout.StateNormal.Content.ShortText.Color1 = Color.Black;
            btnCancelLogout.StateNormal.Content.ShortText.Color2 = Color.Black;
            btnCancelLogout.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelLogout.TabIndex = 19;
            btnCancelLogout.Values.DropDownArrowColor = Color.Empty;
            btnCancelLogout.Values.Text = "CANCEL";
            btnCancelLogout.Click += btnCancelLogout_Click;
            // 
            // LogoutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(607, 415);
            Controls.Add(btnConfirmLogout);
            Controls.Add(btnCancelLogout);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutDialog";
            Text = "LogoutDialog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private PictureBox pictureBox1;
        public Krypton.Toolkit.KryptonButton btnConfirmLogout;
        public Krypton.Toolkit.KryptonButton btnCancelLogout;
    }
}