using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_SearchResultsColVisible : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _SrId = 0;
    int _clientid = 0;
    bool _countrybool = false;
    bool _statebool = false;
    bool _citybool = false;
    bool _facilitybool = false;
    bool _specialitybool = false;
    bool _postdatebool = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    Job_SearchResultsColVisibleBAL objSearchResultsColVisibleBAL = new Job_SearchResultsColVisibleBAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                populatevalues();
            }
        }
    }
    public void populatevalues()
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet dsdisplay = objSearchResultsColVisibleBAL.SRColVisibleSelectByVisible(_clientid);
        
        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SrId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SrId"].ToString());
            Session["SrId"] = dsdisplay.Tables[0].Rows[0]["SrId"].ToString();
            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                chkSearchResults.Items[0].Selected = true;
            }
            else
            {
                chkSearchResults.Items[0].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                chkSearchResults.Items[1].Selected = true;
            }
            else
            {
                chkSearchResults.Items[1].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                chkSearchResults.Items[2].Selected = true;
            }
            else
            {
                chkSearchResults.Items[2].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                chkSearchResults.Items[3].Selected = true;
            }
            else
            {
                chkSearchResults.Items[3].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
            {
                chkSearchResults.Items[4].Selected = true;
            }
            else
            {
                chkSearchResults.Items[4].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["postdate"].ToString() == "True")
            {
                chkSearchResults.Items[5].Selected = true;
            }
            else
            {
                chkSearchResults.Items[5].Selected = false;
            }

            Session["AlreadySR"] = true;
        }
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
         DataSet dsdisplay = objSearchResultsColVisibleBAL.SRColVisibleSelectByVisible(_clientid);
        
        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SrId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SrId"].ToString());
        }
        else 
        {
            _SrId =0;
        }

                _countrybool = chkSearchResults.Items[0].Selected;
                _statebool = chkSearchResults.Items[1].Selected;
                _citybool = chkSearchResults.Items[2].Selected;
                _facilitybool = chkSearchResults.Items[3].Selected;
                _specialitybool = chkSearchResults.Items[4].Selected;
                _postdatebool = chkSearchResults.Items[5].Selected;
                if (Session["SignInOrganizationId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
                }

                if (Session["AlreadySR"] == null)
                {
                    if (Session["SignInId"] != null)
                    {
                        _whocreated = Session["SignInId"].ToString();
                    }
                }
                else
                {
                    if (Session["SignInId"] != null)
                    {
                        _whoupdated = Session["SignInId"].ToString();
                    }
                }

                objSearchResultsColVisibleBAL.InsertUpdateSRColVisible(_SrId,_countrybool, _statebool, _citybool, _facilitybool, _specialitybool, _postdatebool, _clientid, _whocreated, _whoupdated);

                Response.Redirect("Job_SubAdminManageAdmin.aspx");        

    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job_SubAdminManageAdmin.aspx");          
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("~/Default.aspx");
    }
}