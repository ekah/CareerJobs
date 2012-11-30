using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;

public partial class Admin_AdminProfilePageDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
            Response.Redirect("AdminIndex.aspx");

        if (!IsPostBack)
            DefaultSetting();
    }

    private void DefaultSetting()
    {
        BindLoginDetail(false);
    }

    private void BindLoginDetail(bool IsBind)
    {
        DataTable dtLoginTableView = GetLoginTable();

        foreach (DataRow dr in dtLoginTableView.Rows)
        {
            dr["DateTime"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(dr["DateTime"]), "India Standard Time");
        }
        rgAdminLogIn.DataSource = dtLoginTableView;

        if (!IsBind)
            rgAdminLogIn.DataBind();

    }

    protected void rgAdminLogIn_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (!e.IsFromDetailTable)
        {
            BindLoginDetail(true);
        }
    }

    private DataTable GetLoginTable()
    {
        return new AdministrationBAL().GetLoginTableDetailView();
    }

    protected void rgAdminLogIn_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        if (e.CommandName == Telerik.Web.UI.RadGrid.ExportToExcelCommandName ||
            e.CommandName == Telerik.Web.UI.RadGrid.ExportToWordCommandName ||
            e.CommandName == Telerik.Web.UI.RadGrid.ExportToCsvCommandName)
        {
            ConfigureExport();
        }
    }

    public void ConfigureExport()
    {
        rgAdminLogIn.ExportSettings.ExportOnlyData = true;
        rgAdminLogIn.ExportSettings.FileName = "LoginStatus";
        rgAdminLogIn.ExportSettings.IgnorePaging = true;
        //rgAdminLogIn.ExportSettings.OpenInNewWindow = CheckBox3.Checked;
    }

    protected void lnkDelete_OnDelete(object sender, CommandEventArgs e)
    {
        if (e.CommandArgument.ToString().Length > 0)
        {
            string cmd = e.CommandArgument.ToString();

            int id = Convert.ToInt32(cmd);

            new AdministrationBAL().UpdateIsDeleteLoginById(id);

            BindLoginDetail(false);

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

    protected void rgAdminLogIn_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            ImageButton lnkDelete = (ImageButton)item.FindControl("lnkDelete");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure you want to delete " + item["UserName"].Text + "?');";
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminLogIn.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}