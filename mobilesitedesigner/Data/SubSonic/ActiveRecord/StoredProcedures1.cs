


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace SubSonic.POCOS.DB{
	public partial class mobilesitedesignerDB{

        public StoredProcedure selectquery(){
            StoredProcedure sp=new StoredProcedure("selectquery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_ActivateLoginById(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_ActivateLoginById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_DeleteAccountByAccountTypeId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_DeleteAccountByAccountTypeId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_DeleteAccountbyLoginId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_DeleteAccountbyLoginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_DeleteDepartmentDiagnosisSymptomByDirectId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_DeleteDepartmentDiagnosisSymptomByDirectId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_DeleteDepartmentDiagnosisSymptomById(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_DeleteDepartmentDiagnosisSymptomById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetAccountType(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetAccountType",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetAccountTypeByLoginView(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetAccountTypeByLoginView",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetAppointmentView(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetAppointmentView",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetDepartment(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetDepartment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetDoctorServiceByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetDoctorServiceByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetDoctorWithouOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetDoctorWithouOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetExistingHospital(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetExistingHospital",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetHospital(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetHospital",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetHospitalList(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetHospitalList",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetLoginId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetLoginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetLoginTableByLoginView(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetLoginTableByLoginView",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetLoginTableDetailView(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetLoginTableDetailView",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetLoginType(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetLoginType",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetLoginTypeById(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetLoginTypeById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetOrganizationByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetOrganizationByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetRemainderSMS(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetRemainderSMS",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetSearchCount(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetSearchCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetSMSDetails(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetSMSDetails",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetSMSIndividual(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetSMSIndividual",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetSymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetSymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_GetTreatmentByDepartmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_GetTreatmentByDepartmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_InsertDepartment(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_InsertDepartment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_InsertDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_InsertDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_InsertSymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_InsertSymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_InsertTreatment(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_InsertTreatment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_ManageStatusChange(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_ManageStatusChange",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_NoProfile(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_NoProfile",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_OrganizationNoDoctors(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_OrganizationNoDoctors",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_SelectAccountbyLoginId(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_SelectAccountbyLoginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_UpdateHospitalActivation(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_UpdateHospitalActivation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Admin_UpdateIsDeleteLoginById(){
            StoredProcedure sp=new StoredProcedure("USP_Admin_UpdateIsDeleteLoginById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_DeleteBlockCalendarById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_DeleteBlockCalendarById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAllDoctorAppointmentHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAllDoctorAppointmentHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentCountByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentCountByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentCountByServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentCountByServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentHistoryBeta(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentHistoryBeta",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentHistoryFilter(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentHistoryFilter",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentHistoryFilterAllDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentHistoryFilterAllDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAppointmentsCount(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAppointmentsCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAvailableDoctorTimingById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAvailableDoctorTimingById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetAvailableServiceTimingById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetAvailableServiceTimingById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetBlockCalendarDates(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetBlockCalendarDates",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetBlockCalendarDatesByDoctorServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetBlockCalendarDatesByDoctorServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDeletedBlockCalendarDates(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDeletedBlockCalendarDates",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDoctorTimingByAppointmentDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDoctorTimingByAppointmentDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDoctorTimingByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDoctorTimingByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDoctorTimingByDoctorIdOnly(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDoctorTimingByDoctorIdOnly",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDoctorTimingById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDoctorTimingById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetDoctorTimingByServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetDoctorTimingByServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetEmailIdBySelectedId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetEmailIdBySelectedId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetOnlyTodayAppointments(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetOnlyTodayAppointments",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetOnlyTodayAppointmentsAllDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetOnlyTodayAppointmentsAllDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetOrganizationByDoctorTimingId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetOrganizationByDoctorTimingId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetOrganizationByServiceTimingId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetOrganizationByServiceTimingId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetPatientByParentId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetPatientByParentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetPatientReference(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetPatientReference",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetScheduledAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetScheduledAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetScheduleEndTime(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetScheduleEndTime",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetScheduleEndTimeByAppointmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetScheduleEndTimeByAppointmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetScheduleTimingBetweenDatesByTimingId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetScheduleTimingBetweenDatesByTimingId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetServiceTimingById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetServiceTimingById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetServiceTimingByServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetServiceTimingByServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetServiceTimingByServiceIdOnly(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetServiceTimingByServiceIdOnly",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_GetTodayAppointments(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_GetTodayAppointments",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_InsertAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_InsertAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_InsertBlockCalendar(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_InsertBlockCalendar",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_InsertPatientReference(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_InsertPatientReference",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ManageBedMapping(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ManageBedMapping",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ManageComments(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ManageComments",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_PatientSearch(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_PatientSearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_PatientSearch_Bak(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_PatientSearch_Bak",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_UpdateAppointmentStatus(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_UpdateAppointmentStatus",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_UpdateWinServiceDoctorServiceDetail(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_UpdateWinServiceDoctorServiceDetail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_UpdateWinServicePatientDetail(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_UpdateWinServicePatientDetail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateAppointmentByDoctorService(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateAppointmentByDoctorService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateAppointmentByPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateAppointmentByPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateBlockTypeById(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateBlockTypeById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateCancelAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateCancelAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateCancelAppointmentFCFS(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateCancelAppointmentFCFS",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateOnCallAppointmentByPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateOnCallAppointmentByPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_ValidateWaitingTimeByPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_ValidateWaitingTimeByPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_WinServiceDoctorServiceDetail(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_WinServiceDoctorServiceDetail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Appointment_WinServicePatientDetail(){
            StoredProcedure sp=new StoredProcedure("USP_Appointment_WinServicePatientDetail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_AccountSetting(){
            StoredProcedure sp=new StoredProcedure("USP_Common_AccountSetting",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ActivateAccount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ActivateAccount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ActivateAccountBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ActivateAccountBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ActivateEmail(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ActivateEmail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ApproveAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ApproveAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ChangePassword(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ChangePassword",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_EmailCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_EmailCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_EmailSwitch(){
            StoredProcedure sp=new StoredProcedure("USP_Common_EmailSwitch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ForgotPassword(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ForgotPassword",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GenerateToken(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GenerateToken",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetAccountSetting(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetAccountSetting",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetAccountTypeBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetAccountTypeBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetActivationAppointmentSMSCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetActivationAppointmentSMSCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetActivationCodeById(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetActivationCodeById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetAppointmentComments(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetAppointmentComments",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetApprovalReadyCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetApprovalReadyCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetApprovalReadyProfileCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetApprovalReadyProfileCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountOfRecentlyRegistered(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountOfRecentlyRegistered",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountOfRecentlyRegisteredByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountOfRecentlyRegisteredByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountOfRecentlyRegisteredByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountOfRecentlyRegisteredByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountryCodeByCountryId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountryCodeByCountryId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountryCodeByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountryCodeByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCountryIdByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCountryIdByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetCredentialsBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetCredentialsBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetDoctorIdBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetDoctorIdBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetDoctorServiceIdById(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetDoctorServiceIdById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetDoctorServiceIdBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetDoctorServiceIdBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetMobileIdBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetMobileIdBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetNameBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetNameBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetOrganizationBySignIn(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetOrganizationBySignIn",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetOrganizationBySignInAccountType(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetOrganizationBySignInAccountType",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetOrganizationIds(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetOrganizationIds",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetPatientIdBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetPatientIdBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetRecentlyRegisteredOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetRecentlyRegisteredOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetScheduleByDoctorServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetScheduleByDoctorServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetScheduleChangeInfo(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetScheduleChangeInfo",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetSignInPassword(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetSignInPassword",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetSymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetSymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GetWardFloorBed(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GetWardFloorBed",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_GupShupResponse(){
            StoredProcedure sp=new StoredProcedure("USP_Common_GupShupResponse",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_IsScheduleBlockDateClashed(){
            StoredProcedure sp=new StoredProcedure("USP_Common_IsScheduleBlockDateClashed",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_SaveActivationAppointmentSMSCount(){
            StoredProcedure sp=new StoredProcedure("USP_Common_SaveActivationAppointmentSMSCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_SaveKeywordSMS(){
            StoredProcedure sp=new StoredProcedure("USP_Common_SaveKeywordSMS",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_SaveSMS(){
            StoredProcedure sp=new StoredProcedure("USP_Common_SaveSMS",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_SMSSwitch(){
            StoredProcedure sp=new StoredProcedure("USP_Common_SMSSwitch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_UpdateCredentialsBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_UpdateCredentialsBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_UpdateEmailAccountByLoginId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_UpdateEmailAccountByLoginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_UpdateMobileAccountByLoginId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_UpdateMobileAccountByLoginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateBlockCalendar(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateBlockCalendar",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateDoctorDepartmentByAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateDoctorDepartmentByAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateDoctorSchedule(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateDoctorSchedule",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateDoctorServiceByAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateDoctorServiceByAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmail(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmailByLogInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmailByLogInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmailByService(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmailByService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmailBySignIn(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmailBySignIn",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmailBySignInService(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmailBySignInService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateEmailOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateEmailOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateForgetPasswordEmail(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateForgetPasswordEmail",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateForgetPasswordSMS(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateForgetPasswordSMS",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobile(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobile",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobileByLogInId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobileByLogInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobileByService(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobileByService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobileBySignIn(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobileBySignIn",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobileBySignInService(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobileBySignInService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateMobileOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateMobileOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidatePatientMobileById(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidatePatientMobileById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidatePatientUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidatePatientUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateRegistrationNumber(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateRegistrationNumber",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateRegistrationYear(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateRegistrationYear",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateScheduleByAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateScheduleByAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateScheduleByAppointmentEndTime(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateScheduleByAppointmentEndTime",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateServiceNameOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateServiceNameOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateServiceSchedule(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateServiceSchedule",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateSignIn(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateSignIn",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateSignInByAccountTypeId(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateSignInByAccountTypeId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Common_ValidateSignInNonActivate(){
            StoredProcedure sp=new StoredProcedure("USP_Common_ValidateSignInNonActivate",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_Acceptance(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_Acceptance",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteDepartmentDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteDepartmentDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteDoctorById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteDoctorById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteDoctorDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteDoctorDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteDoctorEducation(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteDoctorEducation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteDoctorExperience(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteDoctorExperience",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteEducationById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteEducationById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteExperienceById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteExperienceById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteSchedule(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteSchedule",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteScheduleById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteScheduleById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_DeleteSymptomDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_DeleteSymptomDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_FindDoctorBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_FindDoctorBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetBlockCalendarBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetBlockCalendarBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDiagnosisByDepartmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDiagnosisByDepartmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDiagnosisByDoctorDepartmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDiagnosisByDoctorDepartmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDiagnosisByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDiagnosisByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorEducationByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorEducationByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorEducationByEducationId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorEducationByEducationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorExperienceByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorExperienceByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorExperienceByExperienceId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorExperienceByExperienceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorNameByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorNameByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetDoctorNameById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetDoctorNameById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetEmailSMSNotification(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetEmailSMSNotification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetHospitalByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetHospitalByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetScheduleByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetScheduleByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetScheduleById(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetScheduleById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetScheduleBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetScheduleBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetScheduleBySearchWithoutOrganizationVerification(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetScheduleBySearchWithoutOrganizationVerification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_GetSymptomByDiagnosisId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_GetSymptomByDiagnosisId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDepartmentDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDepartmentDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctorDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctorDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctorEducation(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctorEducation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctorEducationCollection(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctorEducationCollection",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctorExperience(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctorExperience",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertDoctorExperienceCollection(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertDoctorExperienceCollection",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertSchedule(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertSchedule",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_InsertSymptomDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_InsertSymptomDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_UpdateAcceptance(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_UpdateAcceptance",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_UpdatePhotoNameByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_UpdatePhotoNameByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_ValidatePreferredName(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_ValidatePreferredName",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Doctor_ValidateScheduleByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Doctor_ValidateScheduleByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_EmailTemplate_ApprovalNotification(){
            StoredProcedure sp=new StoredProcedure("USP_EmailTemplate_ApprovalNotification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_GETLagitudeandLatitudebyIP(){
            StoredProcedure sp=new StoredProcedure("USP_GETLagitudeandLatitudebyIP",this.Provider);
            return sp;
        }
        public StoredProcedure USP_GetMapBasedSearch(){
            StoredProcedure sp=new StoredProcedure("USP_GetMapBasedSearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CitySelectByClientIDCountryStateID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CitySelectByClientIDCountryStateID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CitySelectByClientIDCountryStateIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CitySelectByClientIDCountryStateIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CitySelectByClientIDCountryStateIDVisibleByAdmin(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CitySelectByClientIDCountryStateIDVisibleByAdmin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CountryByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CountryByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CountrySelectByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CountrySelectByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CountrySelectByClientIDVisibleInJobs(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CountrySelectByClientIDVisibleInJobs",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_CountrySelectInStateByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_CountrySelectInStateByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteCandidateDetailsById(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteCandidateDetailsById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteHrLogin(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteHrLogin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteJobByClienId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteJobByClienId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteLocation(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteLocation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_DeleteSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_DeleteSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FacilitySelectByClientID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FacilitySelectByClientID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FacilitySelectByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FacilitySelectByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FacilitySelectByClientIDVisibleInJobs(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FacilitySelectByClientIDVisibleInJobs",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FacilitySelectByFacid(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FacilitySelectByFacid",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FacilitySelectByFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FacilitySelectByFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FindJobsAssociateWithFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FindJobsAssociateWithFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FindJobsAssociateWithLocation(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FindJobsAssociateWithLocation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_FindJobsAssociateWithSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_FindJobsAssociateWithSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_GetNewsLetterByEmailClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_GetNewsLetterByEmailClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_GetSubDomainNameByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_GetSubDomainNameByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HOClientAlreadyExists(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HOClientAlreadyExists",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HOColVisibleSelectByVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HOColVisibleSelectByVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HOColVisibleSelectByVisibleByAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HOColVisibleSelectByVisibleByAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HrLoginSelectByClientID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HrLoginSelectByClientID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HrLoginSelectByClientIDByAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HrLoginSelectByClientIDByAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HrLoginSelectByUserName(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HrLoginSelectByUserName",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_HrLoginSelectByUserNameById(){
            StoredProcedure sp=new StoredProcedure("USP_Job_HrLoginSelectByUserNameById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertApply(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertApply",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertNewsLetter(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertNewsLetter",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateFacilityByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateFacilityByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateHOColVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateHOColVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateHrLogin(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateHrLogin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateJob(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateJob",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateLocation(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateLocation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateSDColVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateSDColVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateSpecialityByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateSpecialityByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateSRColVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateSRColVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_InsertUpdateSWColVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_InsertUpdateSWColVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_JobsSelectByClientID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_JobsSelectByClientID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_LocationSelectByIds(){
            StoredProcedure sp=new StoredProcedure("USP_Job_LocationSelectByIds",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_LocationSelectByLId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_LocationSelectByLId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SDColVisibleSelectByVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SDColVisibleSelectByVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SDColVisibleSelectByVisibleAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SDColVisibleSelectByVisibleAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SearchResults(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SearchResults",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectByHospitalByChar(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectByHospitalByChar",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectBySpecialityByChar(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectBySpecialityByChar",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectCandidateByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectCandidateByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectCandidateByClientIdByAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectCandidateByClientIdByAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectCandidateDetailsByAidClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectCandidateDetailsByAidClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectDepartmentByClient(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectDepartmentByClient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectJob(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectJob",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectJobByJobId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectJobByJobId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectJobByJobIdByVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectJobByJobIdByVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectLocation(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectLocation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectLocationByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectLocationByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectMasterCityByCountryStateID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectMasterCityByCountryStateID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectMasterCountry(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectMasterCountry",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectMasterSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectMasterSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectMasterStateByCountryID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectMasterStateByCountryID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectOrganizationBasedOnFacility(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectOrganizationBasedOnFacility",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SelectTopJobsByClientId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SelectTopJobsByClientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SpecialitySelectByClientID(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SpecialitySelectByClientID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SpecialitySelectByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SpecialitySelectByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SpecialitySelectByClientIDVisibleInJobs(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SpecialitySelectByClientIDVisibleInJobs",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SpecialitySelectBySpcId(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SpecialitySelectBySpcId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SpecialitySelectBySpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SpecialitySelectBySpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SRColVisibleSelectByVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SRColVisibleSelectByVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SRColVisibleSelectByVisibleByAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SRColVisibleSelectByVisibleByAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_StateSelectInStateByClientIDVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_StateSelectInStateByClientIDVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_StateSelectInStateByClientIDVisibleByAdmin(){
            StoredProcedure sp=new StoredProcedure("USP_Job_StateSelectInStateByClientIDVisibleByAdmin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SubAdminLoginSelectByUserName(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SubAdminLoginSelectByUserName",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SWColVisibleSelectByVisible(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SWColVisibleSelectByVisible",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_SWColVisibleSelectByVisibleByAll(){
            StoredProcedure sp=new StoredProcedure("USP_Job_SWColVisibleSelectByVisibleByAll",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Job_UpdateCandidateDetails(){
            StoredProcedure sp=new StoredProcedure("USP_Job_UpdateCandidateDetails",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_DeleteImageGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_DeleteImageGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_DeleteMainTab(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_DeleteMainTab",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_DeleteSubTab(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_DeleteSubTab",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_DeleteVideoGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_DeleteVideoGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetAllImageGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetAllImageGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetBanner(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetBanner",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetBannerById(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetBannerById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetDoctorIdExistInLanding(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetDoctorIdExistInLanding",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetImageById(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetImageById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetImageGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetImageGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetImageGalleryCount(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetImageGalleryCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetLanding(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetLanding",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetLandingPublish(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetLandingPublish",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetMainTabs(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetMainTabs",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetSubTabs(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetSubTabs",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetVideoGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetVideoGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_GetVideoGalleryCount(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_GetVideoGalleryCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertImageGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertImageGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertLanding(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertLanding",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertLandingPublish(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertLandingPublish",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertMainTab(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertMainTab",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertSubTab(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertSubTab",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_InsertVideoGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_InsertVideoGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_PublishVersion(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_PublishVersion",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Landing_UpdateImageGallery(){
            StoredProcedure sp=new StoredProcedure("USP_Landing_UpdateImageGallery",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetAccount(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetAccount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetAccountByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetAccountByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetAccountByPatientId(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetAccountByPatientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetAccounts(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetAccounts",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetLogin(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetLogin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetLoginNew(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetLoginNew",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetLoginWithoutActivate(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetLoginWithoutActivate",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_GetZipDailConfirmation(){
            StoredProcedure sp=new StoredProcedure("USP_Login_GetZipDailConfirmation",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_InsertAccount(){
            StoredProcedure sp=new StoredProcedure("USP_Login_InsertAccount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_InsertTransactionToken(){
            StoredProcedure sp=new StoredProcedure("USP_Login_InsertTransactionToken",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_UpdateKeywordRegistration(){
            StoredProcedure sp=new StoredProcedure("USP_Login_UpdateKeywordRegistration",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Login_UpdateZipDailVerification(){
            StoredProcedure sp=new StoredProcedure("USP_Login_UpdateZipDailVerification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Manage_BedMaster(){
            StoredProcedure sp=new StoredProcedure("USP_Manage_BedMaster",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetAllRelationship(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetAllRelationship",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetCity(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetCity",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetCountry(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetCountry",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetDepartment(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetDepartment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetDiagnosis(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetDiagnosis",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetFamilyHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetFamilyHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetPastHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetPastHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetPersonalHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetPersonalHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetPreferential(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetPreferential",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetRelationship(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetRelationship",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetState(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetState",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetStatus(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetStatus",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetSymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetSymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Master_GetUniversity(){
            StoredProcedure sp=new StoredProcedure("USP_Master_GetUniversity",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetActivationById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetActivationById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetAddressByDoctorTimingId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetAddressByDoctorTimingId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetAllDoctorServiceById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetAllDoctorServiceById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetAppointmentByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetAppointmentByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetBranding(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetBranding",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDepartmentsByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDepartmentsByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorCountByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorCountByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorServiceByExceptLonginId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorServiceByExceptLonginId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorServiceById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorServiceById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorServiceByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorServiceByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorServiceCountByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorServiceCountByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetDoctorServiceSessionByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetDoctorServiceSessionByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationByDoctorId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationByDoctorId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationByServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationByServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationBySubDomain(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationBySubDomain",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationNamebyAccountId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationNamebyAccountId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationNameById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationNameById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetOrganizationsByDoctorServiceId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetOrganizationsByDoctorServiceId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetRemindSMSByOrganizationForDoctorService(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetRemindSMSByOrganizationForDoctorService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetRemindSMSByOrganizationForPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetRemindSMSByOrganizationForPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetScheduleCountByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetScheduleCountByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetScheduleDoctorServiceByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetScheduleDoctorServiceByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetServiceCountByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetServiceCountByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSByMobile(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSByMobile",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSByOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSByOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSByOrganizationForDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSByOrganizationForDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSByOrganizationForPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSByOrganizationForPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSByOrganizationForService(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSByOrganizationForService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSCountByMobileForOrganizationForPeriod(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSCountByMobileForOrganizationForPeriod",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSCountByOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSCountByOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetSMSCountByOrganizationForPeriod(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetSMSCountByOrganizationForPeriod",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetTimeZoneByDoctorserviceTimingId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetTimeZoneByDoctorserviceTimingId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetTimeZoneById(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetTimeZoneById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_GetTimeZoneByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_GetTimeZoneByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_InsertBranding(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_InsertBranding",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_InsertOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_InsertOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_ValidateOrganization(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_ValidateOrganization",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Organization_ValidateSubDomain(){
            StoredProcedure sp=new StoredProcedure("USP_Organization_ValidateSubDomain",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeleteAppointmentByAppointmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeleteAppointmentByAppointmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeleteAppointmentByAppointmentIdByDoctor(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeleteAppointmentByAppointmentIdByDoctor",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeleteFamilyHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeleteFamilyHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeletePastHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeletePastHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeletePatientByParentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeletePatientByParentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_DeletePersonalHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_DeletePersonalHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetAppointmentStatusByAppointmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetAppointmentStatusByAppointmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetDetailsForAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetDetailsForAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetFamilyHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetFamilyHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetInfoWithComments(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetInfoWithComments",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetMyAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetMyAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetMyAppointmentByAppointmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetMyAppointmentByAppointmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetMyTodayAppointment(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetMyTodayAppointment",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPastHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPastHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPatientByAppointmentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPatientByAppointmentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPatientByParentId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPatientByParentId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPatientByPatientId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPatientByPatientId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetPersonalHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetPersonalHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetReferedPatientIdByToken(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetReferedPatientIdByToken",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetReferenceTokenBySignInId(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetReferenceTokenBySignInId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_GetUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_GetUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertDirectMember(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertDirectMember",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertDirectPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertDirectPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertDirectPatientWithoutLogin(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertDirectPatientWithoutLogin",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertFamilyHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertFamilyHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertLoginPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertLoginPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertPastHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertPastHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertPersonalHistory(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertPersonalHistory",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertSearchCount(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertSearchCount",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_InsertUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_InsertUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_UpdatePatientAppointmentByAppointmentTime(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_UpdatePatientAppointmentByAppointmentTime",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_UpdatePatientNameById(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_UpdatePatientNameById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_UpdateUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_UpdateUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_ValidateEditUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_ValidateEditUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_ValidateMemberName(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_ValidateMemberName",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_ValidatePatientUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_ValidatePatientUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_ValidateUHID(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_ValidateUHID",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Patient_ValidateUHIDExists(){
            StoredProcedure sp=new StoredProcedure("USP_Patient_ValidateUHIDExists",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetCity(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetCity",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetCountry(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetCountry",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetCountryByAccountTypeId(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetCountryByAccountTypeId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetPatient(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetPatient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetPostalcode(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetPostalcode",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetServiceSpecialityByOrganizationId(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetServiceSpecialityByOrganizationId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetSpeciality(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetSpeciality",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetSpecialityByHospital(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetSpecialityByHospital",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetState(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetState",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetSymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetSymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetSymptomByHospital(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetSymptomByHospital",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Search_GetSymptomIdBySymptom(){
            StoredProcedure sp=new StoredProcedure("USP_Search_GetSymptomIdBySymptom",this.Provider);
            return sp;
        }
        public StoredProcedure USP_SelectDepartmentByClient(){
            StoredProcedure sp=new StoredProcedure("USP_SelectDepartmentByClient",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_Acceptance(){
            StoredProcedure sp=new StoredProcedure("USP_Service_Acceptance",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_DeleteScheduleById(){
            StoredProcedure sp=new StoredProcedure("USP_Service_DeleteScheduleById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_DeleteServiceById(){
            StoredProcedure sp=new StoredProcedure("USP_Service_DeleteServiceById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetBlockCalendarBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetBlockCalendarBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetEmailSMSNotification(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetEmailSMSNotification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetScheduleById(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetScheduleById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetScheduleBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetScheduleBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetScheduleBySearchWithoutOrganizationVerification(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetScheduleBySearchWithoutOrganizationVerification",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetService(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetServiceByEmailId(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetServiceByEmailId",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetServiceById(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetServiceById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetServiceBySearch(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetServiceBySearch",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_GetServiceNameById(){
            StoredProcedure sp=new StoredProcedure("USP_Service_GetServiceNameById",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_InsertSchedule(){
            StoredProcedure sp=new StoredProcedure("USP_Service_InsertSchedule",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_InsertService(){
            StoredProcedure sp=new StoredProcedure("USP_Service_InsertService",this.Provider);
            return sp;
        }
        public StoredProcedure USP_Service_UpdateAcceptance(){
            StoredProcedure sp=new StoredProcedure("USP_Service_UpdateAcceptance",this.Provider);
            return sp;
        }
        public StoredProcedure USP_WinService_GetPreferredNames(){
            StoredProcedure sp=new StoredProcedure("USP_WinService_GetPreferredNames",this.Provider);
            return sp;
        }
        public StoredProcedure ValidateUHIDExists(){
            StoredProcedure sp=new StoredProcedure("ValidateUHIDExists",this.Provider);
            return sp;
        }
	
	}
	
}
 