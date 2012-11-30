using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using System.Text;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_HrJobs : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _clientid = 0;
    int _countryid = 0;
    int _stateid = 0;
    //int _cityid = 0;
    int _lid = 0;
    int _facilityid = 0;
    int _specialityid = 0;
    int _jid = 0;
    string _jobid = string.Empty;
    string _jobtitle = string.Empty;
    string _description = string.Empty;
    bool _visibility = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();

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
    protected void rgjobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgjobs.DataSource = GridDataSource();

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
            ds = objJobsBAL.JobSelectByClientID(_clientid,0); 
        return ds;
    }
    protected void rgjobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {

            GridEditableItem edititem = e.Item as GridEditableItem;
            RadComboBox rcbCountry = (RadComboBox)edititem.FindControl("rcbCountry");
            RadComboBox rcbState = (RadComboBox)edititem.FindControl("rcbState");
            RadComboBox rcbCity = (RadComboBox)edititem.FindControl("rcbCity");
            RadComboBox rcbFacility = (RadComboBox)edititem.FindControl("rcbfacility");
            RadComboBox rcbSpeciality = (RadComboBox)edititem.FindControl("rcbspeciality");
            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
            RadEditor rddescription = (RadEditor)edititem.FindControl("rddescription");

            _jid = Convert.ToInt32(edititem.GetDataKeyValue("Jid"));


            if (rcbSpeciality.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Speciality");
            }
            else if (rcbFacility.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Facility");
            }
            else if (rcbCountry.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Country");
            }
            else if (rcbState.Items.Count > 1 && rcbState.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select State");
            }
            else if (rcbCity.SelectedValue == "--Select--" && rcbCity.Items.Count > 1)
            {
                ShowPopUpMsg("Please Select City");
            }
            else
            {
                _jobid = (edititem["jobid"].FindControl("rtbJobId") as RadTextBox).Text.Trim();
                _jobtitle = (edititem["jobtitle"].FindControl("rtbJobTitle") as RadTextBox).Text.Trim();

                if (_jobtitle == string.Empty)
                {
                    ShowPopUpMsg("Please Enter JobTitle");
                }
                else
                {
                    //_countryid = Convert.ToInt32(rcbCountry.SelectedValue);
                    //if (rcbState.Items.Count > 1)
                    //{
                    //    _stateid = Convert.ToInt32(rcbState.SelectedItem.Value);
                    //}
                    //else
                    //{
                    //    _stateid = -1;
                    //}
                    if (rcbCity.Items.Count > 1)
                        _lid = Convert.ToInt32(rcbCity.SelectedValue);
                    else
                        _lid = Convert.ToInt32(rcbState.SelectedValue.ToString().Substring(rcbState.SelectedValue.ToString().IndexOf("-") + 1));
                    _facilityid = Convert.ToInt32(rcbFacility.SelectedValue);
                    _specialityid = Convert.ToInt32(rcbSpeciality.SelectedValue);
                    _visibility = chkVisibilty.Checked;
                    _description = rddescription.Content;
                    if (Request.QueryString["cid"] != null)
                    {
                        if (Request.QueryString["cid"].ToString() != string.Empty)
                        {
                            _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                        }
                    }
                    if (Session["User"] != null)
                    {
                        _whoupdated = Session["User"].ToString();
                    }                  
                    _whocreated = string.Empty;


                    objJobsBAL.InsertUpdateJob(_jobid, _jobtitle, _facilityid, _specialityid, _lid, _description, _visibility, _clientid, _whocreated, _whoupdated);
                    rgjobs.Rebind();
                }
            }

        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rgjobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        _jid = 0;
        RadComboBox rcbCountry = (RadComboBox)item.FindControl("rcbCountry");
        RadComboBox rcbState = (RadComboBox)item.FindControl("rcbState");
        RadComboBox rcbCity = (RadComboBox)item.FindControl("rcbCity");
        RadComboBox rcbFacility = (RadComboBox)item.FindControl("rcbfacility");
        RadComboBox rcbSpeciality = (RadComboBox)item.FindControl("rcbspeciality");
        RadEditor rddescription = (RadEditor)item.FindControl("rddescription");



        if (rcbFacility.SelectedItem.Value == "--Select--")
        {
            ShowPopUpMsg("Please Select Facility");
        }
        else if (rcbCountry.SelectedItem.Value == "--Select--")
        {
            ShowPopUpMsg("Please Select Country");
        }       
        else if (rcbState.Items.Count > 0 && rcbState.SelectedItem.Value == "--Select--")
        {

            ShowPopUpMsg("Please Select State");

        }
        else if (rcbCity.SelectedItem.Value == "--Select--" && rcbCity.Items.Count > 1)
        {
            ShowPopUpMsg("Please Select City");
        } 
        else if (rcbSpeciality.SelectedItem.Value == "--Select--")
        {
            ShowPopUpMsg("Please Select Speciality");
        }
        else
        {
            _jobid = (item["jobid"].FindControl("rtbJobId") as RadTextBox).Text.Trim();
            _jobtitle = (item["jobtitle"].FindControl("rtbJobTitle") as RadTextBox).Text.Trim();


            if (_jobid == string.Empty)
            {
                ShowPopUpMsg("Please Enter JobID");
            }
            else if (_jobtitle == string.Empty)
            {
                ShowPopUpMsg("Please Enter JobTitle");
            }
            else
            {
                _facilityid = Convert.ToInt32(rcbFacility.SelectedValue);
                _specialityid = Convert.ToInt32(rcbSpeciality.SelectedValue);
                _countryid = Convert.ToInt32(rcbCountry.SelectedValue);
                //if (rcbState.Items.Count > 0)
                //    _stateid = Convert.ToInt32(rcbState.SelectedItem.Value);
                //else
                //    _stateid = -1;
                if (rcbCity.Items.Count > 1)
                    _lid = Convert.ToInt32(rcbCity.SelectedValue);
                else
                    _lid = Convert.ToInt32(rcbState.SelectedValue.ToString().Substring(rcbState.SelectedValue.ToString().IndexOf("-") + 1));
                    //_cityid = -1;
                //_lid = Convert.ToInt32(rcbCity.SelectedValue);
                _description = rddescription.Content;
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
                DataSet ds = objJobsBAL.SelectJobByJobId(_jobid, _clientid);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ShowPopUpMsg("Job already exists");
                }
                else
                {
                    objJobsBAL.InsertUpdateJob(_jobid, _jobtitle, _facilityid, _specialityid, _lid, _description, _visibility, _clientid, _whocreated, _whoupdated);
                    rgjobs.Rebind();
                }
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
    protected void rgjobs_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridDataItem item = (GridDataItem)e.Item;
            _jid = Convert.ToInt32(item.GetDataKeyValue("Jid"));
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            objJobsBAL.DeleteJobByClientId(_jid, _clientid);
            rgjobs.Rebind();
        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rgjobs_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridEditFormInsertItem)
        {
            GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }


            // Facility
            RadComboBox ddlfacility = (RadComboBox)item.FindControl("rcbfacility");
            DataSet dsfacility = objJobsBAL.FacilitySelectByClientIDVisible(_clientid);

            if (dsfacility.Tables.Count > 0 && dsfacility.Tables[0].Rows.Count > 0)
            {
                ddlfacility.DataSource = dsfacility;
                ddlfacility.DataTextField = "Facility";
                ddlfacility.DataValueField = "FacId";
                ddlfacility.DataBind();
            }


            RadComboBoxItem asfacilityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlfacility.Items.Insert(0, asfacilityListItem);

            // Speciality

            RadComboBox ddlspeciality = (RadComboBox)item.FindControl("rcbspeciality");
            DataSet dsspeciality = objJobsBAL.SpecialitySelectByClientIDVisible(_clientid);

            if (dsspeciality.Tables.Count > 0 && dsspeciality.Tables[0].Rows.Count > 0)
            {
                ddlspeciality.DataSource = dsspeciality;
                ddlspeciality.DataTextField = "Speciality";
                ddlspeciality.DataValueField = "SpcId";
                ddlspeciality.DataBind();
            }


            RadComboBoxItem asspecialityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlspeciality.Items.Insert(0, asspecialityListItem);

            // Country

            RadComboBox ddlcountry = (RadComboBox)item.FindControl("rcbCountry");
            DataSet dscountry = objJobsBAL.CountrySelectInStateByClientIDVisible(_clientid);

            if (dscountry.Tables.Count > 0 && dscountry.Tables[0].Rows.Count > 0)
            {
                ddlcountry.DataSource = dscountry;
                ddlcountry.DataTextField = "CountryName";
                ddlcountry.DataValueField = "CountryId";
                ddlcountry.DataBind();
            }


            RadComboBoxItem ascountryListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlcountry.Items.Insert(0, ascountryListItem);



            RadComboBox rdState = (RadComboBox)item.FindControl("rcbState");
            RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
            rdState.Items.Insert(0, asstateListItem);

            RadComboBox rdCity = (RadComboBox)item.FindControl("rcbCity");
            RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
            rdCity.Items.Insert(0, ascityListItem);
        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            edititem["jobid"].Enabled = false;
            RadComboBox ddlcountry = (RadComboBox)edititem.FindControl("rcbCountry");

            // Country
            DataSet dscountry = objJobsBAL.CountrySelectInStateByClientIDVisible(_clientid);
            if (dscountry.Tables.Count > 0 && dscountry.Tables[0].Rows.Count > 0)
            {
                ddlcountry.DataSource = dscountry;
                ddlcountry.DataTextField = "CountryName";
                ddlcountry.DataValueField = "CountryId";
                ddlcountry.DataBind();
            }
            else
            {
                ddlcountry.DataSource = null;
                ddlcountry.DataBind();

            }


            RadComboBoxItem ascountryListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlcountry.Items.Insert(0, ascountryListItem);

            ddlcountry.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[7].ToString();
         

            // Facility

            RadComboBox ddlfacility = (RadComboBox)edititem.FindControl("rcbfacility");
            DataSet dsfacility = objJobsBAL.FacilitySelectByClientIDVisible(_clientid);

            if (dsfacility.Tables.Count > 0 && dsfacility.Tables[0].Rows.Count > 0)
            {
                ddlfacility.DataSource = dsfacility;
                ddlfacility.DataTextField = "Facility";
                ddlfacility.DataValueField = "FacId";
                ddlfacility.DataBind();
            }


            RadComboBoxItem asfacilityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlfacility.Items.Insert(0, asfacilityListItem);

            ddlfacility.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[3].ToString();

            // Speciality

            RadComboBox ddlspeciality = (RadComboBox)edititem.FindControl("rcbspeciality");
            DataSet dsspeciality = objJobsBAL.SpecialitySelectByClientIDVisible(_clientid);

            if (dsspeciality.Tables.Count > 0 && dsspeciality.Tables[0].Rows.Count > 0)
            {
                ddlspeciality.DataSource = dsspeciality;
                ddlspeciality.DataTextField = "Speciality";
                ddlspeciality.DataValueField = "SpcId";
                ddlspeciality.DataBind();
            }


            RadComboBoxItem asspecialityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlspeciality.Items.Insert(0, asspecialityListItem);

            ddlspeciality.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[5].ToString();

            // State

            RadComboBox rdState = (RadComboBox)edititem.FindControl("rcbState");
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            _countryid = Convert.ToInt32(ddlcountry.SelectedValue);
            rdState.Items.Clear();
            DataSet dsstate = objJobsBAL.StateSelectInStateByClientIDVisibleByAdmin(_clientid, _countryid);
            if (dsstate.Tables.Count > 0 && dsstate.Tables[0].Rows.Count > 0)
            {
                rdState.DataSource = dsstate;
                rdState.DataTextField = "StateName";
                rdState.DataValueField = "StateId";
                rdState.DataBind();
                RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
                rdState.Items.Insert(0, asstateListItem);
                rdState.Items.FindItemByText(((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[10].ToString()).Selected = true;
            }
            else
            {
                rdState.DataSource = null;
                rdState.DataBind();
                RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
                rdState.Items.Insert(0, asstateListItem);
            }

            if (rdState.SelectedValue.ToString().Contains("-"))
                rdState.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[9].ToString() + "-" + ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[21].ToString();
            else
                rdState.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[9].ToString();

            RadComboBox rdCity = (RadComboBox)edititem.FindControl("rcbCity");

            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            _countryid = Convert.ToInt32(ddlcountry.SelectedValue);
            if (rdState.Items.Count > 1)
            {
                if (rdState.SelectedItem.Value.ToString().Contains("-"))
                    _stateid = Convert.ToInt32(rdState.SelectedItem.Value.ToString().Substring(0, rdState.SelectedItem.Value.ToString().IndexOf("-")));
                else
                    _stateid = Convert.ToInt32(rdState.SelectedItem.Value);
                edititem["state"].Parent.Visible = true; 
            }
            else
            {
                _stateid = -1;
                edititem["state"].Parent.Visible = false; 
            }
            rdCity.Items.Clear();
            DataSet dscity = objJobsBAL.CitySelectByClientIDCountryStateIDVisibleByAdmin(_clientid, _countryid, _stateid);
            if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
            {
                rdCity.DataSource = dscity;
                rdCity.DataTextField = "CityName";
                rdCity.DataValueField = "Lid";
                rdCity.DataBind();
                RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                rdCity.Items.Insert(0, ascityListItem);
            }
            else
            {
                rdCity.DataSource = null;
                rdCity.DataBind();
                RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                edititem["city"].Parent.Visible = false;
                rdCity.Items.Insert(0, ascityListItem);
            }

            rdCity.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[21].ToString();

            RadEditor rddescription = (RadEditor)edititem.FindControl("rddescription");
            rddescription.Content = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[13].ToString();

            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[14].ToString() == "True")
            {
                chkVisibilty.Checked = true;
            }
            else
            {
                chkVisibilty.Checked = false;
            }

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

    }
    protected void rcbcountry_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rdCountry = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rdCountry.NamingContainer;
        RadComboBox rdState = (RadComboBox)editItem.FindControl("rcbState");
        RadComboBox rdCity = (RadComboBox)editItem.FindControl("rcbCity");
        if (rdCountry.SelectedValue != "--Select--")
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            _countryid = Convert.ToInt32(rdCountry.SelectedValue);
            rdState.Items.Clear();
            _stateid = -1;
            string[] strArrCountryids = ("2,12,15,18,26,29,35,51,54,66,75,87,93,96,98,117,121,123,133,135,136,140,148,156,158,162,163,176,181,187,188,199,205,212,218,219").Split(',');
            if (strArrCountryids.Contains(_countryid.ToString()))
            {
                DataSet dscity = objJobsBAL.CitySelectByClientIDCountryStateIDVisibleByAdmin(_clientid, _countryid, _stateid);
                if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
                {
                    rdCity.DataSource = dscity;
                    rdCity.DataTextField = "CityName";
                    rdCity.DataValueField = "Lid";
                    rdCity.DataBind();
                    RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                    rdCity.Items.Insert(0, ascityListItem);
                }
                else
                {
                    rdCity.DataSource = null;
                    rdCity.DataBind();
                    RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                    rdCity.Items.Insert(0, ascityListItem);
                }

                editItem["state"].Parent.Visible = false;

            }
            else
            {
                DataSet dsstate = objJobsBAL.StateSelectInStateByClientIDVisibleByAdmin(_clientid, _countryid);
                if (dsstate.Tables.Count > 0 && dsstate.Tables[0].Rows.Count > 0)
                {
                    rdState.DataSource = dsstate;
                    rdState.DataTextField = "StateName";
                    rdState.DataValueField = "StateId";
                    rdState.DataBind();
                    RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
                    rdState.Items.Insert(0, asstateListItem);
                }
                else
                {
                    rdState.DataSource = null;
                    rdState.DataBind();
                    RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
                    rdState.Items.Insert(0, asstateListItem);
                }

                editItem["state"].Parent.Visible = true;
                editItem["city"].Parent.Visible = true;
            }     
        }
        else
        {
            ShowPopUpMsg("Please Select Country");
        }


    }
    protected void rcbstate_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rdState = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rdState.NamingContainer;
        RadComboBox rdCity = (RadComboBox)editItem.FindControl("rcbCity");
        RadComboBox rcbCountry = (RadComboBox)editItem.FindControl("rcbCountry");
        if (rcbCountry.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Country");
        }
        else if (rdState.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select State");
        }
        else
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            _countryid = Convert.ToInt32(rcbCountry.SelectedValue);
            if (rdState.SelectedValue.ToString().Contains("-"))
            {
                _stateid = Convert.ToInt32(rdState.SelectedValue.ToString().Substring(0, rdState.SelectedValue.ToString().IndexOf("-")));
            }
            else
                _stateid = Convert.ToInt32(rdState.SelectedValue);
            //_stateid = Convert.ToInt32(rdState.SelectedValue.ToString().Substring(0, rdState.SelectedValue.ToString().IndexOf("-")));
            //_stateid = Convert.ToInt32(rdState.SelectedValue);
            rdCity.Items.Clear();
            DataSet dscity = objJobsBAL.CitySelectByClientIDCountryStateIDVisibleByAdmin(_clientid, _countryid, _stateid);
            if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
            {
                rdCity.DataSource = dscity;
                rdCity.DataTextField = "CityName";
                rdCity.DataValueField = "Lid";
                rdCity.DataBind();
                RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                rdCity.Items.Insert(0, ascityListItem);
            }
            else
            {
                rdCity.DataSource = null;
                rdCity.DataBind();
                RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                rdCity.Items.Insert(0, ascityListItem);
                editItem["city"].Parent.Visible = false;
            }
        }

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
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        Session["Login"] = null;
        Response.Redirect("Jobs/Job_HrLogin.aspx?cid=" + _clientid); 
    }
}