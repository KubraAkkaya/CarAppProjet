using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarAppProjet.Models.Classes
{
    public class Context:DbContext
    {

        private static Context instance; //singlton tasarım prensibi

        public Context()
        {
            // Özel yapıcı metot, sınıf dışında bir örneğin oluşturulmasını engeller.
        }

        public static Context Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Context();
                }
                return instance;
            }
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}