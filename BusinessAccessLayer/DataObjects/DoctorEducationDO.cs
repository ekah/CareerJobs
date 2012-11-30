using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class DoctorEducationDO
    {
        public int EducationId { set; get; }

        public string University { set; get; }

        public string Degree { set; get; }

        public int CountryId { set; get; }

        public int CountryName { set; get; }

        public int StateId { set; get; }

        public string StateName { set; get; }

        public int CityId { set; get; }

        public string CityName { set; get; }

        public int YearFrom { set; get; }

        public int YearTo { set; get; }

        public string Notes { set; get; }

        public int DoctorId { set; get; }
    }
}
