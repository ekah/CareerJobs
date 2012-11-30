using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Job_Job_HotOppsColVisible : System.Web.UI.Page
{
    Job_HotOppsColVisibleBAL objHotOppsColVisibleBAL = new Job_HotOppsColVisibleBAL();
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _hid = 0;
    int _clientid = 0;
    bool _countrybool = false;
    bool _statebool = false;
    bool _citybool = false;
    bool _facilitybool = false;
    bool _specialitybool = false;
    bool _postdatebool = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
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

        DataSet dsdisplay = objHotOppsColVisibleBAL.HOColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            Session["hid"] = dsdisplay.Tables[0].Rows[0]["HId"].ToString();
            _hid = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["HId"].ToString());

            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                chkHotopps.Items[0].Selected = true;
            }
            else
            {
                chkHotopps.Items[0].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                chkHotopps.Items[1].Selected = true;
            }
            else
            {
                chkHotopps.Items[1].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                chkHotopps.Items[2].Selected = true;
            }
            else
            {
                chkHotopps.Items[2].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                chkHotopps.Items[3].Selected = true;
            }
            else
            {
                chkHotopps.Items[3].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
            {
                chkHotopps.Items[4].Selected = true;
            }
            else
            {
                chkHotopps.Items[4].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["posteddate"].ToString() == "True")
            {
                chkHotopps.Items[5].Selected = true;
            }
            else
            {
                chkHotopps.Items[5].Selected = false;
            }

            Session["AlreadyHO"] = true;
        }
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet dsdisplay = objHotOppsColVisibleBAL.HOColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
           
            _hid = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["HId"].ToString());
        }
        else 
        {
             _hid = 0;
        }
            
                _countrybool = chkHotopps.Items[0].Selected;
                _statebool = chkHotopps.Items[1].Selected;
                _citybool = chkHotopps.Items[2].Selected;
                _facilitybool = chkHotopps.Items[3].Selected;
                _specialitybool = chkHotopps.Items[4].Selected;
                _postdatebool = chkHotopps.Items[5].Selected;
                if (Session["SignInOrganizationId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
                }

                if (Session["AlreadyHO"] == null)
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

                objHotOppsColVisibleBAL.InsertUpdateHOColVisible(_hid, _countrybool, _statebool, _citybool, _facilitybool, _specialitybool, _postdatebool, _clientid, _whocreated, _whoupdated);

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
