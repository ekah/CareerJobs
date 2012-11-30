using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class AdministrationDAL : Connection
    {
        public DataTable GetLoginType()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_GetLoginType").Tables[0];
        }

        public DataTable GetLoginTypeById()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_GetLoginTypeById").Tables[0];
        }

        public DataTable GetSMSDetails(int loginId, int accountTypeId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetSMSDetails]", loginId, accountTypeId).Tables[0];
        }

        public DataTable GetDepartment()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetDepartment]").Tables[0];
        }

        public DataTable GetDiagnosis()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetDiagnosis]").Tables[0];
        }

        public DataTable GetSymptom()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetSymptom]").Tables[0];
        }

        public DataTable GetHospital()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetHospital]").Tables[0];
        }

        public int DeleteDepartmentDiagnosisSymptomById(int TypeId, int Type)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_DeleteDepartmentDiagnosisSymptomById]", TypeId, Type));
        }

        public int InsertDiagnosis(int DiagnosisId, string  Diagnosis, string Description)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_InsertDiagnosis]",DiagnosisId, Diagnosis, Description));
        }

        public int InsertDepartment(int DepartmentId, string DepartmentName, string Description)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_InsertDepartment]", DepartmentId, DepartmentName, Description));
        }

        public int InsertSymptom(int SymptomId, string Symptom, string Description)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_InsertSymptom]", SymptomId, Symptom, Description));
        }

        public string ActivateLoginById(int Id, int Type)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "[USP_Admin_ActivateLoginById]", Id, Type).ToString();
        }

        public int DeleteDepartmentDiagnosisSymptomByDirectId(int TypeId, int Type)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_DeleteDepartmentDiagnosisSymptomByDirectId]", TypeId, Type));
        }

        public int InsertTreatment(int departmentId, string treatmentName)
        {
            return Convert.ToInt32(SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_InsertTreatment]", departmentId, treatmentName));
        }

        public DataTable GetTreatmentByDepartmentId(int DepartmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_GetTreatmentByDepartmentId", DepartmentId).Tables[0];
        }

        public void UpdateHospitalActivation(int organizationId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Admin_UpdateHospitalActivation", organizationId);
        }

        public void DeleteAccountByAccountTypeId(int id, int type)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Admin_DeleteAccountByAccountTypeId", id, type);
        }

        public DataTable GetLoginId()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_GetLoginId").Tables[0];
        }

        public DataTable GetAccountType(int loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetAccountType]", loginId).Tables[0];
        }

        public DataTable GetLoginTableByLoginView()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Admin_GetLoginTableByLoginView").Tables[0];
        }

        public DataTable GetAccountTypeByLoginView()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetAccountTypeByLoginView]").Tables[0];
        }

        public DataTable GetHospitalList()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetHospitalList]").Tables[0];
        }

        public DataTable GetDoctorServiceByOrganizationId(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetDoctorServiceByOrganizationId]", organizationId).Tables[0];
        }

        public DataTable GetOrganizationByOrganizationId(int organizationId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetOrganizationByOrganizationId]", organizationId).Tables[0];
        }

        public DataTable GetAppointmentview()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetAppointmentview]").Tables[0];
        }

        public DataTable GetSearchCount()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetSearchCount]").Tables[0];
        }

        public DataTable GetRemainderSMS()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetRemainderSMS]").Tables[0];
        }

        public DataTable GetSMSIndividual()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetSMSIndividual]").Tables[0];
        }

        public DataTable GetExistingHospital(string mobileId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetExistingHospital]", mobileId).Tables[0];
        }

        public DataTable NoProfile()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_NoProfile]").Tables[0];
        }
     
        public DataTable OrganizationNoDoctors()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_OrganizationNoDoctors]").Tables[0];
        }

        public void DeleteAccountbyLoginId(int loginId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_DeleteAccountbyLoginId]", loginId);
        }

        public void UpdateIsDeleteLoginById(int loginId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "[USP_Admin_UpdateIsDeleteLoginById]", loginId);
        }

        public DataTable GetLoginTableDetailView()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "[USP_Admin_GetLoginTableDetailView]").Tables[0];
        }
    }
}