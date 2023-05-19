using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public interface IAdvertise
    {
        int ID { get; set; }
        string Name { get; set; }

        void Add();
        void Update();
        void Delete();
    }
}