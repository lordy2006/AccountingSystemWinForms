using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemWinForms
{
    public class AccountDisplay
    {
        public required string Account { get; set; } = "";
        public required string Type { get; set; } = "";
        public required decimal Balance { get; set; }
    }

}
