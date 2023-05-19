using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public interface IUser<T> where T : class, IAdvertise,IComment, ISearch
    {
        [Key]
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Mail { get; set; }
        string Password { get; set; }

    }
}