<%@ Page Language="C#" AutoEventWireup="true" Inherits="mobilesitedesigner.PageHandlerBase" %>

<%@ Import Namespace="DapperExtensions" %>
<%@ Import Namespace="Dapper" %>
<script runat="server">
    public mobilesitedesigner.Data.dbml.Page _Page;
    public IEnumerable<mobilesitedesigner.Data.Standalone.VW_Jobs> _Jobs;
    protected void Page_Load(object sender, EventArgs e)
    {

        NameValueCollection q = Request.QueryString;
        string country = q["country"];
        string state = q["state"];
        string city = q["city"];
        string facility = q["facility"];
        string speciality = q["speciality"];
        string page = q["page"];
        string search = q["search"];
        PredicateGroup pg = new PredicateGroup();
        pg.Predicates = new List<IPredicate>();
        pg.Operator = GroupOperator.And;
        int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
        _Page = GetDataContext2.Page.First(o => o.Location == page && o.ClientID == clientid);
        pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.ClientId, Operator.Eq, clientid));
        if (!string.IsNullOrEmpty(search))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.JobTitle, Operator.Like,string.Format("%{0}%",search)));
        if (!string.IsNullOrEmpty(speciality))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.SpecialityId, Operator.Eq, int.Parse(speciality)));
        if (!string.IsNullOrEmpty(country))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.CountryCode, Operator.Eq, country));
        if (!string.IsNullOrEmpty(city))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.CityId, Operator.Eq, int.Parse(city)));
        if (!string.IsNullOrEmpty(state))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.StateCode, Operator.Eq, state));
        if (!string.IsNullOrEmpty(facility))
            pg.Predicates.Add(Predicates.Field<mobilesitedesigner.Data.Standalone.VW_Jobs>(f => f.FacId, Operator.Eq, int.Parse(facility)));
        _Jobs = SqlConnection.GetList<mobilesitedesigner.Data.Standalone.VW_Jobs>(pg);

    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="../client/lib/jquery.mobile-1.2.0/jquery.mobile-1.2.0.css" rel="stylesheet" />
    <link href="../client/lib/jquery.mobile-1.2.0/jquery.mobile.theme-1.2.0.css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#country,#state').change(function () {
                $.mobile.loading('show');
                var sel = $(this).attr('name');
                if (sel == 'country')
                    $('#state,#city').empty();
                if (sel == 'state')
                    $('#city').empty();
                $.get('../GET.ashx', { t: 'getdet', dettype: sel, val: $(this).val() }, function (dt) {
                    var html = '';
                    $.each(dt, function (i) {
                        html += '<option ' + (i == 0 ? 'selected="selected"' : '') + ' value="' + this.ID + '" >' + this.Value + '</option>';
                    });
                    switch (sel) {
                        case 'country':
                            $('#state').empty().append(html).val(dt.length > 0 ? dt[0].ID : null);
                            break;
                        case 'state':
                            $('#city').empty().append(html).val(dt.length > 0 ? dt[0].ID : null);
                            break;
                    }
                    $.mobile.loading('hide');
                }, 'json');
            });
            $('#search').click(function () {
                $('#sform').submit();
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
        <% 
            int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
            string countryid = null, stateid = null;
            var SearchCol = (from o in GetDataContext2.TBL_Job_SearchWidgetColVisible
                             where o.ClientId == clientid
                             select o).FirstOrDefault();
        %>
        <form action="JobSearch.aspx" method="get" data-ajax="false" class="ui-body ui-body-a ui-corner-all">
            <div data-role="collapsible" data-content-theme="c" data-collapsed-icon="arrow-r" data-expanded-icon="arrow-d">

                <h3>
                    <input type="search" placeholder="Enter Search Keyword" name="search" id="search" /></h3>
                <div data-role="fieldcontain">
                    <% if (SearchCol != null)
                       {
                           if (SearchCol.Speciality ?? false)
                           { %>
                    <label for="speciality" class="ui-select">Select Job Speciality</label>
                    <select name="speciality" id="speciality">
                   <%   var SpeCols = (from o in GetDataContext2.TBL_Job_Speciality
                                            join o1 in GetDataContext2.TBL_Master_Department on o.SpecialityId equals o1.DepartmentId
                                            where o.ClientId == clientid
                                            select new { o.SpecialityId, o1.DepartmentName }).Distinct();
                        foreach (var SpeCol in SpeCols)
                           { %>
                        <option value="<%=SpeCol.SpecialityId%>"><%=SpeCol.DepartmentName%></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% 
                       if (SearchCol.Facility ?? false)
                       { %>
                    <label for="facility" class="ui-select">Select Job Facility</label>
                    <select name="facility" id="facility">
                        <%   var FacCols = (from o in GetDataContext2.TBL_Job_Facility
                                            where o.ClientId == clientid
                                            select o).Distinct();
                             foreach (var FacCol in FacCols)
                             { %>
                        <option value="<%=FacCol.FacId%>"><%=FacCol.Facility%></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.Country ?? false)
                       { %>
                    <label for="country" class="ui-select">Select Country</label>
                    <select name="country" id="country">
                        <%    var CountryCols = (from o in GetDataContext2.TBL_GeoPostcodes_Country
                                                 join o1 in GetDataContext2.TBL_Job_Location on o.CountryId equals o1.CountryId
                                                 where o1.ClientId == clientid
                                                 select o).Distinct();
                              countryid = CountryCols.Any() ? CountryCols.First().CountryCode : null;
                              foreach (var CountryCol in CountryCols)
                              { %>
                        <option value="<%=CountryCol.CountryCode %>"><%=CountryCol.CountryName  %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.State ?? false)
                       { %>
                    <label for="state">Select State</label>
                    <select name="state" id="state">
                        <%   var StateCols = (from o in GetDataContext2.TBL_GeoPostcodes_State
                                              join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                              where o.CountryCode == (string.IsNullOrEmpty(countryid) ? o.CountryCode : countryid) && o1.ClientId == clientid
                                              select o).Distinct();
                             stateid = StateCols.Any() ? StateCols.First().StateCode : null;
                         foreach (var StateCol in StateCols)
                           { %>
                        <option value="<%=StateCol.StateCode%>"><%=StateCol.StateName %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.City ?? false)
                       { %>
                    <label for="city">Select City</label>
                    <select name="city" id="city">
                      <% var CityCols = (from o in GetDataContext2.TBL_GeoPostcodes_City
                                             join o1 in GetDataContext2.TBL_Job_Location on o.CityId equals o1.CityId
                                             where o.StateCode == (string.IsNullOrEmpty(stateid) ? o.StateCode : stateid) && o1.ClientId == clientid
                                             select o).Distinct();
                        foreach (var CityCol in CityCols)
                           { %>
                        <option value="<%=CityCol.CityId  %>"><%=CityCol.CityName %></option>
                        <% }  %>
                    </select>
                    <% }
                   }
                     %>
                </div>

            <input type="hidden" value="<% =_Page.Location %>" name="page" />
            <button type="submit" data-theme="b">Search</button>
            </div>
        </form>
        <div data-role="content">
            <ul data-role="listview">
                <%  foreach (var item in _Jobs)
                    { %>
                <li><a href="JobSearchDetails.aspx?Job=<% =item.JobId %>&referrer=<% =_Page.Location %>"><% =item.JobTitle %></a></li>
                <% }  %>
                <li><a href="<% =_Page.MainSite %>" rel="external">Go To Main Site</a></li>
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
