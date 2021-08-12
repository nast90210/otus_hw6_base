using System;
using System.Collections.Generic;

#nullable disable

namespace otus_hw6_base
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public long Account1 { get; set; }
        public string Currency { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool IsOpen { get; set; }
        public long ClientsId { get; set; }

        public virtual Client Clients { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
