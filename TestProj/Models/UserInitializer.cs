using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Linq;

namespace TestProj.Models
{
    public class UserInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Roles.Add(new IdentityRole() { Name = "Admin" });
            context.Roles.Add(new IdentityRole() { Name = "User" });

            context.Positions.Add(new Position() { Name = "Boss" });
            context.Positions.Add(new Position() { Name = "Manager" });

            context.PositionRoles.Add(new PositionRole() { PositionId = context.Positions.ToList()[0].Id, RoleId = context.Roles.ToList()[0].Id });
            context.PositionRoles.Add(new PositionRole() { PositionId = context.Positions.ToList()[1].Id, RoleId = context.Roles.ToList()[1].Id });
        }
    }
}