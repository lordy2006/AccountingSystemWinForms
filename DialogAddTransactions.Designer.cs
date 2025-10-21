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
            lblOutputDate = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClearForm = new Krypton.Toolkit.KryptonButton();
            btnAddTransaction = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            label1.Click += label1_Click;
            // 
            // lblOutputDate
            // 
            lblOutputDate.AutoSize = true;
            lblOutputDate.Font = new Font("Segoe UI", 12F);
            lblOutputDate.Location = new Point(76, 34);
            lblOutputDate.Name = "lblOutputDate";
            lblOutputDate.Size = new Size(76, 21);
            lblOutputDate.TabIndex = 1;
            lblOutputDate.Text = "12-12-12";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 156);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 3;
            label3.Text = "Debit Account:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 188);
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
            label5.Location = new Point(22, 219);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 5;
            label5.Text = "Amount:";
            label5.Click += label5_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Cursor = Cursors.Hand;
            btnClearForm.Location = new Point(109, 282);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.OverrideDefault.Back.Color1 = Color.White;
            btnClearForm.OverrideDefault.Back.Color2 = Color.White;
            btnClearForm.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnClearForm.Size = new Size(159, 51);
            btnClearForm.StateCommon.Back.Color1 = Color.White;
            btnClearForm.StateCommon.Back.Color2 = Color.White;
            btnClearForm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnClearForm.StateCommon.Border.Rounding = 50F;
            btnClearForm.StateCommon.Content.ShortText.Color1 = Color.White;
            btnClearForm.StateCommon.Content.ShortText.Color2 = Color.White;
            btnClearForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClearForm.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnClearForm.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnClearForm.StateNormal.Back.Color1 = Color.White;
            btnClearForm.StateNormal.Back.Color2 = Color.White;
            btnClearForm.StateNormal.Border.Color1 = Color.Black;
            btnClearForm.StateNormal.Border.Color2 = Color.Black;
            btnClearForm.StateNormal.Border.Width = 1;
            btnClearForm.StateNormal.Content.ShortText.Color1 = Color.Black;
            btnClearForm.StateNormal.Content.ShortText.Color2 = Color.Black;
            btnClearForm.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.TabIndex = 14;
            btnClearForm.Values.DropDownArrowColor = Color.Empty;
            btnClearForm.Values.Text = "CANCEL";
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.Location = new Point(274, 282);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAddTransaction.Size = new Size(159, 51);
            btnAddTransaction.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAddTransaction.StateCommon.Border.Rounding = 50F;
            btnAddTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddTransaction.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.TabIndex = 15;
            btnAddTransaction.Values.DropDownArrowColor = Color.Empty;
            btnAddTransaction.Values.Text = "CONFIRM";
            // 
            // DialogAddTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 352);
            Controls.Add(btnAddTransaction);
            Controls.Add(btnClearForm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblOutputDate);
            Controls.Add(label1);
            Name = "DialogAddTransactions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DialogAddTransactions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOutputDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public Krypton.Toolkit.KryptonButton btnClearForm;
        public Krypton.Toolkit.KryptonButton btnAddTransaction;
    }
}