<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsLetterRight.ascx.cs" Inherits="Job_NewsLetterRight" %>
<div class="homenews">
   <h2>NewsLetter Signup</h2>
   <asp:ValidationSummary ID="valnews" runat="server" ShowMessageBox="false" ShowSummary="false"
            DisplayMode="List" ValidationGroup="valnews" />
<p style="padding:0;margin:0;">Name</p>
    <asp:TextBox ID="txtname" runat="server" style="width:230px;padding:6px 5px;margin:2px 0 0 0; background:url(../ImagesNew/jobs/news_txtbg.jpg) no-repeat left top;border:none;" ></asp:TextBox >
    <asp:RequiredFieldValidator ID="reqname" runat="server" ControlToValidate="txtname" ValidationGroup="valnews"
        ErrorMessage="Enter Name">*</asp:RequiredFieldValidator>
<div style="height:36px;"></div>
<p  style="padding:0;margin:0;">Email</p>
    <asp:TextBox ID="txtEmail" runat="server" style="width:230px;padding:6px 5px;margin:2px 0 0 0; background:url(../ImagesNew/jobs/news_txtbg.jpg) no-repeat left top;border:none;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="reqemail" runat="server" ControlToValidate="txtEmail" ValidationGroup="valnews"
        ErrorMessage="Enter Email">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revtxtEmail" runat="server" ErrorMessage="Invalid your e-mail address" ValidationGroup="valnews"
        ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

<div style="text-align:left;width:262px;padding: 0;margin:10px 0 0 0;">
    <asp:Button ID="btnSubscribe" runat="server" ValidationGroup="valnews" Text="Subscribe" OnClick="btnSubscribe_Click" />
</div>
</div>