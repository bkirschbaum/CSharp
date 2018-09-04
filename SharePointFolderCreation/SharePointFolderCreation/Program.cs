using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;


namespace SharePointFolderCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List to Populate
            List<Site> SitesList = new List<Site>();
            List<Ministry> BUList = new List<Ministry>();


            // SQL to add to SitesList
            using (SqlConnection sqlConnection2 = new SqlConnection(ConnetionString()))
            {
                sqlConnection2.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT [NAME], BusinessUnit  FROM D365CC  where costcenterID not like '1%' and pk_CostCenter != -999  order by costcenterID", sqlConnection2))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SitesList.Add(new Site(reader.GetString(0),reader.GetString(1)));
                        }

                    }
                }
                sqlConnection2.Close();
            }

            /* Creates the Parent Business Unit Folders */

            /*
            // SQL to add to BUList
            using (SqlConnection sqlConnection2 = new SqlConnection(ConnetionString()))
            {
                sqlConnection2.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT Distinct BusinessUnit  FROM D365CC  where costcenterID not like '1%' and pk_CostCenter != -999  order by BusinessUnit", sqlConnection2))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BUList.Add(new Ministry(reader.GetString(0)));
                        }

                    }
                }
                sqlConnection2.Close();
            }

    */
            // Populates Parent Directories //
            
            foreach (var item in BUList)
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\bakirschbaum\Desktop\SPTemplate\" + item.SiteName);
            }
            


            string[] subfolders = { "CMOR", "Weekly Cadence", "CSHA", "Action Plans", "MOR Minutes" };
            foreach (var item in SitesList)
            {
                // Creates Site Folders //
                System.IO.Directory.CreateDirectory(@"C:\Users\bakirschbaum\Desktop\SPTemplate\" + item.BUName + @"\" + item.SiteName);

                // Creates Site Sub Directories [CMOR, WEEKLY Cadence, CSHA, Action Plans, MOR Minutes //
                foreach (var item2 in subfolders)
                {

                    System.IO.Directory.CreateDirectory(@"C:\Users\bakirschbaum\Desktop\SPTemplate\" + item.BUName + @"\" + item.SiteName + @"\" +item2);
                }

            }

            Console.ReadLine();
        }


        //Connection String
        public static string ConnetionString()
        {
            return "Data Source=ahwsqlch3024.DS.SJHS.com;Initial Catalog=FM_OPERATIONS;Integrated Security=True";
        }
    }
}
