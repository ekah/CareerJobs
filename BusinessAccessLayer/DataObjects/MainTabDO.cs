using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class MainTabDO
    {
        public int MainTabId { set; get; }

        public string MainTabName { set; get; }

        public string MainTabContent { set; get; }

        public int LandingId { set; get; }
        
        public List<SubTabDO> SubTabs { set; get; }
    }
}
