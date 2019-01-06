namespace EntityFrameworkMultiDeveloper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntroduceSign : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountTypes", "SignId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountTypes", "SignId");
        }
    }
}
