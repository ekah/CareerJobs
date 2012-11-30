<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master"
    AutoEventWireup="true" CodeFile="AdminHospitalActivation.aspx.cs" Inherits="Admin_AdminHospitalActivation"
    MaintainScrollPositionOnPostback="true" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />

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
            <telerik:AjaxSetting AjaxControlID="rgAdminHospitalList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rgAdminHospitalList" LoadingPanelID="RadAjaxLoadingPanel1" />
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
        <div id="divHospitalList" style="width: 1400px;" align="left">
            <div id="divAdminHospitalList" runat="server" align="left">
                <table cellpadding="0px" cellspacing="0px" border="0px">
                    <tr>
                        <td colspan="2" align="left">
                            <br />
                            <b>Hospital Account Activation</b>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" width="80%" align="left">
                            <telerik:RadGrid ID="rgAdminHospitalList" GridLines="None" runat="server" AllowAutomaticDeletes="False"
                                EnableAjaxSkinRendering="true" Width="100%" OnItemDataBound="rgAdminHospitalList_ItemDataBound"
                                AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true" PageSize="100" AllowAutomaticUpdates="False"
                                AllowPaging="True" OnPreRender="OnPreRender" OnDetailTableDataBind="rgAdminHospitalList_DetailTableDataBind" OnNeedDataSource="rgAdminHospitalList_NeedDataSource" AutoGenerateColumns="False">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" DataKeyNames="OrganizationId,Mobile" PagerStyle-Position="TopAndBottom" HierarchyLoadMode="ServerBind" HierarchyDefaultExpanded="true" HorizontalAlign="NotSet"
                                    AutoGenerateColumns="False">
                                    <DetailTables>
                                        <telerik:GridTableView HierarchyLoadMode="ServerBind" HierarchyDefaultExpanded="true" Name="ExistingHospital" DataKeyNames="OrganizationId" AllowFilteringByColumn="false" 
                                            ShowHeader="true" PagerStyle-AlwaysVisible="false" GridLines="None" BorderStyle="None">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="OrganizationName" ItemStyle-ForeColor="LightSlateGray" HeaderText="Hospital Name"
                                                    SortExpression="OrganizationName" HeaderStyle-Width="200px" UniqueName="OrganizationName">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Address" HeaderText="Address" ItemStyle-ForeColor="LightSlateGray" SortExpression="Address"
                                                    HeaderStyle-Width="350px" UniqueName="Address">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Phone" HeaderText="Phone" ItemStyle-ForeColor="LightSlateGray" SortExpression="Phone"
                                                    HeaderStyle-Width="100px" UniqueName="Phone">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile" ItemStyle-ForeColor="LightSlateGray" SortExpression="Mobile"
                                                    HeaderStyle-Width="50px" UniqueName="Mobile">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="EmailId" HeaderText="EmailId" ItemStyle-ForeColor="LightSlateGray" SortExpression="EmailId"
                                                    HeaderStyle-Width="70px" UniqueName="EmailId">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="InvalidNo" HeaderText="Invalid No." ItemStyle-ForeColor="LightSlateGray" SortExpression="InvalidNo"
                                                    HeaderStyle-Width="70px" UniqueName="InvalidNo" Visible="false">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="InCharge" HeaderText="InCharge" ItemStyle-ForeColor="LightSlateGray"
                                                    SortExpression="InCharge" HeaderStyle-Width="50px" UniqueName="InCharge">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="ReferedBy" HeaderText="Referred By" ItemStyle-ForeColor="LightSlateGray" SortExpression="ReferedBy"
                                                    HeaderStyle-Width="150px" UniqueName="ReferedBy">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="CreatedOn" HeaderText="Created On" ItemStyle-ForeColor="LightSlateGray" SortExpression="CreatedOn"
                                                    HeaderStyle-Width="100px" UniqueName="CreatedOn">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn UniqueName="MobileId" HeaderText="Modify" ItemStyle-ForeColor="Blue" DataField="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                                    ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" HeaderStyle-Width="150px">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="hlnkPatientName" ForeColor="LightSlateGray" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("Mobile") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                            runat="server" Target="_blank" ToolTip="Click here to go patient profile">Modify</asp:HyperLink>
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridBoundColumn DataField="Status" ItemStyle-ForeColor="LightSlateGray" HeaderText="Status" SortExpression="Status"
                                                    HeaderStyle-Width="100px" UniqueName="Status">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                            <NoRecordsTemplate>
                                        <br />
                                        <span style="color: red; font-size: 8pt;"><i>No branches under this hospital.</i></span>
                                        <br />
                                        <br />
                                    </NoRecordsTemplate>
                                        </telerik:GridTableView>
                                    </DetailTables>
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="OrganizationName" HeaderText="Hospital Name"
                                            SortExpression="OrganizationName" HeaderStyle-Width="200px" UniqueName="OrganizationName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Address" HeaderText="Address" SortExpression="Address"
                                            HeaderStyle-Width="350px" UniqueName="Address">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Phone" HeaderText="Phone" SortExpression="Phone"
                                            HeaderStyle-Width="100px" UniqueName="Phone">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile"
                                            HeaderStyle-Width="50px" UniqueName="Mobile">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId"
                                            HeaderStyle-Width="70px" UniqueName="EmailId">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="InCharge" HeaderText="InCharge" SortExpression="InCharge"
                                            HeaderStyle-Width="50px" UniqueName="InCharge">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="ReferedBy" HeaderText="Referred By" SortExpression="ReferedBy"
                                            HeaderStyle-Width="150px" UniqueName="ReferedBy">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CreatedOn" HeaderText="Created On" SortExpression="CreatedOn"
                                            HeaderStyle-Width="100px" UniqueName="CreatedOn">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn UniqueName="MobileId" HeaderText="Modify" DataField="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" HeaderStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:HyperLink ID="hlnkPatientName" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("Mobile") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                    runat="server" Target="_blank" ToolTip="Click here to go patient profile">Modify</asp:HyperLink>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn HeaderText="Activate" ItemStyle-HorizontalAlign="Center"
                                                            HeaderStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="70px">
                                                            <ItemTemplate>
                                                                <asp:ImageButton ID="lnkActivate" runat="server" OnCommand="lnkActivate_OnActivate" CommandArgument='<%# Eval("OrganizationId") %>'
                                                                    OnClientClick="Are you sure to delete this account?" ToolTip="click here to Activate"
                                                                    ImageUrl="~/Imagesnew/tickIcon.png" />
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                        <%--<telerik:GridButtonColumn ConfirmText="Are you sure! You want to Activate this Hospital account?"
                                            ConfirmDialogType="Classic" HeaderStyle-Width="50px" ConfirmTitle="Activate"
                                            ButtonType="ImageButton" CommandName="Activate" HeaderText="Activate" UniqueName="Activate">
                                        </telerik:GridButtonColumn>--%>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <br />
                                        <span style="color: red; font-size: 8pt;"><i>No branches under this hospital.</i></span>
                                        <br />
                                        <br />
                                    </NoRecordsTemplate>
                                </MasterTableView>
                            </telerik:RadGrid>
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
