namespace SkodaShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;

    using SkodaShop.Data.Migrations;
    using SkodaShop.Data.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Part> Parts { get; set; }

        public IDbSet<Order> Orders { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}