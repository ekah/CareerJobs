using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_HrAccessDAL : Connection
    {
        public DataSet HrLoginSelectByClientIDByAll()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HrLoginSelectByClientIDByAll", null);
        }
        public DataSet HrLoginSelectByClientID(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HrLoginSelectByClientID", objprmArray);
        }
        public void InsertUpdateHrLogin(int hid, string username, string password, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[6];
            objprmArray[0] = new SqlParameter("@Hid", hid);
            objprmArray[1] = new SqlParameter("@UserName", username);
            objprmArray[2] = new SqlParameter("@Password", password);
            objprmArray[3] = new SqlParameter("@ClientId", clientid);
            objprmArray[4] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[5] = new SqlParameter("@WhoUpdated", whoupdated);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateHrLogin", objprmArray);
        }

        /// <summary>
        /// This Procedure [USP_Job_HrLoginSelectByUserName] is refered in Job_LoginDAL.cs Also
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
        public DataSet HrLoginSelectByUserNameById(int hid,string username, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@Hid", hid);
            objprmArray[1] = new SqlParameter("@UserName", username);
            objprmArray[2] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_HrLoginSelectByUserNameById", objprmArray);
        }  
        public void DeleteHrLogin(int hid, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Hid", hid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteHrLogin", objprmArray);
        }

    }
}
