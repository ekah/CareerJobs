using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class DoctorExperienceDO
    {
        public int ExperienceId { set; get; }

        public string MedicalServiceName { set; get; }

        public string Title { set; get; }

        public int CountryId { set; get; }

        public int CountryName { set; get; }

        public int StateId { set; get; }

        public string StateName { set; get; }

        public int CityId { set; get; }

        public string CityName { set; get; }

        public int MonthFrom { set; get; }

        public int YearFrom { set; get; }

        public int MonthTo { set; get; }

        public int YearTo { set; get; }

        public string Notes { set; get; }

        public int DoctorId { set; get; }
    }
}
