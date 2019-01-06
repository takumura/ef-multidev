using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkMultiDeveloper.Models
{
    public enum Sign
    {
        Plus,
        Minus
    }

    public class AccountType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int SignId { get; set; }

        ICollection<Account> Accounts { get; set; }
    }
}