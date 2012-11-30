<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master"
    AutoEventWireup="true" CodeFile="AdminListDiagnosis.aspx.cs" Inherits="Admin_AdminListDiagnosis" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu1" runat="server" />

    <style type="text/css">
        .MyImageButton
        {
            cursor: hand;
        }
        .EditFormHeader td
        {
            font-size: 14px;
            padding: 4px !important;
            color: #0066cc;
        }
    </style>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">
            function RowDblClick(sender, eventArgs) {
                sender.get_masterTableView().editItem(eventArgs.get_itemIndexHierarchical());
            }

            function gridCreated(sender, args) {
                if (sender.get_editIndexes && sender.get_editIndexes().length > 0) {
                    document.getElementById("OutPut").innerHTML = sender.get_editIndexes().join();
                }
                else {
                    document.getElementById("OutPut").innerHTML = "";
                }
            }
        </script>
    </telerik:RadCodeBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="rgAdminListDiagnosis">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rgAdminListDiagnosis" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="RadWindowManager1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" MinDisplayTime="1000"
        Skin="" IsSticky="true">
        <img alt="Loading..." src="../ImagesNew/ajax-loader.gif" style="border: 0;" />
    </telerik:RadAjaxLoadingPanel>
    <div align="left">
        <div id="divListDiagnosis" style="width: 1300px;" align="left">
            <div id="divAdminListDiagnosis" runat="server" align="left">
                <table cellpadding="0px" cellspacing="0px" border="0px">
                    <tr>
                        <td colspan="2" align="left">
                            <br />
                            <b>Diagnosis</b>
                            <br /><br />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" width="80%" align="left">
                            <telerik:RadGrid ID="rgAdminListDiagnosis" GridLines="None" runat="server" AllowAutomaticDeletes="False"
                                AllowFilteringByColumn="True" Width="100%" OnItemDataBound="rgAdminListDiagnosis_ItemDataBound"
                                AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true" PageSize="100" AllowAutomaticUpdates="False"
                                AllowPaging="True" OnNeedDataSource="rgAdminListDiagnosis_NeedDataSource" AutoGenerateColumns="False"
                                OnDeleteCommand="rgAdminListDiagnosis_DeleteCommand" OnInsertCommand="rgAdminListDiagnosis_InsertCommand"
                                OnUpdateCommand="rgAdminListDiagnosis_UpdateCommand">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" CommandItemDisplay="TopAndBottom" DataKeyNames="DiagnosisId"
                                    AllowFilteringByColumn="true" HorizontalAlign="NotSet"  PagerStyle-Position="TopAndBottom" AutoGenerateColumns="False"
                                    EditMode="InPlace">
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="Diagnosis" HeaderText="Diagnosis Name" SortExpression="Diagnosis"
                                            HeaderStyle-Width="200px" UniqueName="Diagnosis" ColumnEditorID="GridTextBoxColumnEditor1"
                                            AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith" ShowFilterIcon="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Description" HeaderText="Description" SortExpression="Description"
                                            HeaderStyle-Width="200px" UniqueName="Description" ColumnEditorID="GridTextBoxColumnEditor1"
                                            AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith" ShowFilterIcon="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="IsDeleted" HeaderText="IsDeleted" SortExpression="IsDeleted"
                                            HeaderStyle-Width="30px" UniqueName="IsDeleted" ColumnEditorID="GridTextBoxColumnEditor1"
                                            Visible="false">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="DeleteName" HeaderText="DeleteName" SortExpression="DeleteName"
                                            HeaderStyle-Width="30px" UniqueName="DeleteName" ColumnEditorID="GridTextBoxColumnEditor1"
                                            Visible="false">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn"
                                            HeaderStyle-Width="50px" HeaderText="Edit">
                                            <ItemStyle CssClass="MyImageButton" />
                                        </telerik:GridEditCommandColumn>
                                        <telerik:GridButtonColumn ConfirmText="Selected diagnosis may be mapped with some symptoms and departments! Are you sure to Delete?"
                                            ConfirmDialogType="Classic" HeaderStyle-Width="50px" ConfirmTitle="Delete/Undelete"
                                            ButtonType="ImageButton" CommandName="Delete" HeaderText="Delete" UniqueName="Delete">
                                        </telerik:GridButtonColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <br />
                                        No records to display.
                                        <br />
                                        <br />
                                    </NoRecordsTemplate>
                                </MasterTableView>
                                <ClientSettings>
                                    <ClientEvents OnRowDblClick="RowDblClick" OnGridCreated="gridCreated" />
                                </ClientSettings>
                            </telerik:RadGrid>
                            <telerik:GridTextBoxColumnEditor ID="GridTextBoxColumnEditor1" runat="server" TextBoxStyle-Width="200px" />
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
