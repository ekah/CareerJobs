using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_LocationDAL : Connection
    {
        public DataSet SelectLocation()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectLocation", null);
        }
        public DataSet SelectLocationByClientId(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectLocationByClientId", objprmArray);
        }
        public DataSet SelectMasterCountry()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectMasterCountry", null);
        }
        public DataSet SelectMasterStateByCountryID(int countryid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@CountryId", countryid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectMasterStateByCountryID", objprmArray);
        }
        public DataSet SelectMasterCityByCountryStateID(int countryid, int stateid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@CountryId", countryid);
            objprmArray[1] = new SqlParameter("@StateId", stateid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectMasterCityByCountryStateID", objprmArray);
        }       
        public DataSet LocationSelectByIds(int clientid, int countryid, int stateid, int cityId)
        {
            SqlParameter[] objprmArray = new SqlParameter[4];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            objprmArray[1] = new SqlParameter("@Countryid", countryid);
            objprmArray[2] = new SqlParameter("@Stateid", stateid);
            objprmArray[3] = new SqlParameter("@CityId", cityId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_LocationSelectByIds", objprmArray);
        }
        public DataSet LocationSelectByLId(int lid, int clientid,int countryid, int stateid,int cityid)
        {
            SqlParameter[] objprmArray = new SqlParameter[5];
            objprmArray[0] = new SqlParameter("@Lid", lid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            objprmArray[2] = new SqlParameter("@Countryid", countryid);
            objprmArray[3] = new SqlParameter("@Stateid", stateid);
            objprmArray[4] = new SqlParameter("@Cityid", cityid); 
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_LocationSelectByLId", objprmArray);
        }
        public void InsertUpdateLocation(int lid, int countryid, int stateid, int cityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[8];
            objprmArray[0] = new SqlParameter("@Lid", lid);
            objprmArray[1] = new SqlParameter("@CountryId", countryid);
            objprmArray[2] = new SqlParameter("@StateId", stateid);
            objprmArray[3] = new SqlParameter("@CityId", cityid);
            objprmArray[4] = new SqlParameter("@Visibility", visibility);
            objprmArray[5] = new SqlParameter("@ClientId", clientid);
            objprmArray[6] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[7] = new SqlParameter("@WhoUpdated", whoupdated);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateLocation", objprmArray);
        }
        public void DeleteLocation(int lid,int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Lid", lid);           
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteLocation", objprmArray);
        }

    }
}
