namespace SkodaShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using SkodaShop.Data.Common;
    using SkodaShop.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        private IRandomGenerator random;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            this.random = new RandomGenerator();
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedOrders(context);
            SeedParts(context);           
        }

        private void SeedOrders(ApplicationDbContext context)
        {
            if (context.Orders.Any())
            {
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                var order = new Order
                {
                    ReceiverName = random.RandomString(4, 10),
                    PhoneNumber = random.RandomNumber(811111111, 899999999),
                    Email = string.Format("{0}@{1}.com", this.random.RandomString(6, 16), this.random.RandomString(6, 16)),
                    Address = random.RandomString(4, 10),
                    PartId = random.RandomNumber(1, 10)
                };

                context.Orders.Add(order);
            }

            context.SaveChanges();
        }

        private void SeedParts(ApplicationDbContext context)
        {
            if (context.Parts.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                var part = new Part
                {
                    Price = random.RandomNumber(10, 350) + 0.50m,
                    Name = random.RandomString(5, 10),
                    Manufacturer = "Skoda",
                    CatalogNumber = i +1,
                    FromYear = random.RandomNumber(2005, 2009),
                    ToYear = random.RandomNumber(2009, 2014),
                    PictureUrl = random.RandomImage(),
                    Make = "Skoda",
                    Model = random.RandomModels(),
                    Categories = random.RandomCategory(),
                    // OrderId = random.RandomNumber(1,4),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam in malesuada odio."
                };

                context.Parts.Add(part);                
            }

            context.SaveChanges();
        }        
    }
}