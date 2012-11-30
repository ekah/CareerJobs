<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    CodeFile="Job_AdminFacility.aspx.cs" Inherits="Jobs_Job_AdminFacility" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .fullWidthPageContent
        {
            padding: 0 !important;
        }
        .fullWidthPageTopbg .fullWidthPageContent h3
        {
            line-height: 40px !important;
        }
        #ctl00_MainContent_rgFacilityJobs_ctl00_ctl02_ctl03_EditCell__facility input
        {
            width: 242px;
            height: 30px;
            line-height: 30px;
            padding: 0 5px;
            background: url(../ImagesNew/jobs/facilityTextBox-Bg.jpg) no-repeat left top;
            border: none;
            border-spacing: none !important;
            color: #333333;
            font: 12px "Segoe UI" ,Arial,sans-serif;
            
        }
        input#ctl00_MainContent_rgFacilityJobs_ctl00_ctl02_ctl03_rtbFacility_text 
        {
            line-height: 30px;
        }
        .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    .RadGrid_Hay .rgHeader, .RadGrid_Hay th.rgResizeCol{background:url("../../ImagesNew/jobs/gridbg_adminpage.gif") repeat-x scroll 0 -2300px #2DAFE3 !important}
    #ctl00_MainContent_rgFacilityJobs_ctl00_ctl02_ctl03_EditCell__facility{ width:375px;}
    </style>
    <asp:UpdatePanel ID="upFacility" runat="server">
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
                                                    <h3>
                                                        Facility Admin</h3>
                                                    <div class="adminlogoutpanel">
                                                        <ul>
                                                            <li>
                                                                <asp:LinkButton ID="lnkManageAdmin" runat="server" CausesValidation="false" Text="Job Manage Admin" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                            <li>
                                                                <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="gridpanelpadd">
                                                    <div class="gridpanel">
                                                        <telerik:RadGrid ID="rgFacilityJobs" runat="server" AutoGenerateColumns="False" GridLines="None"
                                                            AllowSorting="true" AllowPaging="true" PageSize="12" Width="918px" Skin="Hay"
                                                            CellPadding="0" OnDeleteCommand="rgFacilityJobs_DeleteCommand" OnInsertCommand="rgFacilityJobs_InsertCommand"
                                                            OnUpdateCommand="rgFacilityJobs_UpdateCommand" OnNeedDataSource="rgFacilityJobs_NeedDataSource"
                                                            OnItemDataBound="rgFacilityJobs_ItemDataBound" OnItemCommand="rgFacilityJobs_ItemCommand">
                                                            <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                                DataKeyNames="facid,facility,ClientId">
                                                                <CommandItemSettings AddNewRecordText="Add Facility" />
                                                                <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save">
                                                                </EditFormSettings>
                                                                <Columns>
                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn"
                                                                        ItemStyle-Height="30px" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                                        <ItemStyle CssClass="imgedit" />
                                                                    </telerik:GridEditCommandColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Client" SortExpression="Client" UniqueName="Client"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblClient" Text='<%# Eval("Client") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbclient" Filter="Contains" ValidationGroup="addFacility" DataTextField="Client" runat="server" Width="250px"
                                                                                DataValueField="Client" />
                                                                            <asp:RequiredFieldValidator ID="Requiredfieldvalidator1" runat="server" ControlToValidate="rcbclient"
                                                                                ErrorMessage="Please select client" Display="Dynamic" InitialValue="--Select--" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>

                                                                    <telerik:GridTemplateColumn HeaderText="Facility" SortExpression="Client" UniqueName="facility"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblfacility" Text='<%# Eval("facility") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadTextBox ID="rtbFacility" Text='<%# Eval("facility") %>' ValidationGroup="addFacility" runat="server" Width="247px" />
                                                                            <asp:RequiredFieldValidator ID="Requiredfieldvalidator12" runat="server" ControlToValidate="rtbFacility"
                                                                                ErrorMessage="Please enter facility" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>

                                                                    <%--<telerik:GridBoundColumn DataField="facility" HeaderText="Facility" SortExpression="facility"
                                                                        UniqueName="facility" ColumnEditorID="GridTextBoxColumnEditor1">
                                                                    </telerik:GridBoundColumn>--%>
                                                                    <telerik:GridTemplateColumn HeaderText="Visibility" SortExpression="visibility" UniqueName="visibility"
                                                                        HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Image ID="imgVisibility" runat="server" />
                                                                            <asp:Label runat="server" ID="lbvisibility" Visible="false" Text='<%# Eval("visibility") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:CheckBox ID="chkVisibilty" runat="server" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Delete" HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center"
                                                                        ItemStyle-HorizontalAlign="Center" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:ImageButton ID="imgdelete" runat="server" ImageUrl="~/ImagesNew/Jobs/jobCloseButton.png"
                                                                                CommandName="delete" OnClientClick="return ConfirmDelete();" />
                                                                        </ItemTemplate>
                                                                    </telerik:GridTemplateColumn>
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
