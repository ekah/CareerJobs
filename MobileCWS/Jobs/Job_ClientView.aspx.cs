using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;
using System.Text;
using System.Data;

public partial class Jobs_ClientView : System.Web.UI.Page
{
    Job_FacilityBAL objFacilityBAL = new Job_FacilityBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    int _facid = 0;
    string _facility = string.Empty;

    bool _visibility = false;
    int _clientid = 0; // BotCode Admin
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("../Admin/AdminIndex.aspx");
        }

    }

    protected void rgClientView_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgClientView.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();
        ds = objFacilityBAL.SelectClient();
        return ds;
    }
    private void ShowPopUpMsg(string msg)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("alert('");
        sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
        sb.Append("');");
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("../Admin/AdminIndex.aspx");
    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job_ManageAdmin.aspx");
    }
}