using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class OrganizationDAL : Connection
    {
        public int SaveOrganization(string organizationName, string subDomain)
        {
            //return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_InsertOrganization", organizationId, loginId, organizationName, countryId, stateId, cityId, branchName, address, addressLine1, addressLine2, postalCode, phone, mobile, timeZone, inCharge, isExternalReference, maxAppointmentDays, isApprovalSystem, isCarParkFacility, isConditionsPage, subDomain, cNameUrl, welcomeTitle, aboutOrganization, referedBy, referenceToken));
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_InsertOrganization", organizationName, subDomain));
        }

        public DataTable GetOrganization(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganization", signInId).Tables[0];
        }

        public DataTable GetOrganizationById(int id)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationById", id).Tables[0];
        }

        public DataTable GetOrganizationByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationByDoctorId", doctorId).Tables[0];
        }

        public DataTable GetOrganizationByServiceId(int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationByServiceId", serviceId).Tables[0];
        }

        public string GetOrganizationNameById(int organizationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetOrganizationNameById", organizationId).ToString();
        }

        public int ValidateOrganization(string organizationName)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_ValidateOrganization", organizationName));
        }

        public int ValidateSubDomain(string subDomain, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_ValidateSubDomain", subDomain, organizationId));
        }

        public DataTable GetOrganizationsByDoctorServiceId(int id, int type)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationsByDoctorServiceId", id, type).Tables[0];
        }

        public DataTable GetOrganizationNamebyAccountId(string signInId, int accountId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationNamebyAccountId", signInId, accountId).Tables[0];
        }

        //following are the doctorlist for particular org

        public DataTable GetDepartmentsByOrganizationId(int OrganizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetDepartmentsByOrganizationId", OrganizationId).Tables[0];
        }

        public DataTable GetDoctorServiceByOrganizationId(int OrganizationId, int DepartmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetDoctorServiceByOrganizationId", OrganizationId, DepartmentId).Tables[0];
        }

        public DataTable GetDoctorServiceSessionByOrganizationId(int DoctorserviceId, int type)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetDoctorServiceSessionByOrganizationId", DoctorserviceId, type).Tables[0];
        }

        public DataTable GetDoctorServiceById(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetDoctorServiceById", organizationId).Tables[0];
        }

        public DataTable GetAllDoctorServiceById(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetAllDoctorServiceById", organizationId).Tables[0];
        }

        public DataTable GetDoctorServiceByExceptLonginId(int organizationId, int loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetDoctorServiceByExceptLonginId", organizationId, loginId).Tables[0];
        }

        public int GetOrganizationBySubDomain(string subDomain)
        {
            DataTable dtOrganization = SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetOrganizationBySubDomain", subDomain).Tables[0];

            if (dtOrganization.Rows.Count > 0)
                return Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"]);
            else
                return 0;
        }

        public DataTable GetScheduleDoctorServiceByOrganizationId(int organizationId, int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetScheduleDoctorServiceByOrganizationId", organizationId, doctorId).Tables[0];
        }

        public void SaveBranding(int organizationId, string subDomain, string cNameUrl)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Organization_InsertBranding", organizationId, subDomain, cNameUrl);
        }

        public DataTable GetBranding(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetBranding", organizationId).Tables[0];
        }

        public string GetTimeZoneById(int doctorServiceId, int type)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetTimeZoneById", doctorServiceId, type).ToString();
        }

        public string GetTimeZoneByOrganizationId(int organizationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetTimeZoneByOrganizationId", organizationId).ToString();
        }

        public int GetActivationById(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetActivationById", organizationId));
        }

        public int GetAppointmentByOrganizationId(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetAppointmentByOrganizationId", organizationId));
        }

        public int GetDoctorServiceCountByOrganizationId(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetDoctorServiceCountByOrganizationId", organizationId));
        }

        public int GetDoctorCountByOrganizationId(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetDoctorCountByOrganizationId", organizationId));
        }

        public int GetServiceCountByOrganizationId(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetServiceCountByOrganizationId", organizationId));
        }

        public int GetScheduleCountByOrganizationId(int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetScheduleCountByOrganizationId", organizationId));
        }

        public DataRow GetAddressByDoctorTimingId(int doctorTimingId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetAddressByDoctorTimingId", doctorTimingId).Tables[0].Rows[0];
        }

        public string GetTimeZoneByDoctorserviceTimingId(int doctorServiceTimingId, int type)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Organization_GetTimeZoneByDoctorserviceTimingId", doctorServiceTimingId, type).ToString();
        }

        public DataTable GetSMSByOrganization(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSByOrganization", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetSMSByOrganizationForDoctor(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSByOrganizationForDoctor", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetRemindSMSByOrganizationForDoctorService(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetRemindSMSByOrganizationForDoctorService", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetSMSByOrganizationForService(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSByOrganizationForService", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetSMSByOrganizationForPatient(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSByOrganizationForPatient", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetRemindSMSByOrganizationForPatient(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetRemindSMSByOrganizationForPatient", fromDate, toDate, accountTypeId, organizationId).Tables[0];
        }

        public DataTable GetSMSCountByOrganization(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSCountByOrganization", organizationId).Tables[0];
        }

        public DataTable GetSMSCountByOrganizationForPeriod(string fromDate, string toDate, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSCountByOrganizationForPeriod", fromDate, toDate, organizationId).Tables[0];
        }

        public DataTable GetSMSCountByMobileForOrganizationForPeriod(string fromDate, string toDate, int organizationId, string mobile)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSCountByMobileForOrganizationForPeriod", fromDate, toDate, organizationId, mobile).Tables[0];
        }

        public DataTable GetSMSByMobile(string fromDate, string toDate, int organizationId, string mobile)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Organization_GetSMSByMobile", fromDate, toDate, organizationId, mobile).Tables[0];
        }
   }
}
 