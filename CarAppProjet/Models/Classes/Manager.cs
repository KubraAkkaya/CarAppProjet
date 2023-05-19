using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAppProjet.Models.Classes
{
    public class Manager : IUser
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Mail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Approve { get; set; } //onay
    }
}