using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;

public partial class Admin_AdminOrganizationNoDoctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
            Response.Redirect("AdminIndex.aspx");

        if (!IsPostBack)
        {
            DefaultSetting();
        }
    }

    private void DefaultSetting()
    {

    }

    private void BindAppointment(bool isBind)
    {
        DataTable dtDeletedDoctorView = new AdministrationBAL().OrganizationNoDoctors();

        rgAdminOrgNoDoctor.DataSource = dtDeletedDoctorView;

        if (!isBind)
            rgAdminOrgNoDoctor.DataBind();
    }

    protected void rgAdminOrgNoDoctor_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindAppointment(true);
    }

    protected void rgAdminOrgNoDoctor_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridCommandItem)
        {
            GridCommandItem commandItem = (GridCommandItem)e.Item;
            commandItem.FindControl("InitInsertButton").Visible = false;
            commandItem.FindControl("AddNewRecordButton").Visible = false;
        }

        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            ImageButton lnkDelete = (ImageButton)item.FindControl("lnkDelete");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure you want to delete " + item["OrganizationName"].Text + "?');";
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminOrgNoDoctor.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }

    protected void lnkDelete_OnDelete(object sender, CommandEventArgs e)
    {
        if (e.CommandArgument.ToString().Length > 0)
        {
            string cmd = e.CommandArgument.ToString();

            int id = Convert.ToInt32(cmd);

            new AdministrationBAL().DeleteAccountByAccountTypeId(id, 1);

            BindAppointment(false);

            ShowAlertMessage("Profile has been deleted Successfully!");
        }
    }

    public static void ShowAlertMessage(string message)
    {
        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            message = message.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "Update_message", "alert('" + message + "');", true);
        }
    }
}