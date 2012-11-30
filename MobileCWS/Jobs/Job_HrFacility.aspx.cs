using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Text;
using System.Data;


public partial class Jobs_Job_HrFacility : System.Web.UI.Page
{
    Job_FacilityBAL objFacilityBAL = new Job_FacilityBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _facid = 0;
    string _facility = string.Empty;
    bool _visibility = false;
    int _clientid = 0;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            Response.Redirect("Job_HrLogin.aspx?cid=" + _clientid); 
        }        

    }

    protected void rgFacilityJobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {

        rgFacilityJobs.DataSource = GridDataSource();
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
            ds = objFacilityBAL.FacilitySelectByClientID(_clientid);

       
        return ds;
    }

    protected void rgFacilityJobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {       

            GridEditableItem edititem = e.Item as GridEditableItem;
            _facid = Convert.ToInt32(edititem.OwnerTableView.DataKeyValues[edititem.ItemIndex]["facid"].ToString());
            _facility = (edititem["facility"].Controls[0] as TextBox).Text;

            if (_facility == string.Empty)
            {
                ShowPopUpMsg("Please Enter Facility");
            }
            else
            {
                CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
                _visibility = chkVisibilty.Checked;
                if (Request.QueryString["cid"] != null)
                {
                    if (Request.QueryString["cid"].ToString() != string.Empty)
                    {
                        _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                    }
                }
                _whocreated = string.Empty;
                if (Session["User"] != null)
                {
                    _whoupdated = Session["User"].ToString();
                }

                  DataSet ds = objFacilityBAL.FacilitySelectByFacid(_facid, _clientid, _facility);
                  if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                  {
                      ShowPopUpMsg("Facility already exists");
                  }
                  else
                  {
                        DataSet dsvis = objJobsBAL.FindJobsAssociateWithFacility(_clientid, _facid);
                        if (dsvis.Tables.Count > 0 && dsvis.Tables[0].Rows.Count > 0)
                        {
                            if (_visibility == false)
                            {
                                ShowPopUpMsg("Jobs Associated with this Facility.So You cannot set Visibility false.");
                            }
                            else
                            {
                                objFacilityBAL.InsertUpdateFacility(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
                                rgFacilityJobs.Rebind();
                            }                           
                        }
                        else
                        {
                            objFacilityBAL.InsertUpdateFacility(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
                            rgFacilityJobs.Rebind();
                        }
                  }
            }

       
    }
    protected void rgFacilityJobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {

        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        _facid = 0;
        _facility = (item["facility"].Controls[0] as TextBox).Text;
        if (_facility == string.Empty)
        {
            ShowPopUpMsg("Please Enter Facility");
        }
        else
        {
            CheckBox chkVisibilty = (CheckBox)item.FindControl("chkVisibilty");
            _visibility = chkVisibilty.Checked;
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            if (Session["User"] != null)
            {
                _whocreated = Session["User"].ToString();
            }
            _whoupdated = string.Empty;
            DataSet ds = objFacilityBAL.FacilitySelectByFacility(_clientid, _facility);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ShowPopUpMsg("Facility already exists");
            }
            else
            {
                objFacilityBAL.InsertUpdateFacility(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
                rgFacilityJobs.Rebind();
            }
        }
    }

    private void ShowPopUpMsg(string msg)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("alert('");
        sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
        sb.Append("');");
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
    }

    protected void rgFacilityJobs_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        
            GridDataItem item = (GridDataItem)e.Item;
            _facid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["facid"].ToString());
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            objFacilityBAL.DeleteFacility(_facid, _clientid);
            rgFacilityJobs.Rebind();
       
    }

    protected void rgFacilityJobs_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridCommandItem)
        {           
            Button addButton = e.Item.FindControl("AddNewRecordButton") as Button;
            addButton.Visible = false;
            LinkButton lnkButton = (LinkButton)e.Item.FindControl("InitInsertButton");
            lnkButton.Visible = false;               
        }

        if (e.Item is GridDataItem)
        {
            GridDataItem dataitem = (GridDataItem)e.Item;
            Label lbvisibility = (Label)dataitem.FindControl("lbvisibility");
            Image imgVisibility = (Image)dataitem.FindControl("imgVisibility");

            if (lbvisibility.Text == "True")
            {
                imgVisibility.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibility.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");          
            edititem["facility"].Enabled = false;           

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[2].ToString() == "True")
            {
                chkVisibilty.Checked = true;
            }
            else
            {
                chkVisibilty.Checked = false;
            }
                   
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
        Response.Redirect("Jobs/Job_HrLogin.aspx?cid=" + _clientid); 
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
        Response.Redirect("~/Jobs/Job_HrManageAdmin.aspx?cid=" + _clientid); 
    }
}
