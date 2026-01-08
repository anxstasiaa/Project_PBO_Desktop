using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Project_PBO.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Project_PBO_Desktop.SiakadContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project_PBO_Desktop.SiakadContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
