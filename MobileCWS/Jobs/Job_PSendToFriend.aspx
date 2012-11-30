<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.master" CodeFile="Job_PSendToFriend.aspx.cs" Inherits="Jobs_Job_PSendToFriend" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function OnClientLoad(editor, args) {
        var style = editor.get_contentArea().style;
        style.backgroundImage = "none";
        style.backgroundColor = "White";
        style.color = "black";
    }
</script>
 <style type="text/css">

/*.applytxt{background:#ffffff!important;}
.jobdescinnercntbg_mid_cnt{width:100%; padding:0;}*/
.editorControl{ border: 1px solid #D2D2D2; height: 170px; padding: 6px; width: 428px;}

</style>
    <div id="container">
        <!--content start -->
        <div class="content">
            <div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">
                                <h3>
                                    send to friend</h3>
                                <div class="jobdescinnercntbg_mid_cnt">
                                    <div id="divMain" runat="server">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin: 0px auto;">
                                            <tr>
                                                <td width="100">
                                                    <div class="FormText">
                                                        Your Name:</div>
                                                </td>
                                                <td>
                                                </td>
                                                <td width="700">
                                                    <asp:TextBox ID="txtYourName" CssClass="applytxt" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="applymessage"
                                                        runat="server" ControlToValidate="txtYourName" ValidationGroup="val2" ErrorMessage="Enter your name"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="FormText">
                                                        Your Email:</div>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtYourEmail" CssClass="applytxt" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvtxtEmail" CssClass="applymessage" runat="server"
                                                        ControlToValidate="txtYourEmail" ValidationGroup="val2" ErrorMessage="Enter your email"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="revtxtEmail" CssClass="applymessage" runat="server"
                                                        ErrorMessage="Invalid your e-mail address" ValidationGroup="val2" ControlToValidate="txtYourEmail"
                                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="FormText">
                                                        Friend Name:</div>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtFriendsName" CssClass="applytxt" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="applymessage"
                                                        runat="server" ControlToValidate="txtFriendsName" ValidationGroup="val2" ErrorMessage="Enter your friend name"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="FormText">
                                                        Friend Email:</div>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtFriendEmail" CssClass="applytxt" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="applymessage"
                                                        runat="server" ControlToValidate="txtFriendEmail" ValidationGroup="val2" ErrorMessage="Enter your friend email"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="applymessage"
                                                        runat="server" ErrorMessage="Invalid friend e-mail address" ValidationGroup="val2"
                                                        ControlToValidate="txtFriendEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="FormText">
                                                        Comments:</div>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <telerik:RadEditor ID="txtComments" AutoResizeHeight="false" CssClass="editorControl"
                                                        Enabled="false" EditModes="Design" Height="170px" OnClientLoad="OnClientLoad"
                                                        runat="server" Style="width: 428px;">
                                                        <Tools>
                                                            <telerik:EditorToolGroup>
                                                            </telerik:EditorToolGroup>
                                                        </Tools>
                                                    </telerik:RadEditor>
                                                    <%--<telerik:RadEditor ID="txtComments" OnClientLoad="OnClientLoad" runat="server" Style="width:100%;">                                                                   
                                                        </telerik:RadEditor>--%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="sumbit" runat="server" Text="Send Now" Width="82px" OnClick="btnSend_Click"
                                                        ValidationGroup="val2" />
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Style="margin-left: 5px;"
                                                        OnClick="btnCancel_Click" />
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div id="divmsg" runat="server" style="text-align: center; color: #006600;
                                        font-weight: bold;">
                                        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
                                    </div>
                                    <div id="divback" runat="server" style="text-align: center; color: #006600;
                                        font-weight: bold;">
                                        <asp:LinkButton ID="lnkBack" runat="server" Text="Back" OnClick="lnkBack_Click" CausesValidation="false"></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>