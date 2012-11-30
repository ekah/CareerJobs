using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using System.Web.UI.HtmlControls;


public partial class Jobs_Job_PClientResults : System.Web.UI.Page
{
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["did"] != null)
        {
            if (Request.QueryString["did"].ToString() != string.Empty)
            {
                int did = Convert.ToInt32(Request.QueryString["did"].ToString());

                BindHospitalByDepartment(did);
            }
        }
    }

    public void BindHospitalByDepartment(int did)
    {
        DataSet ds = objJobsBAL.SelectDepartmentByClient(did);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            rpJobList.DataSource = ds;
            rpJobList.DataBind();
        }
        else
        {
            lblNoJobs.Visible = true;
        }

    }

    protected void lbtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Hospital.aspx");
    }
   
}