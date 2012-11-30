using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;


public partial class Jobs_Job_PDescription : System.Web.UI.Page
{
    int _clientid = 0;
    string _jobid = string.Empty;
    Job_SearchDescriptionColVisibleBAL objSearchDescriptionColVisibleBAL = new Job_SearchDescriptionColVisibleBAL();
    Job_SearchDescriptionBAL objSearchDescriptionBAL = new Job_SearchDescriptionBAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();         
        }
    }
    public void Bind()
    {
        if (Request.QueryString.Count > 0)
        {
            if (Request.QueryString["JobId"] != null)
            {
                if (Request.QueryString["JobId"].ToString() != string.Empty)
                {

                    if (Request.QueryString["cid"] != null)
                    {
                        if (Request.QueryString["cid"].ToString() != string.Empty)
                        {
                            _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                        }
                    }
                    _jobid = Request.QueryString["JobId"].ToString();
                    DataSet ds = objSearchDescriptionBAL.SelectJobByJobIdVisible(_jobid, _clientid);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        lbljobtitleval.Text = ds.Tables[0].Rows[0]["jobtitle"].ToString();
                        lbljobidval.Text = ds.Tables[0].Rows[0]["jobid"].ToString();
                        lblcountry.Text = ds.Tables[0].Rows[0]["country"].ToString();
                        lblstate.Text = ds.Tables[0].Rows[0]["state"].ToString();
                        lblcity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                        lblDepartment.Text = ds.Tables[0].Rows[0]["speciality"].ToString();
                        lbldescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
                        lblfacility.Text = ds.Tables[0].Rows[0]["facility"].ToString();
                        lbldateposted.Text = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                    }
                }
            }
        }
    }
    protected void imgApply_Click(object sender, ImageClickEventArgs e)
    {
        if (Request.QueryString["jobid"] != null)
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            Response.Redirect("~/Jobs/Job_PApply.aspx?jobid=" + Request.QueryString["jobid"].ToString() + "&cid=" + _clientid);
        }
    }

    protected void imgShare_Click(object sender, ImageClickEventArgs e)
    {
        if (Request.QueryString["JobId"] != null)
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            Response.Redirect("~/Jobs/Job_PSendToFriend.aspx?jobid=" + Request.QueryString["JobId"].ToString() + "&cid=" + _clientid);
        }
    }

    protected void lnkback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Hospital.aspx");
    }
}