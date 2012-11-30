using System;
using System.Web;
using System.Linq;
namespace mobilesitedesigner
{
    public static partial class Common
    {
       
        public static int GetClientID(string path)
        {
            HttpContext context = HttpContext.Current;
           
            var datacontext = new Data.dbml.DataContext(Common.DataConnectionString);
            var tbl = datacontext.TBL_Organization.FirstOrDefault(o => o.SubDomain == path);
            return tbl.OrganizationId;
        }
    }
}
