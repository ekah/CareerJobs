using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class AppointmentDO
    {
        public int AppointmentId { set; get; }

        public int PatientId { set; get; }

        public int OrganizationId { set; get; }

        public string OrganizationName { set; get; }

        public string BranchName { set; get; }

        public string Address { set; get; }

        public int? DoctorId { set; get; }

        public int? DoctorTimingId { set; get; }

        public string DoctorName { set; get; }

        public string DoctorNameWithDegree { set; get; }

        public string Doctor { set; get; }

        public int? ServiceId { set; get; }
        
        public int? ServiceTimingId { set; get; }

        public string Service { set; get; }

        public DateTime AppointmentDate { set; get; }

        public string AppointmentTime { set; get; }

        public string OnCallAppointmentTime { set; get; }

        public string Notes { set; get; }

        public bool IsCarParkFacility { set; get; }

        public string CarNumber { set; get; }

        public int? PreferentialId { set; get; }

        public string Preferential { set; get; }

        public string PreferentialBoarding { set; get; }

        public string DoctorClosingNotes { set; get; }

        public int StatusId { set; get; }
        
        public string Status { set; get; }
        
        public bool IsDirectAppointment { set; get; }

        public int RelationshipId { set; get; }

        public string Relationship { set; get; }

        public DateTime AvailableDay { set; get; }

        public string AvailableTime { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }
    }
}
