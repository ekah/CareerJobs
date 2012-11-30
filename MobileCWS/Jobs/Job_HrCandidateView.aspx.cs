using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_HrCandidateView : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _aid = 0;
    string _jobid = string.Empty;
    string _candidateName = string.Empty;
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
    string _applieddate = string.Empty;
    string _hrstatus = string.Empty;
    string _hrdateupdated = string.Empty;
    string _finalstatus = string.Empty;
    string _notes = string.Empty;
    int _clientid = 0;
    Job_CandidateViewBAL objCandidateViewBAL = new Job_CandidateViewBAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        if (Session["Login"] == null)
        {
            Response.Redirect("Job_HrLogin.aspx?cid=" + _clientid);
        }
    }
    protected void rgcandidate_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        rgcandidate.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        ds = objCandidateViewBAL.SelectCandidateByClientId(_clientid);


        return ds;
    }
    protected void rgcandidate_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridDataItem item = (GridDataItem)e.Item;
            _aid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["Aid"].ToString());

            objCandidateViewBAL.DeleteCandidateDetailsById(_aid);
            rgcandidate.Rebind();
        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rgcandidate_UpdateCommand(object sender, GridCommandEventArgs e)
    {
        GridEditableItem edititem = e.Item as GridEditableItem;
        _aid = Convert.ToInt32(edititem.GetDataKeyValue("Aid"));
        RadComboBox rdhrStatus = (RadComboBox)edititem.FindControl("rcbstatus");
        _hrstatus = rdhrStatus.SelectedValue;
        RadComboBox rdfinalstatus = (RadComboBox)edititem.FindControl("rcbfinalstatus");
        _finalstatus = rdfinalstatus.SelectedValue;
        RadEditor rdnotes = (RadEditor)edititem.FindControl("rcbnotes");
        _notes = rdnotes.Content;
        objCandidateViewBAL.UpdateCandidateDetails(_aid, _hrstatus, _finalstatus, _notes);
        rgcandidate.Rebind();

    }
    protected void rgcandidate_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem dataitem = (GridDataItem)e.Item;
            LinkButton lnkViewResume = (LinkButton)dataitem.FindControl("lnkViewResume");
            if (lnkViewResume.CommandArgument == "null")
            {
                lnkViewResume.Visible = false;
            }
        }
        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            edititem["jobid"].Enabled = false;
            edititem["candidatename"].Enabled = false;
            edititem["specialization"].Enabled = false;
            edititem["experience"].Enabled = false;
            RadComboBox rdhrStatus = (RadComboBox)edititem.FindControl("rcbstatus");
            rdhrStatus.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[25].ToString();
            RadComboBox rdfinalstatus = (RadComboBox)edititem.FindControl("rcbfinalstatus");
            rdfinalstatus.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[27].ToString();
            RadEditor rdnotes = (RadEditor)edititem.FindControl("rcbnotes");
            rdnotes.Content = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[28].ToString();
        }
    }
    protected void lnkViewResume_Click(object sender, EventArgs e)
    {
        string _Name = ((LinkButton)sender).CommandArgument;
        DownloadFile(_Name);

    }
    protected void DownloadFile(string name)
    {
        string _path = Request.PhysicalApplicationPath + "/jobs/" + name;
        System.IO.FileInfo _file = new System.IO.FileInfo(_path);
        if (_file.Exists)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + _file.Name);
            Response.AddHeader("Content-Length", _file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(_file.FullName);
            Response.End();
        }
        else
        {
            ClientScript.RegisterStartupScript(Type.GetType("System.String"), "messagebox", "&lt;script type=\"text/javascript\"&gt;alert('Sorry no Doc found');</script>");
        }
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        Response.Redirect("Job_HrLogin.aspx?cid=" + _clientid);
    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        Response.Redirect("Job_HrManageAdmin.aspx?cid=" + _clientid);

    }
}