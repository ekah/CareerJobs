using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_JobsBAL
    {
        Job_JobsDAL objJobsDAL = new Job_JobsDAL();

        public DataSet SelectOrganization()
        {
            return objJobsDAL.SelectOrganization();
        }
        public DataSet SelectOrganizationBasedOnFacility()
        {
            return objJobsDAL.SelectOrganizationBasedOnFacility();
        }
        public DataSet SelectJob()
        {
            return objJobsDAL.SelectJob();
        }
        public DataSet JobSelectByClientID(int clientid,int did)
        {
            return objJobsDAL.JobSelectByClientID(clientid,did);
        }
        public DataSet FacilitySelectByClientIDVisible(int clientid)
        {
            return objJobsDAL.FacilitySelectByClientIDVisible(clientid);
        }
        public DataSet FacilitySelectByClientIDVisibleInJobs(int clientid)
        {
            return objJobsDAL.FacilitySelectByClientIDVisibleInJobs(clientid);
        }
        public DataSet SpecialitySelectByClientIDVisible(int clientid)
        {
            return objJobsDAL.SpecialitySelectByClientIDVisible(clientid);
        }
        public DataSet SpecialitySelectByClientIDVisibleInJobs(int clientid)
        {
            return objJobsDAL.SpecialitySelectByClientIDVisibleInJobs(clientid);
        }
        public DataSet CountrySelectByClientIDVisible(int clientid)
        {
            return objJobsDAL.CountrySelectByClientIDVisible(clientid);
        }
        public DataSet CountrySelectInStateByClientIDVisible(int clientid)
        {
            return objJobsDAL.CountrySelectInStateByClientIDVisible(clientid);
        }
        public DataSet StateSelectInStateByClientIDVisible(int clientid, string lid)
        {
            return objJobsDAL.StateSelectInStateByClientIDVisible(clientid, lid);
        }
        public DataSet StateSelectInStateByClientIDVisibleByAdmin(int clientid, int lid)
        {
            return objJobsDAL.StateSelectInStateByClientIDVisibleByAdmin(clientid, lid);
        }
        public DataSet CitySelectByClientIDCountryStateIDVisible(int clientid, string countryid, int stateid)
        {
            return objJobsDAL.CitySelectByClientIDCountryStateIDVisible(clientid, countryid, stateid);
        }
        public DataSet CitySelectByClientIDCountryStateIDVisibleByAdmin(int clientid, int countryid, int stateid)
        {
            return objJobsDAL.CitySelectByClientIDCountryStateIDVisibleByAdmin(clientid, countryid, stateid);
        }
        public DataSet SelectJobByJobId(string jobid, int clientid)
        {
            return objJobsDAL.SelectJobByJobId(jobid, clientid);
        }
        public void InsertUpdateJob(string jobid, string jobtitle, int facility, int speciality, int Location, string description, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            objJobsDAL.InsertUpdateJob(jobid, jobtitle, facility, speciality, Location, description, visibility, clientid, whocreated, whoupdated);
        }
        public void DeleteJobByClientId(int jid, int clientid)
        {
            objJobsDAL.DeleteJobByClientId(jid, clientid);
        }
        public DataSet SelectByHospitalByChar(string startchar)
        {
           return objJobsDAL.SelectByHospitalByChar(startchar);
        }
        public DataSet SelectBySpecialityByChar(string startchar)
        {
            return objJobsDAL.SelectBySpecialityByChar(startchar);
        }
        public DataSet SelectDepartmentByClient(int did)
        {
            return objJobsDAL.SelectDepartmentByClient(did);
        }
        public DataSet FindJobsAssociateWithLocation(int clientid, int lid)
        {
            return objJobsDAL.FindJobsAssociateWithLocation(clientid, lid);
        }
        public DataSet FindJobsAssociateWithFacility(int clientid, int facilityid)
        {
            return objJobsDAL.FindJobsAssociateWithFacility(clientid, facilityid);
        }
        public DataSet FindJobsAssociateWithSpeciality(int clientid, int specialityid)
        {
            return objJobsDAL.FindJobsAssociateWithSpeciality(clientid, specialityid);
        }
    }
}
