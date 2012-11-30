using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class PatientDO
    {
        public int PatientId { set; get; }

        public LoginDO Login { set; get; } //Dummy remove this after new login done

        public int LoginId { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public DateTime DateofBirth { set; get; }

        public bool Gender { set; get; }

        public int CountryId { set; get; }

        public string CountryName { set; get; }

        public int StateId { set; get; }

        public string StateName { set; get; }

        public int CityId { set; get; }

        public string CityName { set; get; }

        public string Address { set; get; }

        public string AddressLine1 { set; get; }

        public string AddressLine2 { set; get; }

        public string PostalCode { set; get; }

        public string Phone { set; get; }

        public string Mobile { set; get; }

        public int RelationshipId { set; get; }

        public List<PastHistoryDO> PastHistory { set; get; }

        public List<PersonalHistoryDO> PersonalHistory { set; get; }

        public List<FamilyHistoryDO> FamilyHistory { set; get; }

        public int ParentId { set; get; }

        public string ReferenceToken { set; get; }

        public int ReferedPatientId { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }

        public string PrimaryHolder { set; get; }
    }
}
