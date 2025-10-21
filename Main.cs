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
            this.Size = new Size(1363, 757); // set size again ( kay nay bug usahay )

            //display ang note
            NoteControl notes = new NoteControl();
            notes.Dock = DockStyle.Fill;
            notes.Margin = new Padding(0);
            this.Controls.Add(notes);
            notes.BringToFront();

            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
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
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
        }

        private void BtnNewTransactions_Click(object sender, EventArgs e)
        {
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);

            tabHolder.SelectedTab = tabNewTransactions;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.welcomeForm.Show();

        }

    }
}
