<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IEError.aspx.cs" Inherits="IEError" %>

<%@ Register Src="~/Controls/TopMenu.ascx" TagName="TopMenu" TagPrefix="med" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MedAppointment :: Where Doctors &amp; Patients Click!</title>
    <link href="stylesnew/medappointment.css" rel="stylesheet" type="text/css" />
    <link href="fontsNew/font.css" rel="stylesheet" type="text/css" charset="utf-8" />
    <script src="ScriptsNew/jquery.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="frmMaster" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <!--wraper start -->
    <div class="topDesign">
    </div>
    <div id="wrapper" class="homePage">
        <!--header start -->
        <div id="header">
            <div class="toptext">
                <div class="topDesignInnerDiv">
                </div>
            </div>
            <div class="logo">
                <img src="imagesNew/medLogoNew.gif" alt="Med Appointment" title="Med Appointment" /></div>
            <div class="beta">
                <a href="beta.aspx" title="Beta">
                    <img border="0" src="imagesNew/beta.gif" alt="Beta" /></a></div>
            <div class="clear">
            </div>
        </div>
        <!--header end -->
        <!--menu start -->
        <div id="menuBg">
            <med:topmenu id="ucTopMenu" runat="server" />
        </div>
        <!--menu end -->
        <div id="container">
            <div class="content">
                <div class="fullWidthLeftPane">
                    <div class="fullWidthPageCenterBg">
                        <div class="fullWidthPageTopbg">
                            <div class="fullWidthPageBottompbg">
                                <div class="fullWidthPageContent">
                                    <h3>
                                        You are using an outdated browser</h3>
                                    <div style="text-align: center; display: inline-block; width: 410px; font-weight: bold;
                                        margin: 0 0 0 220px;">
                                        <img src="ImagesNew/Warning_Img.jpg" alt="Warning Image" title="Warning Image"  />
                                        <p style="width: 410px;" >
                                           For a better experience using this site, please upgrade to a modern web browser.
                                            <br />
                                            </p>
                                            <div style="width: 410px;" align="center">
                                                <div style="float:left; width: 82px;"><a href="http://www.mozilla.org/en-US/firefox/new/" target="_blank"><img src="ImagesNew/Firefox_icon.jpg" style="border:0px" alt="Firefox Icon" title="Firefox Icon" /></a></div>
                                                <div style="float:left; width: 82px;"><a href="http://windows.microsoft.com/en-us/internet-explorer/products/ie/home" target="_blank"><img src="ImagesNew/IE_icon.jpg" style="border:0px" alt="IE Icon" title="IE Icon"  /></a></div>
                                                <div style="float:left; width: 82px;"><a href="http://www.apple.com/safari/download/" target="_blank"><img src="ImagesNew/Safari_icon.jpg" style="border:0px"  alt="Safari Icon" title="Safari Icon" /></a></div>
                                                <div style="float:left; width: 82px;"><a href="https://www.google.com/chrome" target="_blank"><img src="ImagesNew/Chrome_icon.jpg" style="border:0px" alt="Chrome Icon" title="Chrome Icon"  /></a></div>
                                                <div style="float:left; width: 82px;"><a href="http://www.opera.com/" target="_blank"><img src="ImagesNew/Opera_icon.jpg" style="border:0px" alt="Opera Icon" title="Opera Icon"  /></a></div>
                                            </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
        <!--footer start -->
        <div id="footer">
            <div class="copyrights">
                <img src="ImagesNew/Medical-Emergencies.gif" />
                <span>MedAppointment is NOT to be used in case of Medical Emergencies</span>
            </div>
            <div class="footerLink">
                <a href="Disclaimer.aspx" title="Disclaimer">Disclaimer</a>|&nbsp;&nbsp;&nbsp;MedAppointment
                © 2012
            </div>
        </div>
        <!--footer end -->
    </div>
    <!--wraper end -->
    </form>
</body>
</html>
