<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminSMSIndividual.aspx.cs" Inherits="Admin_AdminSMSIndividual" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .RadGrid .rgGroupItem input, .RadGrid .rgCommandRow img, .RadGrid .rgHeader input, .RadGrid .rgFilterRow img, .RadGrid .rgFilterRow input, .RadGrid .rgPager img{ width:22px;}
        #ctl00_cphAdminMaster_rgSMSIndividual_ctl00_ctl02_ctl03_FilterTextBox_EmailId{ width:100px;}
        #ctl00_cphAdminMaster_rgSMSIndividual_ctl00_ctl02_ctl03_FilterTextBox_MessageDescription{ width:120px;}
        #ctl00_cphAdminMaster_rgSMSIndividual_ctl00_ctl02_ctl03_FilterTextBox_MobileId{ width:48px;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" Runat="Server">
<medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />
    <div id="divAppointmentView" style="width: 1400px;" align="left">
            <div id="divAdminAppointmentView" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="75%" valign="top" align="center">
                            <br />
                            <div align="left">
                                <b>Individual SMS</b></div>
                            <br />
                           <telerik:RadGrid ID="rgSMSIndividual" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" Width="100%" AutoGenerateColumns="False"
                                OnNeedDataSource="rgSMSIndividual_NeedDataSource" OnItemDataBound="rgSMSIndividual_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" HorizontalAlign="NotSet" PagerStyle-Position="TopAndBottom" AllowSorting="true" CommandItemDisplay="Top"
                                    AutoGenerateColumns="False">
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="Name" HeaderText="Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Name" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="Name" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn> 
                                        <telerik:GridBoundColumn DataField="Email" HeaderText="Email" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Email" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="Email" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Mobile" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="Mobile" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Account" HeaderText="Account" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Account" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="Account" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Action" HeaderText="Action" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Action" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="Action" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SMSMessage" HeaderText="Message" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="SMSMessage" ItemStyle-Width="100px" HeaderStyle-Width="100px" UniqueName="SMSMessage" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CreatedOn" HeaderText="CreatedOn" SortExpression="CreatedOn" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="100px" ItemStyle-Width="100px" UniqueName="CreatedOn" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Status" HeaderText="Delivered" SortExpression="Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="100px" ItemStyle-Width="100px" UniqueName="Status" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Reason" HeaderText="Reason" SortExpression="Reason" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="100px" ItemStyle-Width="100px" UniqueName="Reason" FilterControlWidth="100px">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <br />
                                        There is no Appointments to view!
                                        <br />
                                        <br />
                                    </NoRecordsTemplate>
                                </MasterTableView>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
</asp:Content>

