using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_CandidateViewBAL
    {
        Job_CandidateViewDAL objCandidateViewDAL = new Job_CandidateViewDAL();

        public DataSet SelectCandidateByClientIdByAll()
        {
            return objCandidateViewDAL.SelectCandidateByClientIdByAll();
        }
        public DataSet SelectCandidateByClientId(int clientId)
        {
            return objCandidateViewDAL.SelectCandidateByClientId(clientId);
        }
        public void UpdateCandidateDetails(int aid, string hrstatus, string finalstatus, string notes)
        {
            objCandidateViewDAL.UpdateCandidateDetails(aid, hrstatus, finalstatus, notes);
        }
        public void DeleteCandidateDetailsById(int aid)
        {
            objCandidateViewDAL.DeleteCandidateDetailsById(aid);
        }
    }
}
