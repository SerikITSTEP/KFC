namespace KFC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutorizationAndSomeClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id_product = c.Long(nullable: false, identity: true),
                        product_name = c.String(),
                        product_costPrice = c.Single(nullable: false),
                        product_price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id_product);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
