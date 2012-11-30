<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" MaintainScrollPositionOnPostback="true"
         AutoEventWireup="true" CodeFile="AdminProfilePageDetails.aspx.cs" Inherits="Admin_AdminProfilePageDetails" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
    .RadGrid .rgFilterBox{ width:58px;}
    #ctl00_cphAdminMaster_rgAdminLogIn_ctl00_ctl02_ctl03_FilterTextBox_EmailId{ width:130px;}
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
<medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />
    <div align="left">
        <div id="divLoginGrid" style="width: 1250px;" align="left">
            <div id="divAdminLoginDetailView" runat="server">
                <br />
                <div>
                <div style="float:left; width:120px;">
                <b>Account Status</b></div>
                <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel" runat="server" MinDisplayTime="1000"
                    Skin="" IsSticky="true">
                    <img alt="Loading..." src="../ImagesNew/ajax-loader.gif" style="border: 0;" />
                </telerik:RadAjaxLoadingPanel>
                </div>
                <br />
                <br />
                <table border="0" cellpadding="0" cellspacing="0" width="1100px">
                    <tr>
                        <td valign="top" width="80%">

                            
                            <telerik:RadGrid ID="rgAdminLogIn" runat="server" ShowStatusBar="true" PagerStyle-Position="TopAndBottom" AllowFilteringByColumn="true" 
                                AutoGenerateColumns="False" PageSize="100" AllowSorting="True" AllowMultiRowSelection="False"
                                AllowPaging="True" OnItemCommand="rgAdminLogIn_ItemCommand" OnItemDataBound="rgAdminLogIn_ItemDataBound" OnNeedDataSource="rgAdminLogIn_NeedDataSource" GridLines="None">
                                <GroupingSettings CaseSensitive="false" />
                                <PagerStyle Mode="NextPrevAndNumeric"></PagerStyle>
                                <ExportSettings HideStructureColumns="true" />
                                <MasterTableView HierarchyLoadMode="ServerOnDemand" DataKeyNames="LoginId" AllowFilteringByColumn="true" CommandItemDisplay="Top"
                                    AllowMultiColumnSorting="True" GridLines="None">
                                    <CommandItemSettings ShowAddNewRecordButton="false" ShowExportToExcelButton="true" />
                                    
                                    <Columns>
                                    <telerik:GridBoundColumn SortExpression="LoginId" UniqueName="LoginId" DataField="LoginId" HeaderText="LoginId"
                                                            ItemStyle-Width="70px" Visible="false" HeaderStyle-Width="70px">
                                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn SortExpression="UserName" ItemStyle-Width="70px" HeaderStyle-Width="70px" DataField="UserName" HeaderText="User Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="MobileId" DataField="MobileId" HeaderText="Mobile Number" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="EmailId" DataField="EmailId" HeaderText="EmailId"  AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="DateTime" UniqueName="DateTime" DataField="DateTime" HeaderText="DateTime" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Organization" DataField="Organization" HeaderText="Organization" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Doctor" DataField="Doctor" HeaderText="Doctor" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Service" DataField="Service" HeaderText="Service" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Patient" DataField="Patient" HeaderText="Patient" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="SetUpProfile" DataField="SetUpProfile" HeaderText="SetUp Profile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="SetUpScheduleDoctor" DataField="SetUpScheduleDoctor" HeaderText="SetUp Schedule Doctor" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="SetUpScheduleService" DataField="SetUpScheduleService" HeaderText="SetUp Schedule Service" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Verified" DataField="Verified" HeaderText="Verified" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                            HeaderStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="70px">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="lnkDelete" runat="server" OnCommand="lnkDelete_OnDelete" CommandArgument='<%# Eval("LoginId") %>'
                                                    OnClientClick="Are you sure to delete this account?" ToolTip="click here to delete this account"
                                                    ImageUrl="~/ImagesNew/delete-icon.png" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <span style="color: red; font-size: 8pt;"><i>No Login account available.</i></span>
                                    </NoRecordsTemplate>
                                </MasterTableView>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>