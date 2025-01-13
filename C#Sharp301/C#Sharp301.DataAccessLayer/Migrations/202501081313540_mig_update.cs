namespace C_Sharp301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductDescription", c => c.String());
            DropColumn("dbo.Products", "ProductStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Products", "ProductDescription");
        }
    }
}
