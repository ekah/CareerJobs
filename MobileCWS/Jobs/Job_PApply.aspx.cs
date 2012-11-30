using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Telerik.Web.UI;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using System.Text.RegularExpressions;
using System.IO;


public partial class Jobs_Job_PApply : System.Web.UI.Page
{

    int _clientid = 0;
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    Job_ApplyBAL objApplyBAL = new Job_ApplyBAL();
    string _jobid = string.Empty;
    string _candidatename = string.Empty;
    string _age = string.Empty;
    string _sex = string.Empty;
    string _permanentAddress = string.Empty;
    string _email = string.Empty;
    string _city = string.Empty;
    string _district = string.Empty;
    string _state = string.Empty;
    string _country = string.Empty;
    string _aboutUs = string.Empty;
    string _contactPhone = string.Empty;
    string _contactMobile = string.Empty;
    string _bestTime = string.Empty;
    string _specialization = string.Empty;
    string _experience = string.Empty;
    string _highestQualification = string.Empty;
    string _highestDegree = string.Empty;
    string _currentEmployer = string.Empty;
    string _existingPay = string.Empty;
    string _desiredPay = string.Empty;
    string _willing = string.Empty;
    string _uploadResume = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateValues();
        }

    }
    public void PopulateValues()
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        DataSet dsSpecialization = objJobsBAL.SpecialitySelectByClientIDVisible(_clientid);

        if (dsSpecialization.Tables.Count > 0 && dsSpecialization.Tables[0].Rows.Count > 0)
        {
            rdSpecialization.DataSource = dsSpecialization;
            rdSpecialization.DataTextField = "Speciality";
            rdSpecialization.DataValueField = "SpcId";
            rdSpecialization.DataBind();

            RadComboBoxItem aspecialityListItem = new RadComboBoxItem("All", "All");
            rdSpecialization.Items.Insert(0, aspecialityListItem);
        }

    }
    private void ShowMessage(string Message)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("alert('");
        //sb.Append(count.ToString());
        sb.Append(Message + "');");
        sb.Append("</script>");
        //ScriptManager.RegisterStartupScript(this.Page,this.GetType(), "script", sb.ToString(),true);
        ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{0}');", Message), true);
    }
    protected void btnSumbit_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["jobid"] != null)
        {
            _jobid = Request.QueryString["jobid"].ToString();
            _candidatename = txtname.Text.Trim();
            _age = txtage.Text.Trim();
            if (rdSex.Items.Count > 0)
            {
                _sex = rdSex.SelectedValue;
            }
            _permanentAddress = txtpermanentaddress.Text.Trim();
            _email = txtemail.Text.Trim();
            _city = txtCity.Text.Trim();
            _district = txtdistrict.Text.Trim();
            _state = txtState.Text.Trim();
            _country = txtCountry.Text.Trim();
            if (rdhowabt.Items.Count > 0)
            {
                _aboutUs = rdhowabt.SelectedValue;
            }
            _contactPhone = txtHometelephone2.Text.Trim();
            _contactMobile = txtMobile.Text.Trim();
            _bestTime = rdtimetocall.SelectedDate.Value.ToString();
            if (rdSpecialization.Items.Count > 0)
            {
                _specialization = rdSpecialization.SelectedItem.Text;
            }
            if (rdExperience.Items.Count > 0)
            {
                _experience = rdExperience.SelectedValue;
            }
            if (rdHighestQualification.Items.Count > 0)
            {
                _highestQualification = rdHighestQualification.SelectedValue;
            }
            _highestDegree = txtHightestDegree.Text.Trim();
            _currentEmployer = txtCurrentEmployer.Text.Trim();
            _existingPay = txtexistingpay.Text.Trim();
            _desiredPay = txtdesiredpay.Text.Trim();
            if (rdwilling.Items.Count > 0)
            {
                _willing = rdwilling.SelectedValue;
            }

            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }


            string clientfilepath = "ResumeUpload/" + _clientid.ToString();

            if (!Directory.Exists(clientfilepath))
            {
                Directory.CreateDirectory(Server.MapPath(clientfilepath));
            }


            string filename = Path.GetFileName(CollapseSpaces(fileuploadresume.FileName.Trim()));

            string filepath = CollapseSpaces(clientfilepath + "/" + Guid.NewGuid().ToString().Replace("-", "") + filename.Trim());

            fileuploadresume.SaveAs(Server.MapPath(filepath));

            if (filename == string.Empty)
            {
                _uploadResume = "null";
            }
            else
            {
                _uploadResume = filepath;
            }

            objApplyBAL.InsertApply(_jobid, _candidatename, _age, _sex, _permanentAddress, _email, _city, _district, _state, _country, _aboutUs, _contactPhone, _contactMobile, _bestTime, _specialization, _experience, _highestQualification, _highestDegree, _currentEmployer, _existingPay, _desiredPay, _willing, _uploadResume, _clientid);
            //ShowMessage("Thank you applying a job.");
            divInput.Visible = false;
            divThankyou.Visible = true;

        }
    }

    protected void btnBackToSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Hospital.aspx");
    }

    protected void btnThankyou_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Hospital.aspx");
    }

    public static string CollapseSpaces(string str)
    {
        try
        {
            return new Regex(@"\s*").Replace(str, string.Empty);
        }
        catch (Exception)
        {
            return str;
        }

    }
}