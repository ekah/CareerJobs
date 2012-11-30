using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_SearchDescriptionDAL : Connection
    {
        public DataSet SelectJobByJobIdVisible(string jobid, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@JobId", jobid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectJobByJobIdByVisible", objprmArray);
        }

        public DataSet GetSubDomainNameByClientId(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];          
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_GetSubDomainNameByClientId", objprmArray);
        }


    }
}
