<%@ Page Language="C#" AutoEventWireup="true"  Inherits="mobilesitedesigner.PageHandlerBase" %>
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
  
<head  >
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
                <img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.HeaderImage  %>" width="107" height="40" />
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
                <img src="<% =mobilesitedesigner.Common.ImagesRelPath+ _Page.PageImage  %>" width="320" height="160" />
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
        <form action="JobSearch.aspx" method="get" data-ajax="false" id="sform">
            <div class="searchwrapper">
                <div class="QuickSearch">
                    <div class="Searchbox">
                        <input class="input" type="search" name="search" id="search-basic" />
                    </div>
                    <div class="searchbutton">
                        <img src="images/search-btn.png" width="58" height="36" />
                        <img src="images/adv-search.png" width="82" class="OpenImg" height="36" />
                    </div>
                </div>
                <div class="advSearch">
                    <div class="title">Advanced Job Search <span class="Close"></span></div>
                    <div class="HomeSearch">
                        <div class="InpWrap">
                            <div class="TxtBxWrap1">
                                <# if (SearchCol.Facility ?? false)
                                   {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="facility" id="facility" size="1">
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
                                        <#    var CountryCols = (from o in GetDataContext2.TBL_GeoPostcodes_Country
                                                                 join o1 in GetDataContext2.TBL_Job_Location on o.CountryId equals o1.CountryId
                                                                 where o1.ClientId == clientid
                                                                 select o).Distinct();
                                              countryid = CountryCols.Any() ? CountryCols.First().CountryCode : null;
                                              foreach (var CountryCol in CountryCols)
                                              {#>
                                        <option value="<#=CountryCol.CountryCode#>" <#if (CountryCol.CountryCode == mobilesitedesigner.Common.DefaultCountryCode)
                                                                                      {#>
                                            selected="selected" <#}#>><#=CountryCol.CountryName #></option>
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
                                        <#  var StateCols = (from o in GetDataContext2.TBL_GeoPostcodes_State
                                                             join o1 in GetDataContext2.TBL_Job_Location on o.StateId equals o1.StateId
                                                             where o.CountryCode == (string.IsNullOrEmpty(countryid) ? o.CountryCode : countryid) && o1.ClientId == clientid
                                                             select o).Distinct();
                                            stateid = StateCols.Any() ? StateCols.First().StateCode : null;
                                            foreach (var StateCol in StateCols)
                                            {#>
                                        <option value="<#=StateCol.StateCode #>" <#if (StateCol.StateCode == mobilesitedesigner.Common.DefaultStateCode)
                                                                                   {#>
                                            selected="selected" <#}#>><#=StateCol.StateName#></option>
                                        <#} #>
                                    </select>
                                </div>
                                <#} #>
                                <#if (SearchCol.City ?? false)
                                  {#>
                                <div class="jbselection1Wrap">
                                    <select class="jbselection1" name="city" id="city" size="1">
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
                        <input type="hidden" value="<# =Request.Url.Segments.Last().Split('.').First() #>" name="page" />
                        <input type="submit" value="Submit Button" style="width: 70% !important; margin: 0 auto;" />
                    </div>
                </div>
            </div>
        </form>
        <#} #>
        <div class="contentwrapper">
            <!--Content-->
            <ul class="menu">
                <%  foreach (var item in _Content)
                    { %>
                <li><a href="<% =item.Title %>.aspx" data-role="button" data-iconpos="right" data-icon="star"><% =item.Title %></a> </li>
                <% }  %>
            </ul>
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
