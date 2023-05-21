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
        public int Year { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Description { get; set; }
        public string PhotoCarURL { get; set; }

        public int Doors { get; set; }
        public bool FogLights { get; set; } //sis farı
        public bool FoldableMirror { get; set; } //katlanabilir ayna
        public bool ParkingSensor { get; set; } 
        public bool CentralLocking { get; set; } //merkezi kilit
        public bool GlassCeiling { get; set; } //cam tavan
        
        public ICollection<Comment> Comments { get; set; }
        public CarOwner CarOwnerId { get; set; }
        public Brand BrandId { get; set; }
        public Model ModelId { get; set; }
        public City CityId{ get; set; }
        public Color ColorId { get; set; }
        public CarType CarTypeId { get; set; }
    }
}