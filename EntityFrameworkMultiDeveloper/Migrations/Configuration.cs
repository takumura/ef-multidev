namespace EntityFrameworkMultiDeveloper.Migrations
{
    using EntityFrameworkMultiDeveloper.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkMultiDeveloper.Models.HouseHoldDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(EntityFrameworkMultiDeveloper.Models.HouseHoldDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.AccountTypes.AddOrUpdate(
                x => x.Description,
                new AccountType { Description = "Wage Income", SignId = (int)Sign.Plus },
                new AccountType { Description = "Miscellaneous Income", SignId = (int)Sign.Plus },
                new AccountType { Description = "Food expenses", SignId = (int)Sign.Minus },
                new AccountType { Description = "Other expenses", SignId = (int)Sign.Minus });
            context.SaveChanges();

            // remove unneccesary account record
            var list = context.Accounts.Where(x => !x.Date.HasValue).ToList();
            foreach (var item in list)
            {
                context.Accounts.Remove(item);
            }
            context.SaveChanges();

            // id for account is auto-increment field. So it always adds new records for each Update-Database.
            context.Accounts.AddOrUpdate(
                x => x.Id,
                new Account { AccountTypeId = 1, PaymentAmount = 40000, Date = new DateTime(2019, 1, 1) },
                new Account { AccountTypeId = 2, PaymentAmount = 30000, Date = new DateTime(2019, 1, 2) },
                new Account { AccountTypeId = 3, PaymentAmount = 20000, Date = new DateTime(2019, 1, 3) },
                new Account { AccountTypeId = 4, PaymentAmount = 10000, Date = new DateTime(2019, 1, 4) });
            context.SaveChanges();

        }
    }
}
