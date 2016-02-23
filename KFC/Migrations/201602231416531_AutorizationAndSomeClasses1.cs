namespace KFC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutorizationAndSomeClasses1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        id_ingredient = c.Single(nullable: false),
                        ingredient_name = c.String(),
                        measure_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_ingredient);
            
            CreateTable(
                "dbo.Measures",
                c => new
                    {
                        id_measure = c.Long(nullable: false, identity: true),
                        measure_name = c.String(),
                    })
                .PrimaryKey(t => t.id_measure);
            
            CreateTable(
                "dbo.ReceiptDetails",
                c => new
                    {
                        id_receiptDetail = c.Long(nullable: false, identity: true),
                        receipt_id = c.Long(nullable: false),
                        ingredient_id = c.Long(nullable: false),
                        quantity = c.Single(nullable: false),
                        ingredient_costPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id_receiptDetail);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        id_receipt = c.Long(nullable: false, identity: true),
                        receipt_number = c.String(),
                        receipt_date = c.DateTime(nullable: false),
                        user_id = c.Long(nullable: false),
                        supplier_id = c.Long(nullable: false),
                        receipt_summ = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id_receipt);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        id_supplier = c.Long(nullable: false, identity: true),
                        supplier_name = c.String(),
                        supplier_fio = c.String(),
                        supplier_address = c.String(),
                        supplier_phone = c.String(),
                    })
                .PrimaryKey(t => t.id_supplier);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
            DropTable("dbo.Receipts");
            DropTable("dbo.ReceiptDetails");
            DropTable("dbo.Measures");
            DropTable("dbo.Ingredients");
        }
    }
}
