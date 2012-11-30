<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminNoProfile.aspx.cs" Inherits="Admin_AdminDeletedDoctor" %>


<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #ctl00_cphAdminMaster_rgAdminNoProfileView_ctl00_ctl02_ctl03_FilterTextBox_TemplateColumn{ display:none;}
        #ctl00_cphAdminMaster_rgAdminNoProfileView_ctl00_ctl02_ctl03_Filter_TemplateColumn{ display:none;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" Runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />
    <div align="left">
        <div id="divAppointmentView" style="width: 1300px;" align="left">
            <div id="divAdminAppointmentView" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" width="82%">
                    <tr>
                        <td width="75%" valign="top">
                            <br />
                            <div align="left">
                                <b>Account without Profiles</b></div>
                            <br />
                            <telerik:RadGrid ID="rgAdminNoProfileView" GridLines="None" runat="server" AllowAutomaticDeletes="False"  AllowFilteringByColumn="true"
                                EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" AutoGenerateColumns="False"
                                Width="100%" OnNeedDataSource="rgAdminNoProfileView_NeedDataSource" OnItemDataBound="rgAdminNoProfileView_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric" />
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView Width="100%" DataKeyNames="LoginId" HorizontalAlign="NotSet"  PagerStyle-Position="TopAndBottom" AllowSorting="true" CommandItemDisplay="Top"
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
                                        <telerik:GridBoundColumn DataField="FirstName" HeaderText="First Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="FirstName" HeaderStyle-Width="200px" UniqueName="FirstName">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn DataField="LastName" HeaderText="Last Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="LastName" HeaderStyle-Width="200px" UniqueName="LastName">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn DataField="CountryName" HeaderText="Country Name" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="CountryName" HeaderStyle-Width="300px" UniqueName="CountryName">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="MobileId" HeaderText="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="Mobile" HeaderStyle-Width="300px" UniqueName="Mobile">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="EmailId" HeaderText="Email" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            SortExpression="EmailId" HeaderStyle-Width="200px" UniqueName="EmailId">
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

