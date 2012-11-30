using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_CandidateDetailsDAL : Connection
    {
        public DataSet SelectCandidateDetailsByAidClientId(int aid, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Aid", aid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectCandidateDetailsByAidClientId", objprmArray);
        }
    }
}
