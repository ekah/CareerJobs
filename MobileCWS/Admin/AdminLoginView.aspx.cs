using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Data;

public partial class Admin_AdminLoginView : System.Web.UI.Page
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

    protected string GetUrl()
    {
        return SiteBAL.GetURL();
    }

    protected string GetRootDomain()
    {
        return SiteBAL.GetRootDomain();
    }

    private void BindLoginDetail(bool IsBind)
    {
        DataTable dtLoginTableView = GetLoginTable();

        foreach (DataRow dr in dtLoginTableView.Rows)
        {
            dr["CreatedOn"] = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(dr["CreatedOn"]), "India Standard Time");
        }

        dtLoginTableView.AcceptChanges();

        rgAdminLogIn.DataSource = dtLoginTableView;

        if (!IsBind)
            rgAdminLogIn.DataBind();
        if (!IsBind)
        {
            foreach (GridDataItem dataItem in rgAdminLogIn.Items)
            {
                HyperLink hlnkAutoLogin = (HyperLink)dataItem.FindControl("hlnkLogin");
                if (dataItem["IsActivated"].Text == "Activate")
                {
                    hlnkAutoLogin.Enabled = true;
                }
                else
                {
                    hlnkAutoLogin.Enabled = false;
                }
            }
        }
        Generatepassword();
    }

    protected void lnkActivation_OnUpdate(object sender, CommandEventArgs e)
    {
        if (e.CommandArgument.ToString().Length > 0)
        {
            string[] cmd = e.CommandArgument.ToString().Split(',');

            int id = Convert.ToInt32(cmd[0]);
            int type = Convert.ToInt32(cmd[1]);

            string message = new AdministrationBAL().ActivateLoginById(id, type);
            
            BindLoginDetail(false);

            ShowAlertMessage(message + " Successfully!");
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

    protected void lnkDelete_OnDelete(object sender, CommandEventArgs e)
    {
        if (e.CommandArgument.ToString().Length > 0)
        {
            string[] cmd = e.CommandArgument.ToString().Split(',');

            int id = Convert.ToInt32(cmd[0]);
            int type = Convert.ToInt32(cmd[1]);

            new AdministrationBAL().DeleteAccountByAccountTypeId(id, type);

            BindLoginDetail(false);

            ShowAlertMessage("Profile has been deleted Successfully!");
        }
    }

    protected void rgAdminLogIn_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (!e.IsFromDetailTable)
        {
            BindLoginDetail(true);
            //rgAdminLogIn.DataSource = GetLoginTable();
        }
    }

    protected void rgAdminLogIn_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
        switch (e.DetailTableView.Name)
        {
            case "AccountType":
                {
                    int LoginId = Convert.ToInt32(dataItem.GetDataKeyValue("LoginId"));
                    e.DetailTableView.DataSource = GetAccountType(LoginId);
                    break;
                }

            case "Account":
                {
                    int LoginId = Convert.ToInt32(dataItem.GetDataKeyValue("LoginId"));
                    int AccountTypeId = Convert.ToInt32(dataItem.GetDataKeyValue("AccountTypeId"));
                    e.DetailTableView.DataSource = GetLoginTable(LoginId, AccountTypeId);                    
                    break;
                }
        }
    }

    private DataTable GetAccountType(int LoginId)
    {
        DataTable dtAccountType = new AdministrationBAL().GetAccountTypeByLoginView();

        DataRow[] dr = dtAccountType.Select("LoginId=" + LoginId.ToString());
        
        DataTable dtvalid = dtAccountType.Clone();

        dtvalid = dr.CopyToDataTable();

        return dtvalid;
    }

    private DataTable GetLoginTable(int LoginId, int AccountTypeId)
    {
        DataTable dtLoginView =  new AdministrationBAL().GetLoginTypeById();
        
        DataRow[] drLogin = dtLoginView.Select("LoginId=" + LoginId.ToString() + " AND " + "Type=" + AccountTypeId.ToString());

        DataTable dtLogin = null;
        if (drLogin.Length > 0)
        {
            dtLogin = dtLoginView.Clone();

            dtLogin = drLogin.CopyToDataTable();
        }
        else
            dtLogin = dtLoginView.Clone();

        return dtLogin;
    }

    private DataTable GetLoginTable()
    {
        return new AdministrationBAL().GetLoginTableByLoginView();
    }

    protected void rgAdminLogIn_ItemDataBound(object sender, GridItemEventArgs e)
    {
        Generatepassword();
        LoginActivation();
        if (e.Item is GridCommandItem)
        {
            GridCommandItem commandItem = (GridCommandItem)e.Item;
            commandItem.FindControl("InitInsertButton").Visible = false;
            commandItem.FindControl("AddNewRecordButton").Visible = false;
        }

        if (e.Item is GridDataItem && e.Item.OwnerTableView.Name == "Account")
        {
            if (e.Item is GridDataItem)
            {
                GridDataItem item = (GridDataItem)e.Item;
                ImageButton lnkDelete = (ImageButton)item.FindControl("lnkDelete");
                lnkDelete.OnClientClick = "javascript:return confirm('Are you sure you want to delete " + item["Name"].Text + "?');";
                LinkButton lnkActivation = (LinkButton)item.FindControl("lnkActivation");
                lnkActivation.OnClientClick = "javascript:return confirm('Are you sure you want to " + item["IsActivated"].Text + " " + item["Name"].Text + "?');";
            }
        }

        if (e.Item is GridDataItem && e.Item.OwnerTableView.Name == "Account")
        {

            GridDataItem dataItem = e.Item as GridDataItem;
            GridDataItem parentItem = dataItem.OwnerTableView.ParentItem;

            HyperLink hlnkAutoLogin = dataItem["AutoLogin"].Controls[1] as HyperLink;
            LinkButton lnkActivate = dataItem["Activation"].Controls[1] as LinkButton;
            if (lnkActivate.Text == "Activate")
            {
                hlnkAutoLogin.Enabled = false;
            }
            else
            {
                hlnkAutoLogin.Enabled = true;
            }
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
    
    public void ConfigureExport()
    {
        //rgAdminLogIn.MasterTableView.DetailTables[0].HierarchyDefaultExpanded = true;
        //rgAdminLogIn.MasterTableView.DetailTables.Clear();
        rgAdminLogIn.ExportSettings.ExportOnlyData = true;
        rgAdminLogIn.ExportSettings.FileName = "LoginDetails";
        rgAdminLogIn.ExportSettings.IgnorePaging = true;
    }

    protected void LoginActivation()
    {
        foreach (GridDataItem dataItem in rgAdminLogIn.Items)
        {
            if (dataItem.OwnerTableView == rgAdminLogIn.MasterTableView)
            {
                HyperLink hlnkAutoLogin = (HyperLink)dataItem.FindControl("hlnkLogin");
                if (dataItem["IsActivated"].Text == "Activate")
                {
                    hlnkAutoLogin.Enabled = true;
                }
                else
                {
                    hlnkAutoLogin.Enabled = false;
                }
            }
        }
    }
    protected void Generatepassword()
    {
        foreach (GridDataItem dataItem in rgAdminLogIn.Items)
        {
            if (dataItem.OwnerTableView == rgAdminLogIn.MasterTableView)
            {
                Label lblActivationCode = (Label)dataItem.FindControl("lblActivationCode");
                Label lblActivationCodeDisp = (Label)dataItem.FindControl("lblActivationCodeDisp");
                string newActivationCode;
                if ((lblActivationCode.Text != "Not Applicable") && (lblActivationCode.Text != ""))
                {
                    newActivationCode = new CommonBAL().GenrateNewPassword(lblActivationCode.Text).Substring(0, 4);
                    lblActivationCodeDisp.Text = newActivationCode;
                }
                else
                    lblActivationCodeDisp.Text = "Not Applicable";
            }
        }
    }

    protected void lbtnExportToExcel_Click(object sender, System.EventArgs e)
    {
        ConfigureExport();
        rgAdminLogIn.MasterTableView.ExportToExcel();
    }
}