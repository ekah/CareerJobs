<%@ Page Language="C#" Debug="true"  AutoEventWireup="true" Inherits="mobilesitedesigner.PageHandlerBase" %>

<script runat="server">
    public IEnumerable<mobilesitedesigner.Data.dbml.Page> _Pages;
    public mobilesitedesigner.Data.dbml.Page _Page;
    protected void Page_Load(object sender, EventArgs e)
    {
        int pageid = int.Parse(Request.QueryString["clientid"]);
        var query = GetDataContext2.Page.Where(o => o.ClientID == pageid);
        _Page = query.First(o => o.Def ?? false);
        _Pages = query.Where(o => !(o.Def ?? false));
    }
</script>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><% = _Page.HeaderText  %></title>
    <link href="favicon.ico" type="image/x-icon" rel="shortcut icon" />
    <link href="Styles/Styles.css" rel="stylesheet" type="text/css" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.css" />
    <script src="http://code.jquery.com/mobile/1.2.0/jquery.mobile-1.2.0.min.js" type="text/javascript"></script>
    <meta name="viewport" content="initial-scale=2.3, user-scalable=no" />
    <meta name="viewport" content="width=320; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;" />
    <style type="text/css">
        img.c2 {
            float: right;
        }
        div.c1 {
            display: none;
        }
    </style>
    <script type="text/javascript">
        $(function () {
            $('.OpenImg').click(function () {
                $('.advSearch').show();
                $('.QuickSearch').hide();
            });
            $('.Close').click(function () {
                $('.QuickSearch').show();
                $('.advSearch').hide();
            });
            $(window).load(function () {
                var w = $(window).width();
                $('.Searchbox .input').css("width", (w - 220));
            });
            $(window).resize(function () {
                var w = $(window).width();
                $('.Searchbox .input').css("width", (w - 220));
            });
            $('#imgsearch').click(function () {
                $('#sform').submit();
            });
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
                        html += '<option  value="' + this.ID + '" >' + this.Value + '</option>';
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
    <div class="mainwrapper">
        <div class="headerwrapper">
            <% if (_Page != null)
               {
                   if (!string.IsNullOrEmpty(_Page.HeaderImage))
                   {%>
            <div class="logo">
                <a data-ajax="false" href="<% = _Page.Location  %>.aspx"><img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.HeaderImage  %>" width="107" height="40" /></a>
            </div>
            <%}
               } %>
            <div class="title">
                <img src="images/title.png" width="83" height="40" />
            </div>
        </div>
        <div class="bannerwrapper">
            <!--Image Banner-->
            <div class="banner">
                <a data-ajax="false" href="<% = _Page.Location  %>.aspx"><img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.PageImage  %>" width="320" height="160" /></a>
            </div>
        </div>
        <form action="JobSearch.aspx" method="get" data-ajax="false" id="sform">
            <div class="searchwrapper">
                <div class="QuickSearch">
                    <div class="Searchbox">
                        <input class="input" type="search" name="search" id="search-basic" />
                    </div>
                    <div class="searchbutton">
                        <img src="images/search-btn.png" width="58" height="36" id="imgsearch" />
                        <img src="images/adv-search.png" width="82" class="OpenImg" height="36" />
                    </div>
                </div>
                <#
            int clientid = mobilesitedesigner.Common.GetClientID(Request.Path.Split('/')[2]);
            string countryid = null, stateid = null;
            var SearchCol = (from o in GetDataContext2.TBL_Job_SearchWidgetColVisible
                             where o.ClientId == clientid
                             select o).FirstOrDefault();
            if (SearchCol != null)
            { #>
                <div class="advSearch">
                    <div class="title">Advanced Job Search <span class="Close"></span></div>
                    <div class="HomeSearch">
                        <div class="InpWrap">
                            <div class="TxtBxWrap1">
                                <# if (SearchCol.Facility ?? false)
                                   {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="facility" id="facility" size="1">
                                        <option value="" selected="selected">Choose Facilities</option>
                                        <#  var FacCols = (from o in GetDataContext2.TBL_Job_Facility
                                                           where o.ClientId == clientid
                                                           select o).Distinct();
                                            foreach (var FacCol in FacCols)
                                            {#>
                                        <option value="<#=FacCol.FacId #>"><#=FacCol.Facility #></option>
                                        <#} #>
                                    </select>
                                </div>
                                <#} #>
                                <#if (SearchCol.Country ?? false)
                                  {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="country" id="country" size="1">
                                        <option value="" selected="selected">Choose Country</option>
                                        <#    var CountryCols = (from o in GetDataContext2.TBL_GeoPostcodes_Country
                                                                 join o1 in GetDataContext2.TBL_Job_Location on o.CountryId equals o1.CountryId
                                                                 where o1.ClientId == clientid
                                                                 select o).Distinct();
                                              countryid = CountryCols.Any() ? CountryCols.First().CountryCode : null;
                                              foreach (var CountryCol in CountryCols)
                                              {#>
                                        <option value="<#=CountryCol.CountryCode#>"><#=CountryCol.CountryName #></option>
                                        <#} #>
                                    </select>
                                </div>
                                <#} #>
                                <div class="jbselection1Wrap"></div>
                            </div>
                            <div class="TxtBxWrap1">
                                <#if (SearchCol.State ?? false)
                                  {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="state" id="state" size="1">
                                        <option value="" selected="selected">Choose States</option>
                                        <#  var StateCols = (from o in GetDataContext2.TBL_GeoPostcodes_State
                                                             join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                                             where o.CountryCode == (string.IsNullOrEmpty(countryid) ? o.CountryCode : countryid) && o1.ClientId == clientid
                                                             select o).Distinct();
                                            stateid = StateCols.Any() ? StateCols.First().StateCode : null;
                                            foreach (var StateCol in StateCols)
                                            {#>
                                        <option value="<#=StateCol.StateCode #>"><#=StateCol.StateName#></option>
                                        <#} #>
                                    </select>
                                </div>
                                <#} #>
                                <#if (SearchCol.City ?? false)
                                  {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="city" id="city" size="1">
                                        <option value="" selected="selected">Choose Cities</option>
                                        <#  var CityCols = (from o in GetDataContext2.TBL_GeoPostcodes_City
                                                            join o1 in GetDataContext2.TBL_Job_Location on o.CityId equals o1.CityId
                                                            where o.StateCode == (string.IsNullOrEmpty(stateid) ? o.StateCode : stateid) && o1.ClientId == clientid
                                                            select o).Distinct();
                                            foreach (var CityCol in CityCols)
                                            {#>
                                        <option value="<#=CityCol.CityId #>"><#=CityCol.CityName#></option>
                                        <#} #>
                                    </select>
                                </div>
                                <#} #>
                            </div>
                        </div>
                        <input type="hidden" value="<% =_Page.Location %>" name="page" />
                        <input type="submit" value="Submit Button" style="width: 70% !important; margin: 0 auto;" />
                    </div>
                </div>
                <#} #>
            </div>
        </form>
        <div class="contentwrapper">          
            <ul class="menu">
                <%  foreach (var item in _Pages)
                    { %>
                <li><a href="<% =item.Location %>.aspx" data-role="button" data-iconpos="right" data-icon="star" data-ajax="false"><% =item.Location %></a> </li>
                <% }  %>
            </ul>           
            <div style="padding: 10px;"><%=_Page.Text %></div>
            <br />
            <br />
            <br />
            <div class="social">
                <img src="images/socialicons.png" width="126" height="36" />
            </div>
        </div>
        <div class="footerwrapper"><a href="<% =_Page.MainSite%>" rel="external">View Full Site</a></div>
    </div>
</body>
</html>
