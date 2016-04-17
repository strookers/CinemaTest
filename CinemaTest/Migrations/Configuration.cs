using System.Globalization;
using CinemaTest.Models;

namespace CinemaTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CinemaTest.Entity.EntityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CinemaTest.Entity.EntityContext context)
        {
            context.Movies.AddOrUpdate(
              p => p.Id,
              new Movie { Id = new Guid("44e11b12-c9b7-44b2-8ef5-41c67fbe70ec"), Name = "Batman" },
              new Movie { Id = new Guid("f81df7ba-165a-40e6-88cd-cd7193a14f34"), Name = "Star Wars" },
              new Movie { Id = new Guid("FCDE3A07-6FC9-48CA-AB88-713AEA94E322"), Name = "Hunger Games" },
              new Movie { Id = new Guid("FCADDE83-FC15-4581-9CEB-AF1C738BBD81"), Name = "Star Trek" }
            );

            context.Screens.AddOrUpdate(
                s => s.Id,
                new Screen { Id = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"), Name = "sal 1", Description = "flot sal" },
                new Screen { Id = new Guid("689c15e4-f631-468e-84e0-3d46cd49482b"), Name = "sal 2", Description = "Virkelig flot sal" }
                );

            context.Shows.AddOrUpdate(
                x => x.Id,
                new Show
                {
                    Id = new Guid("a1cd09de-9261-4966-98f4-af60603111e7"),
                    MovieId = new Guid("44e11b12-c9b7-44b2-8ef5-41c67fbe70ec"),
                    ScreenId = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"),
                    DateTime = DateTime.ParseExact("2016-12-06 14:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new Show
                {
                    Id = new Guid("E3145D35-D4BE-4BE9-81C7-0D8C6B3B9C58"),
                    MovieId = new Guid("44E11B12-C9B7-44B2-8EF5-41C67FBE70EC"),
                    ScreenId = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"),
                    DateTime = DateTime.ParseExact("2016-12-06 16:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new Show
                {
                    Id = new Guid("A6A7089B-B07A-4D8B-86A6-1E902071AD9D"),
                    MovieId = new Guid("44E11B12-C9B7-44B2-8EF5-41C67FBE70EC"),
                    ScreenId = new Guid("2b1e1e69-9f0a-41d3-9d63-d04cf97614dc"),
                    DateTime = DateTime.ParseExact("2016-12-06 18:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new Show
                {
                    Id = new Guid("36F6C92F-F3E4-4765-838F-4D8C7BE5B6D7"),
                    MovieId = new Guid("FCDE3A07-6FC9-48CA-AB88-713AEA94E322"),
                    ScreenId = new Guid("689C15E4-F631-468E-84E0-3D46CD49482B"),
                    DateTime = DateTime.ParseExact("2016-12-06 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                });
        }
    }
}
