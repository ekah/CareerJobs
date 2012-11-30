<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/SubAdminMasterPage.Master"
    CodeFile="Job_SubAdminManageAdmin.aspx.cs" Inherits="Job_Job_SubAdminManageAdmin" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <div class="appHistory" style="margin: 18px 0 0 0;">
        <div class="appHistoryCenterBg">
            <div class="appHistoryTopbg">
                <div class="appHistoryBottompbg">
                    <br />
                    <div class="historyContBox">
                        <div class="historyContBoxCenterBG">
                            <div class="historyContBoxTopBG">
                                <div class="historyContBoxBottomBG">
                                    <div class="jobs_content">
                                        <div class="innerpanel">
                                            <div class="adminpanel">
                                                <div class="adminpage_cntbgmid">
                                                    <div class="adminheadingbg">
                                                        <h3 style="color: #004F8C; background: url('../ImagesNew/h2Underline.gif') repeat-x scroll left bottom transparent;">
                                                            Sub Manage Admin</h3>
                                                        <div class="adminlogoutpanel">
                                                            <ul>
                                                                <li style="background: none;">
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
                                                                                <li id="addfacilityli" runat="server"><a id="addfacility" runat="server" href="Job_Facility.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/addfacility_btn.gif" alt="add facility" title="add facility" /></a><br />
                                                                                </li>
                                                                                <li id="addspecialityli" runat="server"><a id="addspeciality" runat="server" href="Job_Speciality.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/addspeciality_btn.gif" alt="speciality visibility" title="add speciality" /></a><br />
                                                                                </li>
                                                                                <li id="addcountryli" runat="server"><a id="addcountry" runat="server" href="Job_Location.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/addcountry_btn.gif" alt="add country" title="add location" /></a><br />
                                                                                </li>
                                                                                <li id="addjobsli" runat="server"><a id="addjobs" runat="server" href="Job_Jobs.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/addjobs_btn.gif" alt="add jobs" title="add jobs" /></a><br />
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
                                                                            <img src="../ImagesNew/jobs/setvisbility_icon.gif" alt="" align="absmiddle" />SET
                                                                            VISIBILITY</div>
                                                                    </div>
                                                                    <div class="manageadminboxpadd">
                                                                        <div class="manageadminbox">
                                                                            <ul>
                                                                                <li><a href="Job_HotOppsColVisible.aspx">
                                                                                    <img src="../ImagesNew/jobs/adminhotoppsvisibility_btn.gif" alt="hot opps visibility"
                                                                                        title="hot opps visibility" /></a><br />
                                                                                </li>
                                                                                <li id="locationvisibleli" runat="server"><a id="locationvisible" runat="server"
                                                                                    href="Job_SearchWidgetColVisible.aspx" runat="server">
                                                                                    <img src="../ImagesNew/jobs/adminjobsearchvisibility_btn.gif" alt="job search visibility"
                                                                                        title="job search visibility" /></a><br />
                                                                                </li>
                                                                                <li><a href="Job_SearchResultsColVisible.aspx">
                                                                                    <img src="../ImagesNew/jobs/adminsearchresultvisibility_btn.gif" alt="search result visibility"
                                                                                        title="search result visibility" /></a><br />
                                                                                </li>
                                                                                <li><a href="Job_SearchDescriptionColVisible.aspx">
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
                                                                                <li id="hraccessvisibleli"><a id="hraccessvisible" runat="server" href="Job_HrAccess.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/addHr.gif" alt="Add Hr" title="add hr" /></a><br />
                                                                                </li>
                                                                                <li id="hrentryvisibleli" runat="server"><a id="hrentryvisible" runat="server" href="Job_CandidateView.aspx"
                                                                                    runat="server">
                                                                                    <img src="../ImagesNew/jobs/candidatesView.gif" alt="candidates view" title="candidates view" /></a><br />
                                                                                </li>
                                                                            </ul>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="adddatapanelbtm">
                                                                    <img src="../ImagesNew/jobs/manageadminboxbgbtm.png" alt="" /></div>
                                                            </div>
                                                            <asp:LinkButton runat="server" ID="lbtnBackToAdmin" style="float:right;" OnClick="lbtnBackToAdmin_Click" CssClass="BluBtnNew"><span>Back to Admin</span></asp:LinkButton>
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
