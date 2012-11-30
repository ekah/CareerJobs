using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_NewsLetterHomeDAL : Connection
    {
        public DataSet GetNewsLetterByEmailClientId(string email, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[2];
            objprmArray[0] = new SqlParameter("@Email", email);
            objprmArray[1] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_GetNewsLetterByEmailClientId", objprmArray);
        }

        public void InsertNewsLetter(string name, string email, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[3];
            objprmArray[0] = new SqlParameter("@name", name);
            objprmArray[1] = new SqlParameter("@email", email);
            objprmArray[2] = new SqlParameter("@clientid", clientid);
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertNewsLetter", objprmArray);
        }
    }
}
