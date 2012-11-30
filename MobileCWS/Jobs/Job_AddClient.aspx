<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Job_AddClient.aspx.cs" MasterPageFile="~/Jobs/AdminMasterPage.Master" Inherits="Jobs_Job_AddClient" %>

<asp:Content ID="ct_addclient" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function setFormatMedicalService() {
        var inp = document.getElementById('ctl00_cphMaster_ucRegisterOrganization_txtOrganizationName_text');
        var x = inp.value;
        inp.value = x.toLowerCase();

        var inp = document.getElementById('ctl00_cphMaster_ucRegisterOrganization_txtOrganizationName_text');
        inp.onblur = function (evt) {
            setFormatMedicalService();
        };
    }
    </script>
    
<style type="text/css">
        .ButtonHelp { display: inline-block; float: left; padding: 10px 0 0 0; }
    .ButtonHelp a.ButtonLeft { font-weight: bold; background: url("ImagesNew/blue_Btn_Lft.png") repeat scroll left top transparent; color: #FFFFFF; display: inline-block; float: left; font-size: 13px; line-height: 34px; padding: 0 7px 0 17px; text-decoration: none !important; }
    .thumbnail { position: relative; z-index: 0; float: left; text-decoration: none !important; }
    .thumbnail:hover { background-color: transparent; z-index: 50; }
    .thumbnail span { position: absolute; background-color: #f00; padding: 5px; border: 1px dashed #000; visibility: hidden; left: -1000px; color: #fff; text-decoration: none !important; text-align: left; font-size: 12px; font-weight: normal; }
    .thumbnail span img { /*CSS for enlarged image*/ border-width: 0; padding: 2px; display: block; }
    .thumbnail:hover span { /*CSS for enlarged image on hover*/ visibility: visible; top: 10px; left: 30px; /*position where enlarged image should offset horizontally */ }
    *:first-child + html .thumbnail:hover span { top: 10px; }  
    .InsertScreen						 { font-size:15px; font-family:Arial, Helvetica, sans-serif; color:#333333; background: url(ImagesNew/inser-screen-bg.jpg) right top no-repeat #fff;}
    .InsertScreen h2					 { padding:0; margin:0 0 0 135px; font-size:29px; line-height:75px;}
    .InsertScreen .Strip				 { background:#004b85; height:55px; line-height:60px; color:#fff; text-align:right; padding:0 15px 0 0; font-family:BebasNeueRegular; font-size:39px; }
    .InsertScreen  p					 { font-family:Georgia, "Times New Roman", Times, serif; font-size:20px; color:#003399; padding:20px 0 20px 30px; margin:0;line-height:35px;}
    .InsertScreen .Right				 { position:absolute; top:7px; left:25px; }
    .InsertScreen a.BluBtnNew,
    .InsertScreen a.BluBtnNew:link,
    .InsertScreen a.BluBtnNew:active,
    .InsertScreen a.BluBtnNew:visited,
    .InsertScreen a.BluBtnNew:hover		 {background: url("ImagesNew/blue_Btn_Lft.png") no-repeat left top;clear: both;display: inline-block;font-family: Arial,Helvetica,sans-serif;font-size: 13px;font-weight: bold;    line-height: 34px;padding: 0 0 0 20px; color:#fff; text-decoration:none; bottom:20px; right:30px; position:absolute;}
    .InsertScreen a.BluBtnNew span 	     {background: url("ImagesNew/blue_Btn_Rgt.png") no-repeat right top;    clear: both;    display: block;    line-height: 34px;    padding: 0 20px 0 0;}
    p.txt                                { float:left; width:585px; }
    #ctl00_cphMaster_ucRegisterOrganization_ctl00_cphMaster_ucRegisterOrganization_ddlStatePanel{ display: inline!important;}
    #ctl00_cphMaster_ucRegisterOrganization_ctl00_cphMaster_ucRegisterOrganization_ddlCityPanel{ display: inline!important;}
</style>
<link href="StylesNew/colorbox-insertscreen.css" rel="stylesheet" type="text/css" />
<script src="ScriptsNew/jquery.colorbox.js"></script>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
        <div id="divRegisterOrganization" runat="server">
            <div class="registerPageContent">
                <asp:HiddenField ID="hfMobile" runat="server" />
                <asp:HiddenField ID="hfEmail" runat="server" />
                <table cellpadding="4" cellspacing="0" border="0" width="800" class="normal">
                    <tr>
                        <td valign="top" width="240px">
                            <div class="FormText">
                                Medical Service Name</div>
                        </td>
                        <td style="width: 650px">
                            <telerik:RadTextBox ID="txtOrganizationName" ClientEvents-OnBlur="setFormatMedicalService"
                                Style="text-transform: capitalize;" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                                Width="385px" Skin="" />
                            <asp:RequiredFieldValidator ID="rfvOrganization" runat="server" ControlToValidate="txtOrganizationName"
                                CssClass="error" ErrorMessage="Please enter your medical service name" Display="Dynamic" />
                            <asp:CustomValidator ID="cvOrganization" runat="server" ControlToValidate="txtOrganizationName"
                                        CssClass="error" ErrorMessage="Medical Service/Branch name already exists, please try a different one"
                                        Display="Dynamic" />
                            <span style="font-size: 11px; display: block;">Eg: VeeCare Hospital, Kumaran Hospital,
                                Esthetic Smile Dental Clinic, New Scan Center, etc.</span>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText">
                                Preferred Sub Domain</div>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="upSubDomain" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    http://&nbsp;<telerik:RadTextBox Skin="" ID="txtSubDomain"
                                        Style="text-transform: capitalize;" CssClass="txtBoxStyl" runat="server"
                                        MaxLength="100" Width="150px">
                                    </telerik:RadTextBox>&nbsp;.<asp:Label ID="lblSubDomain" runat="server" Text="" />
                                    <asp:RequiredFieldValidator ID="rfvSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Please enter your preferred sub domain" Display="Dynamic" />
                                    <asp:RegularExpressionValidator ID="revSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Please enter your sub domain in correct format(without space & special characters like @,#...)"
                                        Display="Dynamic" ValidationExpression="^[a-zA-Z0-9]+$" />
                                    <asp:CustomValidator ID="cvSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Entered Sub Domain already in use. Please try a different one."
                                        Display="Dynamic" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                Address</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtAddress" style="text-transform:capitalize;" ClientEvents-OnBlur="setFormatAddress" CssClass="txtBoxStyl"
                                runat="server" Height="120px" TextMode="MultiLine" Width="385px" MaxLength="1000"
                                Skin="" />
                            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress"
                                CssClass="error" ErrorMessage="Please enter your address" Display="Dynamic" />
                        </td>
                    </tr>--%>
                    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <tr id="trCountry" runat="server">
                                <td valign="top">
                                    <div id="divCountry" runat="server" class="FormText">
                                        Country</div>
                                </td>
                                <td>
                                    <asp:UpdatePanel ID="upCountry" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="ddlCountry" runat="server" CssClass="txtBoxStyl" Height="25px"
                                                Width="392px" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="ddlCountry"
                                                CssClass="error" ErrorMessage="Please select your country" InitialValue="0" Display="Dynamic" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr id="trState" runat="server">
                                <td valign="top">
                                    <div id="divState" runat="server" class="FormText">
                                        State</div>
                                </td>
                                <td>
                                    <asp:UpdatePanel ID="upState" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="ddlState" runat="server" CssClass="txtBoxStyl" Height="25px"
                                                Width="392px" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="ddlState"
                                                CssClass="error" ErrorMessage="Please select your state" InitialValue="0" Display="Dynamic" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr id="trCity" runat="server">
                                <td valign="top">
                                    <div id="divCity" runat="server" class="FormText">
                                        City</div>
                                </td>
                                <td>
                                    <asp:UpdatePanel ID="upCity" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="ddlCity" runat="server" CssClass="txtBoxStyl" Height="25px"
                                                Width="392px">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="ddlCity"
                                                CssClass="error" ErrorMessage="Please select your city" InitialValue="0" Display="Dynamic" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </ContentTemplate>
                    </asp:UpdatePanel>--%>
                    <%--<tr>
                <td valign="top">
                    <div class="FormText">
                        Address Line1</div>
                </td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine1" CssClass="txtBoxStyl" runat="server" Width="385px"
                        MaxLength="500" Skin="" />
                    <asp:RequiredFieldValidator ID="rfvAddressLine1" runat="server" ControlToValidate="txtAddressLine1"
                        CssClass="error" ErrorMessage="Please enter your address" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <div class="FormText">
                        Address Line2</div>
                </td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine2" CssClass="txtBoxStyl" runat="server" Width="385px"
                        MaxLength="500" Skin="" />
                </td>
            </tr>--%>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                Postal Code</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtPostalCode" CssClass="txtBoxStyl" runat="server" Width="385px"
                                MaxLength="20" Skin="" />
                            <asp:RequiredFieldValidator ID="rfvPostalCode" runat="server" ControlToValidate="txtPostalCode"
                                CssClass="error" ErrorMessage="Please enter your postal code" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText">
                                Branch Name
                            </div>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <telerik:RadTextBox ID="txtBranchName" ClientEvents-OnBlur="setFormatBranchName"
                                        Style="text-transform: capitalize;" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                                        Text="Main Branch" Width="385px" Skin="" />
                                    <asp:RequiredFieldValidator ID="rfvBranchName" runat="server" ControlToValidate="txtBranchName"
                                        CssClass="error" ErrorMessage="Please enter your branch name" Display="Dynamic" />
                                    <asp:CustomValidator ID="cvOrganization" runat="server" ControlToValidate="txtBranchName"
                                        CssClass="error" ErrorMessage="Medical Service/Branch name already exists, please try a different one"
                                        Display="Dynamic" />
                                    <span style="font-size: 11px; display: block;">If this medical service have multiple
                                        branch operation, please enter the branch name otherwise use "Main Branch".</span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText">
                                Time Zone
                            </div>
                        </td>
                        <td>
                            <div>
                                <asp:DropDownList ID="ddlTimeZone" runat="server" CssClass="txtBoxStyl" Height="25px"
                                    Width="392px">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvTimeZone" runat="server" ControlToValidate="ddlTimeZone"
                                    CssClass="error" ErrorMessage="Please select your time zone" InitialValue="0"
                                    Display="Dynamic" />
                            </div>
                        </td>
                    </tr>--%>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                Phone to be Published</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtPhone" CssClass="txtBoxStyl" runat="server" Width="385px"
                                MaxLength="18" Skin="" />
                            <asp:RegularExpressionValidator runat="server" ID="revPhone" ControlToValidate="txtPhone"
                                CssClass="error" ErrorMessage="Please do not use any special characters, spaces and alphabets"
                                ValidationExpression="^\d+$" Style="z-index: 100" Display="Dynamic"></asp:RegularExpressionValidator>
                            <asp:RegularExpressionValidator ID="revPhone1" runat="server" ControlToValidate="txtPhone"
                                CssClass="error" ErrorMessage="Please enter minimum 6 digits phone number" Display="Dynamic"
                                ValidationExpression="^\d{6,18}$" />
                        </td>
                    </tr>--%>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                Mobile Number</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtMobile" CssClass="txtBoxStyl" runat="server" MaxLength="20"
                                ReadOnly="true" Skin="" Width="385px" />
                        </td>
                    </tr>--%>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                E-mail</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtEmail" style="text-transform:lowercase;" CssClass="txtBoxStyl" runat="server" MaxLength="250"
                                ReadOnly="true" Skin="" Width="385px" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText">
                                Person In Charge
                            </div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtInCharge" ClientEvents-OnBlur="setFormatIncharge"
                                Style="text-transform: capitalize;" CssClass="txtBoxStyl" runat="server" Width="385px"
                                MaxLength="20" Skin="" />
                            <asp:RequiredFieldValidator ID="rfvInCharge" runat="server" ControlToValidate="txtInCharge"
                                CssClass="error" ErrorMessage="Please enter person name who is responsible for this medical service"
                                Display="Dynamic" />
                            <asp:RegularExpressionValidator ID="revInCharge" runat="server" CssClass="error"
                                Display="Dynamic" ValidationExpression="[A-Za-z ]*" ControlToValidate="txtInCharge"
                                ErrorMessage="Please enter person name without any special characters and numerics"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText" style="float: left; width: 160px;">
                                Permit External Reference</div>
                            <a class="thumbnail" href="#thumb">
                                <img src="ImagesNew/help.png" border="0" /><span style="width: 393px;"> External Reference
                                    is allowing Doctors and Medical Services from within your hospital to find Doctors
                                    and Services outside your hospital and book appointments. In case of Major Hospitals
                                    which have all services under one roof it would not be desired that patients be
                                    referred to another facility. Please leave the check box ticked if you do not have
                                    all facilities and you would like to refer patients to other hospitals. Our system
                                    logs these references for your review. </span></a>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkExternalReference" runat="server" Checked="true" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div class="FormText" style="float: left; width: 160px;">
                                Car Parking Management</div>
                            <a class="thumbnail" href="#thumb">
                                <img src="ImagesNew/help.png" border="0" /><span style="width: 232px;">If Car Parking
                                    is provided, please check this box</span></a>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkCarParking" runat="server" Checked="false" />
                        </td>
                    </tr>--%>
                    <%--<tr>
                <td valign="top">
                    <div class="FormText" style="line-height:18px;">
                        Number of days prior to book appointment</div>
                </td>
                <td>
                    <telerik:RadTextBox ID="txtPriorDays" runat="server" Width="25px" MaxLength="3" CssClass="txtBoxStyl"
                        Text="7" Skin="" />&nbsp; Day(s)
                    <asp:RequiredFieldValidator ID="rfvPriorDays" runat="server" ControlToValidate="txtPriorDays"
                        CssClass="error" ErrorMessage="Please enter number of days" Display="Dynamic" />
                    <asp:RangeValidator ID="rvPriorDays" runat="server" ControlToValidate="txtPriorDays"
                        CssClass="error" ErrorMessage="Please enter valid days" Display="None" MinimumValue="1"
                        MaximumValue="30" Type="Integer" />
                    <span style="font-size: 11px; display: block;">Please alter this upto 30 days to suit
                        your commitment.</span>
                </td>
            </tr>--%>
                    <%--<tr>
                <td valign="top">
                    <div class="FormText">
                        Approval System</div>
                </td>
                <td>
                    <asp:CheckBox ID="chkApprovalSystem" Style="float: left;" runat="server" />
                    <p class="txt">
                        Check the above option if you would prefer your schedules to be booked upon approval
                        only.<br />
                        This would require an user at your end to approve incoming appointment requests.</p>
                </td>
            </tr>
                    <tr id="trConditionPage" runat="server">
                        <td valign="top">
                            Conditions Page
                        </td>
                        <td>
                            <asp:CheckBox ID="chkConditionsPage" runat="server" Checked="true" />
                            <br />
                            Select this to enable the condition page for patients.
                        </td>
                    </tr>--%>
                    <%--<tr>
                        <td valign="top">
                            <div class="FormText">
                                Preferred Sub Domain</div>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="upSubDomain" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    http://&nbsp;<telerik:RadTextBox Skin="" ID="txtSubDomain" ClientEvents-OnBlur="setFormatSubDomain"
                                        Style="text-transform: capitalize;" CssClass="txtBoxStyl" runat="server"
                                        MaxLength="100" Width="150px">
                                    </telerik:RadTextBox>&nbsp;.<asp:Label ID="lblSubDomain" runat="server" Text="" />
                                    <asp:RequiredFieldValidator ID="rfvSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Please enter your preferred sub domain" Display="Dynamic" />
                                    <asp:RegularExpressionValidator ID="revSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Please enter your sub domain in correct format(without space & special characters like @,#...)"
                                        Display="Dynamic" ValidationExpression="^[a-zA-Z0-9]+$" />
                                    <asp:CustomValidator ID="cvSubDomain" runat="server" ControlToValidate="txtSubDomain"
                                        CssClass="error" ErrorMessage="Entered Sub Domain already in use. Please try a different one."
                                        Display="Dynamic" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>--%>
                    <%--<tr id="Tr1" runat="server">
                        <td valign="top">
                            <div class="FormText">
                                Referred By</div>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtReferedBy" ClientEvents-OnBlur="setFormatReferredBy" style="text-transform:capitalize;" 
                                CssClass="txtBoxStyl" runat="server" MaxLength="50" Skin="" Width="385px" />
                            <asp:RequiredFieldValidator ID="rfvReferedBy" runat="server" ControlToValidate="txtReferedBy"
                                CssClass="error" ErrorMessage="Please enter your reference" Display="Dynamic" />
                        </td>
                    </tr>--%>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbtnRegister" CssClass="BluBtnNew" runat="server" OnClick="lbtnRegister_Click"
                                ToolTip="Click here to add client"><span>Add Client</span></asp:LinkButton>&nbsp;
                            <asp:LinkButton ID="lbtnCancel" CssClass="BluBtnNew" runat="server" OnClick="lbtnCancel_Click"
                                ToolTip="Click here to cancel" CausesValidation="false"><span>Cancel</span></asp:LinkButton>
                            <asp:ValidationSummary ID="vsOrganization" runat="server" ShowMessageBox="true" ShowSummary="false"
                                CssClass="error" HeaderText="Required Field should not be empty" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <%--<div style='display: none'>
            <div id='inline_content'>
                <div class="InsertScreen">
                    <h2>
                        You have successfully created</h2>
                    <div class="Strip">
                        <%= organizationName%>
                    </div>
                    <p>
                        Our MedAppointment Team will verify via phone within 48 hours
                        <br>
                        after activation you can access your profile...</p>
                    <p>
                        Would you like to add yourself as a first Doctor?
                    </p>
                    <p>
                        <asp:LinkButton ID="lbtnOrganizationScriptYes" runat="server" class="BluBtnNew" style="right: 141px;" OnClick="lbtnOrganizationScriptYes_OnClick"><span>Yes</span></asp:LinkButton>
                        <asp:LinkButton ID="lbtnOrganizationScript" runat="server" class="BluBtnNew" OnClick="lbtnOrganizationScript_OnClick"><span>No</span></asp:LinkButton>
                    </p>                    
                    <div class="Right">
                        <img src="ImagesNew/inser-right.png" /></div>
                </div>
            </div>
        </div>--%>
    </ContentTemplate>
    <Triggers>
        <asp:PostBackTrigger ControlID="lbtnRegister" />
    </Triggers>
</asp:UpdatePanel>
</asp:Content>