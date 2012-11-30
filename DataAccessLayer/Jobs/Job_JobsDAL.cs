using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_JobsDAL : Connection
    {
        public DataSet SelectOrganization()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectOrganization", null);
        }
        public DataSet SelectOrganizationBasedOnFacility()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectOrganizationBasedOnFacility", null);
        }
        public DataSet SelectJob()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectJob", null);
        }
        public DataSet JobSelectByClientID(int clientid,int did)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            objprmArray[1] = new SqlParameter("@did", did);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_JobsSelectByClientID", objprmArray);
        }
        public DataSet FacilitySelectByClientIDVisible(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FacilitySelectByClientIDVisible", objprmArray);
        }
        public DataSet FacilitySelectByClientIDVisibleInJobs(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FacilitySelectByClientIDVisibleInJobs", objprmArray);
        }
        public DataSet SpecialitySelectByClientIDVisible(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SpecialitySelectByClientIDVisible", objprmArray);
        }
        public DataSet SpecialitySelectByClientIDVisibleInJobs(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SpecialitySelectByClientIDVisibleInJobs", objprmArray);
        }
        public DataSet CountrySelectByClientIDVisible(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_CountrySelectByClientIDVisible", objprmArray);
        }
        public DataSet CountrySelectInStateByClientIDVisible(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_CountrySelectInStateByClientIDVisible", objprmArray);
        }
        public DataSet StateSelectInStateByClientIDVisibleByAdmin(int clientid, int lid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Lid", lid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_StateSelectInStateByClientIDVisibleByAdmin", objprmArray);
        }
        public DataSet StateSelectInStateByClientIDVisible(int clientid, string lid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Lid", lid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_StateSelectInStateByClientIDVisible", objprmArray);
        }
        public DataSet CitySelectByClientIDCountryStateIDVisible(int clientid, string countryid, int stateid)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            objprmArray[1] = new SqlParameter("@countryid", countryid);
            objprmArray[2] = new SqlParameter("@stateid", stateid); 
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_CitySelectByClientIDCountryStateIDVisible", objprmArray);
        }
        public DataSet CitySelectByClientIDCountryStateIDVisibleByAdmin(int clientid, int countryid, int stateid)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            objprmArray[1] = new SqlParameter("@countryid", countryid);
            objprmArray[2] = new SqlParameter("@stateid", stateid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_CitySelectByClientIDCountryStateIDVisibleByAdmin", objprmArray);
        }
        public DataSet SelectJobByJobId(string jobid, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@JobId", jobid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectJobByJobId", objprmArray);
        }
        public void InsertUpdateJob(string jobid, string jobtitle, int facility, int speciality, int Location, string description, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[10];
            objprmArray[0] = new SqlParameter("@JobId", jobid);
            objprmArray[1] = new SqlParameter("@JobTitle", jobtitle);
            objprmArray[2] = new SqlParameter("@Facility", facility);
            objprmArray[3] = new SqlParameter("@Speciality", speciality);
            objprmArray[4] = new SqlParameter("@Location", Location);         
            objprmArray[5] = new SqlParameter("@Description", description);
            objprmArray[6] = new SqlParameter("@Visibility", visibility);
            objprmArray[7] = new SqlParameter("@ClientId", clientid);
            objprmArray[8] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[9] = new SqlParameter("@WhoUpdated", whoupdated);
            SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_InsertUpdateJob", objprmArray);
        }
        public void DeleteJobByClientId(int jid, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Jid", jid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteJobByClienId", objprmArray);
        }
        //Job Portal
        public DataSet SelectByHospitalByChar(string startchar)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@startchar", startchar);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectByHospitalByChar", objprmArray);
        }
        public DataSet SelectBySpecialityByChar(string startchar)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@startchar", startchar);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectBySpecialityByChar", objprmArray);
        }
        public DataSet SelectDepartmentByClient(int did)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@did", did);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectDepartmentByClient", objprmArray);
        }
        public DataSet FindJobsAssociateWithLocation(int clientid, int lid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@clientid", clientid);
            objprmArray[1] = new SqlParameter("@lid", lid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FindJobsAssociateWithLocation", objprmArray);

        }
        public DataSet FindJobsAssociateWithFacility(int clientid,int facilityid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@clientid", clientid);
            objprmArray[1] = new SqlParameter("@facilityid", facilityid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FindJobsAssociateWithFacility", objprmArray);

        }
        public DataSet FindJobsAssociateWithSpeciality(int clientid, int specialityid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@clientid", clientid);
            objprmArray[1] = new SqlParameter("@specialityid", specialityid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FindJobsAssociateWithSpeciality", objprmArray);

        }
    }
}
