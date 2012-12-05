<%@ Page Language="C#" AutoEventWireup="true" Inherits="mobilesitedesigner.PageHandlerBase" %>

<%@ Import Namespace="DapperExtensions" %>
<%@ Import Namespace="Dapper" %>
<script runat="server">
    public mobilesitedesigner.Data.dbml.Page _Page;
    public mobilesitedesigner.Data.dbml.VW_Jobs Job;
    protected void Page_Load(object sender, EventArgs e)
    {
        NameValueCollection q = Request.QueryString;
        string job = q["JOB"];
        string page = q["page"];
        PredicateGroup pg = new PredicateGroup();
        pg.Predicates = new List<IPredicate>();
        pg.Operator = GroupOperator.And;
        int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
        Job = GetDataContext2.VW_Jobs.First(o => o.JobId == job);
        _Page = GetDataContext2.Page.First(o => o.Location == page && o.ClientID == clientid);
    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.css" rel="stylesheet" />
    <link href="http://code.jquery.com/mobile/1.2.0/jquery.mobile.theme-1.2.0.css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#sMail').click(function () {

            });
        });
    </script>
</head>
<body>
    <div data-role="page">
        <% if (_Page != null)
           { %>
        <div data-role="header">
            <%  if (!string.IsNullOrEmpty(_Page.HeaderImage))
                {%>
            <img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.HeaderImage  %>" style="width: 100%;" />
            <% }  %>
            <% else if (!string.IsNullOrEmpty(_Page.HeaderText))
                {%>
            <h1><% =_Page.HeaderText  %></h1>
            <% }  %>
        </div>
        <!-- /header -->
        <% }  %>


        <div data-role="content">
            <ul data-role="listview">
                <% 
                    int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
                    var SearchDescriptionCols = (from o in GetDataContext2.TBL_Job_SearchDescriptionColVisible
                                                 where o.ClientId == clientid
                                                 select o).Distinct();
                    foreach (var SearchDescriptionCol in SearchDescriptionCols)
                    { %>
                <%if (SearchDescriptionCol.JobTitle ?? false)
                  { %>
                <li style="display: block">Job Title:<% =Job.JobTitle %></li>
                <%} %>
                <%if (SearchDescriptionCol.Facility ?? false)
                  { %>
                <li style="display: block">Job Facility:<% =Job.Facility %></li>
                <%} %>
                <%if (SearchDescriptionCol.Speciality ?? false)
                  { %>
                <li style="display: block">Job Speciality:<% =Job.Speciality %></li>
                <%} %>
                <%if (SearchDescriptionCol.PostedDate ?? false)
                  { %>
                <li style="display: block">Job Posted:<% =Job.CreatedDate %></li>
                <%} %>
                <%if (SearchDescriptionCol.Description ?? false)
                  { %>
                <li style="display: block">Job Description:<% =Job.Description %></li>
                <%} %>
                <%if (SearchDescriptionCol.Country ?? false)
                  { %>
                <li style="display: block">Job Country:<% =Job.CountryName %></li>
                <%} %>
                <%if (SearchDescriptionCol.State ?? false)
                  { %>
                <li style="display: block">Job State:<% =Job.StateName %></li>
                <%} %>
                <%if (SearchDescriptionCol.City ?? false)
                  { %>
                <li style="display: block">Job City:<% =Job.CityName %></li>
                <%} %>
                <% }  %>
                <li style="display: block">
                    <button id="sMail">Send Mail</button></li>
            </ul>
        </div>
        <!-- /content -->

        <% if (_Page != null)
           { %>
        <div data-role="footer">
            <%  if (!string.IsNullOrEmpty(_Page.HeaderImage))
                {%>
            <img src=" <% =mobilesitedesigner.Common.ImagesRelPath+ _Page.FooterImage   %>" style="width: 100%;" />
            <% }  %>
            <% else if (!string.IsNullOrEmpty(_Page.FooterText))
                {%>
            <h1><% =_Page.FooterText  %></h1>
            <% }  %>
        </div>
        <!-- /footer -->
        <% }  %>
    </div>
</body>
</html>
