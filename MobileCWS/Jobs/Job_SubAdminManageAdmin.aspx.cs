using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Job_Job_SubAdminManageAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Login"] = "SUBADMIN";
        Session["SignInOrganizationId"] = 319;
        Session["SignInId"] = "vanilavanya@botcode.com";
        Session["SignInLoginId"] = "1668";
        
    }

    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Session["SignInOrganizationId"] = null;
        Session["SignInId"] = null;
        Session["SignInLoginId"] = null;
        Response.Redirect("~/Job_SubAdminManageAdmin.aspx");
    }

    protected void lbtnBackToAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Job_SubAdminManageAdmin.aspx");
    }
}