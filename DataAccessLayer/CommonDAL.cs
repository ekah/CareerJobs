using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class CommonDAL : Connection
    {
        public string GetNewToken()
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GenerateToken").ToString();
        }

        public int ValidateEmailBySignUp(string emailId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmail", emailId));
        }

        public int ValidateMobileBySignUp(string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobile", mobileId));
        }

        public int ValidateEmail(string emailId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmailBySignIn", emailId));
        }

        public int ValidateEmailByService(string emailId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmailByService", emailId));
        }

        public int ValidateMobile(string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobileBySignIn", mobileId));
        }

        public int ValidateServiceEmail(string emailId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmailBySignInService", emailId));
        }

        public int ValidateServiceMobile(string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobileBySignInService", mobileId));
        }

        public int ValidateMobileByService(string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobileByService", mobileId));
        }


        public int ValidatePatientMobile(string SignInId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidatePatientMobileById", SignInId));
        }

        public int ValidatePatientUHID(string SignInId, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidatePatientUHID", SignInId, organizationId));
        }

        public int ValidateSignIn(string signInId, string password)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateSignIn", signInId, password));
        }

        public int ValidateSignInNonActivate(string signInId, string password)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "[USP_Common_ValidateSignInNonActivate]", signInId, password));
        }

        public string GetSignInPassword(string signInId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetSignInPassword", signInId).ToString();
        }

        public int UpdateCredentialsBySignInId(int loginId, string emailId, string mobileId, string password)
        {
            return SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_UpdateCredentialsBySignInId", loginId, emailId, mobileId, password);
        }

        public int GetAccountTypeBySignInId(string signInId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetAccountTypeBySignInId", signInId));
        }

        public List<int> GetAccountTypesBySignInId(string signInId)
        {
            DataTable dtAccounts = SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetAccountTypeBySignInId", signInId).Tables[0];

            List<int> types = new List<int>();

            for (int i = 0; i < dtAccounts.Rows.Count; i++)
            {
                types.Add(Convert.ToInt32(dtAccounts.Rows[i]["AccountTypeId"].ToString()));
            }

            return types;
        }

        public string GetNameBySignInId(string signInId, int accountTypeId, int id, int organizationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetNameBySignInId", signInId, accountTypeId, id, organizationId).ToString();
        }

        public DataTable GetCredentialsBySignInId(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetCredentialsBySignInId", signInId).Tables[0];
        }

        public int GetIsCredentialsBySignInId(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetCredentialsBySignInId", signInId).Tables[0].Rows.Count;
        }

        public DataTable GetSymptom()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetSymptom").Tables[0];
        }

        public int GetPatientIdBySignInId(string signInId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetPatientIdBySignInId", signInId));
        }

        public int GetDoctorServiceIdBySignInId(int type, string signInId, int organziationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetDoctorServiceIdBySignInId", type, signInId, organziationId));
        }

        public int GetDoctorServiceIdById(int type, int id, int organziationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetDoctorServiceIdById", type, id, organziationId));
        }

        public DataTable GetOrganizationIds(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetOrganizationIds", signInId).Tables[0];
        }

        public DataTable GetOrganizationBySignIn(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetOrganizationBySignIn", signInId).Tables[0];
        }

        public int GetOrganizationBySignInAccountType(string signInId, int accountType)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetOrganizationBySignInAccountType", signInId, accountType));
        }

        public int ValidateSignInByAccountTypeId(string signInId, int accountType)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateSignInByAccountTypeId", signInId, accountType));
        }

        public int GetDoctorIdBySignInId(string signInId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetDoctorIdBySignInId", signInId));
        }

        public DataTable GetRecentlyRegisteredOrganization()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetRecentlyRegisteredOrganization").Tables[0];
        }

        public DataTable GetCountOfRecentlyRegistered()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetCountOfRecentlyRegistered").Tables[0];
        }

        public void AccountSetting(string signInId, string password, bool isEmailNotification, bool isSMSNotification)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_AccountSetting", signInId, password, isEmailNotification, isSMSNotification);
        }

        public DataTable GetAccountSetting(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetAccountSetting", signInId).Tables[0];
        }

        public void ChangePassword(string signInId, string password)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_ChangePassword", signInId, password);
        }

        public int ValidateMobileOrganization(string mobileId, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobileOrganization", mobileId, organizationId));
        }

        public int ValidateEmailOrganization(string emailId, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmailOrganization", emailId, organizationId));
        }

        public int ValidateServiceNameOrganization(string serviceName, int organizationId, int serviceId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateServiceNameOrganization", serviceName, organizationId, serviceId));
        }

        public string ForgotPassword(string signInId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ForgotPassword", signInId).ToString();
        }

        public int ValidateRegistrationNumber(string RegistrationNumber, int registrationYear, string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateRegistrationNumber", RegistrationNumber, registrationYear, mobileId));
        }

        public DataTable GetCountOfRecentlyRegisteredByOrganizationId(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetCountOfRecentlyRegisteredByOrganizationId", organizationId).Tables[0];
        }

        public DataTable GetCountOfRecentlyRegisteredByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetCountOfRecentlyRegisteredByDoctorId", doctorId).Tables[0];
        }

        public int ValidateDoctorSchedule(int DoctorId, int Day, string StartTime, string EndTime, int ScheduleId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateDoctorSchedule", DoctorId, Day, StartTime, EndTime, ScheduleId));
        }

        public int ValidateServiceSchedule(int ServiceId, int Day, string StartTime, string EndTime, int ScheduleId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateServiceSchedule", ServiceId, Day, StartTime, EndTime, ScheduleId));
        }

        public void SaveSMS(string oldSignInId, string signInId, int accountTypeId, string smsMessage, string action, string mobileId, string externalId, int appointmentId, int organizationId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_SaveSMS", oldSignInId, signInId, accountTypeId, smsMessage, action, mobileId, externalId, appointmentId, organizationId);
        }

        public void GupShupResponse(string externalId, string deliveredTS, string status, string phoneNo, string cause)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_GupShupResponse", externalId, deliveredTS, status, phoneNo, cause);
        }

        public void SaveKeywordSMS(string phoneCode, string keyword, string location, string carrier, string contents, string phoneno, string time)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_SaveKeywordSMS", phoneCode, keyword, location, carrier, contents, phoneno, time);
        }

        public string GetCountryCodeByOrganizationId(int organziationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetCountryCodeByOrganizationId", organziationId).ToString();
        }

        public string GetCountryIdByOrganizationId(int organziationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetCountryIdByOrganizationId", organziationId).ToString();
        }

        public int GetCountryCodeByCountryId(int countryId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetCountryCodeByCountryId", countryId));
        }

        public int ValidateBlockCalendar(int type, int doctorServiceTimingId, string startDate, string endDate, string startTime, string endTime, int blockType)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateBlockCalendar", type, doctorServiceTimingId, startDate, endDate, startTime, endTime, blockType));
        }

        public DataTable GetScheduleByDoctorServiceId(int DoctorServiceId, int type, int scheduleId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetScheduleByDoctorServiceId", DoctorServiceId, type, scheduleId).Tables[0];
        }

        public int ActivateAccount(int loginId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ActivateAccount", loginId));
        }

        public int ActivateAccount(string mobile, string Activationcode)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ActivateAccountBySignInId", mobile, Activationcode));
        }

        public int ValidateScheduleByAppointment(int DoctorServiceTimingId, int Type, DateTime currentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateScheduleByAppointment", DoctorServiceTimingId, Type, currentDate));
        }

        public int ValidateScheduleByAppointmentEndTime(int DoctorServiceTimingId, int Type, DateTime currentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateScheduleByAppointmentEndTime", DoctorServiceTimingId, Type, currentDate));
        }

        public int ValidateDoctorServiceByAppointment(int DoctorServiceId, int Type, DateTime currentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateDoctorServiceByAppointment", DoctorServiceId, Type, currentDate));
        }

        public int ValidateDoctorDepartmentByAppointment(int DoctorId, DateTime currentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateDoctorDepartmentByAppointment", DoctorId, currentDate));
        }

        public int ValidateRegistrationYear(string RegistrationNumber, int registrationYear, string mobileId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateRegistrationYear", RegistrationNumber, registrationYear, mobileId));
        }

        public int ActivateEmail(string token)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ActivateEmail", token));
        }

        public int ApproveAppointment(string appointmentId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ApproveAppointment", appointmentId));
        }

        public int SMSSwitch(string signIn)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_SMSSwitch", signIn));
        }

        public int EmailSwitch(string signIn)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_EmailSwitch", signIn));
        }

        public DataRow GetActivationCodeById(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetActivationCodeById", signInId).Tables[0].Rows[0];
        }

        public int ValidateEmailByLogInId(string emailId, int loginId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateEmailByLogInId", emailId, loginId));
        }

        public int ValidateMobileByLogInId(string mobileId, int loginId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateMobileByLogInId", mobileId, loginId));
        }

        public int UpdateMobileAccountByLoginId(string mobile, int countryId, int loginId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_UpdateMobileAccountByLoginId", mobile, countryId, loginId));
        }

        public int UpdateEmailAccountByLoginId(string email, int loginId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_UpdateEmailAccountByLoginId", email, loginId));
        }

        public DataTable GetApprovalReadyCount(int accountTypeId, int organizationId, int doctorServiceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetApprovalReadyCount", accountTypeId, organizationId, doctorServiceId).Tables[0];
        }

        public int GetApprovalReadyProfileCount(int accountTypeId, int organizationId, int doctorServiceId, int scheduledId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetApprovalReadyProfileCount", accountTypeId, organizationId, doctorServiceId, scheduledId));
        }
        public int ValidateForgetPasswordSMS(string Mobile)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateForgetPasswordSMS", Mobile));
        }

        public int ValidateForgetPasswordEmail(string Mobile)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_ValidateForgetPasswordEmail", Mobile));
        }

        public void InsertEmailCount(string Mobile)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_EmailCount", Mobile);
        }

        public DataRow ApprovalNotification(int appointmentId, int type)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_EmailTemplate_ApprovalNotification", appointmentId, type).Tables[0].Rows[0];
        }

        public void SaveActivationAppointmentSMSCount(string Mobile, string ipAddress, int SMSCount, string createdOnDate, int isVerified)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Common_SaveActivationAppointmentSMSCount", Mobile, ipAddress, SMSCount, createdOnDate, isVerified);
        }

        public int GetActivationAppointmentSMSCount(string Mobile, string ipAddress, string createdOnDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_GetActivationAppointmentSMSCount", Mobile, ipAddress, createdOnDate));
        }

        public string IsScheduleBlockDateClashed(int timingId, int type, DateTime currentDate)
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, "USP_Common_IsScheduleBlockDateClashed", timingId, type, currentDate));
        }
    }
}
