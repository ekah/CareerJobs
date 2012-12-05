



using System;
namespace mobilesitedesigner.Data.Standalone {

public class UVW_HospitalByPostalCode {

public int ID { get;set; }
public int Type { get;set; }
public int? OrganizationId { get;set; }
public string Name { get;set; }
public int? DepartmentId { get;set; }
public string DepartmentName { get;set; }
public string OrganizationName { get;set; }
public int? CountryId { get;set; }
public int? StateId { get;set; }
public int? CityId { get;set; }
public string PostalCode { get;set; }
}public class TBL_Patient_Reference {

public int ReferenceId { get;set; }
public int? PatientId { get;set; }
public int? OrganizationId { get;set; }
public string ReferenceNumber { get;set; }
}public class TBL_Master_Building {

public int Id { get;set; }
public int? OrganizationId { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public string Name { get;set; }
}public class TBL_Master_SymptomGroup {

public int SymptomGroupId { get;set; }
public string SymptomGroup { get;set; }
public string Description { get;set; }
public int? RequestedBy { get;set; }
public bool? IsApproved { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Master_Floor {

public int Id { get;set; }
public int BuildingId { get;set; }
public int? OrganizationId { get;set; }
public string Name { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class Tbl_Master_Ward {

public int Id { get;set; }
public string Name { get;set; }
public int OrganizationId { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public int? FloorId { get;set; }
public int? BuildingId { get;set; }
}public class TBL_Rating {

public int RatingId { get;set; }
public int? AppointmentId { get;set; }
public string Rating { get;set; }
}public class TBL_Master_Symptom {

public int SymptomId { get;set; }
public int? SymptomGroupId { get;set; }
public string Symptom { get;set; }
public string Description { get;set; }
public int? RequestedBy { get;set; }
public bool? IsApproved { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public bool? IsTreatment { get;set; }
}public class TBL_Master_Preferential {

public int PreferentialId { get;set; }
public string PreferentialName { get;set; }
}public class TBL_Master_Diagnosis {

public int DiagnosisId { get;set; }
public string Diagnosis { get;set; }
public string Description { get;set; }
public int? RequestedBy { get;set; }
public bool? IsApproved { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public bool? IsTreatment { get;set; }
}public class TBL_Answer {

public int AnswerId { get;set; }
public int? QuestionId { get;set; }
public string Answer { get;set; }
public int? DoctorId { get;set; }
public bool? IsPatient { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_SMS {

public int Id { get;set; }
public int? LoginId { get;set; }
public int? OrganizationId { get;set; }
public string Mobile { get;set; }
public int? AccountId { get;set; }
public int? AccountTypeId { get;set; }
public int? AppointmentId { get;set; }
public string SMSMessage { get;set; }
public string Action { get;set; }
public int? EmailCount { get;set; }
public string MobileId { get;set; }
public string ExternalId { get;set; }
public DateTime? CreatedOn { get;set; }
}public class TBL_Symptom_Diagnosis {

public int? SymptomId { get;set; }
public int? DiagnosisId { get;set; }
}public class TBL_Diagnosis_Department {

public int? DiagnosisId { get;set; }
public int? DepartmentId { get;set; }
}public class TBL_Question {

public int QuestionId { get;set; }
public int? PatientId { get;set; }
public string Question { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Doctor_Diagnosis {

public int? DoctorId { get;set; }
public int? DiagnosisId { get;set; }
}public class TBL_Feedback {

public int FeedbackId { get;set; }
public string Name { get;set; }
public string Email { get;set; }
public string Feedback { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_KeywordSMS {

public int KeywordSMSId { get;set; }
public string PhoneCode { get;set; }
public string Keyword { get;set; }
public string Location { get;set; }
public string Carrier { get;set; }
public string Contents { get;set; }
public string PhoneNo { get;set; }
public string Time { get;set; }
public DateTime? CreatedOn { get;set; }
}public class TBL_Master_FamilyHistory {

public int FamilyHistoryId { get;set; }
public string FamilyHistoryName { get;set; }
public string Name { get;set; }
}public class TBL_Appointment_Winservice {

public int WinServiceId { get;set; }
public int? AppointmentId { get;set; }
public int? OrganizationId { get;set; }
public int? PatientId { get;set; }
public int? DoctorId { get;set; }
public int? DoctorTimingId { get;set; }
public int? ServiceId { get;set; }
public int? ServiceTimingId { get;set; }
public string EmailId { get;set; }
public string MobileId { get;set; }
public DateTime? AppointmentDate { get;set; }
public string MessageDescription { get;set; }
public int? AccountTypeId { get;set; }
public bool? IsSmsSent { get;set; }
public bool? IsEmailSent { get;set; }
public string Mobile { get;set; }
public string ExternalId { get;set; }
public DateTime? CreatedOn { get;set; }
}public class TBL_Master_Relationship {

public int RelationshipId { get;set; }
public string Relationship { get;set; }
}public class TBL_Master_Status {

public int StatusId { get;set; }
public string StatusName { get;set; }
}public class TBL_Doctor_Experience {

public int ExperienceId { get;set; }
public string MedicalServiceName { get;set; }
public string Title { get;set; }
public int? CountryId { get;set; }
public int? StateId { get;set; }
public int? CityId { get;set; }
public int? YearFrom { get;set; }
public int? MonthFrom { get;set; }
public int? YearTo { get;set; }
public int? MonthTo { get;set; }
public string Notes { get;set; }
public int? DoctorId { get;set; }
}public class TBL_Master_PersonalHistory {

public int PersonalHistoryId { get;set; }
public string PersonalHistoryName { get;set; }
public string Name { get;set; }
}public class TBL_Patient_SearchCount {

public int SearchId { get;set; }
public int? PatientId { get;set; }
public string CountryName { get;set; }
public string StateName { get;set; }
public string CityName { get;set; }
public string Speciality { get;set; }
public int? SpecialityType { get;set; }
public int? SearchCount { get;set; }
public int? SearchType { get;set; }
public DateTime? CreatedOn { get;set; }
}public class TBL_Patient_FamilyHistory {

public int? PatientId { get;set; }
public int? FamilyHistoryId { get;set; }
}public class TBL_Master_PastHistory {

public int PastHistoryId { get;set; }
public string PastHistoryName { get;set; }
public string Name { get;set; }
}public class TBL_Patient {

public int PatientId { get;set; }
public int? LoginId { get;set; }
public string FirstName { get;set; }
public string LastName { get;set; }
public DateTime? DateofBirth { get;set; }
public bool? Gender { get;set; }
public int? CountryId { get;set; }
public int? StateId { get;set; }
public int? CityId { get;set; }
public string Address { get;set; }
public string AddressLine1 { get;set; }
public string AddressLine2 { get;set; }
public string PostalCode { get;set; }
public string Phone { get;set; }
public string Mobile { get;set; }
public int? RelationshipId { get;set; }
public int? ParentId { get;set; }
public string ReferenceToken { get;set; }
public int? ReferedPatientId { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsActivated { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Master_AccountType {

public int AccountTypeId { get;set; }
public bool IsDeleted { get;set; }
public string AccountTypeName { get;set; }
public string Prefix { get;set; }
public DateTime? CreatedOn { get;set; }
}public class TBL_Reference {

public int ReferenceId { get;set; }
public int? PatientId { get;set; }
public int? ReferedBy { get;set; }
public int? ReferedTo { get;set; }
public string Reason { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Patient_PersonalHistory {

public int? PatientId { get;set; }
public int? PersonalHistoryId { get;set; }
}public class TBL_Patient_PastHistory {

public int? PatientId { get;set; }
public int? PastHistoryId { get;set; }
}public class TBL_Master_Department {

public int DepartmentId { get;set; }
public string DepartmentName { get;set; }
public string Description { get;set; }
public int? RequestedBy { get;set; }
public bool? IsApproved { get;set; }
public DateTime? CreatedOn { get;set; }
public int? IsDeleted { get;set; }
}public class UVW_Status {

public int StatusId { get;set; }
public string StatusName { get;set; }
}public class TBL_Master_City_old {

public int CityId { get;set; }
public string CityName { get;set; }
public int? StateId { get;set; }
public string LocationId { get;set; }
public int? CountryId { get;set; }
}public class TBL_Master_State_old {

public int StateId { get;set; }
public string StateName { get;set; }
public int? CountryId { get;set; }
public string StateCode { get;set; }
}public class TBL_GeoPostcodes {

public string Country { get;set; }
public string Language { get;set; }
public string ID { get;set; }
public string RegISO2 { get;set; }
public string Region1 { get;set; }
public string Region2 { get;set; }
public string Region3 { get;set; }
public string Region4 { get;set; }
public string ZIP { get;set; }
public string City { get;set; }
public string Area1 { get;set; }
public string Area2 { get;set; }
public string Lat { get;set; }
public string Lng { get;set; }
public string TZ { get;set; }
public string UTC { get;set; }
public string DST { get;set; }
}public class TBL_Master_Country_old {

public int CountryId { get;set; }
public string CountryName { get;set; }
public string CountryCode { get;set; }
public int? InternationalCode { get;set; }
}public class VW_Job_Country {

public int CountryId { get;set; }
public string CountryCode { get;set; }
public string CountryName { get;set; }
public int? InternationalCode { get;set; }
}public class VW_Job_State {

public int StateId { get;set; }
public string CountryCode { get;set; }
public string StateName { get;set; }
public string StateCode { get;set; }
}public class VW_Job_City {

public int CityId { get;set; }
public string CityName { get;set; }
public string StateCode { get;set; }
public string CountryCode { get;set; }
}public class TBL_Mapping_Status {

public int Id { get;set; }
public int? Type { get;set; }
public int? StatusId { get;set; }
public int? ParentStatusId { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_GeoPostcodes_Country {

public int CountryId { get;set; }
public string CountryCode { get;set; }
public string CountryName { get;set; }
public int? InternationalCode { get;set; }
}public class TBL_Mapping_Bed {

public int Id { get;set; }
public int? AppointmentId { get;set; }
public int? ActionId { get;set; }
public int? BedId { get;set; }
public int? StatusId { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public DateTime? EventTime { get;set; }
public bool? IsTransfer { get;set; }
public int? ActionTypeId { get;set; }
public int? DoctorId { get;set; }
}public class TBL_Doctor_Timing {

public int DoctorTimingId { get;set; }
public int? DoctorId { get;set; }
public string ScheduleName { get;set; }
public string Address { get;set; }
public bool? Sunday { get;set; }
public bool? Monday { get;set; }
public bool? Tuesday { get;set; }
public bool? Wednesday { get;set; }
public bool? Thursday { get;set; }
public bool? Friday { get;set; }
public bool? Saturday { get;set; }
public string StartTime { get;set; }
public string EndTime { get;set; }
public int? PatientDuration { get;set; }
public bool? IsApprovalSystem { get;set; }
public bool? IsApprovalNotificationSMS { get;set; }
public bool? IsApprovalNotificationEmail { get;set; }
public int? MaxAppointmentDays { get;set; }
public bool? IsDefaultAddress { get;set; }
public bool? IsCarParkFacility { get;set; }
public bool? IsFCFS { get;set; }
public int? MaxApps { get;set; }
public int? AppointmentType { get;set; }
public string Conditions { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class sysdiagrams {

public string name { get;set; }
public int principal_id { get;set; }
public int diagram_id { get;set; }
public int? version { get;set; }
public string definition { get;set; }
}public class Tbl_Temp_State {

public string StateUnionTerritory { get;set; }
public string City { get;set; }
}public class TBL_GeoPostcodes_State {

public int StateId { get;set; }
public string CountryCode { get;set; }
public string StateName { get;set; }
public string StateCode { get;set; }
}public class TBL_Job_SubAdminLogin {

public int Sid { get;set; }
public string UserName { get;set; }
public string Password { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Patient_UHID {

public int Id { get;set; }
public string UHID { get;set; }
public int? PatientId { get;set; }
public int? OrganizationId { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_GeoPostcodes_City {

public int CityId { get;set; }
public string CityName { get;set; }
public string StateCode { get;set; }
public string CountryCode { get;set; }
}public class TBL_Landing_MainTab {

public int MainTabId { get;set; }
public string MainTabName { get;set; }
public string MainTabContent { get;set; }
public int? LandingId { get;set; }
}public class TBL_BlockCalendar {

public int BlockId { get;set; }
public int? BlockTypeId { get;set; }
public bool? Type { get;set; }
public int? DoctorId { get;set; }
public int? ServiceId { get;set; }
public int? DoctorTimingId { get;set; }
public int? ServiceTimingId { get;set; }
public DateTime? BlockStart { get;set; }
public DateTime? BlockEnd { get;set; }
public string Reason { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Job_SearchWidgetColVisible {

public int SwId { get;set; }
public bool? Country { get;set; }
public bool? State { get;set; }
public bool? City { get;set; }
public bool? Facility { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Service_Timing {

public int ServiceTimingId { get;set; }
public int? ServiceId { get;set; }
public string ScheduleName { get;set; }
public string Address { get;set; }
public bool? Sunday { get;set; }
public bool? Monday { get;set; }
public bool? Tuesday { get;set; }
public bool? Wednesday { get;set; }
public bool? Thursday { get;set; }
public bool? Friday { get;set; }
public bool? Saturday { get;set; }
public string StartTime { get;set; }
public string EndTime { get;set; }
public string PatientDuration { get;set; }
public bool? IsApprovalSystem { get;set; }
public bool? IsApprovalNotificationSMS { get;set; }
public bool? IsApprovalNotificationEmail { get;set; }
public int? MaxAppointmentDays { get;set; }
public bool? IsDefaultAddress { get;set; }
public bool? IsCarParkFacility { get;set; }
public bool? IsFCFS { get;set; }
public int? MaxApps { get;set; }
public int? AppointmentType { get;set; }
public string Conditions { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Job_SearchResultsColVisible {

public int SrId { get;set; }
public bool? Country { get;set; }
public bool? State { get;set; }
public bool? City { get;set; }
public bool? Facility { get;set; }
public bool? Speciality { get;set; }
public bool? PostDate { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Landing_SubTab {

public int SubTabId { get;set; }
public string SubTabName { get;set; }
public string SubTabContent { get;set; }
public int? MainTabId { get;set; }
}public class TBL_Job_SearchDescriptionColVisible {

public int SdId { get;set; }
public bool? JobId { get;set; }
public bool? JobTitle { get;set; }
public bool? Facility { get;set; }
public bool? Speciality { get;set; }
public bool? Country { get;set; }
public bool? State { get;set; }
public bool? City { get;set; }
public bool? Description { get;set; }
public bool? PostedDate { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Job_NewsLetter {

public int Nid { get;set; }
public string Name { get;set; }
public string Email { get;set; }
public DateTime? PostedDate { get;set; }
public int? ClientId { get;set; }
}public class Tbl_Appointment_Comments {

public int Id { get;set; }
public int? AppointmentId { get;set; }
public int? StatusId { get;set; }
public int? LoginId { get;set; }
public string Comment { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
public int? ActionTypeId { get;set; }
public int? ActionId { get;set; }
}public class TBL_Login {

public int LoginId { get;set; }
public string FirstName { get;set; }
public string LastName { get;set; }
public string MedAppId { get;set; }
public int? CountryId { get;set; }
public string MobileId { get;set; }
public string EmailId { get;set; }
public string Password { get;set; }
public bool? IsDirect { get;set; }
public bool? IsActivated { get;set; }
public bool? IsEmailActivated { get;set; }
public string TransactionToken { get;set; }
public bool? IsEmailNotification { get;set; }
public bool? IsSMSNotification { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Job_HrLogin {

public int Hid { get;set; }
public string UserName { get;set; }
public string Password { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Job_HotOppsColVisible {

public int HId { get;set; }
public bool? Country { get;set; }
public bool? State { get;set; }
public bool? City { get;set; }
public bool? Facility { get;set; }
public bool? Speciality { get;set; }
public bool? PostedDate { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Job_Facility {

public int FacId { get;set; }
public string Facility { get;set; }
public bool? Visibility { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Service_Diagnosis {

public int? ServiceId { get;set; }
public int? DiagnosisId { get;set; }
}public class TBL_Job_Apply {

public int Aid { get;set; }
public string JobId { get;set; }
public string CandidateName { get;set; }
public string Age { get;set; }
public string Sex { get;set; }
public string PermanentAddress { get;set; }
public string Email { get;set; }
public string City { get;set; }
public string District { get;set; }
public string State { get;set; }
public string Country { get;set; }
public string AboutUs { get;set; }
public string ContactPhone { get;set; }
public string ContactMobile { get;set; }
public string BestTime { get;set; }
public string Specialization { get;set; }
public string Experience { get;set; }
public string HighestQualification { get;set; }
public string HighestDegree { get;set; }
public string CurrentEmployer { get;set; }
public string ExistingPay { get;set; }
public string DesiredPay { get;set; }
public string Willing { get;set; }
public string UploadResume { get;set; }
public DateTime? AppliedDate { get;set; }
public string HrStatus { get;set; }
public DateTime? HrDateUpdated { get;set; }
public string FinalStatus { get;set; }
public string Notes { get;set; }
public int? ClientId { get;set; }
}public class TBL_GupShup {

public string ExternalId { get;set; }
public string DeliveredTS { get;set; }
public string Status { get;set; }
public string PhoneNo { get;set; }
public string Cause { get;set; }
}public class TBL_Landing_ImageGallery {

public int ImageId { get;set; }
public int? AccountId { get;set; }
public int? AccountTypeId { get;set; }
public int? Version { get;set; }
public string ImageName { get;set; }
public string ImageDescription { get;set; }
public string Images { get;set; }
public bool? Selected { get;set; }
}public class VW_Jobs {

public int Jid { get;set; }
public int? ClientId { get;set; }
public int? SpecialityId { get;set; }
public DateTime? CreatedDate { get;set; }
public string Description { get;set; }
public string Speciality { get;set; }
public int? FacId { get;set; }
public string Facility { get;set; }
public string JobTitle { get;set; }
public int? CityId { get;set; }
public string CityName { get;set; }
public int? StateId { get;set; }
public string StateName { get;set; }
public string StateCode { get;set; }
public int? CountryId { get;set; }
public string CountryCode { get;set; }
public string CountryName { get;set; }
public string JobId { get;set; }
}public class TBL_Token {

public int TokenId { get;set; }
public string TokenNumber { get;set; }
public int? TokenSequence { get;set; }
public int? AppointmentId { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class Page {

public int ID { get;set; }
public string Location { get;set; }
public string HeaderImage { get;set; }
public string FooterImage { get;set; }
public string HeaderText { get;set; }
public string FooterText { get;set; }
public string PageImage { get;set; }
public string MainSite { get;set; }
public int? ClientID { get;set; }
public bool? Def { get;set; }
public string Text { get;set; }
public bool? Locked { get;set; }
}public class vw_Content {

public int ID { get;set; }
public string ImageUrl { get;set; }
public string Text { get;set; }
public int? PageID { get;set; }
public string Location { get;set; }
public string Title { get;set; }
}public class TBL_GupShup_FailureReason {

public int Id { get;set; }
public string KeyWord { get;set; }
public string Description { get;set; }
}public class TBL_Master_Banner {

public int BannerId { get;set; }
public int? DepartmentId { get;set; }
public string BannerFilename { get;set; }
}public class Content {

public int ID { get;set; }
public string Title { get;set; }
public string ImageUrl { get;set; }
public string Text { get;set; }
public int? PageID { get;set; }
public int? ClientID { get;set; }
public bool? Locked { get;set; }
}public class TBL_Landing {

public int LandingId { get;set; }
public int? Version { get;set; }
public int? PublishId { get;set; }
public string BannerPath { get;set; }
public int? DepartmentId { get;set; }
public string Forms { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
}public class TBL_Doctor_Education {

public int EducationId { get;set; }
public string University { get;set; }
public string Degree { get;set; }
public int? CountryId { get;set; }
public int? StateId { get;set; }
public int? CityId { get;set; }
public int? YearFrom { get;set; }
public int? YearTo { get;set; }
public string Notes { get;set; }
public int? DoctorId { get;set; }
}public class TBL_Organization {

public int OrganizationId { get;set; }
public string OrganizationName { get;set; }
public string SubDomain { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Master_University {

public int UniversityId { get;set; }
public string UniversityName { get;set; }
public int? CountryId { get;set; }
}public class TBL_Landing_Publish {

public int PublishId { get;set; }
public int? AccountId { get;set; }
public int? AccountTypeId { get;set; }
public int? BannerId { get;set; }
public int? DefaultVersion { get;set; }
}public class TBL_Job_Speciality {

public int SpcId { get;set; }
public int? SpecialityId { get;set; }
public string Speciality { get;set; }
public bool? Visibility { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Job_Location {

public int Lid { get;set; }
public string Country { get;set; }
public string State { get;set; }
public string City { get;set; }
public string CountryCode { get;set; }
public string StateCode { get;set; }
public int? CountryId { get;set; }
public int? StateId { get;set; }
public int? CityId { get;set; }
public bool? Visibility { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
}public class TBL_Admin_LoginType {

public int LoginTypeId { get;set; }
public string LoginType { get;set; }
}public class TBL_Job_Jobs {

public int Jid { get;set; }
public string JobId { get;set; }
public string JobTitle { get;set; }
public int? Facility { get;set; }
public int? Speciality { get;set; }
public int? Department { get;set; }
public int? Location { get;set; }
public string Description { get;set; }
public string URL { get;set; }
public bool? Visibility { get;set; }
public int? ClientId { get;set; }
public DateTime? CreatedDate { get;set; }
public DateTime? UpdatedDate { get;set; }
public string WhoCreated { get;set; }
public string WhoUpdated { get;set; }
public string extractedInLatestrun { get;set; }
}public class TBL_Doctor {

public int DoctorId { get;set; }
public int? LoginId { get;set; }
public int? OrganizationId { get;set; }
public string DoctorName { get;set; }
public DateTime? DateofBirth { get;set; }
public bool? Gender { get;set; }
public int? RegistrationYear { get;set; }
public string RegistrationNumber { get;set; }
public string Experience { get;set; }
public string Degrees { get;set; }
public string Certifications { get;set; }
public string PhotoName { get;set; }
public string Mobile { get;set; }
public int? DepartmentId { get;set; }
public string PreferredName { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public string ReferenceToken { get;set; }
public bool? IsActivated { get;set; }
public bool? IsDeleted { get;set; }
public int? UniversityId { get;set; }
}public class TBL_Landing_VideoGallery {

public int? AccountId { get;set; }
public int? AccountTypeId { get;set; }
public int? Version { get;set; }
public string VideoContent { get;set; }
public bool? Selected { get;set; }
}public class TBL_Master_Bed {

public int Id { get;set; }
public int? WardId { get;set; }
public string Name { get;set; }
public int? FloorId { get;set; }
public bool? IsDeleted { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public int? BuildingId { get;set; }
}public class TBL_Master_SubAccountType {

public int SubAccountType { get;set; }
public string SubAccountName { get;set; }
public int? AccountTypeId { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_ActivationSMSCount {

public int ID { get;set; }
public string Mobile { get;set; }
public string IPAddress { get;set; }
public int? SMSCount { get;set; }
public DateTime? ModifiedOn { get;set; }
public DateTime? CreatedOn { get;set; }
public bool? IsVerified { get;set; }
}public class TBL_Service {

public int ServiceId { get;set; }
public int? LoginId { get;set; }
public int? OrganizationId { get;set; }
public string ServiceName { get;set; }
public string InCharge { get;set; }
public int? DepartmentId { get;set; }
public int? Units { get;set; }
public string Mobile { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public string ReferenceToken { get;set; }
public bool? IsActivated { get;set; }
public bool? IsDeleted { get;set; }
}public class TBL_Appointment {

public int AppointmentId { get;set; }
public int? PatientId { get;set; }
public int? OrganizationId { get;set; }
public int? ServiceId { get;set; }
public int? ServiceTimingId { get;set; }
public int? DoctorId { get;set; }
public int? DoctorTimingId { get;set; }
public DateTime? AppointmentDate { get;set; }
public string AppointmentTime { get;set; }
public string OnCallAppointmentTime { get;set; }
public string Notes { get;set; }
public bool? IsCarParking { get;set; }
public string CarNumber { get;set; }
public int? PreferentialId { get;set; }
public string PreferentialBoarding { get;set; }
public string DoctorClosingNotes { get;set; }
public int? StatusId { get;set; }
public bool? IsDirectAppointment { get;set; }
public DateTime? CreatedOn { get;set; }
public DateTime? ModifiedOn { get;set; }
public bool? IsDeleted { get;set; }
}}

