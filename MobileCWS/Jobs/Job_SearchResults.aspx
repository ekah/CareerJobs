<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/SecondaryMasterPage.master" CodeFile="Job_SearchResults.aspx.cs" Inherits="Job_Job_SearchResults" %>
<%@ Register Src="JobSearchRight.ascx" TagName="JobSearchRight" TagPrefix="uc1" %>
<%@ Register Src="HotOppsRight.ascx" TagName="HotOppsRight" TagPrefix="uc2" %>
<%@ Register Src="NewsLetterRight.ascx" TagName="NewsLetterRight" TagPrefix="uc3" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<link href="../StylesNew/Jobs/job_style.css" rel="stylesheet" type="text/css" />
<style type="text/css">
.innerrgtpanel .RadGrid .rgRow td, .RadGrid .rgAltRow td, .RadGrid .rgEditRow td, .RadGrid .rgFooter td{padding:2px 3px 2px 6px!important}
.innercntbg_mid a{color: #666666!important; text-decoration:none!important;}
.RadGrid .rgHeader a {color: #ffffff!important; font-weight:bold;}
.RadGrid_Hay1 .rgHeader, .RadGrid_Hay th.rgResizeCol{ background-color:#00599d!important;}
.RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:10px!important;    padding-top:10px!important;}
.RadGrid_Hay1 .rgAltRow{background:none repeat scroll 0 0 #e6e7e9!important;}
.RadGrid_Hay1 .rgRow td, .RadGrid_Hay1 .rgAltRow td, .RadGrid_Hay1 .rgEditRow td, .RadGrid_Hay1 .rgFooter td{border-width:0!important; padding:10px!important;}
</style>

   <div class="innercontent">
    <div class="innerlftpanel">
    	<div class="innercntbg_top"><img src="../ImagesNew/jobs/innerpage_cntbgtop.gif" alt="" /></div>
        <div class="innercntbg_mid">
             <div class="headingbg"><h3>Careers Search Results</h3></div>           
        <div style="width:678px;">
        <div id="divnorecords" runat="server" style="text-align:center;padding: 5px;margin: 0 auto;">
        <asp:Label ID="lblnorecords" runat="server" style="font-weight:bold;color:Green;">
        </asp:Label>
        </div>
        <telerik:RadGrid ID="rgSearchResults" runat="server" AllowSorting="True" AutoGenerateColumns="False" EnableEmbeddedSkins="false" 
            PageSize="12" ShowStatusBar="false" GridLines="None" CellPadding="0" Skin="Hay1"   OnItemDataBound="rgSearchResults_ItemDataBound"
            AllowPaging="true" OnNeedDataSource="rgSearchResults_NeedDataSource" ShowFooter="false">
            <MasterTableView CommandItemDisplay="none" DataKeyNames="jobid" BorderWidth="0" NoMasterRecordsText="No results matching your criteria."
                PagerStyle-Visible="false">
                <Columns>
                    <telerik:GridTemplateColumn HeaderText="Job Title" DataField="JobTitle" UniqueName="JobTitle"
                        ItemStyle-Width="330px" HeaderStyle-Width="130px" SortExpression="JobTitle">
                        <ItemTemplate>
                            <a href='Job_SearchDescription.aspx?return=2&cid=<%#Eval("ClientId") %>&JobId=<%#Eval("jobid") %>' title='<%#Eval("jobtitle") %>'
                                target="_self">
                                <asp:Label ID="lblJobTitle" runat="server" Text='<%#Eval("jobtitle") %>'></asp:Label>
                            </a>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn DataField="speciality" HeaderText="Department" SortExpression="speciality"
                        UniqueName="speciality" ItemStyle-Width="330px" >
                    </telerik:GridBoundColumn>
                     <telerik:GridBoundColumn DataField="facility" HeaderText="Facility" SortExpression="facility"
                        UniqueName="facility" ItemStyle-Width="330px" >
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="country" HeaderText="Country" SortExpression="country"
                        UniqueName="country"  ItemStyle-Width="330px">
                    </telerik:GridBoundColumn>
                     <telerik:GridBoundColumn DataField="state" HeaderText="State"  ItemStyle-Width="330px" SortExpression="state"
                        UniqueName="state">
                    </telerik:GridBoundColumn>
                       <telerik:GridBoundColumn DataField="city" HeaderText="City"  ItemStyle-Width="330px" SortExpression="city"
                        UniqueName="city">
                    </telerik:GridBoundColumn>
                       <telerik:GridBoundColumn DataField="posteddate"  ItemStyle-Width="330px" HeaderText="Date Posted" SortExpression="posteddate"
                        UniqueName="posteddate">
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
            <ClientSettings>
                <Scrolling AllowScroll="false" />
            </ClientSettings>
        </telerik:RadGrid>
    	</div>          
   		<div style="padding:6px 9px 0 0; height:60px; text-align:right; color:#666666; font-weight:bold;">
        <div style="width:450px; text-align:left; margin:20px 0 0 9px; float:left;"><asp:Label ID="lblDisplay" runat="server"></asp:Label></div>
       
        <div style=" width:168px; float:right; margin:20px 0 0 0;">
        <div style="width:78px; float:left;"><asp:ImageButton ID="ImgBack" runat="server" AlternateText="Back" ImageUrl="images/backBut.jpg" align="absmiddle" CausesValidation="false"
            OnClick="ImgBack_Click" /> </div>
       <div style="width:78px; float:right; background:url(/images/nextBackDivider.jpg) left center no-repeat;"> <asp:ImageButton ID="ImgNext" runat="server" AlternateText="Next" ImageUrl="images/nextBut.jpg" align="absmiddle" CausesValidation="false"
            OnClick="ImgNext_Click" /> </div>
           
            </div>
            <div class="clear"></div>
   		</div>
        </div>
         <div class="innercntbg_btm"><img src="../ImagesNew/jobs/innerpage_cntbgbottom.gif" alt="" /></div>            
      </div>
        <!--rightpanel start-->
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
     <!--rightpanel end-->  
     </div>  
     <div class="clear"></div> 
</asp:Content>
