﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class Color
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }   

    }
}