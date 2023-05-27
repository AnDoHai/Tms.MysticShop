namespace Tms.MysticShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillDetail",
                c => new
                {
                    BillDetailID = c.Int(nullable: false, identity: true),
                    BillID = c.Int(nullable: false),
                    Quanlity = c.Int(nullable: false),
                    Total = c.Single(nullable: false),
                    ProductDetailID = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.BillDetailID)
                .ForeignKey("dbo.Bill", t => t.BillID, cascadeDelete: true)
                .ForeignKey("dbo.ProductDetail", t => t.ProductDetailID, cascadeDelete: true)
                .Index(t => t.BillID)
                .Index(t => t.ProductDetailID);

            CreateTable(
                "dbo.Bill",
                c => new
                {
                    BillID = c.Int(nullable: false, identity: true),
                    BillName = c.String(nullable: false),
                    UserID = c.Int(nullable: false),
                    Total = c.Single(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.BillID);

            CreateTable(
                "dbo.ProductDetail",
                c => new
                {
                    ProductDetailID = c.Int(nullable: false, identity: true),
                    ProductID = c.Int(nullable: false),
                    ColorID = c.Int(nullable: false),
                    SizeID = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.ProductDetailID)
                .ForeignKey("dbo.Color", t => t.ColorID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Size", t => t.SizeID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.ColorID)
                .Index(t => t.SizeID);

            CreateTable(
                "dbo.Color",
                c => new
                {
                    ColorID = c.Int(nullable: false, identity: true),
                    ColorName = c.String(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.ColorID);

            CreateTable(
                "dbo.Product",
                c => new
                {
                    ProductID = c.Int(nullable: false, identity: true),
                    CategoryID = c.Int(nullable: false),
                    ProductName = c.String(nullable: false),
                    Description = c.String(),
                    Price = c.Single(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);

            CreateTable(
                "dbo.Category",
                c => new
                {
                    CategoryID = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.CategoryID);

            CreateTable(
                "dbo.Size",
                c => new
                {
                    SizeID = c.Int(nullable: false, identity: true),
                    SizeName = c.String(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.SizeID);

            CreateTable(
                "dbo.Image",
                c => new
                {
                    ImageID = c.Int(nullable: false, identity: true),
                    ImageLink = c.String(nullable: false),
                    ProductDetailID = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.ProductDetail", t => t.ProductDetailID, cascadeDelete: true)
                .Index(t => t.ProductDetailID);

            CreateTable(
                "dbo.UserRole",
                c => new
                {
                    UserRoleID = c.Int(nullable: false, identity: true),
                    UserRoleName = c.String(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.UserRoleID);

            CreateTable(
                "dbo.User",
                c => new
                {
                    UserID = c.Int(nullable: false, identity: true),
                    UserName = c.String(nullable: false),
                    Email = c.String(nullable: false),
                    PhoneNumber = c.String(nullable: false),
                    Address = c.String(nullable: false),
                    Password = c.String(nullable: false),
                    UserRoleID = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    CreatedBy = c.String(maxLength: 300),
                })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.UserRole", t => t.UserRoleID, cascadeDelete: true)
                .Index(t => t.UserRoleID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.User", "UserRoleID", "dbo.UserRole");
            DropForeignKey("dbo.Image", "ProductDetailID", "dbo.ProductDetail");
            DropForeignKey("dbo.BillDetail", "ProductDetailID", "dbo.ProductDetail");
            DropForeignKey("dbo.ProductDetail", "SizeID", "dbo.Size");
            DropForeignKey("dbo.ProductDetail", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.ProductDetail", "ColorID", "dbo.Color");
            DropForeignKey("dbo.BillDetail", "BillID", "dbo.Bill");
            DropIndex("dbo.User", new[] { "UserRoleID" });
            DropIndex("dbo.Image", new[] { "ProductDetailID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.ProductDetail", new[] { "SizeID" });
            DropIndex("dbo.ProductDetail", new[] { "ColorID" });
            DropIndex("dbo.ProductDetail", new[] { "ProductID" });
            DropIndex("dbo.BillDetail", new[] { "ProductDetailID" });
            DropIndex("dbo.BillDetail", new[] { "BillID" });
            DropTable("dbo.User");
            DropTable("dbo.UserRole");
            DropTable("dbo.Image");
            DropTable("dbo.Size");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Color");
            DropTable("dbo.ProductDetail");
            DropTable("dbo.Bill");
            DropTable("dbo.BillDetail");
        }
    }
}
