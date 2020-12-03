namespace ScienceAndCiao.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoolToCheckBaseKit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kit", "UserHasBaseKit", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kit", "UserHasBaseKit");
        }
    }
}
