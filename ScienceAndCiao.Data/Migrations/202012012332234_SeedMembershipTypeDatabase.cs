namespace ScienceAndCiao.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypeDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('Free Membership',0,90,0)");
            Sql("SELECT * FROM [dbo].[MembershipType]");
            Sql("DROP TABLE IF EXISTS [dbo].[MembershipType]");
            Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('Paid Membership',70,0,90)");
            Sql("SELECT * FROM [dbo].[MembershipType]");
            Sql("DROP TABLE IF EXISTS [dbo].[MembershipType]");
            Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('SAdmin',0,0,0)");
        }
        
        public override void Down()
        {
        }
    }
}
