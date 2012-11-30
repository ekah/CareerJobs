using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class ZipDailDO
    {
        public string Message { set; get; }

        public string ClientTransactionId { set; get; }

        public string TransactionToken { set; get; }

        public string Status { set; get; }

        public string ImageUrl { set; get; }
    }
}