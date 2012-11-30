using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MedAppointments.DataAccessLayer
{
    public class Job_HotOppsColVisibleDAL : Connection
    {
        public DataSet HOColVisibleSelectByVisibleByAll()
        {          
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HOColVisibleSelectByVisibleByAll", null);
        }
        public DataSet HOColVisibleSelectByVisible(int clientId)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HOColVisibleSelectByVisible", objprmArray);
        }
        public void InsertUpdateHOColVisible(int hid,bool country, bool state, bool city, bool facility, bool speciality, bool postdate, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[10];
            objprmArray[0] = new SqlParameter("@HId", hid);
            objprmArray[1] = new SqlParameter("@Country", country);
            objprmArray[2] = new SqlParameter("@State", state);
            objprmArray[3] = new SqlParameter("@City", city);
            objprmArray[4] = new SqlParameter("@Facility", facility);
            objprmArray[5] = new SqlParameter("@Speciality", speciality);
            objprmArray[6] = new SqlParameter("@PostDate", postdate);
            objprmArray[7] = new SqlParameter("@ClientId", clientid);
            objprmArray[8] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[9] = new SqlParameter("@WhoUpdated", whoupdated);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateHOColVisible", objprmArray);
        }

        public DataSet ClientAlreadyExistsHO(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HOClientAlreadyExists", objprmArray);
        }
    }
}
