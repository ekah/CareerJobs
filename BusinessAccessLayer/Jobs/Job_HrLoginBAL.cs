using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;


namespace MedAppointments.BusinessAccessLayer
{
    public class Job_HrLoginBAL
    {
        Job_HrLoginDAL objLoginDAL = new Job_HrLoginDAL();

        public DataSet HrLoginSelectByUserName(string username, int clientid)
        {
            return objLoginDAL.HrLoginSelectByUserName(username, clientid);
        }
    }
}
