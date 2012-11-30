using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;

public partial class Admin_AdminRemainderSMS : System.Web.UI.Page
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

    private void BindPatientSearch(bool isBind)
    {
        DataTable dtRemainderSMS = new AdministrationBAL().GetRemainderSMS();

        foreach (DataRow dr in dtRemainderSMS.Rows)
        {
            dr["Sent On"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(dr["Sent On"]), "India Standard Time");
        }
        dtRemainderSMS.AcceptChanges();

        rgRemainderSMS.DataSource = dtRemainderSMS;

        if (!isBind)
            rgRemainderSMS.DataBind();
    }

    protected void rgRemainderSMS_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindPatientSearch(true);
    }

    protected void rgRemainderSMS_ItemDataBound(object sender, GridItemEventArgs e)
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
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgRemainderSMS.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}