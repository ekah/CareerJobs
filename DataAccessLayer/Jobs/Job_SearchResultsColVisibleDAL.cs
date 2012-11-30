using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_SearchResultsColVisibleDAL : Connection
    {
        public DataSet SRColVisibleSelectByVisibleByAll()
        {          
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SRColVisibleSelectByVisibleByAll", null);
        }
        public DataSet SRColVisibleSelectByVisible(int clientId)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SRColVisibleSelectByVisible", objprmArray);
        }
        public void InsertUpdateSRColVisible(int SrId,bool country, bool state, bool city, bool facility, bool speciality, bool postdate, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[10];
            objprmArray[0] = new SqlParameter("@SrId", SrId);
            objprmArray[1] = new SqlParameter("@Country", country);
            objprmArray[2] = new SqlParameter("@State", state);
            objprmArray[3] = new SqlParameter("@City", city);
            objprmArray[4] = new SqlParameter("@Facility", facility);
            objprmArray[5] = new SqlParameter("@Speciality", speciality);
            objprmArray[6] = new SqlParameter("@PostDate", postdate);
            objprmArray[7] = new SqlParameter("@ClientId", clientid);
            objprmArray[8] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[9] = new SqlParameter("@WhoUpdated", whoupdated);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateSRColVisible", objprmArray);
        }
    }
}
