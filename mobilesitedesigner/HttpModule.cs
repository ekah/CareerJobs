using System;
using System.Web;
using System.Linq;
namespace mobilesitedesigner
{
    public class HttpModule : IHttpModule
    {

        #region IHttpModule Members

        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(BeginRequest);
        }

        #endregion

        public void BeginRequest(Object source, EventArgs e)
        {            
            HttpApplication context = (HttpApplication)source;           
            string path = context.Request.Path.Split('/').First();
            if (!string.IsNullOrEmpty(path))
            {
                var datacontext = new Data.dbml.DataContext(Common.DataConnectionString);
                var tbl = datacontext.TBL_Organization.FirstOrDefault(o => o.SubDomain == path);
                if (tbl != null)
                    context.Response.Cookies.Add(new HttpCookie("client", tbl.OrganizationId.ToString()));
            }
        }
    }
}
