﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class CarType
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}