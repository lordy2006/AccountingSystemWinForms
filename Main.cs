using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;




namespace AccountingSystemWinForms
{
    public partial class Main : Form
    {
        private bool journalSortAscending = true;



        public Main()
        {
            InitializeComponent();




            // Use RGB for White (R: 255, G: 255, B: 255)
            dgvTransaction.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvTransaction.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246); // Use a specific RGB for a light gray (e.g., R: 246, G: 246, B: 246)
            dgvAccounts.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246);
            dgvGeneralJournal.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvGeneralJournal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246);
            dgvGeneralLedger.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvGeneralLedger.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246);
            dgvAssets.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvAssets.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246);
            dgvLiability.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvLiability.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 246);

            dgvAssets.CellFormatting += dgvAssets_CellFormatting;
            dgvLiability.CellFormatting += dgvLiability_CellFormatting;

            dgvAssets.ReadOnly = true;
            dgvLiability.ReadOnly = true;


            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )
            textBox8.TextChanged += textBox8_TextChanged;

            textBox4.Text = DateTime.Now.ToString("dd-MM-yyyy");
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            dgvGeneralJournal.CellFormatting += dgvGeneralJournal_CellFormatting;
            dgvTransaction.AutoGenerateColumns = false;
            dgvGeneralJournal.AutoGenerateColumns = false;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            dgvGeneralLedger.AutoGenerateColumns = false;
            dgvGeneralLedger.CellFormatting += dgvGeneralLedger_CellFormatting;


            dgvTransaction.DataSource = transactionList;


            UiDesign.ApplyShadow(this);
            comboBox1.DataSource = new List<Account>(allAccounts);
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Name";

            comboBox2.DataSource = new List<Account>(allAccounts);
            comboBox2.DisplayMember = "DisplayName";
            comboBox2.ValueMember = "Name";


            // In your constructor or form load
            comboBox3.DataSource = new List<Account>(allAccounts);
            comboBox3.DisplayMember = "DisplayName";
            comboBox3.ValueMember = "Name";
            comboBox3.SelectedIndex = 0; // "Cash" should show first (since it's first in your list)



        }

        public static List<Account> allAccounts = new List<Account>
{
    new Account { Name = "Cash", Type = "ASSET" },
    new Account { Name = "Accounts Receivable", Type = "ASSET" },
    new Account { Name = "Inventory", Type = "ASSET" },
    new Account { Name = "Prepaid Expenses", Type = "ASSET" },
    new Account { Name = "Equipment", Type = "ASSET" },
    new Account { Name = "Accounts Payable", Type = "LIABILITY" },
    new Account { Name = "Notes Payable", Type = "LIABILITY" },
    new Account { Name = "Owner's Capital", Type = "EQUITY" },
    new Account { Name = "Sales Revenue", Type = "INCOME" },
    new Account { Name = "Service Revenue", Type = "INCOME" },
    new Account { Name = "Cost of Goods Sold", Type = "EXPENSE" },
    new Account { Name = "Rent Expense", Type = "EXPENSE" },
    new Account { Name = "Salaries Expense", Type = "EXPENSE" },
    new Account { Name = "Utilities Expense", Type = "EXPENSE" },
};

        private BindingList<Transaction> transactionList = new BindingList<Transaction>();

        public void setUsername(string FullName)
        {
            lblDisplayFullName.Text = FullName;
        }
        //enable window buffering (para ma smooth ang pag render)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )

            //display ang note
            NoteControl notes = new NoteControl();
            notes.Dock = DockStyle.Fill;
            notes.Margin = new Padding(0);
            this.Controls.Add(notes);
            notes.BringToFront();

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to exit the application?",
             "Exit Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvGeneralLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Safety: ignore the "new row" area
            if (e.RowIndex < 0 || e.RowIndex >= dgvGeneralLedger.Rows.Count)
                return;

            string columnName = dgvGeneralLedger.Columns[e.ColumnIndex].Name;

            // === Format Amount & Balance columns ===
            if (columnName == "Amount" || columnName == "Balance")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    // Negative values in red
                    if (val < 0)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }

                    // Bold the Balance column to emphasize running total
                    if (columnName == "Balance")
                    {
                        e.CellStyle.Font = new Font(
                            dgvGeneralLedger.Font,
                            FontStyle.Bold
                        );
                    }
                }
            }

            // === Highlight the last row (ending balance) ===
            bool isLastRow = (e.RowIndex == dgvGeneralLedger.Rows.Count - 1);

            if (isLastRow)
            {
                e.CellStyle.BackColor = Color.FromArgb(230, 240, 255); // soft tint
                e.CellStyle.Font = new Font(
                    dgvGeneralLedger.Font,
                    FontStyle.Bold
                );
            }
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {

            LogoutDialog logoutSystem = new LogoutDialog();
            UiDesign.ShowDialogDimBackground(this, logoutSystem, 15);

        }

        private void BtnNewTransactions_Click(object sender, EventArgs e)
        {
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);

            tabHolder.SelectedTab = tabNewTransactions;
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string dateInput = textBox4.Text.Trim();
            string description = textBox2.Text.Trim();
            var debitAccount = comboBox1.SelectedItem as Account;
            var creditAccount = comboBox2.SelectedItem as Account;
            string amountText = textBox5.Text.Trim();

            // Validate all fields
            if (string.IsNullOrWhiteSpace(dateInput) || string.IsNullOrWhiteSpace(description) ||
                debitAccount == null || creditAccount == null || string.IsNullOrWhiteSpace(amountText))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (debitAccount == null || creditAccount == null)
            {
                MessageBox.Show("Please select both a debit and a credit account.");
                return; // Don't continue if either is null
            }



            if (debitAccount != null && creditAccount != null && debitAccount.Name == creditAccount.Name)
            {
                MessageBox.Show("Debit and Credit accounts must be different, following the double entry rule.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- DATE VALIDATION ---
            DateTime parsedDate;
            bool validDate = DateTime.TryParseExact(
                dateInput,
                "dd-MM-yyyy", // Adjust this if you want a different format
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out parsedDate
            );

            if (!validDate)
            {
                MessageBox.Show("Please enter a valid date in the format DD-MM-YYYY.");
                textBox4.Focus();
                return;
            }

            // --- AMOUNT VALIDATION ---
            decimal amountValue;
            if (!decimal.TryParse(amountText, out amountValue))
            {
                MessageBox.Show("Please enter a valid amount (numbers only).");
                return;
            }

            // Confirmation dialog, showing the formatted date for consistency
            using (var confirm = new DialogAddTransactions(
                parsedDate.ToString("dd-MM-yyyy"),
                description,
                debitAccount.DisplayName,
                creditAccount.DisplayName,
                amountValue.ToString("N2")
            ))
            {
                if (confirm.ShowDialog() == DialogResult.OK && confirm.IsConfirmed)
                {
                    // Add to transaction list with validated/consistent date
                    transactionList.Insert(0, new Transaction
                    {
                        Date = parsedDate.ToString("dd-MM-yyyy"),
                        Description = description,
                        DebitAccount = debitAccount.DisplayName,
                        CreditAccount = creditAccount.DisplayName,
                        Amount = amountValue
                    });

                    MessageBox.Show("Transaction Confirmed!");

                    // Clear the form
                    btnClearForm.PerformClick();

                    // Reset ComboBoxes to show all accounts again after clear
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = new List<Account>(allAccounts);
                    comboBox1.DisplayMember = "DisplayName";
                    comboBox1.ValueMember = "Name";
                    comboBox1.SelectedIndex = 0;

                    comboBox2.DataSource = null;
                    comboBox2.DataSource = new List<Account>(allAccounts);
                    comboBox2.DisplayMember = "DisplayName";
                    comboBox2.ValueMember = "Name";
                    comboBox2.SelectedIndex = 0;


                    // Update other grids if needed
                    UpdateAccountsGrid();
                    SortGeneralJournalByDate();

                    UpdateBalanceSheet();
                }

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Accept only digits, control keys, or one dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || textBox5.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void UpdateAccountsGrid()
        {
            var accountDisplays = allAccounts
                .Select(acc => new AccountDisplay
                {
                    Account = acc.DisplayName,
                    Type = acc.Type,
                    Balance = CalculateBalance(acc)   // <— changed
                })
                .ToList();

            dgvAccounts.DataSource = new BindingList<AccountDisplay>(accountDisplays);
        }


        // Type-aware balance
        private decimal CalculateBalance(Account acc)
        {
            decimal debit = transactionList
                .Where(t => t.DebitAccount == acc.DisplayName)
                .Sum(t => t.Amount);

            decimal credit = transactionList
                .Where(t => t.CreditAccount == acc.DisplayName)
                .Sum(t => t.Amount);

            // Assets & Expenses -> debit-normal (Debits increase balance)
            if (acc.Type == "ASSET" || acc.Type == "EXPENSE")
                return debit - credit;

            // Liabilities, Equity, Income -> credit-normal (Credits increase balance)
            return credit - debit;
        }

        // Optional helper if you still want to call by name
        private decimal CalculateBalance(string accountDisplayName)
        {
            var acc = allAccounts.FirstOrDefault(a => a.DisplayName == accountDisplayName);
            if (acc == null) return 0m;
            return CalculateBalance(acc);
        }



        private void UpdateBalanceSheet()
        {
            // ===== ASSETS =====
            var assetRows = allAccounts
                .Where(a => a.Type == "ASSET")
                .Select(a => new
                {
                    Asset = a.DisplayName,
                    Amount = CalculateBalance(a)
                })
                .Where(row => row.Amount != 0)
                .ToList();

            decimal totalAssets = assetRows.Sum(a => a.Amount);

            assetRows.Add(new { Asset = "Total Assets", Amount = totalAssets });

            dgvAssets.DataSource = assetRows
                .Select(r => new { r.Asset, Amount = r.Amount.ToString("N2") })
                .ToList();

            // ===== LIABILITIES + EQUITY =====
            var liabRows = allAccounts
                .Where(a => a.Type == "LIABILITY" || a.Type == "EQUITY")
                .Select(a => new
                {
                    LiabilityAndEquity = a.DisplayName,
                    Amount = CalculateBalance(a)
                })
                .Where(row => row.Amount != 0)
                .ToList();

            decimal totalLiabEquity = liabRows.Sum(a => a.Amount);

            liabRows.Add(new
            {
                LiabilityAndEquity = "Total Liabilities + Equity",
                Amount = totalLiabEquity
            });

            dgvLiability.DataSource = liabRows
                .Select(r => new { r.LiabilityAndEquity, Amount = r.Amount.ToString("N2") })
                .ToList();

            // ===== BALANCED? =====
            if (totalAssets == totalLiabEquity)
            {
                BalanceCheckMessage.Text = "Balanced ✔";
                BalanceCheckMessage.ForeColor = Color.Green;
            }
            else
            {
                BalanceCheckMessage.Text = "Not Balanced ✖";
                BalanceCheckMessage.ForeColor = Color.Red;
            }
        }





        private void dgvAssets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Last row = Total Assets
            if (e.RowIndex == dgvAssets.Rows.Count - 1)
                dgvAssets.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvAssets.Font, FontStyle.Bold);
        }

        private void dgvLiability_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == dgvLiability.Rows.Count - 1)
                dgvLiability.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvLiability.Font, FontStyle.Bold);
        }



        private void btnTransaction_Click(object sender, EventArgs e)
        {
            btnTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabTransactions;

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            btnAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabAccounts;
            UpdateAccountsGrid();
        }
        private void btnGeneralJournal_Click(object sender, EventArgs e)
        {
            btnGeneralJournal.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabGeneralJournal;
            SortGeneralJournalByDate();


        }
        private void btnGeneralLedger_Click(object sender, EventArgs e)
        {
            btnGeneralLedger.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabGeneralLedger;

        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            btnBalanceSheet.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabBalanceSheet;


            UpdateBalanceSheet();

        }

        private void tableTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString("dd-MM-yyyy");
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox5.Clear();

        }



        // Centralized validation for the New Transaction form




        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox8.Text.Trim().ToLower();

            // If search is empty, show the full list
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvTransaction.DataSource = transactionList;  // <- change this line
                return;
            }

            var filtered = transactionList.Where(t =>
                t.Date.ToLower().Contains(searchText) ||
                t.Description.ToLower().Contains(searchText) ||
                t.DebitAccount.ToLower().Contains(searchText) ||
                t.CreditAccount.ToLower().Contains(searchText)
            ).ToList();

            dgvTransaction.DataSource = new BindingList<Transaction>(filtered);
        }


        private void dgvGeneralJournal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvGeneralLedger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tabNewTransactions_Click(object sender, EventArgs e)
        {

        }

        private bool updatingCombos = false; // Prevent recursion

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingCombos) return;
            updatingCombos = true;
            try
            {
                var selectedDebit = comboBox1.SelectedItem as Account;
                var creditOptions = allAccounts
                    .Where(acc => selectedDebit == null || acc.DisplayName != selectedDebit.DisplayName)
                    .ToList();

                var prevCredit = comboBox2.SelectedItem as Account;

                comboBox2.DataSource = null;
                comboBox2.DataSource = creditOptions;
                comboBox2.DisplayMember = "DisplayName";
                comboBox2.ValueMember = "Name";

                // Try to reselect previous credit account if still available
                if (prevCredit != null && creditOptions.Any(acc => acc.DisplayName == prevCredit.DisplayName))
                    comboBox2.SelectedItem = creditOptions.First(acc => acc.DisplayName == prevCredit.DisplayName);
                else
                    comboBox2.SelectedIndex = 0; // Or -1 for nothing selected
            }
            finally { updatingCombos = false; }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingCombos) return;
            updatingCombos = true;
            try
            {
                var selectedCredit = comboBox2.SelectedItem as Account;
                var debitOptions = allAccounts
                    .Where(acc => selectedCredit == null || acc.DisplayName != selectedCredit.DisplayName)
                    .ToList();

                var prevDebit = comboBox1.SelectedItem as Account;

                comboBox1.DataSource = null;
                comboBox1.DataSource = debitOptions;
                comboBox1.DisplayMember = "DisplayName";
                comboBox1.ValueMember = "Name";

                // Try to reselect previous debit account if still available
                if (prevDebit != null && debitOptions.Any(acc => acc.DisplayName == prevDebit.DisplayName))
                    comboBox1.SelectedItem = debitOptions.First(acc => acc.DisplayName == prevDebit.DisplayName);
                else
                    comboBox1.SelectedIndex = 0; // Or -1 for nothing selected
            }
            finally { updatingCombos = false; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAccount = comboBox3.SelectedItem as Account;
            if (selectedAccount == null) return;

            string selected = selectedAccount.DisplayName;


            var filtered = transactionList
                .Where(t => t.DebitAccount == selected || t.CreditAccount == selected)
                .ToList();

            decimal runningBalance = 0;
            var ledgerRows = new List<LedgerRow>();

            foreach (var t in filtered)
            {
                // Is this account debit-normal?
                bool isDebitNormal = selectedAccount.Type == "ASSET"
                                  || selectedAccount.Type == "EXPENSE";

                if (isDebitNormal)
                {
                    if (t.DebitAccount == selected)
                        runningBalance += t.Amount;
                    else if (t.CreditAccount == selected)
                        runningBalance -= t.Amount;
                }
                else // credit-normal (Liability, Equity, Income)
                {
                    if (t.DebitAccount == selected)
                        runningBalance -= t.Amount;
                    else if (t.CreditAccount == selected)
                        runningBalance += t.Amount;
                }

                ledgerRows.Add(new LedgerRow
                {
                    Date = t.Date,
                    Description = t.Description,
                    DebitAccount = t.DebitAccount,
                    CreditAccount = t.CreditAccount,
                    Amount = t.Amount.ToString("N2"),
                    Balance = runningBalance.ToString("N2")
                });
            }

            dgvGeneralLedger.DataSource = new BindingList<LedgerRow>(ledgerRows);
        }





        private void dgvGeneralJournal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGeneralJournal.Columns[e.ColumnIndex].Name == "Debit" ||
                dgvGeneralJournal.Columns[e.ColumnIndex].Name == "Credit")
            {

                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    if (val == 0m)
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = val.ToString("C2");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        

        private void SortGeneralJournalByDate()
        {
            var journalRows = new List<JournalEntry>();

            // Sort ascending or descending
            var sortedTransactions = journalSortAscending
            ? transactionList.OrderBy(t => DateTime.ParseExact(t.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToList()
            : transactionList.OrderByDescending(t => DateTime.ParseExact(t.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToList();


            foreach (var t in sortedTransactions)
            {
                journalRows.Add(new JournalEntry
                {
                    Date = t.Date,
                    Description = t.Description,
                    Account = t.DebitAccount,
                    Debit = t.Amount,
                    Credit = 0
                });
                journalRows.Add(new JournalEntry
                {
                    Date = "",
                    Description = "",
                    Account = "    " + t.CreditAccount,
                    Debit = 0,
                    Credit = t.Amount
                });
            }

            dgvGeneralJournal.DataSource = new BindingList<JournalEntry>(journalRows);
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TransacCSV_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToCsv(dgvTransaction, "Transactions.csv");

        }
        private void ExportDataGridViewToCsv(DataGridView dgv, string defaultFileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = defaultFileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();

                    // Header row
                    var headers = dgv.Columns
                                     .Cast<DataGridViewColumn>()
                                     .Select(c => c.HeaderText);
                    sb.AppendLine(string.Join(",", headers.Select(EscapeCsv)));

                    // Data rows
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var cells = row.Cells
                                       .Cast<DataGridViewCell>()
                                       .Select(c => c.Value == null ? "" : c.Value.ToString());

                        sb.AppendLine(string.Join(",", cells.Select(EscapeCsv)));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("Transactions exported successfully.",
                                    "Export",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private string EscapeCsv(string input)
        {
            if (input == null)
                return "";

            // Escape quotes by doubling them, wrap entire field in quotes
            string escaped = input.Replace("\"", "\"\"");
            return $"\"{escaped}\"";
        }

        private void btnExportJournalCSV_Click(object sender, EventArgs e)
        {
            SortGeneralJournalByDate();
            ExportDataGridViewToCsv(dgvGeneralJournal, "GeneralJournal.csv");
        }

        private void btnExportLedgerCSV_Click(object sender, EventArgs e)
        {
            var selectedAccount = comboBox3.SelectedItem as Account;

            if (selectedAccount == null)
            {
                MessageBox.Show("Please select an account first before exporting the ledger.",
                                "No Account Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Build a safe filename, e.g. Ledger_Cash.csv
            char[] invalid = Path.GetInvalidFileNameChars();
            string safeAccountName = new string(
                selectedAccount.Name
                    .Where(ch => !invalid.Contains(ch))
                    .ToArray()
            );

            string defaultFileName = $"Ledger_{safeAccountName}.csv";

            // dgvGeneralLedger already shows the ledger for the selected account,
            // so we just export what is currently displayed.
            ExportDataGridViewToCsv(dgvGeneralLedger, defaultFileName);
        }

        private List<string> ParseCsvLine(string line)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(line))
                return result;

            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '\"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                    {
                        // Escaped quote ("")
                        sb.Append('\"');
                        i++; // skip next quote
                    }
                    else
                    {
                        // Toggle quote state
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    // End of field
                    result.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    sb.Append(c);
                }
            }

            // Last field
            result.Add(sb.ToString());
            return result;
        }

        private void LoadTransactionsFromCsv()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.Title = "Select Transactions CSV";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                string[] lines;
                try
                {
                    lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file:\n" + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                if (lines.Length <= 1)
                {
                    MessageBox.Show("The selected CSV file is empty or has no data rows.",
                                    "No Data",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Ask if we replace or append
                var choice = MessageBox.Show(
                    "Do you want to REPLACE existing transactions with this file?\n\n" +
                    "Yes = Replace\nNo = Append",
                    "Load Transactions",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (choice == DialogResult.Cancel)
                    return;

                if (choice == DialogResult.Yes)
                {
                    // Replace
                    transactionList.Clear();
                    
                }
                textBox8.Clear();                    // reset search
                dgvTransaction.DataSource = transactionList;

                // If No -> we append

                int successCount = 0;
                int failedCount = 0;

                // Assume first line is header
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    try
                    {
                        var fields = ParseCsvLine(line);

                        // Expecting: Date, Description, DebitAccount, CreditAccount, Amount
                        if (fields.Count < 5)
                        {
                            failedCount++;
                            continue;
                        }

                        string dateStr = fields[0].Trim().Trim('"');
                        string description = fields[1].Trim().Trim('"');
                        string debitAccount = fields[2].Trim().Trim('"');
                        string creditAccount = fields[3].Trim().Trim('"');
                        string amountStr = fields[4].Trim().Trim('"');

                        // Validate/parse date & amount
                        DateTime parsedDate;
                        if (!DateTime.TryParseExact(
                                dateStr,
                                "dd-MM-yyyy",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out parsedDate))
                        {
                            failedCount++;
                            continue;
                        }

                        decimal amountValue;
                        if (!decimal.TryParse(
                                amountStr,
                                NumberStyles.Number,
                                CultureInfo.CurrentCulture,
                                out amountValue))
                        {
                            failedCount++;
                            continue;
                        }

                        // Add to list
                        transactionList.Insert(0, new Transaction
                        {
                            Date = parsedDate.ToString("dd-MM-yyyy"),
                            Description = description,
                            DebitAccount = debitAccount,
                            CreditAccount = creditAccount,
                            Amount = amountValue
                        });

                        successCount++;
                    }
                    catch
                    {
                        failedCount++;
                    }
                }

                // Refresh bound views
                UpdateAccountsGrid();
                SortGeneralJournalByDate();
                UpdateBalanceSheet();

                if (comboBox3.SelectedItem is Account)
                {
                    comboBox3_SelectedIndexChanged(comboBox3, EventArgs.Empty);
                }

                MessageBox.Show(
                    $"Loaded {successCount} transaction(s).\n" +
                    (failedCount > 0 ? $"Skipped {failedCount} invalid row(s)." : ""),
                    "Import Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void btnLoadTransactionsCSV_Click(object sender, EventArgs e)
        {
            LoadTransactionsFromCsv();
        }
    }
}

