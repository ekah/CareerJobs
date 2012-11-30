using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class DoctorDO
    {
        public int DoctorId { set; get; }

        public int OrganizationId { set; get; }

        public LoginDO Login { set; get; }

        public LoginNewDO LoginNew { set; get; }

        public string DoctorName { set; get; }

        public DateTime? DateofBirth { set; get; }

        public bool Gender { set; get; }

        public int RegistrationYear { set; get; }

        public string RegistrationNumber { set; get; }

        public decimal Experience { set; get; }

        public string Degrees { set; get; }

        public string Certifications { set; get; }

        public string PhotoName { set; get; }

        public string Mobile { set; get; }

        public int DepartmentId { set; get; }

        public string DepartmentName { set; get; }

        public string PreferredName { set; get; }

        public string ReferenceToken { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }

        public bool IsActivated { set; get; }

        public int CountryId { set; get; }

        public int UniversityId { set; get; }
    }
}
