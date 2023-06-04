using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppProjet.Models.Abstract
{
    internal interface IAdvertise
    {
        int ID { get; set; }
        //  string Name { get; set; }
        void Add();
        void Update();
        void Delete();
    }
}
