namespace BDProjectsSellerPoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PROD",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PROD_CODE = c.String(nullable: false, maxLength: 50),
                        PROD_DESCRIPTION = c.String(nullable: false, maxLength: 50),
                        PROD_QUANTITY = c.Int(nullable: false),
                        PROD_PRICE = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.PROD_CODE });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.PROD");
        }
    }
}
