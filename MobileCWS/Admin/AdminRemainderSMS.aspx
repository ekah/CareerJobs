<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminRemainderSMS.aspx.cs" Inherits="Admin_AdminRemainderSMS" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .RadGrid .rgGroupItem input, .RadGrid .rgCommandRow img, .RadGrid .rgHeader input, .RadGrid .rgFilterRow img, .RadGrid .rgFilterRow input, .RadGrid .rgPager img{ width:22px;}
        #ctl00_cphAdminMaster_rgRemainderSMS_ctl00_ctl02_ctl03_FilterTextBox_EmailId{ width:100px;}
        #ctl00_cphAdminMaster_rgRemainderSMS_ctl00_ctl02_ctl03_FilterTextBox_MessageDescription{ width:120px;}
        #ctl00_cphAdminMaster_rgRemainderSMS_ctl00_ctl02_ctl03_FilterTextBox_MobileId{ width:48px;}
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
                                <b>Reminder SMS</b></div>
                            <br />
                           <telerik:RadGrid ID="rgRemainderSMS" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" Width="100%" AutoGenerateColumns="False"
                                OnNeedDataSource="rgRemainderSMS_NeedDataSource" OnItemDataBound="rgRemainderSMS_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" HorizontalAlign="NotSet" PagerStyle-Position="TopAndBottom" AllowSorting="true" CommandItemDisplay="Top"
                                    AutoGenerateColumns="False">
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="AppointmentId" HeaderText="AppId" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="AppointmentId" ItemStyle-Width="70px" HeaderStyle-Width="70px" UniqueName="AppointmentId">
                                        </telerik:GridBoundColumn> 
                                        <telerik:GridBoundColumn DataField="PatientName" HeaderText="Patient Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="PatientName" ItemStyle-Width="70px" HeaderStyle-Width="70px" UniqueName="PatientName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="DoctorName" HeaderText="Doctor Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="DoctorName" ItemStyle-Width="70px" HeaderStyle-Width="70px" UniqueName="DoctorName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="DoctorScheduleName" HeaderText="Doctor Schedule Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="ScheduleName" ItemStyle-Width="70px" HeaderStyle-Width="70px" UniqueName="DoctorScheduleName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="ServiceName" HeaderText="Service Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="ServiceName" ItemStyle-Width="70px" HeaderStyle-Width="70px" UniqueName="ServiceName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="ServiceScheduleName" HeaderText="Service Schedule Name" SortExpression="Hospital" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="ServiceScheduleName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="EmailId">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="MobileId" HeaderText="Mobile Number" SortExpression="MobileId" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="MobileId">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="AppointmentDate" HeaderText="Appointment Date" SortExpression="AppointmentDate" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="AppointmentDate">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="MessageDescription" HeaderText="Message Description" SortExpression="MessageDescription" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="MessageDescription">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="AccountTypeName" HeaderText="Type" SortExpression="AccountTypeName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="AccountTypeName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SmsSent" HeaderText="Sms Sent" SortExpression="SmsSent" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="SmsSent">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="EmailSent" HeaderText="Email Sent" SortExpression="EmailSent" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="EmailSent">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Sent On" HeaderText="Sent On" SortExpression="Sent On" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="SentOn">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Status" HeaderText="SMS Delivered" SortExpression="Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="Status">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Reason" HeaderText="Reason" SortExpression="Sent On" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="70px" ItemStyle-Width="70px" UniqueName="Reason">
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

