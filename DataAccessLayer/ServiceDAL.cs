using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class ServiceDAL : Connection
    {
        public void SaveService(int serviceId, int organizationId, string serviceName, string inCharge, int departmentId, int units, string mobile, string emailId, string password, string transactionToken, string referenceToken, int countryId, bool isActivated)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Service_InsertService", serviceId, organizationId, serviceName, inCharge, departmentId, units, mobile, emailId, password, transactionToken, referenceToken, countryId, isActivated);
        }

        public void SaveSchedule(int serviceTimingId, int serviceId, string scheduleName, string address, bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, string startTime, string endTime, int patientDuration, bool isApprovalSystem, bool isApprovalNotificationSMS, bool isApprovalNotificationEmail, int maxAppointmentDays, bool isDefaultAddress, bool isCarParkFacility, bool isFCFS, int MaxApps, int appointmentType, string conditions)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Service_InsertSchedule", serviceTimingId, serviceId, scheduleName, address, sunday, monday, tuesday, wednesday, thursday, friday, saturday, startTime, endTime, patientDuration, isApprovalSystem, isApprovalNotificationSMS, isApprovalNotificationEmail, maxAppointmentDays, isDefaultAddress, isCarParkFacility, isFCFS, MaxApps, appointmentType, conditions);
        }

        public DataTable GetService(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetService", signInId).Tables[0];
        }

        public DataTable GetServiceBySearch(string search, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetServiceBySearch", search, organizationId).Tables[0];
        }

        public DataTable GetScheduleBySearch(string search, int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetScheduleBySearch", search, serviceId).Tables[0];
        }

        public DataTable GetScheduleBySearchWithoutOrganizationVerification(string search, int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetScheduleBySearchWithoutOrganizationVerification", search, serviceId).Tables[0];
        }

        public string GetServiceNameById(int serviceId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Service_GetServiceNameById", serviceId).ToString();
        }

        public DataTable GetServiceById(int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetServiceById", serviceId).Tables[0];
        }

        public void DeleteServiceById(int serviceId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Service_DeleteServiceById", serviceId);
        }

        public DataTable GetScheduleById(int scheduleId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetScheduleById", scheduleId).Tables[0];
        }

        public void DeleteScheduleById(int ServiceTimingId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Service_DeleteScheduleById", ServiceTimingId);
        }

        public DataTable GetBlockCalendarBySearch(string search, int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetBlockCalendarBySearch", search, serviceId).Tables[0];
        }

        public int VerifyAcceptance(int serviceId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Service_Acceptance", serviceId));
        }

        public void UpdateAcceptance(int serviceId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Service_UpdateAcceptance", serviceId);
        }

        public int GetServiceByEmailId(string emailId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Service_GetServiceByEmailId", emailId));
        }

        public DataTable GetEmailSMSNotification(int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Service_GetEmailSMSNotification", serviceId).Tables[0];
        }
   }
}
