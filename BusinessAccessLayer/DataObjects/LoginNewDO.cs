using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class LoginNewDO
    {
        public int LoginId { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string MedAppId { set; get; }

        public int CountryId { set; get; }

        public string MobileId { set; get; }

        public string EmailId { set; get; }

        public string Password { set; get; }

        public bool IsDirect { set; get; }

        public bool IsActivated { set; get; }

        public bool IsEmailActivated { set; get; }

        public string TransactionToken { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? ModifiedOn { set; get; }

        public bool IsDeleted { set; get; }
    }
}