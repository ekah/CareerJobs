<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    CodeFile="Job_HrSpeciality.aspx.cs" Inherits="Jobs_Job_HrSpeciality" %>
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
                                                        <asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="gridpanelpadd">
                                            <div class="gridpanel">
                                                <telerik:RadGrid ID="rgSpecialityjobs" runat="server" AutoGenerateColumns="False"
                                                    GridLines="None" Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12"
                                                    CellPadding="0" OnDeleteCommand="rgSpecialityjobs_DeleteCommand" OnInsertCommand="rgSpecialityjobs_InsertCommand"
                                                    OnUpdateCommand="rgSpecialityjobs_UpdateCommand" OnNeedDataSource="rgSpecialityjobs_NeedDataSource"
                                                    OnItemDataBound="rgSpecialityjobs_ItemDataBound">
                                                    <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                        DataKeyNames="SpcId,SpecialityId">
                                                        <CommandItemSettings AddNewRecordText="Add Speciality" />
                                                        <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save">
                                                        </EditFormSettings>
                                                        <Columns>
                                                            <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                                                                <ItemStyle CssClass="imgedit" />
                                                            </telerik:GridEditCommandColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Speciality" SortExpression="Speciality" UniqueName="Speciality">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblSpeciality" Width="125px" Text='<%# Eval("Speciality") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbSpeciality" DataTextField="Speciality" runat="server"
                                                                        DataValueField="Speciality" Width="125px" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Visibility" SortExpression="Visibility" UniqueName="Visibility">
                                                                <ItemTemplate>
                                                                    <asp:Image ID="imgVisibility" runat="server" />
                                                                    <asp:Label runat="server" ID="lbvisibility" Width="125px" Visible="false" Text='<%# Eval("Visibility") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:CheckBox ID="chkVisibilty" runat="server" />
                                                                </EditItemTemplate>
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
</asp:Content>
