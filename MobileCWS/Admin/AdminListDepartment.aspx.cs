using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Data;

public partial class Admin_AdminListDepartment : System.Web.UI.Page
{
    protected int departmentType = 0;

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
        BindDepartment(false);
    }

    protected void rgAdminListDepartment_UpdateCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int departmentId = Convert.ToInt32(dataItem.GetDataKeyValue("DepartmentId").ToString());

        TextBox txtDepartmentName = (TextBox)dataItem["DepartmentName"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];

        new AdministrationBAL().InsertDepartment(departmentId, txtDepartmentName.Text, txtDescription.Text);

        BindDepartment(false);

        ShowAlertMessage("Updated successfully!");
    }

    protected void rgAdminListDepartment_InsertCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int departmentId = 0;

        TextBox txtDepartmentName = (TextBox)dataItem["DepartmentName"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];

        if (txtDepartmentName.Text == string.Empty || txtDescription.Text == string.Empty)
        {
            ShowAlertMessage("Please enter the department and description to add!");
        }
        else
        {
            int IsSaved = new AdministrationBAL().InsertDepartment(departmentId, txtDepartmentName.Text, txtDescription.Text);
            if (IsSaved < 0)
                ShowAlertMessage("Entered Department is already exists!");
            else
            {
                ShowAlertMessage("New Department Saved successfully!");
            }
        }
        BindDepartment(false);
    }

    protected void rgAdminListDepartment_DeleteCommand(object source, GridCommandEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.Item;
        int departmentId = Convert.ToInt32(dataItem.GetDataKeyValue("DepartmentId").ToString());
        int IsDeleted = Convert.ToInt32(dataItem["IsDeleted"].Text);

        int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(departmentId, departmentType);// for department type is 0

        BindDepartment(false);
        
        if (IsDeleted > 0)
        {
            ShowAlertMessage("Deleted Successfully!");
        }
    }

    protected void rgAdminListDepartment_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindDepartment(true);
    }

    private void BindDepartment(bool IsRebind)
    {
        DataTable dtDepartment = new AdministrationBAL().GetDepartment();
        rgAdminListDepartment.DataSource = dtDepartment;

        if (!IsRebind)
            rgAdminListDepartment.DataBind();
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

    protected void rgAdminListDepartment_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            ImageButton imgButton = (ImageButton)item["Delete"].Controls[0];
            if (item["DeleteName"].Text == "Delete")
            {
                imgButton.ImageUrl = "../ImagesNew/delete-icon.png";
            }
            else
            {
                imgButton.ImageUrl = "../Imagesnew/tickIcon.png";
            }
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminListDepartment.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}