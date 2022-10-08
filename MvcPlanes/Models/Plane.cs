using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MvcPlane.Models
{
    public class Plane
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Departure")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Departure { get; set; }

        [Display(Name = "Model")]
        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Display(Name = "Price")]
        [Range(1, 2000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Speed km/h")]
        [Required]
        public string Speed { get; set; }

    }
}