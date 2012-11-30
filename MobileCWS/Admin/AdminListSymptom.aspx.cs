using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Admin_AdminListSymptom : System.Web.UI.Page
{
    protected int SymptomType = 2;

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
        BindSymptom(false);
    }

    protected void rgAdminListSymptom_UpdateCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int symptomId = Convert.ToInt32(dataItem.GetDataKeyValue("SymptomId").ToString());

        TextBox txtSymptom = (TextBox)dataItem["Symptom"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];

        new AdministrationBAL().InsertSymptom(symptomId, txtSymptom.Text, txtDescription.Text);

        BindSymptom(false);

        ShowAlertMessage("Updated successfully!");
    }

    protected void rgAdminListSymptom_InsertCommand(object source, GridCommandEventArgs e)
    {
        GridEditableItem dataItem = (GridEditableItem)e.Item;

        int symptomId = 0;

        TextBox txtSymptom = (TextBox)dataItem["Symptom"].Controls[0];
        TextBox txtDescription = (TextBox)dataItem["Description"].Controls[0];

        if (txtSymptom.Text == string.Empty || txtDescription.Text == string.Empty)
        {
            ShowAlertMessage("Please enter the symptom and description to add!");
        }
        else
        {
            int IsSaved = new AdministrationBAL().InsertSymptom(symptomId, txtSymptom.Text, txtDescription.Text);
            if (IsSaved < 0)
                ShowAlertMessage("Entered Symptom is already exists!");
            else
            {
                ShowAlertMessage("New Symptom Saved successfully!");
            }
        }
        BindSymptom(false);
    }

    protected void rgAdminListSymptom_DeleteCommand(object source, GridCommandEventArgs e)
    {
        GridDataItem dataItem = (GridDataItem)e.Item;
        int symptomId = Convert.ToInt32(dataItem.GetDataKeyValue("SymptomId").ToString());
        bool IsDeleted = Convert.ToBoolean(dataItem["IsDeleted"].Text);

        int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(symptomId, SymptomType);// for symptom type is 2

        BindSymptom(false);
        if (isDeleted > 0)
        {
            ShowAlertMessage("Deleted Successfully!");
        }
    }

    protected void rgAdminListSymptom_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindSymptom(true);
    }

    private void BindSymptom(bool IsRebind)
    {
        DataTable dtSymptom = new AdministrationBAL().GetSymptom();
        rgAdminListSymptom.DataSource = dtSymptom;

        if (!IsRebind)
            rgAdminListSymptom.DataBind();
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

    protected void rgAdminListSymptom_ItemDataBound(object sender, GridItemEventArgs e)
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
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminListSymptom.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }
}