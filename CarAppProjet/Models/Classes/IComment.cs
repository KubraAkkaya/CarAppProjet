using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppProjet.Models.Classes
{
    public interface IComment
    {
        int ID { get; set; }
        string Name { get; set; }
        void Add();
        void Delete();
        void Update();
    }
}
