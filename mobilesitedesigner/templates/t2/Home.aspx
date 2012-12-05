<%@ Page Language="C#" AutoEventWireup="true" Inherits="mobilesitedesigner.PageHandlerBase" %>
<script runat="server">
    public mobilesitedesigner.Data.dbml.Page _Page;
    public List<mobilesitedesigner.Data.dbml.Content> _Content;
    protected void Page_Load(object sender, EventArgs e)
    {
        int pageid = int.Parse(Request.QueryString["pageid"]);
        _Page = GetDataContext2.Page.Single(o => o.ID == pageid);
        _Content = _Page.Content.ToList();
    }
</script>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.css" rel="stylesheet" />
    <link href="http://code.jquery.com/mobile/1.2.0/query.mobile.theme-1.2.0.css" rel="stylesheet" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js"></script>
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
                    if (sel == 'country')
                        html += '<option  value="" >Choose States</option>';
                    if (sel == 'state')
                        html += '<option  value="" >Choose Cities</option>';
                    $.each(dt, function (i) {
                        html += '<option value="' + this.ID + '" >' + this.Value + '</option>';
                    });
                    switch (sel) {
                        case 'country':
                            $('#state').empty().append(html).selectmenu('refresh', true);
                            break;
                        case 'state':
                            $('#city').empty().append(html).selectmenu('refresh', true);
                            break;
                    }
                    $.mobile.loading('hide');
                }, 'json');
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
        <# 
           int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
           string countryid=null, stateid=null;
           var SearchCol = (from o in GetDataContext2.TBL_Job_SearchWidgetColVisible
                            where o.ClientId == clientid
                            select o).FirstOrDefault();
            #>
        <form action="JobSearch.aspx" method="get" data-ajax="false" class="ui-body ui-body-a ui-corner-all" id="sform">
            <div data-role="collapsible" data-content-theme="c" data-collapsed-icon="arrow-r" data-expanded-icon="arrow-d">               
                <h3>                   
                    <input type="search" placeholder="Enter Search Keyword" name="search" id="search"  /></h3>
                 <div data-role="fieldcontain">
                 <#  if (SearchCol != null)
                              {   
                if (SearchCol.Facility ?? false)
                        { #>
               
                  
                    <label for="facility" class="ui-select">Select Job Facility</label>
                    <select name="facility" id="facility">
                        <option value="" selected="selected">Choose Facilities</option>
                        <#   var FacCols = (from o in GetDataContext2.TBL_Job_Facility                                            
                                            where o.ClientId == clientid
                                            select o).Distinct();
                             foreach (var FacCol in FacCols)
                             { #>
                        <option value="<#=FacCol.FacId  #>"><#=FacCol.Facility  #></option>
                        <# }  #>
                    </select>
                    <# }  #>
                    <# if (SearchCol.Country ?? false)
                       { #>
                    <label for="country" class="ui-select">Select Country</label>
                    <select name="country" id="country">
                        <option value="" selected="selected">Choose Countries</option>
                        <#     var CountryCols = (from o in GetDataContext2.TBL_GeoPostcodes_Country
                                                join o1 in GetDataContext2.TBL_Job_Location on o.CountryId equals o1.CountryId
                                                 where o1.ClientId == clientid
                                                select o).Distinct();
                             countryid =CountryCols.Any()? CountryCols.First().CountryCode:null;
                             foreach (var CountryCol in CountryCols)
                             { #>
                        <option value="<#=CountryCol.CountryCode #>" ><#=CountryCol.CountryName  #></option>
                        <# }  #>
                    </select>
                    <# }  #>
                    <# if (SearchCol.State ?? false)
                       { #>
                    <label for="state" >Select State</label>
                    <select name="state" id="state">
                        <option value="" selected="selected">Choose States</option>
                        <#   var StateCols = (from o in GetDataContext2.TBL_GeoPostcodes_State
                                              join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                              where o.CountryCode == (string.IsNullOrEmpty(countryid)?o.CountryCode:countryid) && o1.ClientId==clientid
                                              select o).Distinct();
                             stateid = StateCols.Any()?StateCols.First().StateCode:null;
                             foreach (var StateCol in StateCols)
                             { #>
                        <option value="<#=StateCol.StateCode  #>" ><#=StateCol.StateName #></option>
                        <# }  #>
                    </select>
                    <# }  #>
                    <# if (SearchCol.City ?? false)
                       { #>
                    <label for="city" >Select City</label>
                    <select name="city" id="city">
                        <option value="" selected="selected">Choose Cities</option>
                        <#   var CityCols = (from o in GetDataContext2.TBL_GeoPostcodes_City
                                             join o1 in GetDataContext2.TBL_Job_Location on o.CityId equals o1.CityId                                             
                                             where o.StateCode == (string.IsNullOrEmpty(stateid)?o.StateCode:stateid) && o1.ClientId == clientid
                                             select o).Distinct();
                             foreach (var CityCol in CityCols)
                             { #>
                        <option value="<#=CityCol.CityId  #>"><#=CityCol.CityName #></option>
                        <# }  #>
                    </select>
                    <# } 
                     } #>                                   
                </div>
                 <input type="hidden"  value="<% =_Page.Location %>" name="page" />    
                 <button type="submit" data-theme="b" >Search</button>
            </div>
        </form>
       

        <div data-role="content">
            <p><% =_Page.Text%></p>
            <ul data-role="listview">
                <%  foreach (var item in _Content)
                    { %>
                <li><a href="<% =item.Title %>.aspx"><% =item.Title %></a></li>
                <% }  %>
                <li><a href="<% =_Page.MainSite%>" rel="external">Go To Main Site</a></li>
            </ul>
        </div>
        <!-- /content -->

        <% if (_Page != null)
           { %>
        <div data-role="footer">
            <%  if (!string.IsNullOrEmpty(_Page.HeaderImage))
                {%>
            <img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.FooterImage   %>" style="width: 100%;" />
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
