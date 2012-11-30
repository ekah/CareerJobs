using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_SearchResultsBAL
    {
        Job_SearchResultsDAL objSearchResultsDAL = new Job_SearchResultsDAL();

        public DataSet SearchResults(int clientid, string facility, string speciality, string country, string state, string city, string keyword)
        {
            return objSearchResultsDAL.SearchResults(clientid, facility, speciality, country,state,city, keyword);
        }
    }
}
