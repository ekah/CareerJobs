<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Setup.ascx.cs" Inherits="Setup" %>
<link href="StylesNew/iconmenu.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="ScriptsNew/interface.js"></script>
<link href="StylesNew/colorbox-insertscreen.css" rel="stylesheet" type="text/css" />
<script src="ScriptsNew/jquery.colorbox.js"></script>
<%--<script type="text/javascript">

    $(document).ready(
		function () {
		    $('#dock').Fisheye(
				{
				    maxWidth: 10,
				    items: 'a',
				    itemsText: 'span',
				    container: '.dock-container',
				    itemWidth: 67,
				    //proximity: 90,
				    halign: 'center'
				}
			)
		}
	);

</script>--%>
<script>
    $(document).ready(function () {
        $('.remove').click(function () {
            $.colorbox.close();
        });
        $('.inline').click(function () {
            $.colorbox({ href: "#inline_content", inline: true, width: "600px" }); //Patient Profile

        });
    });
</script>
<style type="text/css">
    div, img
    {
        behavior: url(iepngfix.htc);
    }
    .InsertScreen
    {
        font-size: 15px;
        font-family: Arial, Helvetica, sans-serif;
        color: #333333;
        background: url(ImagesNew/inser-screen-bg.jpg) right top no-repeat #fff;
    }
    .InsertScreen h2
    {
        padding: 0 15px 0 0;
        margin: 0;
        font-size: 26px;
        line-height: 75px;
        text-align: right;
    }
    .InsertScreen .Strip
    {
        background: #004b85;
        height: 55px;
        line-height: 60px;
        color: #fff;
        text-align: right;
        padding: 0 15px 0 0;
        font-family: BebasNeueRegular;
        font-size: 39px;
    }
    .InsertScreen p
    {
        font-family: Georgia, "Times New Roman" , Times, serif;
        font-size: 20px;
        color: #003399;
        padding: 20px 0 20px 20px;
        margin: 0;
        line-height: 35px;
    }
    .InsertScreen .Right
    {
        position: absolute;
        top: 25px;
        left: 25px;
    }
    .InsertScreen a.BluBtnNew, .InsertScreen a.BluBtnNew:link, .InsertScreen a.BluBtnNew:active, .InsertScreen a.BluBtnNew:visited, .InsertScreen a.BluBtnNew:hover
    {
        background: url("ImagesNew/blue_Btn_Lft.png") no-repeat left top;
        clear: both;
        display: inline-block;
        font-family: Arial,Helvetica,sans-serif;
        font-size: 13px;
        font-weight: bold;
        line-height: 34px;
        padding: 0 0 0 20px;
        color: #fff;
        text-decoration: none;
        bottom: 20px;
        right: 20px;
        position: absolute;
    }
    .InsertScreen a.BluBtnNew span
    {
        background: url("ImagesNew/blue_Btn_Rgt.png") no-repeat right top;
        clear: both;
        display: block;
        line-height: 34px;
        padding: 0 20px 0 0;
    }
    
    .DockMenuWrap
    {
        width: 989px;
        height: 90px;
        background: url(imagesnew/Doc-menu-bg.gif) left top repeat-x;
        margin: 0 auto;
        text-align: left;
    }
    .DockMenuWrap .Padd
    {
        padding: 5px 32px 0 5px;
        display: inline-block;
    }
    .DockMenuWrap .Padd1
    {
        text-align: center;
        padding: 0px 0 0 40px;
    }
    .DockMenuWrap .Padd img
    {
        display: block;
        clear: both;
        margin: 8px auto 4px;
        border: 0;
    }
    .DockMenuWrap .Padd span
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
        color: #fff;
        font-weight: bold;
        line-height: 14px;
    }
    .DockMenuWrap .Padd .Divider
    {
        margin: 0 22px 0 0 !important;
    }
    .DockMenuWrap .Padd span.Yellow
    {
        color: #fff;
    }
    .DockMenuWrap .Padd span.Green
    {
        color: #fff;
    }
    .DockMenuWrap .Padd a
    {
        width: 69px;
        height: 82px;
        display: inline-block;
        text-align: center;
        text-decoration: none;
        float: left;
        margin: 0 2px 0 0;
        background: url("imagesnew/menu-bg.png") no-repeat scroll left top transparent;
    }
    /* .DockMenuWrap .Padd a{ width:82px; height:82px; background:url(imagesnew/menu-bg.png) left top no-repeat; display:inline-block; text-align:center; text-decoration:none; float:left; margin:0 2px 0 0;}*/
    /*.DockMenuWrap .Padd a:active { width:82px; height:82px; background:url(imagesnew/link-bg.gif) left top no-repeat; display:inline-block; text-align:center; text-decoration:none; float:left; margin:0 2px 0 0;}
        .DockMenuWrap .Padd a:visited { width:82px; height:82px; background:url(imagesnew/bg-hover.png) left top no-repeat; display:inline-block; text-align:center; text-decoration:none; float:left; margin:0 2px 0 0;}*/
    .DockMenuWrap .Padd a:hover
    {
        width: 69px;
        height: 82px;
        background: url(imagesnew/bg-hover.png) left top no-repeat;
        display: inline-block;
        text-align: center;
        text-decoration: none;
        float: left;
        margin: 0 2px 0 0;
    }
    .DockMenuWrap .Padd .blockCalenderSetup, .DockMenuWrap .Padd .blockCalenderSetup:hover
    {
        width: 88px;
    }
    /*DockMenuWrap .Padd{ padding:5px 0 0 5px; display:inline-block; }*/
</style>
<!--Icon Menu start -->
<div class="DockMenuWrap" align="center">
    <div align="center" class="Padd1">
        <div class="Padd">
            <asp:PlaceHolder ID="phMenu" runat="server" />
        </div>
    </div>
</div>
<div style='display: none'>
    <div id='inline_content' style="padding: 10px;">
        <div style="font-family: Arial, Helvetica, sans-serif; background: url(ImagesNew/inser-screen-bg.jpg) right top no-repeat #fff;">
            <img style="float: left; padding: 0 0 10px;" src="imagesnew/alertIcon.gif" /><p style="padding: 0;
                margin: 0; font-size: 18px; color: #af0101; margin: 0; padding: 0 0 5px 0; font-weight: bold;
                line-height: 25px;">
                Are you sure you are a Medical Service Provider?</p>
            <p style="font-size: 12px; font-weight: bold; color: #1d1d1d; padding: 0 0 10px 0;
                margin: 0; line-height: 20px;">
                If You proceed you will able to create a Medical Service Profile.
                <br />
                Are you Sure?</p>
            <div style="width: 230px; float: left; text-align: right;">
                <a href="Profile.aspx" class="BluBtnNew" style="padding: 0 0 0 20px; margin: 0; float: none;">
                    <span>Yes</span></a>&nbsp; <a href="#" class="BluBtnNew remove" style="padding: 0 0 0 20px;
                        margin: 0; float: none;"><span>No</span></a>
            </div>
            <div style="clear: both;">
            </div>
        </div>
    </div>
</div>
<!--Icon Menu end -->
