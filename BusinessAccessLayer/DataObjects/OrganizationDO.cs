using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class OrganizationDO
    {
        public int OrganizationId { set; get; }

        public LoginDO Login { set; get; } //Dummy remove this after new login done

        public int LoginId { set; get; }

        public string OrganizationName { set; get; }

        public int CountryId { set; get; }

        public string CountryName { set; get; }

        public int StateId { set; get; }

        public string StateName { set; get; }

        public int CityId { set; get; }

        public string CityName { set; get; }

        public string BranchName { set; get; }

        public string Address { set; get; }

        public string AddressLine1 { set; get; }

        public string AddressLine2 { set; get; }

        public string PostalCode { set; get; }

        public string Phone { set; get; }

        public string Mobile { set; get; }

        public string TimeZone { set; get; }

        public string InCharge { set; get; }

        public bool IsExternalReference { set; get; }

        public int MaxAppointmentDays { set; get; }

        public bool IsApprovalSystem { set; get; }

        public bool IsCarParkFacility { set; get; }

        public bool IsConditionsPage { set; get; }

        public string SubDomain { set; get; }

        public string CNameUrl { set; get; }

        public string WelcomeTitle { set; get; }

        public string AboutOrganization { set; get; }

        public string ReferedBy { set; get; }

        public string ReferenceToken { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }
    }
}
