using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class PatientDAL : Connection
    {
        public int SavePatient(int patientId, int loginId, string firstName, string lastName, DateTime? dateOfBirth, bool gender, int countryId, int? stateId, int? cityId, string address, string addressLine1, string addressLine2, string postalCode, string phone, string mobile, int relationshipId, int parentId, string referenceToken, int referedPatientId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_InsertPatient", patientId, loginId, firstName, lastName, dateOfBirth, gender, countryId, stateId, cityId, address, addressLine1, addressLine2, postalCode, phone, mobile, relationshipId, parentId, referenceToken, referedPatientId));
        }

        public void SavePatientPastHistory(int patientId, int pastHistoryId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_InsertPastHistory", patientId, pastHistoryId);
        }

        public void SavePatientPersonalHistory(int patientId, int personalHistoryId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_InsertPersonalHistory", patientId, personalHistoryId);
        }

        public void SavePatientFamilyHistory(int patientId, int FamilyHistoryId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_InsertFamilyHistory", patientId, FamilyHistoryId);
        }

        public void DeletePatientPastHistory(int patientId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_DeletePastHistory", patientId);
        }

        public void DeletePatientPersonalHistory(int patientId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_DeletePersonalHistory", patientId);
        }

        public void DeletePatientFamilyHistory(int patientId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_DeleteFamilyHistory", patientId);
        }

        public DataTable GetPatient(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPatient", signInId).Tables[0];
        }

        public DataTable GetPastHistory(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPastHistory", patientId).Tables[0];
        }

        public DataTable GetPersonalHistory(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPersonalHistory", patientId).Tables[0];
        }

        public DataTable GetFamilyHistory(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetFamilyHistory", patientId).Tables[0];
        }

        public DataTable GetPatientByParentId(string search, int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPatientByParentId", search, patientId).Tables[0];
        }

        public void DeletePatientByParentId(int patientId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_DeletePatientByParentId", patientId);
        }

        public DataTable GetPatientByPatientId(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPatientByPatientId", patientId).Tables[0];
        }

        public int SaveDirectPatient(string firstName, string lastName, string mobile, string password, string referenceToken, int countryId, string transactionToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_InsertDirectPatient", firstName, lastName, mobile, password, referenceToken, countryId, transactionToken));
        }

        public int InsertDirectPatientWithoutLogin(string firstName, string lastName, string mobile, string referenceToken, int countryId, string transactionToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_InsertDirectPatientWithoutLogin", firstName, lastName, mobile, referenceToken, countryId, transactionToken));
        }

        public int SaveDirectMember(string name, int patientId, string mobile, int relationshipName, string referenceToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_InsertDirectMember", name, patientId, mobile, relationshipName, referenceToken));
        }

        public int ValidateMemberName(string firstName, string lastName, int patientId, int relationshipId, int editPatientId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_ValidateMemberName", firstName, lastName, patientId, relationshipId, editPatientId));
        }

        public DataTable GetMyAppointment(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetMyAppointment", signInId).Tables[0];
        }

        public DataTable GetMyTodayAppointment(string signInId, string appointmentFrom)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetMyTodayAppointment", signInId, appointmentFrom).Tables[0];
        }

        public DataRow GetReferenceTokenBySignInId(string signInId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetReferenceTokenBySignInId", signInId).Tables[0].Rows[0];
        }

        public int GetReferedPatientIdByToken(string referenceToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_GetReferedPatientIdByToken", referenceToken));
        }

        public DataTable GetMyAppointmentByAppointmentId(int appointmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetMyAppointmentByAppointmentId", appointmentId).Tables[0];
        }

        public int GetAppointmentStatusByAppointmentId(int appointmentId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_GetAppointmentStatusByAppointmentId", appointmentId));
        }

        public DataTable DeleteAppointmentByAppointmentId(int appointmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_DeleteAppointmentByAppointmentId", appointmentId).Tables[0];
        }

        public DataTable DeleteAppointmentByAppointmentIdByDoctor(int appointmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_DeleteAppointmentByAppointmentIdByDoctor", appointmentId).Tables[0];
        }

        public void UpdatePatientAppointmentByAppointmentTime(int appointmentId, string appointmentTime, int status)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_UpdatePatientAppointmentByAppointmentTime", appointmentId, appointmentTime, status);
        }

        public DataTable GetPatientByAppointmentId(int appointmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Patient_GetPatientByAppointmentId", appointmentId).Tables[0];
        }

        public int SaveLoginPatient(int loginId, string firstName, string lastName, string mobile, string referenceToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_InsertLoginPatient", loginId, firstName, lastName, mobile, referenceToken));
        }

        public void SearchCount(int PatientId, string CountryName, string StateName, string CityName, string Speciality, int SpecialityType, int SearchCount, int SearchType)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_InsertSearchCount", PatientId, CountryName, StateName, CityName, Speciality, SpecialityType, SearchCount, SearchType);
        }

        public void InsertPatientUHID(string UHID, int patientId, int organizationId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_InsertUHID", UHID, patientId, organizationId);
        }

        public void UpdateUHID(string UHID, int patientId, int organizationId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Patient_UpdateUHID", UHID, patientId, organizationId);
        }

        public string GetPatientUHID(int patientId, int organizationId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_GetUHID", patientId, organizationId).ToString();
        }

        public int ValidatePatientUHID(int patientId, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_ValidatePatientUHID", patientId, organizationId));
        }

        public string ValidateUHID(string UHID, int organizationId, int patientId)
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_ValidateUHID", UHID, organizationId, patientId));
        }

        public int ValidateUHIDExists(string UHID, int organizationId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_ValidateUHIDExists", UHID, organizationId));
        }

        public int ValidateEditUHID(string UHID, int organizationId, int patientId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_ValidateEditUHID", UHID, organizationId, patientId));
        }

        public void UpdatePatientNameById(string patientName, int patientId)
        {
            SqlHelper.ExecuteScalar(ConnectionString, "USP_Patient_UpdatePatientNameById", patientName, patientId);
        }
   }
}
