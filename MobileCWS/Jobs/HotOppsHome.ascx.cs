using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;
using Telerik.Web.UI;


public partial class Job_HotOppsHome : System.Web.UI.UserControl
{
    protected string HotOppsTextLength = "18";
    protected string HotOppsTextLength1 = "10";
    int _clientid = 0;
    Job_HotOppsColVisibleBAL objHotOppsColVisibleBAL = new Job_HotOppsColVisibleBAL();
    Jobs_HotOppsHomeBAL objHotOppsHomeBAL = new Jobs_HotOppsHomeBAL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void rgHotOpps_ItemDataBound(object sender, GridItemEventArgs e)
    {

        if (e.Item is GridDataItem)
        {
            GridDataItem dataitem = (GridDataItem)e.Item;

            if (Session["SignInOrganizationId"] != null)
            {
                _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
            }

            DataSet dsdisplay = objHotOppsColVisibleBAL.HOColVisibleSelectByVisible(_clientid);
            if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
            {
                if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
                {
                    dataitem["country"].Visible = true;

                }
                else
                {
                    dataitem["country"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
                {
                    dataitem["state"].Visible = true;
                }
                else
                {
                    dataitem["state"].Visible = false;

                }


                if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
                {
                    dataitem["city"].Visible = true;
                }
                else
                {
                    dataitem["city"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
                {
                    dataitem["facility"].Visible = true;
                }
                else
                {
                    dataitem["facility"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
                {
                    dataitem["speciality"].Visible = true;
                }
                else
                {
                    dataitem["speciality"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["posteddate"].ToString() == "True")
                {
                    dataitem["posteddate"].Visible = true;
                }
                else
                {
                    dataitem["posteddate"].Visible = false;
                }
            }

        }


    }

    protected void rgHotOpps_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (!e.IsFromDetailTable)
        {
            PopulateHotopps();
        }

    }

    protected string LearnMoreTrim1(string strLearnMore)
    {
        int intHotOppsTextLength = 5;
        if (!String.IsNullOrEmpty(HotOppsTextLength1))
        {
            intHotOppsTextLength = Convert.ToInt32(HotOppsTextLength);
        }
        if (strLearnMore.Length > intHotOppsTextLength)
        {
            return strLearnMore.Substring(0, intHotOppsTextLength) + "...";
        }
        return strLearnMore;
    }


    protected string LearnMoreTrim(string strLearnMore)
    {
        int intHotOppsTextLength = 20;
        if (!String.IsNullOrEmpty(HotOppsTextLength))
        {
            intHotOppsTextLength = Convert.ToInt32(HotOppsTextLength);
        }
        if (strLearnMore.Length > intHotOppsTextLength)
        {
            return strLearnMore.Substring(0, intHotOppsTextLength) + "...";
        }
        return strLearnMore;
    }

    public void PopulateHotopps()
    {
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet ds = objHotOppsHomeBAL.SelectTopJobsByClientId(_clientid);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            rgHotOpps.DataSource = ds;

        }
    }
}
