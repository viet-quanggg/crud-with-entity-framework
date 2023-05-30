using System;
using System.Collections.Generic;

#nullable disable

namespace PRN211.Models
{
    public partial class BankAccount
    {
        internal int AccountType;

        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? OpenDate { get; set; }
        public string BranchName { get; set; }
        public string TypeId { get; set; }

        public virtual AccountType Type { get; set; }
    }
}
