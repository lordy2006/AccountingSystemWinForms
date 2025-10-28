using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemWinForms
{
    public class JournalEntry
    {
        public required string Date { get; set; } = "";
        public required string Description { get; set; } = "";
        public required string Account { get; set; } = "";
        public required decimal Debit { get; set; }
        public required decimal Credit { get; set; }
    }

}
