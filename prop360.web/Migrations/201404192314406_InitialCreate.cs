namespace prop360.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        ProfBuyerId = c.Int(nullable: false),
                        PriceLow = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceHigh = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EffectiveFrom = c.DateTime(nullable: false),
                        EffectiveThru = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CellPhone = c.String(),
                        SecondPhone = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        PropertyType = c.Int(nullable: false),
                        ForRent = c.Boolean(nullable: false),
                        ForSale = c.Boolean(nullable: false),
                        ProfId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        AskingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        HomeSize = c.Int(nullable: false),
                        LotSize = c.Int(nullable: false),
                        YearBuilt = c.Int(nullable: false),
                        Bedroom = c.Int(nullable: false),
                        Bathroom = c.Int(nullable: false),
                        Garage = c.Int(nullable: false),
                        Story = c.Int(nullable: false),
                        Roof = c.String(),
                        Exterior = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
        }
    }
}
