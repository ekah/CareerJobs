using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MedAppointments.BusinessAccessLayer;

public partial class Setup : System.Web.UI.UserControl
{
    protected int _doctorId = 0;
    protected int _organizationId = 0;
    protected int _serviceId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadMenu();

    }
    protected void LoadMenu()
    {
        if (Session["SignInId"] != null)
        {
            if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Patient)
            {
                phMenu.Controls.Add(new LiteralControl("<a href=\"patient.aspx\"><img src=\"/imagesnew/homeIcon.png\" alt=\"Doctor Search\"/><span class=\"Yellow\">Search</span></a>"));
                //phMenu.Controls.Add(new LiteralControl("<a class =\"dock-item\" href=\"ReferAFriend.aspx\"><img src=\"/imagesnew/ReferFriend.png\" alt=\"Refer a Friend\"/><span>Refer a Friend</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"MyAppointment.aspx\"><img src=\"/imagesnew/listMyAppointment.png\" alt=\"MyAppointment Setup\"/><span class=\"Yellow\">My Appointments</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"ListMember.aspx\"><img src=\"/imagesnew/ListMembers.png\" alt=\"Member Setup\"/><span class=\"Yellow\">Member<br/> Setup</span></a>"));


                phMenu.Controls.Add(new LiteralControl("<a href=\"EditPatient.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"Edit Profile\"/><span>Edit <br/>Profile</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"AccountSetting.aspx\"><img src=\"/imagesnew/account-setting.png\" alt=\"Account Setting\"/><span>Notification Settings</span></a>"));


                if (Convert.ToBoolean(Session["SignInMultipleAccounts"]))
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\" ><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a class=\"inline\" href=\"#\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profile\"/><span class=\"Green\">Profiles</span></a>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Organization)
            {
                int _organizationId = (int)Session["SignInOrganizationId"];


                phMenu.Controls.Add(new LiteralControl("<a href=\"HospitalSetup.aspx\"><img src=\"/imagesnew/hospitalSetup.png\" alt=\"Hospital Setup\"/><span>Hospital Setup</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"ListDoctor.aspx\"><img src=\"/imagesnew/ListDoctor.png\" alt=\"Doctor Setup\"/><span>Doctor<br/> Setup</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"ListService.aspx\"><img src=\"/imagesnew/ListService.png\" alt=\"Service Setup\"/><span>Service<br/> Setup</span></a></li>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"HospitalDirectAppointment.aspx?id=" + _organizationId + "\"><img src=\"/imagesnew/DirectAppointment.png\" alt=\"Direct Appointment\"/><span>Direct Appointment</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"PatientSearch.aspx\"><img src=\"/imagesnew/AppointHistory.png\" alt=\"Patient Search\"/><span>Appointment History</span></a>"));
                //phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"HospitalAppointmentHistory.aspx\"><img src=\"/imagesnew/AppointHistory.png\" alt=\"Appointment History\"/><span>Appointment History</span></a>"));

                phMenu.Controls.Add(new LiteralControl("<a href=\"EditOrganization.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"Edit Profile\"/><span class=\"Yellow\">Edit <br/>Profile</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"Branding.aspx\"><img src=\"/imagesnew/branding.png\" alt=\"Branding\"/><span class=\"Yellow\">Branding</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"Landing.aspx\"><img src=\"/imagesnew/Set-Landing-Page.png\" alt=\"Wesite Setup\"/><span class=\"Yellow\">Website <br/>Setup</span></a></li>"));

                phMenu.Controls.Add(new LiteralControl("<a href=\"AccountSetting.aspx\"><img src=\"/imagesnew/account-setting.png\" alt=\"Notification Settings\"/><span class=\"Green\">Notification Settings</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a href=\"Search.aspx\"><img src=\"/imagesnew/SearchDoctor.png\" alt=\"Search Medical Service\"/><span>Check your Listing</span></a>"));
                if (Convert.ToBoolean(Session["SignInMultipleAccounts"]))
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Doctor)
            {
                int organizationId = (int)Session["SignInOrganizationId"];

                _doctorId = new CommonBAL().GetDoctorServiceIdBySignInId(0, Session["SignInId"].ToString(), organizationId);

                //phMenu.Controls.Add(new LiteralControl("<a href=\"PatientSearch.aspx\"><img src=\"/imagesnew/patientSearch.png\" alt=\"Patient Search\"/><span>Patient Search</span></a>"));


                //if (Session["SignInIdTemp"] == null)
                phMenu.Controls.Add(new LiteralControl("<a href=\"ListScheduleDoctor.aspx?id=" + _doctorId + "\"><img src=\"/imagesnew/List-Schedule.png\" alt=\"Schedule Setup\"/><span class=\"Yellow\">Schedule Setup</span></a>"));

                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider blockCalenderSetup\" href=\"ListBlockCalendar.aspx?id=" + _doctorId + "&type=0\"\"><img src=\"/imagesnew/List-Block-Calendar.png\" alt=\"Block Calendar Setup\"/><span class=\"Yellow\" style=\" font-size:11px;\">Block Calendar Setup</span></a>"));

                if (Session["SignInIdTemp"] == null)
                    phMenu.Controls.Add(new LiteralControl("<a href=\"DirectAppointment.aspx?id=" + _doctorId + "&type=0\"><img src=\"/imagesnew/DirectAppointment.png\" alt=\"Direct Appointment\"/><span>Direct Appointment</span></a>"));

                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"PatientSearch.aspx\"><img src=\"/imagesnew/AppointHistory.png\" alt=\"Appointment History\"/><span>Appointment History</span></a>"));

                if (Session["SignInIdTemp"] == null)
                    phMenu.Controls.Add(new LiteralControl("<a href=\"EditDoctor.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"Edit Profile\"/><span>Edit <br/>Profile</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a href=\"EditDoctor.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"View Profile\"/><span>View <br/>Profile</span></a>"));

                if (Session["SignInIdTemp"] == null) //checking Admin doctor 
                {
                    phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"Landing.aspx\"><img src=\"/imagesnew/Set-Landing-Page.png\" alt=\"Website Setup\"/><span>Website <br/>Setup</span></a></li>"));

                    phMenu.Controls.Add(new LiteralControl("<a href=\"Search.aspx\"><img src=\"/imagesnew/SearchDoctor.png\" alt=\"Search Medical Service\"/><span class=\"Green\">Check your Listing</span></a>"));
                    phMenu.Controls.Add(new LiteralControl("<a href=\"DoctorDiagnosis.aspx\"><img src=\"/imagesnew/Set-Diagnosis.png\" alt=\"Diagnosis Setup\"/><span class=\"Green\">Diagnosis Setup</span></a>"));
                    phMenu.Controls.Add(new LiteralControl("<a href=\"AccountSetting.aspx\"><img src=\"/imagesnew/account-setting.png\" alt=\"Notification Settings\"/><span class=\"Green\">Notification Settings</span></a>"));
                }

                if (Convert.ToBoolean(Session["SignInMultipleAccounts"]))
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profile\"/><span class=\"Green\">Profiles</span></a>"));
            }
            else if ((AccountType)Convert.ToInt32(Session["SignInAccountTypeId"]) == AccountType.Service)
            {
                int organizationId = (int)Session["SignInOrganizationId"];

                _serviceId = Convert.ToInt32(Session["SignInAccountId"]);

                //if (Session["SignInIdTemp"] == null)
                phMenu.Controls.Add(new LiteralControl("<a href=\"ListScheduleService.aspx?id=" + _serviceId + "\"><img src=\"/imagesnew/List-Schedule.png\" alt=\"Schedule Setup\"/><span class=\"Yellow\">Schedule Setup</span></a>"));

                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"ListBlockCalendar.aspx?id=" + _serviceId + "&type=1\"\"><img src=\"/imagesnew/List-Block-Calendar.png\" alt=\"Block Calendar Setup\"/><span class=\"Yellow\"  style=\" font-size:11px;\">Block Calendar Setup</span></a>"));

                if (Session["SignInIdTemp"] == null)
                    phMenu.Controls.Add(new LiteralControl("<a href=\"DirectAppointment.aspx?id=" + _serviceId + "&type=1\"><img src=\"/imagesnew/DirectAppointment.png\" alt=\"Direct Appointment\"/><span>Direct Appointment</span></a></li>"));

                //phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"AppointmentHistory.aspx\"><img src=\"/imagesnew/AppointHistory.png\" alt=\"Appointment History\"/><span>Appointment History</span></a>"));
                phMenu.Controls.Add(new LiteralControl("<a class=\"Divider\" href=\"PatientSearch.aspx\"><img src=\"/imagesnew/AppointHistory.png\" alt=\"Appointment History\"/><span>Appointment History</span></a>"));

                if (Session["SignInIdTemp"] == null)
                    phMenu.Controls.Add(new LiteralControl("<a href=\"EditService.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"Edit Profile\"/><span class=\"Green\">Edit <br/>Profile</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a href=\"EditService.aspx\"><img src=\"/imagesnew/EditProfile.png\" alt=\"View Profile\"/><span class=\"Green\">View <br/>Profile</span></a>"));

                if (Session["SignInIdTemp"] == null)
                {
                    phMenu.Controls.Add(new LiteralControl("<a href=\"AccountSetting.aspx\"><img src=\"/imagesnew/account-setting.png\" alt=\"Notification Settings\"/><span class=\"Green\">Notification Settings</span></a>"));
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Search.aspx\"><img src=\"/imagesnew/SearchDoctor.png\" alt=\"Search Medical Service\"/><span class=\"Green\">Check your Listing</span></a>"));
                }

                if (Convert.ToBoolean(Session["SignInMultipleAccounts"]))
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
                else
                    phMenu.Controls.Add(new LiteralControl("<a href=\"Profile.aspx\"><img src=\"/imagesnew/SwitchAccounts.png\" alt=\"Profiles\"/><span class=\"Green\">Profiles</span></a>"));
            }
        }
    }
}