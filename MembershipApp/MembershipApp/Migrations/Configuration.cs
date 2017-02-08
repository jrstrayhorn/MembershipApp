namespace MembershipApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MembershipApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            // setting the following properties to allow more smooth updates to
            // database during development; should remove to use property below
            // when working with a production database
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            //AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MembershipApp.Models.ApplicationDbContext context)
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
