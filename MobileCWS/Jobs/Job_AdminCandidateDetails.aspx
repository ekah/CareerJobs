<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_AdminCandidateDetails.aspx.cs" Inherits="Jobs_Job_AdminCandidateDetails" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<style type="text/css">
<!--
#adminlogoutpanel{margin: 12px 0 0 0;}
        .fullWidthPageContent
        {
            padding: 0 !important;
        }
.fullWidthPageTopbg .fullWidthPageContent h3{ line-height:45px !important;}
.adminpage_cntbgmid, .innersearchpage_cntbgmid{border:none!important;}
.candidatelbl{font-weight:bold!important;}
.adminheadingbg, .innersearchpageheadingbg{margin:26px auto 0!important;}
-->
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
            
            <div style="width:300px; float:left;"><h3>candidate details</h3></div>

  				<div style="width:44px; float:right;"><a href="javascript:self.close()" title="Close"><img title="Close" src="../ImagesNew/Jobs/closeButtonJobs.png" /></a></div>
             </div> 
  <div class="candidatecntbg_mid_cnt">  
  <asp:ValidationSummary ID="val1" runat="server" ShowMessageBox="true" ShowSummary="false"
            DisplayMode="List" ValidationGroup="val1" />
  <div class="inputs">
    
    <table width="880" border="0" cellspacing="0" cellpadding="0" style="line-height:35px;">
    <tr class="candidaterow">
        <td width="200" class="candidatelbl">Job ID</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lbljobid" runat="server"></asp:Label></td>
       </tr>
     
      <tr>
        <td width="200" class="candidatelbl">Name of Candidate</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblCandidatenameval" runat="server"></asp:Label></td>
      </tr>
    
      <tr><td class="clear"></td></tr>
      <tr class="candidaterow">
        <td class="candidatelbl">Age</td>
         <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblageval" runat="server"></asp:Label></td>
      </tr>
  
      <tr><td class="clear"></td></tr>
      <tr>
        <td class="candidatelbl">Sex</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblsexval" runat="server"></asp:Label></td>
      </tr>
   
      <tr>
        <td class="clear"></td>
      </tr>
      <tr  class="candidaterow">
        <td class="candidatelbl">Permanent Address</td>
       <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblpermanentaddressval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Email</td>
         <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblemailval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr  class="candidaterow">
        <td class="candidatelbl">City</td>
         <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblcityval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">District</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lbldistrictval" runat="server"></asp:Label></td>
      </tr>
   
      <tr>
        <td class="clear"></td>
      </tr>
      <tr  class="candidaterow">
        <td class="candidatelbl">State</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblstateval" runat="server"></asp:Label></td>
      </tr>
    
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Country</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblCountryval" runat="server"></asp:Label></td>
      </tr>
      
      <tr>
        <td class="clear"></td>
      </tr>
      <tr  class="candidaterow">
        <td class="candidatelbl">How did you know about us ?</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblhowdidyouval" runat="server"></asp:Label></td>
      </tr>
      
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Contact Phone</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblcontactphoneval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr class="candidaterow">
        <td class="candidatelbl">Contact Mobile</td>
         <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><span><asp:Label ID="lblcontactmobileval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Best time to call</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblbesttimeval" runat="server"></asp:Label></td>
      </tr>
      
      <tr>
        <td class="clear"></td>
      </tr>
      <tr class="candidaterow">
        <td class="candidatelbl">Specialization Category</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblspecializationval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Experience</td>
         <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblexpval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr class="candidaterow">
        <td class="candidatelbl">Highest Qualification</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblhighesqualtval" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Highest Degree</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblhighesdegreeval" runat="server"></asp:Label></td>
      </tr>
      
      <tr>
        <td class="clear"></td>
      </tr>
      <tr class="candidaterow">
        <td class="candidatelbl">Current Employer</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblCurrentEmployer" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Existing Pay (Per Annum)</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblExistingpay" runat="server"></asp:Label></td>
      </tr>
      
      <tr>
        <td class="clear"></td>
      </tr>
       <tr class="candidaterow">
        <td class="candidatelbl">Desired pay (Per Annum)</td>
       <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblDesiredpay" runat="server"></asp:Label></td>
      </tr>
    
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td class="candidatelbl">Willing to relocate</td>
        <td style="color:#000000;">:</td>
        <td class="candidatetxtrgt"><asp:Label ID="lblwillingtorelocate" runat="server"></asp:Label></td>
      </tr>
     
      <tr>
        <td class="clear"></td>
      </tr>          
    </table>
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

