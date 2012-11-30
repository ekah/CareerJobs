<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminPatientSearch.aspx.cs" Inherits="Admin_AdminPatientSearch" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
    #ctl00_cphAdminMaster_rgAdminPatientSearchView_ctl00_ctl02_ctl03_FilterTextBox_SearchCount { width:35px!important;}
    #ctl00_cphAdminMaster_rgAdminPatientSearchView_ctl00_ctl02_ctl03_FilterTextBox_CreatedOn{ width:50px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" Runat="Server">
<medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />

<div align="left">
        <div id="divAppointmentView" style="width: 1300px;" align="left">
            <div id="divAdminAppointmentView" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="75%" valign="top">
                            <br />
                                <b>Patient Search</b>
                            <br /><br />
                            <telerik:RadGrid ID="rgAdminPatientSearchView" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" AutoGenerateColumns="False"
                                Width="1041px" OnNeedDataSource="rgAdminPatientSearchView_NeedDataSource" OnItemDataBound="rgAdminPatientSearchView_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" DataKeyNames="SearchId" PagerStyle-Position="TopAndBottom" HorizontalAlign="NotSet" AllowSorting="true" CommandItemDisplay="Top"
                                    AutoGenerateColumns="False">
                                    <Columns>
                                        <telerik:GridTemplateColumn UniqueName="PatientName" HeaderText="Patient Name" DataField="PatientName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" HeaderStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:HyperLink ID="hlnkPatientName" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("EmailId") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                    runat="server" Target="_blank" ToolTip="Click here to go patient profile"><%# Eval("PatientName")%></asp:HyperLink>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn> 
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="Mobile Number" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="EmailId" HeaderStyle-Width="200px" UniqueName="EmailId">
                                        </telerik:GridBoundColumn> 
                                        <telerik:GridBoundColumn DataField="CountryName" HeaderText="Country Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="CountryName" HeaderStyle-Width="200px" UniqueName="CountryName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="StateName" HeaderText="State Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="StateName" HeaderStyle-Width="200px" UniqueName="StateName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CityName" HeaderText="City Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="CityName" HeaderStyle-Width="200px" UniqueName="CityName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Department" HeaderText="Speciality / Symptom" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Department" HeaderStyle-Width="600px" UniqueName="Department">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Hospital" HeaderText="Search by Doctor / Hospital" SortExpression="Hospital" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="200px" UniqueName="Hospital">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="SearchCount" HeaderText="Search Result" SortExpression="SearchCount" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="75px" UniqueName="SearchCount">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CreatedOn" HeaderText="Search On" SortExpression="CreatedOn" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="100px" UniqueName="CreatedOn">
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
    </div>
</asp:Content>

