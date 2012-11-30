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

public partial class Jobs_Job_AdminJobs : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _clientid = 0;
    int _countryid = 0;
    int _stateid = 0;
    int _cityid = 0;
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
        if (Session["Login"] == null)
        {
            Response.Redirect("../Admin/AdminIndex.aspx");
        }
    }
    protected void rgjobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgjobs.DataSource = GridDataSource();

    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet(); 
        ds = objJobsBAL.SelectJob();       
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
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
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
            else if (rcbState.Items.Count > 1 && rcbState.SelectedItem.Value == "--Select--")
            {
                ShowPopUpMsg("Please Select State");
            }
            else if (rcbCity.Items.Count > 1 && rcbCity.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select City");
            }
            else
            {
                _jobid = (edititem["jobid"].FindControl("rtbJobId") as RadTextBox).Text.Trim();
                _jobtitle = (edititem["jobtitle"].FindControl("rtbJobTitle") as RadTextBox).Text.Trim();
                //_jobid = (edititem["jobid"].Controls[0] as TextBox).Text;
                //_jobtitle = (edititem["jobtitle"].Controls[0] as TextBox).Text;

                if (_jobtitle == string.Empty)
                {
                    ShowPopUpMsg("Please Enter JobTitle");
                }
                else
                {
                    if (rcbCity.Items.Count > 1)
                        _lid = Convert.ToInt32(rcbCity.SelectedValue);
                    else
                        _lid = Convert.ToInt32(rcbState.SelectedItem.Value.ToString().Substring(rcbState.SelectedItem.Value.ToString().IndexOf("-") + 1));
                    _facilityid = Convert.ToInt32(rcbFacility.SelectedValue);
                    _specialityid = Convert.ToInt32(rcbSpeciality.SelectedValue);
                    _visibility = chkVisibilty.Checked;
                    _description = rddescription.Content;
                    _clientid = Convert.ToInt32(rcbclient.SelectedValue);
                    if (Session["SignInId"] != null)
                    {
                        _whoupdated = Session["SignInId"].ToString();
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
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");


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
        else if (rcbCity.Items.Count > 1 && rcbCity.SelectedItem.Value == "--Select--")
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
            //_jobid = (item["jobid"].Controls[0] as TextBox).Text;
            //_jobtitle = (item["jobtitle"].Controls[0] as TextBox).Text;


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
                if (rcbCity.Items.Count > 1)
                    _lid = Convert.ToInt32(rcbCity.SelectedValue);
                else
                    _lid = Convert.ToInt32(rcbState.SelectedItem.Value.ToString().Substring(rcbState.SelectedItem.Value.ToString().IndexOf("-") + 1));             
                _description = rddescription.Content;
                CheckBox chkVisibilty = (CheckBox)item.FindControl("chkVisibilty");
                _visibility = chkVisibilty.Checked;
                _clientid = Convert.ToInt32(rcbclient.SelectedValue);
                if (Session["SignInId"] != null)
                {
                    _whocreated = Session["SignInId"].ToString();
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
            _clientid = Convert.ToInt32(item.GetDataKeyValue("ClientId"));
            
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

            // Facility
            RadComboBox ddlfacility = (RadComboBox)item.FindControl("rcbfacility");
            RadComboBoxItem asfacilityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlfacility.Items.Insert(0, asfacilityListItem);

            // Speciality

            RadComboBox ddlspeciality = (RadComboBox)item.FindControl("rcbspeciality");           
            RadComboBoxItem asspecialityListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlspeciality.Items.Insert(0, asspecialityListItem);

            // Country

            RadComboBox ddlcountry = (RadComboBox)item.FindControl("rcbCountry");           
            RadComboBoxItem ascountryListItem = new RadComboBoxItem("--Select--", "--Select--");
            ddlcountry.Items.Insert(0, ascountryListItem);

            //State
            RadComboBox rdState = (RadComboBox)item.FindControl("rcbState");
            RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
            rdState.Items.Insert(0, asstateListItem);

            //City
            RadComboBox rdCity = (RadComboBox)item.FindControl("rcbCity");
            RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
            rdCity.Items.Insert(0, ascityListItem);
        }

        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            LinkButton lnkDelete = (LinkButton)item.FindControl("lnkDelete");
            Label lblJobId = (Label)item.FindControl("lblJobId");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure you want to delete Job Id " + lblJobId.Text + "?');";
        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;
            edititem["jobid"].Enabled = false;
            RadComboBox ddlcountry = (RadComboBox)edititem.FindControl("rcbCountry");

            //ClientID
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
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
            rcbclient.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[15].ToString();
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);

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
           
             _countryid = Convert.ToInt32(ddlcountry.SelectedValue);
          

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
            if (Session["SignInOrganizationId"] != null)
            {
                _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
            }
            
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


            RadComboBox rdCity = (RadComboBox)edititem.FindControl("rcbCity");

            if (Session["SignInOrganizationId"] != null)
            {
                _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
            }
            _countryid = Convert.ToInt32(ddlcountry.SelectedValue);          
           
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
                edititem["city"].Parent.Visible = false;
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
    protected void rcbclient_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rcbclient = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rcbclient.NamingContainer;
        RadComboBox rcbCountry = (RadComboBox)editItem.FindControl("rcbCountry");
        RadComboBox rcbState = (RadComboBox)editItem.FindControl("rcbState");
        RadComboBox rcbcity = (RadComboBox)editItem.FindControl("rcbCity");
        RadComboBox rcbspeciality = (RadComboBox)editItem.FindControl("rcbspeciality");
        RadComboBox ddlfacility = (RadComboBox)editItem.FindControl("rcbfacility");

        if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else
        {
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);
          

            //Country
            rcbCountry.Items.Clear();           
            DataSet dscountry = objJobsBAL.CountrySelectInStateByClientIDVisible(_clientid);
            if (dscountry.Tables.Count > 0 && dscountry.Tables[0].Rows.Count > 0)
            {
                rcbCountry.DataSource = dscountry;
                rcbCountry.DataTextField = "CountryName";
                rcbCountry.DataValueField = "CountryId";
                rcbCountry.DataBind();
            }
            RadComboBoxItem ascountryListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbCountry.Items.Insert(0, ascountryListItem);

           
            //State
            rcbState.Items.Clear();
            RadComboBoxItem asstateListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbState.Items.Insert(0, asstateListItem);

            //City
            rcbcity.Items.Clear();
            RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbcity.Items.Insert(0, ascityListItem);

            // Speciality        
            rcbspeciality.Items.Clear();
            DataSet dsspeciality = objJobsBAL.SpecialitySelectByClientIDVisible(_clientid);
            if (dsspeciality.Tables.Count > 0 && dsspeciality.Tables[0].Rows.Count > 0)
            {
                rcbspeciality.DataSource = dsspeciality;
                rcbspeciality.DataTextField = "Speciality";
                rcbspeciality.DataValueField = "SpcId";
                rcbspeciality.DataBind();
            }
            RadComboBoxItem asspecialityListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbspeciality.Items.Insert(0, asspecialityListItem);


            // Facility
            ddlfacility.Items.Clear();
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


        }

    }
    protected void rcbcountry_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rdCountry = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rdCountry.NamingContainer;
        RadComboBox rdState = (RadComboBox)editItem.FindControl("rcbState");
        RadComboBox rdCity = (RadComboBox)editItem.FindControl("rcbCity");
        RadComboBox rcbclient = (RadComboBox)editItem.FindControl("rcbclient");

        if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else  if(rdCountry.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Country");
        }
        else 
        {
            _countryid = Convert.ToInt32(rdCountry.SelectedValue);
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);
            _lid = Convert.ToInt32(rdCountry.SelectedValue);
            rdState.Items.Clear();
           
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
                    editItem["city"].Parent.Visible = true;
                }
                else
                {
                    rdCity.DataSource = null;
                    rdCity.DataBind();
                    RadComboBoxItem ascityListItem = new RadComboBoxItem("--Select--", "--Select--");
                    rdCity.Items.Insert(0, ascityListItem);
                    editItem["city"].Parent.Visible = false;
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

    }
    protected void rcbstate_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rdState = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rdState.NamingContainer;
        RadComboBox rdCity = (RadComboBox)editItem.FindControl("rcbCity");
        RadComboBox rcbCountry = (RadComboBox)editItem.FindControl("rcbCountry");
        RadComboBox rcbclient = (RadComboBox)editItem.FindControl("rcbclient");
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
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);
            _countryid = Convert.ToInt32(rcbCountry.SelectedValue);
            if (rdState.SelectedValue.ToString().Contains("-"))
            {
                _stateid = Convert.ToInt32(rdState.SelectedValue.ToString().Substring(0, rdState.SelectedValue.ToString().IndexOf("-")));
            }
            else
                _stateid = Convert.ToInt32(rdState.SelectedValue);
         


            rdCity.Items.Clear();
            DataSet dscity = objJobsBAL.CitySelectByClientIDCountryStateIDVisibleByAdmin(_clientid, _countryid,_stateid);
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
      Response.Redirect("Job_ManageAdmin.aspx");            
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("../Admin/AdminIndex.aspx");
    }

    protected void rgjobs_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
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