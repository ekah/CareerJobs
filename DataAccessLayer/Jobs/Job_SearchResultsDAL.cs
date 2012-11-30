using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_SearchResultsDAL : Connection
    {
        public DataSet SearchResults(int clientid, string facility, string speciality, string country,string state,string city, string keyword)
        {
            SqlParameter[] objprmArray = new SqlParameter[7];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            objprmArray[1] = new SqlParameter("@Facility", facility);
            objprmArray[2] = new SqlParameter("@Speciality", speciality);
            objprmArray[3] = new SqlParameter("@Country", country);
            objprmArray[4] = new SqlParameter("@State", state);
            objprmArray[5] = new SqlParameter("@City", city);        
            objprmArray[6] = new SqlParameter("@Keyword", keyword);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SearchResults", objprmArray);
        }
    }
}
