namespace SkodaShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(30, MinimumLength = 6)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }

        public int CatalogNumber { get; set; }

        public int? FromYear { get; set; }

        public int? ToYear { get; set; }

        public string PictureUrl { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Categories { get; set; }

        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}