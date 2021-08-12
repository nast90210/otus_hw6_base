using System;
using System.Collections.Generic;

#nullable disable

namespace otus_hw6_base
{
    public partial class Transaction
    {
        public long Id { get; set; }
        public long Ammount { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public long AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
