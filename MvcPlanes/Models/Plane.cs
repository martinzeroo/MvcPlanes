using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPlane.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Departure { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}