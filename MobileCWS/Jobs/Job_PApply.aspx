<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.master"
    CodeFile="Job_PApply.aspx.cs" Inherits="Jobs_Job_PApply" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<link href="../StylesNew/Jobs/job_style.css" rel="stylesheet" type="text/css" />
  <script type="text/javascript" language="javascript">
      function MovetoNextTextBox(arg) {
          if (arg == 1) {
              var StringLenth = document.getElementById('<%=txtHometelephone2.ClientID %>').value.length;
              if (StringLenth == 13) {
                  document.getElementById('<%=txtHometelephone2.ClientID %>').focus();
              }
          }
      }

      function MovetoNextTextBoxMobile(arg) {
          if (arg == 1) {
              var StringLenth = document.getElementById('<%=txtMobile.ClientID %>').value.length;
              if (StringLenth == 10) {
                  document.getElementById('<%=txtMobile.ClientID %>').focus();
              }


          }
      }


      function ValidateHomeTelephone(source, arguments) {
          var strValidChars = "0123456789";

          var arg = document.getElementById('<%=txtHometelephone2.ClientID %>').value;

          if (arg.length == 0) {
              arguments.IsValid = false;
          }
          else {
              for (i = 0; i < arg.length; i++) {
                  strChar = arg.charAt(i);
                  if (strValidChars.indexOf(strChar) == -1) {
                      arguments.IsValid = false;
                      return;
                  }
              }
          }
      }

      function ValidateMobileTelephone(source, arguments) {
          var strValidChars = "0123456789";

          var arg = document.getElementById('<%=txtMobile.ClientID %>').value;

          if (arg.length == 0) {
              arguments.IsValid = false;
          }
          else if (arg.length < 10) {
              arguments.IsValid = false;
          }
          else {
              for (i = 0; i < arg.length; i++) {
                  strChar = arg.charAt(i);
                  if (strValidChars.indexOf(strChar) == -1) {
                      arguments.IsValid = false;
                      return;
                  }
              }
          }
      }
    </script>
<style type="text/css">
.innercntbg_mid_cnt{margin: 18px 0 0 25px; width: 600px;}
.thankyou{ height:95px; width:640px; padding-top:45px; text-align:center; font-size:18px; }
.jobdescinnercntbg_mid_cnt{ width:845px;}
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
         <h3>apply</h3>
       
