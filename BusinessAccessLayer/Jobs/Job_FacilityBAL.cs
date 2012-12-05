using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;


namespace MedAppointments.BusinessAccessLayer
{

    public class Job_FacilityBAL
    {
        Job_FacilityDAL ObjFacilityDAL = new Job_FacilityDAL();

        public DataSet SelectFacility()
        {
            return ObjFacilityDAL.SelectFacility();
        }
        public DataSet SelectClient()
        {
            return ObjFacilityDAL.SelectClient();
        }
        public DataSet FacilitySelectByClientID(int clientid)
        {
            return ObjFacilityDAL.FacilitySelectByClientID(clientid);
        }
        public void InsertUpdateFacility(int facid, string facility, bool visibility, int clientid, string Whocreated, string Whoupdated)
        {
            ObjFacilityDAL.InsertUpdateFacility(facid, facility, visibility, clientid, Whocreated, Whoupdated);
        }
        public void InsertUpdateFacilityByClientId(int facid, string facility, bool visibility, int clientid, string Whocreated, string Whoupdated)
        {
            ObjFacilityDAL.InsertUpdateFacilityByClientId(facid, facility, visibility, clientid, Whocreated, Whoupdated);
        }
        public DataSet FacilitySelectByFacility(int clientid, string facility)
        {
            return ObjFacilityDAL.FacilitySelectByFacility(clientid, facility);
        }
        public DataSet FacilitySelectByFacid(int facid, int clientid, string facility)
        {
            return ObjFacilityDAL.FacilitySelectByFacid(facid, clientid, facility);
        }
        public void DeleteFacility(int facilityid, int clientid)
        {
            ObjFacilityDAL.DeleteFacility(facilityid, clientid);
        }


    }
}
