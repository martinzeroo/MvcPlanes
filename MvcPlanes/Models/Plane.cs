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
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Departure { get; set; }
        public string Model { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        internal static Task<List<Plane>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}