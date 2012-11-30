using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;


namespace MedAppointments.BusinessAccessLayer
{
    public class Job_LocationBAL
    {
        Job_LocationDAL objLocationDAL = new Job_LocationDAL();

        public DataSet SelectLocation()
        {
            return objLocationDAL.SelectLocation();
        }
        public DataSet SelectLocationByClientId(int clientid)
        {
            return objLocationDAL.SelectLocationByClientId(clientid);
        }
        public DataSet SelectMasterCountry()
        {
            return objLocationDAL.SelectMasterCountry();
        }
        public DataSet SelectMasterStateByCountryID(int countryid)
        {
            return objLocationDAL.SelectMasterStateByCountryID(countryid);
        }
        public DataSet SelectMasterCityByCountryStateID(int countryid, int stateid)
        {
            return objLocationDAL.SelectMasterCityByCountryStateID(countryid, stateid);
        }
        public DataSet LocationSelectByIds(int clientid, int countryid, int stateid, int cityId)
        {
            return objLocationDAL.LocationSelectByIds(clientid, countryid, stateid, cityId);
        }
        public DataSet LocationSelectByLId(int lid, int clientid ,int countryid, int stateid,int cityid)
        {
            return objLocationDAL.LocationSelectByLId(lid, clientid, countryid, stateid,cityid);
        }
        public void InsertUpdateLocation(int lid, int countryid, int stateid, int cityid, bool visibility, int clientid, string whocreated, string whoupdated)
        {
            objLocationDAL.InsertUpdateLocation(lid, countryid, stateid, cityid, visibility, clientid, whocreated, whoupdated);
        }
        public void DeleteLocation(int lid,int clientid)
        {
            objLocationDAL.DeleteLocation(lid,clientid);
        }
    }
}
