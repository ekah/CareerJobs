using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Data;
using System.IO;
using System.Text;

public partial class Admin_AdminAppointmentView : System.Web.UI.Page
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

    protected string GetUrl()
    {
        return SiteBAL.GetURL();
    }

    private void BindAppointment(bool isBind)
    {
        DataTable dtAppointmentView = new AdministrationBAL().GetAppointmentview(); 

        foreach (DataRow drAppointmentView in dtAppointmentView.Rows)
        {
            if (!string.IsNullOrEmpty(drAppointmentView["ScheduleAddress"].ToString()))
                drAppointmentView["ScheduleAddress"] = drAppointmentView["ScheduleAddress"].ToString().Replace("\r\n\r\n", "\n").Replace("\r\n", "\n").Replace("\n\n", "\n").Replace("\n", ", \n");
            else
            {
                StringBuilder ScheduleAddress = new StringBuilder();

                ScheduleAddress.AppendLine(drAppointmentView["OrganizationName"].ToString());
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["AddressLine2"].ToString())) ? " \n" + drAppointmentView["AddressLine1"].ToString() + " \n" + drAppointmentView["AddressLine2"].ToString() : " \n" + drAppointmentView["AddressLine1"].ToString());
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["CityName"].ToString())) ? " \n" + drAppointmentView["CityName"].ToString() : string.Empty);
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["StateName"].ToString())) ? " \n" + drAppointmentView["StateName"].ToString() : string.Empty);
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["CountryName"].ToString())) ? " \n" + drAppointmentView["CountryName"].ToString() : string.Empty);
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["PostalCode"].ToString())) ? " \nPostalCode:" + drAppointmentView["PostalCode"].ToString() : string.Empty);
                ScheduleAddress.AppendLine((!string.IsNullOrEmpty(drAppointmentView["Phone"].ToString())) ? " \nPhone: " + drAppointmentView["Phone"].ToString() : string.Empty);

                drAppointmentView["ScheduleAddress"] = ScheduleAddress.ToString();
            }

            drAppointmentView["CreatedOn"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(drAppointmentView["CreatedOn"]), "India Standard Time");
            
        }
        dtAppointmentView.AcceptChanges();

        rgAdminAppointmentView.DataSource = dtAppointmentView;

        if (!isBind)
            rgAdminAppointmentView.DataBind();
    }

    protected void rgAdminAppointmentView_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindAppointment(true);
    }

    protected void rgAdminAppointmentView_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridCommandItem)
        {
            GridCommandItem commandItem = (GridCommandItem)e.Item;
            commandItem.FindControl("InitInsertButton").Visible = false;
            commandItem.FindControl("AddNewRecordButton").Visible = false;
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminAppointmentView.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}