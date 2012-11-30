using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class AppointmentBAL
    {
        AppointmentDAL _objAppointmentDAL = new AppointmentDAL();

        public DataTable GetPatientByParentId(int patientId)
        {
            return _objAppointmentDAL.GetPatientByParentId(patientId);
        }

        public DataTable GetDoctorTimingByDoctorId(int doctorId, int organizationId)
        {
            return _objAppointmentDAL.GetDoctorTimingByDoctorId(doctorId, organizationId);
        }

        public DataTable GetServiceTimingByServiceId(int serviceId, int organizationId)
        {
            return _objAppointmentDAL.GetServiceTimingByServiceId(serviceId, organizationId);
        }

        public DataTable GetDoctorTimingByDoctorId(int doctorId)
        {
            return _objAppointmentDAL.GetDoctorTimingByDoctorId(doctorId);
        }

        public DataTable GetScheduleTimingBetweenDatesByTimingId(int timingID, DateTime fromDate, DateTime? toDate, int actionType)
        {
            return _objAppointmentDAL.GetScheduleTimingBetweenDatesByTimingId(timingID, fromDate, toDate, actionType);
        }

        public DataTable GetServiceTimingByServiceId(int serviceId)
        {
            return _objAppointmentDAL.GetServiceTimingByServiceId(serviceId);
        }

        public DataRow GetDoctorTimingById(int doctorTimingId)
        {
            return _objAppointmentDAL.GetDoctorTimingById(doctorTimingId);
        }

        public DataRow GetServiceTimingById(int serviceTimingId)
        {
            return _objAppointmentDAL.GetServiceTimingById(serviceTimingId);
        }

        public DataTable GetAvailableDoctorTimingById(int doctorTimingId, DateTime dtTime)
        {
            return _objAppointmentDAL.GetAvailableDoctorTimingById(doctorTimingId, dtTime);
        }

        public DataTable GetAvailableServiceTimingById(int serviceTimingId, DateTime dtTime)
        {
            return _objAppointmentDAL.GetAvailableServiceTimingById(serviceTimingId, dtTime);
        }

        public DataRow SaveAppointment(AppointmentDO a)
        {
            return _objAppointmentDAL.SaveAppointment(a.PatientId, a.OrganizationId, a.ServiceId, a.ServiceTimingId, a.DoctorId, a.DoctorTimingId, a.AppointmentDate, a.AppointmentTime, a.OnCallAppointmentTime, a.Notes, a.IsCarParkFacility, a.CarNumber, a.PreferentialId, a.PreferentialBoarding, a.StatusId, a.IsDirectAppointment);
        }

        public DataTable GetScheduledAppointment(int organizationId, int type, int? id, int timingId, string appointmentDate)
        {
            return _objAppointmentDAL.GetScheduledAppointment(organizationId, type, id, timingId, appointmentDate);
        }

        public DataTable GetTodayAppointments(int organizationId, int type, int id, string appointmentDate)
        {
            return _objAppointmentDAL.GetTodayAppointments(organizationId, type, id, appointmentDate);
        }

        public DataTable GetOnlyTodayAppointments(int organizationId, int type, int id, string appointmentDate)
        {
            return _objAppointmentDAL.GetOnlyTodayAppointments(organizationId, type, id, appointmentDate);
        }

        public DataTable GetOnlyTodayAppointmentsAllDoctor(int organizationId, string appointmentDate)
        {
            return _objAppointmentDAL.GetOnlyTodayAppointmentsAllDoctor(organizationId, appointmentDate);
        }

        public DataTable GetAppointmentHistory(int organizationId, int type, int id, string appointmentFromDate, string appointmentToDate)
        {
            return _objAppointmentDAL.GetAppointmentHistory(organizationId, type, id, appointmentFromDate, appointmentToDate);
        }

        public DataTable GetAllDoctorAppointmentHistory(int organizationId, string appointmentFromDate, string appointmentToDate)
        {
            return _objAppointmentDAL.GetAllDoctorAppointmentHistory(organizationId, appointmentFromDate, appointmentToDate);
        }

        public DataTable GetAppointmentHistoryFilter(int patientId, int type, int id, string appointmentFromDate, string appointmentToDate)
        {
            return _objAppointmentDAL.GetAppointmentHistoryFilter(patientId, type, id, appointmentFromDate, appointmentToDate);
        }

        public DataTable GetAppointmentHistoryFilterAllDoctor(int patientId, int organizationId, string appointmentFromDate, string appointmentToDate)
        {
            return _objAppointmentDAL.GetAppointmentHistoryFilterAllDoctor(patientId, organizationId, appointmentFromDate, appointmentToDate);
        }

        public void UpdateAppointmentStatus(string appointmentIds, int statusId, string closingNotes)
        {
            _objAppointmentDAL.UpdateAppointmentStatus(appointmentIds, statusId, closingNotes);
        }

        public AppointmentDO GetOrganizationByDoctorTimingId(int doctorTimingId)
        {
            DataTable dtOrganization = _objAppointmentDAL.GetOrganizationByDoctorTimingId(doctorTimingId);

            AppointmentDO a = null;

            if (dtOrganization.Rows.Count > 0)
            {
                a = new AppointmentDO();
                a.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                a.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                a.Address = dtOrganization.Rows[0]["ScheduleAddress"].ToString();
                a.DoctorId = Convert.ToInt32(dtOrganization.Rows[0]["DoctorId"].ToString());
            }

            return a;
        }

        public AppointmentDO GetOrganizationByServiceTimingId(int serviceTimingId)
        {
            DataTable dtOrganization = _objAppointmentDAL.GetOrganizationByServiceTimingId(serviceTimingId);

            AppointmentDO a = null;

            if (dtOrganization.Rows.Count > 0)
            {
                a = new AppointmentDO();
                a.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                a.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                a.Address = dtOrganization.Rows[0]["ScheduleAddress"].ToString();
                a.ServiceId = Convert.ToInt32(dtOrganization.Rows[0]["ServiceId"].ToString());
            }

            return a;
        }

        public void InsertBlockCalendar(BlockCalendarDO bc)
        {
            _objAppointmentDAL.InsertBlockCalendar(bc.BlockId, bc.BlockTypeId, bc.Type, bc.DoctorId, bc.ServiceId, bc.DoctorTimingId, bc.ServiceTimingId, bc.BlockStart, bc.BlockEnd, bc.Notes);
        }

        public DataTable GetBlockCalendarDates(int doctorServiceTimingId, int blockTypeId, bool type)
        {
            return _objAppointmentDAL.GetBlockCalendarDates(doctorServiceTimingId, blockTypeId, type);
        }

        public DataTable GetBlockCalendarDatesByDoctorServiceId(int doctorServiceId, int doctorServiceTimingId, int blockTypeId, bool type)
        {
            return _objAppointmentDAL.GetBlockCalendarDatesByDoctorServiceId(doctorServiceId, doctorServiceTimingId, blockTypeId, type);
        }

        public int ValidateAppointmentByPatient(int patientId, string appointmentTime, string appointmentDate)
        {
            return _objAppointmentDAL.ValidateAppointmentByPatient(patientId, appointmentTime, appointmentDate);
        }

        public int ValidateAppointmentByDoctorService(int doctorServiceId, int doctorServiceTimingId, int type, string appointmentTime, string appointmentDate)
        {
            return _objAppointmentDAL.ValidateAppointmentByDoctorService(doctorServiceId, doctorServiceTimingId, type, appointmentTime, appointmentDate);
        }

        public void DeleteBlockCalendarById(int blockId)
        {
            _objAppointmentDAL.DeleteBlockCalendarById(blockId);
        }

        public DataTable GetEmailIdBySelectedId(string selectedAppointmentIds)
        {
            return _objAppointmentDAL.GetEmailIdBySelectedId(selectedAppointmentIds);
        }

        public int ValidateAppointmentTimeByPatient(int patientId, int timingId, int type, string appointmentDate, string appointmentTime)
        {
            return _objAppointmentDAL.ValidateAppointmentTimeByPatient(patientId, timingId, type, appointmentDate, appointmentTime);
        }

        public int ValidateOnCallAppointmentByPatient(int patientId, int type, int DoctorServiceId, string appointmentDate, string appointmentTime)
        {
            return _objAppointmentDAL.ValidateOnCallAppointmentByPatient(patientId, type, DoctorServiceId, appointmentDate, appointmentTime);
        }

        public DataTable GetDeletedBlockCalendarDates(int blockId)
        {
            return _objAppointmentDAL.GetDeletedBlockCalendarDates(blockId);
        }

        public int ValidateBlockTypeById(int blockId)
        {
            return _objAppointmentDAL.ValidateBlockTypeById(blockId);
        }

        public bool GetAppointmentsCount(int timingId, int type, string currentDate)
        {
            return _objAppointmentDAL.GetAppointmentsCount(timingId, type, currentDate);
        }

        public string GetScheduleEndTime(int appointmentId, int accountTypeId)
        {
            return _objAppointmentDAL.GetScheduleEndTime(appointmentId, accountTypeId);
        }

        public string GetScheduleEndTimeByAppointmentId(int appointmentId)
        {
            return _objAppointmentDAL.GetScheduleEndTimeByAppointmentId(appointmentId);
        }

        public void InsertPatientReference(int patientId, int organizationId, string referenceNumber)
        {
            _objAppointmentDAL.InsertPatientReference(patientId, organizationId, referenceNumber);
        }

        public DataTable GetPatientReference(int patientId, int organizationId)
        {
            return _objAppointmentDAL.GetPatientReference(patientId, organizationId);
        }

        public int GetAppointmentCountByDoctorId(int DoctorId)
        {
            return _objAppointmentDAL.GetAppointmentCountByDoctorId(DoctorId);
        }

        public int GetAppointmentCountByServiceId(int ServiceId)
        {
            return _objAppointmentDAL.GetAppointmentCountByServiceId(ServiceId);
        }

        public int ValidateCancelAppointment(string appointmentId, string currentDateTime)
        {
            return _objAppointmentDAL.ValidateCancelAppointment(appointmentId, currentDateTime);
        }

        public int ValidateCancelAppointmentFCFS(string appointmentId, string currentDateTime)
        {
            return _objAppointmentDAL.ValidateCancelAppointmentFCFS(appointmentId, currentDateTime);
        }

        public DataTable GetPatientSearchInfo(string type, int orgId, int actionType, int actionId, string pName, string pMobile, string pUhid, string pAppId, string appFromDate, string appToDate, string tName, string statusId, string tId, string pId)
        {
            return GetPatientSearchInfo(type, orgId, actionType, actionId, pName, pMobile, pUhid, pAppId, appFromDate, appToDate, tName, false, statusId, tId, pId).Tables[0];
        }

        public DataSet GetPatientSearchInfo(string type, int orgId, int actionType, int actionId, string pName, string pMobile, string pUhid, string pAppId, string appFromDate, string appToDate, string tName, bool isPageLoad, string statusId, string tId, string pId)
        {
            return _objAppointmentDAL.GetPatientSearchInfo(type, orgId, actionType, actionId, pName, pMobile, pUhid, pAppId, appFromDate, appToDate, tName, isPageLoad, statusId, tId, pId);
        }

        public DataTable GetPatientNameForFill(int orgId, int actionType, int actionId, string pName)
        {
            return GetPatientSearchInfo("pname", orgId, actionType, actionId, pName, "", "", "", "", "", "", "0", "0", "0");
        }

        public DataTable GetDoctorServiceNameForFill(int orgId, string tName, int actionTypeid, int actionId)
        {
            return GetPatientSearchInfo("tname", orgId, actionTypeid, actionId, "", "", "", "", "", "", tName, "0", "0", "0");
        }

        public DataTable ManageCommentsGetCommentById(int commentId)
        {
            return _objAppointmentDAL.ManageComments("get", commentId);
        }

        public DataTable ManageCommentsInsertComment(string comment, int appointmentId, int loginId, int statusId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageComments("insert", 0, comment, appointmentId, loginId, statusId, actionTypeId, actionId);
        }

        public DataSet GetScheduleChangeInfo(int appointmentId, int organizationId, int actionType, int actionId)
        {
            return _objAppointmentDAL.GetScheduleChangeInfo(appointmentId, organizationId, actionType, actionId);

        }

        public DataSet GetInfoWithComments(int appointmentId, int organizationId, int actionType, int actionId)
        {
            return _objAppointmentDAL.GetInfoWithComments(appointmentId, organizationId, actionType, actionId);
        }

        public DataSet GetAvailableFloor(int orgId, int buildingId)
        {
            return _objAppointmentDAL.GetWardFloorBed("getfloor", orgId, buildingId, 0, 0, 0);

        }

        public DataSet GetAvailableWard(int orgId, int buildingId, int floorId)
        {
            return _objAppointmentDAL.GetWardFloorBed("getward", orgId, buildingId, floorId, 0, 0);
        }

        public DataSet GetAvailableBed(int orgId, int buildingId, int floorId, int wardId)
        {
            return _objAppointmentDAL.GetWardFloorBed("getbed", orgId, buildingId, floorId, wardId, 0);
        }


        public DataTable ManageStatusChange(string appointmentIds, int statusId, int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageStatusChange(appointmentIds, statusId, orgId, actionTypeId, actionId);
        }

        public DataTable ManageBedMappingAdmit(int orgId, int doctorId, int bedId, int appId, int statusId, int actionId, int actionTypeId)
        {
            return _objAppointmentDAL.ManageBedMapping("admit", orgId, doctorId, bedId, appId, statusId, actionId, actionTypeId);
        }
        public DataTable ManageBedMappingTransfer(int orgId, int doctorId, int bedId, int appId, int statusId, int actionId, int actionTypeId)
        {
            return _objAppointmentDAL.ManageBedMapping("transfer", orgId, doctorId, bedId, appId, statusId, actionId, actionTypeId);
        }
        public DataTable ManageBedMappingDischarge(int orgId, int bedId, int appId, int statusId, int actionId, int actionTypeId)
        {
            return _objAppointmentDAL.ManageBedMapping("discharge", orgId, 0, bedId, appId, statusId, actionId, actionTypeId);

        }

        public DataTable ManageBedMasterGetWard(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getward", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetWard(int orgId, int actionTypeId, int actionId, int floorId)
        {
            return _objAppointmentDAL.ManageBedMaster("getwardbyfid", orgId, actionTypeId, actionId, 0, "", floorId, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetBuilding(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getbuilding", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetBuildingWithFloors(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getbuildwithfloor", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetFloorsWithWards(int orgId, int actionTypeId, int actionId, int buildingId)
        {
            return _objAppointmentDAL.ManageBedMaster("getfloorwithwards", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterUpdateBuilding(int orgId, int actionTypeId, int actionId, int buildingId, string buildingName)
        {
            return _objAppointmentDAL.ManageBedMaster("mergebuilding", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", buildingId, buildingName);
        }

        public DataTable ManageBedMasterUpdateWard(int orgId, int actionTypeId, int actionId, int wardId, string wardName, int floorId, int buildingId)
        {
            return _objAppointmentDAL.ManageBedMaster("mergeward", orgId, actionTypeId, actionId, wardId, wardName, floorId, "", 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterDeleteBuilding(int orgId, int actionTypeId, int actionId, int buildingId)
        {
            return _objAppointmentDAL.ManageBedMaster("deletebuilding", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterDeleteWard(int orgId, int actionTypeId, int actionId, int wardId)
        {
            return _objAppointmentDAL.ManageBedMaster("deleteward", orgId, actionTypeId, actionId, wardId, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetFloor(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getfloor", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterGetFloor(int orgId, int actionTypeId, int actionId, int buildingId)
        {
            return _objAppointmentDAL.ManageBedMaster("getfloorbybid", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterMergeFloor(int orgId, int actionTypeId, int actionId, string floorName, int floorId, int buildingId)
        {
            return _objAppointmentDAL.ManageBedMaster("mergefloor", orgId, actionTypeId, actionId, 0, "", floorId, floorName, 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterDeleteFloor(int orgId, int actionTypeId, int actionId, int buildingId, int floorId)
        {
            return _objAppointmentDAL.ManageBedMaster("deletefloor", orgId, actionTypeId, actionId, 0, "", floorId, "", 0, "", buildingId, "");
        }

        public DataTable ManageBedMasterGetBed(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getbed", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }

        public DataTable ManageBedMasterMergeBed(int orgId, int actionTypeId, int actionId, int buildingId, int floorId, int wardId, int bedId, string bedName)
        {
            return _objAppointmentDAL.ManageBedMaster("mergebed", orgId, actionTypeId, actionId, wardId, "", floorId, "", bedId, bedName, buildingId, "");
        }

        public DataTable ManageBedMasterDeleteBed(int orgId, int actionTypeId, int actionId, int buildingId, int floorId, int wardId, int bedId)
        {
            return _objAppointmentDAL.ManageBedMaster("deletebed", orgId, actionTypeId, actionId, wardId, "", floorId, "", bedId, "", buildingId, "");
        }

        public DataTable ManageHospitalSetupGetCount(int orgId, int actionTypeId, int actionId)
        {
            return _objAppointmentDAL.ManageBedMaster("getcount", orgId, actionTypeId, actionId, 0, "", 0, "", 0, "", 0, "");
        }
    }
}
