using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using System.Text.RegularExpressions;
using System.Globalization;

public partial class Jobs_Job_AddClient : System.Web.UI.Page
{
    protected string organizationName = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DefaultSettings();
        }
    }

    private void DefaultSettings()
    {
        txtOrganizationName.Focus();

        //lblSubDomain.Text = SiteBAL.GetRootDomain();

        //BindCountry();

        //BindTimeZone();

        //trConditionPage.Visible = false;

        //LoadAccount(Convert.ToInt32(Session["SignInLoginId"]));

        //BindByIP();
    }

    private void LoadAccount(int loginId)
    {
        LoginNewDO l = new LoginBAL().GetAccount(loginId);
        //ddlCountry.Items.FindByValue(l.CountryId.ToString()).Selected = true;
        //BindState(l.CountryId);
        hfMobile.Value = l.MobileId;
        hfEmail.Value = l.EmailId;
        //txtEmail.Text = l.EmailId;
        //txtMobile.Text = l.MobileId;
        //txtEmail.ReadOnly = true;
        //txtMobile.ReadOnly = true;
    }

    private void ClearForm()
    {
        txtOrganizationName.Text = "";
        //ddlState.Items.Clear();
        //ddlCity.Items.Clear();
        //ddlState.Items.Insert(0, new ListItem("Select State", "0"));
        //ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
        //ddlCountry.SelectedIndex = 0;
        //txtBranchName.Text = "";
        //txtAddress.Text = "";
        //txtPostalCode.Text = "";
        //ddlTimeZone.SelectedIndex = 0;
        //txtPhone.Text = "";
        //txtInCharge.Text = "";
        //chkExternalReference.Checked = false;
        //chkConditionsPage.Checked = false;
    }

    //private void BindCountry()
    //{
    //    ddlCountry.Items.Clear();
    //    ddlCountry.DataSource = new MasterBAL().GetCountry();
    //    ddlCountry.DataValueField = "CountryId";
    //    ddlCountry.DataTextField = "CountryName";
    //    ddlCountry.DataBind();

    //    ddlCountry.Items.Insert(0, new ListItem("Select Country", "0"));
    //    ddlState.Items.Insert(0, new ListItem("Select State", "0"));
    //    ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
    //}

    //private void BindState(int countryId)
    //{
    //    DataTable dtState = new MasterBAL().GetState(countryId);
    //    if (dtState.Columns[0].ColumnName.ToLower() == "cityid")
    //    {
    //        ddlCity.Items.Clear();
    //        ddlCity.DataSource = dtState;
    //        ddlCity.DataValueField = "CityId";
    //        ddlCity.DataTextField = "CityName";
    //        ddlCity.DataBind();
    //        ddlCity.Items.Insert(0, new ListItem("Select City", "0"));

    //        ddlState.Items.Clear();
    //        trState.Visible = false;
    //        ddlState.Visible = false;
    //        divState.Visible = false;
    //    }
    //    else
    //    {
    //        ddlState.Items.Clear();
    //        ddlState.DataSource = dtState;
    //        ddlState.DataValueField = "StateId";
    //        ddlState.DataTextField = "StateName";
    //        ddlState.DataBind();
    //        trState.Visible = true;
    //        ddlState.Visible = true;
    //        divState.Visible = true;
    //        ddlState.Items.Insert(0, new ListItem("Select State", "0"));
    //    }
    //}

    //private void BindCity(int stateId)
    //{
    //    DataTable dtCity = new MasterBAL().GetCity(stateId);

    //    ddlCity.Items.Clear();
    //    if (dtCity.Rows.Count > 0)
    //    {
    //        ddlCity.DataSource = dtCity;
    //        ddlCity.DataValueField = "CityId";
    //        ddlCity.DataTextField = "CityName";
    //        ddlCity.DataBind();
    //        ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
    //        trCity.Visible = true;
    //        ddlCity.Visible = true;
    //        divCity.Visible = true;
    //    }
    //    else
    //    {
    //        trCity.Visible = false;
    //        ddlCity.Visible = false;
    //        divCity.Visible = false;
    //    }
    //}

    //private void BindTimeZone()
    //{
    //    ddlTimeZone.Items.Clear();
    //    foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones())
    //    {
    //        ddlTimeZone.Items.Add(new ListItem(timeZone.DisplayName, timeZone.Id));
    //    }
    //    ddlTimeZone.Items.Insert(0, new ListItem("Select Time Zone", "0"));
    //}

    //protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    trState.Visible = true;
    //    ddlState.Visible = true;
    //    divState.Visible = true;
    //    trCity.Visible = true;
    //    ddlCity.Visible = true;
    //    divCity.Visible = true;

    //    if (Convert.ToInt32(ddlCountry.SelectedValue) == 0)
    //    {
    //        ddlState.Items.Clear();
    //        ddlCity.Items.Clear();
    //        ddlState.Items.Insert(0, new ListItem("Select State", "0"));
    //        ddlCity.Items.Insert(0, new ListItem("Select City", "0"));

    //        rfvCountry.IsValid = false;
    //        rfvState.IsValid = false;
    //        rfvCity.IsValid = false;
    //    }
    //    else
    //    {
    //        BindState(Convert.ToInt32(ddlCountry.SelectedValue));

    //        if (trState.Visible)
    //        {
    //            ddlCity.Items.Clear();
    //            ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
    //        }

    //        rfvState.IsValid = false;
    //        rfvCity.IsValid = false;
    //    }
    //}

    //protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    trCity.Visible = true;
    //    ddlCity.Visible = true;
    //    divCity.Visible = true;

    //    if (Convert.ToInt32(ddlState.SelectedValue) == 0)
    //    {
    //        ddlCity.Items.Clear();
    //        ddlCity.Items.Insert(0, new ListItem("Select City", "0"));

    //        rfvState.IsValid = false;
    //        rfvCity.IsValid = false;
    //    }
    //    else
    //    {
    //        BindCity(Convert.ToInt32(ddlState.SelectedValue));
    //        rfvCity.IsValid = false;
    //    }
    //}

    protected void lbtnRegister_Click(object sender, EventArgs e)
    {
        //if ((ddlCity.SelectedValue != "0") && (ddlCity.SelectedValue != ""))
        //{
            if (!ValidateOrganization(Regex.Replace(txtOrganizationName.Text.Trim(), @"\s+", " ")))
            {
                cvOrganization.IsValid = false;
                //txtBranchName.Focus();
                return;
            }
        //}
        //else if (!ValidateOrganization(Regex.Replace(txtOrganizationName.Text.Trim(), @"\s+", " "), Convert.ToInt32(ddlState.SelectedValue), Regex.Replace(txtBranchName.Text.Trim(), @"\s+", " "), 1))
        //{
        //    cvOrganization.IsValid = false;
        //    txtBranchName.Focus();
        //    return;
        //}

            if (!ValidateSubDomain(txtSubDomain.Text.Trim()))
            {
                cvSubDomain.IsValid = false;
                txtSubDomain.Focus();
                return;
            }

        if (Page.IsValid)
            SaveOrganization();
        Session["RegisterMedicalService"] = true;
    }

    protected void lbtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job_ManageAdmin.aspx");
    }

    public static string ToTitleCase(string input)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
    }

    private void SaveOrganization()
    {
        //string titleCaseorganizationAddress = txtAddress.Text.ToLower();
        string titleCaseorganizationName = txtOrganizationName.Text.ToLower();
        //string titleCasepersonIncahrge = txtInCharge.Text.ToLower();
        //string titleCaseBranchName = txtBranchName.Text.ToLower();
        //string titleCaseRefferedBy = txtReferedBy.Text.ToLower();
        string titleCaseSubDomain = txtSubDomain.Text.ToLower();
        //txtAddress.Text = ToTitleCase(titleCaseorganizationAddress);
        txtOrganizationName.Text = ToTitleCase(titleCaseorganizationName);
        //txtInCharge.Text = ToTitleCase(titleCasepersonIncahrge);
        //txtBranchName.Text = ToTitleCase(titleCaseBranchName);
        //txtEmail.Text = txtEmail.Text.ToLower();
        //txtReferedBy.Text = ToTitleCase(titleCaseRefferedBy);
        txtSubDomain.Text = ToTitleCase(titleCaseSubDomain);

        OrganizationDO o = new OrganizationDO();
        //o.LoginId = Convert.ToInt32(Session["SignInLoginId"]);
        //o.OrganizationName = Regex.Replace(txtOrganizationName.Text.Trim(), @"\s+", " ");
        //o.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
        //if (trState.Visible)
        //    o.StateId = Convert.ToInt32(ddlState.SelectedValue);
        //else
        //    o.StateId = 0;
        //if (trCity.Visible)
        //    o.CityId = Convert.ToInt32(ddlCity.SelectedValue);
        //else
        //    o.CityId = 0;
        //o.BranchName = Regex.Replace(txtBranchName.Text.Trim(), @"\s+", " ");
        ////o.Address = null;
        //o.PostalCode = txtPostalCode.Text;
        //o.TimeZone = ddlTimeZone.SelectedValue;
        //o.Phone = null;
        //o.Mobile = hfMobile.Value;
        //o.InCharge = null;
        //o.IsExternalReference = Convert.ToBoolean(0);
        //o.MaxAppointmentDays = 0; //txtPriorDays.Text
        //o.IsApprovalSystem = false; //chkApprovalSystem.Checked
        //o.IsCarParkFacility = Convert.ToBoolean(0);
        //o.IsConditionsPage = Convert.ToBoolean(0);
        //o.SubDomain = txtSubDomain.Text; //sb.ToString();
        //o.CNameUrl = ""; //txtCNameUrl.Text;
        //o.WelcomeTitle = ""; //txtShortDescription.Text;
        //o.AboutOrganization = ""; //txtAboutOrganization.Text;
        //o.ReferedBy = null;
        //o.ReferenceToken = new CommonBAL().GetNewToken();

        int organizationId = new OrganizationBAL().SaveOrganization(txtOrganizationName.Text, txtSubDomain.Text);

        if (organizationId > 0)
        {
            Response.Redirect("Job_ManageAdmin.aspx");
            //ViewState["OrganizationId"] = organizationId;
            //organizationName = Regex.Replace(txtOrganizationName.Text.Trim(), @"\s+", " ") + " " + Regex.Replace(txtBranchName.Text.Trim(), @"\s+", " ");
            //ClientScriptManager cs = Page.ClientScript;
            //Type cType = this.GetType();
            //string cScript = "$(document).ready(function () { $.colorbox({ inline: true, width: \"700px\", href: \"#inline_content\" }) });";
            //cs.RegisterStartupScript(cType, "popup", cScript,true);
        }
    }

    //protected void txtSubDomain_TextChanged(object sender, EventArgs e)
    //{
    //    if (ValidateSubDomain(txtSubDomain.Text.Trim()))
    //    {
    //        cvSubDomain.IsValid = true;
    //    }
    //    else
    //    {
    //        cvSubDomain.IsValid = false;
    //    }
    //}

    private bool ValidateSubDomain(string subDomain)
    {
        int organizationId = 0;
        OrganizationBAL objOrganizationBal = new OrganizationBAL();
        if (objOrganizationBal.ValidateSubDomain(subDomain, organizationId) > 0)
            return false;
        else
            return true;
    }

    //protected void lbtnOrganizationScript_OnClick(object sender, EventArgs e)
    //{
    //    if (hfMobile.Value.Substring(0, 2) == "91")
    //        CommunicationBAL.SendSMSToIndiaWithoutCheckingNotification(hfMobile.Value, OrganizationRegisteredSMSFormat(), (int)AccountType.Organization, "Added New Organization", Convert.ToInt32(ViewState["OrganizationId"]));
    //    else
    //        CommunicationBAL.SendSMSToNonIndiaWithoutCheckingNotification(hfMobile.Value, OrganizationRegisteredSMSFormat(), (int)AccountType.Organization, "Added New Organization", Convert.ToInt32(ViewState["OrganizationId"]));

    //    CommunicationBAL.SendEmailWithoutCheckingNotification(hfEmail.Value, "MedAppointment - Organization Registration", OrganizationRegistrationEmailFormat(), true);

    //    Response.Redirect("profile.aspx");
    //}

    //protected void lbtnOrganizationScriptYes_OnClick(object sender, EventArgs e)
    //{
    //    if (hfMobile.Value.Substring(0, 2) == "91")
    //        CommunicationBAL.SendSMSToIndiaWithoutCheckingNotification(hfMobile.Value, OrganizationRegisteredSMSFormat(), (int)AccountType.Organization, "Added New Organization", Convert.ToInt32(ViewState["OrganizationId"]));
    //    else
    //        CommunicationBAL.SendSMSToNonIndiaWithoutCheckingNotification(hfMobile.Value, OrganizationRegisteredSMSFormat(), (int)AccountType.Organization, "Added New Organization", Convert.ToInt32(ViewState["OrganizationId"]));

    //    CommunicationBAL.SendEmailWithoutCheckingNotification(hfEmail.Value, "MedAppointment - Organization Registration", OrganizationRegistrationEmailFormat(), true);

    //    Session["FirstDoctor"] = hfMobile.Value;
    //    Session["SignInAccountTypeId"] = (int)AccountType.Organization;

    //    if (ViewState["OrganizationId"] != null)
    //        Session["SignInOrganizationId"] = Convert.ToInt32(ViewState["OrganizationId"]);

    //    Response.Redirect("AddDoctor.aspx");
    //}

    void DynamicButtonClick(object sender, CommandEventArgs e)
    {
        if (e.CommandArgument.ToString() != string.Empty)
        {
            string[] cmdArgs = e.CommandArgument.ToString().Split(',');

            int organizationId = Convert.ToInt32(cmdArgs[0]);
            int accountTypeId = Convert.ToInt32(cmdArgs[1]);
            int accountId = Convert.ToInt32(cmdArgs[2]);
            if (((AccountType)accountTypeId) == AccountType.Organization)
            {
                Session["SignInAccountTypeId"] = (int)AccountType.Organization;
                Session["SignInOrganizationId"] = organizationId;
                Session["SignInAccountId"] = accountId;
                //Added By Visa.G For Jobs Module.
                Session["Login"] = "SUBADMIN";

                Response.Redirect("~/Organization.aspx");
            }
        }
    }

    private bool ValidateOrganization(string organizationName)
    {
        int _organizationId = 0;
        OrganizationBAL objOrganizationBal = new OrganizationBAL();

        if (objOrganizationBal.ValidateOrganization(organizationName) > 0)
            return false;
        else
            return true;
    }

    //private string OrganizationRegistrationEmailFormat()
    //{
    //    StringWriter strContent = new StringWriter();
    //    try
    //    {
    //        strContent.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
    //        strContent.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
    //        strContent.WriteLine("<head>");
    //        strContent.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
    //        strContent.WriteLine("<title>MedAppointment - Organization Registration</title>");
    //        strContent.WriteLine("</head>");
    //        strContent.WriteLine("<body>");
    //        strContent.WriteLine("<table width=\"600px\" border=\"0\" cellspacing=\"5\" cellpadding=\"0\" align=\"Left\">");
    //        strContent.WriteLine("<tr>");
    //        strContent.WriteLine("<td colspan=\"2\">Dear " + txtInCharge.Text + ",</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
    //        strContent.WriteLine("<td colspan=\"2\">You have successfully created your Medical service profile. Our MedAppointment team will verify via phone within 48 hours and after activation you can access your profile</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
    //        strContent.WriteLine("<tr><td width=\"250px\">Medical Service Name:</td><td width=\"350px\">  " + txtOrganizationName.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Country:</td><td>  " + ddlCountry.SelectedItem.Text + "</td></tr>");
    //        if ((ddlState.SelectedValue != "0") && (ddlState.SelectedValue != ""))
    //            strContent.WriteLine("<tr><td>State:</td><td>" + ddlState.SelectedItem.Text + "</td></tr>");
    //        if ((ddlCity.SelectedValue != "0") && (ddlCity.SelectedValue != ""))
    //            strContent.WriteLine("<tr><td>City:</td><td>  " + ddlCity.SelectedItem.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Address:</td><td>  " + txtAddress.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Postal Code:</td><td>  " + txtPostalCode.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Branch Name:</td><td>  " + txtBranchName.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Time Zone:</td><td> " + ddlTimeZone.SelectedItem.Text + "</td></tr>");
    //        if (!string.IsNullOrEmpty(txtPhone.Text))
    //            strContent.WriteLine("<tr><td>Phone:</td><td> " + txtPhone.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td>Person In Charge:</td><td> " + txtInCharge.Text + "</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">If you have any questions, you can chat with us by clicking on the Support button on the left side of the page. Our representatives will be available on chat on all weekdays from 10:30 AM IST to 7:30 PM IST and we’ll be happy to assist you.</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">Sincerely,</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">MedAppointment</td></tr>");
    //        strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
    //        strContent.WriteLine("</table>");
    //        strContent.WriteLine("</body>");
    //        strContent.WriteLine("</html>");

    //        return strContent.ToString();
    //    }
    //    catch
    //    {
    //        return "";
    //    }
    //}

    //private string OrganizationRegisteredSMSFormat()
    //{
    //    string smsOrganization = txtOrganizationName.Text;

    //    if (smsOrganization.Length > 20)
    //        smsOrganization = smsOrganization.Substring(0, 20);

    //    string strContent = "Your " + smsOrganization + " profile at MedAppointment.com is pending verification. You will receive a call within 48 hours to confirm the details.";
    //    return strContent.ToString();
    //}

    //private void BindByIP()
    //{
    //    string ipAddress = string.Empty;
    //    DataSet dsCountry = new DataSet();

    //    ipAddress = IpAddress();
    //    ipAddress = (ipAddress == "127.0.0.1" || ipAddress.Length < 5) ? "119.82.113.146" : ipAddress;

    //    if (!string.IsNullOrEmpty(ipAddress))
    //    {
    //        dsCountry = new SearchBAL().GetIPBasedInformation(ipAddress);
    //        if (dsCountry != null)
    //        {
    //            if (dsCountry.Tables.Count > 0 && dsCountry.Tables[0].Rows.Count > 0)
    //            {
    //                string countryName = (dsCountry.Tables[0].Rows.Count > 0) ? dsCountry.Tables[0].Rows[0]["CountryName"].ToString() : string.Empty;
    //                string regionName = (dsCountry.Tables[0].Rows.Count > 0) ? dsCountry.Tables[0].Rows[0]["RegionName"].ToString() : string.Empty;
    //                string cityName = (dsCountry.Tables[0].Rows.Count > 0 && dsCountry.Tables[0].Rows[0]["city"] != null && !string.IsNullOrEmpty(dsCountry.Tables[0].Rows[0]["city"].ToString())) ? dsCountry.Tables[0].Rows[0]["city"].ToString() : string.Empty;
    //                if (cityName == "Madras")
    //                {
    //                    cityName = "Chennai";
    //                }
    //                if (ddlCountry.Items.Count > 1)
    //                {
    //                    ddlCountry.SelectedIndex = ddlCountry.Items.IndexOf(ddlCountry.Items.FindByText(countryName));
    //                    Session["SearchCountry"] = (ddlCountry.SelectedIndex > 0) ? ddlCountry.SelectedValue.ToString() : "0";
    //                    BindState(Convert.ToInt32(Session["SearchCountry"].ToString()));
    //                    ddlState.SelectedIndex = ddlState.Items.IndexOf(ddlState.Items.FindByText(regionName));
    //                    Session["SearchState"] = (ddlState.SelectedIndex > 0) ? ddlState.SelectedValue.ToString() : "0";
    //                    BindCity(Convert.ToInt32(Session["SearchState"].ToString()));
    //                    ddlCity.SelectedIndex = ddlCity.Items.IndexOf(ddlCity.Items.FindByText(cityName));
    //                    Session["SearchCity"] = (ddlCity.SelectedIndex > 0) ? ddlCity.SelectedValue.ToString() : "0";
    //                }
    //            }
    //        }
    //    }
    //}

    public string IpAddress()
    {
        string strIpAddress;
        strIpAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (strIpAddress == null)
        {
            strIpAddress = Request.ServerVariables["REMOTE_ADDR"];
        }
        return strIpAddress.Trim();
    }
}