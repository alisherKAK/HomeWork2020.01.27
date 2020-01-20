namespace TestProj.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestProj.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestProj.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestProj.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Roles.Add(new IdentityRole() { Name = "Admin" });
            context.Roles.Add(new IdentityRole() { Name = "User" });

            context.Positions.Add(new Position() { Name = "Boss" });
            context.Positions.Add(new Position() { Name = "Manager" });
        }
    }
}
