using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;


public partial class Job_Job_SearchDescriptionColVisible : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _SdId = 0;
    int _clientid = 0;
    bool _jobidbool = false;
    bool _jobtitlebool = false;
    bool _countrybool = false;
    bool _statebool = false;
    bool _citybool = false;
    bool _facilitybool = false;
    bool _specialitybool = false;
    bool _descriptionbool = false;
    bool _posteddatebool = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    Job_SearchDescriptionColVisibleBAL objSearchDescriptionColVisibleBAL = new Job_SearchDescriptionColVisibleBAL();
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

        DataSet dsdisplay = objSearchDescriptionColVisibleBAL.SDColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SdId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SdId"].ToString());
            Session["SdId"] = dsdisplay.Tables[0].Rows[0]["SdId"].ToString();
            if (dsdisplay.Tables[0].Rows[0]["jobid"].ToString() == "True")
            {
                chkSearchDescription.Items[0].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[0].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["jobtitle"].ToString() == "True")
            {
                chkSearchDescription.Items[1].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[1].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                chkSearchDescription.Items[2].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[2].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                chkSearchDescription.Items[3].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[3].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                chkSearchDescription.Items[4].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[4].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                chkSearchDescription.Items[5].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[5].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
            {
                chkSearchDescription.Items[6].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[6].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["description"].ToString() == "True")
            {
                chkSearchDescription.Items[7].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[7].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["posteddate"].ToString() == "True")
            {
                chkSearchDescription.Items[8].Selected = true;
            }
            else
            {
                chkSearchDescription.Items[8].Selected = false;
            }

            Session["AlreadySD"] = true;

        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet dsdisplay = objSearchDescriptionColVisibleBAL.SDColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SdId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SdId"].ToString());
        }
        else
        {
            _SdId =0;
        }


                _jobidbool = chkSearchDescription.Items[0].Selected;
                _jobtitlebool = chkSearchDescription.Items[1].Selected;
                _countrybool = chkSearchDescription.Items[2].Selected;
                _statebool = chkSearchDescription.Items[3].Selected;
                _citybool = chkSearchDescription.Items[4].Selected;
                _facilitybool = chkSearchDescription.Items[5].Selected;
                _specialitybool = chkSearchDescription.Items[6].Selected;
                _descriptionbool = chkSearchDescription.Items[7].Selected;
                _posteddatebool = chkSearchDescription.Items[8].Selected;
                if (Session["SignInOrganizationId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
                }

                if (Session["AlreadySD"] == null)
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

                objSearchDescriptionColVisibleBAL.InsertUpdateSDColVisible(_SdId,_jobidbool, _jobtitlebool, _facilitybool, _specialitybool, _countrybool, _statebool, _citybool, _descriptionbool, _posteddatebool, _clientid, _whocreated, _whoupdated);


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