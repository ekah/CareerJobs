using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class SubTabDO
    {
        public int SubTabId { set; get; }

        public string SubTabName { set; get; }

        public string SubTabContent { set; get; }

        public int MainTabId { set; get; }
    }
}
