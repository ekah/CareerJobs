using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class AdministrationBAL
    {
        AdministrationDAL _objAdministrationDal = new AdministrationDAL();

        public DataTable GetLoginType()
        {
            return _objAdministrationDal.GetLoginType();
        }

        public DataTable GetLoginTypeById()
        {
            return _objAdministrationDal.GetLoginTypeById();
        }

        public DataTable GetSMSDetails(int loginId, int accountTypeId)
        {
            return _objAdministrationDal.GetSMSDetails(loginId, accountTypeId);
        }

        public DataTable GetDepartment()
        {
            return _objAdministrationDal.GetDepartment();
        }

        public DataTable GetDiagnosis()
        {
            return _objAdministrationDal.GetDiagnosis();
        }

        public DataTable GetSymptom()
        {
            return _objAdministrationDal.GetSymptom();
        }

        public DataTable GetHospital()
        {
            return _objAdministrationDal.GetHospital();
        }

        public int DeleteDepartmentDiagnosisSymptomById(int TypeId, int type)
        {
            return _objAdministrationDal.DeleteDepartmentDiagnosisSymptomById(TypeId, type);
        }

        public int InsertDiagnosis(int diagnosisId, string diagnosis, string description)
        {
            return _objAdministrationDal.InsertDiagnosis(diagnosisId, diagnosis, description);
        }

        public int InsertDepartment(int departmentId, string departmentName, string description)
        {
            return _objAdministrationDal.InsertDepartment(departmentId, departmentName, description);
        }

        public int InsertSymptom(int symptomId, string symptom, string description)
        {
            return _objAdministrationDal.InsertSymptom(symptomId, symptom, description);
        }

        public string ActivateLoginById(int Id, int type)
        {
            return _objAdministrationDal.ActivateLoginById(Id, type);
        }

        public int DeleteDepartmentDiagnosisSymptomByDirectId(int TypeId, int type)
        {
            return _objAdministrationDal.DeleteDepartmentDiagnosisSymptomByDirectId(TypeId, type);
        }

        public int InsertTreatment(int departmentId, string treatmentName)
        {
            return _objAdministrationDal.InsertTreatment(departmentId, treatmentName);
        }

        public DataTable GetTreatmentByDepartmentId(int departmentId)
        {
            return _objAdministrationDal.GetTreatmentByDepartmentId(departmentId);
        }

        public void UpdateHospitalActivation(int organizationId)
        {
            _objAdministrationDal.UpdateHospitalActivation(organizationId);
        }

        public void DeleteAccountByAccountTypeId(int id, int type)
        {
            _objAdministrationDal.DeleteAccountByAccountTypeId(id, type);
        }

        public DataTable GetLoginId()
        {
            return _objAdministrationDal.GetLoginId();
        }

        public DataTable GetAccountType(int loginId)
        {
            return _objAdministrationDal.GetAccountType(loginId);
        }

        public DataTable GetLoginTableByLoginView()
        {
            return _objAdministrationDal.GetLoginTableByLoginView();
        }

        public DataTable GetAccountTypeByLoginView()
        {
            return _objAdministrationDal.GetAccountTypeByLoginView();
        }

        public DataTable GetHospitalList()
        {
            return _objAdministrationDal.GetHospitalList();
        }

        public DataTable GetDoctorServiceByOrganizationId(int organizationId)
        {
            return _objAdministrationDal.GetDoctorServiceByOrganizationId(organizationId);
        }

        public DataTable GetOrganizationByOrganizationId(int organizationId)
        {
            return _objAdministrationDal.GetOrganizationByOrganizationId(organizationId);
        }

        public DataTable GetAppointmentview()
        {
            return _objAdministrationDal.GetAppointmentview();
        }

        public DataTable GetSearchCount()
        {
            return _objAdministrationDal.GetSearchCount();
        }

        public DataTable GetRemainderSMS()
        {
            return _objAdministrationDal.GetRemainderSMS();
        }

        public DataTable GetSMSIndividual()
        {
            return _objAdministrationDal.GetSMSIndividual();
        }

        public DataTable GetExistingHospital(string mobileId)
        {
            return _objAdministrationDal.GetExistingHospital(mobileId);
        }

        public DataTable NoProfile()
        {
            return _objAdministrationDal.NoProfile();
        }

        public DataTable OrganizationNoDoctors()
        {
            return _objAdministrationDal.OrganizationNoDoctors();
        }

        public void DeleteAccountbyLoginId(int loginId)
        {
            _objAdministrationDal.DeleteAccountbyLoginId(loginId);
        }

        public void UpdateIsDeleteLoginById(int loginId)
        {
            _objAdministrationDal.UpdateIsDeleteLoginById(loginId);
        }

        public DataTable GetLoginTableDetailView()
        {
            return _objAdministrationDal.GetLoginTableDetailView();
        }
    }
}

