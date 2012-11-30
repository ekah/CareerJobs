using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Job_Job_SearchWidgetColVisible : System.Web.UI.Page
{
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _SwId = 0;
    int _clientid = 0;
    bool _countrybool = false;
    bool _statebool = false;
    bool _citybool = false;
    bool _facilitybool = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    Job_SearchWidgetColVisibleBAL objSearchWidgetColVisibleBAL = new Job_SearchWidgetColVisibleBAL();
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
        DataSet dsdisplay = objSearchWidgetColVisibleBAL.SWColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SwId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SwId"].ToString());
            Session["SwId"] = dsdisplay.Tables[0].Rows[0]["SwId"].ToString();
            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                checklocation.Items[0].Selected = true;
            }
            else
            {
                checklocation.Items[0].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                checklocation.Items[1].Selected = true;
            }
            else
            {
                checklocation.Items[1].Selected = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                checklocation.Items[2].Selected = true;
            }
            else
            {
                checklocation.Items[2].Selected = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                checklocation.Items[3].Selected = true;
            }
            else
            {
                checklocation.Items[3].Selected = false;
            }

            Session["AlreadySW"] = true;
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
      DataSet dsdisplay = objSearchWidgetColVisibleBAL.SWColVisibleSelectByVisible(_clientid);

        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            _SwId = Convert.ToInt32(dsdisplay.Tables[0].Rows[0]["SwId"].ToString());
        }
        else 
        {
            _SwId =0;
        }
                _countrybool = checklocation.Items[0].Selected;
                _statebool = checklocation.Items[1].Selected;
                _citybool = checklocation.Items[2].Selected;
                _facilitybool = checklocation.Items[3].Selected;
                if (Session["SignInOrganizationId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
                }

                if (Session["AlreadySW"] == null)
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


                objSearchWidgetColVisibleBAL.InsertUpdateSWColVisible(_SwId,_countrybool, _statebool, _citybool, _facilitybool, _clientid, _whocreated, _whoupdated);


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