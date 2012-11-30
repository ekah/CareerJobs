using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class PatientInfoDO
    {
        public int PatientId { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public string Phone { set; get; }

        public string Mobile { set; get; }

        public string Gender { set; get; }

        public string DateofBirth { set; get; }

        public string Relationship { set; get; }

        public string PastHistory { set; get; }

        public string PersonalHistory { set; get; }

        public string FamilyHistory { set; get; }

        public string Notes { set; get; }

        public string ClosingNotes { set; get; }

        public string SMSDetails { set; get; }
    }
}
