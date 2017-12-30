namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipAndCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "MemberShipType_ID", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShipType_ID");
            AddForeignKey("dbo.Customers", "MemberShipType_ID", "dbo.MemberShipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_ID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_ID" });
            DropColumn("dbo.Customers", "MemberShipType_ID");
            DropColumn("dbo.Customers", "IsActive");
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
