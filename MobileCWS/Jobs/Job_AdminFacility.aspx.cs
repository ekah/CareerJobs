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


public partial class Jobs_Job_AdminFacility : System.Web.UI.Page
{
    Job_FacilityBAL objFacilityBAL = new Job_FacilityBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _facid = 0;
    string _facility = string.Empty;

    bool _visibility = false;
    int _clientid = 0; // BotCode Admin
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("../Admin/AdminIndex.aspx");
        }

    }

    protected void rgFacilityJobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgFacilityJobs.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();
        ds = objFacilityBAL.SelectFacility();
        return ds;
    }

    protected void rgFacilityJobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {

            GridEditableItem edititem = e.Item as GridEditableItem;
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            _facid = Convert.ToInt32(edititem.OwnerTableView.DataKeyValues[edititem.ItemIndex]["facid"].ToString());
            _facility = (edititem["facility"].FindControl("rtbFacility") as RadTextBox).Text.Trim();
            //_facility = (edititem["facility"].Controls[0] as TextBox).Text;

            if (_facility == string.Empty)
            {
                ShowPopUpMsg("Please Enter Facility");
            }
            else if (rcbclient.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Client");
            }
            else
            {
                _clientid = Convert.ToInt32(rcbclient.SelectedValue);
                CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
                _visibility = chkVisibilty.Checked;

                _whocreated = string.Empty;
                if (Session["SignInId"] != null)
                {
                    _whoupdated = Session["SignInId"].ToString();
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
                               objFacilityBAL.InsertUpdateFacilityByClientId(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
                               rgFacilityJobs.Rebind();
                           }
                       }
                       else
                       {
                           objFacilityBAL.InsertUpdateFacilityByClientId(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
                           rgFacilityJobs.Rebind();
                       }

                   
                }
            }

        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rgFacilityJobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {

        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
        _facid = 0;
        _facility = (item["facility"].FindControl("rtbFacility") as RadTextBox).Text.Trim();
        //_facility = (item["facility"].Controls[0] as TextBox).Text;
        if (_facility == string.Empty)
        {
            ShowPopUpMsg("Please Enter Facility");
        }
        else if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else
        {
            CheckBox chkVisibilty = (CheckBox)item.FindControl("chkVisibilty");
            _visibility = chkVisibilty.Checked;
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);
            if (Session["SignInId"] != null)
            {
                _whocreated = Session["SignInId"].ToString();
            }
            _whoupdated = string.Empty;
            DataSet ds = objFacilityBAL.FacilitySelectByFacility(_clientid, _facility);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ShowPopUpMsg("Facility already exists");
            }
            else
            {
                objFacilityBAL.InsertUpdateFacilityByClientId(_facid, _facility, _visibility, _clientid, _whocreated, _whoupdated);
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
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
        _facid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["facid"].ToString());
        _clientid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["ClientId"].ToString());
        objFacilityBAL.DeleteFacility(_facid, _clientid);
        rgFacilityJobs.Rebind();

    }

    protected void rgFacilityJobs_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            ImageButton lnkDelete = (ImageButton)item.FindControl("imgdelete");
            Label lblfacility = (Label)item.FindControl("lblfacility");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure, Do you want to delete " + lblfacility.Text + " facility?');";
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

            _clientid = Convert.ToInt32(((System.Data.DataRowView)(dataitem.DataItem)).Row.ItemArray[4].ToString());
            _facid = Convert.ToInt32(((System.Data.DataRowView)(dataitem.DataItem)).Row.ItemArray[0].ToString());

            DataSet ds = objJobsBAL.FindJobsAssociateWithFacility(_clientid, _facid);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ImageButton imgdelete = (ImageButton)dataitem.FindControl("imgdelete");
                Label lblfacility = (Label)dataitem.FindControl("lblfacility");
                imgdelete.OnClientClick = "return confirm('Jobs Associated with " + lblfacility.Text + " facility.Do you want to delete this facility and jobs?')";

            }
            //else
            //{
            //    ImageButton imgdelete = (ImageButton)dataitem.FindControl("imgdelete");
            //    imgdelete.OnClientClick = "return confirm('Do you want to delete this Facility?')";

            //}

        }

        if (e.Item is GridEditFormInsertItem)
        {
            GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
            RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganization();

            if (dsclient.Tables.Count > 0 && dsclient.Tables[0].Rows.Count > 0)
            {
                rcbclient.DataSource = dsclient;
                rcbclient.DataTextField = "Client";
                rcbclient.DataValueField = "OrganizationId";
                rcbclient.DataBind();
            }


            RadComboBoxItem asclientListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbclient.Items.Insert(0, asclientListItem);
        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");

            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganization();

            if (dsclient.Tables.Count > 0 && dsclient.Tables[0].Rows.Count > 0)
            {
                rcbclient.DataSource = dsclient;
                rcbclient.DataTextField = "Client";
                rcbclient.DataValueField = "OrganizationId";
                rcbclient.DataBind();
            }

            rcbclient.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[4].ToString();

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
        Response.Redirect("../Admin/AdminIndex.aspx");
    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job_ManageAdmin.aspx");
    }

    protected void rgFacilityJobs_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        RadGrid item = (source as RadGrid);
        if (e.CommandName == RadGrid.InitInsertCommandName)
        {
            item.MasterTableView.ClearEditItems();
        }
        if (e.CommandName == RadGrid.EditCommandName)
        {
            e.Item.OwnerTableView.IsItemInserted = false;
        }
    }
}
