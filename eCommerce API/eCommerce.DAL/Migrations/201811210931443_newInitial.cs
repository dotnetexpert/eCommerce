namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        ProductPrice = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ProductCategory = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCatID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ProductCatID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.Int(nullable: false),
                        ProductCatID = c.Int(),
                        VendorID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCatID)
                .ForeignKey("dbo.Vendors", t => t.VendorID)
                .Index(t => t.ProductCatID)
                .Index(t => t.VendorID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorID = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                        ProductCatID = c.Int(),
                    })
                .PrimaryKey(t => t.VendorID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCatID)
                .Index(t => t.ProductCatID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Token = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "VendorID", "dbo.Vendors");
            DropForeignKey("dbo.Vendors", "ProductCatID", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ProductCatID", "dbo.ProductCategories");
            DropIndex("dbo.Vendors", new[] { "ProductCatID" });
            DropIndex("dbo.Products", new[] { "VendorID" });
            DropIndex("dbo.Products", new[] { "ProductCatID" });
            DropTable("dbo.Users");
            DropTable("dbo.Vendors");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Orders");
        }
    }
}
