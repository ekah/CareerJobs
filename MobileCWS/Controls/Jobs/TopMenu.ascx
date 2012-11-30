<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopMenu.ascx.cs" Inherits="Controls_Jobs_TopMenu" %>
<div id="mainMenu">
    <ul class="nav">
        <asp:PlaceHolder ID="phHome" runat="server" />
        <li><asp:LinkButton ID="lbtnFeatures" runat="server" href="../Features.aspx">Features</asp:LinkButton></li>
        <li><asp:LinkButton ID="lbtnFaq" runat="server" href="../FAQ.aspx">FAQ</asp:LinkButton></li>
        <li>
            <asp:PlaceHolder ID="phDiscussion" runat="server" />
        </li>
    </ul>
</div>
<div id="setUpMenu">
    <div class="setUp">
        <ul>
            <li class="med1">
                <div id="lbtnLogin" runat="server" style="display: inline;">
                    <a class='inline' href="#SignIn">Login</a>
                </div>
                <div id="lbtnHospitalLogin" runat="server" style="display: inline;">
                    <a class='inline' href="<%= _siteUrl %>/Default.aspx?Login=<%= _loginhospital %>">Login</a>
                </div>
                <asp:LinkButton ID="lbtnSignOut" runat="server" OnClick="lbtnSignOut_Click" CausesValidation="false">Sign Out</asp:LinkButton>
            </li>
            <li id="lbtnRegister" runat="server" class="med1 HomeReg">
            <div id="divlbtnRegister" runat="server">
                <asp:LinkButton ID="lbtnRegister1" runat="server" class='inline1' href="#SignUp">Register</asp:LinkButton>
            </div>
            <div id="divlbtnHospitalRegister" runat="server">
                <a class='inline' href="<%= _siteUrl %>/Default.aspx?Register=<%= _registerhospital %>">Register</a>
            </div>
                </li>
        </ul>
    </div>
</div>