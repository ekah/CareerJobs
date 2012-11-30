<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master"
    AutoEventWireup="true" CodeFile="AdminAppointmentView.aspx.cs" Inherits="Admin_AdminAppointmentView"
    MaintainScrollPositionOnPostback="true" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />

    <div align="left">
        <div id="divAppointmentView" style="width: 1300px;" align="left">
            <div id="divAdminAppointmentView" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="75%" valign="top">
                            <br />
                            <div align="left">
                                <b>Appointment</b></div>
                            <br />
                            <telerik:RadGrid ID="rgAdminAppointmentView" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" AutoGenerateColumns="False"
                                Width="100%" OnNeedDataSource="rgAdminAppointmentView_NeedDataSource" OnItemDataBound="rgAdminAppointmentView_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" DataKeyNames="AppointmentId" HorizontalAlign="NotSet" PagerStyle-Position="TopAndBottom" AllowSorting="true" CommandItemDisplay="Top"
                                    AutoGenerateColumns="False">
                                    <Columns>
                                        <%--<telerik:GridBoundColumn DataField="PatientName" HeaderText="Patient Name" SortExpression="PatientName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="250px" UniqueName="PatientName">
                                        </telerik:GridBoundColumn>--%>
                                        <telerik:GridTemplateColumn UniqueName="PatientName" HeaderText="Patient Name" DataField="PatientName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" HeaderStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:HyperLink ID="hlnkPatientName" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("EmailId") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                    runat="server" Target="_blank" ToolTip="Click here to go patient profile"><%# Eval("PatientName")%></asp:HyperLink>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridBoundColumn DataField="AppointmentType" HeaderText="Appointment Type" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="AppointmentType" HeaderStyle-Width="200px" UniqueName="AppointmentType">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="Mobile Number" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="EmailId" HeaderStyle-Width="200px" UniqueName="EmailId">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn DataField="OrganizationName" HeaderText="Organization Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="OrganizationName" HeaderStyle-Width="300px" UniqueName="OrganizationName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="DoctorServicename" HeaderText="Doctor / Service Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="DoctorServicename" HeaderStyle-Width="300px" UniqueName="DoctorServicename">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="AppointmentDate" HeaderText="Appointment Date" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="AppointmentDate" HeaderStyle-Width="200px" UniqueName="AppointmentDate">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="AppointmentTime" HeaderText="Appointment Time" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="AppointmentTime" HeaderStyle-Width="200px" UniqueName="AppointmentTime">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Status" HeaderText="Appointment Status" SortExpression="Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="200px" UniqueName="Status">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CreatedOn" HeaderText="CreatedOn" SortExpression="Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="200px" UniqueName="CreatedOn">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText="Schedule"  UniqueName="ScheduleAddress" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="300px" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith">
                                            <ItemTemplate>                                                
                                                <asp:Label ID="lblScheduleAddress" runat="server" Text='<%#Eval("ScheduleName") %>' ToolTip='<%#Eval("ScheduleAddress") %>'></asp:Label>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
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
    </div>
</asp:Content>
