using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class AccountTypeDO
    {
        public int AccountTypeId { set; get; }

        public string AccountTypeName { set; get; }

        public string Prefix { set; get; }

        public DateTime CreatedOn { set; get; }

        public bool IsDeleted { set; get; }
    }

    public enum AccountType { NoAccount = 0, Organization = 1, Service = 2, Doctor = 3, Patient = 4, MainAccount = 5 };
}
