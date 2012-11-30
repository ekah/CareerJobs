<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.Master"
    CodeFile="Job_PClientResults.aspx.cs" Inherits="Jobs_Job_PClientResults" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater runat="server" ID="rpJobList">
        <ItemTemplate>
        <style type="text/css">
            .fullWidthPageContent ul{padding:0 0 0 20px;}
            .fullWidthPageContent ul li{ list-style:none; background:url(../ImagesNew/jobs/JobsclientArrow.gif) left center no-repeat; padding:0 0 0 12px}
            .fullWidthPageContent ul li a{color:#000000; text-decoration:none; }
            
        </style>
        <div id="container">
        <!--content start -->
        <div class="content">
            <div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">
                             <h3>Jobs</h3>
                            <div style="width:843px; margin:0 auto;">
                            <div style="background:url(../ImagesNew/jobs/JobsclientbutBg.gif) no-repeat; margin:0 0 0 7px; height:36px; width:115px; text-align:center; color:#ffffff; font-weight:bold; line-height:36px;">Client</div>
<div style="background:url(../ImagesNew/jobs/JobsclientCenterBg.gif) repeat-y;">
<div style="background:url(../ImagesNew/jobs/JobsclientTopBg.gif) no-repeat top">
<div style="background:url(../ImagesNew/jobs/JobsclientBottomBg.gif) no-repeat bottom; padding:20px 30px 20px 30px;">
                           
            <div style="position: relative;">
                <ul>
                    <li id="licolor" runat="server">
                        <asp:HyperLink ID="Hystatus" runat="server" NavigateUrl='<%# "Job_PResults.aspx?cid=" + DataBinder.Eval(Container.DataItem,"ClientId") + "&did=" + Request.QueryString["did"] %>'
                            Text='<%# DataBinder.Eval(Container.DataItem, "OrganizationName")%>'></asp:HyperLink>
                    </li>
                </ul>
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
        </ItemTemplate>
    </asp:Repeater>
    <br /><br />
    <div id="lblNoJobs" runat="server" style="text-align:center;" visible="false">
    <asp:Label Text="No jobs found" runat="server" ID="lblNoJobs1" style=" color:Red; text-align:center; font-weight:bold; font-size:18px;"></asp:Label>
    <br />
    <asp:LinkButton Text="" runat="server" OnClick="lbtnBack_Click" CssClass="BluBtnNew" ID="lbtnBack"><span>Back to Search</span></asp:LinkButton>
    </div>
</asp:Content>
