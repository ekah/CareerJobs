using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SearchWidgetColVisibleBAL
    {
        Job_SearchWidgetColVisibleDAL objSearchWidgetColVisibleDAL = new Job_SearchWidgetColVisibleDAL();

        public DataSet SWColVisibleSelectByVisibleByAll()
        {
            return objSearchWidgetColVisibleDAL.SWColVisibleSelectByVisibleByAll();
        }        
        public DataSet SWColVisibleSelectByVisible(int clientId)
        {
            return objSearchWidgetColVisibleDAL.SWColVisibleSelectByVisible(clientId);
        }
        public void InsertUpdateSWColVisible(int SwId,bool country, bool state, bool city, bool facility, int clientid, string whocreated, string whoupdated)
        {
            objSearchWidgetColVisibleDAL.InsertUpdateSWColVisible(SwId,country, state, city, facility, clientid, whocreated, whoupdated);
        }

    }
}
