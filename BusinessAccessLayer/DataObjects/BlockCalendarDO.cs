using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedAppointments.BusinessAccessLayer
{
    [Serializable]
    public partial class BlockCalendarDO
    {
        public int BlockId { set; get; }

        public int BlockTypeId { set; get; }

        public bool Type { set; get; }

        public int? DoctorId { set; get; }

        public int? ServiceId { set; get; }

        public int? DoctorTimingId { set; get; }
        
        public int? ServiceTimingId { set; get; }

        public DateTime BlockStart { set; get; }

        public DateTime BlockEnd { set; get; }

        public string Notes { set; get; }

        public DateTime CreatedOn { set; get; }

        public bool IsDeleted { set; get; }
    }
}
