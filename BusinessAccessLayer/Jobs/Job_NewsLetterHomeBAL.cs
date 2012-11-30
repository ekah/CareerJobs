using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Job_NewsLetterHomeBAL
    {
        Job_NewsLetterHomeDAL objNewsLetterHomeDAL = new Job_NewsLetterHomeDAL();

        public DataSet GetNewsLetterByEmailClientId(string email, int clientid)
        {
            return objNewsLetterHomeDAL.GetNewsLetterByEmailClientId(email, clientid);
        }
        public void InsertNewsLetter(string name, string email, int clientid)
        {
            objNewsLetterHomeDAL.InsertNewsLetter(name, email, clientid);
        }
    }
}
