using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;
using Telerik.Web.UI;


public partial class Job_JobSearchHome : System.Web.UI.UserControl
{
    Job_SearchWidgetColVisibleBAL objSearchWidgetColVisibleBAL = new Job_SearchWidgetColVisibleBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _clientid = 0;
    string _countryid = string.Empty;
    int _stateid = 0;   
    public const string strfirstitemFacility = "Choose a Facility";
    public const string strfirstitemCountry = "Choose a Country";
    public const string strfirstitemState = "Choose a State";
    public const string strfirstitemCity = "Choose a City";
    public const string strfirstitemSpeciality = "Choose a Speciality";
    string strFacility = string.Empty;
    string strCountry = string.Empty;
    string strState = string.Empty;
    string strCity = string.Empty;
    string strSpeciality = string.Empty;
    string strkeyword = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            PopulateValues();
            Displayfields();
        }
    }

    public void Displayfields()
    {

        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet dsdisplay = objSearchWidgetColVisibleBAL.SWColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                divCountry.Visible = true;
            }
            else
            {
                divCountry.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                divState.Visible = true;
            }
            else
            {
                divState.Visible = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                divCity.Visible = true;
            }
            else
            {
                divCity.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                divFacility.Visible = true;
            }
            else
            {
                divFacility.Visible = false;
            }

        }
    }

    public void PopulateValues()
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        populatecountry(_clientid);
        RadComboBoxItem asstateListItem = new RadComboBoxItem(strfirstitemState, strfirstitemState);
        rcbstate.Items.Insert(0, asstateListItem);
        RadComboBoxItem ascityListItem = new RadComboBoxItem(strfirstitemCity, strfirstitemCity);
        rcbcity.Items.Insert(0, ascityListItem);
        populatefacility(_clientid);
        populatespeciality(_clientid);
    }

    public void populatecountry(int _clientid)
    {
        DataSet dscountry = objJobsBAL.CountrySelectByClientIDVisible(_clientid);

        rcbcountry.Items.Clear();

        if (dscountry.Tables.Count > 0 && dscountry.Tables[0].Rows.Count > 0)
        {
            rcbcountry.DataSource = dscountry;
            rcbcountry.DataTextField = "CountryName";
            rcbcountry.DataValueField = "CountryName";
            rcbcountry.DataBind();
        }
        else
        {
            rcbcountry.DataSource = null;
            rcbcountry.DataBind();

        }

        RadComboBoxItem ascountryListItem = new RadComboBoxItem(strfirstitemCountry, strfirstitemCountry);
        rcbcountry.Items.Insert(0, ascountryListItem);
        Displayfields();
    }

    public void populatestate(int _clientid)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        if (rcbcountry.SelectedValue != strfirstitemCountry)
        {
            _countryid = rcbcountry.SelectedValue;
        }
        rcbstate.Items.Clear();
        DataSet dsstate = objJobsBAL.StateSelectInStateByClientIDVisible(_clientid, _countryid);
        if (dsstate.Tables.Count > 0 && dsstate.Tables[0].Rows.Count > 0)
        {
            rcbstate.DataSource = dsstate;
            rcbstate.DataTextField = "StateName";
            rcbstate.DataValueField = "StateId";
            rcbstate.DataBind();
            divState.Visible = true;
        }
        else
        {
            rcbstate.DataSource = null;
            rcbstate.DataBind();
            divState.Visible = false;
            populatecity(_clientid);
        }

        RadComboBoxItem asstateListItem = new RadComboBoxItem(strfirstitemState, strfirstitemState);
        rcbstate.Items.Insert(0, asstateListItem);
        Displayfields();
    }

    public void populatecity(int _clientid)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }

        if (rcbcountry.SelectedValue != strfirstitemCountry)
        {
            _countryid =rcbcountry.SelectedValue;
        }
        if (divState.Visible)
        {
            if (rcbstate.SelectedValue != strfirstitemState)
            {
                _stateid = Convert.ToInt32(rcbstate.SelectedValue);
            }
        }

        rcbcity.Items.Clear();

        DataSet dscity = objJobsBAL.CitySelectByClientIDCountryStateIDVisible(_clientid, _countryid, _stateid);
        if (dscity.Tables.Count > 0 && dscity.Tables[0].Rows.Count > 0)
        {
            rcbcity.DataSource = dscity;
            rcbcity.DataTextField = "CityName";
            rcbcity.DataValueField = "CityId";
            rcbcity.DataBind();
            rcbcity.Visible = true;

        }
        else
        {
            rcbcity.DataSource = null;
            rcbcity.DataBind();
            rcbcity.Visible = false;
        }
        RadComboBoxItem ascityListItem = new RadComboBoxItem(strfirstitemCity, strfirstitemCity);
        rcbcity.Items.Insert(0, ascityListItem);
        Displayfields();
    }
    public void populatefacility(int _clientid)
    {
        DataSet dsfacility = objJobsBAL.FacilitySelectByClientIDVisibleInJobs(_clientid);
        rcbfacility.Items.Clear();
        if (dsfacility.Tables.Count > 0 && dsfacility.Tables[0].Rows.Count > 0)
        {
            rcbfacility.DataSource = dsfacility;
            rcbfacility.DataTextField = "Facility";
            rcbfacility.DataValueField = "FacId";
            rcbfacility.DataBind();
        }
        else
        {
            rcbfacility.DataSource = null;
            rcbfacility.DataBind();
        }
        RadComboBoxItem asfacilityListItem = new RadComboBoxItem(strfirstitemFacility, strfirstitemFacility);
        rcbfacility.Items.Insert(0, asfacilityListItem);
    }
    public void populatespeciality(int _clientid)
    {
        DataSet dsspeciality = objJobsBAL.SpecialitySelectByClientIDVisibleInJobs(_clientid);

        if (dsspeciality.Tables.Count > 0 && dsspeciality.Tables[0].Rows.Count > 0)
        {
            rcbspeciality.DataSource = dsspeciality;
            rcbspeciality.DataTextField = "Speciality";
            rcbspeciality.DataValueField = "SpcId";
            rcbspeciality.DataBind();
        }
        else
        {
            rcbspeciality.DataSource = null;
            rcbspeciality.DataBind();
        }

        RadComboBoxItem asspecialityListItem = new RadComboBoxItem(strfirstitemSpeciality, strfirstitemSpeciality);
        rcbspeciality.Items.Insert(0, asspecialityListItem);


    }
    protected void rcbcountry_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        populatestate(_clientid);
    }

    protected void rcbstate_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        populatecity(_clientid);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["facility"] = null;
        Session["speciality"] = null;
        Session["country"] = null;
        Session["state"] = null;
        Session["city"] = null;
        Session["keyword"] = null;

        if (rcbfacility.Items.Count > 0)
        {
            if (rcbfacility.SelectedValue != strfirstitemFacility)
            {
                strFacility = rcbfacility.SelectedValue.Trim();
            }
        }

        if (rcbspeciality.Items.Count > 0)
        {
            if (rcbspeciality.SelectedValue != strfirstitemSpeciality)
            {
                strSpeciality = rcbspeciality.SelectedValue;
            }
        }

        if (rcbcountry.Items.Count > 0)
        {
            if (rcbcountry.SelectedValue != strfirstitemCountry)
            {
                strCountry = rcbcountry.SelectedValue;
            }
        }

        if (rcbstate.Items.Count > 0)
        {
            if (rcbstate.SelectedValue != strfirstitemState)
            {
                strState = rcbstate.SelectedValue;
            }
        }


        if (rcbcity.Items.Count > 0)
        {
            if (rcbcity.SelectedValue != strfirstitemCity)
            {
                strCity = rcbcity.SelectedValue;
            }
        }

        if (txtKeyword.Value != "Keyword")
        {
            strkeyword = txtKeyword.Value;
        }

        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }

        Response.Redirect("Jobs/Job_SearchResults.aspx?cid=" + _clientid + "&facility=" + strFacility.Replace("&", "") + "&speciality=" + strSpeciality.Replace("&", "") + "&country=" + strCountry.Replace("&", "") + "&state=" + strState.Replace("&", "") + "&city=" + strCity.Replace("&", "") + "&keyword=" + strkeyword);

    }
}
