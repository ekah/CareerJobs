using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SearchDescriptionBAL
    {
        Job_SearchDescriptionDAL objSearchDescriptionDAL = new Job_SearchDescriptionDAL();
        public DataSet SelectJobByJobIdVisible(string jobid, int clientid)
        {
            return objSearchDescriptionDAL.SelectJobByJobIdVisible(jobid, clientid);
        }
        public DataSet GetSubDomainNameByClientId(int clientid)
        {
            return objSearchDescriptionDAL.GetSubDomainNameByClientId(clientid);
        }
    }
}
