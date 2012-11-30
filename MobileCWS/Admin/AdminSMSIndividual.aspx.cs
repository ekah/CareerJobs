using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;

public partial class Admin_AdminSMSIndividual : System.Web.UI.Page
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

    private void BindIndividualSMSSearch(bool isBind)
    {
        DataTable dtIndividualSMS = new AdministrationBAL().GetSMSIndividual();

        foreach (DataRow dr in dtIndividualSMS.Rows)
        {
            dr["CreatedOn"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(dr["CreatedOn"]), "India Standard Time");
        }
        dtIndividualSMS.AcceptChanges();

        rgSMSIndividual.DataSource = dtIndividualSMS;

        if (!isBind)
            rgSMSIndividual.DataBind();
    }

    protected void rgSMSIndividual_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindIndividualSMSSearch(true);
    }

    protected void rgSMSIndividual_ItemDataBound(object sender, GridItemEventArgs e)
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
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgSMSIndividual.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}