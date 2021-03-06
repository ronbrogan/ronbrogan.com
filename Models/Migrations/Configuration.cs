namespace Models.Migrations
{
    using Common.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.BroganContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //SetSqlGenerator("System.Data.SqlClient", new DefaultSqlValueSqlMigrator());
            CodeGenerator = new DefaultValueCodeGenerator();
        }

        protected override void Seed(Models.BroganContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
