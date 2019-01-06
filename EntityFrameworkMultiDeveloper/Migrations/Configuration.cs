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
                new AccountType { Description = "Wage Income" },
                new AccountType { Description = "Miscellaneous Income" },
                new AccountType { Description = "Food expenses" },
                new AccountType { Description = "Other expenses" });
            context.SaveChanges();


            // id for account is auto-increment. So always add new record for each Update-Database.
            context.Accounts.AddOrUpdate(
                x => x.Id,
                new Account { AccountTypeId = 1, PaymentAmount = 40000 },
                new Account { AccountTypeId = 2, PaymentAmount = 30000 },
                new Account { AccountTypeId = 3, PaymentAmount = 20000 },
                new Account { AccountTypeId = 4, PaymentAmount = 10000 });
            context.SaveChanges();

        }
    }
}
