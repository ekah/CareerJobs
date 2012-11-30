using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using MedAppointments.BusinessAccessLayer;

public partial class MedAppointment : System.Web.UI.MasterPage
{
    protected string requesterName;
    protected string requesterEmail;
    protected string requesterMobile;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SignInId"] != null)
        {
            //if (ViewState["ZendeskLogin"] == null)
            //{
                LoginNewDO l = new LoginBAL().GetLogin(Session["SignInId"].ToString());
                if (l != null)
                {
                    requesterEmail = l.EmailId;
                    requesterName = l.FirstName + " " + l.LastName;
                    requesterMobile = l.MobileId;

                    string scriptTalcore = @"var talcore_custom = {}; talcore_custom.session = { username: '" + requesterName + "', email: '" + requesterEmail + "', mobile: '" + requesterMobile + "'};";
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "TalCoreUserName", scriptTalcore, true);
                }
            //    ViewState["ZendeskLogin"] = l;
            //}
            //else
            //{
            //    LoginNewDO l = (LoginNewDO)ViewState["ZendeskLogin"];
            //    requesterEmail = l.EmailId;
            //    requesterName = l.FirstName + " " + l.LastName;
            //}


            if (Session["SignInAccountTypeId"] != null)
            {
                if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Patient)
                {
                    divSetup.Visible = true;
                }
                else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Organization)
                {
                    if (Request.Url.PathAndQuery.Contains("Hospital.aspx"))
                        divSetup.Visible = false;
                    else
                        divSetup.Visible = true;
                }
                else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Doctor)
                {
                    if (Request.Url.PathAndQuery.Contains("Hospital.aspx"))
                        divSetup.Visible = false;
                    else
                        divSetup.Visible = true;
                }
                else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Service)
                {
                    divSetup.Visible = true;
                }
                else
                {
                    divSetup.Visible = false;
                }

            }
        }
        else
        {
            divSetup.Visible = false;
        }
    }
}
