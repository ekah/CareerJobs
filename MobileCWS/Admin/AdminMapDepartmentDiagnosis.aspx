<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master"
    AutoEventWireup="true" CodeFile="AdminMapDepartmentDiagnosis.aspx.cs" Inherits="Admin_MapDepartmentDiagnosis" %>

<%@ Register Src="~/Admin/Controls/AdminSideMenu.ascx" TagName="AdminSideMenu" TagPrefix="medAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" runat="Server">
    <medAdmin:AdminSideMenu ID="adminSideMenu" runat="server" />

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ddlDepartment">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="rlbTreatmentList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfo" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSaveSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAdd">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnRemove">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfo" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnSave">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblInfo" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rlbSelectedDiagnosisList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfo" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSaveSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAddSymptom">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSaveSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnRemoveSymptom">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSaveSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnSaveSymptom">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rcbSymptomList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedSymptomList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfoSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSaveSymptom" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rcbDiagnosisList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="rlbSelectedDiagnosisList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="lblInfo" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rlbTreatmentList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rlbTreatmentList" LoadingPanelID="RadAjaxLoadingPanel2" />
                    <telerik:AjaxUpdatedControl ControlID="ddlDepartment" LoadingPanelID="RadAjaxLoadingPanel2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div align="center">
        <table cellpadding="0px" cellspacing="0px" width="100%">
            <tr>
                <td colspan="7">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="left">
                    <fieldset>
                        <legend><b>New Symptom:</b></legend>
                        <telerik:RadTextBox ID="txtSymptom" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                            Width="160px" Skin="" />
                        <br />
                        <b>Description:</b>
                        <br />
                        <telerik:RadTextBox ID="txtDescriptionSymptom" CssClass="txtBoxStyl" runat="server"
                            MaxLength="500" Width="160px" Skin="" />
                    </fieldset>
                </td>
                <td colspan="2">
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddNewSymptom" runat="server" CssClass="greenBtn" OnClick="btnAddNewSymptom_Click"
                                    Width="110px" ToolTip="Click here Add Symptom to List" Text="Add Symptom"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CustomValidator ID="cvNewSymptom" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Entered symptom is already <br/>exists in list." />
                                <asp:CustomValidator ID="cvEmptySymptom" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Please enter new symptom <br/>& description to add." />
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="left">
                    <fieldset>
                        <legend><b>New Diagnosis:</b></legend>
                        <telerik:RadTextBox ID="txtDiagnosis" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                            Width="160px" Skin="" />
                        <br />
                        <b>Description:</b>
                        <br />
                        <telerik:RadTextBox ID="txtDescriptionDiagnosis" CssClass="txtBoxStyl" runat="server"
                            MaxLength="500" Width="160px" Skin="" />
                    </fieldset>
                </td>
                <td colspan="2">
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddNewDiagnosis" runat="server" CssClass="greenBtn" OnClick="btnAddNewDiagnosis_Click"
                                    Width="110px" ToolTip="Click here Add Symptom to List" Text="Add Diagnosis">
                                </asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CustomValidator ID="cvNewDiagnosis" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Entered diagnosis is already <br/>exists in list." />
                                <asp:CustomValidator ID="cvEmptyDiagnosis" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Please enter new diagnosis <br/>& description to add." />
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="left">
                    <fieldset>
                        <legend><b>New Department:</b></legend>
                        <telerik:RadTextBox ID="txtDepartment" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                            Width="160px" Skin="" />
                        <br />
                        <b>Description:</b>
                        <br />
                        <telerik:RadTextBox ID="txtDescriptionDepartment" CssClass="txtBoxStyl" runat="server"
                            MaxLength="500" Width="160px" Skin="" />
                    </fieldset>
                    <asp:RegularExpressionValidator ID="revDepartment" runat="server" ControlToValidate="txtDepartment" Display="Dynamic" ValidationExpression="[A-Za-z ]*" ErrorMessage="Please enter department in <br/>alphabets only"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddNewDepartments" runat="server" CssClass="greenBtn" OnClick="btnAddNewDepartments_Click"
                                    Width="110px" ToolTip="Click here Add Symptom to List" Text="Add Department">
                                </asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CustomValidator ID="cvNewDepartment" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Entered department is already <br/>exists in list." />
                                <asp:CustomValidator ID="cvEmptyDepatment" runat="server" ControlToValidate="ddlDepartment"
                                    CssClass="error" Display="Dynamic" ErrorMessage="Please enter new department <br/>& description to add." />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <table cellpadding="0px" cellspacing="0px" width="100%">
            <tr>
                <td colspan="9">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td align="left">
                    <b>Symptoms:</b>
                    <br />
                    <telerik:RadComboBox ID="rcbSymptomList" AllowCustomText="true" runat="server" DropDownWidth="200px"
                        Filter="Contains" Height="525px" Width="200px" />
                    <asp:Button ID="rcbbtnAddSymptom" runat="server" CssClass="greenBtn" OnClick="rcbbtnAddSymptom_Click"
                        Width="70px" ToolTip="Click here Add Symptom to List" Text="Add"></asp:Button>
                    <br />
                    <br />
                    <asp:Button ID="btnDeleteSymptom" runat="server" CssClass="greenBtn" OnClick="btnDeleteSymptom_Click"
                        OnClientClick="return confirm('Selected symptoms may be mapped with some diagnosis! Are you sure to Delete?');"
                        Width="120px" ToolTip="select item from below list to Delete one symptom" Text="Delete Symptom">
                    </asp:Button><br />
                    <asp:CustomValidator ID="cvDeleteSymptom" runat="server" ControlToValidate="ddlDepartment"
                        CssClass="error" Display="Dynamic" />
                    <br />
                    <br />
                    <telerik:RadListBox runat="server" ID="rlbSymptomList" Height="500px" Width="200px"
                        TabIndex="1" AccessKey="y" CssClass="txtBoxStyl" SelectionMode="Multiple">
                    </telerik:RadListBox>
                </td>
                <td valign="middle" align="center">
                    <asp:Button ID="btnAddSymptom" runat="server" CssClass="greenBtn" OnClick="btnAddSymptom_Click"
                        Width="70px" ToolTip="Click here Add Symptom to List" Text="Add"></asp:Button>
                    <br />
                    <br />
                    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel2" runat="server" MinDisplayTime="1000"
                        Skin="" IsSticky="true">
                        <img alt="Loading..." src="../ImagesNew/ajax-loader.gif" style="border: 0;" />
                    </telerik:RadAjaxLoadingPanel>
                    <br />
                    <asp:Button ID="btnRemoveSymptom" runat="server" CssClass="greenBtn" OnClick="btnRemoveSymptom_Click"
                        Width="70px" ToolTip="Click here Remove Symptom from List" Text="Remove"></asp:Button>
                </td>
                <td align="left">
                    <br />                    
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <b>Selected Symptoms:</b>
                    <br />
                    <telerik:RadListBox runat="server" ID="rlbSelectedSymptomList" Height="500px" Width="200px"
                        TabIndex="1" AccessKey="y" CssClass="txtBoxStyl" SelectionMode="Multiple">
                    </telerik:RadListBox>
                </td>
                <td align="left">
                    <b>Diagnosis:</b>
                    <br />
                    <telerik:RadComboBox ID="rcbDiagnosisList" AllowCustomText="true" runat="server"
                        DropDownWidth="200px" Filter="Contains" Height="525px" Width="200px" />
                        <asp:Button ID="rcbbtnAddDiagnosis" runat="server" CssClass="greenBtn" OnClick="rcbbtnAddDiagnosis_Click"
                        Width="70px" ToolTip="Click here Add diagnosis to List" Text="Add"></asp:Button>
                    <br />
                    <br />
                    <asp:Button ID="btnDeleteDiagnosis" runat="server" CssClass="greenBtn" OnClick="btnDeleteDiagnosis_Click"
                        OnClientClick="return confirm('Selected diagnosis may be mapped with some symptoms and departments! Are you sure to Delete?');"
                        Width="120px" ToolTip="select item from below list to Delete one diagnosis" Text="Delete Diagnosis">
                    </asp:Button><br />
                    <asp:CustomValidator ID="cvDeleteDiagnosis" runat="server" ControlToValidate="ddlDepartment"
                        CssClass="error" Display="Dynamic" />
                    <br />
                    <br />
                    <telerik:RadListBox runat="server" ID="rlbDiagnosisList" Height="500px" Width="200px"
                        TabIndex="1" AccessKey="y" CssClass="txtBoxStyl" SelectionMode="Multiple">
                    </telerik:RadListBox>
                </td>
                <td valign="middle" align="center">
                    <asp:Button ID="btnAdd" runat="server" CssClass="greenBtn" OnClick="btnAdd_Click"
                        Width="70px" ToolTip="Click here Add Diagnosis to List" Text="Add"></asp:Button>
                    <br />
                    <br />
                    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" MinDisplayTime="1000"
                        Skin="" IsSticky="true">
                        <img alt="Loading..." src="../ImagesNew/ajax-loader.gif" style="border: 0;" />
                    </telerik:RadAjaxLoadingPanel>
                    <br />
                    <asp:Button ID="btnRemove" runat="server" CssClass="greenBtn" OnClick="btnRemove_Click"
                        Width="70px" ToolTip="Click here Remove Diagnosis from List" Text="Remove"></asp:Button>
                </td>
                <td align="left">
                    <br />                    
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <b>Selected Diagnosis:</b>
                    <br />
                    <telerik:RadListBox runat="server" ID="rlbSelectedDiagnosisList" Height="500px" Width="200px"
                        AutoPostBack="true" TabIndex="1" AccessKey="y" CssClass="txtBoxStyl" SelectionMode="Multiple"
                        OnSelectedIndexChanged="rlbSelectedDiagnosisList_SelectedIndexChanged">
                    </telerik:RadListBox>
                </td>
                <td align="left">
                    <br />
                    <br />
                    <br />
                     <br />
                    <asp:Button ID="btnDeleteDepartment" runat="server" CssClass="greenBtn" OnClick="btnDeleteDepartment_Click"
                        Width="125px" ToolTip="select item from below list to Delete one symptom" Text="Delete Department"
                        OnClientClick="return confirm('Selected department may be mapped with some diagnosis! Are you sure to Delete?');">
                    </asp:Button><br />                   
                    <asp:CustomValidator ID="cvDeleteDepartment" runat="server" ControlToValidate="ddlDepartment"
                        CssClass="error" Display="Dynamic" />
                    <br />                    
                    <b>Department:</b>
                    <br />
                    <telerik:RadListBox ID="ddlDepartment" runat="server" CssClass="txtBoxStyl" Height="500px"
                        TabIndex="1" AccessKey="y" Width="200px" AutoPostBack="true" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged"
                        SelectionMode="Single">
                    </telerik:RadListBox>
                </td>
                <td valign="top" align="left" width="20%">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnDeleteTreatment" runat="server" CssClass="greenBtn" OnClick="btnDeleteTreatment_Click"
                        Width="125px" ToolTip="select item from below list to Delete treatment" Text="Delete treatment"
                        OnClientClick="return confirm('Selected treatment may be mapped with some department! Are you sure to Delete?');">
                    </asp:Button><br />
                    <asp:CustomValidator ID="cvDeleteTreatment" runat="server" ControlToValidate="rlbTreatmentList"
                        CssClass="error" Display="Dynamic" />
                    <br />                    
                    <b>Treatment:</b>
                    <br />
                    <telerik:RadListBox ID="rlbTreatmentList" runat="server" CssClass="txtBoxStyl" Height="300px"
                        TabIndex="1" AccessKey="y" Width="200px" AutoPostBack="true" OnSelectedIndexChanged="rlbTreatmentList_SelectedIndexChanged"
                        SelectionMode="Single">
                    </telerik:RadListBox>
                    <br /> 
                    <b>New Treatment(s):</b>
                    <telerik:RadTextBox ID="rtbtreatment" CssClass="txtBoxStyl" runat="server" MaxLength="500"
                        Width="200px" Skin="" TextMode="MultiLine" Height="150px" />
                    <br />
                    (Enter treatment's separated by (,))
                    <br />
                    <asp:Button ID="btnAddTreatment" runat="server" CssClass="greenBtn" OnClick="btnAddTreatment_Click"
                        Width="70px" ToolTip="Click here Add new treatment to List" Text="Add"></asp:Button>
                    <br />     
                    <asp:CustomValidator ID="cvAddTreatment" runat="server" ControlToValidate="rlbTreatmentList"
                        CssClass="error" Display="Dynamic" />              
                </td>
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <br />
                    <asp:Button ID="btnSaveSymptom" runat="server" CssClass="greenBtn" OnClick="btnSaveSymptom_Click"
                        Width="70px" ToolTip="Click here to Save Symptom List" Text="Save"></asp:Button>
                    <asp:Label ID="lblInfoSymptom" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
                </td>
                <td colspan="4" align="center">
                    <br />
                    <asp:Button ID="btnSave" runat="server" CssClass="greenBtn" OnClick="btnSave_Click"
                        Width="70px" ToolTip="Click here to Save Diagnosis List" Text="Save"></asp:Button>
                    <asp:Label ID="lblInfo" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
