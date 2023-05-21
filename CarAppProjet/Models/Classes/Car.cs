using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        public Brand BrandName { get; set; }
        public Model ModelName { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public double Price { get; set; }
        public string FuelType { get; set; }
        public string Description { get; set; }
        public string CarType { get; set; }
        public string PhotoCarURL { get; set; }
        public string GearType { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public bool FogLights { get; set; } //sis farı
        public bool FoldableMirror { get; set; } //katlanabilir ayna
        public bool ParkingSensor { get; set; } 
        public bool CentralLocking { get; set; } //merkezi kilit
        public bool GlassCeiling { get; set; } //cam tavan
        
        public ICollection<Comment> Comments { get; set; }

    }
}