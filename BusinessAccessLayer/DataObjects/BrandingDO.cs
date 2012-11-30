using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class BrandingDO
    {
        public int OrganizationId { set; get; }

        public string SubDomain { set; get; }

        public string CNameUrl { set; get; }
    }
}
