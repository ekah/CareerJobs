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

public partial class Jobs_Job_AdminSpeciality : System.Web.UI.Page
{
    Job_SpecialityBAL objSpecialityBAL = new Job_SpecialityBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _spcid = 0;
    int _specialityid = 0;
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
            Response.Redirect("../Admin/AdminIndex.aspx");
        }

    }
    public void PopulateMasterSpeciality(RadComboBox rcbSpeciality)
    {
        DataSet dsSpeciality = objSpecialityBAL.SelectMasterSpeciality();

        if (dsSpeciality.Tables.Count > 0 && dsSpeciality.Tables[0].Rows.Count > 0)
        {
            rcbSpeciality.DataSource = dsSpeciality;
            rcbSpeciality.DataTextField = "DepartmentName";
            rcbSpeciality.DataValueField = "DepartmentId";
            rcbSpeciality.DataBind();
        }
        RadComboBoxItem CountryListItem = new RadComboBoxItem("--Select--", "--Select--");
        rcbSpeciality.Items.Insert(0, CountryListItem);
    }
    protected void rgSpecialityjobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgSpecialityjobs.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();
        ds = objSpecialityBAL.SelectSpeciality();
        return ds;
    }
    protected void rgSpecialityjobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {

            GridEditableItem edititem = e.Item as GridEditableItem;
            _spcid = Convert.ToInt32(edititem.OwnerTableView.DataKeyValues[edititem.ItemIndex]["SpcId"].ToString());
            RadComboBox rcbSpeciality = (RadComboBox)edititem.FindControl("rcbSpeciality");
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            if (rcbSpeciality.SelectedItem.Value == "--Select--")
            {
                ShowPopUpMsg("Please Select Speciality");
            }
            else if (rcbclient.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Client");
            }
            else
            {
                _specialityid = Convert.ToInt32(rcbSpeciality.SelectedItem.Value);
                CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
                _visibility = chkVisibilty.Checked;
                _clientid = Convert.ToInt32(rcbclient.SelectedValue);
                _whocreated = string.Empty;
                if (Session["SignInId"] != null)
                {
                    _whoupdated = Session["SignInId"].ToString();
                }

                DataSet ds = objSpecialityBAL.SpecialitySelectBySpcId(_spcid, _clientid, _specialityid);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ShowPopUpMsg("Speciality already exists");
                }
                else
                {
                    DataSet dsvis = objJobsBAL.FindJobsAssociateWithSpeciality(_clientid, _spcid);
                    if (dsvis.Tables.Count > 0 && dsvis.Tables[0].Rows.Count > 0)
                    {
                        if (_visibility == false)
                        {
                            ShowPopUpMsg("Jobs Associated with this Speciality.So You cannot set Visibility false.");
                        }
                        else
                        {
                            objSpecialityBAL.InsertUpdateSpecialityByClientId(_spcid, _specialityid, _visibility, _clientid, _whocreated, _whoupdated);
                            rgSpecialityjobs.Rebind();
                        }
                    }
                    else
                    {
                        objSpecialityBAL.InsertUpdateSpecialityByClientId(_spcid, _specialityid, _visibility, _clientid, _whocreated, _whoupdated);
                        rgSpecialityjobs.Rebind();
                    }


                }
            }

        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rgSpecialityjobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        _spcid = 0;
        RadComboBox rcbSpeciality = (RadComboBox)item.FindControl("rcbSpeciality");
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");

        if (rcbSpeciality.SelectedItem.Value == "--Select--")
        {
            ShowPopUpMsg("Please Select Speciality");
        }
        else if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else
        {
            _specialityid = Convert.ToInt32(rcbSpeciality.SelectedItem.Value);

            CheckBox chkVisibilty = (CheckBox)item.FindControl("chkVisibilty");
            _visibility = chkVisibilty.Checked;
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);

            if (Session["SignInId"] != null)
            {
                _whocreated = Session["SignInId"].ToString();
            }
            _whoupdated = string.Empty;
            DataSet ds = objSpecialityBAL.SpecialitySelectBySpeciality(_clientid, _specialityid);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ShowPopUpMsg("Speciality already exists");
            }
            else
            {
                objSpecialityBAL.InsertUpdateSpecialityByClientId(_spcid, _specialityid, _visibility, _clientid, _whocreated, _whoupdated);
                rgSpecialityjobs.Rebind();
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

    protected void rgSpecialityjobs_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridDataItem item = (GridDataItem)e.Item;
            _spcid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["SpecialityId"].ToString());
            _clientid = Convert.ToInt32(item.OwnerTableView.DataKeyValues[item.ItemIndex]["OrganizationId"].ToString());
            objSpecialityBAL.DeleteSpeciality(_spcid, _clientid);
            rgSpecialityjobs.Rebind();
        }
        catch
        {
            e.Canceled = true;
        }
    }

    protected void rgSpecialityjobs_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            ImageButton lnkDelete = (ImageButton)item.FindControl("imgdelete");
            Label lblSpeciality = (Label)item.FindControl("lblSpeciality");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure, Do you want to delete " + lblSpeciality.Text + " speciality?');";
        }

        if (e.Item is GridEditFormInsertItem)
        {
            GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
            RadComboBox rcbSpeciality = (RadComboBox)item.FindControl("rcbSpeciality");
            PopulateMasterSpeciality(rcbSpeciality);

            RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganizationBasedOnFacility();

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

            _clientid = Convert.ToInt32(((System.Data.DataRowView)(dataitem.DataItem)).Row.ItemArray[10].ToString());
            _spcid = Convert.ToInt32(((System.Data.DataRowView)(dataitem.DataItem)).Row.ItemArray[0].ToString());               

            DataSet ds = objJobsBAL.FindJobsAssociateWithSpeciality(_clientid, _spcid);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ImageButton imgdelete = (ImageButton)dataitem.FindControl("imgdelete");
                Label lblSpeciality = (Label)dataitem.FindControl("lblSpeciality");
                imgdelete.OnClientClick = "javascript:return confirm('Jobs Associated with " + lblSpeciality.Text + " Speciality.Do you want to delete this Speciality and Jobs?')";

            }
            //else
            //{
            //    ImageButton imgdelete = (ImageButton)dataitem.FindControl("imgdelete");
            //    imgdelete.OnClientClick = "return confirm('Do you want to delete this Speciality?')";

            //}


        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[3].ToString() == "True")
            {
                chkVisibilty.Checked = true;
            }
            else
            {
                chkVisibilty.Checked = false;
            }

            RadComboBox rcbSpeciality = (RadComboBox)edititem.FindControl("rcbSpeciality");
            PopulateMasterSpeciality(rcbSpeciality);

            rcbSpeciality.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[1].ToString();

            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganizationBasedOnFacility();

            if (dsclient.Tables.Count > 0 && dsclient.Tables[0].Rows.Count > 0)
            {
                rcbclient.DataSource = dsclient;
                rcbclient.DataTextField = "Client";
                rcbclient.DataValueField = "OrganizationId";
                rcbclient.DataBind();
            }

            rcbclient.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[10].ToString();
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

    protected void rgSpecialityjobs_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
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