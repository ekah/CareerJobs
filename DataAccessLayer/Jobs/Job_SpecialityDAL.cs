using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MedAppointments.DataAccessLayer
{
    public class Job_SpecialityDAL : Connection
    {

        public DataSet SelectMasterSpeciality()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectMasterSpeciality", null);
        }
        public DataSet SelectSpeciality()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectSpeciality", null);
        }
        public DataSet SpecialitySelectByClientID(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SpecialitySelectByClientID", objprmArray);
        }
        public void InsertUpdateSpeciality(int spcid, int specialityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[6];
            objprmArray[0] = new SqlParameter("@SpcId", spcid);
            objprmArray[1] = new SqlParameter("@SpecialityId", specialityid);
            objprmArray[2] = new SqlParameter("@Visibility", visibility);
            objprmArray[3] = new SqlParameter("@ClientId", clientid);
            objprmArray[4] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[5] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateSpeciality", objprmArray);
        }
        public void InsertUpdateSpecialityByClientId(int spcid, int specialityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            SqlParameter[] objprmArray = new SqlParameter[6];
            objprmArray[0] = new SqlParameter("@SpcId", spcid);
            objprmArray[1] = new SqlParameter("@SpecialityId", specialityid);
            objprmArray[2] = new SqlParameter("@Visibility", visibility);
            objprmArray[3] = new SqlParameter("@ClientId", clientid);
            objprmArray[4] = new SqlParameter("@WhoCreated", whocreated);
            objprmArray[5] = new SqlParameter("@WhoUpdated", whoupdated);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertUpdateSpecialityByClientId", objprmArray);
        }
        public DataSet SpecialitySelectBySpeciality(int clientid, int specialityid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@SpecialityId", specialityid);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SpecialitySelectBySpeciality", objprmArray);
        }
        public DataSet SpecialitySelectBySpcId(int spcid,int clientid, int specialityid)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@SpcId", spcid);
            objprmArray[1] = new SqlParameter("@SpecialityId", specialityid);
            objprmArray[2] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SpecialitySelectBySpcId", objprmArray);
        }
        public void DeleteSpeciality(int specialityid, int clientid)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_DeleteSpeciality", specialityid, clientid);
        }
    }
}
