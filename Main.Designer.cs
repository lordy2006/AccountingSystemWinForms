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
            label1 = new Label();
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
            panel3 = new Panel();
            btnNewTransactions = new Krypton.Toolkit.KryptonButton();
            btnTransaction = new Krypton.Toolkit.KryptonButton();
            btnAccounts = new Krypton.Toolkit.KryptonButton();
            btnGeneralJournal = new Krypton.Toolkit.KryptonButton();
            btnGeneralLedger = new Krypton.Toolkit.KryptonButton();
            btnBalanceSheet = new Krypton.Toolkit.KryptonButton();
            btnLogOut = new Label();
            panel4 = new Panel();
            btnClose = new Krypton.Toolkit.ButtonSpecAny();
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
            tabHolder.Location = new Point(207, 55);
            tabHolder.Name = "tabHolder";
            tabHolder.Padding = new Point(0, 0);
            tabHolder.SelectedIndex = 0;
            tabHolder.Size = new Size(1064, 564);
            tabHolder.TabIndex = 0;
            // 
            // tabNewTransactions
            // 
            tabNewTransactions.BackColor = Color.White;
            tabNewTransactions.Controls.Add(label1);
            tabNewTransactions.Location = new Point(4, 27);
            tabNewTransactions.Name = "tabNewTransactions";
            tabNewTransactions.Padding = new Padding(3);
            tabNewTransactions.Size = new Size(1056, 533);
            tabNewTransactions.TabIndex = 0;
            tabNewTransactions.Text = "tabPage1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(132, 39);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "New Transactions";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.White;
            tabTransactions.Controls.Add(label2);
            tabTransactions.Location = new Point(4, 27);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Padding = new Padding(3);
            tabTransactions.Size = new Size(1056, 533);
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
            tabAccounts.Size = new Size(1056, 533);
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
            tabGeneralJournal.Size = new Size(1056, 533);
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
            tabGeneralLedger.Size = new Size(1056, 533);
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
            tabBalanceSheet.Size = new Size(1056, 533);
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
            pnlContent1.Size = new Size(1096, 632);
            pnlContent1.StateCommon.Back.Color1 = Color.White;
            pnlContent1.StateCommon.Border.Rounding = 25F;
            pnlContent1.TabIndex = 6;
            // 
            // pnlCover
            // 
            pnlCover.BackColor = Color.White;
            pnlCover.Location = new Point(205, 55);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(1071, 35);
            pnlCover.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(205, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(16, 537);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(205, 609);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 10);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(1260, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 537);
            panel3.TabIndex = 10;
            // 
            // btnNewTransactions
            // 
            btnNewTransactions.Cursor = Cursors.Hand;
            btnNewTransactions.Location = new Point(12, 121);
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
            btnTransaction.Location = new Point(12, 164);
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
            btnAccounts.Location = new Point(12, 207);
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
            btnGeneralJournal.Location = new Point(12, 250);
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
            btnGeneralLedger.Location = new Point(12, 293);
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
            btnBalanceSheet.Location = new Point(12, 336);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            ButtonSpecs.Add(btnClose);
            ClientSize = new Size(1365, 664);
            CloseBox = false;
            Controls.Add(panel4);
            Controls.Add(btnLogOut);
            Controls.Add(btnBalanceSheet);
            Controls.Add(btnGeneralLedger);
            Controls.Add(btnGeneralJournal);
            Controls.Add(btnAccounts);
            Controls.Add(btnTransaction);
            Controls.Add(btnNewTransactions);
            Controls.Add(panel3);
            Controls.Add(panel2);
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
        private Panel panel3;
        public Krypton.Toolkit.KryptonButton btnNewTransactions;
        public Krypton.Toolkit.KryptonButton btnTransaction;
        public Krypton.Toolkit.KryptonButton btnAccounts;
        public Krypton.Toolkit.KryptonButton btnGeneralJournal;
        public Krypton.Toolkit.KryptonButton btnGeneralLedger;
        public Krypton.Toolkit.KryptonButton btnBalanceSheet;
        private Label label1;
        private Label btnLogOut;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.ButtonSpecAny btnClose;
    }
}