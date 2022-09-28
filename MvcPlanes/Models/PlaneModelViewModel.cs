using Microsoft.AspNetCore.Mvc.Rendering;
using MvcPlane.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlanes.Models
{
    public class PlaneModelViewModel
    {
        public List<Plane> Planes { get; set; }
        public SelectList Model { get; set; }
        public string PlaneModel { get; set; }
        public string SearchString { get; set; }
    }
}
