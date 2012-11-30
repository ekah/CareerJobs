using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MedAppointments.BusinessAccessLayer;

public partial class Control_DisplayLoggedInName : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            DefaultSettings();
    }

    private void DefaultSettings()
    {
        if (Session["SignInId"] != null)
        {
            if (Session["SignInAccountTypeId"] != null)
            {
                LoadDisplayName();
            }
            else
            {
                lblUser.Text = "Welcome<br /><span class=\"LoggedInSub\">You signed in as " + Session["SignInId"].ToString() + "</span>";
            }
        }
    }

    private void LoadDisplayName()
    {
        string displayName = string.Empty;
        string organizationName = string.Empty;

        if (Session["SignInAccountId"] != null)
            displayName = new CommonBAL().GetNameBySignInId(Session["SignInId"].ToString(), Convert.ToInt32(Session["SignInAccountTypeId"]), Convert.ToInt32(Session["SignInAccountId"]), Convert.ToInt32(Session["SignInOrganizationId"]));
        else
            displayName = new CommonBAL().GetNameBySignInId(Session["SignInId"].ToString(), 0, 0, Convert.ToInt32(Session["SignInOrganizationId"]));

        if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Organization)
        {
            organizationName = new OrganizationBAL().GetOrganizationNameById(Convert.ToInt32(Session["SignInOrganizationId"]));
            lblUser.ToolTip = "Welcome " + organizationName;

            if (organizationName.Length > 50)
                lblUser.Text = "Welcome " + organizationName.Substring(0, 50) + "...";
            else
                lblUser.Text = "Welcome " + organizationName;
            return;
        }
        else
        {
            lblUser.Text = "Welcome " + displayName;
            return;
        }
    }
}