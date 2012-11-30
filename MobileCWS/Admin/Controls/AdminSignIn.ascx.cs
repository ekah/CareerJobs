using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Controls_AdminSignIn : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DefaultSettings();
        }
    }

    private void DefaultSettings()
    {
        txtSignIn.Focus();
    }

    protected void lbtnSignIn_Click(object source, EventArgs args)
    {
        if (txtSignIn.Text == "botcodeadmin" && txtPassword.Text == "botcode123")
        {
            Session["AdminLogin"] = true;
            Response.Redirect("../Jobs/Job_ManageAdmin.aspx");
            //href="../Jobs/Job_ManageAdmin.aspx"
        }
        else
        {
            lblError.Visible = true;
        }
    }
}