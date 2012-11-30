<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" MaintainScrollPositionOnPostback="true"
    AutoEventWireup="true" CodeFile="AdminLoginView.aspx.cs" Inherits="Admin_AdminLoginView" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
    #ctl00_cphAdminMaster_rgAdminLogIn_ctl00_ctl02_ctl03_FilterTextBox_EmailId{ width:183px;}
    #ctl00_cphAdminMaster_rgAdminLogIn_ctl00_ctl02_ctl03_FilterTextBox_MobileId{ width:100px;}
    #ctl00_cphAdminMaster_rgAdminLogIn_ctl00_ctl02_ctl03_FilterTextBox_Password{ width:75px;}
</style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />
    <script type="text/javascript">
    function onRequestStart(sender, args) {
        if (args.get_eventTarget().indexOf("lbtnExportToExcel") >= 0)
    args.set_enableAjax(false);
}
</script>

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="rgAdminLogIn">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rgAdminLogIn" LoadingPanelID="RadAjaxLoadingPanel" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    

    <div align="left">
        <div id="divLoginGrid" style="width: 1250px;" align="left">
            <div id="divAdminLoginDetailView" runat="server">
                <br />
                <div style="height:25px;">
                <div style="float:left; width:55px;">
                <b>Login</b></div>
                <asp:Button ID="lbtnExportToExcel" runat="server" OnClick="lbtnExportToExcel_Click" OnClientClick="onRequestStart" Text="Export To Excel" style="float:right;" />
                <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel" runat="server" MinDisplayTime="1000"
                    Skin="" IsSticky="true">
                    <img alt="Loading..." src="../ImagesNew/ajax-loader.gif" style="border: 0;" />
                </telerik:RadAjaxLoadingPanel>
                </div>
                <br />
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td valign="top" width="80%">

                            <%--<asp:UpdatePanel ID="upAdminLogIn" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>--%>
                            <telerik:RadGrid ID="rgAdminLogIn" runat="server" ShowStatusBar="true" PagerStyle-Position="TopAndBottom" AllowFilteringByColumn="true" 
                                AutoGenerateColumns="False" PageSize="100" AllowSorting="True" AllowMultiRowSelection="False"
                                AllowPaging="True" OnDetailTableDataBind="rgAdminLogIn_DetailTableDataBind" OnNeedDataSource="rgAdminLogIn_NeedDataSource"
                                GridLines="None" OnItemDataBound="rgAdminLogIn_ItemDataBound">
                                <PagerStyle Mode="NextPrevAndNumeric"></PagerStyle>
                                <MasterTableView HierarchyLoadMode="ServerOnDemand" DataKeyNames="LoginId" AllowFilteringByColumn="true" CommandItemDisplay="Top"
                                    AllowMultiColumnSorting="True" ShowHeader="true" GridLines="None">
                                    <DetailTables>
                                        <telerik:GridTableView HierarchyLoadMode="ServerOnDemand" DataKeyNames="LoginId,AccountTypeId" AllowFilteringByColumn="false"
                                            Name="AccountType" Width="100%" ShowHeader="false" GridLines="None" BorderStyle="None" HierarchyDefaultExpanded="true" >
                                            <DetailTables>
                                                <telerik:GridTableView HierarchyLoadMode="ServerOnDemand" Name="Account" DataKeyNames="Id" AllowFilteringByColumn="false" 
                                                    ShowHeader="true" GridLines="None" BorderStyle="None">
                                                    <Columns>
                                                    <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                                            HeaderStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="70px">
                                                            <ItemTemplate>
                                                                <asp:ImageButton ID="lnkDelete" runat="server" OnCommand="lnkDelete_OnDelete" CommandArgument='<%# Eval("Id") + "," + Eval("Type") %>'
                                                                    OnClientClick="Are you sure to delete this account?" ToolTip="click here to delete this account"
                                                                    ImageUrl="~/ImagesNew/delete-icon.png" />
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridBoundColumn SortExpression="CreatedOn" DataField="CreatedOn" HeaderText="CreatedOn"
                                                            ItemStyle-Width="70px">
                                                        </telerik:GridBoundColumn> 
                                                        <telerik:GridBoundColumn SortExpression="IsActivated" UniqueName="IsActivated" DataField="IsActivated" HeaderText="IsActivated"
                                                            ItemStyle-Width="70px" Visible="false">
                                                        </telerik:GridBoundColumn>                                                      
                                                        <telerik:GridBoundColumn SortExpression="Name" DataField="Name" HeaderText="Name"
                                                            ItemStyle-Width="100px">
                                                        </telerik:GridBoundColumn>                                                        
                                                        <telerik:GridTemplateColumn UniqueName="OrganizationName" HeaderText="Hospital Name"
                                                            DataField="OrganizationName" ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Top" 
                                                            HeaderStyle-Width="150px">
                                                            <ItemTemplate>
                                                                <asp:HyperLink ID="hlnkOrganizationName" NavigateUrl='<%# "http://" + Eval("SubDomain") + "." + GetRootDomain() %>'
                                                                    runat="server" Target="_blank" ToolTip="Click here to view Landing Page"><%# Eval("OrganizationName") %></asp:HyperLink>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>  
                                                        <telerik:GridTemplateColumn HeaderText="Admin Activation" ItemStyle-HorizontalAlign="Center"
                                                            UniqueName="Activation" HeaderStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle"
                                                            HeaderStyle-Width="70px">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkActivation" runat="server" Text='<%#Eval("IsActivated") %>'
                                                                    OnCommand="lnkActivation_OnUpdate" CommandArgument='<%# Eval("Id") + "," + Eval("Type") %>' />
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn HeaderText="Auto Login" ItemStyle-HorizontalAlign="Center" UniqueName="AutoLogin"
                                                            ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="50px">
                                                            <ItemTemplate>
                                                                <asp:HyperLink ID="hlnkLogin" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("EmailId") + "&type=" + Eval("Type") + "&orgid=" + Eval("OrganizationId") + "&accountid=" + Eval("Id") %>'
                                                                    Text="Login" runat="server" Target="_blank" ToolTip="Click here to auto login" />
                                                                    <asp:Label ID="lblActivate" runat="server" Text='<%#Eval("IsActivated") %>' Visible="false"></asp:Label>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>                                                        
                                                        <telerik:GridBoundColumn SortExpression="SubDomain" DataField="SubDomain" HeaderText="SubDomain" Visible="false">
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn SortExpression="OrganizationId" DataField="OrganizationId" HeaderText="OrganizationId" Visible="false">
                                                        </telerik:GridBoundColumn>
                                                    </Columns>
                                                    <NoRecordsTemplate>
                                                        <span style="color: red; font-size: 8pt;"><i>There is no account in this account type!</i></span>
                                                    </NoRecordsTemplate>
                                                </telerik:GridTableView>
                                            </DetailTables>
                                            <Columns>
                                                <telerik:GridBoundColumn SortExpression="AccountTypeName" DataField="AccountTypeName" ItemStyle-Width="150px">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </telerik:GridTableView>
                                    </DetailTables>
                                    <Columns>
                                    <telerik:GridBoundColumn SortExpression="IsActivated" UniqueName="IsActivated" DataField="IsActivated" HeaderText="IsActivated"
                                                            ItemStyle-Width="70px" Visible="false" HeaderStyle-Width="70px">
                                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn SortExpression="EmailId" ItemStyle-Width="70px" HeaderStyle-Width="70px" DataField="EmailId" HeaderText="Email Id" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="MobileId" DataField="MobileId" HeaderText="Mobile Number" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Password" DataField="Password" HeaderText="Password"  AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText="Activation Code" ItemStyle-HorizontalAlign="Left" ItemStyle-Font-Bold="true" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="50px">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblActivationCode" runat="server" Text='<%#Eval("Token") %>' Visible="false"></asp:Label>
                                                                <asp:Label ID="lblActivationCodeDisp" runat="server" Text="" Visible="true"></asp:Label>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                        <telerik:GridBoundColumn SortExpression="ActivationStatus" UniqueName="ActivationStatus" DataField="ActivationStatus" HeaderText="Main Account Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="Profile" DataField="Profile" HeaderText="Profile Status" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="CreatedOn" DataField="CreatedOn" HeaderText="CreatedOn" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn HeaderText="Auto Login" ItemStyle-HorizontalAlign="Center"
                                            ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="50px">
                                            <ItemTemplate>
                                                <asp:HyperLink ID="hlnkLogin" NavigateUrl='<%# GetUrl() + "Default.aspx?user=" + Eval("MobileId").ToString().Trim() + "&type=5&orgid=0&accountid=" + Eval("LoginId") %>'
                                                    Text="Login" runat="server" Target="_blank" ToolTip="Click here to auto login" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <span style="color: red; font-size: 8pt;"><i>No Login account available.</i></span>
                                    </NoRecordsTemplate>
                                </MasterTableView>
                            </telerik:RadGrid>
                            <%--</ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
