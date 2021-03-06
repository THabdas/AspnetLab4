namespace ASPLab4.Migrations.IdentityMigrations
{
    using Controllers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPLab4.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(ASPLab4.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(
                p => p.ProvinceCode, DummyData.getProvinces().ToArray());
            context.SaveChanges();

            context.Cities.AddOrUpdate(
                p => new { p.CityId, p.CityName }, DummyData.getCities(context).ToArray());
            
        }
    }
}
