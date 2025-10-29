using System.ComponentModel;
using System.Windows.Forms;

namespace AccountingSystemWinForms
{
    public partial class Main : Form
    {
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

            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )

            dgvGeneralJournal.CellFormatting += dgvGeneralJournal_CellFormatting;


            dgvTransaction.AutoGenerateColumns = false;

            dgvTransaction.DataSource = transactionList;


            UiDesign.ApplyShadow(this);
            comboBox1.DataSource = new List<Account>(allAccounts);
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Name";

            comboBox2.DataSource = new List<Account>(allAccounts);
            comboBox2.DisplayMember = "DisplayName";
            comboBox2.ValueMember = "Name";

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
            string date = textBox4.Text.Trim();
            string description = textBox2.Text.Trim();
            var debitAccount = comboBox1.SelectedItem as Account;
            var creditAccount = comboBox2.SelectedItem as Account;
            string amountText = textBox5.Text.Trim();

            // Validate values
            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(description) ||
                debitAccount == null || creditAccount == null || string.IsNullOrWhiteSpace(amountText))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Strongly type: parse the amount as decimal
            decimal amountValue;
            if (!decimal.TryParse(amountText, out amountValue))
            {
                MessageBox.Show("Please enter a valid amount (numbers only).");
                return;
            }

            // Show confirmation dialog (still passes string to show as-is in dialog)
            using (var confirm = new DialogAddTransactions(
                date,
                description,
                debitAccount.DisplayName,
                creditAccount.DisplayName,
                amountValue.ToString("N2"))) // Format for dialog
            {
                if (confirm.ShowDialog() == DialogResult.OK && confirm.IsConfirmed)
                {
                    // Add to the list; DataGridView auto-refreshes
                    transactionList.Insert(0, new Transaction
                    {
                        Date = date,
                        Description = description,
                        DebitAccount = debitAccount.DisplayName,
                        CreditAccount = creditAccount.DisplayName,
                        Amount = amountValue // decimal property!
                    });

                    // Optional: Currency formatting for grid column


                    MessageBox.Show("Transaction Confirmed!");

                    // Optional: clear the form after adding
                    btnClearForm.PerformClick();

                    UpdateAccountsGrid();
                    UpdateGeneralJournalGrid();
                }
                else
                {
                    // User cancelled - do nothing
                }




            }
        }

        private void UpdateGeneralJournalGrid()
        {
            var journalRows = new List<JournalEntry>();

            foreach (var t in transactionList)
            {
                // Debit row
                journalRows.Add(new JournalEntry
                {
                    Date = t.Date,
                    Description = t.Description,
                    Account = t.DebitAccount,
                    Debit = t.Amount,
                    Credit = 0
                });

                // Credit row (indented, blank date/desc)
                journalRows.Add(new JournalEntry
                {
                    Date = "", // group visually
                    Description = "",
                    Account = "    " + t.CreditAccount, // 4 spaces
                    Debit = 0,
                    Credit = t.Amount
                });
            }

            dgvGeneralJournal.DataSource = new BindingList<JournalEntry>(journalRows);
        }


        private void UpdateAccountsGrid()
        {
            var accountDisplays = allAccounts
                .Select(acc => new AccountDisplay
                {
                    Account = acc.Name,
                    Type = acc.Type,
                    Balance = CalculateBalance(acc.DisplayName)
                })
                .ToList();

            dgvAccounts.DataSource = new BindingList<AccountDisplay>(accountDisplays);

        }

        private decimal CalculateBalance(string accountDisplayName)
        {
            decimal debit = transactionList
                .Where(t => t.DebitAccount == accountDisplayName)
                .Sum(t => t.Amount);

            decimal credit = transactionList
                .Where(t => t.CreditAccount == accountDisplayName)
                .Sum(t => t.Amount);

            // For demo: balance = debits - credits (adjust per account type if needed)
            return debit - credit;
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
            UpdateGeneralJournalGrid();


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
            textBox4.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox5.Clear();
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox8.Text.Trim().ToLower();

            // If search is empty, show the full list
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvTransaction.DataSource = new BindingList<Transaction>(transactionList.ToList());
                return;
            }

            // Filter the list
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

        private void dgvGeneralJournal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Only format Debit and Credit columns
            if (dgvGeneralJournal.Columns[e.ColumnIndex].Name == "Debit" ||
                dgvGeneralJournal.Columns[e.ColumnIndex].Name == "Credit")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    if (val == 0m)
                    {
                        e.Value = "";              // Show blank for zero
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = val.ToString("N2"); // Keep formatting for non-zero
                        e.FormattingApplied = true;
                    }
                }
            }
        }

    }
}
