using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MedAppointments.BusinessAccessLayer;

public partial class Control_DisplayLoggedInId : System.Web.UI.UserControl
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
            lblUserId.Text = "Welcome<br /><span class=\"LoggedInSub\">You signed in as " + Session["SignInId"].ToString() + "</span>";
            }
        }
    }

    private void LoadDisplayName()
    {
        string organizationName = string.Empty;

        if (Convert.ToInt32(Session["SignInAccountTypeId"]) == 0)
        {
            lblUserText.Text = "You signed in as " + Session["SignInId"].ToString();
            return;
        }
        lblUserId.Text = "<span class=\"LoggedInSub\">You signed in as " + Session["SignInId"].ToString() + "<br/>";

        switch ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]))
        {
            case AccountType.Organization:
                lblUserId.Text += " (Administration)</span>";
                break;
            case AccountType.Doctor:
                organizationName = new OrganizationBAL().GetOrganizationNameById(Convert.ToInt32(Session["SignInOrganizationId"]));
                if (organizationName.Length > 50)
                    organizationName = organizationName.Substring(0, 50) + "...";
                lblUserId.Text += " (Doctor in " + organizationName + ")</span>";
                break;
            case AccountType.Service:
                organizationName = new OrganizationBAL().GetOrganizationNameById(Convert.ToInt32(Session["SignInOrganizationId"]));
                if (organizationName.Length > 50)
                    organizationName = organizationName.Substring(0, 50) + "...";
                lblUserId.Text += " (Service in " + organizationName + ")</span>";
                break;
            case AccountType.Patient:
                lblUserId.Text += " (Patient)</span>";
                break;
        }
    }
}