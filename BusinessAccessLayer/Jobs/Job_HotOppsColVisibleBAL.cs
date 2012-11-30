using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_HotOppsColVisibleBAL
    {
        Job_HotOppsColVisibleDAL objHotOppsColVisibleDAL = new Job_HotOppsColVisibleDAL();

        public DataSet HOColVisibleSelectByVisibleByAll()
        {
            return objHotOppsColVisibleDAL.HOColVisibleSelectByVisibleByAll();
        }
        public DataSet HOColVisibleSelectByVisible(int clientId)
        {
            return objHotOppsColVisibleDAL.HOColVisibleSelectByVisible(clientId);
        }       
        public void InsertUpdateHOColVisible(int hid,bool country, bool state, bool city, bool facility, bool speciality, bool postdate, int clientid, string whocreated, string whoupdated)
        {
            objHotOppsColVisibleDAL.InsertUpdateHOColVisible(hid,country, state, city, facility, speciality, postdate, clientid, whocreated, whoupdated);
        }
        public DataSet ClientAlreadyExistsHO(int clientid)
        {
           return objHotOppsColVisibleDAL.ClientAlreadyExistsHO(clientid);
        }
    }
}
