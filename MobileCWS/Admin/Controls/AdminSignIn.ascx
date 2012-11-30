<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminSignIn.ascx.cs" Inherits="Admin_Controls_AdminSignIn" %>

<div>
    <br /><br /><br /><br /><br />
    <h2>Administration Login</h2>
    <div id="signin" runat="server">
        Username:&nbsp;&nbsp;
        <asp:TextBox ID="txtSignIn" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvSignIn" runat="server" ValidationGroup="SignIn"
            ControlToValidate="txtSignIn"  ForeColor="Red" ErrorMessage="<br />Please enter your username"
            Display="Dynamic" />
    </div>
    <br />
    <div>
        Password:&nbsp;
        <asp:TextBox ID="txtPassword" CssClass="txtBoxStyl" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ValidationGroup="SignIn"
            ControlToValidate="txtPassword"  ForeColor="Red" ErrorMessage="<br />Please enter your password"
            Display="Dynamic" />
    </div>
    <br />
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="lbtnSignIn" CssClass="homeRegbutton" runat="server" OnClick="lbtnSignIn_Click"
            ToolTip="Click here to sign in" ValidationGroup="SignIn" Text="Sign In Here" />
    </div>
    <asp:Label ID="lblError" runat="server" Text="<br/>Invalid Credentials" ForeColor="Red" Visible="false"></asp:Label>
</div>
