using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MedAppointments.BusinessAccessLayer;
using System.Net;
using System.IO;


public partial class Controls_Jobs_TopMenu : System.Web.UI.UserControl
{
    protected int _doctorId = 0;
    protected int _organizationId = 0;
    protected int _serviceId = 0;
    protected string _siteUrl = "";
    protected bool _loginhospital = true;
    protected bool _registerhospital = true;

    protected void Page_Load(object sender, EventArgs e)
    {
        _siteUrl = SiteBAL.GetURL();
        DefaultSettings();
        LoadHome();
    }

    private void DefaultSettings()
    {
        if (Session["SignInId"] != null)
        {
            lbtnSignOut.Visible = true;
            lbtnLogin.Visible = false;
            lbtnHospitalLogin.Visible = false;
            lbtnRegister.Visible = false;
        }
        else
        {
            lbtnSignOut.Visible = false;
            //lbtnRegister.Visible = true;

            if (Request.Url.AbsolutePath.Contains("Hospital.aspx"))
            {
                lbtnHospitalLogin.Visible = true;
                lbtnLogin.Visible = false;
                divlbtnHospitalRegister.Visible = true;
                divlbtnRegister.Visible = false;
            }
            else
            {
                lbtnHospitalLogin.Visible = false;
                divlbtnRegister.Visible = true;
                divlbtnHospitalRegister.Visible = false;
                lbtnLogin.Visible = true;
            }

        }
    }

    protected void lbtnSignOut_Click(object sender, EventArgs e)
    {
        Session["SignInId"] = null;
        Session["SignInLoginId"] = null;
        Session["SignInMultipleAccounts"] = null;
        Session["SignInAccountTypeId"] = null;
        Session["SignInOrganizationId"] = null;
        Session["SetSubDomain"] = null;
        //Job Module
        Session["Login"] = null;
        //

        //Search Settings
        Session["SearchCountry"] = null;
        Session["SearchState"] = null;
        Session["SearchCity"] = null;
        Session["SearchOption"] = null;
        Session["SearchValue"] = null;

        Session["SearchCountryLogin"] = null;  //without login
        Session["SearchStateLogin"] = null;
        Session["SearchCityLogin"] = null;
        Session["SearchPostalLogin"] = null;
        Session["SearchSpecialityLogin"] = null;
        Session["SearchSymptomLogin"] = null;

        Session["BookAppointmentId"] = null;
        Session["BookAppointmentType"] = null;

        Session["EducationDataTable"] = null;
        Session["ExperienceDataTable"] = null;
        Session["EnteredDoctorDetails"] = null;

        //WebRequest request = WebRequest.Create("http://practiceprocess.zendesk.com/access/logout");
        //request.Credentials = CredentialCache.DefaultCredentials;
        //HttpWebResponse response = (HttpWebResponse)request.GetResponse ();
        //Stream dataStream = response.GetResponseStream();
        //dataStream.Close ();
        //response.Close ();

        Response.Redirect("~/Default.aspx");
    }

    protected void LoadHome()
    {
        if (Session["SignInId"] != null)
        {
            int signInId = Convert.ToInt32(Session["SignInLoginId"]);
            LoginNewDO l = new LoginBAL().GetAccount(signInId);
            if (!String.IsNullOrEmpty(l.EmailId))
            {
                //phDiscussion.Controls.Add(new LiteralControl("<a href=\"../DiscussionForum.aspx\" target=\"_blank\">Discussion Forum</a>"));
            }

            if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Patient)
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Patient.aspx\">Home</a></li>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Doctor)
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Doctor.aspx\">Home</a></li>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Organization)
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Organization.aspx\">Home</a></li>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Service)
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Service.aspx\">Home</a></li>"));
            }
            else
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Profile.aspx\">Home</a></li>"));
            }
        }
        else
        {
            if ((Request.Url.AbsolutePath.Contains("../Hospital.aspx")) || (Request.Url.AbsolutePath.Contains("../ConfirmByEmail.aspx")))
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"" + SiteBAL.GetURL() + "\">Home</a></li>"));
                lbtnFeatures.Visible = false;
                lbtnFaq.Visible = false;
            }
            else
            {
                phHome.Controls.Add(new LiteralControl("<li><a href=\"../Default.aspx\">Home</a></li>"));
            }
        }
    }
}
