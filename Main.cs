using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
            UiDesign.ApplyShadow(this);
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
            this.Close();
            WelcomeForm.welcomeForm.Show();

        }

        private void BtnNewTransactions_Click(object sender, EventArgs e)
        {
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);

            tabHolder.SelectedTab = tabNewTransactions;
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            DialogAddTransactions addTransactions = new DialogAddTransactions();
            UiDesign.ShowDialogDimBackground(this, addTransactions, 15);
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
        }
        private void btnGeneralJournal_Click(object sender, EventArgs e)
        {
            btnGeneralJournal.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabGeneralJournal;

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
    }
}
