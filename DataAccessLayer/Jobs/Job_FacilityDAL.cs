using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MedAppointments.DataAccessLayer
{
    public class Job_FacilityDAL : Connection
    {
        public DataSet SelectFacility()
        {        
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectFacility", null);
        }
        public DataSet FacilitySelectByClientID(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FacilitySelectByClientID", objprmArray);
        }
        public void InsertUpdateFacility(int facid, string facility, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[6];
            objprmArray[0] = new SqlParameter("@FacId", facid);
            objprmArray[1] = new SqlParameter("@Facility", facility);
            objprmArray[2] = new SqlParameter("@Visibility", visibility);
            objprmArray[3] = new SqlParameter("@ClientId", clientid);
            objprmArray[4] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[5] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateFacility", objprmArray);
        }
        public void InsertUpdateFacilityByClientId(int facid, string facility, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[6];
            objprmArray[0] = new SqlParameter("@FacId", facid);
            objprmArray[1] = new SqlParameter("@Facility", facility);
            objprmArray[2] = new SqlParameter("@Visibility", visibility);
            objprmArray[3] = new SqlParameter("@ClientId", clientid);
            objprmArray[4] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[5] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateFacilityByClientId", objprmArray);
        }
        public DataSet FacilitySelectByFacility(int clientid, string facility)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Facility", facility);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FacilitySelectByFacility", objprmArray);
        }
        public DataSet FacilitySelectByFacid(int facid, int clientid, string facility)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@facid", facid);
            objprmArray[1] = new SqlParameter("@Facility", facility);
            objprmArray[2] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_FacilitySelectByFacid", objprmArray);
        }

        public void DeleteFacility(int facilityid, int clientid)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteFacility", facilityid, clientid);
        }
    }
}
