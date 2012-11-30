using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class DoctorDAL : Connection
    {
        public int SaveDoctor(int doctorId, int organizationId, string doctorName, DateTime? dateofBirth, bool gender, int universityId, int registrationYear, string registrationNumber, decimal experience, string degrees, string certifications, string photoName, string mobile, int departmentId, string preferredName, string emailId, string password, string transactionToken, string referenceToken, int countryId, bool isActivated)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_InsertDoctor", doctorId, organizationId, doctorName, dateofBirth, gender, universityId, registrationYear, registrationNumber, experience, degrees, certifications, photoName, mobile, departmentId, preferredName, emailId, password, transactionToken, referenceToken, countryId, isActivated));
        }

        public void SaveSchedule(int doctorTimingId, int doctorId, string scheduleName, string address, bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, string startTime, string endTime, int patientDuration, bool isApprovalSystem, bool isApprovalNotificationSMS, bool isApprovalNotificationEmail, int maxAppointmentDays, bool isDefaultAddress, bool isCarParkFacility, bool isFCFS, int MaxApps, int appointmentType, string conditions)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertSchedule", doctorTimingId, doctorId, scheduleName, address, sunday, monday, tuesday, wednesday, thursday, friday, saturday, startTime, endTime, patientDuration, isApprovalSystem, isApprovalNotificationSMS, isApprovalNotificationEmail, maxAppointmentDays, isDefaultAddress, isCarParkFacility, isFCFS, MaxApps, appointmentType, conditions);
        }

        public int DeleteSchedule(int doctorTimingId)
        {
            return SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteSchedule", doctorTimingId);
        }

        public DataTable GetDoctorBySearch(string search, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorBySearch", search, organizationId).Tables[0];
        }

        public DataTable GetScheduleBySearch(string search, int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetScheduleBySearch", search, doctorId).Tables[0];
        }

        public DataTable GetScheduleBySearchWithoutOrganizationVerification(string search, int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetScheduleBySearchWithoutOrganizationVerification", search, doctorId).Tables[0];
        }
        
        public string GetDoctorNameById(int doctorId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_GetDoctorNameById", doctorId).ToString();
        }

        public DataTable GetDoctor(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctor", signInId).Tables[0];
        }

        public DataTable GetDoctorById(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorById", doctorId).Tables[0];
        }

        public void DeleteDoctorById(int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteDoctorById", doctorId);
        }

        public DataTable GetScheduleById(int scheduleId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetScheduleById", scheduleId).Tables[0];
        }

        public void DeleteScheduleById(int scheduleId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteScheduleById", scheduleId);
        }

        public void DeleteEducationById(int educationId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteEducationById", educationId);
        }

        public void DeleteExperienceById(int experienceId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteExperienceById", experienceId);
        }

        public void UpdatePhotoNameByDoctorId(int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_UpdatePhotoNameByDoctorId", doctorId);
        }

        public DataTable GetDiagnosisByDoctorDepartmentId(string signinId, int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDiagnosisByDoctorDepartmentId", signinId, organizationId).Tables[0];
        }

        public void SaveDoctorDiagnosis(int DoctorId, int DiagnosisId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDoctorDiagnosis", DoctorId, DiagnosisId);
        }

        public void DeleteDoctorDiagnosis(int DoctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteDoctorDiagnosis", DoctorId);
        }

        public DataTable GetDiagnosisByDoctorId(int DoctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDiagnosisByDoctorId", DoctorId).Tables[0];
        }

        public void InsertDepartmentDiagnosis(int DiagnosisId, int DepartmentId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDepartmentDiagnosis", DiagnosisId, DepartmentId);
        }

        public void DeleteDepartmentDiagnosiss(int DepartmentId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteDepartmentDiagnosis", DepartmentId);
        }

        public DataTable GetDiagnosisByDepartmentId(int DepartmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDiagnosisByDepartmentId", DepartmentId).Tables[0];
        }

        public DataTable GetBlockCalendarBySearch(string search, int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetBlockCalendarBySearch", search, doctorId).Tables[0];
        }

        public DataTable GetSymptomByDiagnosisId(int DiagnosisId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetSymptomByDiagnosisId", DiagnosisId).Tables[0];
        }

        public void InsertSymptomDiagnosis(int SymptomId, int diagnosisId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertSymptomDiagnosis", SymptomId, diagnosisId);
        }

        public void DeleteSymptomDiagnosiss(int diagnosisId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteSymptomDiagnosis", diagnosisId);
        }

        public DataTable FindDoctorBySearch(string doctor)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_FindDoctorBySearch", doctor).Tables[0];
        }

        public int VerifyAcceptance(int doctorId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_Acceptance", doctorId));
        }

        public void UpdateAcceptance(int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_UpdateAcceptance", doctorId);
        }

        public int ValidatePreferredName(string preferredName, int doctorId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_ValidatePreferredName", preferredName, doctorId));
        }

        public int GetDoctorIdExistInLanding(int doctorId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_GetDoctorIdExistInLanding", doctorId));
        }

        public void SaveDoctorEducation(int educationId, string university, string degree, int countryId, int stateId, int cityId, int yearFrom, int yearTo, string notes, int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDoctorEducation", educationId, university, degree, countryId, stateId, cityId, yearFrom, yearTo, notes, doctorId);
        }

        public DataTable GetDoctorEducationByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorEducationByDoctorId", doctorId).Tables[0];
        }

        public DataTable GetDoctorEducationByEducationId(int educationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorEducationByEducationId", educationId).Tables[0];
        }

        public void SaveDoctorExperience(int experienceId, string medicalServiceName, string title, int countryId, int stateId, int cityId, int yearFrom, int monthFrom, int yearTo, int monthTo, string notes, int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDoctorExperience", experienceId, medicalServiceName, title, countryId, stateId, cityId, yearFrom, monthFrom, yearTo, monthTo, notes, doctorId);
        }

        public DataTable GetDoctorExperienceByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorExperienceByDoctorId", doctorId).Tables[0];
        }

        public DataTable GetDoctorExperienceByExperienceId(int experienceId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetDoctorExperienceByExperienceId", experienceId).Tables[0];
        }

        public void SaveDoctorEducationCollection(int oldDoctorId, int newDoctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDoctorEducationCollection", oldDoctorId, newDoctorId);
        }

        public void SaveDoctorExperienceCollection(int oldDoctorId, int newDoctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_InsertDoctorExperienceCollection", oldDoctorId, newDoctorId);
        }

        public void DeleteDoctorEducation(int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteDoctorEducation", doctorId);
        }

        public void DeleteDoctorExperience(int doctorId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Doctor_DeleteDoctorExperience", doctorId);
        }

        public int ValidateScheduleByDoctorId(int doctorId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_ValidateScheduleByDoctorId", doctorId));
        }

        public DataTable GetHospitalByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetHospitalByDoctorId", doctorId).Tables[0];
        }

        public string GetDoctorNameByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Doctor_GetDoctorNameByDoctorId", doctorId).ToString();
        }

        public DataTable GetScheduleByDoctorId(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetScheduleByDoctorId", doctorId).Tables[0];
        }

        public DataTable GetEmailSMSNotification(int doctorId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Doctor_GetEmailSMSNotification", doctorId).Tables[0];
        }
    }
}    
