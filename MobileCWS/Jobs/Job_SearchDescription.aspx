<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/SecondaryMasterPage.master" CodeFile="Job_SearchDescription.aspx.cs" Inherits="Job_Job_SearchDescription" %>
<%@ Register Src="JobSearchRight.ascx" TagName="JobSearchRight" TagPrefix="uc1" %>
<%@ Register Src="HotOppsRight.ascx" TagName="HotOppsRight" TagPrefix="uc2" %>
<%@ Register Src="NewsLetterRight.ascx" TagName="NewsLetterRight" TagPrefix="uc3" %>  

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<link href="../StylesNew/Jobs/job_style.css" rel="stylesheet" type="text/css" />
 <div class="innercontent">
    <div class="innerlftpanel">
        <div class="innercntbg_top"><img src="../ImagesNew/jobs/innerpage_cntbgtop.gif" alt="" /></div>
        <div class="innercntbg_mid">
        <div class="headingbg"><h3>Job Description</h3></div>
             <div class="searchdesc_subheadingbg">
           <div id="divjobtitle" runat="server"><asp:Label ID="lbljobtitleval" runat="server"></asp:Label></div>
           </div>
   
    <div class="jobdescinnercntbg_mid_cnt">
       <div>
    <asp:LinkButton ID="lnkBack1" runat="server" Text="Back to Search Results" OnClick="lnkback_Click" CausesValidation="false" style="float:left"  CssClass="backtosearchresults"></asp:LinkButton>
    <asp:ImageButton ID="imgApply1" runat="server" OnClick="imgApply_Click" style="float:right" CausesValidation="false" ImageUrl="../ImagesNew/jobs/applynow_btn.gif" />
    <asp:ImageButton ID="imgShare1" runat="Server" OnClick="imgShare_Click" style="float:right" CausesValidation="false" ImageUrl="../ImagesNew/jobs/sharejob_btn.gif" CssClass="btnpadding"/>
    </div>
    <div class="jobContents">
        <table width="642px" border="0" cellspacing="0" cellpadding="0">
          <tr id="divNumber" runat="server">
            <td width="154px" valign="top">Job Id :</td>
            <td></td>
            <td><asp:Label ID="lbljobidval" runat="server"></asp:Label></td>
          </tr>
          <tr id="divNumberbr" runat="server"><td>&nbsp;</td></tr>
          <tr id="divcountry" runat="server">
            <td>Country :</td>
            <td></td>
            <td><asp:Label ID="lblcountry" runat="server"></asp:Label></td>
          </tr>
           <tr id="divcountrybr" runat="server"><td>&nbsp;</td></tr>
             <tr id="divstate" runat="server">
            <td>State :</td>
            <td></td>
            <td><asp:Label ID="lblstate" runat="server"></asp:Label></td>
          </tr>
           <tr id="divstatebr" runat="server"><td>&nbsp;</td></tr>
             <tr id="divcity" runat="server">
            <td>City :</td>
            <td></td>
            <td><asp:Label ID="lblcity" runat="server"></asp:Label></td>
          </tr>
           <tr id="divcitybr" runat="server"><td>&nbsp;</td></tr>
          <tr id="divspeciality" runat="server">
            <td>Department :</td>
            <td></td>
            <td><asp:Label ID="lblDepartment" runat="server"></asp:Label></td>
          </tr>
            <tr  id="divspecialitybr" runat="server"><td>&nbsp;</td></tr>          
            <tr id="divfacility" runat="server">
            <td>Facility :</td>
            <td></td>
            <td><asp:Label ID="lblfacility" runat="server"></asp:Label></td>
          </tr>
           <tr  id="divfacilitybr" runat="server"><td>&nbsp;</td></tr>
          <tr id="divdescription" runat="server">
            <td valign="top">Description :</td>
            <td></td>
            <td valign="top"><asp:Label ID="lbldescription" runat="server"></asp:Label></td>
          </tr>        
           <tr id="divdescriptionbr" runat="server"><td>&nbsp;</td></tr> 
            <tr id="divposteddate" runat="server">
            <td valign="top">Date Posted :</td>
            <td></td>
            <td valign="top"><asp:Label ID="lbldateposted" runat="server"></asp:Label></td>
          </tr>
           <tr id="divposteddatebr" runat="server"><td>&nbsp;</td></tr>
        </table>         
        </div>
    <asp:LinkButton ID="lnkback" runat="server" Text="Back to Search Results" OnClick="lnkback_Click" style="float:left" CausesValidation="false" CssClass="backtosearchresults"></asp:LinkButton>
    <asp:ImageButton ID="imgApply" runat="server" OnClick="imgApply_Click" style="float:right" CausesValidation="false"  ImageUrl="../ImagesNew/jobs/applynow_btn.gif" />
    <asp:ImageButton ID="imgShare" runat="Server" OnClick="imgShare_Click" style="float:right" CausesValidation="false" ImageUrl="../ImagesNew/jobs/sharejob_btn.gif" CssClass="btnpadding"/>
    </div>
    </div>
    
     <div class="innercntbg_btm"><img src="../ImagesNew/jobs/innerpage_cntbgbottom.gif" alt="" /></div> 
  </div>
  
  <div class="innerrgtpanel">
    
    	<div class="innercareersearch">
            <div class="innercareersearch_top"><img src="../ImagesNew/jobs/innercareersearch_bgtop.gif" alt="" /></div>
              <div class="innercareersearch_mid">
               <uc1:JobSearchRight id="Jobsearchright1" runat="server"></uc1:JobSearchRight>
              </div>
            <div class="innercareersearch_btm"><img src="../ImagesNew/jobs/innercareersearch_bgbtm.gif" alt="" /></div>
        </div>
        <div class="innerrecentopportunities">
        <div class="innerrecentopportunities_top"><img src="../ImagesNew/jobs/innerrecentopportunities_top.gif" alt="" /></div>
          <div class="innerrecentopportunities_mid">
             <uc2:HotOppsRight id="HotOppsHomeright1" runat="server"></uc2:HotOppsRight>
          </div>
        <div class="innerrecentopportunities_btm"><img src="../ImagesNew/jobs/innerrecentopportunities_btm.gif" alt="" /></div>
        </div>
        <div class="innernewslettersignup">
        <div class="innernewslettersignup_top"><img src="../ImagesNew/jobs/innercareersearch_bgtop.gif" alt="" /></div>
          <div class="innernewslettersignup_mid">
            <uc3:NewsLetterRight id="newsletterright1" runat="server"></uc3:NewsLetterRight>               
          </div>
        <div class="innernewslettersignup_btm"><img src="../ImagesNew/jobs/innercareersearch_bgbtm.gif" alt="" /></div>
        </div>
    
    </div>
     </div>  
     <div class="clear"></div>
</asp:Content>
