using System;
using System.Collections.Generic;

#nullable disable

namespace otus_hw6_base
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
        }

        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
