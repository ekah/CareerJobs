<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master"CodeFile="Job_HrSearchWidgetColVisible.aspx.cs" Inherits="Jobs_Job_HrSearchWidgetColVisible" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .fullWidthPageContent{padding:0!important;}
    .fullWidthPageTopbg .fullWidthPageContent h3{line-height: 40px!important;}
    
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
                <h3>admin job search</h3>
  			  <div class="adminlogoutpanel">
                <ul>
                   
                     <li  style="background:none;"><asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" 
                                onclick="lnkManageAdmin_Click"></asp:LinkButton></li>
                </ul>
                </div>
             </div> 
             <div class="candidatedetails_subheadingbg">
             Visible Location       
            </div> 
      <div class="candidatecntbg_mid_cnt">  
        <div>
        <asp:CheckBoxList ID="checklocation" runat="server" RepeatDirection="Vertical">
        <asp:ListItem Text="Country" Value="Country"></asp:ListItem>
        <asp:ListItem Text="State" Value="State"></asp:ListItem>
        <asp:ListItem Text="City" Value="City"></asp:ListItem>
        <asp:ListItem Text="Facility" Value="Facility"></asp:ListItem>
        </asp:CheckBoxList>
        </div>
        <div>
        <asp:Button ID="btnupdate" style="margin-top:17px;" runat="server" Text="Update" onclick="btnupdate_Click" />
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