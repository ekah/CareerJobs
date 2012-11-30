using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MedAppointments.DataAccessLayer
{
    public class Job_HrLoginDAL : Connection
    {

        ///<summary>
        ///  Hr Login 
        ///</summary>

        /// <summary>
        /// This Procedure [USP_Job_HrLoginSelectByUserName] is refered inJob_HrAccessDAL.cs Also
        /// </summary>
        /// <param name="username"></param>
        /// <param name="clientid"></param>
        /// <returns></returns>
        public DataSet HrLoginSelectByUserName(string username, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@UserName", username);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HrLoginSelectByUserName", objprmArray);
        }

    }
}
