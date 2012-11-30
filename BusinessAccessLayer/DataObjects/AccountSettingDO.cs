using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class AccountSettingDO
    {
        public int LoginId { set; get; }

        public int CountryId { set; get; }

        public string MobileId { set; get; }

        public string EmailId { set; get; }

        public string Password { set; get; }

        public string Token { set; get; }

        public bool IsEmailActivated { set; get; }

        public bool IsEmailNotification { set; get; }
        
        public bool IsSMSNotification { set; get; }
    }
}
