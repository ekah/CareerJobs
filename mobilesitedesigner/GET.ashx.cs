using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Data;
using Newtonsoft.Json;

using System.Threading;
using System.Diagnostics;

using System.ComponentModel;
using System.Dynamic;
using System.Text.RegularExpressions;

using System.Xml.Linq;

using Utilities;
using System.Collections;
using Dapper;
using DapperExtensions;
using System.Collections.Specialized;
namespace mobilesitedesigner
{
    /// <summary>
    /// Summary description for GET
    /// </summary>
    public class GET : HttpHandlerBase
    {
        NameValueCollection p, q;
        HttpRequest req;
        HttpResponse res;
        public override void ProcessRequest(HttpContext context)
        {
            p = context.Request.Params;
            q = context.Request.QueryString;
            req = context.Request;
            res = context.Response;
            base.ProcessRequest(context);
            switch (q["t"])
            {
                case "getcontent":
                    GetContent(context);
                    break;
                case "getclients":
                    GetClients(context);
                    break;
                case "gettemplates":
                    GetTemplates(context);
                    break;
                case "getpages":
                    GetPages(context);
                    break;
                case "getdet":
                    GetDet(context);
                    break;
                case "getcode":
                    GetCode(context);
                    break;
            }
            base.EndRequest(context);
        }

        private void GetCode(HttpContext context)
        {
            res.Write(File.ReadAllText(req.MapPath(q["file"])));
        }

        private void GetTemplates(HttpContext context)
        {
            string[] dirs = Directory.GetDirectories(Path.Combine(context.Request.MapPath("~"), "templates"));
            context.Response.Write(JsonConvert.SerializeObject(from o in dirs select new { ID = o.Split('\\').Last(), Value = o.Split('\\').Last() }));
        }

        private void GetClients(HttpContext context)
        {
            res.Write(JsonConvert.SerializeObject(from o in GetDataContext2.TBL_Organization
                                                  select new { ID = o.OrganizationId, Value = o.OrganizationName }));
        }

        private void GetDet(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                string dettype = q["dettype"];
                switch (dettype)
                {
                    case "country":
                        res.Write(JsonConvert.SerializeObject((from o in GetDataContext2.TBL_GeoPostcodes_State
                                                               join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                                               where o.CountryCode == p["val"]
                                                               select new { ID = o.StateCode, Value = o.StateName }).Distinct()));
                        break;
                    case "state":
                        res.Write(JsonConvert.SerializeObject((from o in GetDataContext2.TBL_GeoPostcodes_City
                                                               join o1 in GetDataContext2.TBL_Job_Location on o.CityId equals o1.CityId
                                                               where o.StateCode == p["val"]
                                                               select new { ID = o.CityId, Value = o.CityName }).Distinct()));
                        break;
                }
            }
        }

        private void GetPages(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                var org = GetDataContext2.TBL_Organization.Single(o => o.OrganizationId == clientID);
                var query = from o in GetDataContext2.Page
                            where o.ClientID == clientID
                            select new
                            {
                                o.ID,
                                o.ClientID,
                                SubDomain = org.SubDomain,
                                o.MainSite,
                                o.Location,
                                o.FooterText,
                                o.HeaderText,
                                o.HeaderImage,
                                o.FooterImage,
                                o.PageImage,
                                o.Text,
                                o.Def,
                                o.Locked
                            };
                context.Response.WriteJson(query);
            }
        }

        private void GetContent(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                if (p["id"] != null)
                {
                    int id = int.Parse(p["id"]);
                    var org = GetDataContext2.TBL_Organization.Single(o => o.OrganizationId == clientID);
                    var query = from o in GetDataContext2.Content
                                where o.PageID == id
                                select new
                                {
                                    o.ID,
                                    o.PageID,
                                    SubDomain = org.SubDomain,
                                    o.ImageUrl,
                                    o.Text,
                                    o.Title,
                                    o.Locked
                                };
                    context.Response.WriteJson(query);
                }
            }
        }
    }
}