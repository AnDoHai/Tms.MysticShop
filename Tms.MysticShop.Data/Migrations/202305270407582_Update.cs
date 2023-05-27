namespace Tms.MysticShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Image", "ImageLink", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Image", "ImageLink", c => c.String(nullable: false));
        }
    }
}
