using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class SymptomDO
    {
        public int SymptomGroupId { set; get; }

        public string SymptomGroup { set; get; }

        public int SymptomId { set; get; }

        public string Symptom { set; get; }

        public int DiagnosisId { set; get; }

        public string Diagnosis { set; get; }

        public int DepartmentId { set; get; }

        public string DepartmentName { set; get; }

        public int DoctorId { set; get; }
     }
}
