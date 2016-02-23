namespace KFC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id_role = c.String(nullable: false, maxLength: 128),
                        role_name = c.String(),
                    })
                .PrimaryKey(t => t.id_role);
            
            AddColumn("dbo.Users", "login", c => c.String());
            AddColumn("dbo.Users", "role_id", c => c.String());
            DropColumn("dbo.Users", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "user", c => c.String());
            DropColumn("dbo.Users", "role_id");
            DropColumn("dbo.Users", "login");
            DropTable("dbo.Roles");
        }
    }
}
