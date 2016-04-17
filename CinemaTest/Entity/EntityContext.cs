using CinemaTest.Models;

namespace CinemaTest.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EntityContext : DbContext
    {

        public EntityContext()
            : base("name=EntityContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Show> Shows { get; set; }


    }

}