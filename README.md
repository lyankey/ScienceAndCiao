# ScienceAndCiao
This is a Science and Ciao version made with WebApi enabled. I have changed the name to Science and Chow. 
1. For this to work, you must clone and build the project and then follow a few steps to add your content in the correct order.
2. Then, you must seed the membership type data through a migration. Here is the seed data for membership types:
Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('Free Membership',0,90,0)");
            Sql("SELECT * FROM [dbo].[MembershipType]");
            Sql("DROP TABLE IF EXISTS [dbo].[MembershipType]");
            Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('Paid Membership',70,0,90)");
            Sql("SELECT * FROM [dbo].[MembershipType]");
            Sql("DROP TABLE IF EXISTS [dbo].[MembershipType]");
            Sql("INSERT INTO [dbo].[MembershipType](Name,SignUpFee,SixMonthMemberShipFee,MonthlyMembershipFee) VALUES('SAdmin',0,0,0)");
3. Then, you can create a user - you will need to register as an admin, but as it is right now, you can't. The code is in the Account Controller and the notes will tell you what to do. 
4. After you register as an admin you can change the code back so new users can't register as an admin. 
5. Then you must add your branches of science. Use the dropdown Admin menu from the navbar and you can easily add the branches through the branches page. 
6. Finally, you can add your kits. 

