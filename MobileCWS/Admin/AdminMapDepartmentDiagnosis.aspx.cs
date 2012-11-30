using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;

public partial class Admin_MapDepartmentDiagnosis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DefaultSettings();
        }
    }

    private void DefaultSettings()
    {
        BindDepartment();
        BindDiagnosis();
        BindSymptom();        
        //LoadSelectedDiagnosis();
        btnSave.Visible = false;
        btnSaveSymptom.Visible = false;
    }

    private void BindDepartment()
    {
        ddlDepartment.DataSource = new MasterBAL().GetDepartment();
        ddlDepartment.DataTextField = "DepartmentName";
        ddlDepartment.DataValueField = "DepartmentId";
        ddlDepartment.DataBind();        
    }

    private void BindDiagnosis()
    {
        DataTable dtDiagnosis = new MasterBAL().GetDiagnosis();

        rlbDiagnosisList.DataSource = dtDiagnosis;
        rlbDiagnosisList.DataTextField = "Diagnosis";
        rlbDiagnosisList.DataValueField = "DiagnosisId";
        rlbDiagnosisList.DataBind();

        rcbDiagnosisList.DataSource = dtDiagnosis;
        rcbDiagnosisList.DataTextField = "Diagnosis";
        rcbDiagnosisList.DataValueField = "DiagnosisId";
        rcbDiagnosisList.DataBind();

        rcbDiagnosisList.Items.Insert(0, new RadComboBoxItem("Select Diagnosis", "0"));
        rcbDiagnosisList.SelectedIndex = 0;

        SortDiagnosis();
    }

    private void BindSymptom()
    {
        DataTable dtSymptoms = new MasterBAL().GetSymptom();

        rlbSymptomList.DataSource = dtSymptoms;
        rlbSymptomList.DataTextField = "Symptom";
        rlbSymptomList.DataValueField = "SymptomId";
        rlbSymptomList.DataBind();

        rcbSymptomList.DataSource = dtSymptoms;
        rcbSymptomList.DataTextField = "Symptom";
        rcbSymptomList.DataValueField = "SymptomId";
        rcbSymptomList.DataBind();

        rcbSymptomList.Items.Insert(0, new RadComboBoxItem("Select Symptom", "0"));
        rcbSymptomList.SelectedIndex = 0;

        SortSymptom();
    }

    private void SortTreatment()
    {
        rlbTreatmentList.Sort = RadListBoxSort.Ascending;
        rlbTreatmentList.SortItems();
    }

    private void SortDiagnosis()
    {
        rlbDiagnosisList.Sort = RadListBoxSort.Ascending;
        rlbDiagnosisList.SortItems();
        rlbSelectedDiagnosisList.Sort = RadListBoxSort.Ascending;
        rlbSelectedDiagnosisList.SortItems();
        rcbDiagnosisList.Sort = RadComboBoxSort.Ascending;
        rcbDiagnosisList.SortItems();
    }

    private void SortSymptom()
    {
        rlbSymptomList.Sort = RadListBoxSort.Ascending;
        rlbSymptomList.SortItems();
        rlbSelectedSymptomList.Sort = RadListBoxSort.Ascending;
        rlbSelectedSymptomList.SortItems();
        rcbSymptomList.Sort = RadComboBoxSort.Ascending;
        rcbSymptomList.SortItems();
    }

    private void LoadSelectedDiagnosis()
    {
        lblInfo.Visible = false;
        lblInfoSymptom.Visible = false;
        btnSaveSymptom.Visible = false;
        btnSave.Visible = false;

        rlbSelectedDiagnosisList.Items.Clear();
        int departmentId = Convert.ToInt32(ddlDepartment.SelectedItem.Value);

        DataTable dtDiagnosis = new DoctorBAL().GetDiagnosisByDepartmentId(departmentId);
        rlbSelectedDiagnosisList.DataSource = dtDiagnosis;
        rlbSelectedDiagnosisList.DataTextField = "Diagnosis";
        rlbSelectedDiagnosisList.DataValueField = "DiagnosisId";
        rlbSelectedDiagnosisList.DataBind();

        foreach (DataRow dr in dtDiagnosis.Rows)
        {
            rlbDiagnosisList.FindItemByText(dr["Diagnosis"].ToString()).Remove();
        }

        SortDiagnosis();
    }

    private void LoadSelectedTreatment()
    {
        lblInfo.Visible = false;
        lblInfoSymptom.Visible = false;
        btnSaveSymptom.Visible = false;
        btnSave.Visible = false;

        rlbTreatmentList.Items.Clear();
        int departmentId = Convert.ToInt32(ddlDepartment.SelectedItem.Value);

        DataTable dtTreatment = new AdministrationBAL().GetTreatmentByDepartmentId(departmentId);
        rlbTreatmentList.DataSource = dtTreatment;
        rlbTreatmentList.DataTextField = "Diagnosis";
        rlbTreatmentList.DataValueField = "DiagnosisId";
        rlbTreatmentList.DataBind();

        SortTreatment();
    }

    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDiagnosis();

        LoadSelectedTreatment();

        LoadSelectedDiagnosis();

        rlbSelectedSymptomList.Items.Clear();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {        
        lblInfo.Visible = false;
        if (rlbDiagnosisList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbDiagnosisList.SelectedItems)
            {
                if (list.Selected)
                {
                    rlbSelectedDiagnosisList.Items.Add(new RadListBoxItem(list.Text, list.Value));
                    rcbDiagnosisList.FindItemByValue(rlbDiagnosisList.SelectedValue).Remove();
                    list.Remove();                    
                }
            }
        }

        btnSave.Visible = true;

        SortDiagnosis();
    }

    protected void rcbbtnAddSymptom_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(rcbSymptomList.SelectedValue) > 0)
        {
            rlbSelectedSymptomList.Items.Add(new RadListBoxItem(rcbSymptomList.SelectedItem.Text, rcbSymptomList.SelectedItem.Value));
            rlbSymptomList.FindItemByValue(rcbSymptomList.SelectedValue).Remove();
            rcbSymptomList.FindItemByValue(rcbSymptomList.SelectedValue).Remove();
            rcbSymptomList.SelectedIndex = 0;
        }
        btnSaveSymptom.Visible = true;
    }

    protected void rcbbtnAddDiagnosis_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(rcbDiagnosisList.SelectedValue) > 0)
        {
            rlbSelectedDiagnosisList.Items.Add(new RadListBoxItem(rcbDiagnosisList.SelectedItem.Text, rcbDiagnosisList.SelectedItem.Value));
            rlbDiagnosisList.FindItemByValue(rcbDiagnosisList.SelectedValue).Remove();
            rcbDiagnosisList.FindItemByValue(rcbDiagnosisList.SelectedValue).Remove();
            rcbDiagnosisList.SelectedIndex = 0;
        }
        btnSave.Visible = true;
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        rlbSelectedSymptomList.Items.Clear();

        lblInfo.Visible = false;
        if (rlbSelectedDiagnosisList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbSelectedDiagnosisList.SelectedItems)
            {
                if (list.Selected)
                {
                    rlbDiagnosisList.Items.Add(new RadListBoxItem(list.Text, list.Value));                    

                    if (rcbDiagnosisList.Items.FindItemByValue(rlbSelectedDiagnosisList.SelectedValue) == null)
                        rcbDiagnosisList.Items.Add(new RadComboBoxItem(list.Text, list.Value));

                    list.Remove();
                }
            }
        }

        btnSave.Visible = true;        

        SortDiagnosis();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        List<SymptomDO> listSymptom = new List<SymptomDO>();

        int departmentId = Convert.ToInt16(ddlDepartment.SelectedItem.Value);
        foreach (RadListBoxItem item in rlbSelectedDiagnosisList.Items)
        {
                SymptomDO s = new SymptomDO();
                s.DepartmentId = departmentId;
                s.DiagnosisId = Convert.ToInt32(item.Value);
                listSymptom.Add(s);
         }

        bool isSaved = new DoctorBAL().SaveDepartmentDiagnosis(listSymptom, departmentId); //Save Department Diagnosis List
        if (isSaved)
        {
            btnSave.Visible = false;
            lblInfo.Visible = true;
            lblInfo.Text = "<br/>Saved Successfully!";
        }
    }

    protected void btnAddSymptom_Click(object sender, EventArgs e)
    {
        lblInfoSymptom.Visible = false;
        if (rlbSymptomList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbSymptomList.SelectedItems)
            {
                if (list.Selected)
                {
                    rlbSelectedSymptomList.Items.Add(new RadListBoxItem(list.Text, list.Value));
                    rcbSymptomList.FindItemByValue(rlbSymptomList.SelectedValue).Remove();

                    list.Remove();                    
                }
            }
        }

        btnSaveSymptom.Visible = true;

        SortSymptom();
    }

    protected void btnRemoveSymptom_Click(object sender, EventArgs e)
    { 
        lblInfoSymptom.Visible = false;
        if (rlbSelectedSymptomList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbSelectedSymptomList.SelectedItems)
            {
                if (list.Selected)
                {
                    rlbSymptomList.Items.Add(new RadListBoxItem(list.Text, list.Value));                    

                    if (rcbSymptomList.Items.FindItemByValue(rlbSelectedSymptomList.SelectedValue) == null)
                        rcbSymptomList.Items.Add(new RadComboBoxItem(list.Text, list.Value));

                    list.Remove();
                }
            }
        }

        btnSaveSymptom.Visible = true;

        SortSymptom();
    }

    protected void btnSaveSymptom_Click(object sender, EventArgs e)
    {
        List<SymptomDO> listSymptom = new List<SymptomDO>();


        int diagnosisId = Convert.ToInt32(rlbSelectedDiagnosisList.SelectedItem.Value);
        foreach (RadListBoxItem item in rlbSelectedSymptomList.Items)
        {
            SymptomDO s = new SymptomDO();
            s.DiagnosisId = diagnosisId;
            s.SymptomId = Convert.ToInt32(item.Value);
            listSymptom.Add(s);
        }

        bool isSaved = new DoctorBAL().SaveSymptomDiagnosis(listSymptom, diagnosisId); //Save symptom Diagnosis List
        if (isSaved)
        {
            btnSaveSymptom.Visible = false;
            lblInfoSymptom.Visible = true;
            lblInfoSymptom.Text = "<br/>Saved Successfully!";
        }        
    }

    protected void rlbSelectedDiagnosisList_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblInfoSymptom.Visible = false;
        lblInfo.Visible = false;
        btnSaveSymptom.Visible = false;

        BindSymptom();

        rlbSelectedSymptomList.Items.Clear();
        int diagnosisId = Convert.ToInt32(rlbSelectedDiagnosisList.SelectedItem.Value);

        DataTable dtSymptom = new DoctorBAL().GetSymptomByDiagnosisId(diagnosisId);
        rlbSelectedSymptomList.DataSource = dtSymptom;
        rlbSelectedSymptomList.DataTextField = "Symptom";
        rlbSelectedSymptomList.DataValueField = "SymptomId";
        rlbSelectedSymptomList.DataBind();

        if (dtSymptom.Rows.Count > 0)
        {
            foreach (DataRow dr in dtSymptom.Rows)
            {
                rlbSymptomList.FindItemByText(dr["Symptom"].ToString()).Remove();
            }
        }

        SortSymptom();
    }


    protected void btnAddNewSymptom_Click(object sender, EventArgs e)
    {
        if (txtSymptom.Text != string.Empty && txtDescriptionSymptom.Text != string.Empty)
        {
            int isSaved = new AdministrationBAL().InsertSymptom(0, txtSymptom.Text, txtDescriptionSymptom.Text);
            if (isSaved < 0)
            {
                cvNewSymptom.IsValid = false;
            }
        }
        else
        {
            cvEmptySymptom.IsValid = false;
        }
        txtSymptom.Text = "";
        txtDescriptionSymptom.Text = "";
        BindSymptom();
    }

    protected void btnDeleteSymptom_Click(object sender, EventArgs e)
    {
        if (rlbSymptomList.SelectedItems.Count > 0)
        {           
            foreach (RadListBoxItem list in rlbSymptomList.SelectedItems)
            {
                if (list.Selected)
                {
                    int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(Convert.ToInt32(list.Value), 2); //for symptoms type is 2
                }
            }
        }
        else
        {
            cvDeleteSymptom.ErrorMessage = "Please select a symptom from Symptoms list to delete.";
            cvDeleteSymptom.IsValid = false;
        }
        BindSymptom();
    }

    protected void btnAddNewDiagnosis_Click(object sender, EventArgs e)
    {
        if (txtDiagnosis.Text != string.Empty && txtDescriptionDiagnosis.Text != string.Empty)
        {
            int isSaved = new AdministrationBAL().InsertDiagnosis(0, txtDiagnosis.Text, txtDescriptionDiagnosis.Text);
            if (isSaved < 0)
            {
                cvNewDiagnosis.IsValid = false;
            }
        }
        else
        {
            cvEmptyDiagnosis.IsValid = false;
        }
        txtDiagnosis.Text = "";
        txtDescriptionDiagnosis.Text = "";
        BindDiagnosis();
    }

    protected void btnDeleteDiagnosis_Click(object sender, EventArgs e)
    {
        if (rlbDiagnosisList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbDiagnosisList.SelectedItems)
            {
                if (list.Selected)
                {
                    int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(Convert.ToInt32(list.Value), 1); //for diagnosis type is 1
                }
            }
        }
        else
        {
            cvDeleteDiagnosis.ErrorMessage = "Please select a diagnosis from Diagnosis list to delete.";
            cvDeleteDiagnosis.IsValid = false;
        }
        rlbSelectedSymptomList.Items.Clear();
        rlbSelectedDiagnosisList.Items.Clear();

        BindDiagnosis();
    }

    protected void btnAddNewDepartments_Click(object sender, EventArgs e)
    {
        if (txtDepartment.Text != string.Empty && txtDescriptionDepartment.Text != string.Empty)
        {
            int isSaved = new AdministrationBAL().InsertDepartment(0, txtDepartment.Text, txtDescriptionDepartment.Text);
            if (isSaved < 0)
            {
                cvNewDepartment.IsValid = false;
            }
        }
        else
        {
            cvEmptyDepatment.IsValid = false;
        }
        txtDepartment.Text = "";
        txtDescriptionDepartment.Text = "";
        BindDepartment();
    }

    protected void btnDeleteDepartment_Click(object sender, EventArgs e)
    {
        if (ddlDepartment.SelectedIndex > 0)
        {
            int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(Convert.ToInt32(ddlDepartment.SelectedValue), 0); //for department type is 0            
        }
        else
        {
            cvDeleteDepartment.ErrorMessage = "Please select one department from Department list to delete.";
            cvDeleteDepartment.IsValid = false;
        }
        rlbSelectedSymptomList.Items.Clear();
        rlbSelectedDiagnosisList.Items.Clear();
        rlbTreatmentList.Items.Clear();

        BindDepartment();
    }

    protected void rlbTreatmentList_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void btnDeleteTreatment_Click(object sender, EventArgs e)
    {
        if (rlbTreatmentList.SelectedItems.Count > 0)
        {
            foreach (RadListBoxItem list in rlbTreatmentList.SelectedItems)
            {
                if (list.Selected)
                {
                    int isDeleted = new AdministrationBAL().DeleteDepartmentDiagnosisSymptomByDirectId(Convert.ToInt32(list.Value), 1); //for diagnosis type is 1
                    LoadSelectedTreatment();
                }
            }
        }
        else
        {
            cvDeleteTreatment.ErrorMessage = "Please select a treatment from the treatment list to delete.";
            cvDeleteTreatment.IsValid = false;
        }
    }

    protected void btnAddTreatment_Click(object sender, EventArgs e)
    {
        string[] treatment = null;

        if (rtbtreatment.Text.Trim() != string.Empty)
        {
            if (ddlDepartment.SelectedIndex > 0)
            {
                int i = 0;
                int IsSaved = 0;

                treatment = rtbtreatment.Text.ToString().Split(',');

                for ( ; i < treatment.Length; i++)
                {
                    IsSaved = new AdministrationBAL().InsertTreatment(Convert.ToInt32(ddlDepartment.SelectedItem.Value), treatment[i].ToString().Trim());

                    if (IsSaved < 0 )
                    {
                        ShowAlertMessage("Entered treatment (" + treatment[i].ToString() +") already exists!");
                        break;
                    }
                    else
                        continue;
                }
                if ((i == treatment.Length) && IsSaved > 0)
                {
                    ShowAlertMessage("New treatment saved successfully!");
                    rtbtreatment.Text = "";
                    LoadSelectedTreatment();
                }
            }
            else
            {
                cvAddTreatment.ErrorMessage = "Please select one department to map these treatment(s)!";
                cvAddTreatment.IsValid = false;
                return;
            }
        }
        else
        {
            cvAddTreatment.ErrorMessage = "Please enter treatment(s) to add!";
            cvAddTreatment.IsValid = false;
            return;
        }
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
}
