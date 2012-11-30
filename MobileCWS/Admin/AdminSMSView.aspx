<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" MaintainScrollPositionOnPostback="true"
    AutoEventWireup="true" CodeFile="AdminSMSView.aspx.cs" Inherits="Admin_AdminSMSView" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu1" runat="server" />

    <div align="left">
        <div id="divLoginGrid" style="width: 1200px;" align="left">
            <div id="divAdminLoginDetailView" runat="server">
                <br />
                <asp:Label ID="lblSMS" runat="server" Font-Bold="true" Font-Size="Larger" Text="Group SMS"></asp:Label>
                <br /><br />
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td align="right">
                            
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" width="80%">                            
                            <asp:UpdatePanel ID="upAdminSMS" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                            <telerik:RadGrid ID="rgAdminSMS" runat="server" Width="100%" ShowStatusBar="true" AllowFilteringByColumn="true" EnableAjaxSkinRendering="true"
                                AutoGenerateColumns="False" PageSize="100" AllowSorting="True" AllowMultiRowSelection="False"
                                AllowPaging="True" OnDetailTableDataBind="rgAdminSMS_DetailTableDataBind" OnNeedDataSource="rgAdminSMS_NeedDataSource" OnItemDataBound="rgAdminSMS_ItemDataBound"
                                OnPreRender="rgAdminSMS_PreRender" GridLines="None">
                                <PagerStyle Mode="NextPrevAndNumeric"></PagerStyle>
                                <MasterTableView HierarchyLoadMode="ServerBind" Width="100%" DataKeyNames="LoginId" AllowFilteringByColumn="true" CommandItemDisplay="Top"
                                    AllowMultiColumnSorting="True" PagerStyle-Position="TopAndBottom" ShowHeader="true" GridLines="None" >
                                    <DetailTables>
                                        <telerik:GridTableView HierarchyLoadMode="ServerBind" DataKeyNames="LoginId,AccountTypeId" AllowFilteringByColumn="false"
                                            Name="AccountType" Width="100%" ShowHeader="true" GridLines="None" BorderStyle="None" HierarchyDefaultExpanded="true">
                                            <DetailTables>
                                                <telerik:GridTableView HierarchyLoadMode="ServerBind" Name="Account" Width="100%" AllowFilteringByColumn="false"
                                                    ShowHeader="true" GridLines="None" BorderStyle="None" >
                                                    <Columns>
                                                        <telerik:GridBoundColumn SortExpression="Action" DataField="Action" HeaderText="Action Performed"
                                                            ItemStyle-Width="300px">
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn SortExpression="SMSMessage" DataField="SMSMessage" HeaderText="Message"
                                                            ItemStyle-Width="300px">
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn SortExpression="Reason" DataField="Reason" HeaderText="Reason"
                                                            ItemStyle-Width="300px">
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn SortExpression="CreatedOn" DataField="CreatedOn" HeaderText="CreatedOn"
                                                            ItemStyle-Width="300px">
                                                        </telerik:GridBoundColumn>
                                                    </Columns>
                                                    <NoRecordsTemplate>
                                                        <span style="color: red; font-size: 8pt;"><i>There is no event regarding SMS!</i></span>
                                                    </NoRecordsTemplate>
                                                </telerik:GridTableView>
                                            </DetailTables>
                                            <Columns>
                                                <telerik:GridBoundColumn SortExpression="AccountTypeName" DataField="AccountTypeName"
                                                    HeaderText="Account Name" ItemStyle-Width="300px">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn SortExpression="SmsCount" DataField="SmsCount" HeaderText="SMS Count"
                                                    ItemStyle-Width="300px">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </telerik:GridTableView>
                                    </DetailTables>
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="EmailId" DataField="EmailId" HeaderText="Email Id" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="MobileId" DataField="MobileId" HeaderText="Mobile Number" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="SmsCount" DataField="SmsCount" HeaderText="SMS Count" AutoPostBackOnFilter="true" CurrentFilterFunction="StartsWith"
                                            ItemStyle-Font-Bold="true">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <NoRecordsTemplate>
                                        <span style="color: red; font-size: 8pt;"><i>No Login account available.</i></span>
                                    </NoRecordsTemplate>
                                </MasterTableView>
                            </telerik:RadGrid>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
