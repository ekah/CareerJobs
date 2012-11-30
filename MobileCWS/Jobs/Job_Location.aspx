<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/SubAdminMasterPage.Master"
    CodeFile="Job_Location.aspx.cs" Inherits="Jobs_Job_Location" %>

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
            .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    </style>
    <asp:UpdatePanel ID="upLocation" runat="server">
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
                                                Location Admin</h3>
                                            <div class="adminlogoutpanel">
                                                <ul>
                                                    <li style="background: none;">
                                                        <asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" CausesValidation="false" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="gridpanelpadd">
                                            <div class="gridpanel">
                                            <asp:UpdatePanel ID="Up1" runat="server">
                                            <ContentTemplate>
                                                <telerik:RadGrid ID="rglocationjobs" runat="server" AutoGenerateColumns="False" GridLines="None"
                                                    Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12" Width="918px"
                                                    CellPadding="0" OnDeleteCommand="rglocationjobs_DeleteCommand" OnInsertCommand="rglocationjobs_InsertCommand"
                                                    OnUpdateCommand="rglocationjobs_UpdateCommand" OnNeedDataSource="rglocationjobs_NeedDataSource"
                                                    OnItemDataBound="rglocationjobs_ItemDataBound" OnItemCommand="rglocationjobs_ItemCommand">
                                                    <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                        DataKeyNames="Lid,CountryId,StateId,CityId,ClientId">
                                                        <CommandItemSettings AddNewRecordText="Add Location" />
                                                        <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save">
                                                        </EditFormSettings>
                                                        <Columns>
                                                            <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn"
                                                                ItemStyle-Width="35px" ItemStyle-Height="30px" ItemStyle-HorizontalAlign="Center">
                                                                <ItemStyle CssClass="imgedit" />
                                                            </telerik:GridEditCommandColumn>                                                          
                                                            <telerik:GridTemplateColumn HeaderText="Country" SortExpression="Country" UniqueName="Country"
                                                                ItemStyle-Width="125px" ItemStyle-Height="30px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblcountry" Text='<%# Eval("Country") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbCountry" CausesValidation="false" DataTextField="CountryName" DataValueField="CountryId"
                                                                        OnSelectedIndexChanged="rcbCountry_SelectedIndexChanged" AutoPostBack="true"
                                                                        runat="server" Width="250px" />
                                                                    <asp:RequiredFieldValidator ID="rfvCountry" runat="server" InitialValue="--Select--" ControlToValidate="rcbCountry"
                                                                        ErrorMessage="Please select country" Display="Dynamic" SetFocusOnError="true" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="State" SortExpression="StateName" UniqueName="StateName"
                                                                ItemStyle-Width="125px" ItemStyle-Height="30px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblState" Text='<%# Eval("StateName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbState" DataTextField="StateName" CausesValidation="false" DataValueField="StateId"
                                                                        OnSelectedIndexChanged="rcbState_SelectedIndexChanged" AutoPostBack="true" runat="server"
                                                                        Width="250px" />
                                                                    <asp:RequiredFieldValidator ID="rfvState" runat="server" InitialValue="--Select--" ControlToValidate="rcbState"
                                                                        ErrorMessage="Please select state" Display="Dynamic" SetFocusOnError="true" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="City" SortExpression="CityName" UniqueName="CityName"
                                                                ItemStyle-Width="125px" ItemStyle-Height="30px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblCity" Text='<%# Eval("CityName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbCity" CausesValidation="false" DataTextField="CityName" DataValueField="CityId"
                                                                        runat="server" Width="250px" />
                                                                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" InitialValue="--Select--" ControlToValidate="rcbCity"
                                                                        ErrorMessage="Please select city" Display="Dynamic" SetFocusOnError="true" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Visibility"  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="75px"  SortExpression="visibility" UniqueName="visibility"
                                                                ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                <ItemTemplate>
                                                                    <asp:Image ID="imgVisibility" runat="server" />
                                                                    <asp:Label runat="server" ID="lbvisibility" Visible="false" Text='<%# Eval("visibility") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:CheckBox ID="chkVisibilty" runat="server" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                           <telerik:GridTemplateColumn HeaderText="Delete"  HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="75px" ItemStyle-Width="75px" ItemStyle-Height="30px"
                                                                ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="imgdelete" runat="server" ImageUrl="~/ImagesNew/Jobs/jobCloseButton.png" CommandName="delete" OnClientClick="return ConfirmDelete();" />
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                        </Columns>
                                                    </MasterTableView>
                                                </telerik:RadGrid>
                                                </ContentTemplate>
                                                </asp:UpdatePanel>
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
