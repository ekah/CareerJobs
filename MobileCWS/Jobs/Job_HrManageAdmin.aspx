<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_HrManageAdmin.aspx.cs" Inherits="Job_Job_HrManageAdmin" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<style>
    .fullWidthPageContent{padding:0!important;}
    .fullWidthPageTopbg .fullWidthPageContent h3{line-height: 40px!important;}
    .adddatapanelmid{ margin-left:2px;}
    </style>

<div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">


<div class="jobs_content">
 <div class="innerpanel">
    <div class="adminpanel">
            <div class="adminpage_cntbgmid">
            <div class="adminheadingbg">
                <h3>HR Manage Admin</h3>
                <div class="adminlogoutpanel">
                <ul>
                    <li style="background:none;"><asp:LinkButton ID="lnklogout" runat="server" Text="Logout" 
                onclick="lnklogout_Click"></asp:LinkButton></li>
                </ul>
                </div>
            </div>
            
            
            <div class="manageadmincnt">
            <div class="manageadminboxpanel">
            <div class="adddatapanel">
             <div class="adddatapaneltop"><img src="../ImagesNew/jobs/manageadminboxbgtop.gif" alt="" /></div>
             <div class="adddatapanelmid">
             <div class="adddatatop"><div class="adddatacnt"><img src="../ImagesNew/jobs/adddatabase_icon.gif" alt="" align="absmiddle" />DATA VISIBILITY</div></div>  
             <div class="manageadminboxpadd">  
            <div class="manageadminbox">
           		<ul>
                	<li id="addfacilityli" runat="server"><a id="addfacility" href="Job_HrFacility.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/facilityVisibilityButton.gif" alt="add facility" title="facility visibility" /></a><br /></li>  
                    <li id="addspecialityli" runat="server"><a id="addspeciality" href="Job_HrSpeciality.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/addspecialityvisibility_btn.gif" alt="speciality visibility" title="speciality visibility" /></a><br /></li>
                    <li id="addcountryli" runat="server"><a id="addcountry"  href="Job_HrLocation.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/locationVisibility.gif" alt="add country" title="location visibility" /></a><br /></li>
                    <li id="addjobsli" runat="server"><a id="addjobs" href="Job_HrJobs.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/addjobs_btn.gif" alt="add jobs" title="add jobs" /></a><br /></li>             
                </ul>
           </div> 
             </div> 
            </div>
            <div class="adddatapanelbtm"><img src="../ImagesNew/jobs/manageadminboxbgbtm.gif" alt="" /></div>
            </div> 
             <div class="adddatapanel">
               <div class="adddatapaneltop"><img src="../ImagesNew/jobs/manageadminboxbgtop.gif" alt="" /></div>
             <div class="adddatapanelmid">
              <div class="adddatatop"><div class="adddatacnt"><img src="../ImagesNew/jobs/setvisbility_icon.gif" alt="" align="absmiddle" />SET VISIBILITY</div></div>
               <div class="manageadminboxpadd">    
            <div class="manageadminbox">
           		<ul>
                      <li><a  href="Job_HrHotOppsColVisible.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/adminhotoppsvisibility_btn.gif" alt="hot opps visibility" title="hot opps visibility" /></a><br /></li> 
                    <li id="locationvisibleli" runat="server"><a id="locationvisible" href="Job_HrSearchWidgetColVisible.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/adminjobsearchvisibility_btn.gif" alt="job search visibility" title="job search visibility" /></a><br /></li>
                   
                     <li><a  href="Job_HrSearchResultsColVisible.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/adminsearchresultvisibility_btn.gif" alt="search result visibility" title="search result visibility" /></a><br /></li> 
                     <li><a  href="Job_HrSearchDescriptionColVisible.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/admindescriptionvisibility_btn.gif" alt="description visibility" title="description visibility" /></a><br /></li>           
                </ul>
            </div> 
             </div> 
            </div>
            <div class="adddatapanelbtm"><img src="../ImagesNew/jobs/manageadminboxbgbtm.gif" alt="" /></div>
            </div>
            <div class="adddatapanel1">
            <div class="adddatapaneltop"><img src="../ImagesNew/jobs/manageadminboxbgtop.gif" alt="" /></div>
             <div class="adddatapanelmid">
            <div class="adddatatop"><div class="adddatacnt"><img src="../ImagesNew/jobs/manageusers.gif" alt="" align="absmiddle" />MANAGE USERS</div></div> 
            <div class="manageadminboxpadd">         
             <div class="manageadminbox">
           		<ul>
                 <li id="hrentryvisibleli" runat="server"><a id="hrentryvisible" href="Job_HrCandidateView.aspx?cid=<%= Request.QueryString["cid"] %>"><img src="../ImagesNew/jobs/candidatesView.gif" alt="candidates view" title="candidates view" /></a><br /></li>                  
                </ul>
            </div>               
                 </div>   
             </div>
              <div class="adddatapanelbtm"><img src="../ImagesNew/jobs/manageadminboxbgbtm.gif" alt="" /></div>
            </div>
            </div> 
            </div>
 
            </div>
            <div class="clear"></div>
        
        
</div>
</div>
</div>
</div>
</div>
</div>
    </div>
</div>
</asp:Content>
