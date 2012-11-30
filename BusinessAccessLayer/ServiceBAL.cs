using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class ServiceBAL
    {
        ServiceDAL _objServiceDAL = new ServiceDAL();

        public bool SaveService(ServiceDO s)
        {
            try
            {
                _objServiceDAL.SaveService(s.ServiceId, s.OrganizationId, s.ServiceName, s.InCharge, s.DepartmentId, s.Units, s.Mobile, s.LoginNew.EmailId, s.LoginNew.Password, s.LoginNew.TransactionToken, s.ReferenceToken, s.CountryId, s.IsActivated);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SaveSchedule(ScheduleDO s)
        {
            try
            {
                _objServiceDAL.SaveSchedule(s.ServiceTimingId, s.ServiceId, s.Name, s.Address, s.Sunday, s.Monday, s.Tuesday, s.Wednesday, s.Thursday, s.Friday, s.Saturday, s.StartTime, s.EndTime, s.PatientDuration, s.IsApprovalSystem, s.IsApprovalNotificationSMS, s.IsApprovalNotificationEmail, s.MaxAppointmentDays, s.IsDefaultSddress, s.IsCarParkFacility, s.IsFCFS, s.MaxApps, s.AppointmentType, s.Conditions);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public ServiceDO GetService(string signInId)
        {
            DataTable dtService = _objServiceDAL.GetService(signInId);

            ServiceDO s = null;

            if (dtService.Rows.Count > 0)
            {
                LoginNewDO l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtService.Rows[0]["LoginId"].ToString());
                l.MobileId = dtService.Rows[0]["MobileId"].ToString();
                l.MedAppId = dtService.Rows[0]["MedAppId"].ToString();
                l.EmailId = dtService.Rows[0]["EmailId"].ToString();
                l.Password = "[Encrypted]";
                l.CreatedOn = Convert.ToDateTime(dtService.Rows[0]["CreatedOn"].ToString());
                l.IsDeleted = Convert.ToBoolean(dtService.Rows[0]["IsDeleted"].ToString());

                s = new ServiceDO();
                s.ServiceId = Convert.ToInt32(dtService.Rows[0]["ServiceId"].ToString());
                s.OrganizationId = Convert.ToInt32(dtService.Rows[0]["OrganizationId"].ToString());
                s.LoginNew = l;
                s.ServiceName = dtService.Rows[0]["ServiceName"].ToString();
                s.InCharge = dtService.Rows[0]["InCharge"].ToString();
                s.DepartmentId = Convert.ToInt32(dtService.Rows[0]["DepartmentId"].ToString());
                s.Units = Convert.ToInt32(dtService.Rows[0]["Units"].ToString());
                s.Mobile = dtService.Rows[0]["Mobile"].ToString();
                s.Units = Convert.ToInt32(dtService.Rows[0]["Units"].ToString());
                s.CreatedOn = Convert.ToDateTime(dtService.Rows[0]["CreatedOn"].ToString());
                s.IsDeleted = Convert.ToBoolean(dtService.Rows[0]["IsDeleted"].ToString());
                s.ReferenceToken = dtService.Rows[0]["ReferenceToken"].ToString();
                s.CountryId = Convert.ToInt32(dtService.Rows[0]["CountryId"]);
                s.IsActivated = Convert.ToBoolean(dtService.Rows[0]["IsActivated1"]);
            }

            return s;
        }

        public DataTable GetServiceBySearch(string search, int organizationId)
        {
            return _objServiceDAL.GetServiceBySearch(search, organizationId);
        }

        public DataTable GetScheduleBySearch(string search, int serviceId)
        {
            return _objServiceDAL.GetScheduleBySearch(search, serviceId);
        }

        public DataTable GetScheduleBySearchWithoutOrganizationVerification(string search, int serviceId)
        {
            return _objServiceDAL.GetScheduleBySearchWithoutOrganizationVerification(search, serviceId);
        }

        public string GetServiceNameById(int serviceId)
        {
            return _objServiceDAL.GetServiceNameById(serviceId);
        }

        public ServiceDO GetServiceById(int serviceId)
        {
            DataTable dtService = _objServiceDAL.GetServiceById(serviceId);

            ServiceDO s = null;

            if (dtService.Rows.Count > 0)
            {
                LoginNewDO l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtService.Rows[0]["LoginId"].ToString());
                l.MobileId = dtService.Rows[0]["MobileId"].ToString();
                l.MedAppId = dtService.Rows[0]["MedAppId"].ToString();
                l.EmailId = dtService.Rows[0]["EmailId"].ToString();
                l.Password = "[Encrypted]";
                l.CreatedOn = Convert.ToDateTime(dtService.Rows[0]["CreatedOn"].ToString());
                l.IsDeleted = Convert.ToBoolean(dtService.Rows[0]["IsDeleted"].ToString());

                s = new ServiceDO();
                s.ServiceId = Convert.ToInt32(dtService.Rows[0]["ServiceId"].ToString());
                s.OrganizationId = Convert.ToInt32(dtService.Rows[0]["OrganizationId"].ToString());
                s.LoginNew = l;
                s.ServiceName = dtService.Rows[0]["ServiceName"].ToString();
                s.InCharge = dtService.Rows[0]["InCharge"].ToString();
                s.DepartmentId = Convert.ToInt32(dtService.Rows[0]["DepartmentId"].ToString());
                s.Units = Convert.ToInt32(dtService.Rows[0]["Units"].ToString());
                s.Mobile = dtService.Rows[0]["Mobile"].ToString();
                s.Units = Convert.ToInt32(dtService.Rows[0]["Units"].ToString());
                s.CreatedOn = Convert.ToDateTime(dtService.Rows[0]["CreatedOn"].ToString());
                s.IsDeleted = Convert.ToBoolean(dtService.Rows[0]["IsDeleted"].ToString());
                s.ReferenceToken = dtService.Rows[0]["ReferenceToken"].ToString();
                s.CountryId = Convert.ToInt32(dtService.Rows[0]["CountryId"]);
                s.IsActivated = Convert.ToBoolean(dtService.Rows[0]["IsActivated1"]);
            }

            return s;
        }

        public void DeleteServiceById(int serviceId)
        {
            _objServiceDAL.DeleteServiceById(serviceId);
        }

        public ScheduleDO GetScheduleById(int scheduleId)
        {
            DataTable dtSchedule = _objServiceDAL.GetScheduleById(scheduleId);

            ScheduleDO s = null;

            if (dtSchedule.Rows.Count > 0)
            {
                s = new ScheduleDO();
                s.ServiceTimingId = Convert.ToInt32(dtSchedule.Rows[0]["ServiceTimingId"].ToString());
                s.ServiceId = Convert.ToInt32(dtSchedule.Rows[0]["ServiceId"].ToString());
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


        public void DeleteScheduleById(int serviceTimingId)
        {
            _objServiceDAL.DeleteScheduleById(serviceTimingId);
        }

        public DataTable GetBlockCalendarBySearch(string search, int serviceId)
        {
            return _objServiceDAL.GetBlockCalendarBySearch(search, serviceId);
        }

        public bool VerifyAcceptance(int serviceId)
        {
            int verifiedCount = _objServiceDAL.VerifyAcceptance(serviceId);

            if (verifiedCount > 0)
                return true;
            else
                return false;
        }

        public void UpdateAcceptance(int serviceId)
        {
            _objServiceDAL.UpdateAcceptance(serviceId);
        }

        public int GetServiceByEmailId(string emailId)
        {
            return _objServiceDAL.GetServiceByEmailId(emailId);
        }

        public DataTable GetEmailSMSNotification(int serviceId)
        {
            return _objServiceDAL.GetEmailSMSNotification(serviceId);
        }
    }
}
