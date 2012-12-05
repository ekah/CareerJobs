<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    CodeFile="Job_ManageAdmin.aspx.cs" Inherits="Job_Job_ManageAdmin" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .fullWidthPageContent { padding: 0 !important; }
        .fullWidthPageTopbg .fullWidthPageContent h3 { line-height: 40px !important; }
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
                                        <h3>
                                            Manage Admin</h3>
                                        <div class="adminlogoutpanel">
                                            <ul>
                                                <li style="background: none; color: #004F8C;">
                                                    <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="manageadmincnt">
                                        <div class="manageadminboxpanel">
                                            <div class="adddatapanel">
                                                <div class="adddatapaneltop">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgtop.png" alt="" /></div>
                                                <div class="adddatapanelmid">
                                                    <div class="adddatatop">
                                                        <div class="adddatacnt">
                                                            <img src="../ImagesNew/jobs/adddatabase_icon.gif" alt="" align="absmiddle" />ADD
                                                            DATA</div>
                                                    </div>
                                                    <div class="manageadminboxpadd">
                                                        <div class="manageadminbox">
                                                            <ul>
                                                                <li id="addfacilityli" runat="server"><a id="addfacility" runat="server" href="Job_AdminFacility.aspx">
                                                                    <img src="../ImagesNew/jobs/addfacility_btn.gif" alt="add facility" title="add facility" /></a><br />
                                                                </li>
                                                                <li id="addspecialityli" runat="server"><a id="addspeciality" runat="server" href="Job_AdminSpeciality.aspx">
                                                                    <img src="../ImagesNew/jobs/addspeciality_btn.gif" alt="add speciality" title="add speciality" /></a><br />
                                                                </li>
                                                                <li id="addcountryli" runat="server"><a id="addcountry" runat="server" href="Job_AdminLocation.aspx">
                                                                    <img src="../ImagesNew/jobs/addcountry_btn.gif" alt="Add Location" title="Add Location" /></a><br />
                                                                </li>
                                                                <li id="addjobsli" runat="server"><a id="addjobs" runat="server" href="Job_AdminJobs.aspx">
                                                                    <img src="../ImagesNew/jobs/addjobs_btn.gif" alt="add jobs" title="add jobs" /></a><br />
                                                                </li>
                                                                <li id="liAddClient" runat="server"><a id="addClient" runat="server" href="Job_AddClient.aspx"
                                                                    class="BluBtnNew">
                                                                   <span>Add Client</span></a>
                                                                   <a id="viewClient" runat="server" style="margin-left:5px;" href="Job_ClientView.aspx"
                                                                    class="BluBtnNew">
                                                                   <span>View Client</span></a>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="adddatapanelbtm">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgbtm.png" alt="" /></div>
                                            </div>
                                            <div class="adddatapanel">
                                                <div class="adddatapaneltop">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgtop.png" alt="" /></div>
                                                <div class="adddatapanelmid">
                                                    <div class="adddatatop">
                                                        <div class="adddatacnt">
                                                            <img src="../ImagesNew/jobs/setvisbility_icon.gif" alt="" align="absmiddle" />SET VISIBILITY</div>
                                                    </div>
                                                    <div class="manageadminboxpadd">
                                                        <div class="manageadminbox">
                                                            <ul>
                                                                <li><a href="Job_AdminHotOppsColVisible.aspx">
                                                                    <img src="../ImagesNew/jobs/adminhotoppsvisibility_btn.gif" alt="hot opps visibility"
                                                                        title="hot opps visibility" /></a><br />
                                                                </li>
                                                                <li id="locationvisibleli" runat="server"><a id="locationvisible" runat="server"
                                                                    href="Job_AdminSearchWidgetColVisible.aspx">
                                                                    <img src="../ImagesNew/jobs/adminjobsearchvisibility_btn.gif" alt="job search visibility"
                                                                        title="job search visibility" /></a><br />
                                                                </li>
                                                                <li><a href="Job_AdminSearchResultsColVisible.aspx">
                                                                    <img src="../ImagesNew/jobs/adminsearchresultvisibility_btn.gif" alt="search result visibility"
                                                                        title="search result visibility" /></a><br />
                                                                </li>
                                                                <li><a href="Job_AdminSearchDescriptionColVisible.aspx">
                                                                    <img src="../ImagesNew/jobs/admindescriptionvisibility_btn.gif" alt="description visibility"
                                                                        title="description visibility" /></a><br />
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="adddatapanelbtm">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgbtm.png" alt="" /></div>
                                            </div>
                                            <div class="adddatapanel1">
                                                <div class="adddatapaneltop">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgtop.png" alt="" /></div>
                                                <div class="adddatapanelmid">
                                                    <div class="adddatatop">
                                                        <div class="adddatacnt">
                                                            <img src="../ImagesNew/jobs/manageusers.gif" alt="" align="absmiddle" />MANAGE USERS</div>
                                                    </div>
                                                    <div class="manageadminboxpadd">
                                                        <div class="manageadminbox">
                                                            <ul>
                                                                <li id="hraccessvisibleli" runat="server"><a id="hraccessvisible" runat="server"
                                                                    href="Job_AdminHrAccess.aspx">
                                                                    <img src="../ImagesNew/jobs/addHr.gif" alt="add hr" title="add hr" /></a><br />
                                                                </li>
                                                                <li id="hrentryvisibleli" runat="server"><a id="hrentryvisible" runat="server" href="Job_AdminCandidateView.aspx">
                                                                    <img src="../ImagesNew/jobs/candidatesView.gif" alt="candidates view" title="candidates view" /></a><br />
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="adddatapanelbtm">
                                                    <img src="../ImagesNew/jobs/manageadminboxbgbtm.png" alt="" /></div>
                                            </div>
                                            <%--<asp:LinkButton runat="server" ID="lbtnBackToAbmin" style="float:right;" OnClick="lbtnBackToAbmin_Click" CssClass="BluBtnNew"><span>Back to Admin</span></asp:LinkButton>--%>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
