using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class Job_ApplyDAL : Connection
    {
        public void InsertApply(string jobid, string candidatename, string age, string sex, string permanentaddress, string email, string city, string district, string state, string country, string aboutus, string contactphone, string contactmobile, string besttime, string specialization, string experience, string highestqualification, string highestdegree, string currentemployer, string existingpay, string desiredpay, string willing, string uploadresume, int clientid)
        {
            SqlParameter[] objprmArray = new SqlParameter[24];
            objprmArray[0] = new SqlParameter("@JobId", jobid);
            objprmArray[1] = new SqlParameter("@CandidateName", candidatename);
            objprmArray[2] = new SqlParameter("@Age", age);
            objprmArray[3] = new SqlParameter("@Sex", sex);
            objprmArray[4] = new SqlParameter("@PermanentAddress", permanentaddress);
            objprmArray[5] = new SqlParameter("@Email", email);
            objprmArray[6] = new SqlParameter("@City", city);
            objprmArray[7] = new SqlParameter("@District", district);
            objprmArray[8] = new SqlParameter("@State", state);
            objprmArray[9] = new SqlParameter("@Country", country);
            objprmArray[10] = new SqlParameter("@AboutUs", aboutus);
            objprmArray[11] = new SqlParameter("@ContactPhone", contactphone);
            objprmArray[12] = new SqlParameter("@ContactMobile", contactmobile);
            objprmArray[13] = new SqlParameter("@BestTime", besttime);
            objprmArray[14] = new SqlParameter("@Specialization", specialization);
            objprmArray[15] = new SqlParameter("@Experience", experience);
            objprmArray[16] = new SqlParameter("@HighestQualification", highestqualification);
            objprmArray[17] = new SqlParameter("@HighestDegree", highestdegree);
            objprmArray[18] = new SqlParameter("@CurrentEmployer", currentemployer);
            objprmArray[19] = new SqlParameter("@ExistingPay", existingpay);
            objprmArray[20] = new SqlParameter("@DesiredPay", desiredpay);
            objprmArray[21] = new SqlParameter("@Willing", willing);
            objprmArray[22] = new SqlParameter("@UploadResume", uploadresume);
            objprmArray[23] = new SqlParameter("@ClientId", clientid);

            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Job_InsertApply", objprmArray);

        }
    }
}
