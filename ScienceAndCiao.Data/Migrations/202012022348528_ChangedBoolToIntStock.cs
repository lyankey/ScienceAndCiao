namespace ScienceAndCiao.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBoolToIntStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kit", "Stock", c => c.Int(nullable: false));
            DropColumn("dbo.Kit", "UserHasBaseKit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kit", "UserHasBaseKit", c => c.Boolean(nullable: false));
            DropColumn("dbo.Kit", "Stock");
        }
    }
}
