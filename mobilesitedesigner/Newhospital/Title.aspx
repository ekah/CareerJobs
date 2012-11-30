<%@ Page Language="C#" AutoEventWireup="true"  Inherits="mobilesitedesigner.PageHandlerBase" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"><title>

</title><link href="../client/lib/jquery.mobile-1.2.0/jquery.mobile-1.2.0.css" rel="stylesheet" /><link href="../client/lib/jquery.mobile-1.2.0/jquery.mobile.theme-1.2.0.css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js"></script>
    <script type="text/javascript">
       
    </script>
</head>
<body>
    <div data-role="page">
        
        <div data-role="header">
            
            <img src="../contentimages/header.jpg" style="width: 100%;" />
            
        </div>
        <!-- /header -->
        
        <% 
            int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
            string countryid=null, stateid=null;
            var SearchCol = (from o in GetDataContext2.TBL_Job_HotOppsColVisible
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
                <% if (SearchCol.Facility ?? false)

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
                 <input type="hidden" value="Page" name="page" />
                <button type="submit" data-theme="b">Search</button>
            </div>
        </form>
       
        
        <div data-role="content">
            
            <p><p>Needham soon started a (male) "Actors List", while Dave Knight began a "<a href="/wiki/Film_director" title="Film director">Directors</a> List", and Andy Krieg took over "THE LIST", which would later be renamed the "Actress List". Both lists had been restricted to people who were alive and working, but soon retired people were added, so Needham started what was then (but did not remain) a separate "Dead Actors/Actresses List". The goal now was to make the lists as inclusive as possible. By late 1990, the lists included almost 10,000 movies and television series correlated with actors and actresses appearing therein.</p> </p>
            
            <div data-role="footer">
                
                <img src="../contentimages/footer.png" style="width: 100%;" />
                
            </div>
            <!-- /footer -->
            
        </div>
</body>
</html>
