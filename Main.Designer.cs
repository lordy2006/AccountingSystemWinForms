namespace AccountingSystemWinForms
{
    partial class Main
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
            tabHolder = new TabControl();
            tabNewTransactions = new TabPage();
            btnAddTransaction = new Krypton.Toolkit.KryptonButton();
            btnClearForm = new Krypton.Toolkit.KryptonButton();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tabTransactions = new TabPage();
            label2 = new Label();
            tabAccounts = new TabPage();
            label3 = new Label();
            tabGeneralJournal = new TabPage();
            label6 = new Label();
            tabGeneralLedger = new TabPage();
            label4 = new Label();
            tabBalanceSheet = new TabPage();
            label5 = new Label();
            pnlContent1 = new Krypton.Toolkit.KryptonGroup();
            pnlCover = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnNewTransactions = new Krypton.Toolkit.KryptonButton();
            btnTransaction = new Krypton.Toolkit.KryptonButton();
            btnAccounts = new Krypton.Toolkit.KryptonButton();
            btnGeneralJournal = new Krypton.Toolkit.KryptonButton();
            btnGeneralLedger = new Krypton.Toolkit.KryptonButton();
            btnBalanceSheet = new Krypton.Toolkit.KryptonButton();
            btnLogOut = new Label();
            panel4 = new Panel();
            btnClose = new Krypton.Toolkit.ButtonSpecAny();
            label7 = new Label();
            panel3 = new Panel();
            tabHolder.SuspendLayout();
            tabNewTransactions.SuspendLayout();
            tabTransactions.SuspendLayout();
            tabAccounts.SuspendLayout();
            tabGeneralJournal.SuspendLayout();
            tabGeneralLedger.SuspendLayout();
            tabBalanceSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlContent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlContent1.Panel).BeginInit();
            SuspendLayout();
            // 
            // tabHolder
            // 
            tabHolder.Appearance = TabAppearance.FlatButtons;
            tabHolder.Controls.Add(tabNewTransactions);
            tabHolder.Controls.Add(tabTransactions);
            tabHolder.Controls.Add(tabAccounts);
            tabHolder.Controls.Add(tabGeneralJournal);
            tabHolder.Controls.Add(tabGeneralLedger);
            tabHolder.Controls.Add(tabBalanceSheet);
            tabHolder.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabHolder.Location = new Point(207, 24);
            tabHolder.Name = "tabHolder";
            tabHolder.Padding = new Point(0, 0);
            tabHolder.SelectedIndex = 0;
            tabHolder.Size = new Size(1118, 664);
            tabHolder.TabIndex = 0;
            // 
            // tabNewTransactions
            // 
            tabNewTransactions.BackColor = Color.White;
            tabNewTransactions.Controls.Add(btnAddTransaction);
            tabNewTransactions.Controls.Add(btnClearForm);
            tabNewTransactions.Controls.Add(textBox5);
            tabNewTransactions.Controls.Add(textBox3);
            tabNewTransactions.Controls.Add(label12);
            tabNewTransactions.Controls.Add(label11);
            tabNewTransactions.Controls.Add(textBox1);
            tabNewTransactions.Controls.Add(textBox4);
            tabNewTransactions.Controls.Add(label10);
            tabNewTransactions.Controls.Add(textBox2);
            tabNewTransactions.Controls.Add(label9);
            tabNewTransactions.Controls.Add(label8);
            tabNewTransactions.Location = new Point(4, 27);
            tabNewTransactions.Name = "tabNewTransactions";
            tabNewTransactions.Padding = new Padding(3);
            tabNewTransactions.Size = new Size(1110, 633);
            tabNewTransactions.TabIndex = 0;
            tabNewTransactions.Text = "tabPage1";
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.Location = new Point(581, 457);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAddTransaction.Size = new Size(216, 51);
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
            btnAddTransaction.TabIndex = 14;
            btnAddTransaction.Values.DropDownArrowColor = Color.Empty;
            btnAddTransaction.Values.Text = "ADD TRANSACTION";
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Cursor = Cursors.Hand;
            btnClearForm.Location = new Point(340, 457);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.OverrideDefault.Back.Color1 = Color.White;
            btnClearForm.OverrideDefault.Back.Color2 = Color.White;
            btnClearForm.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnClearForm.Size = new Size(216, 51);
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
            btnClearForm.TabIndex = 13;
            btnClearForm.Values.DropDownArrowColor = Color.Empty;
            btnClearForm.Values.Text = "CLEAR FORM";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(593, 365);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(436, 29);
            textBox5.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(593, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(436, 29);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(589, 330);
            label12.Name = "label12";
            label12.Size = new Size(73, 21);
            label12.TabIndex = 10;
            label12.Text = "Amount:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(589, 228);
            label11.Name = "label11";
            label11.Size = new Size(124, 21);
            label11.TabIndex = 9;
            label11.Text = "Credit Account:";
            label11.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(593, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 29);
            textBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(85, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(436, 29);
            textBox4.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(589, 125);
            label10.Name = "label10";
            label10.Size = new Size(119, 21);
            label10.TabIndex = 5;
            label10.Text = "Debit Account:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(84, 271);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(437, 123);
            textBox2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(81, 228);
            label9.Name = "label9";
            label9.Size = new Size(98, 21);
            label9.TabIndex = 3;
            label9.Text = "Description:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(81, 125);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 1;
            label8.Text = "Date (DD-MM-YYYY):";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.White;
            tabTransactions.Controls.Add(label2);
            tabTransactions.Location = new Point(4, 27);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Padding = new Padding(3);
            tabTransactions.Size = new Size(1110, 633);
            tabTransactions.TabIndex = 1;
            tabTransactions.Text = "tabPage2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(417, 248);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 1;
            label2.Text = "Transactions";
            // 
            // tabAccounts
            // 
            tabAccounts.BackColor = Color.White;
            tabAccounts.Controls.Add(label3);
            tabAccounts.Location = new Point(4, 27);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(3);
            tabAccounts.Size = new Size(1110, 633);
            tabAccounts.TabIndex = 2;
            tabAccounts.Text = "tabPage3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(417, 248);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 1;
            label3.Text = "Accounts";
            // 
            // tabGeneralJournal
            // 
            tabGeneralJournal.BackColor = Color.White;
            tabGeneralJournal.Controls.Add(label6);
            tabGeneralJournal.Location = new Point(4, 27);
            tabGeneralJournal.Name = "tabGeneralJournal";
            tabGeneralJournal.Padding = new Padding(3);
            tabGeneralJournal.Size = new Size(1110, 633);
            tabGeneralJournal.TabIndex = 3;
            tabGeneralJournal.Text = "white";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(417, 248);
            label6.Name = "label6";
            label6.Size = new Size(202, 37);
            label6.TabIndex = 1;
            label6.Text = "General Journal";
            // 
            // tabGeneralLedger
            // 
            tabGeneralLedger.BackColor = Color.White;
            tabGeneralLedger.Controls.Add(label4);
            tabGeneralLedger.Location = new Point(4, 27);
            tabGeneralLedger.Name = "tabGeneralLedger";
            tabGeneralLedger.Padding = new Padding(3);
            tabGeneralLedger.Size = new Size(1110, 633);
            tabGeneralLedger.TabIndex = 4;
            tabGeneralLedger.Text = "tabPage5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(417, 248);
            label4.Name = "label4";
            label4.Size = new Size(198, 37);
            label4.TabIndex = 1;
            label4.Text = "General Ledger";
            // 
            // tabBalanceSheet
            // 
            tabBalanceSheet.BackColor = Color.White;
            tabBalanceSheet.Controls.Add(label5);
            tabBalanceSheet.Location = new Point(4, 27);
            tabBalanceSheet.Name = "tabBalanceSheet";
            tabBalanceSheet.Padding = new Padding(3);
            tabBalanceSheet.Size = new Size(1110, 633);
            tabBalanceSheet.TabIndex = 5;
            tabBalanceSheet.Text = "tabPage6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(417, 248);
            label5.Name = "label5";
            label5.Size = new Size(181, 37);
            label5.TabIndex = 1;
            label5.Text = "Balance Sheet";
            // 
            // pnlContent1
            // 
            pnlContent1.Location = new Point(197, 12);
            pnlContent1.Size = new Size(1140, 688);
            pnlContent1.StateCommon.Back.Color1 = Color.White;
            pnlContent1.StateCommon.Border.Rounding = 25F;
            pnlContent1.TabIndex = 6;
            // 
            // pnlCover
            // 
            pnlCover.BackColor = Color.White;
            pnlCover.Location = new Point(205, 24);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(1120, 35);
            pnlCover.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(201, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 626);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(205, 678);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 14);
            panel2.TabIndex = 9;
            // 
            // btnNewTransactions
            // 
            btnNewTransactions.Cursor = Cursors.Hand;
            btnNewTransactions.Location = new Point(12, 197);
            btnNewTransactions.Name = "btnNewTransactions";
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNewTransactions.Size = new Size(167, 37);
            btnNewTransactions.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNewTransactions.StateCommon.Border.Rounding = 20F;
            btnNewTransactions.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNewTransactions.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNewTransactions.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransactions.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.TabIndex = 34;
            btnNewTransactions.Values.DropDownArrowColor = Color.Empty;
            btnNewTransactions.Values.Text = "New Transactions";
            btnNewTransactions.Click += BtnNewTransactions_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Cursor = Cursors.Hand;
            btnTransaction.Location = new Point(12, 240);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTransaction.Size = new Size(167, 37);
            btnTransaction.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTransaction.StateCommon.Border.Rounding = 20F;
            btnTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.TabIndex = 35;
            btnTransaction.Values.DropDownArrowColor = Color.Empty;
            btnTransaction.Values.Text = "Transactions";
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.Cursor = Cursors.Hand;
            btnAccounts.Location = new Point(12, 283);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAccounts.Size = new Size(167, 37);
            btnAccounts.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAccounts.StateCommon.Border.Rounding = 20F;
            btnAccounts.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccounts.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAccounts.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccounts.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.TabIndex = 36;
            btnAccounts.Values.DropDownArrowColor = Color.Empty;
            btnAccounts.Values.Text = "Accounts";
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnGeneralJournal
            // 
            btnGeneralJournal.Cursor = Cursors.Hand;
            btnGeneralJournal.Location = new Point(12, 326);
            btnGeneralJournal.Name = "btnGeneralJournal";
            btnGeneralJournal.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGeneralJournal.Size = new Size(167, 37);
            btnGeneralJournal.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGeneralJournal.StateCommon.Border.Rounding = 20F;
            btnGeneralJournal.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGeneralJournal.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGeneralJournal.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralJournal.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.TabIndex = 37;
            btnGeneralJournal.Values.DropDownArrowColor = Color.Empty;
            btnGeneralJournal.Values.Text = "General Journal";
            btnGeneralJournal.Click += btnGeneralJournal_Click;
            // 
            // btnGeneralLedger
            // 
            btnGeneralLedger.Cursor = Cursors.Hand;
            btnGeneralLedger.Location = new Point(12, 369);
            btnGeneralLedger.Name = "btnGeneralLedger";
            btnGeneralLedger.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGeneralLedger.Size = new Size(167, 37);
            btnGeneralLedger.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGeneralLedger.StateCommon.Border.Rounding = 20F;
            btnGeneralLedger.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGeneralLedger.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGeneralLedger.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralLedger.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.TabIndex = 38;
            btnGeneralLedger.Values.DropDownArrowColor = Color.Empty;
            btnGeneralLedger.Values.Text = "General Ledger";
            btnGeneralLedger.Click += btnGeneralLedger_Click;
            // 
            // btnBalanceSheet
            // 
            btnBalanceSheet.Cursor = Cursors.Hand;
            btnBalanceSheet.Location = new Point(12, 412);
            btnBalanceSheet.Name = "btnBalanceSheet";
            btnBalanceSheet.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBalanceSheet.Size = new Size(167, 37);
            btnBalanceSheet.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBalanceSheet.StateCommon.Border.Rounding = 20F;
            btnBalanceSheet.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBalanceSheet.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBalanceSheet.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalanceSheet.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.TabIndex = 39;
            btnBalanceSheet.Values.DropDownArrowColor = Color.Empty;
            btnBalanceSheet.Values.Text = "Balance Sheet";
            btnBalanceSheet.Click += btnBalanceSheet_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Segoe UI", 10F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(62, 604);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(57, 19);
            btnLogOut.TabIndex = 40;
            btnLogOut.Text = "Log out";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(150, 150, 150);
            panel4.Location = new Point(21, 586);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 1);
            panel4.TabIndex = 41;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.exit_google;
            btnClose.UniqueName = "8b7d3961c601403396bb69f1b4e8eb67";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(178, 110);
            label7.TabIndex = 1;
            label7.Text = "Accounting System";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(1320, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 626);
            panel3.TabIndex = 9;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            ButtonSpecs.Add(btnClose);
            ClientSize = new Size(1357, 688);
            CloseBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(btnLogOut);
            Controls.Add(btnBalanceSheet);
            Controls.Add(btnGeneralLedger);
            Controls.Add(btnGeneralJournal);
            Controls.Add(btnAccounts);
            Controls.Add(btnTransaction);
            Controls.Add(btnNewTransactions);
            Controls.Add(panel1);
            Controls.Add(pnlCover);
            Controls.Add(tabHolder);
            Controls.Add(pnlContent1);
            ForeColor = Color.FromArgb(7, 67, 130);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Rounding = 20F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Border.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Border.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.ButtonEdgeInset = 20;
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            tabHolder.ResumeLayout(false);
            tabNewTransactions.ResumeLayout(false);
            tabNewTransactions.PerformLayout();
            tabTransactions.ResumeLayout(false);
            tabTransactions.PerformLayout();
            tabAccounts.ResumeLayout(false);
            tabAccounts.PerformLayout();
            tabGeneralJournal.ResumeLayout(false);
            tabGeneralJournal.PerformLayout();
            tabGeneralLedger.ResumeLayout(false);
            tabGeneralLedger.PerformLayout();
            tabBalanceSheet.ResumeLayout(false);
            tabBalanceSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlContent1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlContent1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabHolder;
        private TabPage tabNewTransactions;
        private TabPage tabTransactions;
        private TabPage tabAccounts;
        private TabPage tabGeneralJournal;
        private TabPage tabGeneralLedger;
        private TabPage tabBalanceSheet;
        private Krypton.Toolkit.KryptonGroup pnlContent1;
        private Panel pnlCover;
        private Panel panel1;
        private Panel panel2;
        public Krypton.Toolkit.KryptonButton btnNewTransactions;
        public Krypton.Toolkit.KryptonButton btnTransaction;
        public Krypton.Toolkit.KryptonButton btnAccounts;
        public Krypton.Toolkit.KryptonButton btnGeneralJournal;
        public Krypton.Toolkit.KryptonButton btnGeneralLedger;
        public Krypton.Toolkit.KryptonButton btnBalanceSheet;
        private Label btnLogOut;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.ButtonSpecAny btnClose;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private Label label9;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label12;
        public Krypton.Toolkit.KryptonButton btnAddTransaction;
        public Krypton.Toolkit.KryptonButton btnClearForm;
        private Panel panel3;
    }
}