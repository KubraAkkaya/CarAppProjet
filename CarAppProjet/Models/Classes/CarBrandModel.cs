using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class CarBrandModel
    {
        public IEnumerable<Car> Value1 { get; set; }
        public IEnumerable<Brand> Value2 { get; set; }
        public IEnumerable<Comment> Value3 { get; set; }

    }
}