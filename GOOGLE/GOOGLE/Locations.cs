﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOOGLE
{
    class Locations
    {
        public string SiteName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public Locations(string fromName, double Lat, double Long)
        {
            SiteName = fromName;
            Latitude = Lat;
            Longitude = Long;
        }
    }
}
