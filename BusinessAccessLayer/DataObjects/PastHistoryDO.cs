using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class PastHistoryDO
    {
        public int PatientId { set; get; }

        public int PastHistoryId { set; get; }
    }
}
