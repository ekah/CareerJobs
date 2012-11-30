using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_SearchDescriptionColVisibleDAL : Connection
    {

        public DataSet SDColVisibleSelectByVisibleAll()
        {         
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SDColVisibleSelectByVisibleAll", null);
        }
        public DataSet SDColVisibleSelectByVisible(int clientId)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SDColVisibleSelectByVisible", objprmArray);
        }
        public void InsertUpdateSDColVisible(int SdId,bool jobid, bool jobtitle, bool facility, bool speciality, bool country, bool state, bool city, bool description, bool posteddate, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[13];
            objprmArray[0] = new SqlParameter("@SdId", SdId);
            objprmArray[1] = new SqlParameter("@JobId", jobid);
            objprmArray[2] = new SqlParameter("@JobTitle", jobtitle);
            objprmArray[3] = new SqlParameter("@Facility", facility);
            objprmArray[4] = new SqlParameter("@Speciality", speciality);
            objprmArray[5] = new SqlParameter("@Country", country);
            objprmArray[6] = new SqlParameter("@State", state);
            objprmArray[7] = new SqlParameter("@City", city);
            objprmArray[8] = new SqlParameter("@Description", description);
            objprmArray[9] = new SqlParameter("@PostedDate", posteddate);
            objprmArray[10] = new SqlParameter("@ClientId", clientid);
            objprmArray[11] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[12] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateSDColVisible", objprmArray);
        }

    }
}
