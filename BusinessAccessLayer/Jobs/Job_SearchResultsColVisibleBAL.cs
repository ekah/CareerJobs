using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SearchResultsColVisibleBAL
    {
        Job_SearchResultsColVisibleDAL objSearchResultsColVisibleDAL = new Job_SearchResultsColVisibleDAL();

        public DataSet SRColVisibleSelectByVisibleByAll()
        {
            return objSearchResultsColVisibleDAL.SRColVisibleSelectByVisibleByAll();
        }
        public DataSet SRColVisibleSelectByVisible(int clientId)
        {
            return objSearchResultsColVisibleDAL.SRColVisibleSelectByVisible(clientId);
        }
        public void InsertUpdateSRColVisible(int SrId,bool country, bool state, bool city, bool facility, bool speciality, bool postdate, int clientid, string whocreated, string whoupdated)
        {
            objSearchResultsColVisibleDAL.InsertUpdateSRColVisible(SrId,country, state, city, facility, speciality, postdate, clientid, whocreated, whoupdated);
        }
    }
}
