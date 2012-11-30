using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MedAppointments.BusinessAccessLayer
{
    public static class SiteBAL
    {
        public static string GetURL()
        {
            return ConfigurationManager.AppSettings["SiteUrl"].ToString();
        }

        public static string GetRootDomain()
        {
            return ConfigurationManager.AppSettings["SiteDomain"].ToString();
        }

        public static void Serialize(DataTable dt, Stream stream)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, dt);
        }

        public static DataTable Deserialize(Stream stream)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            return (DataTable)serializer.Deserialize(stream);
        }
    }

    public class CommonBAL
    {
        CommonDAL _objCommonDal = new CommonDAL();

        public string GenrateNewPassword(string token)
        {
            StringBuilder newToken = new StringBuilder();
            byte[] tokenGenrated = Encoding.ASCII.GetBytes(token);

            foreach (byte element in tokenGenrated)
                newToken.Append(element);

            return newToken.ToString().Substring(0, 6);
        }

        public string GetNewToken()
        {
            return _objCommonDal.GetNewToken();
        }

        public int ValidateMobileBySignUp(string mobileId)
        {
            return _objCommonDal.ValidateMobileBySignUp(mobileId);
        }

        public int ValidateEmailBySignUp(string emailId)
        {
            return _objCommonDal.ValidateEmailBySignUp(emailId);
        }

        public int ValidateMobile(string mobileId)
        {
            return _objCommonDal.ValidateMobile(mobileId);
        }

        public int ValidatePatientMobile(string signInId)
        {
            return _objCommonDal.ValidatePatientMobile(signInId);
        }

        public int ValidatePatientUHID(string signInId, int organizationId)
        {
            return _objCommonDal.ValidatePatientUHID(signInId, organizationId);
        }

        public int ValidateEmail(string emailId)
        {
            return _objCommonDal.ValidateEmail(emailId);
        }

        public int ValidateEmailByService(string emailId)
        {
            return _objCommonDal.ValidateEmailByService(emailId);
        }

        public int ValidateServiceMobile(string mobileId)
        {
            return _objCommonDal.ValidateServiceMobile(mobileId);
        }

        public int ValidateMobileByService(string mobileId)
        {
            return _objCommonDal.ValidateMobileByService(mobileId);
        }

        public int ValidateServiceEmail(string emailId)
        {
            return _objCommonDal.ValidateServiceEmail(emailId);
        }

        public int ValidateSignIn(string signInId, string password)
        {
            return _objCommonDal.ValidateSignIn(signInId, password);
        }

        public int ValidateSignInNonActivate(string signInId, string password)
        {
            return _objCommonDal.ValidateSignInNonActivate(signInId, password);
        }

        public string GetSignInPassword(string signInId)
        {
            return _objCommonDal.GetSignInPassword(signInId);
        }

        public int UpdateCredentialsBySignInId(LoginNewDO l)
        {
            return _objCommonDal.UpdateCredentialsBySignInId(l.LoginId, l.EmailId, l.MobileId, l.Password);
        }

        public AccountType GetAccountTypeBySignInId(string signInId)
        {
            return (AccountType)_objCommonDal.GetAccountTypeBySignInId(signInId);
        }

        public List<AccountType> GetAccountTypesBySignInId(string signInId)
        {
            List<int> types = _objCommonDal.GetAccountTypesBySignInId(signInId);

            List<AccountType> accountType = new List<AccountType>();
            foreach (int i in types)
            {
                accountType.Add((AccountType)i);
            }

            return accountType;
        }

        public string GetNameBySignInId(string signInId, int accountTypeId, int id, int organizationId)
        {
            return _objCommonDal.GetNameBySignInId(signInId, accountTypeId, id, organizationId);
        }

        public DataTable GetCredentialsBySignInId(string signInId)
        {
            return _objCommonDal.GetCredentialsBySignInId(signInId);
        }

        public int GetIsCredentialsBySignInId(string signInId)
        {
            return _objCommonDal.GetIsCredentialsBySignInId(signInId);
        }

        public DataTable GetSymptom()
        {
            return _objCommonDal.GetSymptom();
        }

        public int GetPatientIdBySignInId(string signInId)
        {
            return _objCommonDal.GetPatientIdBySignInId(signInId);
        }

        public int GetDoctorServiceIdBySignInId(int type, string signInId, int organizationId)
        {
            return _objCommonDal.GetDoctorServiceIdBySignInId(type, signInId, organizationId);
        }

        public int GetDoctorServiceIdById(int type, int id, int organizationId)
        {
            return _objCommonDal.GetDoctorServiceIdById(type, id, organizationId);
        }

        public DataTable GetOrganizationIds(string signInId)
        {
            return _objCommonDal.GetOrganizationIds(signInId);
        }

        public DataTable GetOrganizationBySignIn(string signInId)
        {
            return _objCommonDal.GetOrganizationBySignIn(signInId);
        }

        public int GetOrganizationBySignInAccountType(string signInId, int accountType)
        {
            return _objCommonDal.GetOrganizationBySignInAccountType(signInId, accountType);
        }

        public int ValidateSignInByAccountTypeId(string signInId, int accountType)
        {
            return _objCommonDal.ValidateSignInByAccountTypeId(signInId, accountType);
        }

        public int GetDoctorIdBySignInId(string signInId)
        {
            return _objCommonDal.GetDoctorIdBySignInId(signInId);
        }

        public DataTable GetRecentlyRegisteredOrganization()
        {
            return _objCommonDal.GetRecentlyRegisteredOrganization();
        }

        public DataTable GetCountOfRecentlyRegistered()
        {
            return _objCommonDal.GetCountOfRecentlyRegistered();
        }

        public bool AccountSetting(string signInId, string password, bool isEmailNotification, bool isSMSNotification)
        {
            try
            {
                _objCommonDal.AccountSetting(signInId, password, isEmailNotification, isSMSNotification);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public AccountSettingDO GetAccountSetting(string signInId)
        {
            DataTable dtAccountSetting = _objCommonDal.GetAccountSetting(signInId);

            AccountSettingDO asdo = new AccountSettingDO();
            if (dtAccountSetting.Rows.Count > 0)
            {
                asdo.EmailId = dtAccountSetting.Rows[0]["EmailId"].ToString();
                asdo.MobileId = dtAccountSetting.Rows[0]["MobileId"].ToString();
                asdo.CountryId = Convert.ToInt32(dtAccountSetting.Rows[0]["CountryId"]);
                asdo.LoginId = Convert.ToInt32(dtAccountSetting.Rows[0]["LoginId"]);
                asdo.Password = dtAccountSetting.Rows[0]["Password"].ToString();
                asdo.Token = dtAccountSetting.Rows[0]["TransactionToken"].ToString();
                asdo.IsEmailActivated = Convert.ToBoolean(dtAccountSetting.Rows[0]["IsEmailActivated"]);
                asdo.IsEmailNotification = Convert.ToBoolean(dtAccountSetting.Rows[0]["IsEmailNotification"]);
                asdo.IsSMSNotification = Convert.ToBoolean(dtAccountSetting.Rows[0]["IsSMSNotification"]);
            }
            return asdo;
        }

        public bool ChangePassword(string signInId, string password)
        {
            try
            {
                _objCommonDal.ChangePassword(signInId, password);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ValidateMobileOrganization(string mobileId, int organizationId)
        {
            return _objCommonDal.ValidateMobileOrganization(mobileId, organizationId);
        }

        public int ValidateEmailOrganization(string emailId, int organizationId)
        {
            return _objCommonDal.ValidateEmailOrganization(emailId, organizationId);
        }

        public int ValidateServiceNameOrganization(string serviceName, int organizationId, int serviceId)
        {
            return _objCommonDal.ValidateServiceNameOrganization(serviceName, organizationId, serviceId);
        }

        public string ForgotPassword(string signInId)
        {
            return _objCommonDal.ForgotPassword(signInId);
        }

        public int ValidateRegistrationNumber(string registrationNumber, int registrationYear, string mobileId)
        {
            return _objCommonDal.ValidateRegistrationNumber(registrationNumber, registrationYear, mobileId);
        }

        public DataTable GetCountOfRecentlyRegisteredByOrganizationId(int organizationId)
        {
            return _objCommonDal.GetCountOfRecentlyRegisteredByOrganizationId(organizationId);
        }

        public DataTable GetCountOfRecentlyRegisteredByDoctorId(int doctorId)
        {
            return _objCommonDal.GetCountOfRecentlyRegisteredByDoctorId(doctorId);
        }

        public int ValidateDoctorSchedule(int doctorId, int day, string startTime, string endTime, int scheduleId)
        {
            return _objCommonDal.ValidateDoctorSchedule(doctorId, day, startTime, endTime, scheduleId);
        }

        public int ValidateServiceSchedule(int serviceId, int day, string startTime, string endTime, int scheduleId)
        {
            return _objCommonDal.ValidateServiceSchedule(serviceId, day, startTime, endTime, scheduleId);
        }

        public string GetCountryCodeByOrganizationId(int organziationId)
        {
            return _objCommonDal.GetCountryCodeByOrganizationId(organziationId);
        }

        public string GetCountryIdByOrganizationId(int organziationId)
        {
            return _objCommonDal.GetCountryIdByOrganizationId(organziationId);
        }

        public int GetCountryCodeByCountryId(int countryId)
        {
            return _objCommonDal.GetCountryCodeByCountryId(countryId);
        }

        public int ValidateBlockCalendar(int type, int doctorServiceTimingId, string startDate, string endDate, string startTime, string endTime, int blockType)
        {
            return _objCommonDal.ValidateBlockCalendar(type, doctorServiceTimingId, startDate, endDate, startTime, endTime, blockType);
        }

        public DataTable GetScheduleByDoctorServiceId(int doctorServiceId, int type, int scheduleId)
        {
            return _objCommonDal.GetScheduleByDoctorServiceId(doctorServiceId, type, scheduleId);
        }

        public bool ActivateAccount(int loginId)
        {
            int iCount = _objCommonDal.ActivateAccount(loginId);

            if (iCount > 0)
                return true;
            else
                return false;
        }

        public bool ActivateAccount(string mobile, string Activationcode)
        {
            int iCount = _objCommonDal.ActivateAccount(mobile, Activationcode);

            if (iCount > 0)
                return true;
            else
                return false;
        }

        public int ValidateScheduleByAppointment(int doctorServiceTimingId, int type, DateTime currentDate)
        {
            return _objCommonDal.ValidateScheduleByAppointment(doctorServiceTimingId, type, currentDate);
        }

        public int ValidateScheduleByAppointmentEndTime(int doctorServiceTimingId, int type, DateTime currentDate)
        {
            return _objCommonDal.ValidateScheduleByAppointmentEndTime(doctorServiceTimingId, type, currentDate);
        }

        public int ValidateDoctorServiceByAppointment(int doctorServiceId, int type, DateTime currentDate)
        {
            return _objCommonDal.ValidateDoctorServiceByAppointment(doctorServiceId, type, currentDate);
        }

        public int ValidateDoctorDepartmentByAppointment(int doctorId, DateTime currentDate)
        {
            return _objCommonDal.ValidateDoctorDepartmentByAppointment(doctorId, currentDate);
        }

        public int ValidateRegistrationYear(string registrationNumber, int registrationYear, string mobileId)
        {
            return _objCommonDal.ValidateRegistrationYear(registrationNumber, registrationYear, mobileId);
        }

        public bool ActivateEmail(string token)
        {
            int iCount = _objCommonDal.ActivateEmail(token);

            if (iCount > 0)
                return true;

            return false;
        }

        public bool ApproveAppointment(string appointmentId)
        {
            int iCount = _objCommonDal.ApproveAppointment(appointmentId);

            if (iCount > 0)
                return true;

            return false;
        }

        public bool SMSSwitch(string signIn)
        {
            int iCount = _objCommonDal.SMSSwitch(signIn);

            if (iCount > 0)
                return true;

            return false;
        }

        public bool EmailSwitch(string signIn)
        {
            int iCount = _objCommonDal.EmailSwitch(signIn);

            if (iCount > 0)
                return true;

            return false;
        }

        public DataRow GetActivationCodeById(string signInId)
        {
            return _objCommonDal.GetActivationCodeById(signInId);
        }

        public int ValidateEmailByLogInId(string emailId, int loginId)
        {
            return _objCommonDal.ValidateEmailByLogInId(emailId, loginId);
        }

        public int ValidateMobileByLogInId(string mobileId, int loginId)
        {
            return _objCommonDal.ValidateMobileByLogInId(mobileId, loginId);
        }

        public bool UpdateMobileAccountByLoginId(string mobile, int countryId, int loginId)
        {
            int iCount = _objCommonDal.UpdateMobileAccountByLoginId(mobile, countryId, loginId);

            if (iCount > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEmailAccountByLoginId(string email, int loginId)
        {
            int iCount = _objCommonDal.UpdateEmailAccountByLoginId(email, loginId);

            if (iCount > 0)
                return true;
            else
                return false;
        }

        public DataTable GetApprovalReadyCount(int accountTypeId, int organizationId, int doctorServiceId)
        {
            return _objCommonDal.GetApprovalReadyCount(accountTypeId, organizationId, doctorServiceId);
        }

        public int GetApprovalReadyProfileCount(int accountTypeId, int organizationId, int doctorServiceId, int scheduledId)
        {
            return _objCommonDal.GetApprovalReadyProfileCount(accountTypeId, organizationId, doctorServiceId, scheduledId);
        }

        public int ValidateForgetPasswordSMS(string Mobile)
        {
            return _objCommonDal.ValidateForgetPasswordSMS(Mobile);
        }

        public int ValidateForgetPasswordEmail(string Mobile)
        {
            return _objCommonDal.ValidateForgetPasswordEmail(Mobile);
        }

        public void InsertEmailCount(string Mobile)
        {
            _objCommonDal.InsertEmailCount(Mobile);
        }

        public DataRow ApprovalNotification(int appointmentId, int type)
        {
            return _objCommonDal.ApprovalNotification(appointmentId, type);
        }

        public void GupShupResponse(string externalId, string deliveredTS, string status, string phoneNo, string cause)
        {
            _objCommonDal.GupShupResponse(externalId, deliveredTS, status, phoneNo, cause);
        }

        public void SaveActivationAppointmentSMSCount(string Mobile, string ipAddress, int SMSCount, string createdOnDate, int isVerified)
        {
            _objCommonDal.SaveActivationAppointmentSMSCount(Mobile, ipAddress, SMSCount, createdOnDate, isVerified);
        }

        public int GetActivationAppointmentSMSCount(string Mobile, string ipAddress, string createdOnDate)
        {
            return _objCommonDal.GetActivationAppointmentSMSCount(Mobile, ipAddress, createdOnDate);
        }

        public string IsScheduleBlockDateClashed(int timingId, int type, DateTime currentDate)
        {
            return _objCommonDal.IsScheduleBlockDateClashed(timingId, type, currentDate);
        }
    }
}
