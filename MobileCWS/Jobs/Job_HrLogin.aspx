<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_HrLogin.aspx.cs" Inherits="Jobs_Job_HrLogin" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .fullWidthPageContent{padding:0!important;}
    .fullWidthPageTopbg .fullWidthPageContent h3{line-height: 40px!important;}
    .adminloginpanel{float:left;padding:25px 0 0 32px;}
   .adminheadingbg, .innersearchpageheadingbg{width: 500px!important; float: left!important;}
   .headerLink{float:right; font-style:italic; line-height:95px; color:#fff; margin:0 77px 0 0; font-weight:bold;}
        .headerLink a{color:#fff;}
        .headerLink a:hover{text-decoration:none;}
    .adminloginpanel{ padding-top:17px;}
    </style>

<div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">


<div class="jobs_content">
    <div class="innerpanel">
        
        <div class="adminpage_cntbgmid">
            <div class="adminheadingbg">
                <h3>HR Manage Admin</h3>
                 </div>
                 <p class="headerLink"><a href="../Hospital.aspx">back</a></p>
                                <div class="clear"></div>
            <div class="innercntbg_mid_cnt">
            	<div class="admincntpanel">
                <div class="adminloginpanel">
                <div class="adminloginicon"><img src="../ImagesNew/jobs/adminlogin_icon.jpg" alt="" /></div>
                <div class="adminloginbox">
                    <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                    <div class="textbox">
                    <div class="lftlable">Username : </div>           
                    <asp:TextBox ID="txtUsername" runat="Server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requsername" runat="server" Display="Dynamic" style="margin-left:77px;" ControlToValidate="txtUsername" ErrorMessage="Enter Username"></asp:RequiredFieldValidator>
                    </div>
                    <div class="textbox">
                    <div class="lftlable1">Password : </div>          
                    <asp:TextBox ID="txtPassword" runat="Server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqpassword" Display="Dynamic" runat="server" style="margin-left:77px;" ControlToValidate="txtPassword" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
                    </div>
                    
                    <div class="loginbtn">
                    <asp:ImageButton ID="imgLogin" runat="Server" ImageUrl="../ImagesNew/jobs/adminlogin_btn.jpg" 
                            onclick="imgLogin_Click" style="height: 28px;width:75px;" />
                    </div>
                </div> 
                 </div>
                </div>
            </div>
        </div>
        
    </div>
    </div>

    </div>
</div>
</div>
    </div>
</div>
</asp:Content>
