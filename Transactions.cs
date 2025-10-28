using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemWinForms
{
    public class Transaction
    {
        public required string Date { get; set; }
        public required string Description { get; set; }
        public required string DebitAccount { get; set; }
        public required string CreditAccount { get; set; }
        public required decimal Amount { get; set; }
    }

}
