using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkMultiDeveloper.Models
{
    public class HouseHoldDataContext : DbContext
    {
        public HouseHoldDataContext() : base("name=Household")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
    }
}