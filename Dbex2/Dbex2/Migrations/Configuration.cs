namespace Dbex2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dbex2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dbex2.Models.ApplicationDbContext context)
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
            context.FakeUsers.AddOrUpdate(
                p => p.FakeName,
                  new Models.FakeUser{ FakeName = DateTime.Now.AddYears(-100).ToLongDateString(), FakeDate="Andrew Peters"},
                  new Models.FakeUser { FakeName = DateTime.Now.AddDays(15).ToLongDateString(), FakeDate = "Brice Lambson" },
                  new Models.FakeUser { FakeName = DateTime.Now.AddDays(-15).ToLongDateString(), FakeDate = "Rowan Miller" }
                  );
        }
    }
}
