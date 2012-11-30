using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;
using System.Data;
using System.Text;

public partial class Admin_AdminListDiagnosis : System.Web.UI.Page
{
    protected int diagnosisType = 1;

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
        BindDiagnosis(false);
    }

    protected void rgAdminListDiagnosis_UpdateCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int diagnosisId = Convert.ToInt32(dataItem.GetDataKeyValue("DiagnosisId").ToString());

        TextBox txtDiagnosis = (TextBox)dataItem["Diagnosis"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];

        new AdministrationBAL().InsertDiagnosis(diagnosisId, txtDiagnosis.Text, txtDescription.Text);       

        BindDiagnosis(false);

        ShowAlertMessage("Updated successfully!");
    }

    protected void rgAdminListDiagnosis_InsertCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int diagnosisId = 0;

        TextBox txtDiagnosis = (TextBox)dataItem["Diagnosis"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];
        if (txtDiagnosis.Text == string.Empty || txtDescription.Text == string.Empty)
        {
            ShowAlertMessage("Please enter the diagnosis and description to add!");
        }
        else
        {
            int IsSaved = new AdministrationBAL().InsertDiagnosis(diagnosisId, txtDiagnosis.Text, txtDescription.Text);
            if (IsSaved < 0)
                ShowAlertMessage("Entered Diagnosis is already exists!");
            else
            {
                ShowAlertMessage("New Diagnosis Saved successfully!");
            }  
        }
        BindDiagnosis(false);             
    }

    protected void rgAdminListDiagnosis_DeleteCommand(object source, GridCommandEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.Item;
        int diagnosisId =Convert.ToInt32(dataItem.GetDataKeyValue("DiagnosisId").ToString());
        bool IsDeleted = Convert.ToBoolean(dataItem["IsDeleted"].Text);

        int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(diagnosisId, diagnosisType);// for diagnosis type is 1

        BindDiagnosis(false);
        if (isDeleted > 0)
        { 
            ShowAlertMessage("Deleted Successfully!");
        }
    }

    protected void rgAdminListDiagnosis_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindDiagnosis(true);
    }

    private void BindDiagnosis(bool IsRebind)
    {        
        DataTable dtDiagnosis = new AdministrationBAL().GetDiagnosis();
        rgAdminListDiagnosis.DataSource = dtDiagnosis;

        if (!IsRebind)
            rgAdminListDiagnosis.DataBind();
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

    protected void rgAdminListDiagnosis_ItemDataBound(object sender, GridItemEventArgs e)
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
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminListDiagnosis.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}