<div class="jobdescinnercntbg_mid_cnt">  
  <asp:ValidationSummary ID="val1" runat="server" ShowMessageBox="true" ShowSummary="false"
            DisplayMode="List" ValidationGroup="val1" />
  <div class="inputs" id="divInput" runat="server">
    <asp:Label ID="lbljobidval" runat="server"></asp:Label>
    <table width="650" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="350"><div class="FormText">Name of Candidate</div></td>
        <td></td>
        <td><asp:TextBox ID="txtname" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="requsername" runat="server" ControlToValidate="txtname"
                ErrorMessage="Enter Candidate Name" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
       <tr>
        <td><div class="FormText">Age</div></td>
        <td></td>
        <td><asp:TextBox ID="txtage" Width="50" CssClass="txtBoxStyl" runat="server" MaxLength="3"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqage" runat="server" ControlToValidate="txtage"
                ErrorMessage="Enter Age" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="regage" runat="server" ControlToValidate="txtage"
                ErrorMessage="Enter Age Only Numbers" Display="Dynamic" ValidationExpression="^\d+$"
                ValidationGroup="val1"></asp:RegularExpressionValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Sex</div></td>
        <td></td>
        <td style="background:none;"><asp:RadioButtonList ID="rdSex" runat="server">
        
            <asp:ListItem Text="Male"  Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
          </asp:RadioButtonList>
          <asp:RequiredFieldValidator ID="reqsex" runat="server" ControlToValidate="rdSex"
                ErrorMessage="Select Sex" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Permanent Address</div></td>
        <td></td>
        <td><asp:TextBox ID="txtpermanentaddress" CssClass="txtBoxStyl" runat="server" TextMode="MultiLine"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqpermanentaddress" runat="server" ControlToValidate="txtpermanentaddress"
                ErrorMessage="Enter Permanent Address" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Email</div></td>
        <td></td>
        <td>
          <asp:TextBox ID="txtemail" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqemail" runat="server" ControlToValidate="txtemail"
                ErrorMessage="Enter Email" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegExpValEmail" runat="server" ErrorMessage="Enter Valid Email"
                ControlToValidate="txtemail" ValidationGroup="val1" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">City</div></td>
        <td></td>
        <td><asp:TextBox ID="txtCity" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqcity" runat="server" ControlToValidate="txtCity"
                ErrorMessage="Enter City" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">District</div></td>
        <td></td>
        <td><asp:TextBox ID="txtdistrict" CssClass="txtBoxStyl" runat="server"></asp:TextBox></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">State</div></td>
        <td></td>
        <td><asp:TextBox ID="txtState" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqState" runat="server" ControlToValidate="txtState"
                ErrorMessage="Enter State" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Country</div></td>
        <td></td>
        <td><asp:TextBox ID="txtCountry" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqCountry" runat="server" ControlToValidate="txtCountry"
                ErrorMessage="Enter Country" Display="Dynamic" ValidationGroup="val1"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">How did you know about us ?</div></td>
        <td></td>
        <td><telerik:RadComboBox ID="rdhowabt" runat="server" style="width:405px;">
            <Items>
              <telerik:RadComboBoxItem runat="server" Text="--Select--" Value="--Select--" />
              <telerik:RadComboBoxItem runat="server" Text="Internet" Value="Internet" />
              <telerik:RadComboBoxItem runat="server" Text="Employee" Value="Employee" />
              <telerik:RadComboBoxItem runat="server" Text="Newspaper" Value="Newspaper" />
              <telerik:RadComboBoxItem runat="server" Text="Website" Value="Website" />
              <telerik:RadComboBoxItem runat="server" Text="Direct" Value="Direct" />
              <telerik:RadComboBoxItem runat="server" Text="Other" Value="Other" />
            </Items>
          </telerik:RadComboBox>
          <asp:RequiredFieldValidator ID="reqhowabt" runat="server" ControlToValidate="rdhowabt" InitialValue="--Select--"
                ErrorMessage="Select How did you know about us" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Contact Phone (Country,Area Code,Phone Number)</div></td>
        <td></td>
        <td><span>
          <asp:TextBox ID="txtHometelephone2" CssClass="txtBoxStyl" runat="server" MaxLength="20"  onkeyup="MovetoNextTextBox(2)"></asp:TextBox>
          <ajaxToolkit:FilteredTextBoxExtender ID="AjaxFTEHometelephone2" TargetControlID="txtHometelephone2"
                        FilterType="Numbers" runat="server"> </ajaxToolkit:FilteredTextBoxExtender>     
                        </span><span>&nbsp;&nbsp;&nbsp;</span>    
          <asp:CustomValidator ID="CusValtxtHometelephone" runat="server" ControlToValidate="txtHometelephone2"
                ValidationGroup="val1" ClientValidationFunction="ValidateHomeTelephone" Display="Dynamic"
                SetFocusOnError="true" ErrorMessage="Phone Number Should be Valid" ValidateEmptyText="true"></asp:CustomValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Contact Mobile</div></td>
        <td></td>
        <td><span>
          <asp:TextBox ID="txtMobile" CssClass="txtBoxStyl" runat="server" MaxLength="10" onkeyup="MovetoNextTextBoxMobile(2)"></asp:TextBox>
          <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" TargetControlID="txtMobile"
                    FilterType="Numbers" runat="server"> </ajaxToolkit:FilteredTextBoxExtender>
          </span><span>&nbsp;&nbsp;&nbsp;</span>
          <asp:CustomValidator ID="cvmobile" runat="server" ControlToValidate="txtMobile"
                ValidationGroup="val1" ClientValidationFunction="ValidateMobileTelephone" Display="Dynamic"
                SetFocusOnError="true" ErrorMessage="Enter Valid Mobile Number" ValidateEmptyText="true"></asp:CustomValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Best time to call you</div></td>
        <td></td>
        <td><telerik:RadTimePicker ID="rdtimetocall" runat="server" Width="100px"  />
          </telerik:RadTimePicker>
          <asp:RequiredFieldValidator ID="Reqtimetocall" CssClass="timePopupLink" runat="server" ControlToValidate="rdtimetocall"
                Display="Dynamic" ErrorMessage="Select Time to call" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Specialization Category</div></td>
        <td></td>
        <td><telerik:RadComboBox ID="rdSpecialization" runat="server" style="width:405px;"> </telerik:RadComboBox>
          <asp:RequiredFieldValidator ID="reqSpecialization" runat="server" ControlToValidate="rdSpecialization"
                ErrorMessage="Select Specialization" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Experience</div></td>
        <td></td>
        <td><telerik:RadComboBox ID="rdExperience" runat="server" style="width:405px;">
            <Items>
              <telerik:RadComboBoxItem runat="server" Text="--Select--" Value="--Select--" />
              <telerik:RadComboBoxItem runat="server" Text="<1" Value="<1" />
              <telerik:RadComboBoxItem runat="server" Text="1-2" Value="1-2" />
              <telerik:RadComboBoxItem runat="server" Text="3-5" Value="3-5" />
              <telerik:RadComboBoxItem runat="server" Text="6-8" Value="6-8" />
              <telerik:RadComboBoxItem runat="server" Text="9-10" Value="9-10" />
               <telerik:RadComboBoxItem runat="server" Text=">10" Value=">10" />
            </Items>
          </telerik:RadComboBox>
          <asp:RequiredFieldValidator ID="reqExperience" runat="server" ControlToValidate="rdExperience" 
                ErrorMessage="Select Experience" Display="Dynamic" ValidationGroup="val1" InitialValue="--Select--"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Highest Qualification</div></td>
        <td></td>
        <td ><telerik:RadComboBox ID="rdHighestQualification" runat="server" style="width:405px;">
            <Items>
              <telerik:RadComboBoxItem runat="server" Text="--Select--" Value="--Select--" />
              <telerik:RadComboBoxItem runat="server" Text="Graduate" Value="Graduate" />
              <telerik:RadComboBoxItem runat="server" Text="Diploma" Value="Diploma" />
              <telerik:RadComboBoxItem runat="server" Text="Post Graduate" Value="Post Graduate" />
              <telerik:RadComboBoxItem runat="server" Text="Masters" Value="Masters" />
              <telerik:RadComboBoxItem runat="server" Text="Doctorate" Value="Doctorate" />
              <telerik:RadComboBoxItem runat="server" Text="Unknown" Value="Unknown" />
              <telerik:RadComboBoxItem runat="server" Text="Others" Value="Others"  />
            </Items>
          </telerik:RadComboBox>
          <asp:RequiredFieldValidator ID="reqHighest" runat="server" ControlToValidate="rdHighestQualification" InitialValue="--Select--"
                ErrorMessage="Select  Highest Qualification" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Highest Degree</div></td>
        <td></td>
        <td><asp:TextBox ID="txtHightestDegree" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqHightestDegree" runat="server" ControlToValidate="txtHightestDegree"
                ErrorMessage="Enter  Highest Degree" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Current Employer</div></td>
        <td></td>
        <td><asp:TextBox ID="txtCurrentEmployer" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqCurrentEmployer" runat="server" ControlToValidate="txtCurrentEmployer"
                ErrorMessage="Enter Current Employer" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Existing Pay (Per Annum)</div></td>
        <td></td>
        <td><asp:TextBox ID="txtexistingpay" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqExistingPay" runat="server" ControlToValidate="txtexistingpay"
                ErrorMessage="Enter Existing Pay (Per Annum)" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Desired pay (Per Annum)</div></td>
        <td></td>
        <td><asp:TextBox ID="txtdesiredpay" CssClass="txtBoxStyl" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="reqDesiredPay" runat="server" ControlToValidate="txtdesiredpay"
                ErrorMessage="Enter Desired pay (Per Annum)" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Willing to relocate</div></td>
        <td></td>
        <td><asp:RadioButtonList ID="rdwilling" runat="server">
            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
            <asp:ListItem Text="No" Value="No"></asp:ListItem>
          </asp:RadioButtonList>
          <asp:RequiredFieldValidator ID="reqwilling" runat="server" ControlToValidate="rdwilling"
                ErrorMessage="Select Willing to relocate" Display="Dynamic" ValidationGroup="val1"> </asp:RequiredFieldValidator></td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td><div class="FormText">Upload Resume (Only .doc,.docx files are allowed)</div></td>
        <td></td>
        <td><asp:FileUpload ID="fileuploadresume" runat="server" />
         <asp:RegularExpressionValidator ID="regupload" runat="server" CssClass="txtBoxStyl" ErrorMessage="Upload Resume Only .doc , .docx files are allowed." ControlToValidate="fileuploadresume"
            ValidationExpression="^.*\.(doc|DOC|docx|DOCX)$"
            Display="Dynamic" ValidationGroup="val1" ></asp:RegularExpressionValidator>   
        </td>
      </tr>
       <tr><td class="vspace"></td></tr>
      <tr>
        <td class="clear"></td>
      </tr>
      <tr>
        <td></td>
        <td></td>
        <td>
            <asp:Button ID="btnSumbit" runat="server" Text="Submit" OnClick="btnSumbit_Click"
                ValidationGroup="val1" />
            <asp:Button ID="btnBackToSearch" runat="server" Text="Cancel" style="margin-left:5px;" CausesValidation="false" OnClick="btnBackToSearch_Click"
                ValidationGroup="val1" />
        </td>
      </tr>
    </table>
  </div>
  <div id="divThankyou" class="thankyou" runat="server" visible="false">
  Thank you for applying a job.<br /><br />
  <asp:Button ID="btnThankyou" runat="server" Text="Back to search" OnClick="btnThankyou_Click" />
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
