namespace Portfolio.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Portfolio.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Portfolio.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(userStore);
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // Check to see if a user exists  
            // You can change admin's username and password below
            // To change to your email, change MainTest@yahoo.com to your email
            if (!(context.Users.Any(u => u.UserName == "MainTest@yahoo.com")))
            {
                var user = new ApplicationUser { UserName = "MainTest@yahoo.com" };
                /// Change Password2 to something else if you want to change the password.
                UserManager.Create(user, "Password2");
                // Check to see if Role exists
                if (!RoleManager.RoleExists("Admin"))
                {
                    RoleManager.Create(new IdentityRole("Admin"));
                }
                UserManager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
