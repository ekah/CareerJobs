using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class FamilyHistoryDO
    {
        public int PatientId { set; get; }

        public int FamilyHistoryId { set; get; }
    }
}
