using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;

public partial class Job_Job_ManageAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Session["SignInId"] = null;
        Response.Redirect("~/Admin/AdminIndex.aspx");
    }

    protected void lbtnBackToAbmin_Click(object sender, EventArgs e)
    {
        Response.Redirect(SiteBAL.GetURL() + "Admin/AdminLoginView.aspx");
    }
}