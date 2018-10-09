using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleDirections;
using System.Configuration;


namespace GOOGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate Geocoder Class
            var geocoder = new Geocoder("My API KEY");

            // Lists to Hold Addresses and Geocodes
            List<Address> Addresses = new List<Address>();
            List<Locations> LocationList = new List<Locations>();

            // SQL to add to SitesList
            
            using (SqlConnection sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString))
            {
                sqlConnection2.Open();

                using (SqlCommand command = new SqlCommand("SELECT CONCAT(StreetAddress,' ',City + ', ',State + ' ',Zip) as 'Full Address' FROM [FM_OPERATIONS].[dbo].[xRef_MasterFile] where Latitude is null", sqlConnection2))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Addresses.Add(new Address(reader.GetString(0)));
                        }

                    }
                }
                sqlConnection2.Close();
            }
            

           

            // Run Address List to Gooogle API

            foreach (var item in Addresses)
            {
                
                var x = geocoder.Geocode(item.PostalAddress);

                var y = x.ElementAt(0).LatLng.ToString().Trim().Split(',');

                Console.WriteLine("{0}|{1}|{2}", item.PostalAddress, Convert.ToDouble(y[0]), Convert.ToDouble(y[1]));

            }

            /*
            foreach (var item in LocationList)
            {
                Console.WriteLine("{0}|{1}|{2}", item.SiteName, item.Latitude, item.Longitude);
            }
            */
            


            

            /* Test Examples for Data Structure
            
            var address = geocoder.Geocode("21000 Twelve Mile Rd., MI");
            address.ElementAt(0);

            Console.WriteLine(address);
            Console.WriteLine(address.GetType());
            var stp = address.ElementAt(0);

            var output = stp.LatLng.ToString().Trim().Split(',');

            Console.WriteLine("Latitude: {0}",output[0].Trim());
            Console.WriteLine("Longitude: {0}",output[1].Trim());
            

            foreach (var item in Addresses)
            {
                Console.WriteLine(item.PostalAddress);
            }
            */



            Console.ReadLine();


        }

        /****************************** Haversine Area *****************************************/
        public static double HaversineInKM(double lat1, double long1, double lat2, double long2)
        {
            double _eQuatorialEarthRadius = 6378.1370D;
            double _d2r = (Math.PI / 180D);
            double dlong = (long2 - long1) * _d2r;
            double dlat = (lat2 - lat1) * _d2r;
            double a = Math.Pow(Math.Sin(dlat / 2D), 2D) + Math.Cos(lat1 * _d2r) * Math.Cos(lat2 * _d2r) * Math.Pow(Math.Sin(dlong / 2D), 2D);
            double c = 2D * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D - a));
            double d = _eQuatorialEarthRadius * c;

            return d;
        }


        // Converts Haversinse from KM to Miles
        public static int HaversineInMiles(double lat1, double long1, double lat2, double long2)
        {
            return (int)(.621371 * HaversineInKM(lat1, long1, lat2, long2));
        }

        /****************************** End Haversine *****************************************/
    }


}
