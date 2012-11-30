<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master"
    AutoEventWireup="true" CodeFile="AdminHospitalView.aspx.cs" Inherits="Admin_AdminHospitalView"
    MaintainScrollPositionOnPostback="true" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu1" runat="server" />

    <div align="left">
        <div id="divHospitalView" style="width: 1300px;" align="left">
            <div id="divAdminHospitalView" runat="server">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="80%" valign="top" align="center">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td colspan="2">
                                        <br />
                                        <b>Hospital</b>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <br />
                                        <b>Select Hospital: </b>
                                        <telerik:RadComboBox ID="ddlHospitalView" AllowCustomText="true" runat="server" Width="450px"
                                            Height="250px"  EmptyMessage="Search for hospital..." Filter="Contains">
                                        </telerik:RadComboBox>
                                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search"
                                            Height="25px" Width="100px" /><br />
                                        <asp:RequiredFieldValidator ID="rfvHospitalView" runat="server" CssClass="error"
                                            ControlToValidate="ddlHospitalView" ErrorMessage="Please select Hospital to Search"
                                            Display="Dynamic" InitialValue="0"></asp:RequiredFieldValidator>
                                    </td>
                                    <td valign="top">
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr id="trHospitalAdminDetail" runat="server">
                                    <td valign="top">
                                        <br />
                                        <br />
                                        <b>Hospital Administrator Details:</b><br />
                                        Name: <b>
                                            <%= _HospitalAdminName %>
                                        </b>
                                        <br />
                                        Email: <b>
                                            <%= _HospitalAdminEmail %>
                                        </b>
                                        <br />
                                        Mobile: <b>
                                            <%= _HospitalAdminMobile %>
                                        </b>
                                        <br /><br />
                                        <asp:HyperLink ID="btnAdminAccess" runat="server" Text="Click here to login as Administrator" NavigateUrl="" Target="_blank"></asp:HyperLink>
                                    </td>
                                    <td valign="top">
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr id="trHospitalAdminView" runat="server">
                                    <td colspan="2">
                                        <br />
                                        <br />
                                        <b>Hospital Doctor / Servcie Details:</b><br />
                                        <telerik:RadGrid ID="rgAdminHospitalView" GridLines="None" runat="server" AllowAutomaticDeletes="False"
                                            EnableAjaxSkinRendering="true" AllowAutomaticInserts="False" PagerStyle-AlwaysVisible="true"
                                            PageSize="100" AllowAutomaticUpdates="False" AllowPaging="True" AutoGenerateColumns="False"
                                            Width="1041px" OnNeedDataSource="rgAdminHospitalView_NeedDataSource" OnItemDataBound="rgAdminHospitalView_ItemDataBound"
                                            OnItemCommand="rgAdminHospitalView_ActivateCommand">
                                            <PagerStyle Mode="NextPrevAndNumeric" />
                                            <GroupingSettings CaseSensitive="false" />
                                            <MasterTableView Width="100%" DataKeyNames="DoctorServcieId"  PagerStyle-Position="TopAndBottom" HorizontalAlign="NotSet"
                                                AutoGenerateColumns="False">
                                                <GroupByExpressions>
                                                    <telerik:GridGroupByExpression>
                                                        <SelectFields>
                                                            <telerik:GridGroupByField FieldName="Type" HeaderText="" />
                                                        </SelectFields>
                                                        <GroupByFields>
                                                            <telerik:GridGroupByField FieldName="Type" SortOrder="Ascending" />
                                                        </GroupByFields>
                                                    </telerik:GridGroupByExpression>
                                                </GroupByExpressions>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="DoctorServcieName" HeaderText="Doctor / ServiceName"
                                                        SortExpression="DoctorServcieName" HeaderStyle-Width="400px" UniqueName="DoctorServcieName">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="DepartmentName" HeaderText="Department" SortExpression="DepartmentName"
                                                        HeaderStyle-Width="400px" UniqueName="DepartmentName">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Gender" HeaderText="Gender" SortExpression="Gender"
                                                        HeaderStyle-Width="200px" UniqueName="Gender">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Degrees" HeaderText="Degrees" SortExpression="Degrees"
                                                        HeaderStyle-Width="200px" UniqueName="Degrees">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridTemplateColumn DataField="PhotoName" HeaderText="Photo" UniqueName="Thumbnail"
                                                        HeaderStyle-Width="50px">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblImageName" Text='<%# Eval("PhotoName") %>' Visible="false" />
                                                            <asp:Image ID="imgThumbnail" runat="server" Height="50px" Width="50px" />
                                                        </ItemTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </telerik:GridTemplateColumn>
                                                    <telerik:GridBoundColumn DataField="PreferedName" HeaderText="Prefered Name" SortExpression="PreferedName"
                                                        HeaderStyle-Width="200px" UniqueName="PreferedName">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Email" HeaderText="Email-Id" SortExpression="Email"
                                                        HeaderStyle-Width="300px" UniqueName="Email">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile Number" SortExpression="Mobile"
                                                        HeaderStyle-Width="250px" UniqueName="Mobile">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="LoginId" Visible="false" HeaderText="" SortExpression="LoginId"
                                                        HeaderStyle-Width="250px" UniqueName="LoginId">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridTemplateColumn HeaderText="Auto Login" ItemStyle-HorizontalAlign="Center"
                                                        ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="50px">
                                                        <ItemTemplate>
                                                            <asp:HyperLink ID="hlnkLogin" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("Mobile").ToString().Trim() + "&type=5&orgid=0&accountid=" + Eval("LoginId") %>'
                                                                Text="Login" runat="server" Target="_blank" ToolTip="Click here to auto login" />
                                                        </ItemTemplate>
                                                    </telerik:GridTemplateColumn>
                                                </Columns>
                                                <NoRecordsTemplate>
                                                    <br />
                                                    There is no Accounts in this Hospital!
                                                    <br />
                                                    <br />
                                                </NoRecordsTemplate>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                    </td>
                                    <td valign="top" width="20%" align="left">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
