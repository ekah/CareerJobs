using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Text;
using System.Data;
using MedAppointments.BusinessAccessLayer;


public partial class Jobs_Job_HrLocation : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    Job_LocationBAL objLocationBAL = new Job_LocationBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _ctid = 0;
    int _countryid = 0;
    int _cityid = 0;
    int _stateid = 0;
    int _lid = 0;
    string _country = string.Empty;
    bool _visibility = false;
    int _clientid = 0;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
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


    public DataSet populatecountry()
    {
        DataSet dscountry = objLocationBAL.SelectMasterCountry();
        return dscountry;
    }

    public DataSet populatestate(int countryid)
    {
        DataSet dsstate = objLocationBAL.SelectMasterStateByCountryID(countryid);
        return dsstate;
    }
    public DataSet populatecity(int countryid, int stateid)
    {
        DataSet dscity = objLocationBAL.SelectMasterCityByCountryStateID(countryid, stateid);
        return dscity;
    }


    protected void rglocationjobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rglocationjobs.DataSource = GridDataSource();
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
        ds = objLocationBAL.SelectLocationByClientId(_clientid);
        return ds;
    }

    protected void rglocationjobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem edititem = e.Item as GridEditableItem;
            _ctid = Convert.ToInt32(edititem.GetDataKeyValue("Lid"));
            RadComboBox rcbCountry = (RadComboBox)edititem.FindControl("rcbCountry");
            RadComboBox rcbState = (RadComboBox)edititem.FindControl("rcbState");
            RadComboBox rcbCity = (RadComboBox)edititem.FindControl("rcbCity");
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            if (Session["User"] != null)
            {
                _whoupdated = Session["User"].ToString();
            }
            if (rcbCountry.SelectedItem.Text == "--Select--")
            {
                ShowPopUpMsg("Please Select Country");
            }
            else if (rcbState.SelectedItem != null)
            {
                if (rcbState.SelectedItem.Value == "--Select--")
                {
                    ShowPopUpMsg("Please Select State");
                }
                else if (rcbCity.SelectedItem.Value == "--Select--" && rcbCity.Items.Count > 1)
                {
                    ShowPopUpMsg("Please Select City");
                }
                else
                {
                    _countryid = Convert.ToInt32(rcbCountry.SelectedItem.Value);
                    if (rcbState.Items.Count > 0)
                        _stateid = Convert.ToInt32(rcbState.SelectedItem.Value);
                    else
                        _stateid = -1;
                    if (rcbCity.Items.Count > 1)
                        _cityid = Convert.ToInt32(rcbCity.SelectedItem.Value);
                    else
                        _cityid = -1;
                    //_cityid = Convert.ToInt32(rcbCity.SelectedItem.Value);
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
                    DataSet ds = objLocationBAL.LocationSelectByLId(_ctid, _clientid, _countryid, _stateid, _cityid);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        ShowPopUpMsg("Location already exists");
                    }
                    else
                    {
                        DataSet dsvis = objJobsBAL.FindJobsAssociateWithLocation(_clientid, _ctid);
                        if (dsvis.Tables.Count > 0 && dsvis.Tables[0].Rows.Count > 0)
                        {
                            if (_visibility == false)
                            {
                                ShowPopUpMsg("Jobs Associated with this Location.So You cannot set Visibility false.");
                            }
                            else
                            {
                                objLocationBAL.InsertUpdateLocation(_ctid, _countryid, _stateid, _cityid, _visibility, _clientid, _whocreated, _whoupdated);
                                rglocationjobs.Rebind();
                            }
                        }
                        else
                        {
                            objLocationBAL.InsertUpdateLocation(_ctid, _countryid, _stateid, _cityid, _visibility, _clientid, _whocreated, _whoupdated);
                            rglocationjobs.Rebind();
                        }
                    }
                }
            }
            else if (rcbCity.SelectedItem.Value == "--Select--")
            {
                ShowPopUpMsg("Please Select City");
            }      
            else
            {
                _countryid = Convert.ToInt32(rcbCountry.SelectedItem.Value);
                if (rcbState.Items.Count > 0)
                    _stateid = Convert.ToInt32(rcbState.SelectedItem.Value);
                else
                    _stateid = -1;
                if (rcbCity.Items.Count > 1)
                    _cityid = Convert.ToInt32(rcbCity.SelectedItem.Value);
                else
                    _cityid = -1;
                //_cityid = Convert.ToInt32(rcbCity.SelectedItem.Value);
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
                DataSet ds = objLocationBAL.LocationSelectByLId(_ctid, _clientid, _countryid, _stateid, _cityid);
                  if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                  {
                      ShowPopUpMsg("Location already exists");
                  }
                  else
                  {
                      DataSet dsvis = objJobsBAL.FindJobsAssociateWithLocation(_clientid, _ctid);
                      if (dsvis.Tables.Count > 0 && dsvis.Tables[0].Rows.Count > 0)
                      {
                          if (_visibility == false)
                          {
                              ShowPopUpMsg("Jobs Associated with this Location.So You cannot set Visibility false.");
                          }
                          else
                          {
                              objLocationBAL.InsertUpdateLocation(_ctid, _countryid, _stateid, _cityid, _visibility, _clientid, _whocreated, _whoupdated);
                              rglocationjobs.Rebind();
                          }
                      }
                      else 
                      {
                             objLocationBAL.InsertUpdateLocation(_ctid, _countryid, _stateid, _cityid, _visibility, _clientid, _whocreated, _whoupdated);
                             rglocationjobs.Rebind();
                      }
                  }
            }
        }
        catch
        {
            e.Canceled = true;
        }

    }
    protected void rglocationjobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        _ctid = 0;
        RadComboBox rcbCountry = (RadComboBox)item.FindControl("rcbCountry");
        RadComboBox rcbState = (RadComboBox)item.FindControl("rcbState");
        RadComboBox rcbCity = (RadComboBox)item.FindControl("rcbCity");
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
        if (rcbCountry.SelectedItem.Value == "--Select--")
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
        else
        {
            _countryid = Convert.ToInt32(rcbCountry.SelectedItem.Value);
            if (rcbState.Items.Count > 0)
                _stateid = Convert.ToInt32(rcbState.SelectedItem.Value);
            else
                _stateid = -1;
            if (rcbCity.Items.Count > 1)
                _cityid = Convert.ToInt32(rcbCity.SelectedItem.Value);
            else
                _cityid = -1;
            CheckBox chkVisibilty = (CheckBox)item.FindControl("chkVisibilty");
            _visibility = chkVisibilty.Checked;
            //_cityid = Convert.ToInt32(rcbCity.SelectedValue);
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
            DataSet ds = objLocationBAL.LocationSelectByIds(_clientid, _countryid, _stateid, _cityid);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ShowPopUpMsg("Location already exists");
            }
            else
            {
                objLocationBAL.InsertUpdateLocation(_ctid, _countryid, _stateid, _cityid, _visibility, _clientid, _whocreated, _whoupdated);
                rglocationjobs.Rebind();
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
    protected void rglocationjobs_ItemDataBound(object sender, GridItemEventArgs e)
    {

        if (e.Item is GridCommandItem)
        {
            Button addButton = e.Item.FindControl("AddNewRecordButton") as Button;
            addButton.Visible = false;
            LinkButton lnkButton = (LinkButton)e.Item.FindControl("InitInsertButton");
            lnkButton.Visible = false;
        }

        if (e.Item is GridEditFormInsertItem)
        {
            GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
          

            RadComboBox ddlcountry = (RadComboBox)item.FindControl("rcbCountry");
            DataSet dscountry = populatecountry();
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
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            RadComboBox ddlcountry = (RadComboBox)edititem.FindControl("rcbCountry");
            DataSet dscountry = populatecountry();
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
            ddlcountry.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[2].ToString();
            ddlcountry.Enabled = false;
            RadComboBox rdState = (RadComboBox)edititem.FindControl("rcbState");
            RadComboBox rdCity = (RadComboBox)edititem.FindControl("rcbCity");
            _countryid = Convert.ToInt32(ddlcountry.SelectedValue);
            rdState.Items.Clear();
            string[] strArrCountryids = ("2,12,15,18,26,29,35,51,54,66,75,87,93,96,98,117,121,123,133,135,136,140,148,156,158,162,163,176,181,187,188,199,205,212,218,219").Split(',');

            if (strArrCountryids.Contains(_countryid.ToString()))
            {
                DataSet dscity = populatestate(_countryid);
                rdCity.Items.Clear();
                if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
                {
                    rdCity.DataSource = dscity;
                    rdCity.DataTextField = "CityName";
                    rdCity.DataValueField = "CityId";
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
                rdCity.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[7].ToString();
                edititem["StateName"].Parent.Visible = false;

            }
            else
            {

                DataSet dsstate = populatestate(_countryid);
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
                rdState.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[3].ToString();

                if (Session["SignInOrganizationId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
                }
                _countryid = Convert.ToInt32(ddlcountry.SelectedValue);
                _stateid = Convert.ToInt32(rdState.SelectedValue);
                rdCity.Items.Clear();
                DataSet dscity = populatecity(_countryid, _stateid);
                if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
                {
                    rdCity.DataSource = dscity;
                    rdCity.DataTextField = "CityName";
                    rdCity.DataValueField = "CityId";
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
                    edititem["CityName"].Parent.Visible = false;
                }
                rdCity.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[7].ToString();
            }
            CheckBox chkVisibilty = (CheckBox)edititem.FindControl("chkVisibilty");
            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[8].ToString() == "True")
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
    protected void rcbCountry_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadComboBox rdCountry = (RadComboBox)o;
        GridEditFormItem editItem = (GridEditFormItem)rdCountry.NamingContainer;
        RadComboBox rdState = (RadComboBox)editItem.FindControl("rcbState");
        RadComboBox rcbclient = (RadComboBox)editItem.FindControl("rcbclient");
        RadComboBox rdCity = (RadComboBox)editItem.FindControl("rcbCity");

        if (rdCountry.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Country");
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
            _countryid = Convert.ToInt32(rdCountry.SelectedValue);
            rdState.Items.Clear();
            string[] strArrCountryids = ("2,12,15,18,26,29,35,51,54,66,75,87,93,96,98,117,121,123,133,135,136,140,148,156,158,162,163,176,181,187,188,199,205,212,218,219").Split(',');
            if (strArrCountryids.Contains(_countryid.ToString()))
            {
                DataSet dscity = populatestate(_countryid);

                if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
                {
                    rdCity.DataSource = dscity;
                    rdCity.DataTextField = "CityName";
                    rdCity.DataValueField = "CityId";
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

                editItem["StateName"].Parent.Visible = false;
            }
            else
            {
                rdState.Items.Clear();
                DataSet dsstate = populatestate(_countryid);
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
                editItem["StateName"].Parent.Visible = true;
                editItem["CityName"].Parent.Visible = true;
            }
        }

    }
    protected void rcbState_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
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
            _stateid = Convert.ToInt32(rdState.SelectedValue);
            rdCity.Items.Clear();
            DataSet dscity = populatecity(_countryid, _stateid);
            if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
            {
                rdCity.DataSource = dscity;
                rdCity.DataTextField = "CityName";
                rdCity.DataValueField = "CityId";
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
}