<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_HrSearchResultsColVisible.aspx.cs" Inherits="Jobs_Job_HrSearchResultsColVisible" %>

<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">

<script language="javascript" type="text/javascript">
    function ValidateModuleList(source, args) {
        var chkListModules = document.getElementById('<%= chkSearchResults.ClientID %>');
        var chkListinputs = chkListModules.getElementsByTagName("input");
        var numSelected = 0;
        for (var i = 0; i < chkListinputs.length; i++) {
            if (chkListinputs[i].checked) {
                numSelected = numSelected + 1;
            }

        }

        if (numSelected != 0) {

            if (numSelected <= 2) {
                args.IsValid = true;
                return;
            }
        }
        args.IsValid = false;
    }
</script>

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
                <h3>
                    Search Results Admin</h3>
                <div class="adminlogoutpanel">
                    <ul>
                       
                      <li  style="background:none;"><asp:LinkButton ID="lnkManageAdmin" CausesValidation="false" runat="server" Text="Job Manage Admin" 
                                onclick="lnkManageAdmin_Click"></asp:LinkButton></li>
                    </ul>
                </div>
            </div>
            <div class="candidatedetails_subheadingbg">
                Search Results Visibility
            </div>
            <div class="candidatecntbg_mid_cnt">
                <div>
                    <asp:CheckBoxList ID="chkSearchResults" runat="server" RepeatDirection="Vertical">
                        <asp:ListItem Text="Country" Value="Country"></asp:ListItem>
                        <asp:ListItem Text="State" Value="State"></asp:ListItem>
                        <asp:ListItem Text="City" Value="City"></asp:ListItem>
                        <asp:ListItem Text="Facility" Value="Facility"></asp:ListItem>
                        <asp:ListItem Text="Speciality" Value="Speciality"></asp:ListItem>
                         <asp:ListItem Text="PostDate" Value="PostDate"></asp:ListItem>
                    </asp:CheckBoxList>
                    <asp:CustomValidator runat="server" ID="cvmodulelist" ClientValidationFunction="ValidateModuleList"
                        ErrorMessage="Select one or two items only"></asp:CustomValidator>
                </div>
                <div>
                    <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
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