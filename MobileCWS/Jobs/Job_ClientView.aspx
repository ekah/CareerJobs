<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Job_ClientView.aspx.cs" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    Inherits="Jobs_ClientView" %>

<asp:Content ID="ct_addclient" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .fullWidthPageTopbg .fullWidthPageContent h3{ line-height:38px;}
    </style>
    <asp:UpdatePanel ID="upFacility" runat="server">
        <ContentTemplate>
            <div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">
                                <div class="jobs_content">
                                    <div class="innerpanel">
                                        <div class="adminpanel">
                                            <div class="adminpage_cntbgmid">
                                                <div class="adminheadingbg">
                                                    <h3>
                                                        Client View</h3>
                                                    <div class="adminlogoutpanel">
                                                        <ul>
                                                            <li>
                                                                <asp:LinkButton ID="lnkManageAdmin" runat="server" CausesValidation="false" Text="Job Manage Admin"
                                                                    OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                            <li>
                                                                <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="gridpanelpadd">
                                                    <div class="gridpanel">
                                                        <telerik:RadGrid AutoGenerateColumns="false" ID="rgClientView"
                                                            AllowFilteringByColumn="True" AllowSorting="True" PageSize="15" Skin="Hay" Width="880px"
                                                            AllowPaging="True" runat="server"  OnNeedDataSource="rgClientView_NeedDataSource" GridLines="None" EnableLinqExpressions="false">
                                                            <MasterTableView AutoGenerateColumns="false" AllowFilteringByColumn="true">
                                                                <Columns>
                                                                    <telerik:GridBoundColumn SortExpression="ClientId" UniqueName="IsActivated" DataField="ClientId" HeaderText="ClientId"
                                                                        ItemStyle-Width="70px">
                                                                    </telerik:GridBoundColumn>
                                                                    <telerik:GridBoundColumn SortExpression="Client" FilterControlWidth="450px" UniqueName="Client" DataField="Client" HeaderText="Client">
                                                                    </telerik:GridBoundColumn>
                                                                    <telerik:GridBoundColumn SortExpression="SubDomain" UniqueName="SubDomain" DataField="SubDomain" HeaderText="SubDomain">
                                                                    </telerik:GridBoundColumn>
                                                                </Columns>
                                                            </MasterTableView>
                                                        </telerik:RadGrid>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
