using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand{ get; set; }
    }
}