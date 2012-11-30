<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/SecondaryMasterPage.master" CodeFile="Job_SendToFriend.aspx.cs" Inherits="Job_Job_SendToFriend" %>

<%@ Register Src="JobSearchRight.ascx" TagName="JobSearchRight" TagPrefix="uc1" %>
<%@ Register Src="HotOppsRight.ascx" TagName="HotOppsRight" TagPrefix="uc2" %>
<%@ Register Src="NewsLetterRight.ascx" TagName="NewsLetterRight" TagPrefix="uc3" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
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
    .editorControl{ border: 1px solid #D2D2D2; height: 170px; padding: 6px; width: 428px;}
</style>
<link href="../StylesNew/Jobs/job_style.css" rel="stylesheet" type="text/css" />
    <div class="innercontent">
        <div class="innerlftpanel">
            <div class="innercntbg_top">
                <img src="../ImagesNew/jobs/innerpage_cntbgtop.gif" alt="" /></div>
            <div class="innercntbg_mid">
                <div class="headingbg">
                    <h3>
                        send to friend</h3>
                </div>
                <div class="jobdescinnercntbg_mid_cnt">
                    <div id="divMain" runat="server">
                        <table width="607" border="0" cellspacing="0" cellpadding="0" style="margin: 0px auto;">
                            <tr>
                                <td width="175">
                                    Your Name:
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="txtYourName" CssClass="applytxt" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="applymessage" runat="server" ControlToValidate="txtYourName"
                                        ValidationGroup="val2" ErrorMessage="Enter your name"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Your Email:
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="txtYourEmail" CssClass="applytxt" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvtxtEmail" CssClass="applymessage" runat="server" ControlToValidate="txtYourEmail"
                                        ValidationGroup="val2" ErrorMessage="Enter your email"  Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revtxtEmail" CssClass="applymessage" runat="server" ErrorMessage="Invalid your e-mail address"
                                        ValidationGroup="val2" ControlToValidate="txtYourEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Friend Name:
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFriendsName" CssClass="applytxt" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="applymessage" runat="server" ControlToValidate="txtFriendsName"
                                        ValidationGroup="val2" ErrorMessage="Enter your friend name"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Friend Email:
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFriendEmail" CssClass="applytxt" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="applymessage" runat="server" ControlToValidate="txtFriendEmail"
                                        ValidationGroup="val2" ErrorMessage="Enter your friend email" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="applymessage" runat="server" ErrorMessage="Invalid friend e-mail address"
                                        ValidationGroup="val2" ControlToValidate="txtFriendEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Comments:
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <telerik:RadEditor ID="txtComments" AutoResizeHeight="false" CssClass="editorControl" Enabled="false" EditModes="Design" Height="170px" OnClientLoad="OnClientLoad" runat="server" Style="width: 428px;">
                                        <Tools>
                                            <telerik:EditorToolGroup>
                                            </telerik:EditorToolGroup>
                                        </Tools>
                                    </telerik:RadEditor>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="sumbit" runat="server" Text="Send Now" Width="82px" OnClick="btnSend_Click"
                                        ValidationGroup="val2" />
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="margin-left:5px;" OnClick="btnCancel_Click" />
                                </td>
                                <td>&nbsp;
                                    
                                </td>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="text-align: center; padding: 10px 0px; color: #006600; font-weight: bold;">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
                        <asp:LinkButton ID="lnkBack" runat="server" Text="Back" OnClick="lnkBack_Click" CausesValidation="false"></asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="innercntbg_btm">
                <img src="../ImagesNew/jobs/innerpage_cntbgbottom.gif" alt="" /></div>
        </div>
        <div class="innerrgtpanel">
            <div class="innercareersearch">
                <div class="innercareersearch_top">
                    <img src="../ImagesNew/jobs/innercareersearch_bgtop.gif" alt="" /></div>
                <div class="innercareersearch_mid">
                    <uc1:JobSearchRight ID="Jobsearchright1" runat="server"></uc1:JobSearchRight>
                </div>
                <div class="innercareersearch_btm">
                    <img src="../ImagesNew/jobs/innercareersearch_bgbtm.gif" alt="" /></div>
            </div>
            <div class="innerrecentopportunities">
                <div class="innerrecentopportunities_top">
                    <img src="../ImagesNew/jobs/innerrecentopportunities_top.gif" alt="" /></div>
                <div class="innerrecentopportunities_mid">
                    <uc2:HotOppsRight ID="HotOppsHomeright1" runat="server"></uc2:HotOppsRight>
                </div>
                <div class="innerrecentopportunities_btm">
                    <img src="../ImagesNew/jobs/innerrecentopportunities_btm.gif" alt="" /></div>
            </div>
            <div class="innernewslettersignup">
                <div class="innernewslettersignup_top">
                    <img src="../ImagesNew/jobs/innercareersearch_bgtop.gif" alt="" /></div>
                <div class="innernewslettersignup_mid">
                    <uc3:NewsLetterRight ID="newsletterright1" runat="server"></uc3:NewsLetterRight>
                </div>
                <div class="innernewslettersignup_btm">
                    <img src="../ImagesNew/jobs/innercareersearch_bgbtm.gif" alt="" /></div>
            </div>
        </div>
    </div>
    <div class="clear"></div>
</asp:Content>
