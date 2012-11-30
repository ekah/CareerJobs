using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class SearchBAL
    {
        SearchDAL _objSearchDal = new SearchDAL();

        public DataSet GetSpeciality(int stateId, int cityId, int departmentId, string postalcode, int signLoginId)
        {
            return _objSearchDal.GetSpeciality(stateId, cityId, departmentId, postalcode, signLoginId);
        }

        public DataSet GetSpecialityByHospital(int stateID, int cityId, int departmentId, string postalcode)
        {
            return _objSearchDal.GetSpecialityByHospital(stateID, cityId, departmentId, postalcode);
        }

        public string GetSymptomIdBySymptom(string likeSymptom)
        {
            return _objSearchDal.GetSymptomIdBySymptom(likeSymptom);
        }

        public DataSet GetSymptom(int stateId, int cityId, string likeSymptom, string postalcode, int signLoginId)
        {
            string symptomIds = GetSymptomIdBySymptom(likeSymptom);

            return _objSearchDal.GetSymptom(stateId, cityId, symptomIds, postalcode, signLoginId);
        }

        public DataSet GetSymptomByHospital(int stateId, int cityId, string likeSymptom, string postalcode)
        {
            string symptomIds = GetSymptomIdBySymptom(likeSymptom);

            return _objSearchDal.GetSymptomByHospital(stateId, cityId, symptomIds, postalcode);
        }

        public DataTable GetCountry()
        {
            return _objSearchDal.GetCountry();
        }

        public DataTable GetState(int countryId)
        {
            return _objSearchDal.GetState(countryId);
        }

        public DataTable GetCity(int stateId)
        {
            return _objSearchDal.GetCity(stateId);
        }

        public DataTable GetPostalcode(int cityId)
        {
            return _objSearchDal.GetPostalcode(cityId);
        }

        public DataSet GetIPBasedInformation(string UserIP)
        {
            return _objSearchDal.GetIPBasedInformation(UserIP);
        }

        public DataSet GETLagitudeandLatitudebyIP(string strCountry, string strRegion, string strCity, string strDomain, string strORGIDS)
        {
            return _objSearchDal.GETLagitudeandLatitudebyIP(strCountry, strRegion, strCity, strDomain, strORGIDS);
        }

        public DataTable GetCountryByAccountTypeId(int id, int accountTypeId)
        {
            return _objSearchDal.GetCountryByAccountTypeId(id, accountTypeId);
        }

        public DataSet GetServiceSpecialityByOrganizationId(int departmentId, int organizationId, int signLoginId)
        {
            return _objSearchDal.GetServiceSpecialityByOrganizationId(departmentId, organizationId, signLoginId);
        }
    }
}
