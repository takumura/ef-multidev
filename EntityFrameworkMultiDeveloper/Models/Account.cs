using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkMultiDeveloper.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int AccountTypeId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime? Date { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}