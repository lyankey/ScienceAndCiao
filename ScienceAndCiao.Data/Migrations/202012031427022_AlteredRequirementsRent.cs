namespace ScienceAndCiao.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredRequirementsRent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rental", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Rental", "Duration", c => c.DateTime());
            AlterColumn("dbo.Rental", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rental", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rental", "Duration", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rental", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
