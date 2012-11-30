using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class MasterDAL : Connection
    {
        public DataTable GetCountry()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetCountry").Tables[0];
        }

        public DataTable GetState(int countryId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetState", countryId).Tables[0];
        }

        public DataTable GetCity(int stateId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetCity", stateId).Tables[0];
        }

        public DataTable GetPastHistory()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetPastHistory").Tables[0];
        }

        public DataTable GetPersonalHistory()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetPersonalHistory").Tables[0];
        }

        public DataTable GetFamilyHistory()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetFamilyHistory").Tables[0];
        }

        public DataTable GetDepartment()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetDepartment").Tables[0];
        }

        public DataTable GetPreferential()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetPreferential").Tables[0];
        }

        public DataTable GetStatus()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetStatus").Tables[0];
        }

        public DataTable GetRelationship(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetRelationship", patientId).Tables[0];
        }

        public DataTable GetAllRelationship()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetAllRelationship").Tables[0];
        }

        public DataTable GetDiagnosis()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetDiagnosis").Tables[0];
        }

        public DataTable GetSymptom()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetSymptom").Tables[0];
        }

        public DataTable GetUniversity()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Master_GetUniversity").Tables[0];
        }
    }
}
