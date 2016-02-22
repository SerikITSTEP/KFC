namespace KFC.Migrations
{
    using KFC.models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KFC.DATA.KFCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KFC.DATA.KFCDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Users.AddOrUpdate(
              p => p.login,
              new User { login = "admin", password="admin",role_id="admin" }
            );

            context.Roles.AddOrUpdate(
              p => p.id_role,
              new Role { id_role = "admin", role_name="Администратор"}
            );
            //
        }
    }
}
