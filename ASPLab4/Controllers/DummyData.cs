using ASPLab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPLab4.Controllers
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Models.Province()
                {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia"
                },
                new Models.Province()
                {
                    ProvinceCode="AB",
                    ProvinceName="Alberta"
                },
                new Models.Province()
                {
                    ProvinceCode="ON",
                    ProvinceName="Ontario"
                },
            };

            return provinces;
        }

        public static System.Collections.Generic.List<City> getCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>()
            {
                new Models.City()
                {
                    CityName = "Vancouver",
                    Population = 2000000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Victoria",
                    Population = 80000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Kelowna",
                    Population = 107000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Calgary",
                    Population = 1100000,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Edmonton",
                    Population = 800000,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Lethbridge",
                    Population = 93000,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Toronto",
                    Population = 2600000,
                    ProvinceCode = context.Provinces.Find("ON").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Ottawa",
                    Population = 880000,
                    ProvinceCode = context.Provinces.Find("ON").ProvinceCode
                },
                new Models.City()
                {
                    CityName = "Hamilton",
                    Population = 520000,
                    ProvinceCode = context.Provinces.Find("ON").ProvinceCode
                },
            };

            return cities;
        }
    }
}