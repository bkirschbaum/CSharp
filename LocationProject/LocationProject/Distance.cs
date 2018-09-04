using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationProject
{
    class Distance
    {
        public string FromSite { get; set; }
        public string ToSite { get; set; }
        public double Miles { get; set; }


        public Distance(string fromName,string toSite, double distance)
        {
            FromSite = fromName;
            ToSite = toSite;
            Miles = distance;
        }
    }
}
