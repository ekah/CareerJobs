using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class PatientBAL
    {
        PatientDAL _objPatientDAL = new PatientDAL();

        public bool SavePatient(PatientDO p)
        {
            try
            {
                int? stateId = null;
                if (p.StateId == 0)
                    stateId = null;
                else
                    stateId = p.StateId;

                int? cityId = null;
                if (p.CityId == 0)
                    cityId = null;
                else
                    cityId = p.CityId;

                int patientId = 0;

                if (p.DateofBirth.ToString() != "1/1/0001 12:00:00 AM")
                    patientId = _objPatientDAL.SavePatient(p.PatientId, p.LoginId, p.FirstName, p.LastName, p.DateofBirth, p.Gender, p.CountryId, stateId, cityId, p.Address, p.AddressLine1, p.AddressLine2, p.PostalCode, p.Phone, p.Mobile, p.RelationshipId, p.ParentId, p.ReferenceToken, p.ReferedPatientId);
                else
                    patientId = _objPatientDAL.SavePatient(p.PatientId, p.LoginId, p.FirstName, p.LastName, null, p.Gender, p.CountryId, stateId, cityId, p.Address, p.AddressLine1, p.AddressLine2, p.PostalCode, p.Phone, p.Mobile, p.RelationshipId, p.ParentId, p.ReferenceToken, p.ReferedPatientId);

                if (patientId > 0)
                {
                    _objPatientDAL.DeletePatientPastHistory(patientId);
                    foreach (PastHistoryDO item in p.PastHistory)
                    {
                        item.PatientId = patientId;
                        _objPatientDAL.SavePatientPastHistory(item.PatientId, item.PastHistoryId);
                    }

                    _objPatientDAL.DeletePatientPersonalHistory(patientId);
                    foreach (PersonalHistoryDO item in p.PersonalHistory)
                    {
                        item.PatientId = patientId;
                        _objPatientDAL.SavePatientPersonalHistory(item.PatientId, item.PersonalHistoryId);
                    }

                    _objPatientDAL.DeletePatientFamilyHistory(patientId);
                    foreach (FamilyHistoryDO item in p.FamilyHistory)
                    {
                        item.PatientId = patientId;
                        _objPatientDAL.SavePatientFamilyHistory(item.PatientId, item.FamilyHistoryId);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public PatientDO GetPatient(string signInId)
        {
            DataTable dtPatient = _objPatientDAL.GetPatient(signInId);

            PatientDO p = null;

            if (dtPatient.Rows.Count > 0)
            {
                p = new PatientDO();
                p.PatientId = Convert.ToInt32(dtPatient.Rows[0]["PatientId"].ToString());
                p.FirstName = dtPatient.Rows[0]["FirstName1"].ToString();
                p.LastName = dtPatient.Rows[0]["LastName1"].ToString();
                p.CountryId = Convert.ToInt32(dtPatient.Rows[0]["CountryId"].ToString());

                if (dtPatient.Rows[0]["DateofBirth"].ToString() != string.Empty)
                {
                    p.DateofBirth = Convert.ToDateTime(dtPatient.Rows[0]["DateofBirth"].ToString());
                    p.Gender = Convert.ToBoolean(dtPatient.Rows[0]["Gender"].ToString());
                    if (dtPatient.Rows[0]["StateId"].ToString() != "")
                        p.StateId = Convert.ToInt32(dtPatient.Rows[0]["StateId"].ToString());
                    else
                        p.StateId = 0;
                    if (dtPatient.Rows[0]["CityId"].ToString() != "")
                        p.CityId = Convert.ToInt32(dtPatient.Rows[0]["CityId"].ToString());
                    else
                        p.CityId = 0;
                    p.Address = dtPatient.Rows[0]["Address"].ToString();
                    p.AddressLine1 = dtPatient.Rows[0]["AddressLine1"].ToString();
                    p.AddressLine2 = dtPatient.Rows[0]["AddressLine2"].ToString();
                    p.PostalCode = dtPatient.Rows[0]["PostalCode"].ToString();
                    p.Phone = dtPatient.Rows[0]["Phone"].ToString();
                }
                p.Mobile = dtPatient.Rows[0]["Mobile"].ToString();
                p.RelationshipId = Convert.ToInt32(dtPatient.Rows[0]["RelationshipId"].ToString());
                p.ParentId = Convert.ToInt32(dtPatient.Rows[0]["ParentId"].ToString());
                p.ReferenceToken = dtPatient.Rows[0]["ReferenceToken"].ToString();
                p.ReferedPatientId = Convert.ToInt32(dtPatient.Rows[0]["ReferedPatientId"].ToString());
                List<PastHistoryDO> ph = GetPastHistory(p.PatientId);
                p.PastHistory = ph;
                List<PersonalHistoryDO> phy = GetPersonalHistory(p.PatientId);
                p.PersonalHistory = phy;
                List<FamilyHistoryDO> fh = GetFamilyHistory(p.PatientId);
                p.FamilyHistory = fh;
                p.CreatedOn = Convert.ToDateTime(dtPatient.Rows[0]["CreatedOn"].ToString());
                p.IsDeleted = Convert.ToBoolean(dtPatient.Rows[0]["IsDeleted"].ToString());
            }

            return p;
        }

        public List<PastHistoryDO> GetPastHistory(int patientId)
        {
            DataTable dt = _objPatientDAL.GetPastHistory(patientId);

            List<PastHistoryDO> ph = new List<PastHistoryDO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PastHistoryDO p = new PastHistoryDO();
                p.PastHistoryId = Convert.ToInt32(dt.Rows[i]["PastHistoryId"].ToString());
                p.PatientId = Convert.ToInt32(dt.Rows[i]["PatientId"].ToString());
                ph.Add(p);
            }

            return ph;
        }

        public List<PersonalHistoryDO> GetPersonalHistory(int patientId)
        {
            DataTable dt = _objPatientDAL.GetPersonalHistory(patientId);

            List<PersonalHistoryDO> ph = new List<PersonalHistoryDO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PersonalHistoryDO p = new PersonalHistoryDO();
                p.PersonalHistoryId = Convert.ToInt32(dt.Rows[i]["PersonalHistoryId"].ToString());
                p.PatientId = Convert.ToInt32(dt.Rows[i]["PatientId"].ToString());
                ph.Add(p);
            }

            return ph;
        }

        public List<FamilyHistoryDO> GetFamilyHistory(int patientId)
        {
            DataTable dt = _objPatientDAL.GetFamilyHistory(patientId);

            List<FamilyHistoryDO> fh = new List<FamilyHistoryDO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FamilyHistoryDO p = new FamilyHistoryDO();
                p.FamilyHistoryId = Convert.ToInt32(dt.Rows[i]["FamilyHistoryId"].ToString());
                p.PatientId = Convert.ToInt32(dt.Rows[i]["PatientId"].ToString());
                fh.Add(p);
            }
            return fh;
        }

        public DataTable GetPatientByParentId(string search, int patientId)
        {
            return _objPatientDAL.GetPatientByParentId(search, patientId);
        }

        public void DeletePatientByParentId(int patientId)
        {
            _objPatientDAL.DeletePatientByParentId(patientId);
        }

        public PatientDO GetPatientByPatientId(int patientId)
        {
            DataTable dtPatient = _objPatientDAL.GetPatientByPatientId(patientId);

            PatientDO p = null;

            if (dtPatient.Rows.Count > 0)
            {
                p = new PatientDO();
                p.PatientId = Convert.ToInt32(dtPatient.Rows[0]["PatientId"].ToString());
                p.FirstName = dtPatient.Rows[0]["FirstName"].ToString();
                p.LastName = dtPatient.Rows[0]["LastName"].ToString();
                p.PrimaryHolder = dtPatient.Rows[0]["PrimaryHolder"].ToString();
                p.CountryName = dtPatient.Rows[0]["CountryName"].ToString();
                p.CountryId = Convert.ToInt32(dtPatient.Rows[0]["CountryId"].ToString());
                if (dtPatient.Rows[0]["DateofBirth"].ToString() != string.Empty)
                {
                    p.DateofBirth = Convert.ToDateTime(dtPatient.Rows[0]["DateofBirth"].ToString());
                    p.Gender = Convert.ToBoolean(dtPatient.Rows[0]["Gender"].ToString());
                    if (dtPatient.Rows[0]["StateId"].ToString() != "")
                        p.StateId = Convert.ToInt32(dtPatient.Rows[0]["StateId"].ToString());
                    else
                        p.StateId = 0;
                    if (dtPatient.Rows[0]["CityId"].ToString() != "")
                        p.CityId = Convert.ToInt32(dtPatient.Rows[0]["CityId"].ToString());
                    else
                        p.CityId = 0;
                    p.Address = dtPatient.Rows[0]["Address"].ToString();
                    p.AddressLine1 = dtPatient.Rows[0]["AddressLine1"].ToString();
                    p.AddressLine2 = dtPatient.Rows[0]["AddressLine2"].ToString();
                    p.PostalCode = dtPatient.Rows[0]["PostalCode"].ToString();
                    p.Phone = dtPatient.Rows[0]["Phone"].ToString();
                }
                p.Mobile = dtPatient.Rows[0]["Mobile"].ToString();
                p.RelationshipId = Convert.ToInt32(dtPatient.Rows[0]["RelationshipId"].ToString());
                p.ParentId = Convert.ToInt32(dtPatient.Rows[0]["ParentId"].ToString());
                p.ReferenceToken = dtPatient.Rows[0]["ReferenceToken"].ToString();
                p.ReferedPatientId = Convert.ToInt32(dtPatient.Rows[0]["ReferedPatientId"].ToString());
                List<PastHistoryDO> ph = GetPastHistory(p.PatientId);
                p.PastHistory = ph;
                List<PersonalHistoryDO> phy = GetPersonalHistory(p.PatientId);
                p.PersonalHistory = phy;
                List<FamilyHistoryDO> fh = GetFamilyHistory(p.PatientId);
                p.FamilyHistory = fh;
                p.CreatedOn = Convert.ToDateTime(dtPatient.Rows[0]["CreatedOn"].ToString());
                p.IsDeleted = Convert.ToBoolean(dtPatient.Rows[0]["IsDeleted"].ToString());
            }

            return p;
        }

        public PatientDO GetPatientByMemberId(int patientId)
        {
            DataTable dtPatient = _objPatientDAL.GetPatientByPatientId(patientId);

            PatientDO p = null;

            if (dtPatient.Rows.Count > 0)
            {
                p = new PatientDO();
                p.PatientId = Convert.ToInt32(dtPatient.Rows[0]["PatientId"].ToString());
                p.FirstName = dtPatient.Rows[0]["FirstName"].ToString();
                p.LastName = dtPatient.Rows[0]["LastName"].ToString();
                if (dtPatient.Rows[0]["DateofBirth"].ToString() != "")
                    p.DateofBirth = Convert.ToDateTime(dtPatient.Rows[0]["DateofBirth"].ToString());
                if (dtPatient.Rows[0]["Gender"].ToString() != "")
                    p.Gender = Convert.ToBoolean(dtPatient.Rows[0]["Gender"].ToString());
                if (dtPatient.Rows[0]["CountryId"].ToString() != "")
                    p.CountryId = Convert.ToInt32(dtPatient.Rows[0]["CountryId"].ToString());
                if (dtPatient.Rows[0]["CountryName"].ToString() != "")
                    p.CountryName = dtPatient.Rows[0]["CountryName"].ToString();
                if (dtPatient.Rows[0]["StateId"].ToString() != "")
                    p.StateId = Convert.ToInt32(dtPatient.Rows[0]["StateId"].ToString());
                if (dtPatient.Rows[0]["StateName"].ToString() != "")
                    p.StateName = dtPatient.Rows[0]["StateName"].ToString();
                if (dtPatient.Rows[0]["CityId"].ToString() != "")
                    p.CityId = Convert.ToInt32(dtPatient.Rows[0]["CityId"].ToString());
                if (dtPatient.Rows[0]["CityName"].ToString() != "")
                    p.CityName = dtPatient.Rows[0]["CityName"].ToString();
                if (dtPatient.Rows[0]["Address"].ToString() != "")
                    p.Address = dtPatient.Rows[0]["Address"].ToString();
                if (dtPatient.Rows[0]["AddressLine1"].ToString() != "")
                    p.AddressLine1 = dtPatient.Rows[0]["AddressLine1"].ToString();
                if (dtPatient.Rows[0]["AddressLine2"].ToString() != "")
                    p.AddressLine2 = dtPatient.Rows[0]["AddressLine2"].ToString();
                if (dtPatient.Rows[0]["PostalCode"].ToString() != "")
                    p.PostalCode = dtPatient.Rows[0]["PostalCode"].ToString();
                if (dtPatient.Rows[0]["Phone"].ToString() != "")
                    p.Phone = dtPatient.Rows[0]["Phone"].ToString();
                if (dtPatient.Rows[0]["Mobile"].ToString() != "")
                    p.Mobile = dtPatient.Rows[0]["Mobile"].ToString();
                if (dtPatient.Rows[0]["RelationshipId"].ToString() != "")
                    p.RelationshipId = Convert.ToInt32(dtPatient.Rows[0]["RelationshipId"].ToString());
                p.ParentId = Convert.ToInt32(dtPatient.Rows[0]["ParentId"].ToString());
                p.ReferenceToken = dtPatient.Rows[0]["ReferenceToken"].ToString();
                p.ReferedPatientId = Convert.ToInt32(dtPatient.Rows[0]["ReferedPatientId"].ToString());
                List<PastHistoryDO> ph = GetPastHistory(p.PatientId);
                p.PastHistory = ph;
                List<PersonalHistoryDO> phy = GetPersonalHistory(p.PatientId);
                p.PersonalHistory = phy;
                List<FamilyHistoryDO> fh = GetFamilyHistory(p.PatientId);
                p.FamilyHistory = fh;
                p.CreatedOn = Convert.ToDateTime(dtPatient.Rows[0]["CreatedOn"].ToString());
                p.IsDeleted = Convert.ToBoolean(dtPatient.Rows[0]["IsDeleted"].ToString());
            }

            return p;
        }

        public int SaveDirectPatient(string firstName, string lastName, string mobile, string password, string referenceToken, int countryId, string transactionToken)
        {
            return _objPatientDAL.SaveDirectPatient(firstName, lastName, mobile, password, referenceToken, countryId, transactionToken);
        }

        public int InsertDirectPatientWithoutLogin(string firstName, string lastName, string mobile, string referenceToken, int countryId, string transactionToken)
        {
            return _objPatientDAL.InsertDirectPatientWithoutLogin(firstName, lastName, mobile, referenceToken, countryId, transactionToken);
        }

        public int SaveDirectMember(string name, int patientId, string mobile, int relationshipName, string referenceToken)
        {
            return _objPatientDAL.SaveDirectMember(name, patientId, mobile, relationshipName, referenceToken);
        }

        public int ValidateMemberName(string firstName, string lastName, int patientId, int relationshipId, int editPatientId)
        {
            return _objPatientDAL.ValidateMemberName(firstName, lastName, patientId, relationshipId, editPatientId);
        }

        public DataTable GetMyAppointment(string signInId)
        {
            return _objPatientDAL.GetMyAppointment(signInId);
        }

        public DataTable GetMyTodayAppointment(string signInId, string appointmentFrom)
        {
            return _objPatientDAL.GetMyTodayAppointment(signInId, appointmentFrom);
        }

        public DataRow GetReferenceTokenBySignInId(string signInId)
        {
            return _objPatientDAL.GetReferenceTokenBySignInId(signInId);
        }

        public int GetReferedPatientIdByToken(string referenceToken)
        {
            return _objPatientDAL.GetReferedPatientIdByToken(referenceToken);
        }

        public DataTable GetMyAppointmentByAppointmentId(int appointmentId)
        {
            return _objPatientDAL.GetMyAppointmentByAppointmentId(appointmentId);
        }

        public int GetAppointmentStatusByAppointmentId(int appointmentId)
        {
            return _objPatientDAL.GetAppointmentStatusByAppointmentId(appointmentId);
        }

        public DataTable DeleteAppointmentByAppointmentId(int appointmentId)
        {
            return _objPatientDAL.DeleteAppointmentByAppointmentId(appointmentId);
        }

        public DataTable DeleteAppointmentByAppointmentIdByDoctor(int appointmentId)
        {
            return _objPatientDAL.DeleteAppointmentByAppointmentIdByDoctor(appointmentId);
        }

        public void UpdatePatientAppointmentByAppointmentTime(int appointmentId, string appointmentTime, int status)
        {
            _objPatientDAL.UpdatePatientAppointmentByAppointmentTime(appointmentId, appointmentTime, status);
        }

        public DataTable GetPatientByAppointmentId(int appointmentId)
        {
            return _objPatientDAL.GetPatientByAppointmentId(appointmentId);
        }

        public int SaveLoginPatient(int loginId, string firstName, string lastName, string mobile, string referenceToken)
        {
            return _objPatientDAL.SaveLoginPatient(loginId, firstName, lastName, mobile, referenceToken);
        }

        public void SearchCount(int PatientId, string CountryName, string StateName, string CityName, string Speciality, int SpecialityType, int SearchCount, int SearchType)
        {
            _objPatientDAL.SearchCount(PatientId, CountryName, StateName, CityName, Speciality, SpecialityType, SearchCount, SearchType);
        }

        public void InsertPatientUHID(string UHID, int patientId, int organizationId)
        {
            _objPatientDAL.InsertPatientUHID(UHID, patientId, organizationId);
        }

        public void UpdateUHID(string UHID, int patientId, int organizationId)
        {
            _objPatientDAL.UpdateUHID(UHID, patientId, organizationId);
        }

        public string GetPatientUHID(int patientId, int organizationId)
        {
            return _objPatientDAL.GetPatientUHID(patientId, organizationId);
        }

        public int ValidatePatientUHID(int patientId, int organizationId)
        {
            return _objPatientDAL.ValidatePatientUHID(patientId, organizationId);
        }

        public string ValidateUHID(string UHID, int organizationId, int patientId)
        {
            return _objPatientDAL.ValidateUHID(UHID, organizationId, patientId);
        }

        public int ValidateUHIDExists(string UHID, int organizationId)
        {
            return _objPatientDAL.ValidateUHIDExists(UHID, organizationId);
        }

        public int ValidateEditUHID(string UHID, int organizationId, int patientId)
        {
            return _objPatientDAL.ValidateEditUHID(UHID, organizationId, patientId);
        }

        public void UpdatePatientNameById(string patientName, int patientId)
        {
            _objPatientDAL.UpdatePatientNameById(patientName, patientId);
        }
    }
}
