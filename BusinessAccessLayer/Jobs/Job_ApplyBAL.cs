using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_ApplyBAL
    {
        Job_ApplyDAL objApplyDAL = new Job_ApplyDAL();

        public void InsertApply(string jobid, string candidatename, string age, string sex, string permanentaddress, string email, string city, string district, string state, string country, string aboutus, string contactphone, string contactmobile, string besttime, string specialization, string experience, string highestqualification, string highestdegree, string currentemployer, string existingpay, string desiredpay, string willing, string uploadresume, int clientid)
        {
            objApplyDAL.InsertApply(jobid, candidatename, age, sex, permanentaddress, email, city, district, state, country, aboutus, contactphone, contactmobile, besttime, specialization, experience, highestqualification, highestdegree, currentemployer, existingpay, desiredpay, willing, uploadresume, clientid);
        }
    }
}
