namespace WebApplication1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml.Schema;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebApplication1.Models.ApplicationDbContext";
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("Apple#1");

            context.Users.AddOrUpdate(x => x.Id,
                new Models.ApplicationUser() {
                    Id = "2",
                    Email = "josh.madurai@gmail.com",
                    EmailConfirmed = false,
                    
                    PasswordHash = password,
                    SecurityStamp=Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEndDateUtc = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "josh.madurai@gmail.com" }
                    
                
                );
        }
    }
}
