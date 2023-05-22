using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class CarBrandModel
    {
        public IEnumerable<Car> ValueCar { get; set; }
        public IEnumerable<Brand> ValueBrand { get; set; }
        public IEnumerable<Model> ValueModel { get; set; }
        public IEnumerable<CarOwner> ValueCarOwner { get; set; }
        public IEnumerable<CarType> ValueCarType { get; set; }
        public IEnumerable<Color> ValueColor { get; set; }
        public IEnumerable<City> ValueCity { get; set; }
        public IEnumerable<IUser> ValueUser { get; set; }
        public IEnumerable<Comment> ValueComment { get; set; }
        public IEnumerable<About> ValueAbout { get; set; }

    }
}