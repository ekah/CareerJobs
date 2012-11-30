using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class ScheduleDO
    {
        public int DoctorTimingId { set; get; }

        public int ServiceTimingId { set; get; }

        public int DoctorId { set; get; }

        public int ServiceId { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public bool Sunday { set; get; }

        public bool Monday { set; get; }

        public bool Tuesday { set; get; }

        public bool Wednesday { set; get; }

        public bool Thursday { set; get; }

        public bool Friday { set; get; }

        public bool Saturday { set; get; }

        public string StartTime { set; get; }

        public string EndTime { set; get; }

        public int PatientDuration { set; get; }

        public bool IsApprovalSystem { set; get; }

        public bool IsApprovalNotificationSMS { set; get; }

        public bool IsApprovalNotificationEmail { set; get; }

        public int MaxAppointmentDays { set; get; }

        public bool IsCarParkFacility { set; get; }

        public bool IsFCFS { set; get; }

        public int MaxApps { set; get; }

        public int AppointmentType { set; get; }

        public string Conditions { set; get; }

        public DateTime CreatedOn { set; get; }

        public bool IsDeleted { set; get; }

        public bool IsDefaultSddress { set; get; }
    }
}
