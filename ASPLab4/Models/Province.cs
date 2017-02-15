using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPLab4.Models
{
    public class Province
    {
        [Key]
        [MaxLength(5)]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }
    }
}