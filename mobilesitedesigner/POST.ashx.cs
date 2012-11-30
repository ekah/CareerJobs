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
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;

namespace mobilesitedesigner
{
    /// <summary>
    /// Summary description for GET
    /// </summary>
    public class POST : HttpHandlerBase
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
            switch (context.Request.QueryString["t"])
            {
                case "setcontent":
                    SetContent(context);
                    break;
                case "delcontent":
                    DelContent(context);
                    break;
                case "savepage":
                    SavePage(context);
                    break;
                case "gencontent":
                    GenContent(context);
                    break;
            }
            base.EndRequest(context);
        }

        private void SavePage(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                string ID = p["ID"];
                Data.POCOS.Page page;
                if (!string.IsNullOrEmpty(ID) && ID != "0")
                    page = Data.POCOS.Page.Single(int.Parse(ID));
                else
                    page = new Data.POCOS.Page();
                page.FooterText = p["FooterText"];
                page.HeaderText = p["HeaderText"];
                page.Location = p["Location"];
                page.MainSite = p["MainSite"];
                page.ClientID = clientID;
                if (context.Request.Files.Count > 0)
                {
                    HttpPostedFile file = context.Request.Files["HeaderImage"];
                    if (file.ContentLength > 0)
                    {
                        string filename = file.FileName;
                        string filepath = Common.ImagesPath + filename;
                        file.SaveAs(filepath);
                        page.HeaderImage = filename;
                    }
                    file = context.Request.Files["FooterImage"];
                    if (file.ContentLength > 0)
                    {
                        string filename = file.FileName;
                        string filepath = Common.ImagesPath + filename;
                        file.SaveAs(filepath);
                        page.FooterImage = filename;
                    }
                    file = context.Request.Files["PageImage"];
                    if (file.ContentLength > 0)
                    {

                        string filename = file.FileName;
                        string filepath = Common.ImagesPath + filename;
                        file.SaveAs(filepath);
                        page.PageImage = filename;
                    }
                }
                page.Save();
            }
            context.Response.WriteJsonSuccess();
        }


        private void GenContent(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                string tmpl = p["tmpl"];
                if (!string.IsNullOrEmpty(tmpl))
                {
                    var org = GetDataContext2.TBL_Organization.Single(o => o.OrganizationId == clientID);
                    if (!string.IsNullOrEmpty(org.SubDomain))
                    {
                        string dir = Path.Combine(context.Server.MapPath("~"), org.SubDomain);
                        if (!Directory.Exists(dir))
                            Directory.CreateDirectory(dir);
                        var query = GetDataContext2.Page.Where(o => o.ClientID == clientID);
                        string root = Path.Combine(context.Server.MapPath("~"), "templates", tmpl);
                        File.Copy(Path.Combine(root, "JobSearch.aspx"), Path.Combine(dir, "JobSearch.aspx"), true);
                        File.Copy(Path.Combine(root, "JobSearchDetails.aspx"), Path.Combine(dir, "JobSearchDetails.aspx"), true);
                        foreach (var page in query)
                        {
                            StringWriter writer = new StringWriter();
                            writer.WriteLine(@"<%@ Page Language=""C#"" AutoEventWireup=""true""  Inherits=""mobilesitedesigner.PageHandlerBase"" %>");
                            context.Server.Execute(string.Format("templates/{1}/Home.aspx?pageid={0}", page.ID, tmpl), writer);
                            File.WriteAllText(Path.Combine(dir, page.Location + ".aspx"), writer.ToString().Replace("<#", "<%").Replace("#>", "%>"));
                            var contents = page.Content.ToList();
                            foreach (var content in contents)
                            {
                                StringWriter writer1 = new StringWriter();
                                writer1.WriteLine(@"<%@ Page Language=""C#"" AutoEventWireup=""true""  Inherits=""mobilesitedesigner.PageHandlerBase"" %>");
                                context.Server.Execute(string.Format("templates/{1}/Content.aspx?id={0}", content.ID, tmpl), writer1);
                                File.WriteAllText(Path.Combine(dir, content.Title + ".aspx"), writer1.ToString().Replace("<#", "<%").Replace("#>", "%>"));
                            }
                        }
                        context.Response.WriteJsonSuccess();
                    }
                }
            }
        }

        private void DelContent(HttpContext context)
        {
            string ID = context.Request.Params["ID"];
            if (!string.IsNullOrEmpty(ID))
                GetDataContext1.Delete<Data.POCOS.Content>(int.Parse(ID));
            context.Response.WriteJsonSuccess();
        }

        private void SetContent(HttpContext context)
        {
            HttpCookie cookie = req.Cookies["client"];
            if (cookie != null)
            {
                int clientID = int.Parse(cookie.Value);
                NameValueCollection p = context.Request.Params;
                string ID = p["ID"];
                string PageID = p["PageID"];
                if (!string.IsNullOrEmpty(PageID))
                {
                    Data.POCOS.Content content;
                    if (!string.IsNullOrEmpty(ID) && ID != "0")
                        content = Data.POCOS.Content.Single(int.Parse(ID));
                    else
                        content = new Data.POCOS.Content();
                    content.Title = p["Title"];
                    content.Text = p["Text"];
                    content.PageID = int.Parse(PageID);
                    content.ClientID = clientID;
                    if (context.Request.Files.Count > 0)
                    {
                        HttpPostedFile file = context.Request.Files["ImageUrl"];
                        if (file.ContentLength > 0)
                        {
                            string filename = file.FileName;
                            string filepath = Common.ImagesPath + filename;
                            file.SaveAs(filepath);
                            content.ImageUrl = filename;
                        }
                    }
                    content.Save();
                }
            }
            context.Response.WriteJsonSuccess();
        }
    }
}