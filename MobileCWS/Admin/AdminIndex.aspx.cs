using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminIndex : System.Web.UI.Page
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
        Session["Login"] = "ADMIN";
        Session["SignInId"] = "BOTCODE";
        Session["AdminLogin"] = null;

        if (Cache["LoginTable"] != null)
        {
            //Cache.Remove("LoginTable");
            //Cache.Remove("LoginView");
            //Cache.Remove("AccountType");

            Session["AccountType"] = null;
            Session["LoginView"] = null;
            Session["LoginTable"] = null;
        }
    }   
}