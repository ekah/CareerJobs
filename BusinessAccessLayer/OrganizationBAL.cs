using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class OrganizationBAL
    {
        OrganizationDAL _objOrganizationDAL = new OrganizationDAL();

        public int SaveOrganization(string OrganizationName, string subDomain)
        {
            try
            {
                //int? stateId = null;
                //if (o.StateId == 0)
                //    stateId = null;
                //else
                //    stateId = o.StateId;

                //int? cityId = null;
                //if (o.CityId == 0)
                //    cityId = null;
                //else
                //    cityId = o.CityId;

                //int orgId = _objOrganizationDAL.SaveOrganization(o.OrganizationId, o.LoginId, o.OrganizationName, o.CountryId, stateId, cityId, o.BranchName, o.Address, o.AddressLine1, o.AddressLine2, o.PostalCode, o.Phone, o.Mobile, o.TimeZone, o.InCharge, o.IsExternalReference, o.MaxAppointmentDays, o.IsApprovalSystem, o.IsCarParkFacility, o.IsConditionsPage, o.SubDomain, o.CNameUrl, o.WelcomeTitle, o.AboutOrganization, o.ReferedBy, o.ReferenceToken);
                int orgId = _objOrganizationDAL.SaveOrganization(OrganizationName, subDomain);
                return orgId;
            }
            catch
            {
                return 0;
            }
        }

        public OrganizationDO GetOrganization(string signInId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganization(signInId);

            OrganizationDO o = null;

            if (dtOrganization.Rows.Count > 0)
            {
                o = new OrganizationDO();
                o.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                o.LoginId = Convert.ToInt32(dtOrganization.Rows[0]["LoginId"].ToString());
                o.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                o.CountryId = Convert.ToInt32(dtOrganization.Rows[0]["CountryId"].ToString());
                o.CountryName = dtOrganization.Rows[0]["CountryName"].ToString();
                if (dtOrganization.Rows[0]["StateId"].ToString() != "")
                    o.StateId = Convert.ToInt32(dtOrganization.Rows[0]["StateId"].ToString());
                else
                    o.StateId = 0;
                o.StateName = dtOrganization.Rows[0]["StateName"].ToString();
                if (dtOrganization.Rows[0]["CityId"].ToString() != "")
                    o.CityId = Convert.ToInt32(dtOrganization.Rows[0]["CityId"].ToString());
                else
                    o.CityId = 0;
                o.CityName = dtOrganization.Rows[0]["CityName"].ToString();
                o.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                o.AddressLine1 = dtOrganization.Rows[0]["AddressLine1"].ToString();
                o.AddressLine2 = dtOrganization.Rows[0]["AddressLine2"].ToString();
                o.PostalCode = dtOrganization.Rows[0]["PostalCode"].ToString();
                o.TimeZone = dtOrganization.Rows[0]["TimeZone"].ToString();
                o.Phone = dtOrganization.Rows[0]["Phone"].ToString();
                o.Mobile = dtOrganization.Rows[0]["Mobile"].ToString();
                o.InCharge = dtOrganization.Rows[0]["InCharge"].ToString();
                o.IsExternalReference = Convert.ToBoolean(dtOrganization.Rows[0]["IsExternalReference"].ToString());
                o.MaxAppointmentDays = Convert.ToInt32(dtOrganization.Rows[0]["MaxAppointmentDays"].ToString());
                o.IsApprovalSystem = Convert.ToBoolean(dtOrganization.Rows[0]["IsApprovalSystem"].ToString());
                o.IsCarParkFacility = Convert.ToBoolean(dtOrganization.Rows[0]["IsCarParkFacility"].ToString());
                o.IsConditionsPage = Convert.ToBoolean(dtOrganization.Rows[0]["IsConditionsPage"].ToString());
                o.SubDomain = dtOrganization.Rows[0]["SubDomain"].ToString();
                o.CNameUrl = dtOrganization.Rows[0]["CNameUrl"].ToString();
                o.WelcomeTitle = dtOrganization.Rows[0]["WelcomeTitle"].ToString();
                o.AboutOrganization = dtOrganization.Rows[0]["AboutOrganization"].ToString();
                o.ReferedBy = dtOrganization.Rows[0]["ReferedBy"].ToString();
                o.ReferenceToken = dtOrganization.Rows[0]["ReferenceToken"].ToString();
                o.CreatedOn = Convert.ToDateTime(dtOrganization.Rows[0]["CreatedOn"].ToString());
                o.IsDeleted = Convert.ToBoolean(dtOrganization.Rows[0]["IsDeleted"].ToString());
            }

            return o;
        }

        public OrganizationDO GetOrganizationById(int id)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationById(id);

            OrganizationDO o = null;

            if (dtOrganization.Rows.Count > 0)
            {
                o = new OrganizationDO();
                o.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                o.LoginId = Convert.ToInt32(dtOrganization.Rows[0]["LoginId"].ToString());
                o.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                o.CountryId = Convert.ToInt32(dtOrganization.Rows[0]["CountryId"].ToString());
                o.CountryName = dtOrganization.Rows[0]["CountryName"].ToString();
                if (dtOrganization.Rows[0]["StateId"].ToString() != "")
                    o.StateId = Convert.ToInt32(dtOrganization.Rows[0]["StateId"].ToString());
                else
                    o.StateId = 0;
                o.StateName = dtOrganization.Rows[0]["StateName"].ToString();
                if (dtOrganization.Rows[0]["CityId"].ToString() != "")
                    o.CityId = Convert.ToInt32(dtOrganization.Rows[0]["CityId"].ToString());
                else
                    o.CityId = 0;
                o.CityName = dtOrganization.Rows[0]["CityName"].ToString();
                o.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                o.Address = dtOrganization.Rows[0]["Address"].ToString().Trim();
                o.AddressLine1 = dtOrganization.Rows[0]["AddressLine1"].ToString();
                o.AddressLine2 = dtOrganization.Rows[0]["AddressLine2"].ToString();
                o.PostalCode = dtOrganization.Rows[0]["PostalCode"].ToString();
                o.TimeZone = dtOrganization.Rows[0]["TimeZone"].ToString();
                o.Phone = dtOrganization.Rows[0]["Phone"].ToString();
                o.Mobile = dtOrganization.Rows[0]["Mobile"].ToString();
                o.InCharge = dtOrganization.Rows[0]["InCharge"].ToString();
                o.IsExternalReference = Convert.ToBoolean(dtOrganization.Rows[0]["IsExternalReference"].ToString());
                o.MaxAppointmentDays = Convert.ToInt32(dtOrganization.Rows[0]["MaxAppointmentDays"].ToString());
                o.IsApprovalSystem = Convert.ToBoolean(dtOrganization.Rows[0]["IsApprovalSystem"].ToString());
                o.IsCarParkFacility = Convert.ToBoolean(dtOrganization.Rows[0]["IsCarParkFacility"].ToString());
                o.IsConditionsPage = Convert.ToBoolean(dtOrganization.Rows[0]["IsConditionsPage"].ToString());
                o.SubDomain = dtOrganization.Rows[0]["SubDomain"].ToString();
                o.CNameUrl = dtOrganization.Rows[0]["CNameUrl"].ToString();
                o.WelcomeTitle = dtOrganization.Rows[0]["WelcomeTitle"].ToString();
                o.AboutOrganization = dtOrganization.Rows[0]["AboutOrganization"].ToString();
                o.ReferedBy = dtOrganization.Rows[0]["ReferedBy"].ToString();
                o.ReferenceToken = dtOrganization.Rows[0]["ReferenceToken"].ToString();
                o.CreatedOn = Convert.ToDateTime(dtOrganization.Rows[0]["CreatedOn"].ToString());
                o.IsDeleted = Convert.ToBoolean(dtOrganization.Rows[0]["IsDeleted"].ToString());
            }

            return o;
        }

        public OrganizationDO GetOrganizationByDoctorId(int doctorId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationByDoctorId(doctorId);

            OrganizationDO o = null;

            if (dtOrganization.Rows.Count > 0)
            {
                o = new OrganizationDO();
                o.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                o.LoginId = Convert.ToInt32(dtOrganization.Rows[0]["LoginId"].ToString());
                o.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                o.CountryId = Convert.ToInt32(dtOrganization.Rows[0]["CountryId"].ToString());
                o.CountryName = dtOrganization.Rows[0]["CountryName"].ToString();
                if (dtOrganization.Rows[0]["StateId"].ToString() != "")
                    o.StateId = Convert.ToInt32(dtOrganization.Rows[0]["StateId"].ToString());
                else
                    o.StateId = 0;
                o.StateName = dtOrganization.Rows[0]["StateName"].ToString();
                if (dtOrganization.Rows[0]["CityId"].ToString() != "")
                    o.CityId = Convert.ToInt32(dtOrganization.Rows[0]["CityId"].ToString());
                else
                    o.CityId = 0;
                o.CityName = dtOrganization.Rows[0]["CityName"].ToString();
                o.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                o.Address = dtOrganization.Rows[0]["Address"].ToString().Trim();
                o.AddressLine1 = dtOrganization.Rows[0]["AddressLine1"].ToString();
                o.AddressLine2 = dtOrganization.Rows[0]["AddressLine2"].ToString();
                o.PostalCode = dtOrganization.Rows[0]["PostalCode"].ToString();
                o.TimeZone = dtOrganization.Rows[0]["TimeZone"].ToString();
                o.Phone = dtOrganization.Rows[0]["Phone"].ToString();
                o.Mobile = dtOrganization.Rows[0]["Mobile"].ToString();
                o.InCharge = dtOrganization.Rows[0]["InCharge"].ToString();
                o.IsExternalReference = Convert.ToBoolean(dtOrganization.Rows[0]["IsExternalReference"].ToString());
                o.MaxAppointmentDays = Convert.ToInt32(dtOrganization.Rows[0]["MaxAppointmentDays"].ToString());
                o.IsApprovalSystem = Convert.ToBoolean(dtOrganization.Rows[0]["IsApprovalSystem"].ToString());
                o.IsCarParkFacility = Convert.ToBoolean(dtOrganization.Rows[0]["IsCarParkFacility"].ToString());
                o.IsConditionsPage = Convert.ToBoolean(dtOrganization.Rows[0]["IsConditionsPage"].ToString());
                o.SubDomain = dtOrganization.Rows[0]["SubDomain"].ToString();
                o.CNameUrl = dtOrganization.Rows[0]["CNameUrl"].ToString();
                o.WelcomeTitle = dtOrganization.Rows[0]["WelcomeTitle"].ToString();
                o.AboutOrganization = dtOrganization.Rows[0]["AboutOrganization"].ToString();
                o.ReferedBy = dtOrganization.Rows[0]["ReferedBy"].ToString();
                o.ReferenceToken = dtOrganization.Rows[0]["ReferenceToken"].ToString();
                o.CreatedOn = Convert.ToDateTime(dtOrganization.Rows[0]["CreatedOn"].ToString());
                o.IsDeleted = Convert.ToBoolean(dtOrganization.Rows[0]["IsDeleted"].ToString());
            }

            return o;
        }

        public OrganizationDO GetOrganizationByServiceId(int serviceId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationByServiceId(serviceId);

            OrganizationDO o = null;

            if (dtOrganization.Rows.Count > 0)
            {
                o = new OrganizationDO();
                o.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                o.LoginId = Convert.ToInt32(dtOrganization.Rows[0]["LoginId"].ToString());
                o.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                o.CountryId = Convert.ToInt32(dtOrganization.Rows[0]["CountryId"].ToString());
                o.CountryName = dtOrganization.Rows[0]["CountryName"].ToString();
                if (dtOrganization.Rows[0]["StateId"].ToString() != "")
                    o.StateId = Convert.ToInt32(dtOrganization.Rows[0]["StateId"].ToString());
                else
                    o.StateId = 0;
                o.StateName = dtOrganization.Rows[0]["StateName"].ToString();
                if (dtOrganization.Rows[0]["CityId"].ToString() != "")
                    o.CityId = Convert.ToInt32(dtOrganization.Rows[0]["CityId"].ToString());
                else
                    o.CityId = 0;
                o.CityName = dtOrganization.Rows[0]["CityName"].ToString();
                o.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                o.Address = dtOrganization.Rows[0]["Address"].ToString().Trim();
                o.AddressLine1 = dtOrganization.Rows[0]["AddressLine1"].ToString();
                o.AddressLine2 = dtOrganization.Rows[0]["AddressLine2"].ToString();
                o.PostalCode = dtOrganization.Rows[0]["PostalCode"].ToString();
                o.TimeZone = dtOrganization.Rows[0]["TimeZone"].ToString();
                o.Phone = dtOrganization.Rows[0]["Phone"].ToString();
                o.Mobile = dtOrganization.Rows[0]["Mobile"].ToString();
                o.InCharge = dtOrganization.Rows[0]["InCharge"].ToString();
                o.IsExternalReference = Convert.ToBoolean(dtOrganization.Rows[0]["IsExternalReference"].ToString());
                o.MaxAppointmentDays = Convert.ToInt32(dtOrganization.Rows[0]["MaxAppointmentDays"].ToString());
                o.IsApprovalSystem = Convert.ToBoolean(dtOrganization.Rows[0]["IsApprovalSystem"].ToString());
                o.IsCarParkFacility = Convert.ToBoolean(dtOrganization.Rows[0]["IsCarParkFacility"].ToString());
                o.IsConditionsPage = Convert.ToBoolean(dtOrganization.Rows[0]["IsConditionsPage"].ToString());
                o.SubDomain = dtOrganization.Rows[0]["SubDomain"].ToString();
                o.CNameUrl = dtOrganization.Rows[0]["CNameUrl"].ToString();
                o.WelcomeTitle = dtOrganization.Rows[0]["WelcomeTitle"].ToString();
                o.AboutOrganization = dtOrganization.Rows[0]["AboutOrganization"].ToString();
                o.ReferedBy = dtOrganization.Rows[0]["ReferedBy"].ToString();
                o.ReferenceToken = dtOrganization.Rows[0]["ReferenceToken"].ToString();
                o.CreatedOn = Convert.ToDateTime(dtOrganization.Rows[0]["CreatedOn"].ToString());
                o.IsDeleted = Convert.ToBoolean(dtOrganization.Rows[0]["IsDeleted"].ToString());
            }

            return o;
        }

        public int GetOrganizationId(string signInId) //changed temporary instead of this below one
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganization(signInId);

            if (dtOrganization.Rows.Count > 0)
            {
                return Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public int GetOrganizationNamebyAccountId(string signInId, int accountId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationNamebyAccountId(signInId, accountId);

            if (dtOrganization.Rows.Count > 0)
            {
                return Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public AppointmentDO GetAppointmentByDoctorId(int doctorId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationByDoctorId(doctorId);

            AppointmentDO a = new AppointmentDO();
            if (dtOrganization.Rows.Count > 0)
            {
                a.DoctorId = doctorId;
                a.DoctorName = dtOrganization.Rows[0]["DoctorName"].ToString();
                a.DoctorNameWithDegree = dtOrganization.Rows[0]["DoctorNameWithDegree"].ToString();
                a.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                a.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                a.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                //if (dtOrganization.Rows[0]["AddressLine2"].ToString() == string.Empty)
                //    a.Address = dtOrganization.Rows[0]["AddressLine1"].ToString() + "\n" + dtOrganization.Rows[0]["CityName"].ToString() + "\n" + dtOrganization.Rows[0]["StateName"].ToString() + "\n" + dtOrganization.Rows[0]["CountryName"].ToString() + "\n" + dtOrganization.Rows[0]["PostalCode"].ToString() + "\nPhone: " + dtOrganization.Rows[0]["Phone"].ToString(); // + "\nMobile: " + dtOrganization.Rows[0]["Mobile"].ToString();
                //else
                a.Address = dtOrganization.Rows[0]["Address"].ToString().Trim() + dtOrganization.Rows[0]["CityName"].ToString() + "\n" + dtOrganization.Rows[0]["StateName"].ToString() + "\n" + dtOrganization.Rows[0]["CountryName"].ToString() + "\n" + dtOrganization.Rows[0]["PostalCode"].ToString() + "\nPhone: " + dtOrganization.Rows[0]["Phone"].ToString(); // +"\nMobile: " + dtOrganization.Rows[0]["Mobile"].ToString();
                
                return a;
            }
            else
            {
                return a;
            }
        }

        public AppointmentDO GetAppointmentByServiceId(int serviceId)
        {
            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationByServiceId(serviceId);

            AppointmentDO a = new AppointmentDO();
            if (dtOrganization.Rows.Count > 0)
            {
                a.ServiceId = serviceId;
                a.Service = dtOrganization.Rows[0]["ServiceName"].ToString();
                a.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                a.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                a.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                //if (dtOrganization.Rows[0]["AddressLine2"].ToString() == string.Empty)
                //    a.Address = dtOrganization.Rows[0]["AddressLine1"].ToString() + "\n" + dtOrganization.Rows[0]["CityName"].ToString() + "\n" + dtOrganization.Rows[0]["StateName"].ToString() + "\n" + dtOrganization.Rows[0]["CountryName"].ToString() + "\n" + dtOrganization.Rows[0]["PostalCode"].ToString() + "\nPhone: " + dtOrganization.Rows[0]["Phone"].ToString();// + "\nMobile: " + dtOrganization.Rows[0]["Mobile"].ToString();
                //else
                a.Address = dtOrganization.Rows[0]["Address"].ToString().Trim() + "\n" + dtOrganization.Rows[0]["CityName"].ToString() + "\n" + dtOrganization.Rows[0]["StateName"].ToString() + "\n" + dtOrganization.Rows[0]["CountryName"].ToString() + "\n" + dtOrganization.Rows[0]["PostalCode"].ToString() + "\nPhone: " + dtOrganization.Rows[0]["Phone"].ToString();// +"\nMobile: " + dtOrganization.Rows[0]["Mobile"].ToString();

                return a;
            }
            else
            {
                return a;
            }
        }

        public string GetOrganizationNameById(int organizationId)
        {
            return _objOrganizationDAL.GetOrganizationNameById(organizationId);
        }

        public int ValidateOrganization(string organizationName)
        {
            return _objOrganizationDAL.ValidateOrganization(organizationName);
        }

        public int ValidateSubDomain(string subDomain, int organizationId)
        {
            return _objOrganizationDAL.ValidateSubDomain(subDomain, organizationId);
        }

        public DataTable GetOrganizationsByDoctorServiceId(int id, int type)
        {
            return _objOrganizationDAL.GetOrganizationsByDoctorServiceId(id, type);
        }

        //following are the doctorlist for particular org

        public DataTable GetDepartmentsByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetDepartmentsByOrganizationId(organizationId);
        }

        public DataTable GetDoctorServiceByOrganizationId(int organizationId, int departmentId)
        {
            return _objOrganizationDAL.GetDoctorServiceByOrganizationId(organizationId, departmentId);
        }

        public DataTable GetDoctorServiceSessionByOrganizationId(int doctorserviceId, int type)
        {
            return _objOrganizationDAL.GetDoctorServiceSessionByOrganizationId(doctorserviceId, type);
        }

        //for hospital Direct appointment

        public DataTable GetDoctorServiceById(int organizationId)
        {
            return _objOrganizationDAL.GetDoctorServiceById(organizationId);
        }

        public DataTable GetAllDoctorServiceById(int organizationId)
        {
            return _objOrganizationDAL.GetAllDoctorServiceById(organizationId);
        }

        public DataTable GetDoctorServiceByExceptLonginId(int organizationId, int loginId)
        {
            return _objOrganizationDAL.GetDoctorServiceByExceptLonginId(organizationId, loginId);
        }

        public OrganizationDO GetOrganizationBySubDomain(string subDomain)
        {
            int organizationId = _objOrganizationDAL.GetOrganizationBySubDomain(subDomain);

            OrganizationDO o = null;

            if (organizationId == 0)
            {
                return o;
            }

            DataTable dtOrganization = _objOrganizationDAL.GetOrganizationById(organizationId);

            if (dtOrganization.Rows.Count > 0)
            {
                o = new OrganizationDO();
                o.OrganizationId = Convert.ToInt32(dtOrganization.Rows[0]["OrganizationId"].ToString());
                o.LoginId = Convert.ToInt32(dtOrganization.Rows[0]["LoginId"].ToString());
                o.OrganizationName = dtOrganization.Rows[0]["OrganizationName"].ToString();
                o.CountryId = Convert.ToInt32(dtOrganization.Rows[0]["CountryId"].ToString());
                o.CountryName = dtOrganization.Rows[0]["CountryName"].ToString();
                if (dtOrganization.Rows[0]["StateId"].ToString() != "")
                    o.StateId = Convert.ToInt32(dtOrganization.Rows[0]["StateId"].ToString());
                else
                    o.StateId = 0;
                o.StateName = dtOrganization.Rows[0]["StateName"].ToString();
                if (dtOrganization.Rows[0]["CityId"].ToString() != "")
                    o.CityId = Convert.ToInt32(dtOrganization.Rows[0]["CityId"].ToString());
                else
                    o.CityId = 0;
                o.CityName = dtOrganization.Rows[0]["CityName"].ToString();
                o.BranchName = dtOrganization.Rows[0]["BranchName"].ToString();
                o.Address = dtOrganization.Rows[0]["Address"].ToString().Trim();
                o.AddressLine1 = dtOrganization.Rows[0]["AddressLine1"].ToString();
                o.AddressLine2 = dtOrganization.Rows[0]["AddressLine2"].ToString();
                o.PostalCode = dtOrganization.Rows[0]["PostalCode"].ToString();
                o.TimeZone = dtOrganization.Rows[0]["TimeZone"].ToString();
                o.Phone = dtOrganization.Rows[0]["Phone"].ToString();
                o.Mobile = dtOrganization.Rows[0]["Mobile"].ToString();
                o.InCharge = dtOrganization.Rows[0]["InCharge"].ToString();
                o.IsExternalReference = Convert.ToBoolean(dtOrganization.Rows[0]["IsExternalReference"].ToString());
                o.MaxAppointmentDays = Convert.ToInt32(dtOrganization.Rows[0]["MaxAppointmentDays"].ToString());
                o.IsApprovalSystem = Convert.ToBoolean(dtOrganization.Rows[0]["IsApprovalSystem"].ToString());
                o.IsCarParkFacility = Convert.ToBoolean(dtOrganization.Rows[0]["IsCarParkFacility"].ToString());
                o.IsConditionsPage = Convert.ToBoolean(dtOrganization.Rows[0]["IsConditionsPage"].ToString());
                o.SubDomain = dtOrganization.Rows[0]["SubDomain"].ToString();
                o.CNameUrl = dtOrganization.Rows[0]["CNameUrl"].ToString();
                o.WelcomeTitle = dtOrganization.Rows[0]["WelcomeTitle"].ToString();
                o.AboutOrganization = dtOrganization.Rows[0]["AboutOrganization"].ToString();
                o.ReferedBy = dtOrganization.Rows[0]["ReferedBy"].ToString();
                o.ReferenceToken = dtOrganization.Rows[0]["ReferenceToken"].ToString();
                o.CreatedOn = Convert.ToDateTime(dtOrganization.Rows[0]["CreatedOn"].ToString());
                o.IsDeleted = Convert.ToBoolean(dtOrganization.Rows[0]["IsDeleted"].ToString());
            }

            return o;
        }

        public DataTable GetScheduleDoctorServiceByOrganizationId(int organizationId, int doctorId)
        {
            return _objOrganizationDAL.GetScheduleDoctorServiceByOrganizationId(organizationId, doctorId);
        }

        public bool SaveBranding(BrandingDO b)
        {
            try
            {
                _objOrganizationDAL.SaveBranding(b.OrganizationId, b.SubDomain, b.CNameUrl);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public BrandingDO GetBranding(int organizationId)
        {
            DataTable dtBranding = _objOrganizationDAL.GetBranding(organizationId);

            BrandingDO b = null;

            if (dtBranding.Rows.Count > 0)
            {
                b = new BrandingDO();
                b.OrganizationId = Convert.ToInt32(dtBranding.Rows[0]["OrganizationId"].ToString());
                b.SubDomain = dtBranding.Rows[0]["SubDomain"].ToString();
                b.CNameUrl = dtBranding.Rows[0]["CNameUrl"].ToString();
            }

            return b;
        }

        public string GetTimeZoneById(int doctorServiceId, int type)
        {
            return _objOrganizationDAL.GetTimeZoneById(doctorServiceId, type);
        }

        public string GetTimeZoneByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetTimeZoneByOrganizationId(organizationId);
        }

        public int GetActivationById(int organizationId)
        {
            return _objOrganizationDAL.GetActivationById(organizationId);
        }

        public int GetAppointmentByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetAppointmentByOrganizationId(organizationId);
        }

        public int GetDoctorServiceCountByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetDoctorServiceCountByOrganizationId(organizationId);
        }

        public int GetDoctorCountByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetDoctorCountByOrganizationId(organizationId);
        }

        public int GetServiceCountByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetServiceCountByOrganizationId(organizationId);
        }

        public int GetScheduleCountByOrganizationId(int organizationId)
        {
            return _objOrganizationDAL.GetScheduleCountByOrganizationId(organizationId);
        }

        public DataRow GetAddressByDoctorTimingId(int doctorTimingId)
        {
            return _objOrganizationDAL.GetAddressByDoctorTimingId(doctorTimingId);
        }

        public string GetTimeZoneByDoctorserviceTimingId(int doctorServiceTimingId, int type)
        {
            return _objOrganizationDAL.GetTimeZoneByDoctorserviceTimingId(doctorServiceTimingId, type);
        }

        public DataTable GetSMSByOrganization(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetSMSByOrganization(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetSMSByOrganizationForDoctor(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetSMSByOrganizationForDoctor(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetRemindSMSByOrganizationForDoctorService(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetRemindSMSByOrganizationForDoctorService(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetSMSByOrganizationForService(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetSMSByOrganizationForService(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetSMSByOrganizationForPatient(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetSMSByOrganizationForPatient(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetRemindSMSByOrganizationForPatient(string fromDate, string toDate, int accountTypeId, int organizationId)
        {
            return _objOrganizationDAL.GetRemindSMSByOrganizationForPatient(fromDate, toDate, accountTypeId, organizationId);
        }

        public DataTable GetSMSCountByOrganization(int organizationId)
        {
            return _objOrganizationDAL.GetSMSCountByOrganization(organizationId);
        }

        public DataTable GetSMSCountByOrganizationForPeriod(string fromDate, string toDate, int organizationId)
        {
            return _objOrganizationDAL.GetSMSCountByOrganizationForPeriod(fromDate, toDate, organizationId);
        }

        public DataTable GetSMSCountByMobileForOrganizationForPeriod(string fromDate, string toDate, int organizationId, string mobile)
        {
            return _objOrganizationDAL.GetSMSCountByMobileForOrganizationForPeriod(fromDate, toDate, organizationId, mobile);
        }

        public DataTable GetSMSByMobile(string fromDate, string toDate, int organizationId, string mobile)
        {
            return _objOrganizationDAL.GetSMSByMobile(fromDate, toDate, organizationId, mobile);
        }
    }
}
