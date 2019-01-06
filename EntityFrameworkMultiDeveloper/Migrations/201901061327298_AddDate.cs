namespace EntityFrameworkMultiDeveloper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Date");
        }
    }
}
