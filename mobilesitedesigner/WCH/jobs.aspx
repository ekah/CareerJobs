<%@ Page Language="C#" AutoEventWireup="true"  Inherits="mobilesitedesigner.PageHandlerBase" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"><title>

</title><link href="http://code.jquery.com/mobile/1.2.0/query.mobile-1.2.0.css" rel="stylesheet" /><link href="http://code.jquery.com/mobile/1.2.0/jquery.mobile.theme-1.2.0.css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js" type="text/javascript"></script>
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
        
        <div data-role="header">
            
            <h1>Jobs</h1>
            
        </div>
        <!-- /header -->
        
        <% 
            int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
            string countryid=null, stateid=null;
            var SearchCol = (from o in GetDataContext2.TBL_Job_SearchWidgetColVisible
                             where o.ClientId == clientid
                             select o).FirstOrDefault();
              %>
        <form action="JobSearch.aspx" method="get" data-ajax="false"  class="ui-body ui-body-a ui-corner-all">
            <div data-role="collapsible" data-content-theme="c" data-collapsed-icon="arrow-r" data-expanded-icon="arrow-d">
                <h3>
                    <input type="search" placeholder="Enter Search Keyword" name="search" id="search" /></h3>
                 <div data-role="fieldcontain">
                  <% if (SearchCol != null)
                              {   

                if (SearchCol.Facility ?? false)

                        { %>
               
                  
                    <label for="facility" class="ui-select">Select Job Facility</label>
                    <select name="facility" id="facility">
                        <%   var FacCols = (from o in GetDataContext2.TBL_Job_Facility
                                            where o.ClientId == clientid
                                            select o).Distinct();
                             foreach (var FacCol in FacCols)
                             { %>
                        <option value="<%=FacCol.FacId  %>"><%=FacCol.Facility  %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.Country ?? false)
                       { %>
                    <label for="country" class="ui-select">Select Country</label>
                    <select name="country" id="country">
                        <%   var CountryCols = (from o in GetDataContext2.TBL_GeoPostcodes_Country
                                                join o1 in GetDataContext2.TBL_Job_Location on o.CountryId equals o1.CountryId
                                                where o1.ClientId == clientid
                                                select o).Distinct();
                             countryid =CountryCols.Any()? CountryCols.First().CountryCode:null;
                             foreach (var CountryCol in CountryCols)
                             { %>
                        <option value="<%=CountryCol.CountryCode %>" <%if (CountryCol.CountryCode == mobilesitedesigner.Common.DefaultCountryCode)
                                                                       { %>
                            selected="selected" <%} %>><%=CountryCol.CountryName  %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.State ?? false)
                       { %>
                    <label for="state">Select State</label>
                    <select name="state" id="state">
                        <%   var StateCols = (from o in GetDataContext2.TBL_GeoPostcodes_State
                                              join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                              where o.CountryCode == (string.IsNullOrEmpty(countryid)?o.CountryCode:countryid) && o1.ClientId == clientid
                                              select o).Distinct();
                             stateid = StateCols.Any()?StateCols.First().StateCode:null;
                             foreach (var StateCol in StateCols)
                             { %>
                        <option value="<%=StateCol.StateCode  %>" <%if (StateCol.StateCode == mobilesitedesigner.Common.DefaultStateCode)
                                                                    { %>
                            selected="selected" <%} %>><%=StateCol.StateName %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    <% if (SearchCol.City ?? false)
                       { %>
                    <label for="city">Select City</label>
                    <select name="city" id="city">
                        <%   var CityCols = (from o in GetDataContext2.TBL_GeoPostcodes_City
                                             join o1 in GetDataContext2.TBL_Job_Location on o.CityId equals o1.CityId
                                             where o.StateCode == (string.IsNullOrEmpty(stateid)?o.StateCode:stateid) && o1.ClientId == clientid
                                             select o).Distinct();
                             foreach (var CityCol in CityCols)
                             { %>
                        <option value="<%=CityCol.CityId  %>"><%=CityCol.CityName %></option>
                        <% }  %>
                    </select>
                    <% }  %>
                    
                </div>
                 <% }  %>
                 <input type="hidden" value="UnitedStates" name="page" />
                <button type="submit" data-theme="b">Search</button>
            </div>
        </form>
         
         <div class="contentwrapper">
            <!--Content-->
            <div class="breadcrump">Jobs   >  jobs
                <div class="back-btn"><a href="index.html">
                    <img src="images/back-btn.png" width="62" height="26" /></a> </div>
            </div>
            <h1 style="margin-left: 10px;">jobs </h1>
            <ul class="menu">
                <li><a href="index.html" data-role="button" data-iconpos="right" data-icon="star">Call Center</a> </li>
                <li><a href="index.html" data-role="button" data-iconpos="right" data-icon="home">Marketing</a></li>
                <li><a href="index.html" data-role="button" data-iconpos="right" data-icon="info">Non-Clinical</a></li>

            </ul>         
            <p style="padding: 10px;">you can search jobs in this page</p>
        </div>
        
       
        </div>
</body>
</html>
