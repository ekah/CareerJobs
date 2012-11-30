using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class LandingDO
    {
        public int LandingId { set; get; }

        public int Version { set; get; }

        public int PublishId { set; get; }

        public int DepartmentId { set; get; }

        public string Forms { set; get; }

        public List<MainTabDO> MainTabs { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime ModifiedOn { set; get; }
    }
}
