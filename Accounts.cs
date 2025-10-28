using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemWinForms
{
    public class Account
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string DisplayName => $"{Name} [{Type}]";
        public override string ToString() => DisplayName;
    }



}
