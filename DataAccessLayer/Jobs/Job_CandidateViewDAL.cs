using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_CandidateViewDAL : Connection
    {

        public DataSet SelectCandidateByClientIdByAll()
        {            
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectCandidateByClientIdByAll", null);
        }
        public DataSet SelectCandidateByClientId(int clientId)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientId);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectCandidateByClientId", objprmArray);
        }
        public void UpdateCandidateDetails(int aid, string hrstatus, string finalstatus, string notes)
        {
            SqlParameter[] objprmArray = new SqlParameter[4];
            objprmArray[0] = new SqlParameter("@Aid", aid);
            objprmArray[1] = new SqlParameter("@HrStatus", hrstatus);
            objprmArray[2] = new SqlParameter("@FinalStatus", finalstatus);
            objprmArray[3] = new SqlParameter("@Notes", notes);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_UpdateCandidateDetails", objprmArray);
        }
        public void DeleteCandidateDetailsById(int aid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@Aid", aid);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteCandidateDetailsById", objprmArray);
        }

    }
}
