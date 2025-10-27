namespace AccountingSystemWinForms
{
    partial class DialogAddTransactions
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelTransaction = new Krypton.Toolkit.KryptonButton();
            btnConfirmTransaction = new Krypton.Toolkit.KryptonButton();
            label6 = new Label();
            lblDateTransaction = new Label();
            lblDescriptionTransaction = new Label();
            lblDebitAccTransaction = new Label();
            lblCreditAccTransaction = new Label();
            lblAmountTransaction = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 105);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 227);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 3;
            label3.Text = "Debit Account:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 259);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 4;
            label4.Text = "Credit Account:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 290);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 5;
            label5.Text = "Amount:";
            label5.Click += label5_Click;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Cursor = Cursors.Hand;
            btnCancelTransaction.Location = new Point(133, 341);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.OverrideDefault.Back.Color1 = Color.White;
            btnCancelTransaction.OverrideDefault.Back.Color2 = Color.White;
            btnCancelTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelTransaction.Size = new Size(159, 51);
            btnCancelTransaction.StateCommon.Back.Color1 = Color.White;
            btnCancelTransaction.StateCommon.Back.Color2 = Color.White;
            btnCancelTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelTransaction.StateCommon.Border.Rounding = 50F;
            btnCancelTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancelTransaction.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCancelTransaction.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCancelTransaction.StateNormal.Back.Color1 = Color.White;
            btnCancelTransaction.StateNormal.Back.Color2 = Color.White;
            btnCancelTransaction.StateNormal.Border.Color1 = Color.Black;
            btnCancelTransaction.StateNormal.Border.Color2 = Color.Black;
            btnCancelTransaction.StateNormal.Border.Width = 1;
            btnCancelTransaction.StateNormal.Content.ShortText.Color1 = Color.Black;
            btnCancelTransaction.StateNormal.Content.ShortText.Color2 = Color.Black;
            btnCancelTransaction.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCancelTransaction.TabIndex = 14;
            btnCancelTransaction.Values.DropDownArrowColor = Color.Empty;
            btnCancelTransaction.Values.Text = "CANCEL";
            btnCancelTransaction.Click += btnClearForm_Click_1;
            // 
            // btnConfirmTransaction
            // 
            btnConfirmTransaction.Cursor = Cursors.Hand;
            btnConfirmTransaction.Location = new Point(298, 341);
            btnConfirmTransaction.Name = "btnConfirmTransaction";
            btnConfirmTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnConfirmTransaction.Size = new Size(159, 51);
            btnConfirmTransaction.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmTransaction.StateCommon.Border.Rounding = 50F;
            btnConfirmTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirmTransaction.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnConfirmTransaction.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnConfirmTransaction.TabIndex = 15;
            btnConfirmTransaction.Values.DropDownArrowColor = Color.Empty;
            btnConfirmTransaction.Values.Text = "CONFIRM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(7, 67, 130);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(60, 9);
            label6.Name = "label6";
            label6.Size = new Size(486, 84);
            label6.TabIndex = 16;
            label6.Text = "Do these details align with your\r\nrecords?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // lblDateTransaction
            // 
            lblDateTransaction.Location = new Point(100, 110);
            lblDateTransaction.Name = "lblDateTransaction";
            lblDateTransaction.Size = new Size(445, 18);
            lblDateTransaction.TabIndex = 17;
            
            // 
            // lblDescriptionTransaction
            // 
            lblDescriptionTransaction.Location = new Point(60, 163);
            lblDescriptionTransaction.Name = "lblDescriptionTransaction";
            lblDescriptionTransaction.Size = new Size(485, 59);
            lblDescriptionTransaction.TabIndex = 18;
            
            // 
            // lblDebitAccTransaction
            // 
            lblDebitAccTransaction.Location = new Point(171, 232);
            lblDebitAccTransaction.Name = "lblDebitAccTransaction";
            lblDebitAccTransaction.Size = new Size(375, 18);
            lblDebitAccTransaction.TabIndex = 19;
            
            // 
            // lblCreditAccTransaction
            // 
            lblCreditAccTransaction.Location = new Point(171, 264);
            lblCreditAccTransaction.Name = "lblCreditAccTransaction";
            lblCreditAccTransaction.Size = new Size(374, 18);
            lblCreditAccTransaction.TabIndex = 20;
            
            // 
            // lblAmountTransaction
            // 
            lblAmountTransaction.Location = new Point(125, 295);
            lblAmountTransaction.Name = "lblAmountTransaction";
            lblAmountTransaction.Size = new Size(420, 18);
            lblAmountTransaction.TabIndex = 21;
            lblAmountTransaction.Click += lblAmountTransaction_Click;
            // 
            // DialogAddTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 415);
            Controls.Add(lblAmountTransaction);
            Controls.Add(lblCreditAccTransaction);
            Controls.Add(lblDebitAccTransaction);
            Controls.Add(lblDescriptionTransaction);
            Controls.Add(lblDateTransaction);
            Controls.Add(label6);
            Controls.Add(btnConfirmTransaction);
            Controls.Add(btnCancelTransaction);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogAddTransactions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DialogAddTransactions";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public Krypton.Toolkit.KryptonButton btnCancelTransaction;
        public Krypton.Toolkit.KryptonButton btnConfirmTransaction;
        private Label label6;
        private Label lblDateTransaction;
        private Label lblDescriptionTransaction;
        private Label lblDebitAccTransaction;
        private Label lblCreditAccTransaction;
        private Label lblAmountTransaction;
    }
}