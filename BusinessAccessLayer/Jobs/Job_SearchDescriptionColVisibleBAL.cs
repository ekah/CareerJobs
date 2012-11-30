using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SearchDescriptionColVisibleBAL
    {
        Job_SearchDescriptionColVisibleDAL objSearchDescriptionColVisibleDAL = new Job_SearchDescriptionColVisibleDAL();

        public DataSet SDColVisibleSelectByVisibleAll()
        {
            return objSearchDescriptionColVisibleDAL.SDColVisibleSelectByVisibleAll();
        }
        public DataSet SDColVisibleSelectByVisible(int clientId)
        {
            return objSearchDescriptionColVisibleDAL.SDColVisibleSelectByVisible(clientId);
        }
        public void InsertUpdateSDColVisible(int SdId, bool jobid, bool jobtitle, bool facility, bool speciality, bool country, bool state, bool city, bool description, bool posteddate, int clientid, string whocreated, string whoupdated)
        {
            objSearchDescriptionColVisibleDAL.InsertUpdateSDColVisible(SdId,jobid, jobtitle, facility, speciality, country, state, city, description, posteddate, clientid, whocreated, whoupdated);
        }
    }
}
