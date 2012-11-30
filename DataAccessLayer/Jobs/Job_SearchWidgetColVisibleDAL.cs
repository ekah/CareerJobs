using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_SearchWidgetColVisibleDAL : Connection
    {
        public DataSet SWColVisibleSelectByVisibleByAll()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SWColVisibleSelectByVisibleByAll", null);
        }
        public DataSet SWColVisibleSelectByVisible(int clientId)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SWColVisibleSelectByVisible", objprmArray);
        }

        public void InsertUpdateSWColVisible(int SwId,bool country, bool state, bool city, bool facility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[8];
            objprmArray[0] = new SqlParameter("@SwId", SwId);
            objprmArray[1] = new SqlParameter("@Country", country);
            objprmArray[2] = new SqlParameter("@State", state);
            objprmArray[3] = new SqlParameter("@City", city);
            objprmArray[4] = new SqlParameter("@Facility", facility);
            objprmArray[5] = new SqlParameter("@ClientId", clientid);
            objprmArray[6] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[7] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateSWColVisible", objprmArray);
        }
    }
}
