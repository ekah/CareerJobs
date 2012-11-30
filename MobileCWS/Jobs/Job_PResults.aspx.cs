using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_PResults : System.Web.UI.Page
{
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    DataSet ds;
    DataView dv = new DataView();
    int _clientid = 0;
    int _did = -1;
    string sortexpres = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          
            PopulateResults();

            if (grdResults.PageIndex == 0)
            {
                lnkPrev.Enabled =false;
            }
            if (grdResults.PageIndex == grdResults.PageCount - 1)
            {
                lnkNext.Enabled = false;
            }
        }
    }

    public void PopulateResults()
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

            if (Request.QueryString["did"] != null)
            {

                if (Request.QueryString["did"].ToString() != string.Empty)
                {
                    _did = Convert.ToInt32(Request.QueryString["did"].ToString());
                }
            }
                ds = objJobsBAL.JobSelectByClientID(_clientid,_did);
                grdResults.DataSource = BindGrid(sortexpres);
                grdResults.DataBind();
               
                int currentStartRow = (grdResults.PageIndex * grdResults.PageSize) + 1;
                int currentEndRow = (grdResults.PageIndex * grdResults.PageSize) + grdResults.PageSize;
                    
                if (currentEndRow > ds.Tables[0].Rows.Count)
                    currentEndRow = ds.Tables[0].Rows.Count;

                lblstart.Text = currentStartRow + "-" + currentEndRow + " out of " + ds.Tables[0].Rows.Count;
           
        }

    }
    public void SetPaging()
    {
      
        lnkPrev.Enabled = false;


        if (grdResults.PageIndex == 0)
        {
            lnkPrev.Enabled = false;
            lnkNext.Enabled = true;         

        }

        if (grdResults.PageCount - 1 == grdResults.PageIndex + 1)
        {
            lnkNext.Enabled = true;

        }

        if (grdResults.PageIndex == 0)
        {
            lnkPrev.Enabled = false;

        }

        if (grdResults.PageIndex <= grdResults.PageCount)
        {
            lnkNext.Enabled = true;
            lnkPrev.Enabled = true;         

        }

        if (grdResults.PageCount - 1 == grdResults.PageIndex)
        {
            lnkNext.Enabled = false;           

        }

        if (grdResults.PageIndex == grdResults.PageCount)
        {           
            lnkNext.Enabled = false;
            lnkPrev.Enabled = true;         

        }
   
        Session["PageIndex"] = grdResults.PageIndex;       

    }

    public DataView BindGrid(string sortExpr)
    {
        if (sortExpr != null || sortExpr != string.Empty)
        {
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    dv = new DataView(ds.Tables[0]);
                    dv.Sort = sortExpr;
                }
            }

        }
        else
        {
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    dv = ds.Tables[0].DefaultView;
                }
            }
        }

        return dv;
    }

    protected void lnkPrev_Click(object sender, EventArgs e)
    {
        int i = grdResults.PageCount;

        if (grdResults.PageIndex > 0)
        {
            grdResults.PageIndex = grdResults.PageIndex - 1;
            lnkNext.Enabled = true;
        }

        if (grdResults.PageIndex == 0)
        {
            lnkPrev.Enabled = false;       
        }
        PopulateResults();

    }
    protected void lnkNext_Click(object sender, EventArgs e)
    {
        int i = grdResults.PageIndex + 1;
        if (i <= grdResults.PageCount)
        {
            grdResults.PageIndex = i;           
            lnkPrev.Enabled = true;           
        }

        if (grdResults.PageCount - 1 == grdResults.PageIndex)
        {
            lnkNext.Enabled = false;           
        }

        PopulateResults();
        Session["PageIndex"] = grdResults.PageIndex;        

    }
}