using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class Admin : User
    {
        public string AdminName { get; set; }
        public bool Approve { get; set; } //onay
    }
}