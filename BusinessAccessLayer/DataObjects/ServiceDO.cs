using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class ServiceDO
    {
        public int ServiceId { set; get; }
        
        public int OrganizationId { set; get; }

        public LoginNewDO LoginNew { set; get; }

        public LoginDO Login { set; get; }

        public string ServiceName { set; get; }

        public string InCharge { set; get; }

        public int DepartmentId { set; get; }

        public int Units { set; get; }

        public string Mobile { set; get; }

        public string ReferenceToken { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }

        public bool IsActivated { set; get; }

        public int CountryId { set; get; }
    }
}
