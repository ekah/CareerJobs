using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class DoctorBAL
    {
        DoctorDAL _objDoctorDAL = new DoctorDAL();

        public int SaveDoctor(DoctorDO d)
        {
            try
            {
                int doctorId = _objDoctorDAL.SaveDoctor(d.DoctorId, d.OrganizationId, d.DoctorName, d.DateofBirth, d.Gender, d.UniversityId, d.RegistrationYear, d.RegistrationNumber, d.Experience, d.Degrees, d.Certifications, d.PhotoName, d.Mobile, d.DepartmentId, d.PreferredName, d.LoginNew.EmailId, d.LoginNew.Password, d.LoginNew.TransactionToken, d.ReferenceToken, d.CountryId, d.IsActivated);

                return doctorId;
            }
            catch
            {
                return 0;
            }
        }

        public bool SaveSchedule(ScheduleDO s)
        {
            try
            {
                _objDoctorDAL.SaveSchedule(s.DoctorTimingId, s.DoctorId, s.Name, s.Address, s.Sunday, s.Monday, s.Tuesday, s.Wednesday, s.Thursday, s.Friday, s.Saturday, s.StartTime, s.EndTime, s.PatientDuration, s.IsApprovalSystem, s.IsApprovalNotificationSMS,s.IsApprovalNotificationEmail, s.MaxAppointmentDays, s.IsDefaultSddress, s.IsCarParkFacility, s.IsFCFS, s.MaxApps, s.AppointmentType, s.Conditions);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int DeleteSchedule(int doctorTimingId)
        {
            return _objDoctorDAL.DeleteSchedule(doctorTimingId);
        }

        public DataTable GetDoctorBySearch(string search, int organizationId)
        {
            return _objDoctorDAL.GetDoctorBySearch(search, organizationId);
        }

        public DataTable GetScheduleBySearch(string search, int doctorId)
        {
            return _objDoctorDAL.GetScheduleBySearch(search, doctorId);
        }

        public DataTable GetScheduleBySearchWithoutOrganizationVerification(string search, int doctorId)
        {
            return _objDoctorDAL.GetScheduleBySearchWithoutOrganizationVerification(search, doctorId);
        }
        
        public string GetDoctorNameById(int doctorId)
        {
            return _objDoctorDAL.GetDoctorNameById(doctorId);
        }

        public DoctorDO GetDoctor(string signInId)
        {
            DataTable dtDoctor = _objDoctorDAL.GetDoctor(signInId);

            DoctorDO d = null;

            if (dtDoctor.Rows.Count > 0)
            {
                LoginNewDO l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtDoctor.Rows[0]["LoginId"].ToString());
                l.MobileId = dtDoctor.Rows[0]["MobileId"].ToString();
                l.MedAppId = dtDoctor.Rows[0]["MedAppId"].ToString();
                l.EmailId = dtDoctor.Rows[0]["EmailId"].ToString();
                l.Password = "[Encrypted]";
                l.CreatedOn = Convert.ToDateTime(dtDoctor.Rows[0]["CreatedOn"].ToString());
                l.IsDeleted = Convert.ToBoolean(dtDoctor.Rows[0]["IsDeleted"].ToString());

                d = new DoctorDO();
                d.DoctorId = Convert.ToInt32(dtDoctor.Rows[0]["DoctorId"].ToString());
                d.OrganizationId = Convert.ToInt32(dtDoctor.Rows[0]["OrganizationId"].ToString());
                d.DoctorName = dtDoctor.Rows[0]["DoctorName"].ToString();

                if (!string.IsNullOrEmpty(dtDoctor.Rows[0]["DateofBirth"].ToString()))
                    d.DateofBirth = Convert.ToDateTime(dtDoctor.Rows[0]["DateofBirth"].ToString());
                else
                    d.DateofBirth = null;

                d.Gender = Convert.ToBoolean(dtDoctor.Rows[0]["Gender"].ToString());
                d.UniversityId = Convert.ToInt32(dtDoctor.Rows[0]["UniversityId"].ToString());
                d.RegistrationYear = Convert.ToInt32(dtDoctor.Rows[0]["RegistrationYear"].ToString());
                d.RegistrationNumber = dtDoctor.Rows[0]["RegistrationNumber"].ToString();
                d.Experience = Convert.ToDecimal(dtDoctor.Rows[0]["Experience"].ToString());
                d.Degrees = dtDoctor.Rows[0]["Degrees"].ToString();
                d.Certifications = dtDoctor.Rows[0]["Certifications"].ToString();
                d.PhotoName = dtDoctor.Rows[0]["PhotoName"].ToString();
                d.Mobile = dtDoctor.Rows[0]["Mobile"].ToString();
                d.DepartmentId = Convert.ToInt32(dtDoctor.Rows[0]["DepartmentId"].ToString());
                d.DepartmentName = dtDoctor.Rows[0]["DepartmentName"].ToString();
                d.PreferredName = dtDoctor.Rows[0]["PreferredName"].ToString();
                d.ReferenceToken = dtDoctor.Rows[0]["ReferenceToken"].ToString();
                d.CountryId = Convert.ToInt32(dtDoctor.Rows[0]["CountryId"]);
                d.IsActivated = Convert.ToBoolean(dtDoctor.Rows[0]["IsActivated1"]);
                d.LoginNew = l;
            }

            return d;
        }

        public DoctorDO GetDoctorById(int doctorId)
        {
            DataTable dtDoctor = _objDoctorDAL.GetDoctorById(doctorId);

            DoctorDO d = null;

            if (dtDoctor.Rows.Count > 0)
            {
                LoginNewDO l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtDoctor.Rows[0]["LoginId"].ToString());
                l.MobileId = dtDoctor.Rows[0]["MobileId"].ToString();
                l.MedAppId = dtDoctor.Rows[0]["MedAppId"].ToString();
                l.EmailId = dtDoctor.Rows[0]["EmailId"].ToString();
                l.Password = "[Encrypted]";
                l.CreatedOn = Convert.ToDateTime(dtDoctor.Rows[0]["CreatedOn"].ToString());
                l.IsDeleted = Convert.ToBoolean(dtDoctor.Rows[0]["IsDeleted"].ToString());

                d = new DoctorDO();
                d.DoctorId = Convert.ToInt32(dtDoctor.Rows[0]["DoctorId"].ToString());
                d.OrganizationId = Convert.ToInt32(dtDoctor.Rows[0]["OrganizationId"].ToString());
                d.DoctorName = dtDoctor.Rows[0]["DoctorName"].ToString();

                if (!string.IsNullOrEmpty(dtDoctor.Rows[0]["DateofBirth"].ToString()))
                    d.DateofBirth = Convert.ToDateTime(dtDoctor.Rows[0]["DateofBirth"].ToString());
                else
                    d.DateofBirth = null;

                d.Gender = Convert.ToBoolean(dtDoctor.Rows[0]["Gender"].ToString());
                d.UniversityId = Convert.ToInt32(dtDoctor.Rows[0]["UniversityId"].ToString());
                d.RegistrationYear = Convert.ToInt32(dtDoctor.Rows[0]["RegistrationYear"].ToString());
                d.RegistrationNumber = dtDoctor.Rows[0]["RegistrationNumber"].ToString();
                d.Experience = Convert.ToDecimal(dtDoctor.Rows[0]["Experience"].ToString());
                d.Degrees = dtDoctor.Rows[0]["Degrees"].ToString();
                d.Certifications = dtDoctor.Rows[0]["Certifications"].ToString();
                d.PhotoName = dtDoctor.Rows[0]["PhotoName"].ToString();
                d.Mobile = dtDoctor.Rows[0]["Mobile"].ToString();
                d.DepartmentId = Convert.ToInt32(dtDoctor.Rows[0]["DepartmentId"].ToString());
                d.DepartmentName = dtDoctor.Rows[0]["DepartmentName"].ToString();
                d.PreferredName = dtDoctor.Rows[0]["PreferredName"].ToString();
                d.ReferenceToken = dtDoctor.Rows[0]["ReferenceToken"].ToString();
                d.CountryId = Convert.ToInt32(dtDoctor.Rows[0]["CountryId"]);
                d.IsActivated = Convert.ToBoolean(dtDoctor.Rows[0]["IsActivated1"]);
                d.LoginNew = l;
            }

            return d;
        }


        public void DeleteDoctorById(int doctorId)
        {
            _objDoctorDAL.DeleteDoctorById(doctorId);
        }

        public ScheduleDO GetScheduleById(int scheduleId)
        {
            DataTable dtSchedule = _objDoctorDAL.GetScheduleById(scheduleId);

            ScheduleDO s = null;

            if (dtSchedule.Rows.Count > 0)
            {
                s = new ScheduleDO();
                s.DoctorTimingId = Convert.ToInt32(dtSchedule.Rows[0]["DoctorTimingId"].ToString());
                s.DoctorId = Convert.ToInt32(dtSchedule.Rows[0]["DoctorId"].ToString());
                s.Address = dtSchedule.Rows[0]["Address"].ToString();
                s.Name = dtSchedule.Rows[0]["ScheduleName"].ToString();
                s.Sunday = Convert.ToBoolean(dtSchedule.Rows[0]["Sunday"].ToString());
                s.Monday = Convert.ToBoolean(dtSchedule.Rows[0]["Monday"].ToString());
                s.Tuesday = Convert.ToBoolean(dtSchedule.Rows[0]["Tuesday"].ToString());
                s.Wednesday = Convert.ToBoolean(dtSchedule.Rows[0]["Wednesday"].ToString());
                s.Thursday = Convert.ToBoolean(dtSchedule.Rows[0]["Thursday"].ToString());
                s.Friday = Convert.ToBoolean(dtSchedule.Rows[0]["Friday"].ToString());
                s.Saturday = Convert.ToBoolean(dtSchedule.Rows[0]["Saturday"].ToString());
                s.StartTime = dtSchedule.Rows[0]["StartTime"].ToString();
                s.EndTime = dtSchedule.Rows[0]["EndTime"].ToString();
                s.PatientDuration = Convert.ToInt32(dtSchedule.Rows[0]["PatientDuration"].ToString());
                s.IsApprovalSystem = Convert.ToBoolean(dtSchedule.Rows[0]["IsApprovalSystem"].ToString());
                s.IsApprovalNotificationSMS = Convert.ToBoolean(dtSchedule.Rows[0]["IsApprovalNotificationSMS"].ToString());
                s.IsApprovalNotificationEmail = Convert.ToBoolean(dtSchedule.Rows[0]["IsApprovalNotificationEmail"].ToString());
                s.MaxAppointmentDays = Convert.ToInt32(dtSchedule.Rows[0]["MaxAppointmentDays"].ToString());
                s.IsDefaultSddress = Convert.ToBoolean(dtSchedule.Rows[0]["IsDefaultAddress"].ToString());
                s.IsCarParkFacility = Convert.ToBoolean(dtSchedule.Rows[0]["IsCarParkFacility"].ToString());
                s.IsFCFS = Convert.ToBoolean(dtSchedule.Rows[0]["IsFCFS"].ToString());
                s.MaxApps = Convert.ToInt32(dtSchedule.Rows[0]["MaxApps"].ToString());
                s.AppointmentType = Convert.ToInt32(dtSchedule.Rows[0]["AppointmentType"].ToString());
                s.Conditions = dtSchedule.Rows[0]["Conditions"].ToString();                
            }

            return s;
        }

        public void DeleteScheduleById(int scheduleId)
        {
            _objDoctorDAL.DeleteScheduleById(scheduleId);
        }

        public void DeleteEducationById(int EducationId)
        {
            _objDoctorDAL.DeleteEducationById(EducationId);
        }

        public void DeleteExperienceById(int ExperienceId)
        {
            _objDoctorDAL.DeleteExperienceById(ExperienceId);
        }

        public void UpdatePhotoNameByDoctorId(int DoctorId)
        {
            _objDoctorDAL.UpdatePhotoNameByDoctorId(DoctorId);
        }

        public DataTable GetDiagnosisByDoctorDepartmentId(string signinId, int organizationId)
        {
            return _objDoctorDAL.GetDiagnosisByDoctorDepartmentId(signinId, organizationId);
        }

        public bool SaveDoctorDiagnosis(List<SymptomDO> listDiagnosis, int doctorId)
        {
            try
            {
                if (listDiagnosis.Count > 0)
                {
                    _objDoctorDAL.DeleteDoctorDiagnosis(doctorId);

                    foreach (SymptomDO item in listDiagnosis)
                    {
                        _objDoctorDAL.SaveDoctorDiagnosis(item.DoctorId, item.DiagnosisId);
                    }
                }
                else
                {
                    _objDoctorDAL.DeleteDoctorDiagnosis(doctorId);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDiagnosisByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetDiagnosisByDoctorId(doctorId);
        }

        public bool SaveDepartmentDiagnosis(List<SymptomDO> listDiagnosis, int departmentId)
        {
            try
            {
                if (listDiagnosis.Count > 0)
                {
                    _objDoctorDAL.DeleteDepartmentDiagnosiss(departmentId);

                    foreach (SymptomDO item in listDiagnosis)
                    {
                        _objDoctorDAL.InsertDepartmentDiagnosis(item.DiagnosisId, departmentId);
                    }
                }
                else
                {
                    _objDoctorDAL.DeleteDepartmentDiagnosiss(departmentId);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDiagnosisByDepartmentId(int departmentId)
        {
            return _objDoctorDAL.GetDiagnosisByDepartmentId(departmentId);
        }

        public DataTable GetBlockCalendarBySearch(string search, int doctorId)
        {
            return _objDoctorDAL.GetBlockCalendarBySearch(search, doctorId);
        }

        public DataTable GetSymptomByDiagnosisId(int diagnosisId)
        {
            return _objDoctorDAL.GetSymptomByDiagnosisId(diagnosisId);
        }

        public bool SaveSymptomDiagnosis(List<SymptomDO> listDiagnosis, int diagnosisId)
        {
            try
            {
                if (listDiagnosis.Count > 0)
                {
                    _objDoctorDAL.DeleteSymptomDiagnosiss(diagnosisId);

                    foreach (SymptomDO item in listDiagnosis)
                    {
                        _objDoctorDAL.InsertSymptomDiagnosis(item.SymptomId, diagnosisId);
                    }
                }
                else
                {
                    _objDoctorDAL.DeleteSymptomDiagnosiss(diagnosisId);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable FindDoctorBySearch(string doctor)
        {
            return _objDoctorDAL.FindDoctorBySearch(doctor);
        }

        public bool VerifyAcceptance(int doctorId)
        {
            int verifiedCount = _objDoctorDAL.VerifyAcceptance(doctorId);

            if (verifiedCount > 0)
                return true;
            else
                return false;
        }

        public void UpdateAcceptance(int doctorId)
        {
            _objDoctorDAL.UpdateAcceptance(doctorId);
        }

        public int ValidatePreferredName(string preferredName, int doctorId)
        {
            return _objDoctorDAL.ValidatePreferredName(preferredName, doctorId);
        }

        public int GetDoctorIdExistInLanding(int doctorId)
        {
            return _objDoctorDAL.GetDoctorIdExistInLanding(doctorId);
        }

        public bool SaveDoctorEducation(DoctorEducationDO d)
        {
            try
            {
                _objDoctorDAL.SaveDoctorEducation(d.EducationId, d.University, d.Degree, d.CountryId, d.StateId, d.CityId, d.YearFrom, d.YearTo, d.Notes, d.DoctorId);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDoctorEducationByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetDoctorEducationByDoctorId(doctorId);
        }

        public DataTable GetDoctorEducationByEducationId(int educationId)
        {
            return _objDoctorDAL.GetDoctorEducationByEducationId(educationId);
        }

        public bool SaveDoctorExperience(DoctorExperienceDO d)
        {
            try
            {
                _objDoctorDAL.SaveDoctorExperience(d.ExperienceId, d.MedicalServiceName, d.Title, d.CountryId, d.StateId, d.CityId, d.YearFrom, d.MonthFrom, d.YearTo, d.MonthTo, d.Notes, d.DoctorId);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDoctorExperienceByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetDoctorExperienceByDoctorId(doctorId);
        }

        public DataTable GetDoctorExperienceByExperienceId(int experienceId)
        {
            return _objDoctorDAL.GetDoctorExperienceByExperienceId(experienceId);
        }

        public void SaveDoctorEducationCollection(int oldDoctorId, int newDoctorId)
        {
            _objDoctorDAL.SaveDoctorEducationCollection(oldDoctorId, newDoctorId);
        }

        public void SaveDoctorExperienceCollection(int oldDoctorId, int newDoctorId)
        {
            _objDoctorDAL.SaveDoctorExperienceCollection(oldDoctorId, newDoctorId);
        }

        public void DeleteDoctorEducation(int doctorId)
        {
            _objDoctorDAL.DeleteDoctorEducation(doctorId);
        }

        public void DeleteDoctorExperience(int doctorId)
        {
            _objDoctorDAL.DeleteDoctorExperience(doctorId);
        }

        public int ValidateScheduleByDoctorId(int doctorId)
        {
            return _objDoctorDAL.ValidateScheduleByDoctorId(doctorId);
        }

        public DataTable GetHospitalByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetHospitalByDoctorId(doctorId);
        }

        public string GetDoctorNameByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetDoctorNameByDoctorId(doctorId);
        }

        public DataTable GetScheduleByDoctorId(int doctorId)
        {
            return _objDoctorDAL.GetScheduleByDoctorId(doctorId);
        }

        public DataTable GetEmailSMSNotification(int doctorId)
        {
            return _objDoctorDAL.GetEmailSMSNotification(doctorId);
        }
    }
}