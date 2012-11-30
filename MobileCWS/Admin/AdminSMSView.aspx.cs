using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Data;

public partial class Admin_AdminSMSView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
            Response.Redirect("AdminIndex.aspx");
    }

    protected void rgAdminSMS_ItemDataBound(object sender, GridItemEventArgs e)
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
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminSMS.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }

    protected void rgAdminSMS_ItemCreated(object sender, GridItemEventArgs e)
    {
    }

    private void BindSMSDetail(bool IsBind)
    {
        rgAdminSMS.DataSource = new AdministrationBAL().GetLoginId();

        if (!IsBind)
            rgAdminSMS.DataBind();
    }

    protected void rgAdminSMS_PreRender(object sender, EventArgs e)
    {
    }

    protected void rgAdminSMS_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (!e.IsFromDetailTable)
        {
            rgAdminSMS.DataSource = new AdministrationBAL().GetLoginId();
        }
    }

    protected void rgAdminSMS_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
        switch (e.DetailTableView.Name)
        {
            case "AccountType":
                {
                    int LoginId = Convert.ToInt32(dataItem.GetDataKeyValue("LoginId"));
                    e.DetailTableView.DataSource = new AdministrationBAL().GetAccountType(LoginId);
                    break;
                }

            case "Account":
                {
                    int LoginId = Convert.ToInt32(dataItem.GetDataKeyValue("LoginId"));
                    int AccountTypeId = Convert.ToInt32(dataItem.GetDataKeyValue("AccountTypeId"));
                    DataTable dtAccountType = new AdministrationBAL().GetSMSDetails(LoginId, AccountTypeId);
                    foreach (DataRow dr in dtAccountType.Rows)
                    {
                        dr["CreatedOn"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(dr["CreatedOn"]), "India Standard Time");
                    }
                    e.DetailTableView.DataSource = dtAccountType;
                    //e.DetailTableView.DataSource = new AdministrationBAL().GetSMSDetails(LoginId, AccountTypeId);
                    break;
                }
        }
    }
}