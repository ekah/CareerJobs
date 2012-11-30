using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_HrAccessBAL
    {
        Job_HrAccessDAL objHrAccessDAL = new Job_HrAccessDAL();

        public DataSet HrLoginSelectByClientIDByAll()
        {
            return objHrAccessDAL.HrLoginSelectByClientIDByAll();
        }
        public DataSet HrLoginSelectByClientId(int clientid)
        {
            return objHrAccessDAL.HrLoginSelectByClientID(clientid);
        }

        public void InsertUpdateHrLogin(int hid, string username, string password, int clientid, string whocreated, string whoupdated)
        {
            objHrAccessDAL.InsertUpdateHrLogin(hid, username, password, clientid, whocreated, whoupdated);
        }

        public DataSet HrLoginSelectByUserName(string username, int clientid)
        {
            return objHrAccessDAL.HrLoginSelectByUserName(username, clientid);
        }
        public DataSet HrLoginSelectByUserNameById(int hid,string username, int clientid)
        {
            return objHrAccessDAL.HrLoginSelectByUserNameById(hid,username, clientid);
        }
        public void DeleteHrLogin(int hid, int clientid)
        {
            objHrAccessDAL.DeleteHrLogin(hid, clientid);
        }
    }
}
