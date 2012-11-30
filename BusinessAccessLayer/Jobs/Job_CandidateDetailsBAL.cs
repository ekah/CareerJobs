using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_CandidateDetailsBAL
    {
        Job_CandidateDetailsDAL objCandidateDetailsDAL = new Job_CandidateDetailsDAL();

        public DataSet SelectCandidateDetailsByAidClientId(int aid, int clientid)
        {
            return objCandidateDetailsDAL.SelectCandidateDetailsByAidClientId(aid, clientid);
        }
    }
}
