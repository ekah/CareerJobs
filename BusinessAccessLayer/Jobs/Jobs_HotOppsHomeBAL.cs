using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.DataAccessLayer;
using System.Data;

namespace MedAppointments.BusinessAccessLayer
{
    public class Jobs_HotOppsHomeBAL
    {
        Jobs_HotOppsHomeDAL objHotOppsHomeDAL = new Jobs_HotOppsHomeDAL();

        public DataSet SelectTopJobsByClientId(int clientid)
        {
            return objHotOppsHomeDAL.SelectTopJobsByClientId(clientid);
        }
    }
}
