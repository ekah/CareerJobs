<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsLetterHome.ascx.cs" Inherits="Job_NewsLetterHome" %>
<div class="homenews"  style="width:280px; margin:0 auto;">
   <h2>NewsLetter Signup</h2>

<p style="padding:0;margin:0;">Name</p>
    <asp:TextBox ID="txtname" runat="server" style="width:260px; height:36px; line-height:36px; padding:0 5px;  background:url(ImagesNew/jobs/news_txtbg.jpg) no-repeat left top;border:none;" ></asp:TextBox >
    <asp:RequiredFieldValidator ID="reqname" runat="server" ControlToValidate="txtname"
        ErrorMessage="Enter Name">*</asp:RequiredFieldValidator>
<p  style="padding:0;margin:0;">Email</p>
    <asp:TextBox ID="txtEmail" runat="server" style="width:260px; height:36px; line-height:36px; padding:0 5px; background:url(ImagesNew/jobs/news_txtbg.jpg) no-repeat left top;border:none;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="reqemail" runat="server" ControlToValidate="txtEmail"
        ErrorMessage="Enter Email">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revtxtEmail" runat="server" ErrorMessage="Invalid your e-mail address"
        ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

<div style="text-align:right;width:262px;padding: 0;margin:10px 0 0 0;">
    <asp:Button ID="btnSubscribe" runat="server" Text="Subscribe" OnClick="btnSubscribe_Click" />
</div>
</div>
