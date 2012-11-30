<%@ Control Language="C#" AutoEventWireup="true" Inherits="Control_TopMenu" CodeFile="~/Controls/TopMenu.ascx.cs" %>
<div id="mainMenu">
    <ul class="nav">
        <asp:PlaceHolder ID="phHome" runat="server" />
        <li>
            <asp:LinkButton ID="lbtnFeatures" runat="server" href="Features.aspx">Features</asp:LinkButton></li>
        <li>
            <asp:LinkButton ID="lbtnFaq" runat="server" href="FAQ.aspx">FAQ</asp:LinkButton></li>
        <li>
            <asp:PlaceHolder ID="phDiscussion" runat="server" Visible="false" />
        </li>
    </ul>
</div>
<div id="setUpMenu">
    <div class="setUp" align="center">
        <ul>
            <li class="med1">
                <div id="lbtnLogin" runat="server" style="display: inline;">
                    <a href="<%= _siteUrl %>Default.aspx">Login</a>
                </div>
                <div id="lbtnHospitalLogin" runat="server" style="display: inline;">
                    <a href="<%= _siteUrl %>Default.aspx">Login</a>
                </div>
                <asp:LinkButton ID="lbtnSignOut" runat="server" OnClick="lbtnSignOut_Click" CausesValidation="false">Sign Out</asp:LinkButton>
            </li>
            <li id="lbtnRegister" runat="server" class="med1 HomeReg">
                <div id="divlbtnRegister" runat="server">
                    <asp:LinkButton ID="lbtnRegister1" runat="server">Register</asp:LinkButton>
                </div>
                <div id="divlbtnHospitalRegister" runat="server">
                    <a href="<%= _siteUrl %>Default.aspx">Register</a>
                </div>
            </li>
        </ul>
    </div>
</div>
