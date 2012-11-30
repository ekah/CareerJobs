using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Job_Job_HrManageAdmin : System.Web.UI.Page
{
    int _clientid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
    }

    protected void lnklogout_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        Session["Login"] = null;
        Session["User"] = null;
        Session["SignInId"] = null;
        Response.Redirect("Job_HrLogin.aspx?cid=" + _clientid);
    }
}