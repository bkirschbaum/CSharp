using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointFolderCreation
{
    class Site
    {
        public string SiteName { get; set; }
        public string BUName { get; set; }



        public Site(string fromName, string BName)
        {
            SiteName = fromName;
            BUName = BName;
        }
    }
}
