using Microsoft.AspNetCore.Mvc.Rendering;
using MvcPlane.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcPlanes.Models
{
    public class PlaneModelViewModel
    {
        public List<Plane> Planes { get; set; }
        public SelectList Model { get; set; }

        [Display(Name = "Model")]
        public string PlaneModel { get; set; }

        [Display(Name = "Name")]
        public string SearchString { get; set; }
    }
}
