<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    CodeFile="Job_AdminSpeciality.aspx.cs" Inherits="Jobs_Job_AdminSpeciality" %>

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
        .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    .RadGrid_Hay .rgHeader, .RadGrid_Hay th.rgResizeCol{background:url("../../ImagesNew/jobs/gridbg_adminpage.gif") repeat-x scroll 0 -2300px #2DAFE3 !important}
    </style>
    <asp:UpdatePanel runat="server" ID="upSpeciality">
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
                                                        Speciality Admin</h3>
                                                    <div class="adminlogoutpanel">
                                                        <ul>
                                                            <li>
                                                                <asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" CausesValidation="false" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                            <li>
                                                                <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="gridpanelpadd">
                                                    <div class="gridpanel">
                                                        <telerik:RadGrid ID="rgSpecialityjobs" runat="server" AutoGenerateColumns="False"
                                                            GridLines="None" Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12"
                                                            Width="918px" CellPadding="0" OnDeleteCommand="rgSpecialityjobs_DeleteCommand"
                                                            OnInsertCommand="rgSpecialityjobs_InsertCommand" OnUpdateCommand="rgSpecialityjobs_UpdateCommand"
                                                            OnNeedDataSource="rgSpecialityjobs_NeedDataSource" OnItemCommand="rgSpecialityjobs_ItemCommand" OnItemDataBound="rgSpecialityjobs_ItemDataBound">
                                                            <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                                DataKeyNames="SpcId,SpecialityId,OrganizationId">
                                                                <CommandItemSettings AddNewRecordText="Add Speciality" />
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
                                                                            <telerik:RadComboBox ID="rcbclient" Filter="Contains" DataTextField="Client" runat="server" Width="250px"
                                                                                DataValueField="Client" />
                                                                            <asp:RequiredFieldValidator ID="rfvClient" runat="server" ControlToValidate="rcbclient"
                                                                                ErrorMessage="Please select client" Display="Dynamic" InitialValue="--Select--" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Speciality" SortExpression="Speciality" UniqueName="Speciality"
                                                                        ItemStyle-Width="110px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblSpeciality" Text='<%# Eval("Speciality") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbSpeciality" DataTextField="Speciality" runat="server"
                                                                                Width="250px" DataValueField="Speciality" />
                                                                            <asp:RequiredFieldValidator ID="rfvSpeciality" runat="server" ControlToValidate="rcbSpeciality"
                                                                                ErrorMessage="Please select speciality" Display="Dynamic" InitialValue="--Select--" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Visibility" SortExpression="Visibility" UniqueName="Visibility"
                                                                        HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center" ItemStyle-Height="30px"
                                                                        ItemStyle-HorizontalAlign="Center">
                                                                        <ItemTemplate>
                                                                            <asp:Image ID="imgVisibility" runat="server" />
                                                                            <asp:Label runat="server" ID="lbvisibility" Visible="false" Text='<%# Eval("Visibility") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:CheckBox ID="chkVisibilty" runat="server" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Delete" HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center"
                                                                        ItemStyle-Height="30px" ItemStyle-HorizontalAlign="Center">
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
