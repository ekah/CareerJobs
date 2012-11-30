<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.master"
    CodeFile="Job_PDescription.aspx.cs" Inherits="Jobs_Job_PDescription" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
<!--
.searchdesc_subheadingbg{width:860px!important;}
.jobdescinnercntbg_mid_cnt{width:848px!important; background-color:#ffffff; border:1px solid #c7c4c4;}
.jobContents{width:100%!important;}

-->
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
                                <h3>
                                    Job Description</h3>
                                <div class="searchdesc_subheadingbg">
                                    <div id="divjobtitle" runat="server">
                                        <asp:Label ID="lbljobtitleval" runat="server"></asp:Label></div>
                                </div>
                                <div class="jobdescinnercntbg_mid_cnt">
                                    <div>
                                        <asp:LinkButton ID="LinkButton1" runat="server" Text="Back to Search Results" OnClick="lnkback_Click" CausesValidation="false" style="float:left"  CssClass="backtosearchresults"></asp:LinkButton>
                                        <asp:ImageButton ID="imgApply1" runat="server" OnClick="imgApply_Click" Style="float: right"
                                            CausesValidation="false" ImageUrl="../ImagesNew/jobs/applynow_btn.gif" />
                                        <asp:ImageButton ID="imgShare1" runat="Server" OnClick="imgShare_Click" Style="float: right"
                                            CausesValidation="false" ImageUrl="../ImagesNew/jobs/sharejob_btn.gif" CssClass="btnpadding" />
                                    </div>
                                    <div class="jobContents">
                                        <table width="642px" border="0" cellspacing="0" cellpadding="0">
                                            <tr id="divNumber" runat="server">
                                                <td width="154px" valign="top">
                                                    Job Id :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lbljobidval" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divNumberbr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divcountry" runat="server">
                                                <td>
                                                    Country :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblcountry" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divcountrybr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divstate" runat="server">
                                                <td>
                                                    State :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblstate" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divstatebr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divcity" runat="server">
                                                <td>
                                                    City :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblcity" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divcitybr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divspeciality" runat="server">
                                                <td>
                                                    Department :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblDepartment" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divspecialitybr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divfacility" runat="server">
                                                <td>
                                                    Facility :
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblfacility" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divfacilitybr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divdescription" runat="server">
                                                <td valign="top">
                                                    Description :
                                                </td>
                                                <td>
                                                </td>
                                                <td valign="top">
                                                    <asp:Label ID="lbldescription" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divdescriptionbr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr id="divposteddate" runat="server">
                                                <td valign="top">
                                                    Date Posted :
                                                </td>
                                                <td>
                                                </td>
                                                <td valign="top">
                                                    <asp:Label ID="lbldateposted" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="divposteddatebr" runat="server">
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <asp:LinkButton ID="lnkBack1" runat="server" Text="Back to Search Results" OnClick="lnkback_Click" CausesValidation="false" style="float:left"  CssClass="backtosearchresults"></asp:LinkButton>
                                    <asp:ImageButton ID="imgApply" runat="server" OnClick="imgApply_Click" Style="float: right"
                                        CausesValidation="false" ImageUrl="../ImagesNew/jobs/applynow_btn.gif" />
                                    <asp:ImageButton ID="imgShare" runat="Server" OnClick="imgShare_Click" Style="float: right"
                                        CausesValidation="false" ImageUrl="../ImagesNew/jobs/sharejob_btn.gif" CssClass="btnpadding" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
