﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPLab4.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }

        public string ProvinceCode { get; set; }
    }
}