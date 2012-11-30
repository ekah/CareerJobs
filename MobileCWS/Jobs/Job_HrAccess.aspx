<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_HrAccess.aspx.cs" Inherits="Job_Job_HrAccess" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<style>
    .fullWidthPageContent{padding:0!important;}
    .fullWidthPageTopbg .fullWidthPageContent h3{line-height: 40px!important;}
    RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
            .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    .RadGrid_Hay .rgHeader, .RadGrid_Hay th.rgResizeCol{background:url("../../ImagesNew/jobs/gridbg_adminpage.gif") repeat-x scroll 0 -2300px #2DAFE3 !important}
    #ctl00_MainContent_rghr_ctl00_ctl02_ctl02_EditCell__hrusername, #ctl00_MainContent_rghr_ctl00_ctl05_EditCell__hrusername{ width:500px!important;}
    </style>
<asp:UpdatePanel ID="upJob_HrAccess" runat="server">
<ContentTemplate>
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
                <h3>Hr Admin</h3>
                <div class="adminlogoutpanel">
                <ul>
                    
                 <li  style="background:none;"><asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" 
                                onclick="lnkManageAdmin_Click"></asp:LinkButton></li>
                 </ul>
                 </div>
            </div>
        <div class="gridpanelpadd" >       
           <div class="gridpanel">
                <telerik:RadGrid ID="rghr" runat="server" AutoGenerateColumns="False" GridLines="None" Skin="Hay"
                    CellPadding="0"  OnDeleteCommand="rghr_DeleteCommand" OnInsertCommand="rghr_InsertCommand"
                    OnUpdateCommand="rghr_UpdateCommand" OnNeedDataSource="rghr_NeedDataSource"
                    OnItemDataBound="rghr_ItemDataBound" OnItemCommand="rghr_ItemCommand">
                    <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                        DataKeyNames="Hid,UserName">
                        <CommandItemSettings AddNewRecordText="Add User" /> 
                         <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save"></EditFormSettings>  
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" HeaderStyle-Width="50px" ItemStyle-HorizontalAlign="Center" UniqueName="EditCommandColumn">
                                <ItemStyle CssClass="imgedit" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridTemplateColumn HeaderText="User Name" SortExpression="hrusername" UniqueName="hrusername"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblUserName" Text='<%# Eval("UserName") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbUserName" Text='<%# Eval("UserName") %>' runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="rtbUserName"
                                        ErrorMessage="Please enter user name" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <%--<telerik:GridBoundColumn DataField="UserName" HeaderText="User Name" SortExpression="hrusername"
                                UniqueName="hrusername" ColumnEditorID="GridTextBoxColumnEditor1">
                            </telerik:GridBoundColumn>--%>
                            <telerik:GridTemplateColumn HeaderText="Password" SortExpression="hrpassword" UniqueName="hrpassword"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblPassword" Text='<%# Eval("Password") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbPassword" Text='<%# Eval("Password") %>' runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="rtbPassword"
                                        ErrorMessage="Please enter password" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                           <%--<telerik:GridBoundColumn DataField="Password" HeaderText="Password" SortExpression="hrpassword"
                                UniqueName="hrpassword" ColumnEditorID="GridTextBoxColumnEditor1">
                            </telerik:GridBoundColumn>--%>
                            <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                HeaderStyle-HorizontalAlign="Center" UniqueName="DeleteColumn" ItemStyle-VerticalAlign="Middle"
                                HeaderStyle-Width="70px">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" ToolTip="click here to delete"
                                        CssClass="MyImageButton"><img src="../ImagesNew/Jobs/jobCloseButton.png" border="0px" alt="delete" /></asp:LinkButton>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <%--<telerik:GridButtonColumn ConfirmText="Delete this Username?" ConfirmDialogType="RadWindow"
                                ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                UniqueName="DeleteColumn">
                                <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton" />
                            </telerik:GridButtonColumn>--%>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
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
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>