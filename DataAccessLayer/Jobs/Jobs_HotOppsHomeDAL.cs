using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Jobs_HotOppsHomeDAL : Connection
    {
        public DataSet SelectTopJobsByClientId(int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[1];
            objprmArray[0] = new SqlParameter("@ClientId", clientid);
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Job_SelectTopJobsByClientId", objprmArray);
        }

    }
}
