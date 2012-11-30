using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SpecialityBAL
    {
        Job_SpecialityDAL ObjSpecialityDAL = new Job_SpecialityDAL();

        public DataSet SelectMasterSpeciality()
        {
            return ObjSpecialityDAL.SelectMasterSpeciality();
        }
        public DataSet SelectSpeciality()
        {
            return ObjSpecialityDAL.SelectSpeciality();
        }
        public DataSet SpecialitySelectByClientID(int clientid)
        {
            return ObjSpecialityDAL.SpecialitySelectByClientID(clientid);
        }
        public void InsertUpdateSpeciality(int spcid, int specialityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            ObjSpecialityDAL.InsertUpdateSpeciality(spcid, specialityid, visibility, clientid, whocreated, whoupdated);
        }
        public void InsertUpdateSpecialityByClientId(int spcid, int specialityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            ObjSpecialityDAL.InsertUpdateSpecialityByClientId(spcid, specialityid, visibility, clientid, whocreated, whoupdated);
        }
        public DataSet SpecialitySelectBySpeciality(int clientid, int specialityid)
        {
            return ObjSpecialityDAL.SpecialitySelectBySpeciality(clientid, specialityid);
        }
        public DataSet SpecialitySelectBySpcId(int spcid, int clientid, int specialityid)
        {
            return ObjSpecialityDAL.SpecialitySelectBySpcId(spcid, clientid, specialityid);
        }
        public void DeleteSpeciality(int specialityid, int clientid)
        {
            ObjSpecialityDAL.DeleteSpeciality(specialityid, clientid);
        }
    }
}
