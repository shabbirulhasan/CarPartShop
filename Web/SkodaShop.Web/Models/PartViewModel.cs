namespace SkodaShop.Web.Models
{    
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using SkodaShop.Data.Models;

    public class PartViewModel
    {
        public static Expression<Func<Part, PartViewModel>> FromPart
        {
            get
            {
                return r => new PartViewModel
                {
                    Id = r.Id,
                    Description = r.Description,
                    Price = r.Price,
                    PictureUrl = r.PictureUrl
                };
            }
        }

        public int Id { get; set; }        

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string PictureUrl { get; set; }
    }
}