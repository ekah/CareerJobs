using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Compilation;
using System.Web.UI;
using System.Configuration;

/// <summary>
/// Summary description for RouteHandler
/// </summary>
public class HospitalRouteHandler : IRouteHandler
{
    string _virtualPath;

    public HospitalRouteHandler()
    {

    }
    public HospitalRouteHandler(string virtualPath)
    {
        _virtualPath = virtualPath;
    }

    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
        var page = BuildManager.CreateInstanceFromVirtualPath
                 (_virtualPath, typeof(Page)) as IHospitalDisplay;

        if (page != null)
        {
            if (requestContext.RouteData.Values["fdoctorname"] != null)
                page.fdoctorname = requestContext.RouteData.Values["fdoctorname"].ToString();

            return page;
        }
        else
        {
            return null;
        }
    }     
}
