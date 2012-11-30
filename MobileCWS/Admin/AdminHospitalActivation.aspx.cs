using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;
using System.Data;
using System.IO;

public partial class Admin_AdminHospitalActivation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
            Response.Redirect("AdminIndex.aspx");

        if (!IsPostBack)
        {
            DefaultSettings();
        }
    }

    private void DefaultSettings()
    {
        BindHospital(false);
    }

    protected string GetUrl()
    {
        return SiteBAL.GetURL();
    }

    protected void rgAdminHospitalList_ActivateCommand(object source, GridCommandEventArgs e)
    {
        //GridDataItem dataItem = (GridDataItem)e.Item;
        //int OrganizationId = Convert.ToInt32(dataItem.GetDataKeyValue("OrganizationId").ToString());

        //new AdministrationBAL().UpdateHospitalActivation(OrganizationId);

        //OrganizationDO o = new OrganizationBAL().GetOrganizationById(OrganizationId);
        //LoginNewDO l = new LoginBAL().GetAccount(o.LoginId);
        //string inCharge = l.FirstName + " " + l.LastName;

        //if (l.MobileId.Substring(0, 2) == "91")
        //    CommunicationBAL.SendSMSToIndiaWithoutCheckingNotification(l.MobileId, OrganizationRegisteredSMSFormat(o.OrganizationName), (int)AccountType.Organization, "Hospital Account Activated");
        //else
        //    CommunicationBAL.SendSMSToNonIndiaWithoutCheckingNotification(l.MobileId, OrganizationRegisteredSMSFormat(o.OrganizationName), (int)AccountType.Organization, "Hospital Account Activated");

        //CommunicationBAL.SendEmailWithoutCheckingNotification(l.EmailId, " MedAppointment Organization Account Activation Confirmation", OrganizationRegisteredEmailFormat(inCharge), true);

        ////EmailSmsBAL.ActivatedOrganization(l.MobileId, l.EmailId, inCharge, o.OrganizationName);

        //BindHospital(false);
        
        //ShowAlertMessage("Activated Successfully!");
    }

    protected void lnkActivate_OnActivate(object sender, CommandEventArgs e)
    {
        int OrganizationId = Convert.ToInt32(e.CommandArgument);

        new AdministrationBAL().UpdateHospitalActivation(OrganizationId);

        OrganizationDO o = new OrganizationBAL().GetOrganizationById(OrganizationId);
        LoginNewDO l = new LoginBAL().GetAccount(o.LoginId);
        

        if (l.MobileId.Substring(0, 2) == "91")
            CommunicationBAL.SendSMSToIndiaWithoutCheckingNotification(l.MobileId, OrganizationRegisteredSMSFormat(o.OrganizationName), (int)AccountType.Organization, "Account Activation", o.OrganizationId);
        else
            CommunicationBAL.SendSMSToNonIndiaWithoutCheckingNotification(l.MobileId, OrganizationRegisteredSMSFormat(o.OrganizationName), (int)AccountType.Organization, "Account Activation", o.OrganizationId);
        
        string inCharge = l.FirstName + " " + l.LastName;
        string emailBody = OrganizationAccountActivatedEmailFormat(inCharge);
        CommunicationBAL.SendEmailWithoutCheckingNotification(l.EmailId, "MedAppointment - Organization Account Activated", emailBody, true);

        //EmailSmsBAL.ActivatedOrganization(l.MobileId, l.EmailId, inCharge, o.OrganizationName);

        BindHospital(false);

        ShowAlertMessage("Activated Successfully!");
    }

    protected void rgAdminHospitalList_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindHospital(true);
    }

    protected void rgAdminHospitalList_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
        string mobileId = dataItem.GetDataKeyValue("Mobile").ToString();

        DataTable dtDepartment = new AdministrationBAL().GetExistingHospital(mobileId);

        dtDepartment.Columns.Add("Address", typeof(string));
        foreach (DataRow dr in dtDepartment.Rows)
        {
            if (!string.IsNullOrEmpty(dr["AddressLine"].ToString()))
                dr["Address"] += dr["AddressLine"].ToString();

            if (!string.IsNullOrEmpty(dr["CityName"].ToString()))
                dr["Address"] += ", " + dr["CityName"].ToString();

            if (!string.IsNullOrEmpty(dr["StateName"].ToString()))
                dr["Address"] += ", " + dr["StateName"].ToString();

            if (!string.IsNullOrEmpty(dr["CountryName"].ToString()))
                dr["Address"] += ", " + dr["CountryName"].ToString();

            if (!string.IsNullOrEmpty(dr["PostalCode"].ToString()))
                dr["Address"] += ", " + dr["PostalCode"].ToString();

        }
        dtDepartment.AcceptChanges();
        e.DetailTableView.DataSource = dtDepartment;

        //if (!IsRebind)
           // rgAdminHospitalList.DataBind();
    }

    private void BindHospital(bool IsRebind)
    {
        DataTable dtDepartment = new AdministrationBAL().GetHospital();

        dtDepartment.Columns.Add("Address", typeof(string));
        foreach (DataRow dr in dtDepartment.Rows)
        {
            if (!string.IsNullOrEmpty(dr["AddressLine"].ToString()))
                dr["Address"] += dr["AddressLine"].ToString();

            if (!string.IsNullOrEmpty(dr["CityName"].ToString()))
                dr["Address"] += ", " + dr["CityName"].ToString();

            if (!string.IsNullOrEmpty(dr["StateName"].ToString()))
                dr["Address"] += ", " + dr["StateName"].ToString();

            if (!string.IsNullOrEmpty(dr["CountryName"].ToString()))
                dr["Address"] += ", " + dr["CountryName"].ToString();

            if (!string.IsNullOrEmpty(dr["PostalCode"].ToString()))
                dr["Address"] += ", " + dr["PostalCode"].ToString();

        }
        dtDepartment.AcceptChanges();

        rgAdminHospitalList.DataSource = dtDepartment;

        if (!IsRebind)
            rgAdminHospitalList.DataBind();
    }

    public static void ShowAlertMessage(string message)
    {
        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            message = message.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "Delete_message", "alert('" + message + "');", true);
        }
    }

    protected void rgAdminHospitalList_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem && e.Item.OwnerTableView.Name != "ExistingHospital")
        {
            if (e.Item is GridDataItem)
            {
                GridDataItem item = (GridDataItem)e.Item;
                //ImageButton imgButton = (ImageButton)item["Activate"].Controls[0];

                //imgButton.ImageUrl = "../Imagesnew/tickIcon.png";


                //GridDataItem item = (GridDataItem)e.Item;
                ImageButton lnkActivate = (ImageButton)item.FindControl("lnkActivate");
                lnkActivate.OnClientClick = "javascript:return confirm('Are you sure! You want to Activate this Hospital account?');";
            }
            
        }

        if (e.Item is GridDataItem && e.Item.OwnerTableView.Name == "ExistingHospital")
        {
            GridDataItem item = (GridDataItem)e.Item;
            if (item["InvalidNo"].Text == item["Mobile"].Text)
            {
                item.BackColor = System.Drawing.Color.Brown;
                item.ForeColor = System.Drawing.Color.White;
            }
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminHospitalList.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }

    private string OrganizationAccountActivatedEmailFormat(string inCharge)
    {
        StringWriter strContent = new StringWriter();
        try
        {
            strContent.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            strContent.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
            strContent.WriteLine("<head>");
            strContent.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            strContent.WriteLine("<title>MedAppointment - Organization Account Activated</title>");
            strContent.WriteLine("</head>");
            strContent.WriteLine("<body>");
            strContent.WriteLine("<table width=\"650px\" border=\"0\" cellspacing=\"5\" cellpadding=\"0\" align=\"Left\">");
            strContent.WriteLine("<tr>");
            strContent.WriteLine("<td>Dear " + inCharge + ",</td></tr>");
            strContent.WriteLine("<tr><td>&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td>Congratulations! Your MedAppointment account has been activated. Please sign in to MedAppointment to add services and configure MedAppointment for your organization.  Your organization’s details will be visible to public after verification.</td></tr>");
            strContent.WriteLine("<tr><td>&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td>If you have any questions, you can chat with us by clicking on the Support button on the left side of the page. Our representatives will be available on chat on all weekdays from 10:30 AM IST to 7:30 PM IST and we’ll be happy to assist you.</td></tr>");
            strContent.WriteLine("<tr><td>&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td>Sincerely,</td></tr>");
            strContent.WriteLine("<tr><td>MedAppointment</td></tr>");
            strContent.WriteLine("<tr><td>&nbsp;</td></tr>");
            strContent.WriteLine("</table>");
            strContent.WriteLine("</body>");
            strContent.WriteLine("</html>");

            return strContent.ToString();
        }
        catch
        {
            return "";
        }
    }

    private string OrganizationRegisteredSMSFormat(string hospitalName)
    {
        if (hospitalName.Length > 20)
            hospitalName = hospitalName.Substring(0, 20);

        string strContent = "Your " + hospitalName + " profile at MedAppointment.com has been activated. You may now login to manage this profile.";
        return strContent.ToString();
    }

    protected void OnPreRender(object sender, EventArgs e)
    {
        HideExpandColumnRecursive(rgAdminHospitalList.MasterTableView);
    }

    public void HideExpandColumnRecursive(GridTableView tableView)
    {
        GridItem[] nestedViewItems = tableView.GetItems(GridItemType.NestedView);
        foreach (GridNestedViewItem nestedViewItem in nestedViewItems)
        {
            foreach (GridTableView nestedView in nestedViewItem.NestedTableViews)
            {
                if (nestedView.Items.Count == 0)
                {
                    TableCell cell = nestedView.ParentItem["ExpandColumn"];
                    cell.Controls[0].Visible = false;
                    nestedViewItem.Visible = false;
                }
                if (nestedView.HasDetailTables)
                {
                    HideExpandColumnRecursive(nestedView);
                }
            }
        }
    }
}