using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class LoginDO
    {
        public int LoginId { set; get; }

        public string MobileId { set; get; }

        public string MedAppointmentId { set; get; }

        public string EmailId { set; get; }

        public string Password { set; get; }

        public AccountTypeDO AccountType { set; get; }

        public bool IsDirectAppointment { set; get; }

        public DateTime CreatedOn { set; get; }

        public bool IsDeleted { set; get; }
    }
}
