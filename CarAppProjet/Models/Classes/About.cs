﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}