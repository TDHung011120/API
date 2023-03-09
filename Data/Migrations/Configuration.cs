namespace Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.APIDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.APIDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new APIDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new APIDbContext()));
            var user = new ApplicationUser()
            {
                UserName = "Hung",
                Email = "trinhdinhhung2468@gmail.com",
                EmailConfirmed = true,
                BirtDay = DateTime.Now,
                FullName = "Trinh Đình Hùng"
            };
            manager.Create(user, "123456$");
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole("Admin"));
                roleManager.Create(new IdentityRole("User"));
            }
            var adminUser = manager.FindByEmail("trinhdinhhung2468@gmail.com");
            manager.AddToRoles(adminUser.Id,new string[] { "Admin", "User" });
        }
    }
}
