using System;
using System.ComponentModel.DataAnnotations;

namespace SanjnaMvcPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]               // validating to produts page
        [Required]
        public string ProductName { get; set; }

        [StringLength(60, MinimumLength = 3)]               // validating added
        [Required]
        public string Material { get; set; }                 // validating added

        [StringLength(60, MinimumLength = 3)]                // validating added
        [Required]
        public string size { get; set; }

        [StringLength(60, MinimumLength = 3)]                // validating added
        [Required]
        public string Color { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]               // validation to price to enter digit only
       public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]          // validating added
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }                  // added new field in database as rating 
    }
}
