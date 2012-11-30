using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class AppointmentDAL : Connection
    {
        public DataTable GetPatientByParentId(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetPatientByParentId", patientId).Tables[0];
        }

        public DataTable GetDoctorTimingByDoctorId(int doctorId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetDoctorTimingByDoctorId", doctorId, organizationId).Tables[0];
        }

        public DataTable GetScheduleTimingBetweenDatesByTimingId(int timingID, DateTime fromDate, DateTime? toDate, int actionType)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetScheduleTimingBetweenDatesByTimingId", timingID, fromDate, toDate, actionType).Tables[0];
        }


        public DataTable GetServiceTimingByServiceId(int serviceId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetServiceTimingByServiceId", serviceId, organizationId).Tables[0];
        }

        public DataTable GetDoctorTimingByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetDoctorTimingByDoctorIdOnly", doctorId).Tables[0];
        }

        public DataTable GetServiceTimingByServiceId(int serviceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetServiceTimingByServiceIdOnly", serviceId).Tables[0];
        }

        public DataRow GetDoctorTimingById(int doctorTimingId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetDoctorTimingById", doctorTimingId).Tables[0].Rows[0];
        }

        public DataRow GetServiceTimingById(int serviceTimingId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetServiceTimingById", serviceTimingId).Tables[0].Rows[0];
        }

        public DataTable GetAvailableDoctorTimingById(int doctorTimingId, DateTime dtTime)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAvailableDoctorTimingById", doctorTimingId, dtTime).Tables[0];
        }

        public DataTable GetAvailableServiceTimingById(int serviceTimingId, DateTime dtTime)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAvailableServiceTimingById", serviceTimingId, dtTime).Tables[0];
        }

        public DataRow SaveAppointment(int patientId, int organizationId, int? serviceId, int? serviceTimingId, int? doctorId, int? doctorTimingId, DateTime appointmentDate, string appointmentTime, string onCallAppointmentTime, string notes, bool isCarParking, string carNumber, int? preferentialId, string preferentialBoarding, int statusId, bool IsDirectAppointment)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_InsertAppointment", patientId, organizationId, serviceId, serviceTimingId, doctorId, doctorTimingId, appointmentDate, appointmentTime, onCallAppointmentTime, notes, isCarParking, carNumber, preferentialId, preferentialBoarding, statusId, IsDirectAppointment).Tables[0].Rows[0];
        }

        public DataTable GetScheduledAppointment(int organizationId, int type, int? id, int timingId, string appointmentDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetScheduledAppointment", organizationId, type, id, timingId, appointmentDate).Tables[0];
        }

        public DataTable GetTodayAppointments(int organizationId, int type, int id, string appointmentDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetTodayAppointments", organizationId, type, id, appointmentDate).Tables[0];
        }

        public DataTable GetOnlyTodayAppointments(int organizationId, int type, int id, string appointmentDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetOnlyTodayAppointments", organizationId, type, id, appointmentDate).Tables[0];
        }

        public DataTable GetOnlyTodayAppointmentsAllDoctor(int organizationId, string appointmentDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetOnlyTodayAppointmentsAllDoctor", organizationId, appointmentDate).Tables[0];
        }

        public DataTable GetAppointmentHistory(int organizationId, int type, int id, string appointmentFromDate, string appointmentToDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAppointmentHistory", organizationId, type, id, appointmentFromDate, appointmentToDate).Tables[0];
        }

        public DataTable GetAllDoctorAppointmentHistory(int organizationId, string appointmentFromDate, string appointmentToDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAllDoctorAppointmentHistory", organizationId, appointmentFromDate, appointmentToDate).Tables[0];
        }

        public DataTable GetAppointmentHistoryFilter(int patientId, int type, int id, string appointmentFromDate, string appointmentToDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAppointmentHistoryFilter", patientId, type, id, appointmentFromDate, appointmentToDate).Tables[0];
        }

        public DataTable GetAppointmentHistoryFilterAllDoctor(int patientId, int organizationId, string appointmentFromDate, string appointmentToDate)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetAppointmentHistoryFilterAllDoctor", patientId, organizationId, appointmentFromDate, appointmentToDate).Tables[0];
        }

        public void UpdateAppointmentStatus(string appointmentIds, int statusId, string closingNotes)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Appointment_UpdateAppointmentStatus", appointmentIds, statusId, closingNotes);
        }

        public DataTable GetOrganizationByDoctorTimingId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetOrganizationByDoctorTimingId", doctorId).Tables[0];
        }

        public DataTable GetOrganizationByServiceTimingId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetOrganizationByServiceTimingId", doctorId).Tables[0];
        }

        public void InsertBlockCalendar(int blockId, int blockTypeId, bool type, int? doctorId, int? serviceId, int? doctorTimingId, int? serviceTimingId, DateTime blockStart, DateTime blockEnd, string notes)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Appointment_InsertBlockCalendar", blockId, blockTypeId, type, doctorId, serviceId, doctorTimingId, serviceTimingId, blockStart, blockEnd, notes);
        }

        public DataTable GetBlockCalendarDates(int doctorServiceTimingId, int blockTypeId, bool type)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetBlockCalendarDates", doctorServiceTimingId, blockTypeId, type).Tables[0];
        }

        public DataTable GetBlockCalendarDatesByDoctorServiceId(int doctorServiceId, int doctorServiceTimingId, int blockTypeId, bool type)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetBlockCalendarDatesByDoctorServiceId", doctorServiceId, doctorServiceTimingId, blockTypeId, type).Tables[0];
        }

        public int ValidateAppointmentByPatient(int patientId, string appointmentTime, string appointmentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateAppointmentByPatient", patientId, appointmentTime, appointmentDate));
        }

        public int ValidateAppointmentByDoctorService(int doctorServiceId, int doctorServiceTimingId, int type, string appointmentTime, string appointmentDate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateAppointmentByDoctorService", doctorServiceId, doctorServiceTimingId, type, appointmentTime, appointmentDate));
        }

        public void DeleteBlockCalendarById(int blockId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Appointment_DeleteBlockCalendarById", blockId);
        }

        public DataTable GetEmailIdBySelectedId(string SelectedAppointmentIds)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetEmailIdBySelectedId", SelectedAppointmentIds).Tables[0];
        }

        public int ValidateAppointmentTimeByPatient(int patientId, int timingId, int type, string appointmentDate, string appointmentTime)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateWaitingTimeByPatient", patientId, timingId, type, appointmentDate, appointmentTime));
        }

        public int ValidateOnCallAppointmentByPatient(int patientId, int type, int DoctorServiceId, string appointmentDate, string appointmentTime)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateOnCallAppointmentByPatient", patientId, type, DoctorServiceId, appointmentDate, appointmentTime));
        }

        public DataTable GetDeletedBlockCalendarDates(int blockId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetDeletedBlockCalendarDates", blockId).Tables[0];
        }

        public int ValidateBlockTypeById(int blockId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateBlockTypeById", blockId));
        }

        public bool GetAppointmentsCount(int timingId, int type, string currentDate)
        {
            return Convert.ToBoolean(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_GetAppointmentsCount", timingId, type, currentDate));
        }

        public string GetScheduleEndTime(int appointmentId, int accountTypeId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_GetScheduleEndTime", appointmentId, accountTypeId).ToString();
        }

        public string GetScheduleEndTimeByAppointmentId(int appointmentId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_GetScheduleEndTimeByAppointmentId", appointmentId).ToString();
        }

        public void InsertPatientReference(int patientId, int organizationId, string referenceNumber)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Appointment_InsertPatientReference", patientId, organizationId, referenceNumber);
        }

        public DataTable GetPatientReference(int patientId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_GetPatientReference", patientId, organizationId).Tables[0];
        }

        public int GetAppointmentCountByDoctorId(int DoctorId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_GetAppointmentCountByDoctorId", DoctorId));
        }

        public int GetAppointmentCountByServiceId(int ServiceId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_GetAppointmentCountByServiceId", ServiceId));
        }

        public int ValidateCancelAppointment(string appointmentId, string currentDateTime)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateCancelAppointment", appointmentId, currentDateTime));
        }

        public int ValidateCancelAppointmentFCFS(string appointmentId, string currentDateTime)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Appointment_ValidateCancelAppointmentFCFS", appointmentId, currentDateTime));
        }

        public DataSet GetPatientSearchInfo(string type, int orgId, int actionType, int actionId, string pName, string pMobile, string pUhid, string pAppId, string appFromDate, string appToDate, string tName, bool isPageLoad, string statusId, string tId, string pId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_PatientSearch", type, orgId, actionType, actionId, pName, pMobile, pUhid, pAppId, appFromDate, appToDate, tName, isPageLoad, statusId, tId, pId);
        }

        public DataTable ManageComments(string type, int commentId = 0, string comment = "", int appointmentId = 0, int loginId = 0, int statusId = 0, int isDeleted = 0, int actionTypeId = 0, int actionId = 0)
        {

            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Appointment_ManageComments]", type, commentId, comment, appointmentId, loginId, statusId, isDeleted, actionTypeId, actionId).Tables[0];
        }

        public DataSet GetScheduleChangeInfo(int appointmentId, int organizationId, int actionType, int actionId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Common_GetScheduleChangeInfo]", appointmentId, organizationId, actionType, actionId);
        }

        public DataSet GetInfoWithComments(int appointmentId, int organizationId, int actionType, int actionId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetInfoWithComments", appointmentId, organizationId, actionType, actionId);
        }

        public DataSet GetWardFloorBed(string type, int orgId, int buildingId = 0, int floorId = 0, int wardId = 0, int bedId = 0)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Common_GetWardFloorBed", type, orgId, buildingId, floorId, wardId, bedId);
        }

        public DataTable ManageStatusChange(string appointmentIds, int statusId, int orgId, int actionTypeId, int actionId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_ManageStatusChange", appointmentIds, statusId, orgId, actionTypeId, actionId).Tables[0];
        }

        public DataTable ManageBedMapping(string type, int orgId, int doctorId, int bedId, int appId, int statusId, int actionId, int actionTypeId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Appointment_ManageBedMapping", type, orgId, doctorId, bedId, appId, statusId, actionId, actionTypeId).Tables[0];
        }

        public DataTable ManageBedMaster(string type, int orgId, int actionTypeId, int actionId, int wardId, string wardName, int floorId, string floorName, int bedId, string bedName, int buildingId, string buildingName)
        {
            DataSet dsReturn = SqlHelper.ExecuteDataset(ConnectionString, "USP_Manage_BedMaster", type, orgId, actionTypeId, actionId, wardId, wardName, floorId, floorName, bedId, bedName, buildingId, buildingName);

            if (dsReturn != null && dsReturn.Tables.Count > 0)
            {

                return dsReturn.Tables[0];
            }
            else
            {
                return null;
            }
        }
    }
}
