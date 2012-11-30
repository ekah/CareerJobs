<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminOrganizationNoDoctor.aspx.cs" Inherits="Admin_AdminOrganizationNoDoctor" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #ctl00_cphAdminMaster_rgAdminOrgNoDoctor_ctl00_ctl02_ctl03_FilterTextBox_TemplateColumn{ display:none;}
        #ctl00_cphAdminMaster_rgAdminOrgNoDoctor_ctl00_ctl02_ctl03_Filter_TemplateColumn{ display:none;}
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
                            <div align="left">
                                <b>Organization without Doctors / Services</b></div>
                            <br />
                            <telerik:RadGrid ID="rgAdminOrgNoDoctor" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" AutoGenerateColumns="False"
                                Width="100%" OnNeedDataSource="rgAdminOrgNoDoctor_NeedDataSource" OnItemDataBound="rgAdminOrgNoDoctor_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" DataKeyNames="OrganizationId"  PagerStyle-Position="TopAndBottom" HorizontalAlign="NotSet" AllowSorting="true" CommandItemDisplay="Top"
                                    AutoGenerateColumns="False">
                                    <Columns>
                                        <%--<telerik:GridBoundColumn DataField="PatientName" HeaderText="Patient Name" SortExpression="PatientName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            HeaderStyle-Width="250px" UniqueName="PatientName">
                                        </telerik:GridBoundColumn>--%>
                                        <%--<telerik:GridTemplateColumn UniqueName="DoctorName" HeaderText="Doctor Name" DataField="PatientName" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" HeaderStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:HyperLink ID="hlnkPatientName" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("EmailId") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                    runat="server" Target="_blank" ToolTip="Click here to go patient profile"><%# Eval("PatientName")%></asp:HyperLink>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>--%>
                                        <telerik:GridBoundColumn DataField="OrganizationName" HeaderText="Organization Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="OrganizationName" HeaderStyle-Width="400px" UniqueName="OrganizationName">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn DataField="Address" HeaderText="Address" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Address" HeaderStyle-Width="200px" UniqueName="Address">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Country" HeaderText="Country" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Country" HeaderStyle-Width="200px" UniqueName="Country">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="State" HeaderText="State" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="State" HeaderStyle-Width="200px" UniqueName="State">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="City" HeaderText="City" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="City" HeaderStyle-Width="200px" UniqueName="City">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Mobile" HeaderStyle-Width="300px" UniqueName="Mobile">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="Email" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="EmailId" HeaderStyle-Width="200px" UniqueName="EmailId">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                            HeaderStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="70px">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="lnkDelete" runat="server" OnCommand="lnkDelete_OnDelete" CommandArgument='<%# Eval("OrganizationId") %>'
                                                    OnClientClick="Are you sure to delete this account?" ToolTip="click here to delete this account"
                                                    ImageUrl="~/ImagesNew/delete-icon.png" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <br />
                                        There are no Doctors to view!
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

