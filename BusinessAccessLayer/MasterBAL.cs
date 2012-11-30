using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class MasterBAL
    {
        MasterDAL _objMasterDal = new MasterDAL();

        public DataTable GetCountry()
        {
            return _objMasterDal.GetCountry();
        }

        public DataTable GetState(int countryId)
        {
            return _objMasterDal.GetState(countryId);
        }

        public DataTable GetCity(int stateId)
        {
            return _objMasterDal.GetCity(stateId);
        }

        public DataTable GetPastHistory()
        {
            return _objMasterDal.GetPastHistory();
        }

        public DataTable GetPersonalHistory()
        {
            return _objMasterDal.GetPersonalHistory();
        }

        public DataTable GetFamilyHistory()
        {
            return _objMasterDal.GetFamilyHistory();
        }

        public DataTable GetDepartment()
        {
            return _objMasterDal.GetDepartment();
        }

        public DataTable GetPreferential()
        {
            return _objMasterDal.GetPreferential();
        }

        public DataTable GetStatus()
        {
            return _objMasterDal.GetStatus();
        }

        public DataTable GetRelationship(int patientId)
        {
            return _objMasterDal.GetRelationship(patientId);
        }

        public DataTable GetAllRelationship()
        {
            return _objMasterDal.GetAllRelationship();
        }

        public DataTable GetDiagnosis()
        {
            return _objMasterDal.GetDiagnosis();
        }

        public DataTable GetSymptom()
        {
            return _objMasterDal.GetSymptom();
        }

        public DataTable GetUniversity()
        {
            return _objMasterDal.GetUniversity();
        }
    }
}
