namespace SkodaShop.Data.Common
{
    using System;
    using System.Text;

    public class RandomGenerator : IRandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUWXVYZabcdefghijklmnopqrstuwxvyz";

        private string[] images = new string[] { "octavia2013.jpg", "rapid2012.jpg", "superb2014.jpeg", "remak.jpg", "oil.jpg", "no_image.png", 
            "icon-sintetika.jpg", "filters.jpg", "engine.jpg", "disks.jpg", "clutch.jpg", "castrol.jpg", "bialet.jpg"};

        private string[] categories = new string[] {"Tyre", "Shock", "Repair Part", "Engine", "Clutch", "Exhaust" };

        private string[] models = new string[] {"Fabia", "Octavia", "Rapid", "Octavia2", "Superb", "Roomster", "Citigo", "FabiaRS" };

        private Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public string RandomString(int minLength, int maxLength)
        {
            var result = new StringBuilder();
            var length = this.random.Next(minLength, maxLength + 1);
            for (int i = 0; i <= length; i++)
            {
                result.Append(Letters[this.random.Next(0, Letters.Length)]);
            }

            return result.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string RandomImage()
        {
            return images[this.random.Next(0, images.Length)];
        }

        public string RandomCategory()
        {
            return categories[this.random.Next(0, categories.Length)];
        }

        public string RandomModels()
        { 
            return models[this.random.Next(0, models.Length)];
        }
    }
}