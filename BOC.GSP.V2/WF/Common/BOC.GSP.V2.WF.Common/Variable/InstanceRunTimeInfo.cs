using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    public class InstanceRunTimeInfo
    {
        public Guid ProcessId { get; set; }
        public Guid InstanceId { get; set; }
        public Guid WorkListId { get; set; }

        public List<NextActivity> NextAct { get; set; }
        public Guid CurrentActivityId { get; set; }
    }
}
