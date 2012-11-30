using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class LandingPublishDO
    {
        public int PublishId { set; get; }

        public int AccountId { set; get; }

        public int AccountTypeId { set; get; }

        public int BannerId { set; get; }

        public int DefaultVersion { set; get; }

        public LandingDO Landing { set; get; }
    }
}
