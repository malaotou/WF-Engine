using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Models
{
    public class WorkListRunTimeInfo
    {
        public WorkList WorkItem { get; set; }
        public ProcesssInstance processInstance { get; set; }

        public WFDefine WFDefine { get; set; }
        public Process Process { get; set; }
        public Activity NextActivity { get; set; }
        public Activity CurrentActivity { get; set; }

    }
}
