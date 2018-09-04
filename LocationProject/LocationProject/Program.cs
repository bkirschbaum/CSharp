using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create List to Populate
            List<Sites> SitesList = new List<Sites>();


            // SQL to add to SitesList
            using (SqlConnection sqlConnection2 = new SqlConnection(ConnetionString()))
            {
                sqlConnection2.Open();

                using (SqlCommand command = new SqlCommand("Select  NewAXCustomerName,Latitude, Longitude FROM [FM_OPERATIONS].[dbo].[xRef_MasterFile] where Latitude is not null and NewAXCustomerName is not null", sqlConnection2))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SitesList.Add(new Sites(reader.GetString(0), reader.GetDouble(1),reader.GetDouble(2)));
                        }

                    }
                }
                sqlConnection2.Close();
            }

            /*
            // Upload Result Set Test
            using (SqlConnection sqlConnection2 = new SqlConnection(ConnetionString()))
            {
                using (SqlCommand command2)
                {

                }
                foreach (var item in SitesList)
                {
                    SqlConnection sqlConnection3 = new SqlConnection(ConnetionString());
                    SqlCommand upload = new SqlCommand();
                    SqlDataReader reader1;
                    upload.CommandText = @"INSERT INTO CTest ([Site],[Latitude],[Longitude]) VALUES ('" + item.SiteName + "','" + item.Latitude.ToString() + "','" + item.Longitude.ToString() + "')";
                    upload.Connection = sqlConnection3;
                    sqlConnection3.Open();
                    reader1 = upload.ExecuteReader();
                    sqlConnection3.Close();

                }
            }
            
            */

            // List to hold calculated distances
            List<Distance> DistanceList = new List<Distance>();

            foreach (var item in SitesList)
            {
                foreach (var item2 in SitesList)
                {
                    if (item != item2)
                    {
                        DistanceList.Add(new Distance(item.SiteName, item2.SiteName, HaversineInMiles(item.Latitude, item.Longitude, item2.Latitude, item2.Longitude)));
                    }
                    
                }
                
            }

            //Upload to SQL


            //Linq group by to find count of sites within a distance
            var Miles = (from Distance in DistanceList
                        where Distance.Miles < 50
                        group Distance.FromSite by Distance.FromSite
                        into g
                        select new
                        {
                            Site = g.Key,
                            Count = g.Count()
                        }).Where(x => x.Count > 5).OrderByDescending(x=>x.Count);
                              

            foreach (var item in Miles)
            {
                Console.WriteLine("From: {0} Count: {1}",item.Site,item.Count);
            }
            

            Console.ReadLine();

        } // End Args


        /******************************   METHODS **********************************************/

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


        //Connection String
        public static string ConnetionString()
        {
            return "Data Source=ahwsqlch3024.DS.SJHS.com;Initial Catalog=FM_OPERATIONS;Integrated Security=True";
        }

        //Test to make sure there is a valid connection to the server
        public static string ValidConnection1()
        {
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection(ConnetionString());
                SqlCommand cmd = new SqlCommand();
                sqlConnection1.Open();
                sqlConnection1.Close();
                return "Success";
            }
            catch (Exception ex)
            {

                return "Failed";
            }



        }







    }

}
