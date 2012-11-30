using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;

public partial class Job_Job_SearchDescription : System.Web.UI.Page
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
            displayfields();
        }
    }
    public void displayfields()
    {
        if (Request.QueryString.Count > 0)
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
        }

        DataSet dsdisplay = objSearchDescriptionColVisibleBAL.SDColVisibleSelectByVisible(_clientid);
        if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
        {
            if (dsdisplay.Tables[0].Rows[0]["jobid"].ToString() == "True")
            {
                divNumber.Visible = true;
                divNumberbr.Visible = true;

            }
            else
            {
                divNumber.Visible = false;
                divNumber.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["jobtitle"].ToString() == "True")
            {
                divjobtitle.Visible = true;
            }
            else
            {
                divjobtitle.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
            {
                divcountry.Visible = true;
                divcountrybr.Visible = true;
            }
            else
            {
                divcountry.Visible = false;
                divcountry.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
            {
                divstate.Visible = true;
                divstatebr.Visible = true;

            }
            else
            {
                divstate.Visible = false;
                divstatebr.Visible = false;
            }


            if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
            {
                divcity.Visible = true;
                divcitybr.Visible = true;
            }
            else
            {
                divcity.Visible = false;
                divcitybr.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
            {
                divspeciality.Visible = true;
                divspecialitybr.Visible = true;
            }
            else
            {
                divspeciality.Visible = false;
                divspecialitybr.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
            {
                divfacility.Visible = true;
                divfacilitybr.Visible = true;
            }
            else
            {
                divfacility.Visible = false;
                divfacilitybr.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["Description"].ToString() == "True")
            {
                divdescription.Visible = true;
                divdescriptionbr.Visible = true;
            }
            else
            {
                divdescription.Visible = false;
                divdescriptionbr.Visible = false;
            }

            if (dsdisplay.Tables[0].Rows[0]["posteddate"].ToString() == "True")
            {
                divposteddate.Visible = true;
                divposteddatebr.Visible = true;
            }
            else
            {
                divposteddate.Visible = false;
                divposteddatebr.Visible = false;
            }
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
    protected void lnkback_Click(object sender, EventArgs e)
    {
        if (Request.QueryString.Count > 0)
        {
            if (Request.QueryString["return"].ToString() == "1")
            {
                Response.Redirect("~/Hospital.aspx");
            }
            else if (Request.QueryString["return"].ToString() == "2")
            {
                Response.Redirect("~/Jobs/Job_SearchResults.aspx");
            }
            else if (Request.QueryString["return"].ToString() == "3")
            {
                Response.Redirect("~/Hospital.aspx");
            }
        }

    }
    protected void imgApply_Click(object sender, ImageClickEventArgs e)
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
            Response.Redirect("~/Jobs/Job_Apply.aspx?jobid=" + Request.QueryString["JobId"].ToString() + "&cid=" + _clientid);
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
            Response.Redirect("~/Jobs/Job_SendToFriend.aspx?jobid=" + Request.QueryString["JobId"].ToString() + "&cid=" + _clientid);
        }
    }
}
